using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontDialogSample;
using System.Windows;
using System.Windows.Interop;
using System.Xaml;
using System.Windows.Forms.Integration;
namespace WFTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontChooser fontchooser = new FontChooser();
            ElementHost.EnableModelessKeyboardInterop(fontchooser);
            WindowInteropHelper helper = new WindowInteropHelper(fontchooser);
            helper.Owner = this.Handle;
            fontchooser.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            if (fontchooser.ShowDialog() == true)
            {
                this.textBox1.Font = fontchooser.myfont;
                this.textBox1.ForeColor = fontchooser._color;
            }
        }
    }
}
