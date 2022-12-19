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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Метод при изменении выбранно элемента списка
        {
            usluga = comboBox1.Items[comboBox1.SelectedIndex].ToString(); // Присваивание переменной строку выбранного элемента из списка
        }
        private void List_Load(object sender, EventArgs e)
        {
            // Чтение строк из текстового файла
            string s1;
            StreamReader sR = new StreamReader("1.txt");
            comboBox1.BeginUpdate();
            while ((s1 = sR.ReadLine()) != null)
            {
                comboBox1.Items.Add(s1);// Добавление в список элементов из текстового файла
            }
            sR.Close();
            comboBox1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e) // Обработка нажатия на кнопку
        {
            if (comboBox1.SelectedIndex > -1) // Обработка действия, если был выбран не начальный элемент списка
            {
                usluga = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                Result frm = new Result();
                frm.usluga = usluga; // Передача переменных из данной формы в следующую
                frm.user = user;
                frm.Show();
            }
            else if (comboBox1.SelectedIndex < 1) // Обработка действия, если был выбран начальный элемент списка
            {
                MessageBox.Show("Выберите услугу");
            }
        }
    }
}
