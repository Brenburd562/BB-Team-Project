using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class GameOverScreen : UserControl
    {
        #region global values
        Boolean UpArrowDown, DownArrowDown, RightArrowDown, LeftArrowDown;
        int upCounter = 0;
        int rightCounter = 0;

        public static string nameKeeper;

        List<Scores> name = new List<Scores>();
        #endregion

        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Up:
                    UpArrowDown = true;
                    break;
                case Keys.Down:
                    DownArrowDown = true;
                    break;
                case Keys.Right:
                    RightArrowDown = true;
                    break;
                case Keys.Left:
                    LeftArrowDown = true;
                    break;

                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Up:
                    UpArrowDown = false;
                    break;
                case Keys.Down:
                    DownArrowDown = false;
                    break;
                case Keys.Right:
                    RightArrowDown = false;
                    break;
                case Keys.Left:
                    LeftArrowDown = false;
                    break;

                default:
                    break;
            }
        }


        private void playAgainButton_Click(object sender, EventArgs e)
        {
            #region store name
            string letter1 = letter1Output.Text;
            string letter2 = letter2Output.Text;
            string letter3 = letter3Output.Text;

            Scores newScores = new Scores(letter1, letter2, letter3);

            // TODO - add object to global list
            name.Add(newScores);

            foreach (Scores n in name)
            {
                string l1 = n.letter1;
                string l2 = n.letter2;
                string l3 = n.letter3;

                nameKeeper += l1 + l2 + l3;

                HighScoreScreen hss = new HighScoreScreen();
                hss.Show();
            }
            #endregion

            #region change screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);

            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);

            gs.Focus();
            #endregion
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            #region store name
            string letter1 = letter1Output.Text;
            string letter2 = letter2Output.Text;
            string letter3 = letter3Output.Text;

            Scores newScores = new Scores(letter1, letter2, letter3);

            // TODO - add object to global list
            name.Add(newScores);

            foreach (Scores n in name)
            {
                string l1 = n.letter1;
                string l2 = n.letter2;
                string l3 = n.letter3;

                nameKeeper += l1 + l2 + l3;

                HighScoreScreen hss = new HighScoreScreen();
                hss.Show();
            }
            #endregion

            Application.Exit();
        }

        private void playAgainButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.LightSalmon;
            exitButton.BackColor = Color.LightGray;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.LightSalmon;
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            letter1Output.Text = "A";
            letter2Output.Text = "A";
            letter3Output.Text = "A";

            #region counter setup
            if (RightArrowDown == true)
            {
                upCounter = 0;
                rightCounter++;
            }
            else if (UpArrowDown == true)
            {
                upCounter++;
            }

            if (rightCounter == 0)
            {
                letter3Output.ForeColor = Color.Black;
                letter1Output.ForeColor = Color.Red;
            }
            else if (rightCounter == 1)
            {
                letter1Output.ForeColor = Color.Black;
                letter2Output.ForeColor = Color.Red;
            }
            else if (rightCounter == 2)
            {
                letter2Output.ForeColor = Color.Black;
                letter3Output.ForeColor = Color.Red;
            }
            #endregion

            #region first letter setup
            if (upCounter == 0 && rightCounter == 0)
            {
                letter1Output.Text = "A";
            }
            else if (upCounter == 1 && rightCounter == 0)
            {
                letter1Output.Text = "B";
            }
            else if (upCounter == 2 && rightCounter == 0)
            {
                letter1Output.Text = "C";
            }
            else if (upCounter == 3 && rightCounter == 0)
            {
                letter1Output.Text = "D";
            }
            else if (upCounter == 4 && rightCounter == 0)
            {
                letter1Output.Text = "E";
            }
            else if (upCounter == 5 && rightCounter == 0)
            {
                letter1Output.Text = "F";
            }
            else if (upCounter == 6 && rightCounter == 0)
            {
                letter1Output.Text = "G";
            }
            else if (upCounter == 7 && rightCounter == 0)
            {
                letter1Output.Text = "H";
            }
            else if (upCounter == 8 && rightCounter == 0)
            {
                letter1Output.Text = "I";
            }
            else if (upCounter == 9 && rightCounter == 0)
            {
                letter1Output.Text = "J";
            }
            else if (upCounter == 10 && rightCounter == 0)
            {
                letter1Output.Text = "K";
            }
            else if (upCounter == 11 && rightCounter == 0)
            {
                letter1Output.Text = "L";
            }
            else if (upCounter == 12 && rightCounter == 0)
            {
                letter1Output.Text = "M";
            }
            else if (upCounter == 13 && rightCounter == 0)
            {
                letter1Output.Text = "N";
            }
            else if (upCounter == 14 && rightCounter == 0)
            {
                letter1Output.Text = "O";
            }
            else if (upCounter == 15 && rightCounter == 0)
            {
                letter1Output.Text = "P";
            }
            else if (upCounter == 16 && rightCounter == 0)
            {
                letter1Output.Text = "Q";
            }
            else if (upCounter == 17 && rightCounter == 0)
            {
                letter1Output.Text = "R";
            }
            else if (upCounter == 18 && rightCounter == 0)
            {
                letter1Output.Text = "S";
            }
            else if (upCounter == 19 && rightCounter == 0)
            {
                letter1Output.Text = "T";
            }
            else if (upCounter == 20 && rightCounter == 0)
            {
                letter1Output.Text = "U";
            }
            else if (upCounter == 21 && rightCounter == 0)
            {
                letter1Output.Text = "V";
            }
            else if (upCounter == 22 && rightCounter == 0)
            {
                letter1Output.Text = "W";
            }
            else if (upCounter == 23 && rightCounter == 0)
            {
                letter1Output.Text = "X";
            }
            else if (upCounter == 24 && rightCounter == 0)
            {
                letter1Output.Text = "Y";
            }
            else if (upCounter == 25 && rightCounter == 0)
            {
                letter1Output.Text = "Z";
                upCounter = 0;
            }
            #endregion

            #region second letter setup
            if (upCounter == 0 && rightCounter == 1)
            {
                letter1Output.Text = "A";
            }
            else if (upCounter == 1 && rightCounter == 1)
            {
                letter1Output.Text = "B";
            }
            else if (upCounter == 2 && rightCounter == 1)
            {
                letter1Output.Text = "C";
            }
            else if (upCounter == 3 && rightCounter == 1)
            {
                letter1Output.Text = "D";
            }
            else if (upCounter == 4 && rightCounter == 1)
            {
                letter1Output.Text = "E";
            }
            else if (upCounter == 5 && rightCounter == 1)
            {
                letter1Output.Text = "F";
            }
            else if (upCounter == 6 && rightCounter == 1)
            {
                letter1Output.Text = "G";
            }
            else if (upCounter == 7 && rightCounter == 1)
            {
                letter1Output.Text = "H";
            }
            else if (upCounter == 8 && rightCounter == 1)
            {
                letter1Output.Text = "I";
            }
            else if (upCounter == 9 && rightCounter == 1)
            {
                letter1Output.Text = "J";
            }
            else if (upCounter == 10 && rightCounter == 1)
            {
                letter1Output.Text = "K";
            }
            else if (upCounter == 11 && rightCounter == 1)
            {
                letter1Output.Text = "L";
            }
            else if (upCounter == 12 && rightCounter == 1)
            {
                letter1Output.Text = "M";
            }
            else if (upCounter == 13 && rightCounter == 1)
            {
                letter1Output.Text = "N";
            }
            else if (upCounter == 14 && rightCounter == 1)
            {
                letter1Output.Text = "O";
            }
            else if (upCounter == 15 && rightCounter == 1)
            {
                letter1Output.Text = "P";
            }
            else if (upCounter == 16 && rightCounter == 1)
            {
                letter1Output.Text = "Q";
            }
            else if (upCounter == 17 && rightCounter == 1)
            {
                letter1Output.Text = "R";
            }
            else if (upCounter == 18 && rightCounter == 1)
            {
                letter1Output.Text = "S";
            }
            else if (upCounter == 19 && rightCounter == 1)
            {
                letter1Output.Text = "T";
            }
            else if (upCounter == 20 && rightCounter == 1)
            {
                letter1Output.Text = "U";
            }
            else if (upCounter == 21 && rightCounter == 1)
            {
                letter1Output.Text = "V";
            }
            else if (upCounter == 22 && rightCounter == 1)
            {
                letter1Output.Text = "W";
            }
            else if (upCounter == 23 && rightCounter == 1)
            {
                letter1Output.Text = "X";
            }
            else if (upCounter == 24 && rightCounter == 1)
            {
                letter1Output.Text = "Y";
            }
            else if (upCounter == 25 && rightCounter == 1)
            {
                letter1Output.Text = "Z";
                upCounter = 0;
            }
            #endregion

            #region third letter setup
            if (upCounter == 0 && rightCounter == 2)
            {
                letter1Output.Text = "A";
            }
            else if (upCounter == 1 && rightCounter == 2)
            {
                letter1Output.Text = "B";
            }
            else if (upCounter == 2 && rightCounter == 2)
            {
                letter1Output.Text = "C";
            }
            else if (upCounter == 3 && rightCounter == 2)
            {
                letter1Output.Text = "D";
            }
            else if (upCounter == 4 && rightCounter == 2)
            {
                letter1Output.Text = "E";
            }
            else if (upCounter == 5 && rightCounter == 2)
            {
                letter1Output.Text = "F";
            }
            else if (upCounter == 6 && rightCounter == 2)
            {
                letter1Output.Text = "G";
            }
            else if (upCounter == 7 && rightCounter == 2)
            {
                letter1Output.Text = "H";
            }
            else if (upCounter == 8 && rightCounter == 2)
            {
                letter1Output.Text = "I";
            }
            else if (upCounter == 9 && rightCounter == 2)
            {
                letter1Output.Text = "J";
            }
            else if (upCounter == 10 && rightCounter == 2)
            {
                letter1Output.Text = "K";
            }
            else if (upCounter == 11 && rightCounter == 2)
            {
                letter1Output.Text = "L";
            }
            else if (upCounter == 12 && rightCounter == 2)
            {
                letter1Output.Text = "M";
            }
            else if (upCounter == 13 && rightCounter == 2)
            {
                letter1Output.Text = "N";
            }
            else if (upCounter == 14 && rightCounter == 2)
            {
                letter1Output.Text = "O";
            }
            else if (upCounter == 15 && rightCounter == 2)
            {
                letter1Output.Text = "P";
            }
            else if (upCounter == 16 && rightCounter == 2)
            {
                letter1Output.Text = "Q";
            }
            else if (upCounter == 17 && rightCounter == 2)
            {
                letter1Output.Text = "R";
            }
            else if (upCounter == 18 && rightCounter == 2)
            {
                letter1Output.Text = "S";
            }
            else if (upCounter == 19 && rightCounter == 2)
            {
                letter1Output.Text = "T";
            }
            else if (upCounter == 20 && rightCounter == 2)
            {
                letter1Output.Text = "U";
            }
            else if (upCounter == 21 && rightCounter == 2)
            {
                letter1Output.Text = "V";
            }
            else if (upCounter == 22 && rightCounter == 2)
            {
                letter1Output.Text = "W";
            }
            else if (upCounter == 23 && rightCounter == 2)
            {
                letter1Output.Text = "X";
            }
            else if (upCounter == 24 && rightCounter == 2)
            {
                letter1Output.Text = "Y";
            }
            else if (upCounter == 25 && rightCounter == 2)
            {
                letter1Output.Text = "Z";
                upCounter = 0;
            }
            #endregion

        }
    }
}
