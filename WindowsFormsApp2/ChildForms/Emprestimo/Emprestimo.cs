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
    public partial class Emprestimo : Form
    {
        private Principal _principal;

        public Emprestimo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }
    }
}
