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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        public string usluga;
        public string user;
        public string spisok;
        public string FileName = "2.txt";
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Result_Load(object sender, EventArgs e)
        {
            label1.Text = "Пользователь "+user+" был зарегистрирован на услугу\n" + usluga;
            spisok = "Пользователь " + user + " : " + usluga; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FileName))
            {
                MessageBox.Show("Файл не существует.");

                using (StreamWriter Write = new StreamWriter(FileName, true, Encoding.Unicode))
                {
                    Write.WriteLine(spisok);
                }

                MessageBox.Show("Файл создан.");
            }
            else
            {
                using (StreamWriter Write = new StreamWriter(FileName, true, Encoding.Unicode))
                {
                    Write.WriteLine(spisok);
                }
            }
            Application.Exit();
        }
    }
}
