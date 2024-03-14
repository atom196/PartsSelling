using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data.SqlClient;
using PartsSelling.Classes;
using PartsSelling.Forms;
using System.IO;

namespace PartsSelling
{
    public partial class LoginForm : BaseFormClass
    {
        private int loginAttempts = 0;

        public LoginForm()
        {
            InitializeComponent();
            CheckCredentials();
        }

        // автозаполнение учетных данных
        private void CheckCredentials()
        {
            if (File.Exists("credentials.txt"))
            {
                try
                {
                    string data = File.ReadAllText("credentials.txt");
                    string[] credentials = data.Split(',');

                    if (credentials.Length == 2)
                    {
                        string login = credentials[0];
                        string password = credentials[1];

                        tbLogin.Text = login;
                        tbPassword.Text = password;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Не удалось автоматически заполнить учетные данные: {ex.Message}");
                    MessageBox.Show("Не удалось автоматически заполнить учетные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Заполните все поля.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string login = tbLogin.Text.Trim();
            string password = tbPassword.Text.Trim();

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("LoginProc", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows && reader.Read())
                            {
                                UserData user = new UserData(reader);

                                // приветствие пользователя
                                string welcome;
                                if (DateTime.Now.Hour < 12)
                                {
                                    welcome = "Доброе утро";
                                }
                                else if (DateTime.Now.Hour < 17)
                                {
                                    welcome = "Добрый день";
                                }
                                else
                                {
                                    welcome = "Добрый вечер";
                                }

                                MessageBox.Show($"{welcome}, {UserData.LastName} {UserData.FirstName} {UserData.MiddleName}!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // сохранение учетных данных
                                if (btnRemember.BackColor == Color.FromArgb(242, 172, 41))
                                {
                                    try
                                    {
                                        string data = $"{login},{password}";
                                        File.WriteAllText("credentials.txt", data);
                                    }
                                    catch (Exception ex)
                                    {
                                        Debug.WriteLine($"Не удалось запомнить учетные данные: {ex.Message}");
                                        MessageBox.Show("Не удалось запомнить учетные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

                                PartsListForm partsListForm = new PartsListForm();
                                partsListForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
                                loginAttempts++;

                                // блокировка ввода на 10 сек.
                                if (loginAttempts > 2)
                                {
                                    CaptchForm captchForm = new CaptchForm();
                                    captchForm.ShowDialog();

                                    if (captchForm.isAnswerCorrect == false)
                                    {
                                        MessageBox.Show("Возможность входа заблокирована на 10 сек.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        DisableUserInput();
                                        await Task.Delay(10000);
                                        EnableUserInput();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка входа: {ex}");
                MessageBox.Show("Не удалось получить доступ к базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EnableUserInput()
        {
            tbLogin.Enabled = true;
            tbPassword.Enabled = true;
            btnLogin.Enabled = true;
        }

        private void DisableUserInput()
        {
            tbLogin.Enabled = false;
            tbPassword.Enabled = false;
            btnLogin.Enabled = false;
        }

        // флаг, на случай, когда необходимо запомнить учетные данные пользователя
        private void btnRemember_Click(object sender, EventArgs e)
        {
            if (btnRemember.BackColor == Color.Transparent)
            {
                btnRemember.BackColor = Color.FromArgb(242, 172, 41);
            }
            else
            {
                btnRemember.BackColor = Color.Transparent;
            }
        }
    }
}
