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
    public partial class Form1 : Form
    {
        OracleConnection cn;
        OracleDataAdapter da;
        DataSet ds;
        OracleCommandBuilder comanda;
        BindingSource bs1 = new BindingSource();
        String strSQL;
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridViewUpdate();
        }

        private void buttonAdaugAngajati_Click(object sender, EventArgs e)
        {
            var dialogBox = new Form2();
            var result = dialogBox.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                GridViewUpdate();
            }
        }

        private void GridViewUpdate()
        {
            try
            {
                cn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=STUDENT;PERSIST SECURITY INFO=True;USER ID=STUDENT");
                cn.Open();
                strSQL = "SELECT * FROM salarii_angajati";
                da = new OracleDataAdapter(strSQL, cn);
                comanda = new OracleCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "salarii_angajati");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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
                GridViewUpdate();
                MessageBox.Show("Date actualizate cu succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu s-au putut actualiza datele:\n" + ex.Message.ToString());
            }
        }

        private void buttonStergAngajati_Click(object sender, EventArgs e)
        {
            string nume = dataGridView1.CurrentRow.Cells["NUME"].Value.ToString();
            string prenume = dataGridView1.CurrentRow.Cells["PRENUME"].Value.ToString();
            DialogResult dialog = MessageBox.Show("Doriti sa stergeti angajatul cu numele " + nume + " "
                + prenume + "?", "Stergere", MessageBoxButtons.YesNo);

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
                    MessageBox.Show("Angajat sters cu succes");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu s-a putut sterge angajatul:\n" + ex.Message.ToString());
            }
        }
    }
}
