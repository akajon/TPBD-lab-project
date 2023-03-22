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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonActualizareDate = new System.Windows.Forms.Button();
            this.buttonAdaugAngajati = new System.Windows.Forms.Button();
            this.buttonStergAngajati = new System.Windows.Forms.Button();
            this.buttonCalculSalarii = new System.Windows.Forms.Button();
            this.buttonStatPlata = new System.Windows.Forms.Button();
            this.buttonFluturasi = new System.Windows.Forms.Button();
            this.buttonModifProc = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAjutor.SuspendLayout();
            this.tabPageIntroducereDate.SuspendLayout();
            this.tabPageTiparire.SuspendLayout();
            this.tabPageModificareProc.SuspendLayout();
            this.tabPageIesire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1961, 178);
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
            this.tabPageAjutor.Size = new System.Drawing.Size(1103, 112);
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
            this.tabPageIntroducereDate.Controls.Add(this.buttonCalculSalarii);
            this.tabPageIntroducereDate.Controls.Add(this.buttonStergAngajati);
            this.tabPageIntroducereDate.Controls.Add(this.buttonAdaugAngajati);
            this.tabPageIntroducereDate.Controls.Add(this.buttonActualizareDate);
            this.tabPageIntroducereDate.Location = new System.Drawing.Point(4, 35);
            this.tabPageIntroducereDate.Name = "tabPageIntroducereDate";
            this.tabPageIntroducereDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntroducereDate.Size = new System.Drawing.Size(1953, 139);
            this.tabPageIntroducereDate.TabIndex = 1;
            this.tabPageIntroducereDate.Text = "INTRODUCERE DATE";
            this.tabPageIntroducereDate.UseVisualStyleBackColor = true;
            // 
            // tabPageTiparire
            // 
            this.tabPageTiparire.Controls.Add(this.buttonFluturasi);
            this.tabPageTiparire.Controls.Add(this.buttonStatPlata);
            this.tabPageTiparire.Location = new System.Drawing.Point(4, 35);
            this.tabPageTiparire.Name = "tabPageTiparire";
            this.tabPageTiparire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTiparire.Size = new System.Drawing.Size(1953, 139);
            this.tabPageTiparire.TabIndex = 2;
            this.tabPageTiparire.Text = "TIPARIRE";
            this.tabPageTiparire.UseVisualStyleBackColor = true;
            // 
            // tabPageModificareProc
            // 
            this.tabPageModificareProc.Controls.Add(this.buttonModifProc);
            this.tabPageModificareProc.Location = new System.Drawing.Point(4, 35);
            this.tabPageModificareProc.Name = "tabPageModificareProc";
            this.tabPageModificareProc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModificareProc.Size = new System.Drawing.Size(1953, 139);
            this.tabPageModificareProc.TabIndex = 3;
            this.tabPageModificareProc.Text = "MODIFICARE PROCENTE";
            this.tabPageModificareProc.UseVisualStyleBackColor = true;
            // 
            // tabPageIesire
            // 
            this.tabPageIesire.Controls.Add(this.buttonIesire);
            this.tabPageIesire.Location = new System.Drawing.Point(4, 35);
            this.tabPageIesire.Name = "tabPageIesire";
            this.tabPageIesire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIesire.Size = new System.Drawing.Size(1953, 139);
            this.tabPageIesire.TabIndex = 4;
            this.tabPageIesire.Text = "IESIRE";
            this.tabPageIesire.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1957, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonActualizareDate
            // 
            this.buttonActualizareDate.Location = new System.Drawing.Point(84, 17);
            this.buttonActualizareDate.Name = "buttonActualizareDate";
            this.buttonActualizareDate.Size = new System.Drawing.Size(156, 23);
            this.buttonActualizareDate.TabIndex = 0;
            this.buttonActualizareDate.Text = "Actualizare Date";
            this.buttonActualizareDate.UseVisualStyleBackColor = true;
            // 
            // buttonAdaugAngajati
            // 
            this.buttonAdaugAngajati.Location = new System.Drawing.Point(84, 46);
            this.buttonAdaugAngajati.Name = "buttonAdaugAngajati";
            this.buttonAdaugAngajati.Size = new System.Drawing.Size(156, 23);
            this.buttonAdaugAngajati.TabIndex = 1;
            this.buttonAdaugAngajati.Text = "Adaugare Angajati";
            this.buttonAdaugAngajati.UseVisualStyleBackColor = true;
            // 
            // buttonStergAngajati
            // 
            this.buttonStergAngajati.Location = new System.Drawing.Point(84, 75);
            this.buttonStergAngajati.Name = "buttonStergAngajati";
            this.buttonStergAngajati.Size = new System.Drawing.Size(156, 23);
            this.buttonStergAngajati.TabIndex = 2;
            this.buttonStergAngajati.Text = "Stergere Angajati";
            this.buttonStergAngajati.UseVisualStyleBackColor = true;
            // 
            // buttonCalculSalarii
            // 
            this.buttonCalculSalarii.Location = new System.Drawing.Point(84, 104);
            this.buttonCalculSalarii.Name = "buttonCalculSalarii";
            this.buttonCalculSalarii.Size = new System.Drawing.Size(156, 23);
            this.buttonCalculSalarii.TabIndex = 3;
            this.buttonCalculSalarii.Text = "Calcul Salarii";
            this.buttonCalculSalarii.UseVisualStyleBackColor = true;
            // 
            // buttonStatPlata
            // 
            this.buttonStatPlata.Location = new System.Drawing.Point(253, 19);
            this.buttonStatPlata.Name = "buttonStatPlata";
            this.buttonStatPlata.Size = new System.Drawing.Size(105, 23);
            this.buttonStatPlata.TabIndex = 0;
            this.buttonStatPlata.Text = "Stat Plata";
            this.buttonStatPlata.UseVisualStyleBackColor = true;
            // 
            // buttonFluturasi
            // 
            this.buttonFluturasi.Location = new System.Drawing.Point(253, 48);
            this.buttonFluturasi.Name = "buttonFluturasi";
            this.buttonFluturasi.Size = new System.Drawing.Size(105, 23);
            this.buttonFluturasi.TabIndex = 1;
            this.buttonFluturasi.Text = "Fluturasi";
            this.buttonFluturasi.UseVisualStyleBackColor = true;
            // 
            // buttonModifProc
            // 
            this.buttonModifProc.Location = new System.Drawing.Point(355, 17);
            this.buttonModifProc.Name = "buttonModifProc";
            this.buttonModifProc.Size = new System.Drawing.Size(149, 23);
            this.buttonModifProc.TabIndex = 0;
            this.buttonModifProc.Text = "Modificare Procente";
            this.buttonModifProc.UseVisualStyleBackColor = true;
            // 
            // buttonIesire
            // 
            this.buttonIesire.Location = new System.Drawing.Point(546, 18);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(57, 23);
            this.buttonIesire.TabIndex = 0;
            this.buttonIesire.Text = "Iesire";
            this.buttonIesire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIesire.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1982, 904);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAjutor.ResumeLayout(false);
            this.tabPageAjutor.PerformLayout();
            this.tabPageIntroducereDate.ResumeLayout(false);
            this.tabPageTiparire.ResumeLayout(false);
            this.tabPageModificareProc.ResumeLayout(false);
            this.tabPageIesire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCalculSalarii;
        private System.Windows.Forms.Button buttonStergAngajati;
        private System.Windows.Forms.Button buttonAdaugAngajati;
        private System.Windows.Forms.Button buttonActualizareDate;
        private System.Windows.Forms.Button buttonFluturasi;
        private System.Windows.Forms.Button buttonStatPlata;
        private System.Windows.Forms.Button buttonModifProc;
        private System.Windows.Forms.Button buttonIesire;
    }
}

