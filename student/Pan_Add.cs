using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    //  for file operation


namespace student
{
    public partial class Pan_Add : Form
    {
        int i = 0;
        string str;
        String path1 = Environment.CurrentDirectory + "/" + "Index.txt";
        String path2 = Environment.CurrentDirectory + "/" + "Record.txt";


        public Pan_Add()
        {
            InitializeComponent();
        }

        private void Add_Pan_Load(object sender, EventArgs e)
        {
            File.WriteAllText(path1, String.Empty);
            File.WriteAllText(path2, String.Empty);// clear all contents o file
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // write to index file
            using (StreamWriter sw = File.AppendText(path1))
            {
                i++;
                sw.WriteLine(txtPanNo.Text + "|" + i);
                sw.Close();
            }

            // write to Record file
            using (StreamWriter sw = File.AppendText(path2))
            {
                sw.WriteLine(txtPanNo.Text + "|" + txtName.Text + "|" + txtAccNo.Text + "|" + txtIFSC.Text + "|" + txtFatherName.Text + "|" + txtDOB.Text + "|" + richtxtAddress.Text);
                sw.Close();
            }

            txtPanNo.Text = "";
            txtName.Text = "";
            txtIFSC.Text = "";
            txtAccNo.Text = "";
            txtFatherName.Text = "";
            txtDOB.Text = "";
            richtxtAddress.Text = "";

            MessageBox.Show("Record saved successfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
