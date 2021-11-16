namespace GestionDeStock.PL
{
    partial class FRM_Ajouet_Modifier_Produit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbltitre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtBoxRef = new System.Windows.Forms.TextBox();
            this.comboCategorie = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBoxQuantite = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBoxPrix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 3);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 528);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(318, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 528);
            this.panel4.TabIndex = 1;
            // 
            // lbltitre
            // 
            this.lbltitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.Color.White;
            this.lbltitre.Location = new System.Drawing.Point(9, 9);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(303, 77);
            this.lbltitre.TabIndex = 2;
            this.lbltitre.Text = "Ajouter Produit";
            this.lbltitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.button1.Location = new System.Drawing.Point(282, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 37);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(31, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 3);
            this.panel6.TabIndex = 14;
            // 
            // txtBoxRef
            // 
            this.txtBoxRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtBoxRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRef.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxRef.Location = new System.Drawing.Point(31, 100);
            this.txtBoxRef.Multiline = true;
            this.txtBoxRef.Name = "txtBoxRef";
            this.txtBoxRef.Size = new System.Drawing.Size(249, 33);
            this.txtBoxRef.TabIndex = 13;
            this.txtBoxRef.Text = "Reference";
            this.txtBoxRef.Enter += new System.EventHandler(this.txtBoxRef_Enter);
            this.txtBoxRef.Leave += new System.EventHandler(this.txtBoxRef_Leave);
            // 
            // comboCategorie
            // 
            this.comboCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategorie.FormattingEnabled = true;
            this.comboCategorie.ItemHeight = 13;
            this.comboCategorie.Location = new System.Drawing.Point(146, 206);
            this.comboCategorie.Name = "comboCategorie";
            this.comboCategorie.Size = new System.Drawing.Size(159, 21);
            this.comboCategorie.TabIndex = 16;
            this.comboCategorie.SelectedIndexChanged += new System.EventHandler(this.comboCategorie_SelectedIndexChanged);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Firebrick;
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(28, 373);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(249, 47);
            this.btnEnregistrer.TabIndex = 20;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.Firebrick;
            this.btnActualiser.FlatAppearance.BorderSize = 0;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.Color.White;
            this.btnActualiser.Location = new System.Drawing.Point(31, 441);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(249, 47);
            this.btnActualiser.TabIndex = 19;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionDeStock.Properties.Resources.Quantie_32;
            this.pictureBox2.Location = new System.Drawing.Point(10, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 37);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(56, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 3);
            this.panel5.TabIndex = 23;
            // 
            // txtBoxQuantite
            // 
            this.txtBoxQuantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtBoxQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQuantite.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxQuantite.Location = new System.Drawing.Point(56, 255);
            this.txtBoxQuantite.Multiline = true;
            this.txtBoxQuantite.Name = "txtBoxQuantite";
            this.txtBoxQuantite.Size = new System.Drawing.Size(249, 33);
            this.txtBoxQuantite.TabIndex = 22;
            this.txtBoxQuantite.Text = "Quantité";
            this.txtBoxQuantite.Enter += new System.EventHandler(this.txtBoxQuantite_Enter);
            this.txtBoxQuantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxQuantite_KeyPress);
            this.txtBoxQuantite.Leave += new System.EventHandler(this.txtBoxQuantite_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GestionDeStock.Properties.Resources.prix_32;
            this.pictureBox4.Location = new System.Drawing.Point(13, 310);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 37);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(59, 349);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(249, 3);
            this.panel7.TabIndex = 26;
            // 
            // txtBoxPrix
            // 
            this.txtBoxPrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtBoxPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrix.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPrix.Location = new System.Drawing.Point(59, 314);
            this.txtBoxPrix.Multiline = true;
            this.txtBoxPrix.Name = "txtBoxPrix";
            this.txtBoxPrix.Size = new System.Drawing.Size(249, 33);
            this.txtBoxPrix.TabIndex = 25;
            this.txtBoxPrix.Text = "Prix Unitaire";
            this.txtBoxPrix.TextChanged += new System.EventHandler(this.txtBoxPrix_TextChanged);
            this.txtBoxPrix.Enter += new System.EventHandler(this.txtBoxPrix_Enter);
            this.txtBoxPrix.Leave += new System.EventHandler(this.txtBoxPrix_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(14, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Categorie :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(31, 186);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(249, 3);
            this.panel8.TabIndex = 16;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBoxDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesignation.ForeColor = System.Drawing.Color.Silver;
            this.textBoxDesignation.Location = new System.Drawing.Point(31, 151);
            this.textBoxDesignation.Multiline = true;
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(249, 33);
            this.textBoxDesignation.TabIndex = 15;
            this.textBoxDesignation.Text = "Designation";
            this.textBoxDesignation.Enter += new System.EventHandler(this.textBoxDesignation_Enter);
            this.textBoxDesignation.Leave += new System.EventHandler(this.textBoxDesignation_Leave);
            // 
            // FRM_Ajouet_Modifier_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(321, 531);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtBoxPrix);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtBoxQuantite);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.comboCategorie);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtBoxRef);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajouet_Modifier_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ajouet_Modifier_Produit";
            this.Load += new System.EventHandler(this.FRM_Ajouet_Modifier_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox txtBoxRef;
        public System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txtBoxQuantite;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox txtBoxPrix;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbltitre;
        public System.Windows.Forms.Button btnEnregistrer;
        public System.Windows.Forms.ComboBox comboCategorie;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox textBoxDesignation;
    }
}