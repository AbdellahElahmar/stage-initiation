namespace GestionDeStock.PL
{
    partial class FRM_PRODUIT_COMMANDE
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
            this.groupBoxCommande = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrixU = new System.Windows.Forms.TextBox();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxCommande.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCommande
            // 
            this.groupBoxCommande.Controls.Add(this.label2);
            this.groupBoxCommande.Controls.Add(this.label1);
            this.groupBoxCommande.Controls.Add(this.textBoxPrixU);
            this.groupBoxCommande.Controls.Add(this.textBoxRef);
            this.groupBoxCommande.Controls.Add(this.label4);
            this.groupBoxCommande.Controls.Add(this.label9);
            this.groupBoxCommande.Controls.Add(this.textBoxTotal);
            this.groupBoxCommande.Controls.Add(this.textBoxQuantite);
            this.groupBoxCommande.ForeColor = System.Drawing.Color.White;
            this.groupBoxCommande.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCommande.Name = "groupBoxCommande";
            this.groupBoxCommande.Size = new System.Drawing.Size(378, 165);
            this.groupBoxCommande.TabIndex = 50;
            this.groupBoxCommande.TabStop = false;
            this.groupBoxCommande.Text = "Ajouter a la commande :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(180, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Quantité  :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(180, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Prix Total  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPrixU
            // 
            this.textBoxPrixU.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.textBoxPrixU.BackColor = System.Drawing.Color.Silver;
            this.textBoxPrixU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrixU.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxPrixU.Location = new System.Drawing.Point(51, 127);
            this.textBoxPrixU.Name = "textBoxPrixU";
            this.textBoxPrixU.Size = new System.Drawing.Size(128, 26);
            this.textBoxPrixU.TabIndex = 53;
            this.textBoxPrixU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRef
            // 
            this.textBoxRef.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.textBoxRef.BackColor = System.Drawing.Color.Silver;
            this.textBoxRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRef.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxRef.Location = new System.Drawing.Point(51, 51);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(128, 26);
            this.textBoxRef.TabIndex = 52;
            this.textBoxRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Reference :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(11, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Prix Unité  :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.textBoxTotal.BackColor = System.Drawing.Color.Silver;
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxTotal.Location = new System.Drawing.Point(244, 127);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(128, 26);
            this.textBoxTotal.TabIndex = 46;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.textBoxQuantite.BackColor = System.Drawing.Color.Silver;
            this.textBoxQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantite.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxQuantite.Location = new System.Drawing.Point(244, 51);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(128, 26);
            this.textBoxQuantite.TabIndex = 43;
            this.textBoxQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuantite.TextChanged += new System.EventHandler(this.textBoxQuantite_TextChanged);
            this.textBoxQuantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantite_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(79, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 40);
            this.button1.TabIndex = 51;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_PRODUIT_COMMANDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(400, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxCommande);
            this.Name = "FRM_PRODUIT_COMMANDE";
            this.Text = "Ajouter a la commande";
            this.Load += new System.EventHandler(this.FRM_PRODUIT_COMMANDE_Load);
            this.groupBoxCommande.ResumeLayout(false);
            this.groupBoxCommande.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCommande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxPrixU;
        public System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBoxTotal;
        public System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Button button1;
    }
}