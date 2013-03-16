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
        char[] _numbers = new[] { '1', '2', '3' };
        char _currentNumber;

        public Form1()
        {
            InitializeComponent();
            _buttons = new List<Control>() { btnPrevious, btnNext };
            _buttons.ForEach(x => x.Enabled = false);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_learning != null) lblValue.Text = _learning.Next();
            else
            {
                if (_currentNumber == '9')
                {
                    lblValue.Text = "10";
                }
                else
                {
                    _currentNumber++;
                    lblValue.Text = _currentNumber.ToString();
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_learning != null) lblValue.Text = _learning.Previous();
            else
            {
                if (_currentNumber == '1') return;
                if (lblValue.Text == "10") _currentNumber = '9';
                else _currentNumber--;
                lblValue.Text = _currentNumber.ToString();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (_learning != null)
            {
                _learning.Reset();
                lblValue.Text = _learning.CurrentValue;
            }
            else
            {
                _currentNumber = '1';
                lblValue.Text = _currentNumber.ToString();
            }
        }

        private void numbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;

            _currentNumber = _numbers[0];
            lblValue.Text = _currentNumber.ToString();
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
