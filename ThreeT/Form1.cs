using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Format obj = new Format();
        Logic l1  = new Logic();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Logic.CreateTable();
            MessageBox.Show("Table has been created");
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            //int number;
            //if (int.TryParse(textBox1_id, out number))
            //{
            //    int a = Convert.ToInt32(Textbox.text);
            //}
            obj.id = Convert.ToString(textBox1_id);
            obj.name = Convert.ToString(textBox2_name);
            obj.email = Convert.ToString(textBox3_email);

            Logic.InsertRecord(obj);
            MessageBox.Show("Records have been inserted");
        }
    }
}
