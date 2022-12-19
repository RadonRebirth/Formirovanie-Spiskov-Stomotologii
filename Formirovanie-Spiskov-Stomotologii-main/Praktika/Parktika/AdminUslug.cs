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
        public string usluga; // Инициализация перменных
        public string user;
        public string FileName = "1.txt"; // Указание ссылки на файл услуг

        private void Admin_Load(object sender, EventArgs e)
        {
            string s1;
            StreamReader sR = new StreamReader(FileName); // Чтение строк из файла
            listBox1.BeginUpdate();
            while ((s1 = sR.ReadLine()) != null)// Запись в список услуги из файла
            {
                listBox1.Items.Add(s1);
            }
            sR.Close();
            listBox1.EndUpdate();
        }

        private void buttonAccept_Click(object sender, EventArgs e) // Обработка кнопки 
        {
            
            Application.Exit(); // Заверешение работы приложения
        }

        private void buttonDelete_Click(object sender, EventArgs e) // Обработка кнопки удаления элемента из списка и файла
        {
            string textToRight = listBox1.SelectedItem.ToString();
            
            var item = (listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex); // удаление выбранного элемента из списка
            using (var sr = new StreamReader("1.txt")) 
            using (var sw = new StreamWriter("temp.txt",false,Encoding.Unicode)) // Перезапись списка из файла во временный файл
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
            File.Delete("1.txt"); // Удаление старого списка
            File.Move("temp.txt", "1.txt"); // Запись нового списка из временного файла в основной
        }

        private void buttonBack_Click(object sender, EventArgs e) // Обработка кнопки возврата на прошлое окно
        {
            AdminMenu frm = new AdminMenu();
            frm.Show();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e) // Обработка кнопки добавление элемента в список и файл
        {
            listBox1.Items.Add(textBox1.Text);
            using (StreamWriter Write = new StreamWriter(FileName, true, Encoding.Unicode))
            {
                Write.WriteLine(textBox1.Text+"\n");
            }
        }
    }
}
