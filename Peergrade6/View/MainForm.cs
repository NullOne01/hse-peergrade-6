using Peergrade6.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peergrade6
{
    public partial class MainForm : Form
    {
        private MainViewModel viewModel;

        public MainForm() {
            InitializeComponent();
            InitializeControlHandlers();
        }

        /// <summary>
        /// Method 
        /// </summary>
        private void InitializeControlHandlers() {
            viewModel = new MainViewModel();
        }
    }
}
