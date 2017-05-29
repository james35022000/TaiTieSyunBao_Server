using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaiTieSyunBao_Server
{
	public partial class Form1: Form
	{
        public DataBase_Form dataBase_Form = null;

        public Form1()
		{
			InitializeComponent();
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

    }
}
