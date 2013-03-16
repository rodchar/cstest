using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPRewards2
{
    public partial class ucListView : UserControl
    {
        public event EventHandler UserControlClicked;

        public ucListView()
        {
            InitializeComponent();
        }

        public void UserControlClick(object sender, EventArgs e)
        {
            if (UserControlClicked != null) UserControlClicked(sender, e);
 
        }
    }
}
