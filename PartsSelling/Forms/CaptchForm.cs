using PartsSelling.Classes;
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
using static System.Net.Mime.MediaTypeNames;

namespace PartsSelling.Forms
{
    public partial class CaptchForm : BaseFormClass
    {
        public bool isAnswerCorrect { get; set; }

        string[] images;
        string captchAnswer;

        public CaptchForm()
        {
            InitializeComponent();
            DownloadCaptch();
            ShowCaptcha();
        }

        private void ShowCaptcha()
        {
            try
            {
                var rand = new Random();
                captchAnswer = images[rand.Next(images.Length)];
                pbCaptch.ImageLocation = captchAnswer;

                captchAnswer = Path.GetFileNameWithoutExtension(captchAnswer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось отобразить каптчу.");
                Console.WriteLine($"Error : {ex}");
            }
        }

        private void DownloadCaptch()
        {
            try
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                images = Directory.GetFiles(Path.Combine(projectDirectory, "Images\\Captch\\"), "*.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось найти папку Captch.");
                Console.WriteLine($"Error : {ex}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCaptch.Text))
            {
                MessageBox.Show("Введите каптчу.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbCaptch.Text.Trim() == captchAnswer)
            {
                MessageBox.Show("Каптча успешно пройдена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isAnswerCorrect = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Каптча введена неверно.", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isAnswerCorrect = false;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
