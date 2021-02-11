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
    public partial class Service : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter da;
        DataTable dt;

        public Service(String con)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Service_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            string query = @"insert into tb1_ServiceDetails(IdService,VehicleNumber,ServiceDetails,IdVehicleType)values('" + txtid.Text + "','" + txtvno.Text + "','" +txtsd.Text + "','" + txtvid.Text + "')";
            da = new SqlDataAdapter(query, sqlConnection);
            dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Service details added into database  successfully!");

        }
    }
}
