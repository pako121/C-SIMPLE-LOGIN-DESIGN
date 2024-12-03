using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Exit.BackColor = Color.White;
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {
                Youtube yt = new Youtube();
                yt.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Wrong username or password. Try again.");
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reg rg = new Reg();
            rg.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            loginBTN.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            loginBTN.BackColor= Color.Yellow;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackColor= Color.Red;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = Color.Transparent;
        }

        private void regBTN_MouseEnter(object sender, EventArgs e)
        {
            regBTN.BackColor = Color.Yellow;
        }

        private void regBTN_MouseLeave(object sender, EventArgs e)
        {
            regBTN.BackColor= Color.Transparent;
        }

        private void cancelBTN_MouseEnter(object sender, EventArgs e)
        {
            cancelBTN.BackColor = Color.Red;
        }

        private void cancelBTN_MouseLeave(object sender, EventArgs e)
        {
            cancelBTN.BackColor= Color.Transparent;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
