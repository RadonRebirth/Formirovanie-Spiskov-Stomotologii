using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class List : Form
    {
        public string user;
        public List()
        {
            InitializeComponent();
        }
        public string usluga;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            usluga = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }
        private void List_Load(object sender, EventArgs e)
        {
            string s1;
            StreamReader sR = new StreamReader("1.txt");
            comboBox1.BeginUpdate();
            while ((s1 = sR.ReadLine()) != null)
            {
                comboBox1.Items.Add(s1);
            }
            sR.Close();
            comboBox1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                usluga = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                Result frm = new Result();
                frm.usluga = usluga;
                frm.user = user;
                frm.Show();
            }
            else if (comboBox1.SelectedIndex < 1)
            {
                MessageBox.Show("Выберите услугу");
            }
        }
    }
}
