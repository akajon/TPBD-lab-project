﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using CrystalDecisions.CrystalReports;

namespace TPBD_lab_project
{
    public partial class Form1 : Form
    {
        OracleConnection cn;
        OracleDataAdapter da;
        DataSet ds;
        OracleCommandBuilder comanda;
        BindingSource bs1 = new BindingSource();
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridViewUpdate("SELECT * FROM salarii_angajati");
        }

        private void buttonAdaugAngajati_Click(object sender, EventArgs e)
        {
            var dialogBox = new Form2();
            var result = dialogBox.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                GridViewUpdate("SELECT * FROM salarii_angajati");
            }
        }

        private void GridViewUpdate(string query)
        {
            try
            {
                cn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=STUDENT;PERSIST SECURITY "
                    + "INFO=True;USER ID=STUDENT");
                cn.Open();
                da = new OracleDataAdapter(query, cn);
                comanda = new OracleCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "salarii_angajati");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\nEroare la actualizarea datelor din tabel...");
            }

            dataGridView1.DataSource = ds.Tables["salarii_angajati"];

            dataGridView1.Columns["nr_crt"].ReadOnly = true;
            dataGridView1.Columns["total_brut"].ReadOnly = true;
            dataGridView1.Columns["brut_impozabil"].ReadOnly = true;
            dataGridView1.Columns["impozit"].ReadOnly = true;
            dataGridView1.Columns["cas"].ReadOnly = true;
            dataGridView1.Columns["cass"].ReadOnly = true;
            dataGridView1.Columns["virat_card"].ReadOnly = true;
        }

        private void buttonActualizareDate_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables["salarii_angajati"]);
                ds.AcceptChanges();
                GridViewUpdate("SELECT * FROM salarii_angajati");
                MessageBox.Show("Date salvate cu succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\nEroare la actualizarea datelor din tabel...");
            }
        }

        private void buttonStergAngajati_Click(object sender, EventArgs e)
        {
            string nume = dataGridView1.CurrentRow.Cells["NUME"].Value.ToString();
            string prenume = dataGridView1.CurrentRow.Cells["PRENUME"].Value.ToString();
            DialogResult dialog = MessageBox.Show("Doriti sa stergeti angajatul cu numele " + nume + " "
                + prenume + "?", "Stergere angajat", MessageBoxButtons.YesNo);

            try
            {
                if (dialog == DialogResult.Yes)
                {
                    if (ds.Tables["salarii_angajati"].Rows.Count > 0)
                    {
                        int rownum = (dataGridView1.CurrentCell.RowIndex);
                        DataRow Linie = ds.Tables["salarii_angajati"].Rows[rownum];
                        Linie.Delete();
                        da.Update(ds.Tables["salarii_angajati"]);
                    }
                    MessageBox.Show("Angajat sters cu succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\nEroare la stergerea angajatului...");
            }
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Doriti sa iesiti din aplicatie?", "Iesire", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        private void buttonModifProc_Click(object sender, EventArgs e)
        {
            var dialogBox = new Form3();
            var result = dialogBox.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                GridViewUpdate("SELECT * FROM salarii_angajati");
            }
        }

        private void textBoxCautare_TextChanged(object sender, EventArgs e)
        {
            try {
                string strSQL = "SELECT * FROM salarii_angajati WHERE UPPER(nume) LIKE UPPER('%" + textBoxCautare.Text
                    + "%') OR UPPER(prenume) LIKE UPPER('%" + textBoxCautare.Text + "%')";
                GridViewUpdate(strSQL);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\nEroare la filtrare...");
            }
        }

        private void buttonStatPlata_Click(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            crystalReportViewer1.DisplayGroupTree = false;
            report.SetDataSource(ds.Tables["salarii_angajati"]);
            crystalReportViewer1.ReportSource = report;
        }

        private void buttonFluturasi_Click(object sender, EventArgs e)
        {
            CrystalReport2 report = new CrystalReport2();
            crystalReportViewer1.DisplayGroupTree = false;
            report.SetDataSource(ds.Tables["salarii_angajati"]);
            crystalReportViewer1.ReportSource = report;
        }

        private void buttonAjutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicatie de gestionare a angajatilor companiei. Modul de operare:\n"
                + "\n\n\t1.Ajutor:\n\t\t* Afisare Informatii Ajutatoare: Afiseaza meniul curent\n"
                + "\n\n\t2.Introducere Date:\n\t\t* Actualizare date: Salveaza modificarile din interfata in baza de date\n"
                + "\t\t* Adaugare Angajati: Adauga un nou angajat\n\t\t* Stergere angajat: Sterge angajatul selectat din "
                + "baza de date\n\n\t3.Tiparire:\n\t\t* Stat plata: Afiseaza un raport cu toate datele despre angajatii selectati "
                + "si suma totala\n\t\t* Fluturasi: Afiseaza fluturasii pentru angajatii selectati"
                + "\n\n\t4. Modificare Procente:\n\t\t* Modificare procente: Modifica valorile procentelor pentru taxe in baza de date. "
                + "Se vor recalcula salariile pentru toti angajatii. Este nevoie de introducere parola"
                + "\n\n\t5. Iesire:\n\t\t* Iesire: Paraseste aplicatia");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GridViewUpdate("SELECT * FROM salarii_angajati");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables["salarii_angajati"]);
                ds.AcceptChanges();
                GridViewUpdate("SELECT * FROM salarii_angajati");
                MessageBox.Show("Date salvate cu succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\nEroare la actualizarea datelor din tabel...");
            }
        }

        private void buttonRefreshHint_Click(object sender, EventArgs e)
        {
            GridViewUpdate("SELECT * FROM salarii_angajati");
        }

        private void buttonAdaugAngajatiHint_Click(object sender, EventArgs e)
        {
            var dialogBox = new Form2();
            var result = dialogBox.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                GridViewUpdate("SELECT * FROM salarii_angajati");
            }
        }

        private void buttonStergAngajatiHint_Click(object sender, EventArgs e)
        {
            string nume = dataGridView1.CurrentRow.Cells["NUME"].Value.ToString();
            string prenume = dataGridView1.CurrentRow.Cells["PRENUME"].Value.ToString();
            DialogResult dialog = MessageBox.Show("Doriti sa stergeti angajatul cu numele " + nume + " "
                + prenume + "?", "Stergere angajat", MessageBoxButtons.YesNo);

            try
            {
                if (dialog == DialogResult.Yes)
                {
                    if (ds.Tables["salarii_angajati"].Rows.Count > 0)
                    {
                        int rownum = (dataGridView1.CurrentCell.RowIndex);
                        DataRow Linie = ds.Tables["salarii_angajati"].Rows[rownum];
                        Linie.Delete();
                        da.Update(ds.Tables["salarii_angajati"]);
                    }
                    MessageBox.Show("Angajat sters cu succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\nEroare la stergerea angajatului...");
            }
        }
    }
}
