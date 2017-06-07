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
    public partial class AddGood_Form : Form
    {
        private DataBase_Form dataBase_Form;
        public AddGood_Form(DataBase_Form d)
        {
            InitializeComponent();
            this.dataBase_Form = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isComplete())
            {
                DialogResult key = MessageBox.Show("新增\" " + nameAdd_textBox.Text +
                    " \"至商品?", "確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (key == DialogResult.Yes)
                {
                    Good good = new Good()
                    {
                        ID = dataBase_Form.nextID,
                        Name = nameAdd_textBox.Text,
                        Price = Convert.ToInt32(priceAdd_textBox.Text),
                        Amount = Convert.ToInt32(amountAdd_textBox.Text),
                        Kind = kindAdd_comboBox.Text,
                        Info = infoAdd_textBox.Text,
                        ImgurID = imgurID_textBox.Text
                    };
                    dataBase_Form.setGoods("new", 0, good);
                    this.Close();
                }      
            }
            else
            {
                
            }
        }

        private Boolean isComplete()
        {
            if (nameAdd_textBox.Text == "" || priceAdd_textBox.Text == "" || amountAdd_textBox.Text == ""
                || kindAdd_comboBox.Text == "" || infoAdd_textBox.Text == "" || imgurID_textBox.Text == "")
                return false;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                picAdd_pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imgByteArray = dataBase_Form.ImageToBuffer(picAdd_pictureBox.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                WebRequest request = WebRequest.Create(dataBase_Form.StorageURL);
                request.Method = "POST";
                request.Headers.Add("Authorization", "Client-ID " + dataBase_Form.clientID);
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
            catch
            {
                MessageBox.Show("Something Wrong~", "Error");
            }
        }
    }
}
