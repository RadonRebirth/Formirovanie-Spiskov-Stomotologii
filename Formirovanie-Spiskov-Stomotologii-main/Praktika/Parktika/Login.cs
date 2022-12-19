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
    public partial class Login : Form
    {
        public string user; 

        private const string FileName = "authentication.txt"; // Файл для сохранения данных
        public Login()
        {
            
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e) // Обработка нажатия на кнопку
        {
            Authentication();
        }

        private void Authentication() // Проверка на существование списка пользователей
        {
            if (!File.Exists(FileName))
            {
                MessageBox.Show("Файл не существует.");

                using (StreamWriter Write = new StreamWriter(FileName, false, Encoding.Default)) // создание списка пользователей с стандартным логином,паролем для администратора
                {
                    Write.Write("admin;admin;1\n");
                }

                MessageBox.Show("Файл создан.");
            }
            else
            {
                if (loginField.Text != "" && passField.Text != "") // Проверка на наличие текста в полях
                {
                    CheckAccessRight();
                }
                else
                {
                    MessageBox.Show("Необходимо заполнить все поля авторизации.");
                }
            }
        }

        private void CheckAccessRight() // Проверка пользователя с списком
        {
            Authority NewAuthority = new Authority(FileName, loginField.Text, passField.Text);

            var X = NewAuthority.IncorrectInput();

            if (X.Count() != 0)
            {
                foreach (var Row in X)
                {
                    if (Row.Role == 1)
                    {
                        MessageBox.Show($"Вход под админом ({Row.User})."); // Авторизация под администратора
                        AdminMenu frA = new AdminMenu();
                        frA.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Вход под пользователем {Row.User}."); // Авторизация под обычным пользователем
                        List frm = new List();
                        user = loginField.Text; 
                        frm.user = user; // Передача логина пользователя в следующую форму
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            else // Вывод неверных данных и регистрация пользователя
            {
                MessageBox.Show("Неверный логин или пароль. Повторите вход.");
               DialogResult dialogResult = MessageBox.Show("Не хотите зарегистрировть данные?", "Регистрация", MessageBoxButtons.YesNo); // Появление системного вопроса о регистрации
                if (dialogResult == DialogResult.Yes)
                {
                    using (StreamWriter Write = new StreamWriter(FileName, true, Encoding.Default)) // Запись данных нового пользователя в список
                    {
                        Write.Write(loginField.Text+";"+passField.Text+";0\n");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                }
                
            }
        }
 
    }

    public class Authority // Проверка данных
    {
        private readonly string _FileName;

        private readonly string _Login;

        private readonly string _Password;

        public Authority(string FileName, string Login, string Password)
        {
            this._FileName = FileName;

            this._Login = Login;

            this._Password = Password;
        }

        public List<Authentication> IncorrectInput() 
        {
            string[] Data = File.ReadAllLines(_FileName);

            List<Authentication> Lst = new List<Authentication>();

            for (int i = 0; i < Data.Length; i++) // цикл для получения данных 
            {
                Authentication Auth = new Authentication();

                string[] Row = Data[i].Split(';'); // Получение логина,пароля и роли из строки путём разделения знаком ; 

                Auth.User = Row[0];

                Auth.Password = Row[1];

                Auth.Role = Convert.ToInt32(Row[2]);

                Lst.Add(Auth);
            }

            return Lst.Where(w => w.User == _Login && w.Password == _Password).ToList();
        }
    }

    public struct Authentication // создание структуры авторизации
    {
        public string User { get; set; }

        public string Password { get; set; }

        public int Role { get; set; }
    }
}