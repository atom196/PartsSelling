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
    public partial class CartForm : BaseFormClass
    {
        private Cart cart;

        public CartForm(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            try
            {
                //fill combobox
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM PickUpView", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            cbPickUpPoint.DisplayMember = "address_city";
                            cbPickUpPoint.ValueMember = "pickup_point_id";
                            cbPickUpPoint.DataSource = dataTable;
                        }
                    }
                }

                //fill cart
                dgvCart.DataSource = cart.GetParts();
                UpdateTotalSum();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка на форме корзины: {ex}");
                MessageBox.Show("Не удалось загрузить корзину/пункты выдачи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCart.CurrentRow != null)
                {
                    int partId = Convert.ToInt32(dgvCart.CurrentRow.Cells[0].Value);

                    Part part = cart.GetParts().FirstOrDefault(p => p.PartId == partId);

                    if (part != null)
                    {
                        cart.RemovePart(part);

                        dgvCart.DataSource = null;
                        dgvCart.DataSource = cart.GetParts();

                        UpdateTotalSum();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Не удалось удалить товар из корзины: {ex}");
                MessageBox.Show("Не удалось удалить товар из корзины.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalSum()
        {
            decimal totalSum = cart.GetTotalSum();
            lblTotalSum.Text = $"{totalSum:C}";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cart.GetParts().Count == 0)
            {
                MessageBox.Show("Ваша корзина пуста. Добавьте товары, чтобы оформить заказ.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbPickUpPoint.SelectedValue is null)
            {
                MessageBox.Show("Пожалуйста выберите пункт выдачи.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int user_id = UserData.UserId;

                int pickupPointId = (int)cbPickUpPoint.SelectedValue;

                int orderId;

                // запись заказа в таблицу orders
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO orders (user_id, pickup_point_id) OUTPUT INSERTED.order_id VALUES (@userId, @pickupPointId)", connection))
                    {
                        command.Parameters.AddWithValue("@userId", user_id);
                        command.Parameters.AddWithValue("@pickupPointId", pickupPointId);
                        orderId = (int)command.ExecuteScalar();
                    }
                }

                foreach (Part part in cart.GetParts())
                {
                    // запись в таблицу order_details: заказ - запчасть количество
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("INSERT INTO order_details (order_id, part_id, quantity) VALUES (@orderId, @partId, @quantity)", connection))
                        {
                            command.Parameters.AddWithValue("@orderId", orderId);
                            command.Parameters.AddWithValue("@partId", part.PartId);
                            command.Parameters.AddWithValue("@quantity", part.Quantity);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                cart.Clear();

                MessageBox.Show("Заказ успешно оформлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка при оформлении заказа: {ex}");
                MessageBox.Show("Произошла ошибка при оформлении заказа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
