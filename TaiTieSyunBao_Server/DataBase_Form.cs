using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TaiTieSyunBao_Server
{
    public partial class DataBase_Form : Form
    {
        public string DataBaseURL = "https://taitiesyunbao.firebaseio.com/";
        public string StorageURL = "https://api.imgur.com/3/image";
        public string clientID = "12cdcf756a9e13b";
        private Goods_Root goods = null;
        private AddGood_Form addGood_Form = null;
        public int nextID = 1;
        private Boolean imgChanged = false;
        

        public DataBase_Form()
        {
            InitializeComponent();
            goods_listView.Columns.Add("ID");
            goods_listView.Columns.Add("ImgurID");
            goods_listView.Columns.Add("品名");
            goods_listView.Columns.Add("價格");
            goods_listView.Columns.Add("庫存");
            goods_listView.Columns.Add("種類");
            goods_listView.Columns.Add("介紹");
            getGoods();
        }

        public void getGoods()
        {
            string jsonData = getJsonData("");
            goods = JsonConvert.DeserializeObject<Goods_Root>(jsonData);
            goods_listView.Items.Clear();
            if (goods == null) return;
            goods.Goods.Sort((x, y) => { return x.ID.CompareTo(y.ID); });
            foreach(Good g in goods.Goods)
            {
                nextID = (g.ID == nextID ? nextID + 1 : nextID);
                string[] row = { g.ID.ToString(), g.ImgurID, g.Name, g.Price.ToString(),
                                    g.Amount.ToString(), g.Kind , g.Info };
                ListViewItem listViewItem = new ListViewItem(row);
                goods_listView.Items.Add(listViewItem);
            }
            goods_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void setGoods(string method, int index, Good good)
        {
            if(method == "update")
            {
                using (var client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    client.Headers.Add("content-type", "application/json");
                    client.UploadString(DataBaseURL + "Goods/" + index.ToString() + "/.json",
                                    "PUT", JsonConvert.SerializeObject(good));
                }

            }
            else if(method == "new")
            {
                if (goods == null)
                    index = 0;
                else
                    index = goods.Goods.Count;
                using (var client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    client.Headers.Add("content-type", "application/json");
                    client.UploadString(DataBaseURL + "Goods/" + index.ToString() + "/.json",
                                    "PUT", JsonConvert.SerializeObject(good));
                }
            }
            else if(method == "delete")
            {

            }

            getGoods();
        }

        private string getJsonData(string path)
        {
            string response = null;

            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("content-type", "application/json");
                response = client.DownloadString(DataBaseURL + path + ".json");
            }
            return response;
        }
       

        private void goods_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (goods_listView.SelectedItems.Count > 0)
            {
                imgChanged = false;
                idUpdate_textBox.Text = goods_listView.SelectedItems[0].SubItems[0].Text;
                imgurID_textBox.Text = goods_listView.SelectedItems[0].SubItems[1].Text;
                nameUpdate_textBox.Text = goods_listView.SelectedItems[0].SubItems[2].Text;
                priceUpdate_textBox.Text = goods_listView.SelectedItems[0].SubItems[3].Text;
                amountUpdate_textBox.Text = goods_listView.SelectedItems[0].SubItems[4].Text;
                kindUpdate_comboBox.Text = goods_listView.SelectedItems[0].SubItems[5].Text;
                infoUpdate_textBox.Text = goods_listView.SelectedItems[0].SubItems[6].Text;
                try
                {
                    picUpdate_pictureBox.Image = Image.FromFile("Cache\\" + imgurID_textBox.Text + ",jpg");
                }
                catch
                {
                    picUpdate_pictureBox.Load("http://i.imgur.com/" + imgurID_textBox.Text + ".jpg");
                    picUpdate_pictureBox.Image.Save("Cache\\" + imgurID_textBox.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imgurID = imgurID_textBox.Text;
            if (imgChanged)
            {
                byte[] imgByteArray = ImageToBuffer(picUpdate_pictureBox.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                WebRequest request = WebRequest.Create(StorageURL);
                request.Method = "POST";
                request.Headers.Add("Authorization", "Client-ID " + clientID);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = imgByteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(imgByteArray, 0, imgByteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string response_JSON = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();

                JObject data = JObject.Parse(response_JSON);
                imgurID_textBox.Text = (string)data["data"]["id"];
            }

            Good good = new Good()
            {
                ID = Convert.ToInt32(idUpdate_textBox.Text),
                Name = nameUpdate_textBox.Text,
                Price = Convert.ToInt32(priceUpdate_textBox.Text),
                Amount = Convert.ToInt32(amountUpdate_textBox.Text),
                Kind = kindUpdate_comboBox.Text,
                Info = infoUpdate_textBox.Text,
                ImgurID = imgurID_textBox.Text
            };
            setGoods("update", getGoodIndex(good), good);
        }

        private int getGoodIndex(Good good)
        {
            int index = 0;
            foreach(Good g in goods.Goods)
            {
                if (g.ID == good.ID)
                    return index;
                index++;
            }
            return -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (addGood_Form == null)
            {
                addGood_Form = new AddGood_Form(this);
                addGood_Form.FormClosed += new FormClosedEventHandler(AddGood_Form_Closed);
                addGood_Form.Show();
            }
        }

        private void AddGood_Form_Closed(object sender, FormClosedEventArgs e)
        {
            addGood_Form = null;
        }

        private void picUpdate_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                imgChanged = true;
                imgurID_textBox.Text = "";
                picUpdate_pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        public byte[] ImageToBuffer(Image Image, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            if (Image == null) { return null; }
            byte[] data = null;
            using (MemoryStream oMemoryStream = new MemoryStream())
            {
                //建立副本
                using (Bitmap oBitmap = new Bitmap(Image))
                {
                    //儲存圖片到 MemoryStream 物件，並且指定儲存影像之格式
                    oBitmap.Save(oMemoryStream, imageFormat);
                    //設定資料流位置
                    oMemoryStream.Position = 0;
                    //設定 buffer 長度
                    data = new byte[oMemoryStream.Length];
                    //將資料寫入 buffer
                    oMemoryStream.Read(data, 0, Convert.ToInt32(oMemoryStream.Length));
                    //將所有緩衝區的資料寫入資料流
                    oMemoryStream.Flush();
                }
            }
            return data;
        }
    }
}
