using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPRewards2
{
    public partial class Form1 : Form
    {
        ucListView lv;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddNewListView(Object sender)
        {
            TabPage t = sender as TabPage;
            t.Controls.Clear();
            lv = new ucListView();
            lv.UserControlClicked += lv_UserControlClicked;
            t.Controls.Add(lv);
        }


    }
}
