using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace econtact
{
    public partial class Form1 : Form
    {
        // testing out passing string message in the constructor
        private string formMessage;


        public Form1(string message)
        {
            InitializeComponent();
            formMessage = message;
            label1.Text = formMessage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
