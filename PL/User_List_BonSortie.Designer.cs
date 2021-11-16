namespace GestionDeStock.PL
{
    partial class User_List_BonSortie
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
            this.dvgbonSortie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImpCommande = new System.Windows.Forms.Button();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnchercher = new System.Windows.Forms.Button();
            this.dateF = new System.Windows.Forms.DateTimePicker();
            this.dateD = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dvgbonSortie)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgbonSortie
            // 
            this.dvgbonSortie.AllowUserToAddRows = false;
            this.dvgbonSortie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgbonSortie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgbonSortie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgbonSortie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgbonSortie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgbonSortie.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgbonSortie.EnableHeadersVisualStyles = false;
            this.dvgbonSortie.Location = new System.Drawing.Point(10, 76);
            this.dvgbonSortie.Name = "dvgbonSortie";
            this.dvgbonSortie.ReadOnly = true;
            this.dvgbonSortie.RowHeadersVisible = false;
            this.dvgbonSortie.Size = new System.Drawing.Size(960, 428);
            this.dvgbonSortie.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Affaire";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Demandeur";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Livreur";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            this.btnImpCommande.Location = new System.Drawing.Point(703, 510);
            this.btnImpCommande.Name = "btnImpCommande";
            this.btnImpCommande.Size = new System.Drawing.Size(270, 57);
            this.btnImpCommande.TabIndex = 46;
            this.btnImpCommande.Text = "         Imprimer bon sortie";
            this.btnImpCommande.UseVisualStyleBackColor = false;
            this.btnImpCommande.Click += new System.EventHandler(this.btnImpCommande_Click);
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAjouterProduit.FlatAppearance.BorderSize = 0;
            this.btnAjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterProduit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouterProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterProduit.Location = new System.Drawing.Point(6, 3);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(260, 29);
            this.btnAjouterProduit.TabIndex = 39;
            this.btnAjouterProduit.Text = "Ajouter Bon de sortie";
            this.btnAjouterProduit.UseVisualStyleBackColor = false;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 32);
            this.button1.TabIndex = 47;
            this.button1.Text = "Ajouter Bon de retour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 38);
            this.label2.TabIndex = 52;
            this.label2.Text = "Date Fin :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 38);
            this.label1.TabIndex = 51;
            this.label1.Text = "Date Debut :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btnchercher
            // 
            this.Btnchercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.Btnchercher.FlatAppearance.BorderSize = 0;
            this.Btnchercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnchercher.Image = global::GestionDeStock.Properties.Resources.search;
            this.Btnchercher.Location = new System.Drawing.Point(918, 4);
            this.Btnchercher.Name = "Btnchercher";
            this.Btnchercher.Size = new System.Drawing.Size(57, 53);
            this.Btnchercher.TabIndex = 50;
            this.Btnchercher.UseVisualStyleBackColor = false;
            // 
            // dateF
            // 
            this.dateF.Location = new System.Drawing.Point(732, 29);
            this.dateF.Name = "dateF";
            this.dateF.Size = new System.Drawing.Size(151, 20);
            this.dateF.TabIndex = 49;
            // 
            // dateD
            // 
            this.dateD.Location = new System.Drawing.Point(438, 29);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(156, 20);
            this.dateD.TabIndex = 48;
            // 
            // User_List_BonSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnchercher);
            this.Controls.Add(this.dateF);
            this.Controls.Add(this.dateD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImpCommande);
            this.Controls.Add(this.dvgbonSortie);
            this.Controls.Add(this.btnAjouterProduit);
            this.Name = "User_List_BonSortie";
            this.Size = new System.Drawing.Size(978, 570);
            this.Load += new System.EventHandler(this.User_List_BonSortie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgbonSortie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImpCommande;
        private System.Windows.Forms.DataGridView dvgbonSortie;
        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnchercher;
        private System.Windows.Forms.DateTimePicker dateF;
        private System.Windows.Forms.DateTimePicker dateD;
    }
}
