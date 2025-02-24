namespace Latihan_LKS_2
{
    partial class cariPerjalanan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            title = new Label();
            inputJadwal = new TextBox();
            tabelDataJadwal = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            formStatus = new FlowLayoutPanel();
            labelPilihStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            inputID = new Guna.UI2.WinForms.Guna2TextBox();
            comboBoxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            buttonSimpan = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)tabelDataJadwal).BeginInit();
            formStatus.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(196, 45);
            title.TabIndex = 1;
            title.Text = "Data Jadwal";
            // 
            // inputJadwal
            // 
            inputJadwal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputJadwal.Location = new Point(11, 62);
            inputJadwal.Name = "inputJadwal";
            inputJadwal.PlaceholderText = "Masukan data jadwal";
            inputJadwal.Size = new Size(550, 39);
            inputJadwal.TabIndex = 2;
            // 
            // tabelDataJadwal
            // 
            tabelDataJadwal.AllowUserToAddRows = false;
            tabelDataJadwal.AllowUserToDeleteRows = false;
            tabelDataJadwal.AllowUserToResizeColumns = false;
            tabelDataJadwal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            tabelDataJadwal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tabelDataJadwal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tabelDataJadwal.ColumnHeadersHeight = 82;
            tabelDataJadwal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tabelDataJadwal.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.Padding = new Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tabelDataJadwal.DefaultCellStyle = dataGridViewCellStyle3;
            tabelDataJadwal.GridColor = Color.FromArgb(231, 229, 255);
            tabelDataJadwal.Location = new Point(11, 122);
            tabelDataJadwal.Name = "tabelDataJadwal";
            tabelDataJadwal.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tabelDataJadwal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tabelDataJadwal.RowHeadersVisible = false;
            tabelDataJadwal.RowHeadersWidth = 62;
            tabelDataJadwal.RowTemplate.Height = 65;
            tabelDataJadwal.Size = new Size(833, 265);
            tabelDataJadwal.TabIndex = 3;
            tabelDataJadwal.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            tabelDataJadwal.ThemeStyle.AlternatingRowsStyle.Font = null;
            tabelDataJadwal.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tabelDataJadwal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tabelDataJadwal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tabelDataJadwal.ThemeStyle.BackColor = Color.White;
            tabelDataJadwal.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            tabelDataJadwal.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            tabelDataJadwal.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tabelDataJadwal.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            tabelDataJadwal.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tabelDataJadwal.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tabelDataJadwal.ThemeStyle.HeaderStyle.Height = 82;
            tabelDataJadwal.ThemeStyle.ReadOnly = true;
            tabelDataJadwal.ThemeStyle.RowsStyle.BackColor = Color.White;
            tabelDataJadwal.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabelDataJadwal.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            tabelDataJadwal.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            tabelDataJadwal.ThemeStyle.RowsStyle.Height = 65;
            tabelDataJadwal.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            tabelDataJadwal.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            tabelDataJadwal.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tanggal";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Jam";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "status";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = tabelDataJadwal;
            // 
            // formStatus
            // 
            formStatus.Controls.Add(labelPilihStatus);
            formStatus.Controls.Add(inputID);
            formStatus.Controls.Add(comboBoxStatus);
            formStatus.Controls.Add(buttonSimpan);
            formStatus.FlowDirection = FlowDirection.TopDown;
            formStatus.Location = new Point(11, 435);
            formStatus.Name = "formStatus";
            formStatus.Size = new Size(833, 254);
            formStatus.TabIndex = 4;
            formStatus.Visible = false;
            formStatus.Paint += flowLayoutPanel1_Paint;
            // 
            // labelPilihStatus
            // 
            labelPilihStatus.BackColor = Color.Transparent;
            labelPilihStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPilihStatus.Location = new Point(3, 3);
            labelPilihStatus.Name = "labelPilihStatus";
            labelPilihStatus.Size = new Size(209, 34);
            labelPilihStatus.TabIndex = 0;
            labelPilihStatus.Text = "Pilih Status Barang";
            // 
            // inputID
            // 
            inputID.CustomizableEdges = customizableEdges1;
            inputID.DefaultText = "";
            inputID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            inputID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            inputID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            inputID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            inputID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            inputID.Font = new Font("Segoe UI", 9F);
            inputID.ForeColor = Color.FromArgb(68, 88, 112);
            inputID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            inputID.Location = new Point(4, 45);
            inputID.Margin = new Padding(4, 5, 4, 5);
            inputID.Name = "inputID";
            inputID.PasswordChar = '\0';
            inputID.PlaceholderForeColor = Color.Black;
            inputID.PlaceholderText = "ID";
            inputID.ReadOnly = true;
            inputID.SelectedText = "";
            inputID.ShadowDecoration.CustomizableEdges = customizableEdges2;
            inputID.Size = new Size(429, 53);
            inputID.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.Transparent;
            comboBoxStatus.CustomizableEdges = customizableEdges3;
            comboBoxStatus.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FocusedColor = Color.FromArgb(94, 148, 255);
            comboBoxStatus.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboBoxStatus.Font = new Font("Segoe UI", 10F);
            comboBoxStatus.ForeColor = Color.FromArgb(68, 88, 112);
            comboBoxStatus.ItemHeight = 45;
            comboBoxStatus.Items.AddRange(new object[] { "Berangkat", "Menunggu", "Sampai" });
            comboBoxStatus.Location = new Point(3, 115);
            comboBoxStatus.Margin = new Padding(3, 12, 3, 3);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.ShadowDecoration.CustomizableEdges = customizableEdges4;
            comboBoxStatus.Size = new Size(430, 51);
            comboBoxStatus.StartIndex = 0;
            comboBoxStatus.TabIndex = 1;
            // 
            // buttonSimpan
            // 
            buttonSimpan.CustomizableEdges = customizableEdges5;
            buttonSimpan.DefaultAutoSize = true;
            buttonSimpan.DisabledState.BorderColor = Color.DarkGray;
            buttonSimpan.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonSimpan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonSimpan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonSimpan.FillColor = Color.FromArgb(100, 88, 255);
            buttonSimpan.Font = new Font("Segoe UI", 9F);
            buttonSimpan.ForeColor = Color.White;
            buttonSimpan.Location = new Point(3, 189);
            buttonSimpan.Margin = new Padding(3, 20, 3, 3);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Padding = new Padding(4);
            buttonSimpan.ShadowDecoration.CustomizableEdges = customizableEdges6;
            buttonSimpan.Size = new Size(101, 44);
            buttonSimpan.TabIndex = 2;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.Click += guna2Button1_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = buttonSimpan;
            // 
            // cariPerjalanan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(formStatus);
            Controls.Add(tabelDataJadwal);
            Controls.Add(inputJadwal);
            Controls.Add(title);
            Font = new Font("Segoe UI", 9F);
            Name = "cariPerjalanan";
            Size = new Size(1112, 987);
            Load += cariPerjalanan_Load;
            ((System.ComponentModel.ISupportInitialize)tabelDataJadwal).EndInit();
            formStatus.ResumeLayout(false);
            formStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox inputJadwal;
        private Guna.UI2.WinForms.Guna2DataGridView tabelDataJadwal;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private FlowLayoutPanel formStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPilihStatus;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxStatus;
        private Guna.UI2.WinForms.Guna2Button buttonSimpan;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox inputID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
