using PartsSelling.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartsSelling.Forms
{
    public partial class OrderSupForm : BaseFormClass
    {
        private decimal partPrice;
        private int partId;
        private int supplierId;

        public OrderSupForm()
        {
            InitializeComponent();
        }

        public string PartTitle
        {
            get { return tbTitle.Text; }
            set { tbTitle.Text = value; }
        }

        public string PartSupplier
        {
            get { return tbSupplier.Text; }
            set 
            { 
                tbSupplier.Text = value;
                GetSupplierIdByName(value);
            }
        }

        public decimal PartPrice
        {
            get { return partPrice; }
            set
            {
                partPrice = value;
                UpdateTotalPrice();
            }
        }

        public int PartId
        {
            get { return partId; }
            set { partId = value; }
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
            SaveOrder();
            this.Close();
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = PartPrice * nudQuantity.Value;
            lblTotalSum.Text = totalPrice.ToString("C");
        }

        private void GetSupplierIdByName(string supplierName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT supplier_id FROM suppliers WHERE contact_name = @supplierName", connection))
                    {
                        command.Parameters.AddWithValue("@supplierName", supplierName);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            supplierId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Не удалось получить получить id поставщика: {ex.Message}");
                MessageBox.Show("Не удалось получить получить id поставщика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveOrder()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    DateTime orderDate = DateTime.Now;
                    int supOrderId;

                    // Вставка данных в таблицу supplier_orders и получение sup_order_id
                    using (SqlCommand command = new SqlCommand("INSERT INTO supplier_orders (supplier_id, order_date) OUTPUT INSERTED.sup_order_id VALUES (@supplierId, @orderDate)", connection))
                    {
                        command.Parameters.AddWithValue("@supplierId", supplierId);
                        command.Parameters.AddWithValue("@orderDate", orderDate);
                        supOrderId = (int)command.ExecuteScalar();
                    }

                    // Вставка данных в таблицу sup_order_details
                    using (SqlCommand command = new SqlCommand("INSERT INTO sup_order_details (sup_order_id, part_id, quantity) VALUES (@supOrderId, @partId, @quantity)", connection))
                    {
                        command.Parameters.AddWithValue("@supOrderId", supOrderId);
                        command.Parameters.AddWithValue("@partId", PartId);
                        command.Parameters.AddWithValue("@quantity", nudQuantity.Value);

                        command.ExecuteNonQuery();
                    }

                    // Обновление данных в таблице parts
                    using (SqlCommand command = new SqlCommand("UPDATE parts SET quantity_in_stock = quantity_in_stock + @quantity WHERE part_id = @partId", connection))
                    {
                        command.Parameters.AddWithValue("@quantity", nudQuantity.Value);
                        command.Parameters.AddWithValue("@partId", PartId);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Заказ оформлен успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Не удалось оформить заказ: {ex.Message}");
                MessageBox.Show("Не удалось оформить заказ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
