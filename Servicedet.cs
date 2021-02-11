using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleServiceStations
{
    public partial class Servicedet : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter da;
        DataTable dt;

        public Servicedet(String con)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var item =this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string query = @"update tb_VehicleTypes set ServiceCharge='"+ txtsc.Text + "' where VehicleType='" + item + "'";
            da = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Service details updated into database successfully!");
        }
    }
}
