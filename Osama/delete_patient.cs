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

namespace Osama
{
    public partial class delete_patient : UserControl
    {
        public delete_patient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          


            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PATIENTS WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (MessageBox.Show("Do You Want Delete This Patiant ?", "Delete Patiant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlDataAdapter sda2 = new SqlDataAdapter("Delete  from KOBRY_ELKOBBA WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda2.Fill(dt);
                    SqlDataAdapter sda3 = new SqlDataAdapter("Delete  from NOT_KOBRY_ElKOBBA WHERE PATIENT_ID = '" + PATIENT_ID.Text + "'", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda3.Fill(dt);
                    SqlDataAdapter sda4 = new SqlDataAdapter("Delete  from CIVIL WHERE PATIENT_ID = '" + PATIENT_ID.Text + "'", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda4.Fill(dt);
                    SqlDataAdapter sda1 = new SqlDataAdapter("Delete  from PATIENTS WHERE PATIENT_ID = '" + PATIENT_ID.Text + "'", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda1.Fill(dt);

                    MessageBox.Show("Deleted Successfully");

                }


            }
            else
            {
                MessageBox.Show("This ID IS NOT FOUND");
            }

        }
    }
}
