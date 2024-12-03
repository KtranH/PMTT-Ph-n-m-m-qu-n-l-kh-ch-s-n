namespace GUI.DatNhanPhong_GUI
{
    partial class DatPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Textbox_Find_DatPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Data_DatPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Textbox_DatPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_TiepTuc = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Huy = new Guna.UI2.WinForms.Guna2Button();
            this.Button_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_DatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // Textbox_Find_DatPhong
            // 
            this.Textbox_Find_DatPhong.BorderRadius = 15;
            this.Textbox_Find_DatPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Find_DatPhong.DefaultText = "";
            this.Textbox_Find_DatPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_Find_DatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_Find_DatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Find_DatPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_Find_DatPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_Find_DatPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textbox_Find_DatPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_Find_DatPhong.Location = new System.Drawing.Point(227, 12);
            this.Textbox_Find_DatPhong.Name = "Textbox_Find_DatPhong";
            this.Textbox_Find_DatPhong.PasswordChar = '\0';
            this.Textbox_Find_DatPhong.PlaceholderText = "";
            this.Textbox_Find_DatPhong.SelectedText = "";
            this.Textbox_Find_DatPhong.Size = new System.Drawing.Size(1333, 36);
            this.Textbox_Find_DatPhong.TabIndex = 0;
            this.Textbox_Find_DatPhong.TextChanged += new System.EventHandler(this.Textbox_Find_DatPhong_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(22, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(199, 22);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Tìm kiếm đơn đặt phòng:";
            // 
            // Data_DatPhong
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.Data_DatPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_DatPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Data_DatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_DatPhong.DefaultCellStyle = dataGridViewCellStyle9;
            this.Data_DatPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_DatPhong.Location = new System.Drawing.Point(22, 54);
            this.Data_DatPhong.Name = "Data_DatPhong";
            this.Data_DatPhong.RowHeadersVisible = false;
            this.Data_DatPhong.Size = new System.Drawing.Size(1538, 603);
            this.Data_DatPhong.TabIndex = 2;
            this.Data_DatPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_DatPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Data_DatPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Data_DatPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Data_DatPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Data_DatPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Data_DatPhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_DatPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Data_DatPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Data_DatPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_DatPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Data_DatPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data_DatPhong.ThemeStyle.HeaderStyle.Height = 23;
            this.Data_DatPhong.ThemeStyle.ReadOnly = false;
            this.Data_DatPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_DatPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Data_DatPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_DatPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data_DatPhong.ThemeStyle.RowsStyle.Height = 22;
            this.Data_DatPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_DatPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data_DatPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_DatPhong_CellContentClick);
            // 
            // Textbox_DatPhong
            // 
            this.Textbox_DatPhong.BorderRadius = 20;
            this.Textbox_DatPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_DatPhong.DefaultText = "";
            this.Textbox_DatPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textbox_DatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textbox_DatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_DatPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textbox_DatPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_DatPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textbox_DatPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textbox_DatPhong.Location = new System.Drawing.Point(22, 699);
            this.Textbox_DatPhong.Name = "Textbox_DatPhong";
            this.Textbox_DatPhong.PasswordChar = '\0';
            this.Textbox_DatPhong.PlaceholderText = "";
            this.Textbox_DatPhong.SelectedText = "";
            this.Textbox_DatPhong.Size = new System.Drawing.Size(757, 43);
            this.Textbox_DatPhong.TabIndex = 3;
            // 
            // Button_TiepTuc
            // 
            this.Button_TiepTuc.BorderRadius = 20;
            this.Button_TiepTuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_TiepTuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_TiepTuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_TiepTuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_TiepTuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.Button_TiepTuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_TiepTuc.ForeColor = System.Drawing.Color.White;
            this.Button_TiepTuc.Location = new System.Drawing.Point(797, 697);
            this.Button_TiepTuc.Name = "Button_TiepTuc";
            this.Button_TiepTuc.Size = new System.Drawing.Size(180, 45);
            this.Button_TiepTuc.TabIndex = 4;
            this.Button_TiepTuc.Text = "Tiếp tục";
            this.Button_TiepTuc.Click += new System.EventHandler(this.Button_TiepTuc_Click);
            // 
            // Button_Huy
            // 
            this.Button_Huy.BorderRadius = 20;
            this.Button_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(69)))), ((int)(((byte)(63)))));
            this.Button_Huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Huy.ForeColor = System.Drawing.Color.White;
            this.Button_Huy.Location = new System.Drawing.Point(1380, 697);
            this.Button_Huy.Name = "Button_Huy";
            this.Button_Huy.Size = new System.Drawing.Size(180, 45);
            this.Button_Huy.TabIndex = 5;
            this.Button_Huy.Text = "Hủy";
            this.Button_Huy.Click += new System.EventHandler(this.Button_Huy_Click);
            // 
            // Button_LamMoi
            // 
            this.Button_LamMoi.BorderRadius = 20;
            this.Button_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_LamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.Button_LamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LamMoi.ForeColor = System.Drawing.Color.White;
            this.Button_LamMoi.Location = new System.Drawing.Point(983, 697);
            this.Button_LamMoi.Name = "Button_LamMoi";
            this.Button_LamMoi.Size = new System.Drawing.Size(180, 45);
            this.Button_LamMoi.TabIndex = 6;
            this.Button_LamMoi.Text = "Làm mới";
            this.Button_LamMoi.Click += new System.EventHandler(this.Button_LamMoi_Click);
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1572, 841);
            this.Controls.Add(this.Button_LamMoi);
            this.Controls.Add(this.Button_Huy);
            this.Controls.Add(this.Button_TiepTuc);
            this.Controls.Add(this.Textbox_DatPhong);
            this.Controls.Add(this.Data_DatPhong);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Textbox_Find_DatPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatPhong";
            this.Text = "DatPhong";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_DatPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox Textbox_Find_DatPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView Data_DatPhong;
        private Guna.UI2.WinForms.Guna2TextBox Textbox_DatPhong;
        private Guna.UI2.WinForms.Guna2Button Button_TiepTuc;
        private Guna.UI2.WinForms.Guna2Button Button_Huy;
        private Guna.UI2.WinForms.Guna2Button Button_LamMoi;
    }
}