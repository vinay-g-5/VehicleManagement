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
    public partial class Servicechar : Form
    {
        SqlConnection sqlconnection;
        SqlDataAdapter da;
        DataTable dt;
        
        public Servicechar(String con)
        {
            InitializeComponent();
            sqlconnection = new SqlConnection(con);
            sqlconnection.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item =this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
 da = new SqlDataAdapter("select sum(v.ServiceCharge) from tb_VehicleTypes v join tb1_ServiceDetails s on v.IdVehicleType = s.IdVehicleType where v.VehicleType = '"+item+ "' group by s.IdVehicleType", sqlconnection);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
            txttsc.Text = dt.Rows[0][0].ToString();
        }
    }
}
