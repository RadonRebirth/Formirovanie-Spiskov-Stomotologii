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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }
        private void buttonUslug_Click(object sender, EventArgs e) // Обработка нажатия на кнопку для редактирования списка услуг
        {
            AdminUslug frm = new AdminUslug();
            frm.Show();
            this.Hide();
        }
        private void buttonUsers_Click(object sender, EventArgs e) // Обработка нажатия на кнопку для редактирования списка пользователей с услугами
        {
            Admin frm = new Admin();
            frm.Show();
            this.Hide();
        }
    }
}