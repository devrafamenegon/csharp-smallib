using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smallib.ChildForms
{
    public partial class Home : Form
    {
        private Principal _principal;

        public Home(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }
    }
}
