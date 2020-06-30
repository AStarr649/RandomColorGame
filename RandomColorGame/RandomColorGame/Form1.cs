using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomColorGame
{
    public partial class frmMain : Form
    {
        public const string INSTRUCTIONS = "Random Color Game\n\n" +
            "Press the correct button within the time limit\nbased on the instruction at the top.\n" +
            "Choose a difficulty level, then press the start button.\n\n" +
            "Easy     -   9 buttons\n" +
            "Normal - 12 buttons\n" +
            "Hard     - 15 buttons\n\n" +
            "--Pay attention to the text--\nEither the button OR the text will be the correct\n" +
            "Timer reduces after every 3 rounds.";

        public char choice;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInstruct.Text = INSTRUCTIONS;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoEasy_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoEasy.Checked == true)
            {
                choice = 'E';
                rdoNormal.Checked = false;
                rdoHard.Checked = false;
            }
        }

        private void rdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoNormal.Checked == true)
            {
                choice = 'N';
                rdoEasy.Checked = false;
                rdoHard.Checked = false;
            }
        }

        private void rdoHard_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoHard.Checked == true)
            {
                choice = 'H';
                rdoNormal.Checked = false;
                rdoEasy.Checked = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();

            gameForm.RefTofrmMain = this;

            if(rdoEasy.Checked == true)
            {
                gameForm.Size = new Size(422, 605);
            }
            else if(rdoNormal.Checked == true)
            {
                gameForm.Size = new Size(556, 605);
            }
            else if(rdoHard.Checked == true)
            {
                gameForm.Size = new Size(690, 605);
            }

            gameForm.difficulty = choice;
            this.Visible = false;
            gameForm.Show();
        }
    }
}
