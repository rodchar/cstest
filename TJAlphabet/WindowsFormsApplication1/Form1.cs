using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        //Todo: Maybe add some audio for letters or numbers
        //Need to added Numbers class
        ILearning _learning;
        List<Control> _buttons;

        public Form1()
        {
            InitializeComponent();
            _buttons = new List<Control>() { btnPrevious, btnNext };
            _buttons.ForEach(x => x.Enabled = false);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblValue.Text = _learning.Next();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            lblValue.Text = _learning.Previous();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _learning.Reset();
            lblValue.Text = _learning.CurrentValue;
        }

        private void numbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
        }

        private void alphabetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _buttons.ForEach(x => x.Enabled = true);
            
            _learning = new Alphabet();
            lblValue.Text = _learning.CurrentValue;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
