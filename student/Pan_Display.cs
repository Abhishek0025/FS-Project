using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace student
{
    public partial class Pan_Display : Form
    {
        public Pan_Display()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void display_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String path2 = Environment.CurrentDirectory + "/" + "Record.txt";
            using (StreamReader reader = new StreamReader(path2))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] strarr = line.Split('|');

                    string[] row = new string[] { strarr[0], strarr[1], strarr[2], strarr[3], strarr[4], strarr[5], strarr[6] };
                    dataGridView1.Rows.Add(row);


                }
            }
        }
    }
}
