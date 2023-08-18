
namespace Hotel_management_sistem.Kontrole
{
    partial class Dodavanje_sobe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojSobe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCijena = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTipSobe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTipKreveta = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDodajSobu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj novu sobu";
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.Location = new System.Drawing.Point(48, 57);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(987, 524);
            this.DataGridView1.TabIndex = 1;
            this.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridView1.ThemeStyle.ReadOnly = false;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1194, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj sobe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1194, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tip sobe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1194, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tip kreveta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1194, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cijena";
            // 
            // txtBrojSobe
            // 
            this.txtBrojSobe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrojSobe.DefaultText = "";
            this.txtBrojSobe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBrojSobe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBrojSobe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrojSobe.DisabledState.Parent = this.txtBrojSobe;
            this.txtBrojSobe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrojSobe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrojSobe.FocusedState.Parent = this.txtBrojSobe;
            this.txtBrojSobe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojSobe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBrojSobe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrojSobe.HoverState.Parent = this.txtBrojSobe;
            this.txtBrojSobe.Location = new System.Drawing.Point(1198, 86);
            this.txtBrojSobe.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtBrojSobe.Name = "txtBrojSobe";
            this.txtBrojSobe.PasswordChar = '\0';
            this.txtBrojSobe.PlaceholderText = "";
            this.txtBrojSobe.SelectedText = "";
            this.txtBrojSobe.ShadowDecoration.Parent = this.txtBrojSobe;
            this.txtBrojSobe.Size = new System.Drawing.Size(347, 36);
            this.txtBrojSobe.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtBrojSobe.TabIndex = 6;
            // 
            // txtCijena
            // 
            this.txtCijena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCijena.DefaultText = "";
            this.txtCijena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCijena.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCijena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCijena.DisabledState.Parent = this.txtCijena;
            this.txtCijena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCijena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCijena.FocusedState.Parent = this.txtCijena;
            this.txtCijena.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCijena.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCijena.HoverState.Parent = this.txtCijena;
            this.txtCijena.Location = new System.Drawing.Point(1198, 337);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.PasswordChar = '\0';
            this.txtCijena.PlaceholderText = "";
            this.txtCijena.SelectedText = "";
            this.txtCijena.ShadowDecoration.Parent = this.txtCijena;
            this.txtCijena.Size = new System.Drawing.Size(347, 36);
            this.txtCijena.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCijena.TabIndex = 7;
            // 
            // txtTipSobe
            // 
            this.txtTipSobe.BackColor = System.Drawing.Color.Transparent;
            this.txtTipSobe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTipSobe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipSobe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipSobe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipSobe.FocusedState.Parent = this.txtTipSobe;
            this.txtTipSobe.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtTipSobe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipSobe.HoverState.Parent = this.txtTipSobe;
            this.txtTipSobe.ItemHeight = 30;
            this.txtTipSobe.Items.AddRange(new object[] {
            "Superior",
            "Deluxe"});
            this.txtTipSobe.ItemsAppearance.Parent = this.txtTipSobe;
            this.txtTipSobe.Location = new System.Drawing.Point(1198, 167);
            this.txtTipSobe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipSobe.Name = "txtTipSobe";
            this.txtTipSobe.ShadowDecoration.Parent = this.txtTipSobe;
            this.txtTipSobe.Size = new System.Drawing.Size(347, 36);
            this.txtTipSobe.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTipSobe.TabIndex = 8;
            // 
            // txtTipKreveta
            // 
            this.txtTipKreveta.BackColor = System.Drawing.Color.Transparent;
            this.txtTipKreveta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTipKreveta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipKreveta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipKreveta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipKreveta.FocusedState.Parent = this.txtTipKreveta;
            this.txtTipKreveta.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtTipKreveta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipKreveta.HoverState.Parent = this.txtTipKreveta;
            this.txtTipKreveta.ItemHeight = 30;
            this.txtTipKreveta.Items.AddRange(new object[] {
            "King size krevet",
            "Dva odvojena kreveta"});
            this.txtTipKreveta.ItemsAppearance.Parent = this.txtTipKreveta;
            this.txtTipKreveta.Location = new System.Drawing.Point(1198, 252);
            this.txtTipKreveta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipKreveta.Name = "txtTipKreveta";
            this.txtTipKreveta.ShadowDecoration.Parent = this.txtTipKreveta;
            this.txtTipKreveta.Size = new System.Drawing.Size(347, 36);
            this.txtTipKreveta.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTipKreveta.TabIndex = 9;
            // 
            // btnDodajSobu
            // 
            this.btnDodajSobu.BorderRadius = 23;
            this.btnDodajSobu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnDodajSobu.BorderThickness = 2;
            this.btnDodajSobu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDodajSobu.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnDodajSobu.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnDodajSobu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDodajSobu.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDodajSobu.CheckedState.Parent = this.btnDodajSobu;
            this.btnDodajSobu.CustomImages.Parent = this.btnDodajSobu;
            this.btnDodajSobu.FillColor = System.Drawing.Color.White;
            this.btnDodajSobu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSobu.ForeColor = System.Drawing.Color.Black;
            this.btnDodajSobu.HoverState.Parent = this.btnDodajSobu;
            this.btnDodajSobu.Location = new System.Drawing.Point(1365, 441);
            this.btnDodajSobu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajSobu.Name = "btnDodajSobu";
            this.btnDodajSobu.ShadowDecoration.Parent = this.btnDodajSobu;
            this.btnDodajSobu.Size = new System.Drawing.Size(180, 46);
            this.btnDodajSobu.TabIndex = 10;
            this.btnDodajSobu.Text = "Dodaj sobu";
            this.btnDodajSobu.Click += new System.EventHandler(this.btnDodajSobu_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Dodavanje_sobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDodajSobu);
            this.Controls.Add(this.txtTipKreveta);
            this.Controls.Add(this.txtTipSobe);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtBrojSobe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dodavanje_sobe";
            this.Size = new System.Drawing.Size(1615, 960);
            this.Load += new System.EventHandler(this.Dodavanje_sobe_Load);
            this.Enter += new System.EventHandler(this.Dodavanje_sobe_Enter);
            this.Leave += new System.EventHandler(this.Dodavanje_sobe_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtBrojSobe;
        private Guna.UI2.WinForms.Guna2TextBox txtCijena;
        private Guna.UI2.WinForms.Guna2ComboBox txtTipSobe;
        private Guna.UI2.WinForms.Guna2ComboBox txtTipKreveta;
        private Guna.UI2.WinForms.Guna2Button btnDodajSobu;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
