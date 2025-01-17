using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Blank : Form
    {
        public string DockName { get; set; } = "";
        public Blank()
        {
            InitializeComponent();
        }
    }
}
