
namespace appDatabase
{
    partial class Voitures
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Connect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Connect.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Connect.Location = new System.Drawing.Point(92, 85);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(160, 53);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connexion";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Voitures
            // 
            this.AcceptButton = this.Connect;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(355, 234);
            this.Controls.Add(this.Connect);
            this.Name = "Voitures";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de données";
            this.Load += new System.EventHandler(this.Voitures_Load);
            this.CausesValidationChanged += new System.EventHandler(this.Voitures_CausesValidationChanged);
            this.Click += new System.EventHandler(this.Voitures_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect;
    }
}

