namespace PartsSelling.Forms
{
    partial class CartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.cbPickUpPoint = new System.Windows.Forms.ComboBox();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblTotalSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPickUpPoint
            // 
            this.cbPickUpPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPickUpPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPickUpPoint.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F);
            this.cbPickUpPoint.FormattingEnabled = true;
            this.cbPickUpPoint.Location = new System.Drawing.Point(508, 132);
            this.cbPickUpPoint.Name = "cbPickUpPoint";
            this.cbPickUpPoint.Size = new System.Drawing.Size(310, 42);
            this.cbPickUpPoint.TabIndex = 1;
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.BackColor = System.Drawing.Color.Transparent;
            this.btnRemovePart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePart.FlatAppearance.BorderSize = 0;
            this.btnRemovePart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemovePart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRemovePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePart.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePart.ForeColor = System.Drawing.Color.White;
            this.btnRemovePart.Location = new System.Drawing.Point(502, 563);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(322, 50);
            this.btnRemovePart.TabIndex = 11;
            this.btnRemovePart.Text = "УДАЛИТЬ ТОВАР";
            this.btnRemovePart.UseVisualStyleBackColor = false;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(503, 501);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(322, 50);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "ОФОРМИТЬ ЗАКАЗ";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(749, 19);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 34);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(792, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(115)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(115)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.dgvCart.Location = new System.Drawing.Point(39, 98);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.Size = new System.Drawing.Size(407, 511);
            this.dgvCart.TabIndex = 16;
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalSum.Font = new System.Drawing.Font("Myriad Pro", 18F);
            this.lblTotalSum.Location = new System.Drawing.Point(497, 267);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(77, 29);
            this.lblTotalSum.TabIndex = 17;
            this.lblTotalSum.Text = "сумма";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 650);
            this.Controls.Add(this.lblTotalSum);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemovePart);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cbPickUpPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CartForm";
            this.Text = "Корзина";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPickUpPoint;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblTotalSum;
    }
}