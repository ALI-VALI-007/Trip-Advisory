using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class frmDestination : Form
    {
        public frmDestination()
        {
            InitializeComponent();
        }

        private void frmDestination_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            string curName = frmLogin.getCurUser();
            MessageBox.Show(curName);
        }
    }
}
