﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace CRUD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Globaly Define DB Connection
        SqlConnection con = new SqlConnection(@"Data Source=SD4; Initial Catalog=SCHOOL; Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO student VALUES('" + txtNAME.Text + "', '" + txtROLLNO.Text + "', '" + txtCOURSE.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");
            clearData();
            con.Close();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE student SET name = '" + txtNAME.Text + "', roll_no = '" + txtROLLNO.Text + "', course = '" + txtCOURSE.Text + "' WHERE roll_no = '" + txtROLLNO.Text + "' ", con);
            cmd.ExecuteNonQuery();
            clearData();
            MessageBox.Show("Data Updated Successfully.");
            con.Close();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE student WHERE roll_no = '" + txtROLLNO.Text + "' ", con);
            cmd.ExecuteNonQuery();
            clearData();
            MessageBox.Show("Data Deleted Successfully.");
            con.Close();
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearData()
        {
            txtNAME.Clear();
            txtROLLNO.Clear();
            txtCOURSE.Clear();
        }

        private void btnSHOWALL_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM student", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Data Shown Successfully.");
            con.Close();
        }

        private void btnFIND_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE roll_no = '" + txtFIND.Text + "' ", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtNAME.Text = dt.ToString();
            txtROLLNO.Text = dt.ToString();
            txtCOURSE.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            //MessageBox.Show("Data Found Successfully.");
            con.Close();
        }
    }
}
