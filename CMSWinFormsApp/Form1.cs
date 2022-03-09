using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobDetailsForm jobDetailsForm = new JobDetailsForm();
            jobDetailsForm.ShowDialog();
        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm workerForm = new WorkerForm();
            workerForm.ShowDialog();
        }

        private class WorkerForm
        {
            public WorkerForm()
            {
            }

            internal void ShowDialog()
            {
                throw new NotImplementedException();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    internal class CustomerForm
    {
        public CustomerForm()
        {
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
