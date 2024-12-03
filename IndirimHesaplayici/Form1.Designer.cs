namespace IndirimHesaplayici
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            RoomName = new DataGridViewTextBoxColumn();
            BasePrice = new DataGridViewTextBoxColumn();
            ReqPrice = new DataGridViewTextBoxColumn();
            BasePriceUSD = new DataGridViewTextBoxColumn();
            ReqPriceUSD = new DataGridViewTextBoxColumn();
            BasePriceTRY = new DataGridViewTextBoxColumn();
            ReqPriceTRY = new DataGridViewTextBoxColumn();
            oda_ayarlari_isim_tb = new TextBox();
            oda_ayarlari_isim_lb = new Label();
            tabPage2 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnRemoveDiscount = new Button();
            txtDiscountName = new TextBox();
            dataGridViewDiscounts = new DataGridView();
            DiscountName = new DataGridViewTextBoxColumn();
            DiscountChain = new DataGridViewTextBoxColumn();
            TotalDiscount = new DataGridViewTextBoxColumn();
            btnAddDiscount = new Button();
            txtDiscount5 = new TextBox();
            txtDiscount4 = new TextBox();
            txtDiscount3 = new TextBox();
            txtDiscount2 = new TextBox();
            txtDiscount1 = new TextBox();
            tabPage3 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            try_Textbox = new TextBox();
            usd_Textbox = new TextBox();
            lstDiscounts = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiscounts).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(50, 50);
            tabControl1.Location = new Point(8, 11);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(874, 545);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(oda_ayarlari_isim_tb);
            tabPage1.Controls.Add(oda_ayarlari_isim_lb);
            tabPage1.Location = new Point(4, 54);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(866, 487);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Oda Ayarları";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(592, 23);
            button4.Name = "button4";
            button4.Size = new Size(264, 23);
            button4.TabIndex = 8;
            button4.Text = "Mod: Temel Fiyatı Hesapla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(458, 23);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 7;
            button3.Text = "PDF Olarak Çıkart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(349, 23);
            button2.Name = "button2";
            button2.Size = new Size(103, 23);
            button2.TabIndex = 6;
            button2.Text = "Seçili Odayı Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDeleteRoom_Click;
            // 
            // button1
            // 
            button1.Location = new Point(238, 23);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 5;
            button1.Text = "Oda Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddRoom_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RoomName, BasePrice, ReqPrice, BasePriceUSD, ReqPriceUSD, BasePriceTRY, ReqPriceTRY });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(5, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(857, 453);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // RoomName
            // 
            RoomName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomName.FillWeight = 25F;
            RoomName.HeaderText = "Oda Adı: ";
            RoomName.MinimumWidth = 8;
            RoomName.Name = "RoomName";
            RoomName.ReadOnly = true;
            // 
            // BasePrice
            // 
            BasePrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            BasePrice.DefaultCellStyle = dataGridViewCellStyle2;
            BasePrice.FillWeight = 12.5F;
            BasePrice.HeaderText = "Temel Fiyat (eur)";
            BasePrice.MinimumWidth = 8;
            BasePrice.Name = "BasePrice";
            // 
            // ReqPrice
            // 
            ReqPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            ReqPrice.DefaultCellStyle = dataGridViewCellStyle3;
            ReqPrice.FillWeight = 12.5F;
            ReqPrice.HeaderText = "İndirimli Fiyat (eur)";
            ReqPrice.MinimumWidth = 8;
            ReqPrice.Name = "ReqPrice";
            // 
            // BasePriceUSD
            // 
            BasePriceUSD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            BasePriceUSD.DefaultCellStyle = dataGridViewCellStyle4;
            BasePriceUSD.FillWeight = 12.5F;
            BasePriceUSD.HeaderText = "Temel Fiyat (usd)";
            BasePriceUSD.MinimumWidth = 8;
            BasePriceUSD.Name = "BasePriceUSD";
            // 
            // ReqPriceUSD
            // 
            ReqPriceUSD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReqPriceUSD.FillWeight = 12.5F;
            ReqPriceUSD.HeaderText = "İndirimli Fiyat (usd)";
            ReqPriceUSD.MinimumWidth = 8;
            ReqPriceUSD.Name = "ReqPriceUSD";
            // 
            // BasePriceTRY
            // 
            BasePriceTRY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BasePriceTRY.FillWeight = 12.5F;
            BasePriceTRY.HeaderText = "Temel Fiyat (try)";
            BasePriceTRY.MinimumWidth = 8;
            BasePriceTRY.Name = "BasePriceTRY";
            // 
            // ReqPriceTRY
            // 
            ReqPriceTRY.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReqPriceTRY.FillWeight = 12.5F;
            ReqPriceTRY.HeaderText = "İndirimli Fiyat (try)";
            ReqPriceTRY.MinimumWidth = 8;
            ReqPriceTRY.Name = "ReqPriceTRY";
            // 
            // oda_ayarlari_isim_tb
            // 
            oda_ayarlari_isim_tb.Location = new Point(67, 23);
            oda_ayarlari_isim_tb.Name = "oda_ayarlari_isim_tb";
            oda_ayarlari_isim_tb.Size = new Size(165, 23);
            oda_ayarlari_isim_tb.TabIndex = 1;
            // 
            // oda_ayarlari_isim_lb
            // 
            oda_ayarlari_isim_lb.AutoSize = true;
            oda_ayarlari_isim_lb.Location = new Point(5, 27);
            oda_ayarlari_isim_lb.Name = "oda_ayarlari_isim_lb";
            oda_ayarlari_isim_lb.Size = new Size(56, 15);
            oda_ayarlari_isim_lb.TabIndex = 0;
            oda_ayarlari_isim_lb.Text = "Oda Adı: ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(btnRemoveDiscount);
            tabPage2.Controls.Add(txtDiscountName);
            tabPage2.Controls.Add(dataGridViewDiscounts);
            tabPage2.Controls.Add(btnAddDiscount);
            tabPage2.Controls.Add(txtDiscount5);
            tabPage2.Controls.Add(txtDiscount4);
            tabPage2.Controls.Add(txtDiscount3);
            tabPage2.Controls.Add(txtDiscount2);
            tabPage2.Controls.Add(txtDiscount1);
            tabPage2.Location = new Point(4, 54);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(866, 487);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "İndirim Ayarları";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(447, 13);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 14;
            label10.Text = "5. İndirim: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(367, 13);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 13;
            label9.Text = "4. İndirim: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 13);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 12;
            label8.Text = "3. İndirim: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(207, 13);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 11;
            label7.Text = "2. İndirim: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 13);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 10;
            label6.Text = "1. İndirim: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 13);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "İndirim Adı:";
            // 
            // btnRemoveDiscount
            // 
            btnRemoveDiscount.Location = new Point(672, 30);
            btnRemoveDiscount.Name = "btnRemoveDiscount";
            btnRemoveDiscount.Size = new Size(139, 23);
            btnRemoveDiscount.TabIndex = 8;
            btnRemoveDiscount.Text = "İndirim Sil";
            btnRemoveDiscount.UseVisualStyleBackColor = true;
            btnRemoveDiscount.Click += btnRemoveDiscount_Click;
            // 
            // txtDiscountName
            // 
            txtDiscountName.Location = new Point(47, 31);
            txtDiscountName.Name = "txtDiscountName";
            txtDiscountName.Size = new Size(74, 23);
            txtDiscountName.TabIndex = 7;
            // 
            // dataGridViewDiscounts
            // 
            dataGridViewDiscounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewDiscounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewDiscounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDiscounts.Columns.AddRange(new DataGridViewColumn[] { DiscountName, DiscountChain, TotalDiscount });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewDiscounts.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewDiscounts.Location = new Point(16, 59);
            dataGridViewDiscounts.Name = "dataGridViewDiscounts";
            dataGridViewDiscounts.RowHeadersWidth = 62;
            dataGridViewDiscounts.Size = new Size(840, 423);
            dataGridViewDiscounts.TabIndex = 6;
            // 
            // DiscountName
            // 
            DiscountName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiscountName.HeaderText = "İndirim İsmi";
            DiscountName.MinimumWidth = 8;
            DiscountName.Name = "DiscountName";
            DiscountName.ReadOnly = true;
            // 
            // DiscountChain
            // 
            DiscountChain.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiscountChain.HeaderText = "İndirim Oranları";
            DiscountChain.MinimumWidth = 8;
            DiscountChain.Name = "DiscountChain";
            DiscountChain.ReadOnly = true;
            // 
            // TotalDiscount
            // 
            TotalDiscount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalDiscount.FillWeight = 30F;
            TotalDiscount.HeaderText = "Total İndirim";
            TotalDiscount.MinimumWidth = 8;
            TotalDiscount.Name = "TotalDiscount";
            TotalDiscount.ReadOnly = true;
            // 
            // btnAddDiscount
            // 
            btnAddDiscount.Location = new Point(527, 31);
            btnAddDiscount.Name = "btnAddDiscount";
            btnAddDiscount.Size = new Size(139, 23);
            btnAddDiscount.TabIndex = 5;
            btnAddDiscount.Text = "İndirim Ekle";
            btnAddDiscount.UseVisualStyleBackColor = true;
            btnAddDiscount.Click += btnAddDiscount_Click;
            // 
            // txtDiscount5
            // 
            txtDiscount5.Location = new Point(447, 31);
            txtDiscount5.Name = "txtDiscount5";
            txtDiscount5.Size = new Size(74, 23);
            txtDiscount5.TabIndex = 4;
            // 
            // txtDiscount4
            // 
            txtDiscount4.Location = new Point(367, 31);
            txtDiscount4.Name = "txtDiscount4";
            txtDiscount4.Size = new Size(74, 23);
            txtDiscount4.TabIndex = 3;
            // 
            // txtDiscount3
            // 
            txtDiscount3.Location = new Point(287, 31);
            txtDiscount3.Name = "txtDiscount3";
            txtDiscount3.Size = new Size(74, 23);
            txtDiscount3.TabIndex = 2;
            // 
            // txtDiscount2
            // 
            txtDiscount2.Location = new Point(207, 31);
            txtDiscount2.Name = "txtDiscount2";
            txtDiscount2.Size = new Size(74, 23);
            txtDiscount2.TabIndex = 1;
            // 
            // txtDiscount1
            // 
            txtDiscount1.Location = new Point(127, 31);
            txtDiscount1.Name = "txtDiscount1";
            txtDiscount1.Size = new Size(74, 23);
            txtDiscount1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(try_Textbox);
            tabPage3.Controls.Add(usd_Textbox);
            tabPage3.Location = new Point(4, 54);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(866, 487);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Döviz Kurları";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 58);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 3;
            label2.Text = "₺";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 2;
            label1.Text = "$";
            // 
            // try_Textbox
            // 
            try_Textbox.Location = new Point(39, 55);
            try_Textbox.Margin = new Padding(2);
            try_Textbox.Name = "try_Textbox";
            try_Textbox.Size = new Size(106, 23);
            try_Textbox.TabIndex = 1;
            try_Textbox.TextChanged += try_Textbox_TextChanged;
            // 
            // usd_Textbox
            // 
            usd_Textbox.Location = new Point(39, 28);
            usd_Textbox.Margin = new Padding(2);
            usd_Textbox.Name = "usd_Textbox";
            usd_Textbox.Size = new Size(106, 23);
            usd_Textbox.TabIndex = 0;
            usd_Textbox.TextChanged += usd_Textbox_TextChanged;
            // 
            // lstDiscounts
            // 
            lstDiscounts.BorderStyle = BorderStyle.None;
            lstDiscounts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lstDiscounts.FormattingEnabled = true;
            lstDiscounts.ItemHeight = 17;
            lstDiscounts.Location = new Point(861, 8);
            lstDiscounts.Name = "lstDiscounts";
            lstDiscounts.SelectionMode = SelectionMode.MultiExtended;
            lstDiscounts.Size = new Size(46, 17);
            lstDiscounts.TabIndex = 1;
            lstDiscounts.Visible = false;
            lstDiscounts.SelectedIndexChanged += lstDiscounts_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(891, 567);
            Controls.Add(tabControl1);
            Controls.Add(lstDiscounts);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiscounts).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label oda_ayarlari_isim_lb;
        private TextBox oda_ayarlari_isim_tb;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button btnAddDiscount;
        private TextBox txtDiscount5;
        private TextBox txtDiscount4;
        private TextBox txtDiscount3;
        private TextBox txtDiscount2;
        private TextBox txtDiscount1;
        private DataGridView dataGridViewDiscounts;
        private TextBox txtDiscountName;
        private Button btnRemoveDiscount;
        private ListBox lstDiscounts;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridViewTextBoxColumn DiscountName;
        private DataGridViewTextBoxColumn DiscountChain;
        private DataGridViewTextBoxColumn TotalDiscount;
        private Button button3;
        private Button button4;
        private TabPage tabPage3;
        private TextBox try_Textbox;
        private TextBox usd_Textbox;
        private DataGridViewTextBoxColumn RoomName;
        private DataGridViewTextBoxColumn BasePrice;
        private DataGridViewTextBoxColumn ReqPrice;
        private DataGridViewTextBoxColumn BasePriceUSD;
        private DataGridViewTextBoxColumn ReqPriceUSD;
        private DataGridViewTextBoxColumn BasePriceTRY;
        private DataGridViewTextBoxColumn ReqPriceTRY;
        private Label label2;
        private Label label1;
    }
}
