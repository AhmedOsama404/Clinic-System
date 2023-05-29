using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace Osama
{
    public partial class add_patient : UserControl
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");

        public add_patient()
        {
            InitializeComponent();
        }

        private void GENDER_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            DIAGNOSIS.Text = DateTime.Now.ToString();



            SqlCommand cmd = new SqlCommand();

           
            string s = "";
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox C = (CheckBox)c;
                    if (C.Checked)
                    {
                        s = C.Text + "," + s;
                    }
                }
            }


            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(*) FROM PATIENTS WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ";
            cmd.ExecuteNonQuery();

            int bb =(Int32)cmd.ExecuteScalar();
            if (bb > 0)
            {
                MessageBox.Show("The Patient id already exists");

            }
            else
            {
                if (MessageBox.Show("Do You Want Add This Patiant ?", "Add Patiant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.CommandText = "INSERT INTO PATIENTS(PATIENT_ID,PATIENT_NAME,ADRESS,PHONE,GENDER,AGE,DIAGNOSIS,DISEASE,TYBE) VALUES (@PATIENT_ID,@PATIENT_NAME,@ADRESS,@PHONE,@GENDER,@AGE,@DIAGNOSIS,@DISEASE,@TYBE)";
                    cmd.Parameters.AddWithValue("@PATIENT_ID", PATIENT_ID.Text);
                    cmd.Parameters.AddWithValue("@PATIENT_NAME", PATIENT_NAME.Text);
                    cmd.Parameters.AddWithValue("@ADRESS", ADRESS.Text);
                    cmd.Parameters.AddWithValue("@PHONE", PHONE.Text);
                    cmd.Parameters.AddWithValue("@GENDER", GENDER.Text);
                    cmd.Parameters.AddWithValue("@AGE", AGE.Text);
                    cmd.Parameters.AddWithValue("@DIAGNOSIS", DIAGNOSIS.Text);
                    cmd.Parameters.AddWithValue("@DISEASE", s);
                    cmd.Parameters.AddWithValue("@TYBE", TYPE.Text);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Patient was Added Successfully");

                    if (TYPE.Text == "Civil")
                    {

                        string text1 = "insert into civil values (N'" + PATIENT_ID.Text + "',N'" + PATIENT_NAME.Text + "',N'" + ADRESS.Text + "',N'" + PHONE.Text + "',N'" + GENDER.Text + "',N'" + AGE.Text + "',N'" + DIAGNOSIS.Text + "','" + s + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(text1, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                    }
                    if (TYPE.Text == "Kobry El Kobba")
                    {

                        string text2 = "insert into KOBRY_ElKOBBA values (N'" + PATIENT_ID.Text + "',N'" + PATIENT_NAME.Text + "',N'" + ADRESS.Text + "',N'" + PHONE.Text + "',N'" + GENDER.Text + "',N'" + AGE.Text + "',N'" + DIAGNOSIS.Text + "',N'" + s + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(text2, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                    }
                    if (TYPE.Text == "Not Kobry El Kobba")
                    {

                        string text3 = "insert into NOT_KOBRY_ElKOBBA values (N'" + PATIENT_ID.Text + "',N'" + PATIENT_NAME.Text + "',N'" + ADRESS.Text + "',N'" + PHONE.Text + "',N'" + GENDER.Text + "',N'" + AGE.Text + "',N'" + DIAGNOSIS.Text + "',N'" + s + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(text3, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                    }
                    PATIENT_NAME.Text = " ";
                    ADRESS.Text = " ";
                    PHONE.Text = " ";
                    GENDER.Text = " ";
                    AGE.Text = " ";
                    DIAGNOSIS.Text = " ";


                }






                cmd.Connection = conn;

                cmd.CommandText = "SELECT COUNT(PATIENT_ID) FROM PATIENTS ";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                int m = (Int32)(cmd.ExecuteScalar());

                if (m == 0)
                {
                    PATIENT_ID.Text = 1.ToString();

                }
                else
                {



                    m = m + 1;
                    PATIENT_ID.Text = m.ToString();
                }

                conn.Close();

            }
             

        }

        private void add_patient_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;

            cmd.CommandText = "SELECT COUNT(PATIENT_ID) FROM PATIENTS ";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            int m = (Int32)(cmd.ExecuteScalar());

            if (m == 0)
            {
                PATIENT_ID.Text = 1.ToString();

            }
            else
            {
                m = m + 1;
                PATIENT_ID.Text = m.ToString();

            }


            conn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
