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
	public partial class Form1: Form
	{
        public DataBase_Form dataBase_Form = null;
        public string DataBaseURL = "https://taitiesyunbao.firebaseio.com/";
        private string API_KEY = "AIzaSyCfhtJllOC2qsMTmQvqeUjHnkOJKmCew1E";
        private string ACOUNT_EMAIL = "james35022000.cs03@g2.nctu.edu.tw";
        private string ACOUNT_PASSWORD = "jack841008";
        public string ID_TOKEN = "";
        private Orders_Root orders_Root = new Orders_Root();

        public Form1()
		{
			InitializeComponent();
            orders_Root.Orders = new List<Order>();
            order_listView.Columns.Add("UID");
            order_listView.Columns.Add("Key");

            good_listView.Columns.Add("ID");
            good_listView.Columns.Add("Name");
            good_listView.Columns.Add("Amount");
            good_listView.Columns.Add("MaxAmount");
            StreamingRESTApi();
        }

        private void dataBaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataBase_Form == null)
            {
                dataBase_Form = new DataBase_Form(this);
                dataBase_Form.FormClosed += new FormClosedEventHandler(DataBase_Form_Closed);
                dataBase_Form.Show();
            }
        }

        private void DataBase_Form_Closed(object sender, FormClosedEventArgs e)
        {
            dataBase_Form = null;
        }

        private void StreamingRESTApi()
        {
            Uri uri = new Uri(DataBaseURL + "Orders/.json");
            using (WebClient client = new WebClient())
            {
                connect_toolStripStatusLabel.Text = "Disconnect";
                connect_toolStripStatusLabel.ForeColor = Color.Red;
                client.OpenReadCompleted += new OpenReadCompletedEventHandler(onReadCompletedEvent);
                client.OpenReadAsync(uri);
            }
        }

        private void onReadCompletedEvent(object sender, OpenReadCompletedEventArgs args)
        {
            Stream stream = null;
            StreamReader streamReader = null;
            stream = (Stream)args.Result;
            streamReader = new StreamReader(stream);
            var serializer = new JsonSerializer();
            var jsonObject = serializer.Deserialize(new JsonTextReader(streamReader));
            string jsonStr = jsonObject.ToString();
            Dictionary<string, object> values;
            try
            {
                values = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonStr);
                orders_Root.Orders = new List<Order>();
                foreach (var value in values)
                {
                    JObject data = JObject.Parse(JObject.Parse(jsonStr)[value.Key].ToString());
                    Order order = JsonConvert.DeserializeObject<Order>(JsonConvert.SerializeObject(data));
                    orders_Root.Orders.Add(order);
                }

                using (var client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    client.Headers.Add("content-type", "application/json");
                    client.UploadString(DataBaseURL + "/.json",
                                    "PATCH", JsonConvert.SerializeObject(orders_Root));
                }
            }
            catch
            {
                orders_Root = JsonConvert.DeserializeObject<Orders_Root>("{\"Orders\":" + jsonStr + "}");
            }

            connect_toolStripStatusLabel.Text = "Connect";
            connect_toolStripStatusLabel.ForeColor = Color.Green;
            setOrderList();

            try
            {
                Uri uri = new Uri(DataBaseURL + "Orders/.json");
                using (WebClient client = new WebClient())
                {
                    client.OpenReadCompleted += new OpenReadCompletedEventHandler(onReadCompletedEvent);
                    client.OpenReadAsync(uri);
                }
            }
            catch
            {
                connect_toolStripStatusLabel.Text = "Disconnect";
                connect_toolStripStatusLabel.ForeColor = Color.Red;
            }


            if (stream != null)
                stream.Close();
            if (streamReader != null)
                streamReader.Close();
        }

        private void setOrderList()
        {
            foreach (Order o in orders_Root.Orders)
            {
                string[] row = { o.UID, o.Key };
                bool exist = false;
                foreach(ListViewItem itemRow in order_listView.Items)
                {
                    if (itemRow.SubItems[1].Text.Equals(o.Key))
                        exist = true;
                }
                if (!exist)
                {
                    ListViewItem listViewItem = new ListViewItem(row);
                    order_listView.Items.Add(listViewItem);
                    order_listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }
        
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void signIn()
        {
            string Url = "https://www.googleapis.com/identitytoolkit/v3/relyingparty/verifyPassword?key=" + API_KEY;
            using (var client = new WebClient())
            {
                string response;
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("content-type", "application/json");
                response = client.UploadString(Url, "{\"email\":\"" + ACOUNT_EMAIL + 
                                                    "\",\"password\":\"" + ACOUNT_PASSWORD +
                                                    "\",\"returnSecureToken\":true}");
                JObject data = JObject.Parse(response);
                string token = JsonConvert.SerializeObject(data["idToken"]);
                ID_TOKEN = token.Split('\"')[1];
            }
        }
    }
}
