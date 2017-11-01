using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectoryComparer
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            string str = "About\n" +
                "-------------------\n" +
                "DIRECTORY COMPARER v1.0\n" +
                "-------------------\n" +
                "Sanchi Varma\n" +
                "Senior Computer Scientist\n" +
                "+91 9958327367\n" +
                "emailsanchi@gmail.com\n" +
                "http://www.sanchivarma.com\n";
            richTextBoxAbout.Text = str;
        }
    }
}
