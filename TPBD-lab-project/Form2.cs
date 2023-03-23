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

namespace TPBD_lab_project
{
    public partial class Form2 : Form
    {
        OracleConnection cn;
        OracleDataAdapter da;
        DataSet ds;
        String strSQL;
        public Form2()
        {
            InitializeComponent();

            this.AcceptButton = buttonOK; // Sets the default accept button
            this.Controls.Add(buttonOK);

            buttonCancel.DialogResult = DialogResult.Cancel;
            this.CancelButton = buttonCancel; // Sets the default cancel button
            this.Controls.Add(buttonCancel);
            textBoxSpor.Text = "10";
            textBoxPremii.Text = "0";
            textBoxRetineri.Text = "0";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=STUDENT;"
                    + "PERSIST SECURITY INFO=True;USER ID=STUDENT");
                OracleCommand comanda;
                OracleTransaction tranzactie;
                try
                {
                    cn.Open();
                    tranzactie = cn.BeginTransaction(IsolationLevel.ReadCommitted);
                    comanda = new OracleCommand("INSERT INTO salarii_angajati(nume, prenume, functie, salar_baza,"
                        + "spor_procent, premii_brute, retineri) VALUES('" + textBoxNume.Text + "', '"
                        + textBoxPrenume.Text + "', '" + textBoxFunctie.Text + "', " + textBoxSalarBaza.Text
                        + ", " + textBoxSpor.Text + ", " + textBoxPremii.Text + ", " + textBoxRetineri.Text + ")", cn);
                    comanda.Transaction = tranzactie;
                    comanda.ExecuteNonQuery();
                    tranzactie.Commit();
                    MessageBox.Show("Angajatul au fost introduse");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "\nEroare la adaugarea angajatului...");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
