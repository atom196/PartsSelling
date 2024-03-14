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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PartsSelling.Forms
{
    public partial class PartsListForm : BaseFormClass
    {
        private Cart cart = new Cart();

        public PartsListForm()
        {
            InitializeComponent();

            if (UserData.RoleId == 3)
            {
                cmsParts.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PartsListForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM PartsListView", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgvParts.DataSource = dataTable;

                            List<string> suppliers = dataTable.AsEnumerable()
                                .Select(row => row.Field<string>("Поставщик"))
                                .Distinct()
                                .ToList();
                            suppliers.Insert(0, "Все поставщики");
                            cbFilter.DataSource = suppliers;
                            cbFilter.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Не удалось получить запчасти: {ex}");
                MessageBox.Show("Не удалось получить список запчастей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilter()
        {
            string searchText = tbSearch.Text.Trim();

            string selectedSupplier = cbFilter.SelectedIndex > 0 ? cbFilter.Text : null;

            string minPrice = mtbMin.Text;
            string maxPrice = mtbMax.Text;

            DataTable dataTable = (DataTable)dgvParts.DataSource;
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = string.Empty;

            // применение фильтров
            if (!string.IsNullOrEmpty(searchText))
            {
                dataView.RowFilter = string.Format("Название LIKE '%{0}%'", searchText);
            }

            if (!string.IsNullOrEmpty(selectedSupplier) && selectedSupplier != "Все поставщики")
            {
                if (dataView.RowFilter.Length > 0)
                {
                    dataView.RowFilter += string.Format(" AND Поставщик = '{0}'", selectedSupplier);
                }
                else
                {
                    dataView.RowFilter += string.Format("Поставщик = '{0}'", selectedSupplier);
                }
            }

            if (!string.IsNullOrEmpty(minPrice) && !string.IsNullOrEmpty(maxPrice))
            {
                int minPriceValue = int.Parse(minPrice);
                int maxPriceValue = int.Parse(maxPrice);

                if (dataView.RowFilter.Length > 0)
                {
                    dataView.RowFilter += string.Format(" AND Цена >= {0} AND Цена <= {1}", minPriceValue, maxPriceValue);
                }
                else
                {
                    dataView.RowFilter += string.Format("Цена >= {0} AND Цена <= {1}", minPriceValue, maxPriceValue);
                }
            }

            dgvParts.Refresh();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void mtbMin_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void mtbMax_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null)
            {
                int partId = Convert.ToInt32(dgvParts.CurrentRow.Cells[0].Value);
                string title = dgvParts.CurrentRow.Cells[1].Value.ToString();
                decimal price = Convert.ToDecimal(dgvParts.CurrentRow.Cells[3].Value);

                int quantityInStock = Convert.ToInt32(dgvParts.CurrentRow.Cells[5].Value);

                if (quantityInStock > 0)
                {
                    Part part = new Part
                    {
                        PartId = partId,
                        Title = title,
                        Price = price
                    };

                    cart.AddPart(part);
                }
                else
                {
                    MessageBox.Show("");
                    return;
                }
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(cart);
            cartForm.ShowDialog();

            PartsListForm_Load(sender, e);
            ApplyFilter();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null)
            {
                EditPartForm editForm = new EditPartForm
                {
                    PartId = Convert.ToInt32(dgvParts.CurrentRow.Cells[0].Value),
                    PartTitle = dgvParts.CurrentRow.Cells[1].Value.ToString(),
                    PartDescription = dgvParts.CurrentRow.Cells[2].Value.ToString(),
                    PartPrice = Convert.ToDecimal(dgvParts.CurrentRow.Cells[3].Value),
                    PartQuantity = Convert.ToInt32(dgvParts.CurrentRow.Cells[5].Value)
                };

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    PartsListForm_Load(sender, e);
                    ApplyFilter();
                }
            }
        }

        private void заказатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null)
            {
                OrderSupForm orderSupForm = new OrderSupForm
                {
                    PartTitle = dgvParts.CurrentRow.Cells[1].Value.ToString(),
                    PartSupplier = dgvParts.CurrentRow.Cells[4].Value.ToString(),
                    PartPrice = Convert.ToDecimal(dgvParts.CurrentRow.Cells[3].Value),
                    PartId = Convert.ToInt32(dgvParts.CurrentRow.Cells[0].Value)
                };

                if (orderSupForm.ShowDialog() == DialogResult.OK)
                {
                    PartsListForm_Load(sender, e);
                    ApplyFilter();
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // не реализованная форма
        }

        // Отображение контекстного меню на таблице
        private void dgvParts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentRow = e.RowIndex;
                _ = e.ColumnIndex;

                if (currentRow >= 0)
                {
                    dgvParts.Rows[currentRow].Selected = true;

                    Point point = dgvParts.PointToClient(Cursor.Position);

                    cmsParts.Show(dgvParts, point);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
