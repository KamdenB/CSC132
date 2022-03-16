using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CornerstoneAppartments
{
    public partial class InformationForm : Form
    {

        public string optionTitle;
        public string optionText;

        public InformationForm(string title, string text)
        {
            InitializeComponent();
            lblInformation.Text = text;
            this.optionTitle = title;
        }

        private void lblInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
