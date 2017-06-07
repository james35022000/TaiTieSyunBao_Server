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
        private Orders_Root orders_Root = new Orders_Root();

        public Form1()
		{
			InitializeComponent();
            orders_Root.Orders = new List<Order>();
		}

        private void dataBaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataBase_Form == null)
            {
                dataBase_Form = new DataBase_Form();
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
            
            if (stream != null)
                stream.Close();
            if (streamReader != null)
                streamReader.Close();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamingRESTApi();
        }
    }
}
