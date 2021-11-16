namespace GestionDeStock.PL
{
    partial class User_Liste_Produit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupprimerProduit = new System.Windows.Forms.Button();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.BtnActualiser = new System.Windows.Forms.Button();
            this.ComboRechaerche = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgProduit
            // 
            this.dvgProduit.AllowUserToAddRows = false;
            this.dvgProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProduit.DefaultCellStyle = dataGridViewCellStyle6;
            this.dvgProduit.EnableHeadersVisualStyles = false;
            this.dvgProduit.Location = new System.Drawing.Point(3, 143);
            this.dvgProduit.Name = "dvgProduit";
            this.dvgProduit.RowHeadersVisible = false;
            this.dvgProduit.Size = new System.Drawing.Size(960, 411);
            this.dvgProduit.TabIndex = 18;
            this.dvgProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProduit_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "id";
            this.Column10.Name = "Column10";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Designation";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Refeence";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categorie";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantité";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prix unitaire";
            this.Column6.Name = "Column6";
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.textBoxRechercher.BackColor = System.Drawing.Color.Silver;
            this.textBoxRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercher.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxRechercher.Location = new System.Drawing.Point(260, 91);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(325, 35);
            this.textBoxRechercher.TabIndex = 17;
            this.textBoxRechercher.Text = "Rechercher";
            this.textBoxRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRechercher.TextChanged += new System.EventHandler(this.textBoxRechercher_TextChanged);
            this.textBoxRechercher.Enter += new System.EventHandler(this.textBoxRechercher_Enter);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(69, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 2);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(34, 140);
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
            this.panel1.Location = new System.Drawing.Point(20, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 3);
            this.panel1.TabIndex = 13;
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerProduit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSupprimerProduit.FlatAppearance.BorderSize = 0;
            this.btnSupprimerProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerProduit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupprimerProduit.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btnSupprimerProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerProduit.Location = new System.Drawing.Point(630, 3);
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(345, 67);
            this.btnSupprimerProduit.TabIndex = 12;
            this.btnSupprimerProduit.Text = "Supprimer";
            this.btnSupprimerProduit.UseVisualStyleBackColor = false;
            this.btnSupprimerProduit.Click += new System.EventHandler(this.btnSupprimerProduit_Click);
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifierProduit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModifierProduit.FlatAppearance.BorderSize = 0;
            this.btnModifierProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierProduit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifierProduit.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btnModifierProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifierProduit.Location = new System.Drawing.Point(317, 3);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(290, 67);
            this.btnModifierProduit.TabIndex = 11;
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.UseVisualStyleBackColor = false;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAjouterProduit.FlatAppearance.BorderSize = 0;
            this.btnAjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterProduit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouterProduit.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnAjouterProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterProduit.Location = new System.Drawing.Point(7, 3);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(293, 67);
            this.btnAjouterProduit.TabIndex = 10;
            this.btnAjouterProduit.Text = "Ajouter";
            this.btnAjouterProduit.UseVisualStyleBackColor = false;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click);
            // 
            // BtnActualiser
            // 
            this.BtnActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualiser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActualiser.FlatAppearance.BorderSize = 0;
            this.BtnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualiser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnActualiser.Image = global::GestionDeStock.Properties.Resources.Refresh_icon;
            this.BtnActualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualiser.Location = new System.Drawing.Point(686, 81);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.Size = new System.Drawing.Size(253, 50);
            this.BtnActualiser.TabIndex = 23;
            this.BtnActualiser.Text = "Actualiser";
            this.BtnActualiser.UseVisualStyleBackColor = false;
            this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
            // 
            // ComboRechaerche
            // 
            this.ComboRechaerche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRechaerche.FormattingEnabled = true;
            this.ComboRechaerche.ItemHeight = 13;
            this.ComboRechaerche.Items.AddRange(new object[] {
            "",
            "Designation",
            "Reference"});
            this.ComboRechaerche.Location = new System.Drawing.Point(51, 99);
            this.ComboRechaerche.Name = "ComboRechaerche";
            this.ComboRechaerche.Size = new System.Drawing.Size(179, 21);
            this.ComboRechaerche.TabIndex = 24;
            this.ComboRechaerche.SelectedIndexChanged += new System.EventHandler(this.ComboRechaerche_SelectedIndexChanged);
            // 
            // User_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboRechaerche);
            this.Controls.Add(this.BtnActualiser);
            this.Controls.Add(this.dvgProduit);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSupprimerProduit);
            this.Controls.Add(this.btnModifierProduit);
            this.Controls.Add(this.btnAjouterProduit);
            this.Name = "User_Liste_Produit";
            this.Size = new System.Drawing.Size(978, 570);
            this.Load += new System.EventHandler(this.User_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimerProduit;
        private System.Windows.Forms.Button btnModifierProduit;
        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.Button BtnActualiser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox ComboRechaerche;
    }
}
