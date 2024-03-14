using PartsSelling.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartsSelling.Forms
{
    public partial class EditPartForm : BaseFormClass
    {
        private int partId;
        public EditPartForm()
        {
            InitializeComponent();
        }
        public int PartId
        {
            set { partId = value; }
        }

        public string PartTitle
        {
            get { return tbTitle.Text; }
            set { tbTitle.Text = value; }
        }

        public string PartDescription
        {
            get { return tbDescription.Text; }
            set { tbDescription.Text = value; }
        }

        public decimal PartPrice
        {
            get { return nudPrice.Value; }
            set { nudPrice.Value = value; }
        }

        public int PartQuantity
        {
            get { return int.Parse(mtbQuantity.Text); }
            set { mtbQuantity.Text = value.ToString(); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UPDATE parts SET title = @title, description = @description, price = @price, quantity_in_stock = @quantity WHERE part_id = @partId", connection))
                    {
                        command.Parameters.AddWithValue("@title", PartTitle);
                        command.Parameters.AddWithValue("@description", PartDescription);
                        command.Parameters.AddWithValue("@price", PartPrice);
                        command.Parameters.AddWithValue("@quantity", PartQuantity);
                        command.Parameters.AddWithValue("@partId", partId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные о запчасти успешно обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Не удалось обновить данные о запчасти.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении данных о запчасти: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
