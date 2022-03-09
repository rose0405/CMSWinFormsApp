﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if((txtCarNo.Text =="")||(txtCarNo.Text == null))
            {
                MessageBox.Show("Please Specify a Valid Car Number");
                txtCarNo.Focus ();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCarNo.Text.Length < 6)
            {
                MessageBox.Show("Please Specify a valid car number");
                txtCarNo.Focus();
                return;
            }
            try 
            {
                if (Convert.ToInt32(txtCarNo.Text) < 1)
                {
                    MessageBox.Show("Please Specify a valid worker Id");
                    txtWorkerld.Focus();
                    return;
                }
                if (Convert.ToDateTime(dateTimePicker1.Value) > DateTime.Today)
                {
                    MessageBox.Show("Please Specify a valid Date");
                    dateTimePicker1.Focus();
                    return;
                }

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void JobDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
