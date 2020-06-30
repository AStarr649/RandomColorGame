using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Schema;

namespace RandomColorGame
{
    public partial class GameForm : Form
    {

        public Form RefTofrmMain { get; set; }

        public static Random random = new Random();



        public Color rightColor;
        public string rightText;
        public static int Correct = 0, Incorrect = 0, time = 10, round = 1, timeleft = 10, option;
        public char difficulty;


        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            lblTimer.Text = Convert.ToString(time);
            lblCorrect.Text = Convert.ToString(Correct);
            lblWrong.Text = Convert.ToString(Incorrect);

            if (difficulty == 'E')
            {
                lblCommand.Size = new Size(387, 67);
                lblTxtTimer.Location = new Point(215, 484);
                lblTimer.Location = new Point(218, 509);
                btnQuit.Location = new Point(325, 495);
                btnTen.Visible = false;
                btnEleven.Visible = false;
                btnTwelve.Visible = false;
                btnThirteen.Visible = false;
                btnFourteen.Visible = false;
                btnFifteen.Visible = false;
                gameStart(difficulty);
            }
            else if (difficulty == 'N')
            {
                lblCommand.Size = new Size(518, 67);
                lblTxtTimer.Location = new Point(242, 484);
                lblTimer.Location = new Point(245, 509);
                btnQuit.Location = new Point(456, 495);
                btnThirteen.Visible = false;
                btnFourteen.Visible = false;
                btnFifteen.Visible = false;
                gameStart(difficulty);
            }
            else if (difficulty == 'H')
            {
                lblCommand.Size = new Size(649, 67);
                lblTxtTimer.Location = new Point(312, 484);
                lblTimer.Location = new Point(315, 509);
                btnQuit.Location = new Point(587, 495);
                gameStart(difficulty);
            }
        }

        public void timer_Tick()
        {
            gameTimer.Stop();
            gameTimer.Enabled = false;
        }

