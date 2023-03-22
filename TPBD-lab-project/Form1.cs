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
    public partial class Form1 : Form
    {
        OracleConnection cn;
        OracleDataAdapter da;
        DataSet ds;
        String strSQL;
        public Form1()
        {
            InitializeComponent();
            try
            {
                cn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=STUDENT;PERSIST SECURITY INFO=True;USER ID=STUDENT");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.Open();
            strSQL = "SELECT * FROM salarii_angajati";
            da = new OracleDataAdapter(strSQL, cn);
            ds = new DataSet();
            da.Fill(ds, "salarii_angajati");

            dataGridView1.DataSource = ds.Tables["salarii_angajati"];
        }
    }
}
