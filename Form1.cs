using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleServiceStations
{
    public partial class Form1 : Form
    {
        private String con = "Data Source=LAPTOP-S8FKPDUB\\SQLEXPRESS;Initial Catalog=db_VSS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
           public Form1()
        {
            InitializeComponent();
        }

        private void enterServiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service s = new Service(con);
            s.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviceChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicechar sc = new Servicechar(con);
            sc.Show();

        }

        private void updateServiceChargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicedet sd = new Servicedet(con);
            sd.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
