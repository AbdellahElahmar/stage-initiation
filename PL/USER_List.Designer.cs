namespace GestionDeStock.PL
{
    partial class USER_List_CLIENT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ComboRechaerche = new System.Windows.Forms.ComboBox();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.dvgClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnImpCommande = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(18, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 3);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(27, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 3);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(446, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 2);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ComboRechaerche
            // 
            this.ComboRechaerche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRechaerche.FormattingEnabled = true;
            this.ComboRechaerche.ItemHeight = 13;
            this.ComboRechaerche.Items.AddRange(new object[] {
            "",
            "Numero d\'affaire",
            "Label",
            "Adresse",
            "Ville",
            "Telephone",
            "E-mail",
            "Date Ouverture",
            "Date fermeture",
            "Etat Affaire"});
            this.ComboRechaerche.Location = new System.Drawing.Point(191, 118);
            this.ComboRechaerche.Name = "ComboRechaerche";
            this.ComboRechaerche.Size = new System.Drawing.Size(179, 21);
            this.ComboRechaerche.TabIndex = 7;
            this.ComboRechaerche.SelectedIndexChanged += new System.EventHandler(this.ComboRechaerche_SelectedIndexChanged);
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.textBoxRechercher.BackColor = System.Drawing.Color.Silver;
            this.textBoxRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercher.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxRechercher.Location = new System.Drawing.Point(446, 111);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(294, 35);
            this.textBoxRechercher.TabIndex = 8;
            this.textBoxRechercher.Text = "Rechercher";
            this.textBoxRechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRechercher.TextChanged += new System.EventHandler(this.TextBoxRechercher_TextChanged);
            this.textBoxRechercher.Enter += new System.EventHandler(this.TextBox1_Enter);
            // 
            // dvgClient
            // 
            this.dvgClient.AllowUserToAddRows = false;
            this.dvgClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column11,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgClient.EnableHeadersVisualStyles = false;
            this.dvgClient.Location = new System.Drawing.Point(0, 173);
            this.dvgClient.Name = "dvgClient";
            this.dvgClient.RowHeadersVisible = false;
            this.dvgClient.Size = new System.Drawing.Size(960, 292);
            this.dvgClient.TabIndex = 9;
            this.dvgClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClient_CellContentClick);
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
            // Column2
            // 
            this.Column2.HeaderText = "Numero d\'affaire";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Label";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.Name = "Column4";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ville";
            this.Column11.Name = "Column11";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telephone";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "E-mail";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Date Ouverture";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Date de fermeture";
            this.Column9.Name = "Column9";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Etat Affaire";
            this.Column7.Name = "Column7";
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerClient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSupprimerClient.FlatAppearance.BorderSize = 0;
            this.btnSupprimerClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupprimerClient.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btnSupprimerClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerClient.Location = new System.Drawing.Point(653, 22);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(298, 67);
            this.btnSupprimerClient.TabIndex = 2;
            this.btnSupprimerClient.Text = "Supprimer";
            this.btnSupprimerClient.UseVisualStyleBackColor = false;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifierClient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModifierClient.FlatAppearance.BorderSize = 0;
            this.btnModifierClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifierClient.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btnModifierClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifierClient.Location = new System.Drawing.Point(335, 22);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(298, 67);
            this.btnModifierClient.TabIndex = 1;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = false;
            this.btnModifierClient.Click += new System.EventHandler(this.BtnModifierClient_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAjouterClient.FlatAppearance.BorderSize = 0;
            this.btnAjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouterClient.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnAjouterClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterClient.Location = new System.Drawing.Point(18, 22);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(298, 67);
            this.btnAjouterClient.TabIndex = 0;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = false;
            this.btnAjouterClient.Click += new System.EventHandler(this.BtnAjouterClient_Click);
            // 
            // btnImpCommande
            // 
            this.btnImpCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpCommande.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImpCommande.FlatAppearance.BorderSize = 0;
            this.btnImpCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpCommande.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImpCommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpCommande.Location = new System.Drawing.Point(690, 471);
            this.btnImpCommande.Name = "btnImpCommande";
            this.btnImpCommande.Size = new System.Drawing.Size(270, 57);
            this.btnImpCommande.TabIndex = 47;
            this.btnImpCommande.Text = "Imprimer bon Livraison";
            this.btnImpCommande.UseVisualStyleBackColor = false;
            this.btnImpCommande.Click += new System.EventHandler(this.btnImpCommande_Click);
            // 
            // USER_List_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImpCommande);
            this.Controls.Add(this.dvgClient);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.ComboRechaerche);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.btnAjouterClient);
            this.Name = "USER_List_CLIENT";
            this.Size = new System.Drawing.Size(978, 531);
            this.Load += new System.EventHandler(this.USER_List_CLIENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ComboRechaerche;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.DataGridView dvgClient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnImpCommande;
    }
}
