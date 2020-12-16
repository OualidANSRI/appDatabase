
namespace appDatabase
{
    partial class Form2
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(35, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(286, 26);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Afficher la table de voitures ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel3.Location = new System.Drawing.Point(35, 159);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(234, 26);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Supprimer une marque";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel4.Location = new System.Drawing.Point(35, 105);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(368, 26);
            this.linkLabel4.TabIndex = 7;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Ajouter, modifier la table de voitures";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(292, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form2";
            this.Text = "Gestion de données";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Button button1;
    }
}