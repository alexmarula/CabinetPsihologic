namespace CabinetPsihologic_WindowsForms
{
    partial class MeniuPrincipal
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
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnPacienti = new System.Windows.Forms.Button();
            this.btnGestiune = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersonal
            // 
            this.btnPersonal.Location = new System.Drawing.Point(310, 106);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(150, 50);
            this.btnPersonal.TabIndex = 0;
            this.btnPersonal.Text = "Optiuni personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnPacienti
            // 
            this.btnPacienti.Location = new System.Drawing.Point(310, 162);
            this.btnPacienti.Name = "btnPacienti";
            this.btnPacienti.Size = new System.Drawing.Size(150, 50);
            this.btnPacienti.TabIndex = 1;
            this.btnPacienti.Text = "Optiuni pacienti";
            this.btnPacienti.UseVisualStyleBackColor = true;
            this.btnPacienti.Click += new System.EventHandler(this.btnPacienti_Click);
            // 
            // btnGestiune
            // 
            this.btnGestiune.Location = new System.Drawing.Point(310, 218);
            this.btnGestiune.Name = "btnGestiune";
            this.btnGestiune.Size = new System.Drawing.Size(150, 50);
            this.btnGestiune.TabIndex = 2;
            this.btnGestiune.Text = "Gestiune";
            this.btnGestiune.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(310, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Meniu principal";
            // 
            // MeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGestiune);
            this.Controls.Add(this.btnPacienti);
            this.Controls.Add(this.btnPersonal);
            this.Name = "MeniuPrincipal";
            this.Text = "Cabinet Psihologic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnPacienti;
        private System.Windows.Forms.Button btnGestiune;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

