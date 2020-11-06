using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class Pan_Management : Form
    {
        public Pan_Management()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPANDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pan_Add f = new Pan_Add(); // creating Add_Pan object
            f.ShowDialog();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pan_Update f = new Pan_Update(); // creating Pan_Update object
            f.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pan_delete f = new Pan_delete(); // creating Pan_delete object
            f.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pan_Search f = new Pan_Search(); // creating Pan_Search object
            f.ShowDialog();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pan_Display f = new Pan_Display(); // creating Pan_Display object
            f.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        

        private void BtnAddnew_Click(object sender, EventArgs e)
        {
            Pan_Add pd = new Pan_Add();
            pd.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Pan_Search pd = new Pan_Search();
            pd.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Pan_Update pd = new Pan_Update();
            pd.ShowDialog();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Pan_Display pd = new Pan_Display();
            pd.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Pan_delete pd = new Pan_delete();
            pd.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
