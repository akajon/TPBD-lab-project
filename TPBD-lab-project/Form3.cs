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
using System.Security.Cryptography;

namespace TPBD_lab_project
{
    public partial class Form3 : Form
    {
        OracleConnection cn;
        OracleDataAdapter da;
        DataSet ds;
        OracleCommandBuilder comanda;
        BindingSource bs1 = new BindingSource();
        DataTable dt;
        string encryptedPass;

        public Form3()
        {
            InitializeComponent();
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.UseSystemPasswordChar = true;

            this.AcceptButton = buttonOK; // Sets the default accept button
            this.Controls.Add(buttonOK);

            buttonCancel.DialogResult = DialogResult.Cancel;
            this.CancelButton = buttonCancel; // Sets the default cancel button
            this.Controls.Add(buttonCancel);
        }

        private static readonly byte[] key = Encoding.UTF8.GetBytes("oMV8lTg1QGXwfnk0");
        private static readonly byte[] iv = Encoding.UTF8.GetBytes("xM82Rjv0YUMzL37G");

        public static string Encrypt(string password)
        {
            using (var rijndael = new RijndaelManaged())
            {
                rijndael.Key = key;
                rijndael.IV = iv;

                var encryptor = rijndael.CreateEncryptor(rijndael.Key, rijndael.IV);

                var passwordBytes = Encoding.UTF8.GetBytes(password);

                var encryptedBytes = encryptor.TransformFinalBlock(passwordBytes, 0, passwordBytes.Length);

                return Convert.ToBase64String(encryptedBytes);
            }
        }

        //public static string Decrypt(string encryptedPassword)
        //{
        //    using (var rijndael = new RijndaelManaged())
        //    {
        //        rijndael.Key = key;
        //        rijndael.IV = iv;

        //        var decryptor = rijndael.CreateDecryptor(rijndael.Key, rijndael.IV);

        //        var encryptedBytes = Convert.FromBase64String(encryptedPassword);

        //        var decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

        //        return Encoding.UTF8.GetString(decryptedBytes);
        //    }
        //}

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=STUDENT;PERSIST SECURITY "
                    + "INFO=True;USER ID=STUDENT");
                cn.Open();
                da = new OracleDataAdapter("SELECT * FROM valori_procentuale_impozite WHERE NR_CRT = 1", cn);
                comanda = new OracleCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "valori_procentuale_impozite");
                DataTable dt = ds.Tables["valori_procentuale_impozite"];

                if (dt.Rows.Count > 0)
                {
                    // Retrieve the first row
                    DataRow row = dt.Rows[0];

                    textBoxCas.Text = row["CAS_PROCENT"].ToString();
                    textBoxCass.Text = row["CASS_PROCENT"].ToString();
                    textBoxImpozit.Text = row["IMPOZIT_PROCENT"].ToString();
                    encryptedPass = row["PAROLA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\nEroare la citirea impozitelor curente din BD...");
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Form3.Encrypt(textBoxParola.Text) == encryptedPass)
            {
                DataTable dt = ds.Tables["valori_procentuale_impozite"];
                DataRow row = dt.Rows[0];
                row["CAS_PROCENT"] = textBoxCas.Text;
                row["CASS_PROCENT"] = textBoxCass.Text;
                row["IMPOZIT_PROCENT"] = textBoxImpozit.Text;
                da.Update(ds, "valori_procentuale_impozite");
                MessageBox.Show("Valori impozite modificate cu succes!");
            }
            else
            {
                MessageBox.Show("Parola incorecta!");
            }
        }
    }
}
