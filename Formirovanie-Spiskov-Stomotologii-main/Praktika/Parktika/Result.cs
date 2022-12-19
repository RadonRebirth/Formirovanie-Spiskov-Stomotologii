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
        public string usluga; // Инициализация переменных
        public string user;
        public string spisok;
        public string FileName = "2.txt"; // Создание файла для хранения списка зарегистрированных на услуги пользователей

        private void Result_Load(object sender, EventArgs e)
        {
            label1.Text = "Пользователь "+user+" был зарегистрирован на услугу\n" + usluga; // замента текста в зависимости от выбранной услуги
            spisok = "Пользователь " + user + " : " + usluga;  // замена текста для списка
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FileName)) // Проверка на существование файла
            {
                MessageBox.Show("Файл не существует.");

                using (StreamWriter Write = new StreamWriter(FileName, true, Encoding.Unicode)) // Создание файла и запись в него переменной
                {
                    Write.WriteLine(spisok);
                }

                MessageBox.Show("Файл создан.");
            }
            else
            {
                using (StreamWriter Write = new StreamWriter(FileName, true, Encoding.Unicode)) // Запись переменной, даже если список создан
                {
                    Write.WriteLine(spisok);
                }
            }
            Application.Exit(); // Выход из программы
        }
    }
}
