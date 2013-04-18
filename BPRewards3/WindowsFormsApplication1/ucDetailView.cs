using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ucDetailView : UserControl
    {
        public event EventHandler DetailClickEvent;

        public ucDetailView()
        {
            InitializeComponent();
            btnClose.Visible = false;
        }

        public void DetailsClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                String btnName = (sender as Button).Name;

                if (btnName == "btnSave")
                {
                    //Todo: SaveData();
                    btnSave.Visible = false;
                    btnCancel.Visible = btnSave.Visible;
                    btnClose.Visible = !btnSave.Visible;
                }
                else if (btnName == "btnClose")
                {
                    btnSave.Visible = true;
                    btnCancel.Visible = btnSave.Visible;
                    btnClose.Visible = !btnSave.Visible;
                }
            }

            //Maybe consider passing button name instead of sender?
            if (DetailClickEvent != null) DetailClickEvent(sender, e);
        }

    }
}