        private void gameStart(char choice)
        {
            option = random.Next(0, 2);
            gameTimer.Interval = 1000;

            if (choice == 'E')
            {
                set_Easy_Buttons(option);
            }
            else if (choice == 'N')
            {
                set_Normal_Buttons(option);
            }
            else if (choice == 'H')
            {
                set_Hard_Buttons(option);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            gameTimer.Enabled = false;

            Button btnClicked = (Button)sender;

            if (option == 0)
            {
                if (rightColor == btnClicked.BackColor)
                {
                    Correct++;
                    lblCorrect.Text = Convert.ToString(Correct);
                }
                else
                {
                    Incorrect++;
                    lblWrong.Text = Convert.ToString(Incorrect);
                }
            }
            else if (option == 1)
            {
                if (rightText.Equals(btnClicked.Text))
                {
                    Correct++;
                    lblCorrect.Text = Convert.ToString(Correct);
                }
                else
                {
                    Incorrect++;
                    lblWrong.Text = Convert.ToString(Incorrect);
                }
            }

            round++;

            if (round < 5)
            {
                timeleft = 10;
                lblTimer.Text = Convert.ToString(timeleft);
                gameStart(difficulty);
            }
            else if (round >= 5 && round < 10)
            {
                timeleft = 8;
                lblTimer.Text = Convert.ToString(timeleft);
                gameStart(difficulty);
            }
            else
            {
                timeleft = 4;
                lblTimer.Text = Convert.ToString(timeleft);
                gameStart(difficulty);
            }
        }

        private void set_Easy_Buttons(int option)
        {
            Color[] buttonColor = new Color[9];
            String[] buttonWord = new String[9];
            int itemLeft = 9, count = 0, randColor, randWord;

            List<string> selectColor = new List<string> {
                "Red", "Yellow", "Blue",
                "Violet", "Orange", "Green",
                "Cyan", "Magenta", "Teal" };

            List<Color> backColors = new List<Color> {
                Color.Red, Color.Yellow, Color.Blue,
                Color.Violet, Color.Orange, Color.Green,
                Color.Cyan, Color.Magenta, Color.Teal };

            List<Color> textColors = new List<Color> {
                Color.Red, Color.Yellow, Color.Blue,
                Color.Violet, Color.Orange, Color.Green,
                Color.Cyan, Color.Magenta, Color.Teal };

            int answer = random.Next(0, 8);
            string answerTxt = selectColor[answer];
            if (option == 0)
            {
                lblCommand.Text = "Press the " + answerTxt + " button.";
                rightColor = backColors[answer];
            }
            else if (option == 1)
            {
                lblCommand.Text = "Press the button with " + answerTxt + " on it.";
                rightText = selectColor[answer];
            }

            while (count < 9)
            {
                if (itemLeft > 1)
                {
                    randColor = random.Next(itemLeft);
                    randWord = random.Next(itemLeft);
                    while (backColors[randColor] == textColors[randWord])
                    {
                        randColor = random.Next(itemLeft);
                        randWord = random.Next(itemLeft);
                    }
                }
                else
                {
                    randColor = 0;
                    randWord = 0;
                }
                buttonColor[count] = backColors[randColor];
                buttonWord[count] = selectColor[randWord];

                backColors.RemoveAt(randColor);
                selectColor.RemoveAt(randWord);
                textColors.RemoveAt(randWord);
                itemLeft--;
                count++;
            }

            btnOne.BackColor = buttonColor[0];
            btnOne.Text = buttonWord[0];
            btnTwo.BackColor = buttonColor[1];
            btnTwo.Text = buttonWord[1];
            btnThree.BackColor = buttonColor[2];
            btnThree.Text = buttonWord[2];
            btnFour.BackColor = buttonColor[3];
            btnFour.Text = buttonWord[3];
            btnFive.BackColor = buttonColor[4];
            btnFive.Text = buttonWord[4];
            btnSix.BackColor = buttonColor[5];
            btnSix.Text = buttonWord[5];
            btnSeven.BackColor = buttonColor[6];
            btnSeven.Text = buttonWord[6];
            btnEight.BackColor = buttonColor[7];
            btnEight.Text = buttonWord[7];
            btnNine.BackColor = buttonColor[8];
            btnNine.Text = buttonWord[8];

            gameTimer.Enabled = true;
            gameTimer.Start();
        }

        public void set_Normal_Buttons(int option)
        {
            Color[] buttonColor = new Color[12];
            String[] buttonWord = new String[12];
            int itemLeft = 12, count = 0, randColor, randWord;

            List<string> selectColor = new List<string> {
                "Red", "Yellow", "Blue",
                "Violet", "Orange", "Green",
                "Cyan", "Magenta", "Teal",
                "Pink", "Tan", "Purple" };

            List<Color> backColors = new List<Color> {
                Color.Red, Color.Yellow, Color.Blue,
                Color.Violet, Color.Orange, Color.Green,
                Color.Cyan, Color.Magenta, Color.Teal,
                Color.Pink, Color.Tan, Color.Purple };

            List<Color> textColors = new List<Color> {
                Color.Red, Color.Yellow, Color.Blue,
                Color.Violet, Color.Orange, Color.Green,
                Color.Cyan, Color.Magenta, Color.Teal,
                Color.Pink, Color.Tan, Color.Purple };

            int answer = random.Next(0, 11);
            string answerTxt = selectColor[answer];

            if (option == 0)
            {
                lblCommand.Text = "Press the " + answerTxt + " button.";
                rightColor = backColors[answer];
            }
            else if (option == 1)
            {
                lblCommand.Text = "Press the button with " + answerTxt + " on it.";
                rightText = selectColor[answer];
            }

            while (count < 12)
            {
                if (itemLeft > 1)
                {
                    randColor = random.Next(itemLeft);
                    randWord = random.Next(itemLeft);
                    while (backColors[randColor] == textColors[randWord])
                    {
                        randColor = random.Next(itemLeft);
                        randWord = random.Next(itemLeft);
                    }
                }
                else
                {
                    randColor = 0;
                    randWord = 0;
                }
                buttonColor[count] = backColors[randColor];
                buttonWord[count] = selectColor[randWord];

                backColors.RemoveAt(randColor);
                selectColor.RemoveAt(randWord);
                textColors.RemoveAt(randWord);
                itemLeft--;
                count++;
            }

            btnOne.BackColor = buttonColor[0];
            btnOne.Text = buttonWord[0];
            btnTwo.BackColor = buttonColor[1];
            btnTwo.Text = buttonWord[1];
            btnThree.BackColor = buttonColor[2];
            btnThree.Text = buttonWord[2];
            btnFour.BackColor = buttonColor[3];
            btnFour.Text = buttonWord[3];
            btnFive.BackColor = buttonColor[4];
            btnFive.Text = buttonWord[4];
            btnSix.BackColor = buttonColor[5];
            btnSix.Text = buttonWord[5];
            btnSeven.BackColor = buttonColor[6];
            btnSeven.Text = buttonWord[6];
            btnEight.BackColor = buttonColor[7];
            btnEight.Text = buttonWord[7];
            btnNine.BackColor = buttonColor[8];
            btnNine.Text = buttonWord[8];
            btnTen.BackColor = buttonColor[9];
            btnTen.Text = buttonWord[9];
            btnEleven.BackColor = buttonColor[10];
            btnEleven.Text = buttonWord[10];
            btnTwelve.BackColor = buttonColor[11];
            btnTwelve.Text = buttonWord[11];

            gameTimer.Enabled = true;
            gameTimer.Start();
        }
    
        public void set_Hard_Buttons(int option)
        {
            Color[] buttonColor = new Color[15];
            String[] buttonWord = new String[15];
            int itemLeft = 15, count = 0, randColor, randWord;

            List<string> selectColor = new List<string> {
                "Red", "Yellow", "Blue",
                "Violet", "Orange", "Green",
                "Cyan", "Magenta", "Teal",
                "Pink", "Tan", "Purple",
                "Gray", "Lime", "Navy" };

            List<Color> backColors = new List<Color> {
                Color.Red, Color.Yellow, Color.Blue,
                Color.Violet, Color.Orange, Color.Green,
                Color.Cyan, Color.Magenta, Color.Teal,
                Color.Pink, Color.Tan, Color.Purple,
                Color.Gray, Color.Lime, Color.Navy };

            List<Color> textColors = new List<Color> {
                Color.Red, Color.Yellow, Color.Blue,
                Color.Violet, Color.Orange, Color.Green,
                Color.Cyan, Color.Magenta, Color.Teal,
                Color.Pink, Color.Tan, Color.Purple,
                Color.Gray, Color.Lime, Color.Navy };

            int answer = random.Next(0, 14);
            string answerTxt = selectColor[answer];

            if (option == 0)
            {
                lblCommand.Text = "Press the " + answerTxt + " button.";
                rightColor = backColors[answer];
            }
            else if (option == 1)
            {
                lblCommand.Text = "Press the button with " + answerTxt + " on it.";
                rightText = selectColor[answer];
            }

            while (count < 15)
            {
                if (itemLeft > 1)
                {
                    randColor = random.Next(itemLeft);
                    randWord = random.Next(itemLeft);
                    while (backColors[randColor] == textColors[randWord])
                    {
                        randColor = random.Next(itemLeft);
                        randWord = random.Next(itemLeft);
                    }
                }
                else
                {
                    randColor = 0;
                    randWord = 0;
                }
                buttonColor[count] = backColors[randColor];
                buttonWord[count] = selectColor[randWord];

                backColors.RemoveAt(randColor);
                selectColor.RemoveAt(randWord);
                textColors.RemoveAt(randWord);
                itemLeft--;
                count++;
            }

            btnOne.BackColor = buttonColor[0];
            btnOne.Text = buttonWord[0];
            btnTwo.BackColor = buttonColor[1];
            btnTwo.Text = buttonWord[1];
            btnThree.BackColor = buttonColor[2];
            btnThree.Text = buttonWord[2];
            btnFour.BackColor = buttonColor[3];
            btnFour.Text = buttonWord[3];
            btnFive.BackColor = buttonColor[4];
            btnFive.Text = buttonWord[4];
            btnSix.BackColor = buttonColor[5];
            btnSix.Text = buttonWord[5];
            btnSeven.BackColor = buttonColor[6];
            btnSeven.Text = buttonWord[6];
            btnEight.BackColor = buttonColor[7];
            btnEight.Text = buttonWord[7];
            btnNine.BackColor = buttonColor[8];
            btnNine.Text = buttonWord[8];
            btnTen.BackColor = buttonColor[9];
            btnTen.Text = buttonWord[9];
            btnEleven.BackColor = buttonColor[10];
            btnEleven.Text = buttonWord[10];
            btnTwelve.BackColor = buttonColor[11];
            btnTwelve.Text = buttonWord[11];
            btnThirteen.BackColor = buttonColor[12];
            btnThirteen.Text = buttonWord[12];
            btnFourteen.BackColor = buttonColor[13];
            btnFourteen.Text = buttonWord[13];
            btnFifteen.BackColor = buttonColor[14];
            btnFifteen.Text = buttonWord[14];

            gameTimer.Enabled = true;
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                lblTimer.Text = Convert.ToString(timeleft);
            }
            else
            {
                lblCommand.Text = "Time up";
                Incorrect++;
                lblWrong.Text = Convert.ToString(Incorrect);
                gameTimer.Stop();

                round++;

                if (round < 5)
                {
                    timeleft = 10;
                    lblTimer.Text = Convert.ToString(timeleft);
                    gameStart(difficulty);
                }
                else if (round >= 5 && round < 10)
                {
                    timeleft = 8;
                    lblTimer.Text = Convert.ToString(timeleft);
                    gameStart(difficulty);
                }
                else
                {
                    timeleft = 4;
                    lblTimer.Text = Convert.ToString(timeleft);
                    gameStart(difficulty);
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            gameTimer.Enabled = false;
            Correct = 0;
            Incorrect = 0;
            round = 1;
            timeleft = 10;
            this.Close();
            this.RefTofrmMain.Show();
        }     
    }
}
