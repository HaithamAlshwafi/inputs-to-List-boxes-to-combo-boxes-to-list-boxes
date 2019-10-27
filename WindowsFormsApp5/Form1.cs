using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (txtFname.Text != "" && txtLname.Text != "") { 
            lisFName.Items.Add(txtFname.Text);
            lisLName.Items.Add(txtLname.Text);
            txtFname.Text = "";
            txtLname.Text = "";

                lblLB1Count.Text = lisFName.Items.Count.ToString();
                lblLB2Count.Text = lisLName.Items.Count.ToString();

            }
            else
            {
                MessageBox.Show("please check if thier is an empty box");
            }
        }

        private void lisFName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lisLName.SelectedIndex = lisFName.SelectedIndex;
        }

        private void lisLName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lisFName.SelectedIndex = lisLName.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = lisFName.SelectedIndex;
            lisFName.Items.RemoveAt(i);
            lisLName.Items.RemoveAt(i);

            lblLB1Count.Text = lisFName.Items.Count.ToString();
            lblLB2Count.Text = lisLName.Items.Count.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lisFName.Items.Clear();
            lisLName.Items.Clear();

            lblLB1Count.Text = lisFName.Items.Count.ToString();
            lblLB2Count.Text = lisLName.Items.Count.ToString();

        }

        private void comFName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comFName.Items.Add(lisFName.SelectedItem);
            comLName.Items.Add(lisLName.SelectedItem);

            int i = lisFName.SelectedIndex;
            lisFName.Items.RemoveAt(i);
            lisLName.Items.RemoveAt(i);

            lblLB1Count.Text = lisFName.Items.Count.ToString();
            lblLB2Count.Text = lisLName.Items.Count.ToString();

            comFName.SelectedIndex = 0;
            comLName.SelectedIndex = 0;

            lblCFName.Text = comFName.Items.Count.ToString();
            lblCLName.Text = comLName.Items.Count.ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void z(object sender, EventArgs e)
        {

        }
    }
}
