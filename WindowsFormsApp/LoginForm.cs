using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            var userlogin = inputLogin.Text;
            var userpassword = inputPassword.Text;

            //создается объект бд
            DB database = new DB();

            //создается таблица
            DataTable table = new DataTable();

            //создается адаптер
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //создается запрос из комманды и соединения с бд
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE login = @login AND password = @password;", database.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = userlogin;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = userpassword;

            //адаптером выполняется запрос
            adapter.SelectCommand = command;

            //результат запроса добавляется в таблицу
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void PasswordInput(object sender, EventArgs e)
        {

        }

        private void LoginInput(object sender, EventArgs e)
        {

        }
    }
}
