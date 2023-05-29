using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Windows.Forms;
using System.Threading;

namespace Osama
{
    public partial class update_patient : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
        public update_patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();



            if (comboBox2.Text == "PATIENT ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PATIENTS WHERE PATIENT_ID = '" + textBox1.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from PATIENTS where PATIENT_ID= '" + textBox1.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        PATIENT_ID.Text = dr[0].ToString();
                        PATIENT_NAME.Text = dr[1].ToString();

                        ADRESS.Text = dr[2].ToString();
                        PHONE.Text = dr[3].ToString();

                        GENDER.Text = dr[4].ToString();
                        AGE.Text = dr[5].ToString();
                        DIAGNOSIS.Text = dr[6].ToString();
                        TYPE.Text = dr[8].ToString();

                        string aa = dr["DISEASE"].ToString();
                        string[] a = aa.Split(',');
                        foreach (Control cc in this.Controls)
                        {
                            if (cc is CheckBox)
                            {
                                CheckBox b = (CheckBox)cc;
                                for (int j = 0; j < a.Length; j++)
                                {
                                    if (a[j].ToString() == b.Text)
                                    {
                                        b.Checked = true;
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("This ID Is Not Found");

                    }
                    dr.Close();
                }
            }


            if (comboBox2.Text == "PATIENT Name")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PATIENTS WHERE PATIENT_NAME = '" + textBox1.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from PATIENTS where PATIENT_NAME= '" + textBox1.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        PATIENT_ID.Text = dr[0].ToString();
                        PATIENT_NAME.Text = dr[1].ToString();

                        ADRESS.Text = dr[2].ToString();
                        PHONE.Text = dr[3].ToString();

                        GENDER.Text = dr[4].ToString();
                        AGE.Text = dr[5].ToString();
                        DIAGNOSIS.Text = dr[6].ToString();
                        TYPE.Text = dr[8].ToString();

                        string aa = dr["DISEASE"].ToString();
                        string[] a = aa.Split(',');
                        foreach (Control cc in this.Controls)
                        {
                            if (cc is CheckBox)
                            {
                                CheckBox b = (CheckBox)cc;
                                for (int j = 0; j < a.Length; j++)
                                {
                                    if (a[j].ToString() == b.Text)
                                    {
                                        b.Checked = true;
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("This Name Is Not Found");

                    }
                    dr.Close();
                }
            }


            if (comboBox2.Text == "Phone")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PATIENTS WHERE PHONE = '" + textBox1.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from PATIENTS where PHONE= '" + textBox1.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        PATIENT_ID.Text = dr[0].ToString();
                        PATIENT_NAME.Text = dr[1].ToString();

                        ADRESS.Text = dr[2].ToString();
                        PHONE.Text = dr[3].ToString();

                        GENDER.Text = dr[4].ToString();
                        AGE.Text = dr[5].ToString();
                        DIAGNOSIS.Text = dr[6].ToString();
                        TYPE.Text = dr[8].ToString();

                        string aa = dr["DISEASE"].ToString();
                        string[] a = aa.Split(',');
                        foreach (Control cc in this.Controls)
                        {
                            if (cc is CheckBox)
                            {
                                CheckBox b = (CheckBox)cc;
                                for (int j = 0; j < a.Length; j++)
                                {
                                    if (a[j].ToString() == b.Text)
                                    {
                                        b.Checked = true;
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("This Phone Is Not Found");

                    }
                    dr.Close();
                }
            }
            conn.Close();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want Update This Patiant ?", "Update Patiant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TYPE.Text == "Civil")
                {
                    string s = "";
                    foreach (Control c in this.Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox b = (CheckBox)c;
                            if (b.Checked)
                            {
                                s = b.Text + "," + s;
                            }
                        }
                    }
                    DataTable dt = new DataTable();

                    SqlDataAdapter sda3 = new SqlDataAdapter("Delete  from KOBRY_ElKOBBA WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda3.Fill(dt);
                    SqlDataAdapter sda4 = new SqlDataAdapter("Delete  from NOT_KOBRY_ElKOBBA WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda4.Fill(dt);

                    SqlDataAdapter sda6 = new SqlDataAdapter("Delete  from CIVIL WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda6.Fill(dt);
                    SqlDataAdapter sda1 = new SqlDataAdapter("update PATIENTS set PATIENT_NAME=N'" + PATIENT_NAME.Text + "', ADRESS=N'" + ADRESS.Text + "' , PHONE='" + PHONE.Text + "',GENDER=N'" + GENDER.Text + "',AGE=N'" + AGE.Text + "',DIAGNOSIS=N'" + DIAGNOSIS.Text + "', DISEASE='" + s + "', TYBE=N'" + TYPE.Text + "' where PATIENT_ID =N'" + PATIENT_ID.Text + "'", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda1.Fill(dt);

                    string text1 = "insert into civil values (N'" + PATIENT_ID.Text + "',N'" + PATIENT_NAME.Text + "',N'" + ADRESS.Text + "',N'" + PHONE.Text + "',N'" + GENDER.Text + "','" + AGE.Text + "',N'" + DIAGNOSIS.Text + "',N'" + s + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(text1, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    dt = new DataTable();
                    sda.Fill(dt);


                    MessageBox.Show("Updated Successfully");

                }

                if (TYPE.Text == "Kobry El Kobba")
                {
                    string s = "";
                    foreach (Control c in this.Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox b = (CheckBox)c;
                            if (b.Checked)
                            {
                                s = b.Text + "," + s;
                            }
                        }
                    }
                    DataTable dt = new DataTable();

                    SqlDataAdapter sda3 = new SqlDataAdapter("Delete  from KOBRY_ElKOBBA WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda3.Fill(dt);
                    SqlDataAdapter sda4 = new SqlDataAdapter("Delete  from NOT_KOBRY_ElKOBBA WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda4.Fill(dt);

                    SqlDataAdapter sda6 = new SqlDataAdapter("Delete  from CIVIL WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda6.Fill(dt);
                    SqlDataAdapter sda1 = new SqlDataAdapter("update PATIENTS set PATIENT_NAME=N'" + PATIENT_NAME.Text + "', ADRESS=N'" + ADRESS.Text + "' , PHONE=N'" + PHONE.Text + "',GENDER=N'" + GENDER.Text + "',AGE=N'" + AGE.Text + "',DIAGNOSIS=N'" + DIAGNOSIS.Text + "', DISEASE=N'" + s + "', TYBE=N'" + TYPE.Text + "' where PATIENT_ID =N'" + PATIENT_ID.Text + "'", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda1.Fill(dt);
                    string text1 = "insert into KOBRY_ElKOBBA values (N'" + PATIENT_ID.Text + "',N'" + PATIENT_NAME.Text + "',N'" + ADRESS.Text + "',N'" + PHONE.Text + "',N'" + GENDER.Text + "',N'" + AGE.Text + "',N'" + DIAGNOSIS.Text + "',N'" + s + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(text1, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    dt = new DataTable();
                    sda.Fill(dt);


                    MessageBox.Show("Updated Successfully");

                }



                if (TYPE.Text == "Not Kobry El Kobba")
                {
                    string s = "";
                    foreach (Control c in this.Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox b = (CheckBox)c;
                            if (b.Checked)
                            {
                                s = b.Text + "," + s;
                            }
                        }
                    }
                    DataTable dt = new DataTable();

                    SqlDataAdapter sda3 = new SqlDataAdapter("Delete  from KOBRY_ElKOBBA WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda3.Fill(dt);
                    SqlDataAdapter sda4 = new SqlDataAdapter("Delete  from NOT_KOBRY_ElKOBBA WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda4.Fill(dt);

                    SqlDataAdapter sda6 = new SqlDataAdapter("Delete  from CIVIL WHERE PATIENT_ID = '" + PATIENT_ID.Text + "' ", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda6.Fill(dt);
                    SqlDataAdapter sda1 = new SqlDataAdapter("update PATIENTS set PATIENT_NAME=N'" + PATIENT_NAME.Text + "', ADRESS=N'" + ADRESS.Text + "' , PHONE='" + PHONE.Text + "',GENDER='" + GENDER.Text + "',AGE='" + AGE.Text + "',DIAGNOSIS=N'" + DIAGNOSIS.Text + "', DISEASE='" + s + "', TYBE='" + TYPE.Text + "' where PATIENT_ID ='" + PATIENT_ID.Text + "'", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    sda1.Fill(dt);
                    string text1 = "insert into NOT_KOBRY_ElKOBBA values (N'" + PATIENT_ID.Text + "',N'" + PATIENT_NAME.Text + "',N'" + ADRESS.Text + "',N'" + PHONE.Text + "',N'" + GENDER.Text + "',N'" + AGE.Text + "',N'" + DIAGNOSIS.Text + "',N'" + s + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(text1, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
                    dt = new DataTable();
                    sda.Fill(dt);



                    MessageBox.Show("Updated Successfully");

                }








                PATIENT_NAME.Text = " ";
                ADRESS.Text = " ";
                PHONE.Text = " ";
                GENDER.Text = " ";
                AGE.Text = " ";
                DIAGNOSIS.Text = " ";

                
            }

        }

    }
              
}
