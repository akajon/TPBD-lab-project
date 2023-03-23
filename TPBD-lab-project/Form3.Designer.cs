namespace TPBD_lab_project
{
    partial class Form3
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
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxImpozit = new System.Windows.Forms.TextBox();
            this.textBoxCass = new System.Windows.Forms.TextBox();
            this.textBoxCas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(122, 121);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(191, 22);
            this.textBoxParola.TabIndex = 28;
            // 
            // textBoxImpozit
            // 
            this.textBoxImpozit.Location = new System.Drawing.Point(122, 86);
            this.textBoxImpozit.Name = "textBoxImpozit";
            this.textBoxImpozit.Size = new System.Drawing.Size(191, 22);
            this.textBoxImpozit.TabIndex = 27;
            // 
            // textBoxCass
            // 
            this.textBoxCass.Location = new System.Drawing.Point(122, 53);
            this.textBoxCass.Name = "textBoxCass";
            this.textBoxCass.Size = new System.Drawing.Size(191, 22);
            this.textBoxCass.TabIndex = 26;
            // 
            // textBoxCas
            // 
            this.textBoxCas.Location = new System.Drawing.Point(122, 23);
            this.textBoxCas.Name = "textBoxCas";
            this.textBoxCas.Size = new System.Drawing.Size(191, 22);
            this.textBoxCas.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Impozit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "CASS %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "CAS %";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(213, 182);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Anuleaza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(27, 182);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(108, 30);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "Modifica";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 243);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxImpozit);
            this.Controls.Add(this.textBoxCass);
            this.Controls.Add(this.textBoxCas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "Form3";
            this.Text = "Modifica Taxe";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.TextBox textBoxImpozit;
        private System.Windows.Forms.TextBox textBoxCass;
        private System.Windows.Forms.TextBox textBoxCas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}