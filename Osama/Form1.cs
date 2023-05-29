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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
        public Form1()
        {
            InitializeComponent();
        }

        





        private void patients_btn_Click(object sender, EventArgs e)
        {
           


            panelside.Show();



            panel_btn2.Show();



            dashboard1.Hide();
            add_patient1.Show();
            update_patient1.Hide();
            delete_patient1.Hide();



            p1.Hide();
            p2.Show();
            p3.Hide();
            dataGridView1.Hide();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(PATIENT_ID) FROM PATIENTS ";
            cmd.CommandType = CommandType.Text;
            int h = (Int32)(cmd.ExecuteScalar());
            all_patients_countt.Text = h.ToString();



     
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(PATIENT_ID) FROM CIVIL ";
            cmd.CommandType = CommandType.Text;
            int g = (Int32)(cmd.ExecuteScalar());
            civil_countt.Text = g.ToString();



            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(PATIENT_ID) FROM KOBRY_ElKOBBA ";
            cmd.CommandType = CommandType.Text;
            int d = (Int32)(cmd.ExecuteScalar());
            kobry_countt.Text = d.ToString();

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(PATIENT_ID) FROM NOT_KOBRY_ElKOBBA ";
            cmd.CommandType = CommandType.Text;
            int l = (Int32)(cmd.ExecuteScalar());
            not_kobry_countt.Text = l.ToString();

            panelside.Show();



            panel_btn2.Hide();



            dashboard1.Show();
            add_patient1.Hide();
            update_patient1.Hide();
            delete_patient1.Hide();

            panelMenu.Hide();


            p1.Show();
            p2.Hide();
            p3.Hide();

            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            conn.Close();



        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void add_paitent_menu_btn_Click(object sender, EventArgs e)
        {
            panelside.Show();



            panel_btn2.Show();



            dashboard1.Hide();
            add_patient1.Show();
            update_patient1.Hide();
            delete_patient1.Hide();



            p1.Hide();
            p2.Show();
            p3.Hide();

            panelMenu.Hide();


            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
        }

        private void update_paitent_menu_btn_Click(object sender, EventArgs e)
        {
            panelside.Show();



            panel_btn2.Show();



            dashboard1.Hide();
            add_patient1.Hide();
            update_patient1.Show();
            delete_patient1.Hide();



            p1.Hide();
            p2.Show();
            p3.Hide();

            panelMenu.Hide();


            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
        }

        private void delete_paitent_menu_btn_Click(object sender, EventArgs e)
        {
            panelside.Show();



            panel_btn2.Show();



            dashboard1.Hide();
            add_patient1.Hide();
            update_patient1.Hide();
            delete_patient1.Show();



            p1.Hide();
            p2.Show();
            p3.Hide();

            panelMenu.Hide();

            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
        }

        private void dash_btn_Click(object sender, EventArgs e)
        {
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(PATIENT_ID) FROM PATIENTS ";
            cmd.CommandType = CommandType.Text;
            int h = (Int32)(cmd.ExecuteScalar());
            all_patients_countt.Text = h.ToString();




            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(PATIENT_ID) FROM CIVIL ";
            cmd.CommandType = CommandType.Text;
            int g = (Int32)(cmd.ExecuteScalar());
            civil_countt.Text = g.ToString();



            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(PATIENT_ID) FROM KOBRY_ElKOBBA ";
            cmd.CommandType = CommandType.Text;
            int d = (Int32)(cmd.ExecuteScalar());
            kobry_countt.Text = d.ToString();

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(PATIENT_ID) FROM NOT_KOBRY_ElKOBBA ";
            cmd.CommandType = CommandType.Text;
            int l = (Int32)(cmd.ExecuteScalar());
            not_kobry_countt.Text = l.ToString();

            panelside.Show();



            panel_btn2.Hide();



            dashboard1.Show();
            add_patient1.Hide();
            update_patient1.Hide();
            delete_patient1.Hide();



            p1.Show();
            p2.Hide();
            p3.Hide();

            panelMenu.Hide();

            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            conn.Close();
        }

        private void data_show_btn_Click(object sender, EventArgs e)
        {

            panelside.Show();


            panel_btn2.Hide();



            dashboard1.Hide();
            add_patient1.Hide();
            update_patient1.Hide();
            delete_patient1.Hide();



            p1.Hide();
            p2.Hide();
            p3.Show();


            panelMenu.Show();

            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();

            SqlDataAdapter s = new SqlDataAdapter("select * from PATIENTS", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
            DataTable dt = new DataTable();
            s.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            panelside.Show();


            panel_btn2.Hide();



            dashboard1.Hide();
            add_patient1.Hide();
            update_patient1.Hide();
            delete_patient1.Hide();



            p1.Hide();
            p2.Hide();
            p3.Show();


            panelMenu.Show();

            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();



            SqlDataAdapter s = new SqlDataAdapter("select * from PATIENTS", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
            DataTable dt = new DataTable();
            s.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void civil_data_Click(object sender, EventArgs e)
        {
            panelside.Show();


            panel_btn2.Hide();



            dashboard1.Hide();
            add_patient1.Hide();
            update_patient1.Hide();
            delete_patient1.Hide();



            p1.Hide();
            p2.Hide();
            p3.Show();


            panelMenu.Show();

            dataGridView1.Hide();
            dataGridView2.Show();
            dataGridView3.Hide();
            dataGridView4.Hide();



            SqlDataAdapter s = new SqlDataAdapter("select * from CIVIL", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
            DataTable dt = new DataTable();
            s.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void kobry_data_Click(object sender, EventArgs e)
        {
            panelside.Show();


            panel_btn2.Hide();



            dashboard1.Hide();
            add_patient1.Hide();
            update_patient1.Hide();
            delete_patient1.Hide();



            p1.Hide();
            p2.Hide();
            p3.Show();


            panelMenu.Show();

            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Show();
            dataGridView4.Hide();



            SqlDataAdapter s = new SqlDataAdapter("select * from KOBRY_ElKOBBA", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
            DataTable dt = new DataTable();
            s.Fill(dt);
            dataGridView3.DataSource = dt;

        }

        private void not_kobry_data_Click(object sender, EventArgs e)
        {
            panelside.Show();


            panel_btn2.Hide();



            dashboard1.Hide();
            add_patient1.Hide();
            update_patient1.Hide();
            delete_patient1.Hide();



            p1.Hide();
            p2.Hide();
            p3.Show();


            panelMenu.Show();

            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Show();



            SqlDataAdapter s = new SqlDataAdapter("select * from NOT_KOBRY_ElKOBBA", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + System.IO.Path.GetFullPath("clinic_sys.mdf") + ";Integrated Security=True ;");
            DataTable dt = new DataTable();
            s.Fill(dt);
            dataGridView4.DataSource = dt;

        }
    }
}
