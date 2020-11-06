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
    public partial class Pan_delete : Form
    {
        int flag;
        String path1 = Environment.CurrentDirectory + "/" + "Index.txt";
        String path2 = Environment.CurrentDirectory + "/" + "Record.txt";


        public Pan_delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader(path1))
            {
                int i;
                string ln;
                long no = CountLinesReader(path1);
                for (i = 0; i < no; i++)

                {
                    ln = file.ReadLine();
                    string[] strarr = ln.Split('|');
                    if (string.Compare(txtPanNo.Text, strarr[0]) == 0)
                    {
                        flag = i;  //  i is line to be deleted
                    }
                }

              file.Close();
            }

            // delete line in index
            List<string> linesList1 = File.ReadAllLines(path1).ToList();
            linesList1.RemoveAt(flag);
            File.WriteAllLines(path1, linesList1.ToArray());


            // delete line in Record
            List<string> linesList2 = File.ReadAllLines(path2).ToList();
            linesList2.RemoveAt(flag);
            File.WriteAllLines(path2, linesList2.ToArray());


            MessageBox.Show("Record Deleted Successfully");

        }


        //count no of lines in file
        long CountLinesReader(String path2)
        {
            var lineCounter = 0L;
            using (var reader = new StreamReader(path2))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                }
                return lineCounter;

            }
        }

               
    }
}
