using System;
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

            // Add OK and CANCEL buttons
            //var okButton = new Button();
            //okButton.Text = "Adauga";
            //buttonOK.DialogResult = DialogResult.None;
            this.AcceptButton = buttonOK; // Sets the default button
            this.Controls.Add(buttonOK);

            //var cancelButton = new Button();
            //cancelButton.Text = "Anulare";
            buttonCancel.DialogResult = DialogResult.Cancel;
            this.CancelButton = buttonCancel; // Sets the cancel button
            this.Controls.Add(buttonCancel);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=STUDENT;PERSIST SECURITY INFO=True;USER ID=STUDENT");
                OracleCommand comanda;
                OracleTransaction tranzactie;
                try
                {
                    cn.Open();
                    tranzactie = cn.BeginTransaction(IsolationLevel.ReadCommitted);
                    Console.WriteLine("INSERT INTO salarii_angajati(nume, prenume, functie, salar_baza, spor_procent, premii_brute, retineri) VALUES('"
                        + textBoxNume.Text + "', '" + textBoxPrenume.Text + "', '" + textBoxFunctie.Text + "', " + textBoxSalarBaza.Text + ", " + textBoxSpor.Text +
                        ", " + textBoxPremii.Text + ", " + textBoxRetineri.Text + ")");
                    comanda = new OracleCommand("INSERT INTO salarii_angajati(nume, prenume, functie, salar_baza, spor_procent, premii_brute, retineri) VALUES('"
                        + textBoxNume.Text + "', '" + textBoxPrenume.Text + "', '" + textBoxFunctie.Text + "', " + textBoxSalarBaza.Text + ", " + textBoxSpor.Text + 
                        ", " + textBoxPremii.Text + ", " + textBoxRetineri.Text + ")", cn);
                    comanda.Transaction = tranzactie;
                    comanda.ExecuteNonQuery();
                    tranzactie.Commit();
                    MessageBox.Show("Datele au fost introduse");
                    //Form1.GridViewUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "\nEroare la adaugare date in tabela");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
