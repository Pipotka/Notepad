using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace notepad
{
    public partial class Blank : Form
    {
        private string dockName = "";

        /// <summary>
        /// Название документа
        /// </summary>
        public string DockName
        {
            get => dockName;
            set
            {
                dockName = value;
                Text = dockName;
            }
        }

        public Blank()
        {
            InitializeComponent();
        }
    }
}
