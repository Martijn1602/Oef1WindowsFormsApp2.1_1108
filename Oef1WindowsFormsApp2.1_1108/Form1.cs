using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef1WindowsFormsApp2._1_1108
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // https://www.youtube.com/watch?v=FWKFvYGas6s
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            lbAfwezig.Items.Add(tbToevoegen.Text);
        }

        private void btnAanwezig_Click(object sender, EventArgs e)
        {
            lbAanwezig.Items.Add(lbAfwezig.SelectedItem);
            int i = 0;
            i = lbAfwezig.SelectedIndex;
            lbAfwezig.Items.RemoveAt(i);
        }

        private void btnAfwezig_Click(object sender, EventArgs e)
        {
            lbAfwezig.Items.Add(lbAanwezig.SelectedItem);
            int i = 0;
            i = lbAanwezig.SelectedIndex;
            lbAanwezig.Items.RemoveAt(i);
        }
    }
}
