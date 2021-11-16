namespace GestionDeStock.PL
{
    partial class User_Liste_Personnel
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
            this.dvgPersonnel = new System.Windows.Forms.DataGridView();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.ComboRechaerche = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgPersonnel
            // 
            this.dvgPersonnel.AllowUserToAddRows = false;
            this.dvgPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvgPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgPersonnel.DefaultCellStyle = dataGridViewCellStyle8;
            this.dvgPersonnel.EnableHeadersVisualStyles = false;
            this.dvgPersonnel.Location = new System.Drawing.Point(9, 163);
            this.dvgPersonnel.Name = "dvgPersonnel";
            this.dvgPersonnel.RowHeadersVisible = false;
            this.dvgPersonnel.Size = new System.Drawing.Size(960, 315);
            this.dvgPersonnel.TabIndex = 18;
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.textBoxRechercher.BackColor = System.Drawing.Color.Silver;
            this.textBoxRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercher.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxRechercher.Location = new System.Drawing.Point(455, 101);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(294, 35);
            this.textBoxRechercher.TabIndex = 17;
            this.textBoxRechercher.Text = "Rechercher";
            this.textBoxRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRechercher.TextChanged += new System.EventHandler(this.textBoxRechercher_TextChanged);
            this.textBoxRechercher.Enter += new System.EventHandler(this.textBoxRechercher_Enter);
            // 
            // ComboRechaerche
            // 
            this.ComboRechaerche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRechaerche.FormattingEnabled = true;
            this.ComboRechaerche.ItemHeight = 13;
            this.ComboRechaerche.Items.AddRange(new object[] {
            " ",
            "CIN",
            "Nom Complet",
            "Poste"});
            this.ComboRechaerche.Location = new System.Drawing.Point(200, 108);
            this.ComboRechaerche.Name = "ComboRechaerche";
            this.ComboRechaerche.Size = new System.Drawing.Size(179, 21);
            this.ComboRechaerche.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(455, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 2);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(36, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 3);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(27, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 3);
            this.panel1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CIN";
            this.Column7.Name = "Column7";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom Complet";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adresse";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Numero de telephone";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Poste";
            this.Column4.Name = "Column4";
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerPersonnel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSupprimerPersonnel.FlatAppearance.BorderSize = 0;
            this.btnSupprimerPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerPersonnel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupprimerPersonnel.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btnSupprimerPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(662, 12);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(298, 67);
            this.btnSupprimerPersonnel.TabIndex = 12;
            this.btnSupprimerPersonnel.Text = "Supprimer";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = false;
            this.btnSupprimerPersonnel.Click += new System.EventHandler(this.btnSupprimerPersonnel_Click);
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifierPersonnel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModifierPersonnel.FlatAppearance.BorderSize = 0;
            this.btnModifierPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierPersonnel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifierPersonnel.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btnModifierPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifierPersonnel.Location = new System.Drawing.Point(344, 12);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(298, 67);
            this.btnModifierPersonnel.TabIndex = 11;
            this.btnModifierPersonnel.Text = "Modifier";
            this.btnModifierPersonnel.UseVisualStyleBackColor = false;
            this.btnModifierPersonnel.Click += new System.EventHandler(this.btnModifierPersonnel_Click);
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAjouterPersonnel.FlatAppearance.BorderSize = 0;
            this.btnAjouterPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPersonnel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouterPersonnel.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnAjouterPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(27, 12);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(298, 67);
            this.btnAjouterPersonnel.TabIndex = 10;
            this.btnAjouterPersonnel.Text = "Ajouter";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = false;
            this.btnAjouterPersonnel.Click += new System.EventHandler(this.btnAjouterPersonnel_Click);
            // 
            // User_Liste_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 491);
            this.Controls.Add(this.dvgPersonnel);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.ComboRechaerche);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSupprimerPersonnel);
            this.Controls.Add(this.btnModifierPersonnel);
            this.Controls.Add(this.btnAjouterPersonnel);
            this.Name = "User_Liste_Personnel";
            this.Text = "User_Liste_Personnel";
            this.Load += new System.EventHandler(this.User_Liste_Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgPersonnel;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.ComboBox ComboRechaerche;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.Button btnAjouterPersonnel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}