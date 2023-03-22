namespace TPBD_lab_project
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAjutor = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageIntroducereDate = new System.Windows.Forms.TabPage();
            this.tabPageTiparire = new System.Windows.Forms.TabPage();
            this.tabPageModificareProc = new System.Windows.Forms.TabPage();
            this.tabPageIesire = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageAjutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAjutor);
            this.tabControl1.Controls.Add(this.tabPageIntroducereDate);
            this.tabControl1.Controls.Add(this.tabPageTiparire);
            this.tabControl1.Controls.Add(this.tabPageModificareProc);
            this.tabControl1.Controls.Add(this.tabPageIesire);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 551);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAjutor
            // 
            this.tabPageAjutor.Controls.Add(this.label1);
            this.tabPageAjutor.Location = new System.Drawing.Point(4, 35);
            this.tabPageAjutor.Name = "tabPageAjutor";
            this.tabPageAjutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAjutor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageAjutor.Size = new System.Drawing.Size(1103, 512);
            this.tabPageAjutor.TabIndex = 0;
            this.tabPageAjutor.Text = "AJUTOR";
            this.tabPageAjutor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplicatie calcul salarii angajati";
            // 
            // tabPageIntroducereDate
            // 
            this.tabPageIntroducereDate.Location = new System.Drawing.Point(4, 35);
            this.tabPageIntroducereDate.Name = "tabPageIntroducereDate";
            this.tabPageIntroducereDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntroducereDate.Size = new System.Drawing.Size(1103, 512);
            this.tabPageIntroducereDate.TabIndex = 1;
            this.tabPageIntroducereDate.Text = "INTRODUCERE DATE";
            this.tabPageIntroducereDate.UseVisualStyleBackColor = true;
            // 
            // tabPageTiparire
            // 
            this.tabPageTiparire.Location = new System.Drawing.Point(4, 35);
            this.tabPageTiparire.Name = "tabPageTiparire";
            this.tabPageTiparire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTiparire.Size = new System.Drawing.Size(1103, 512);
            this.tabPageTiparire.TabIndex = 2;
            this.tabPageTiparire.Text = "TIPARIRE";
            this.tabPageTiparire.UseVisualStyleBackColor = true;
            // 
            // tabPageModificareProc
            // 
            this.tabPageModificareProc.Location = new System.Drawing.Point(4, 35);
            this.tabPageModificareProc.Name = "tabPageModificareProc";
            this.tabPageModificareProc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModificareProc.Size = new System.Drawing.Size(1103, 512);
            this.tabPageModificareProc.TabIndex = 3;
            this.tabPageModificareProc.Text = "MODIFICARE PROCENTE";
            this.tabPageModificareProc.UseVisualStyleBackColor = true;
            // 
            // tabPageIesire
            // 
            this.tabPageIesire.Location = new System.Drawing.Point(4, 35);
            this.tabPageIesire.Name = "tabPageIesire";
            this.tabPageIesire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIesire.Size = new System.Drawing.Size(1103, 512);
            this.tabPageIesire.TabIndex = 4;
            this.tabPageIesire.Text = "IESIRE";
            this.tabPageIesire.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAjutor.ResumeLayout(false);
            this.tabPageAjutor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAjutor;
        private System.Windows.Forms.TabPage tabPageIntroducereDate;
        private System.Windows.Forms.TabPage tabPageTiparire;
        private System.Windows.Forms.TabPage tabPageModificareProc;
        private System.Windows.Forms.TabPage tabPageIesire;
        private System.Windows.Forms.Label label1;
    }
}

