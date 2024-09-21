using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Image _pic1 = Properties.Resources.pic1;
        private static Image _pic2 = Properties.Resources.pic2;
        private static Image _pic3 = Properties.Resources.pic3;
        private static Image _pic4 = Properties.Resources.pic4;
        private static Image _pic5 = Properties.Resources.pic5;
        private static Image _pic6 = Properties.Resources.pic6;
        private static Image _pic7 = Properties.Resources.pic7;
        private static Image _pic8 = Properties.Resources.pic8;
        private static Image _pic9 = Properties.Resources.pic9;
        private static Image _blackPic = Properties.Resources.R__6_;

        Random _rnd = new Random();

        HashSet<int> _uniqueNumbers = new HashSet<int>();

        short _numberOfMoves = 0;

        Button _blackBtn;

        short _numberOfDifferences = 0;

        TimeSpan _timer = new TimeSpan(0, 0, 30);

        TimeSpan _timerElapsed = new TimeSpan();

        StringBuilder _formattedTimer = new StringBuilder();
        StringBuilder _formattedTimerElapsed  = new StringBuilder();

        enum enGameStatus { Pause, Resume };
        enGameStatus _gameStatus;


        private TimeSpan CalculateTheTimerElapsed()
        {
            TimeSpan ThirtySeconds = new TimeSpan(0, 0, 30);

            _timerElapsed = ThirtySeconds - _timer;         

            return _timerElapsed;
        }

        private string SetTextForWin()
        {
            _formattedTimerElapsed.Clear();

            _formattedTimerElapsed.AppendFormat("{0:00}:{1:00}", CalculateTheTimerElapsed().Minutes, CalculateTheTimerElapsed().Seconds);

            return "Congratulations.. Your Cat Is Happy :-)\nTime Elapsed: " + _formattedTimerElapsed + "\nTotal Moves Made: " + _numberOfMoves;  
        }

        private string SetTextForLoss()
        {
            _formattedTimerElapsed.Clear();

            _formattedTimerElapsed.AppendFormat("{0:00}:{1:00}", CalculateTheTimerElapsed().Minutes, CalculateTheTimerElapsed().Seconds);

            return "Sorry.. Your Cat Is Sad :-(\nTime Elapsed: " + _formattedTimerElapsed + "\nTotal Moves Made: " + _numberOfMoves;   
        }

        private void ResetGame()
        {
            gbPuzzle.Enabled = true;
            btnPause.Enabled = true;

            //Pictures
            ShuffleThePictures();

            //Timer
            timer1.Stop();

            _timer = new TimeSpan(0, 0, 30);

            TimeSpan Zero = TimeSpan.Zero;

            _formattedTimer.AppendFormat("{0:00}:{1:00}", Zero.Minutes, Zero.Seconds);

            lblTimer.Text = _formattedTimer.ToString();

            _formattedTimer.Clear();

            lblTimer.ForeColor = Color.Green;

            //Moves
            _numberOfMoves = 0;
            lblMoves.Text = _numberOfMoves.ToString();

            timer1.Start();
        }

        private void RecoverLostPicture()
        {
            if (_blackBtn == btn1)
                _blackBtn.Image = _pic1;

            else if (_blackBtn == btn2)
                _blackBtn.Image = _pic2;

            else if (_blackBtn == btn3)
                _blackBtn.Image = _pic3;

            else if (_blackBtn == btn4)
                _blackBtn.Image = _pic4;

            else if (_blackBtn == btn5)
                _blackBtn.Image = _pic5;

            else if (_blackBtn == btn6)
                _blackBtn.Image = _pic6;

            else if (_blackBtn == btn7)
                _blackBtn.Image = _pic7;

            else if (_blackBtn == btn8)
                _blackBtn.Image = _pic8;

            else if (_blackBtn == btn9)
                _blackBtn.Image = _pic9;
        }

        private bool WhenToWin()
        {
            if ((int)btn1.Tag != 1)
                ++_numberOfDifferences;

            if ((int)btn2.Tag != 2)
                ++_numberOfDifferences;

            if ((int)btn3.Tag != 3)
                ++_numberOfDifferences;

            if ((int)btn4.Tag != 4)
                ++_numberOfDifferences;

            if ((int)btn5.Tag != 5)
                ++_numberOfDifferences;

            if ((int)btn6.Tag != 6)
                ++_numberOfDifferences;

            if ((int)btn7.Tag != 7)
                ++_numberOfDifferences;

            if ((int)btn8.Tag != 8)
                ++_numberOfDifferences;

            if ((int)btn9.Tag != 9)
                ++_numberOfDifferences;


            if (_numberOfDifferences == 1)
                return true;
            
            _numberOfDifferences = 0;

            return false;
        }

        private void Swap(Button clickedButton)
        {
            Image tempImage = clickedButton.Image;

            clickedButton.Image = _blackBtn.Image;

            _blackBtn.Image = tempImage;
            _blackBtn.Tag = clickedButton.Tag;
            _blackBtn = clickedButton;

            clickedButton.Tag = 0;

            if (WhenToWin())
            {
                timer1.Stop();
                RecoverLostPicture();
                MessageBox.Show(SetTextForWin(), "Cat Puzzle");

                gbPuzzle.Enabled = false;

                btnPause.Enabled = false;

            }
        }

        private void FillHashSet()
        {
            _uniqueNumbers.Clear();

            while (_uniqueNumbers.Count < 9)
            {
                int randomNumber = _rnd.Next(1, 10);

                if (!_uniqueNumbers.Contains(randomNumber))
                {
                    _uniqueNumbers.Add(randomNumber);
                }
            }
        }

        private void SetImage(int number, Button btn)
        {
            switch (number)
            {
                case 1:
                    btn.Image = _pic1;
                    btn.Tag = 1;
                    break;

                case 2:
                    btn.Image = _pic2;
                    btn.Tag = 2;
                    break;

                case 3:
                    btn.Image = _pic3;
                    btn.Tag = 3;
                    break;

                case 4:
                    btn.Image = _pic4;
                    btn.Tag = 4;
                    break;

                case 5:
                    btn.Image = _pic5;
                    btn.Tag = 5;
                    break;

                case 6:
                    btn.Image = _pic6;
                    btn.Tag = 6;
                    break;

                case 7:
                    btn.Image = _pic7;
                    btn.Tag = 7;
                    break;

                case 8:
                    btn.Image = _pic8;
                    btn.Tag = 8;
                    break;

                case 9:
                    btn.Image = _pic9;
                    btn.Tag = 9;
                    break;
            }
        }

        private void SetBlackPic()
        {
            int randomButton = _rnd.Next(1, 10);

            switch (randomButton)
            {
                case 1:
                    btn1.Image = _blackPic;
                    _blackBtn = btn1;

                    break;

                case 2:
                    btn2.Image = _blackPic;
                    _blackBtn = btn2;

                    break;

                case 3:
                    btn3.Image = _blackPic;
                    _blackBtn = btn3;

                    break;

                case 4:
                    btn4.Image = _blackPic;
                    _blackBtn = btn4;

                    break;

                case 5:
                    btn5.Image = _blackPic;
                    _blackBtn = btn5;

                    break;

                case 6:
                    btn6.Image = _blackPic;
                    _blackBtn = btn6;

                    break;

                case 7:
                    btn7.Image = _blackPic;
                    _blackBtn = btn7;

                    break;

                case 8:
                    btn8.Image = _blackPic;
                    _blackBtn = btn8;

                    break;

                case 9:
                    btn9.Image = _blackPic;
                    _blackBtn = btn9;

                    break;
            }
        }

        private void ShuffleThePictures()
        {
            FillHashSet();

            SetImage(_uniqueNumbers.ElementAt(0), btn1);
            SetImage(_uniqueNumbers.ElementAt(1), btn2);
            SetImage(_uniqueNumbers.ElementAt(2), btn3);
            SetImage(_uniqueNumbers.ElementAt(3), btn4);
            SetImage(_uniqueNumbers.ElementAt(4), btn5);
            SetImage(_uniqueNumbers.ElementAt(5), btn6);
            SetImage(_uniqueNumbers.ElementAt(6), btn7);
            SetImage(_uniqueNumbers.ElementAt(7), btn8);
            SetImage(_uniqueNumbers.ElementAt(8), btn9);

            SetBlackPic();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            IncreaseTheMoves();

            Swap(btn8);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            IncreaseTheMoves();

            Swap(btn5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShuffleThePictures();

            timer1.Start();

            _gameStatus = enGameStatus.Pause;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void IncreaseTheMoves()
        {
            _numberOfMoves++;

            lblMoves.Text = _numberOfMoves.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            IncreaseTheMoves();

            Swap(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            IncreaseTheMoves();

            Swap(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            IncreaseTheMoves();

            Swap(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            IncreaseTheMoves();

            Swap(btn4);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            IncreaseTheMoves();

            Swap(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            IncreaseTheMoves();

            Swap(btn7);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            IncreaseTheMoves();

            Swap(btn9);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan OneSecond = new TimeSpan(0, 0, 1);

            _timer -= OneSecond;

            _formattedTimer.AppendFormat("{0:00}:{1:00}", _timer.Minutes, _timer.Seconds);

            lblTimer.Text = _formattedTimer.ToString();

            _formattedTimer.Clear();

            if (_timer.Seconds == 10)
                lblTimer.ForeColor = Color.Red;

            if (_timer <= TimeSpan.Zero)
            {
                timer1.Stop();

                MessageBox.Show(SetTextForLoss(), "Time's up");

                btnPause.Enabled = false;

                gbPuzzle.Enabled = false;

                //ResetGame();
            }
        }
      
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_gameStatus == enGameStatus.Pause)
            {
                btnPause.Text = enGameStatus.Resume.ToString();

                _gameStatus = enGameStatus.Resume;

                timer1.Stop();

                gbPuzzle.Visible = false;

                btnPause.BackColor = Color.Silver;
            }

            else
            {
                btnPause.Text = enGameStatus.Pause.ToString();

                _gameStatus = enGameStatus.Pause;

                timer1.Start();

                gbPuzzle.Visible = true;

                btnPause.BackColor = Color.Cornsilk;
            }
        }
    }
}
