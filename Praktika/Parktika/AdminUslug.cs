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
    public partial class AdminUslug : Form
    {
        public AdminUslug()
        {
            InitializeComponent();
        }
        public string usluga;
        public string user;
        public string FileName = "1.txt";

        private void Admin_Load(object sender, EventArgs e)
        {
            string s1;
            StreamReader sR = new StreamReader(FileName);
            listBox1.BeginUpdate();
            while ((s1 = sR.ReadLine()) != null)
            {
                listBox1.Items.Add(s1);
            }
            sR.Close();
            listBox1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textToRight = listBox1.SelectedItem.ToString();
            
            var item = (listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            using (var sr = new StreamReader("1.txt")) 
            using (var sw = new StreamWriter("temp.txt",false,Encoding.Unicode))
            { 
                    if (!listBox1.Items.Contains(textToRight))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != textToRight)
                            sw.WriteLine(line);
                    }
                }
            }
            File.Delete("1.txt");
            File.Move("temp.txt", "1.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMenu frm = new AdminMenu();
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            using (StreamWriter Write = new StreamWriter(FileName, true, Encoding.Unicode))
            {
                Write.WriteLine(textBox1.Text+"\n");
            }
        }
    }
}
