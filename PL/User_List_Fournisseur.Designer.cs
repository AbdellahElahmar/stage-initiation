namespace GestionDeStock.PL
{
    partial class User_List_Fournisseur
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
            this.dvgFournisseur = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.ComboRechaerche = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgFournisseur
            // 
            this.dvgFournisseur.AllowUserToAddRows = false;
            this.dvgFournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgFournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgFournisseur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgFournisseur.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgFournisseur.EnableHeadersVisualStyles = false;
            this.dvgFournisseur.Location = new System.Drawing.Point(9, 163);
            this.dvgFournisseur.Name = "dvgFournisseur";
            this.dvgFournisseur.RowHeadersVisible = false;
            this.dvgFournisseur.Size = new System.Drawing.Size(960, 394);
            this.dvgFournisseur.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id_Fournisseur";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom ";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telephone";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adresse";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            "",
            "Nom"});
            this.ComboRechaerche.Location = new System.Drawing.Point(200, 108);
            this.ComboRechaerche.Name = "ComboRechaerche";
            this.ComboRechaerche.Size = new System.Drawing.Size(179, 21);
            this.ComboRechaerche.TabIndex = 16;
            this.ComboRechaerche.SelectedIndexChanged += new System.EventHandler(this.ComboRechaerche_SelectedIndexChanged);
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
            this.btnSupprimerClient.Location = new System.Drawing.Point(662, 12);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(298, 67);
            this.btnSupprimerClient.TabIndex = 12;
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
            this.btnModifierClient.Location = new System.Drawing.Point(344, 12);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(298, 67);
            this.btnModifierClient.TabIndex = 11;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = false;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
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
            this.btnAjouterClient.Location = new System.Drawing.Point(27, 12);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(298, 67);
            this.btnAjouterClient.TabIndex = 10;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = false;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // User_List_Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgFournisseur);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.ComboRechaerche);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.btnAjouterClient);
            this.Name = "User_List_Fournisseur";
            this.Size = new System.Drawing.Size(978, 570);
            this.Load += new System.EventHandler(this.User_List_Fournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgFournisseur;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.ComboBox ComboRechaerche;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
