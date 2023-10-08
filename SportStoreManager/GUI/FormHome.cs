using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormHome : Form
    {
        int i = 0;
        public FormHome()
        {
            InitializeComponent();
        }

        private void timerImg_Tick(object sender, EventArgs e)
        {
            picHome.Image = imageList.Images[i];
            if(i==imageList.Images.Count-1) {
                i = 0;
            }
            else
            {
                i++;
            }

        }
    }
}
