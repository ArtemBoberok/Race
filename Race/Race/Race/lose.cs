using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race
{
    public partial class lose : Form
    {
        public lose()
        {
            InitializeComponent();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
