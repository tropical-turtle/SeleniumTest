using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumTest
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnTestWithChrome_Click(object sender, EventArgs e)
        {
            TestWithChrome test = new TestWithChrome();
            test.SetUp();
            rtBoxPossibleExceptionMessage.Text= test.Test_CDN_Application();

        }

        private void btnTestWithFireFox_Click(object sender, EventArgs e)
        {
            TestWithFirefox test = new TestWithFirefox();
            test.SetUp();
            
            rtBoxPossibleExceptionMessage.Text=test.Test_CDN_Application();
            
        }
    }
}
