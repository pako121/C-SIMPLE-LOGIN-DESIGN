using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Reg : Form
    {
        string Connection = @"Provider = C:\Users\nielm\OneDrive\Desktop\Code 2023\C# Codes 2023 - BSIT Second Sem\LoginSystem\LoginSystem.sln";
        public Reg()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(Connection)) 
            {
                string query = $"INSERT INTO Table1(first_name,middle_name,last_name) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3 + "')";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Connection = con;

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
               
        }
    }
}
