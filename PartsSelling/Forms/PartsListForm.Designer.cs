namespace PartsSelling.Forms
{
    partial class PartsListForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsListForm));
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.mtbMax = new System.Windows.Forms.MaskedTextBox();
            this.mtbMin = new System.Windows.Forms.MaskedTextBox();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.cmsParts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.cmsParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F);
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(26, 249);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(310, 42);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(23, 145);
            this.tbSearch.MaxLength = 20;
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(315, 40);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(992, 17);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 34);
            this.btnMinimize.TabIndex = 7;
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
            this.btnExit.Location = new System.Drawing.Point(1035, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(20, 505);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(322, 50);
            this.btnAddToCart.TabIndex = 8;
            this.btnAddToCart.Text = "ДОБАВИТЬ В КОРЗИНУ";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Location = new System.Drawing.Point(19, 567);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(322, 50);
            this.btnCart.TabIndex = 9;
            this.btnCart.Text = "ПЕРЕЙТИ К КОРЗИНЕ";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // mtbMax
            // 
            this.mtbMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbMax.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbMax.Location = new System.Drawing.Point(91, 412);
            this.mtbMax.Mask = "000000";
            this.mtbMax.Name = "mtbMax";
            this.mtbMax.Size = new System.Drawing.Size(64, 26);
            this.mtbMax.TabIndex = 13;
            this.mtbMax.TextChanged += new System.EventHandler(this.mtbMax_TextChanged);
            // 
            // mtbMin
            // 
            this.mtbMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbMin.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbMin.Location = new System.Drawing.Point(91, 368);
            this.mtbMin.Mask = "000000";
            this.mtbMin.Name = "mtbMin";
            this.mtbMin.Size = new System.Drawing.Size(64, 26);
            this.mtbMin.TabIndex = 14;
            this.mtbMin.TextChanged += new System.EventHandler(this.mtbMin_TextChanged);
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvParts.BackgroundColor = System.Drawing.Color.White;
            this.dgvParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(90)))), ((int)(((byte)(191)))));
            this.dgvParts.Location = new System.Drawing.Point(387, 94);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.Size = new System.Drawing.Size(671, 511);
            this.dgvParts.TabIndex = 15;
            this.dgvParts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvParts_CellMouseClick);
            // 
            // cmsParts
            // 
            this.cmsParts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.заказатьToolStripMenuItem,
            this.добавитьToolStripMenuItem});
            this.cmsParts.Name = "cmsParts";
            this.cmsParts.Size = new System.Drawing.Size(155, 70);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // заказатьToolStripMenuItem
            // 
            this.заказатьToolStripMenuItem.Name = "заказатьToolStripMenuItem";
            this.заказатьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.заказатьToolStripMenuItem.Text = "Заказать";
            this.заказатьToolStripMenuItem.Click += new System.EventHandler(this.заказатьToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(949, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PartsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.mtbMin);
            this.Controls.Add(this.mtbMax);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PartsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запчасти";
            this.Load += new System.EventHandler(this.PartsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.cmsParts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.MaskedTextBox mtbMax;
        private System.Windows.Forms.MaskedTextBox mtbMin;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.ContextMenuStrip cmsParts;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
    }
}