using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHJ_II_HarjotustehtäväRistinolla
{
    public partial class DrawForm : Form
    {


        public bool computerplayer = false;
        private bool playerOneTurn = true;
        //these tell if the spot is taken or not
        private bool oneOne = false;
        private bool oneTwo = false;
        private bool oneThree = false;
        private bool twoOne = false;
        private bool twoTwo = false;
        private bool twoThree = false;
        private bool threeOne = false;
        private bool threeTwo = false;
        private bool threeThree = false;

        //these are for checking if there is a 3 mark row of either X or O
        private bool oneOneX = false;
        private bool oneTwoX = false;
        private bool oneThreeX = false;
        private bool twoOneX = false;
        private bool twoTwoX = false;
        private bool twoThreeX = false;
        private bool threeOneX = false;
        private bool threeTwoX = false;
        private bool threeThreeX = false;

        private bool oneOneO = false;
        private bool oneTwoO = false;
        private bool oneThreeO = false;
        private bool twoOneO = false;
        private bool twoTwoO = false;
        private bool twoThreeO = false;
        private bool threeOneO = false;
        private bool threeTwoO = false;
        private bool threeThreeO = false;
        //for checking AI switch-case loop
        bool wasTaken = false;
        public DrawForm()
        {
            InitializeComponent();
            /*
            while (playerOneTurn)
            {
                //here the code where to increase player's total time played?
            }
            */
        }
        public void DrawForm_MouseClick(object sender, MouseEventArgs e)
        {

            this.backgroundWorker1.RunWorkerAsync();
        }
        
        // does not work, for some reason after couple of clicks, it goes unresponsive, and if i click fast in the start, it goes so after one click.
        public void CheckPlayStuff()
        {
            lblPlayer1FullName.Text = PointToClient(Cursor.Position).ToString();
            Point mouseCurrent = PointToClient(Cursor.Position);
            //following 2 IF's check if there has been a 3 mark row of either X or O to see if either has won.
            if ((oneOneX && oneTwoX && oneThreeX) || (oneOneX && twoTwoX && threeThreeX) || (twoOneX && twoTwoX && twoThreeX) || (threeOneX && threeTwoX && threeThreeX) || (oneThreeX && !twoTwoX && threeOneX) || (oneOneX && twoOneX && threeOneX)
                 || (oneTwoX && twoTwoX && threeTwoX) || (oneThreeX && twoThreeX && twoThreeX))
            {
                //X won the game
                //need to add code for saving scores to current players saved info
                MessageBox.Show("X won!");


            }
            else if ((oneOneO && oneTwoO && oneThreeO) || (oneOneO && twoTwoO && threeThreeO) || (twoOneO && twoTwoO && twoThreeO) || (threeOneO && threeTwoO && threeThreeO) || (oneThreeO && twoTwoO && threeOneO) || (oneOneO && twoOneO && threeOneO)
                 || (oneTwoO && twoTwoO && threeTwoO) || (oneThreeO && twoThreeO && twoThreeO))

            {
                // O won the game
                //need to add code for saving scores to current player 2 / AI saved info
                MessageBox.Show("O won!");

            }
            // checks if it is player 1's turn (player one is always X). If it is, it draws X where he clicks and after that playerOneTurn is set to false. Why does it allow second X to be placed if i spamclick an X i just placed?
            else if (playerOneTurn)
            {
                if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneOne == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 100, 70, 300, 170);
                    drawX.DrawLine(blackPen, 300, 70, 100, 170);
                    oneOne = true;
                    oneOneX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneTwo == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 300, 70, 500, 170);
                    drawX.DrawLine(blackPen, 500, 70, 300, 170);
                    oneTwo = true;
                    oneTwoX = true;
                    blackPen.Dispose();
                    drawX.Dispose();
                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneThree == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 500, 70, 700, 170);
                    drawX.DrawLine(blackPen, 700, 70, 500, 170);
                    oneThree = true;
                    oneThreeX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoOne == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 100, 170, 300, 270);
                    drawX.DrawLine(blackPen, 300, 170, 100, 270);
                    twoOne = true;
                    twoOneX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoTwo == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 300, 170, 500, 270);
                    drawX.DrawLine(blackPen, 500, 170, 300, 270);
                    twoTwo = true;
                    twoTwoX = true;
                    blackPen.Dispose();
                    drawX.Dispose();
                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoThree == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 500, 170, 700, 270);
                    drawX.DrawLine(blackPen, 700, 170, 500, 270);
                    twoThree = true;
                    twoThreeX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeOne == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 100, 270, 300, 370);
                    drawX.DrawLine(blackPen, 300, 270, 100, 370);
                    threeOne = true;
                    threeOneX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeTwo == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 300, 270, 500, 370);
                    drawX.DrawLine(blackPen, 500, 270, 300, 370);
                    threeTwo = true;
                    threeTwoX = true;
                    blackPen.Dispose();
                    drawX.Dispose();
                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeThree == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 500, 270, 700, 370);
                    drawX.DrawLine(blackPen, 700, 270, 500, 370);
                    threeThree = true;
                    threeThreeX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                playerOneTurn = false;
            }
            // PlayerOneTurn is false, thus next drawing is a circle, after that, PlayerOneTurn is set to true.
            else
            {
                //second player is not an AI
                if (!computerplayer)
                {
                    if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneOne == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 150, 70, 100, 100);
                        oneOne = true;
                        oneOneO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneTwo == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 350, 70, 100, 100);
                        oneTwo = true;
                        oneTwoO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneThree == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 550, 70, 100, 100);
                        oneThree = true;
                        oneThreeO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoOne == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 150, 170, 100, 100);
                        twoOne = true;
                        twoOneO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoTwo == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 350, 170, 100, 100);
                        twoTwo = true;
                        twoTwoO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoThree == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 550, 170, 100, 100);
                        twoThree = true;
                        twoThreeO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeOne == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 150, 270, 100, 100);
                        threeOne = true;
                        threeOneO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeTwo == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 350, 270, 100, 100);
                        threeTwo = true;
                        threeTwoO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeThree == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 550, 270, 100, 100);
                        threeThree = true;
                        threeThreeO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    playerOneTurn = true;
                }
                //second player is an AI
                else
                {
                    Random rnd = new Random();
                    int rndCase = rnd.Next(1, 10);

                    while (!wasTaken)
                    {
                        switch (rndCase)
                        {
                            case 1:
                                if (!oneOne)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 150, 70, 100, 100);
                                    oneOne = true;
                                    oneOneO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 2:
                                if (!oneTwo)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 350, 70, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 3:
                                if (!oneThree)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 550, 70, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 4:
                                if (!twoOne)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 150, 170, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 5:
                                if (!twoTwo)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 350, 170, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 6:
                                if (!twoThree)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 550, 170, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 7:
                                if (!threeOne)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 150, 270, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 8:
                                if (!threeTwo)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 350, 270, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 9:
                                if (!threeThree)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 550, 270, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                        }
                    }

                }
                
            }
        }

        private void DrawForm_Load(object sender, EventArgs e)
        {


        }

        private void DrawForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush lgrayBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightGray);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(lgrayBrush, new Rectangle(0, 0, 816, 489));
            lgrayBrush.Dispose();
            Brush whiteBrush = new SolidBrush(Color.White);
            formGraphics.FillRectangle(whiteBrush, new Rectangle(100, 70, 600, 300));
            whiteBrush.Dispose();
            Pen blackPen = new Pen(Color.Black, 5);
            formGraphics.DrawLine(blackPen, 300, 70, 300, 370);
            formGraphics.DrawLine(blackPen, 500, 70, 500, 370);
            formGraphics.DrawLine(blackPen, 100, 170, 700, 170);
            formGraphics.DrawLine(blackPen, 100, 270, 700, 270);
            blackPen.Dispose();

            formGraphics.Dispose();
        }
        /*
        //tried to figure this thing out, it throws errors that it tries to access things out of something.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

           // lblPlayer1FullName.Text = PointToClient(Cursor.Position).ToString();
            Point mouseCurrent = PointToClient(Cursor.Position);
            //following 2 IF's check if there has been a 3 mark row of either X or O to see if either has won.
            if ((oneOneX && oneTwoX && oneThreeX) || (oneOneX && twoTwoX && threeThreeX) || (twoOneX && twoTwoX && twoThreeX) || (threeOneX && threeTwoX && threeThreeX) || (oneThreeX && !twoTwoX && threeOneX) || (oneOneX && twoOneX && threeOneX)
                 || (oneTwoX && twoTwoX && threeTwoX) || (oneThreeX && twoThreeX && twoThreeX))
            {
                //X won the game
                //need to add code for saving scores to current players saved info
                MessageBox.Show("X won!");


            }
            else if ((oneOneO && oneTwoO && oneThreeO) || (oneOneO && twoTwoO && threeThreeO) || (twoOneO && twoTwoO && twoThreeO) || (threeOneO && threeTwoO && threeThreeO) || (oneThreeO && twoTwoO && threeOneO) || (oneOneO && twoOneO && threeOneO)
                 || (oneTwoO && twoTwoO && threeTwoO) || (oneThreeO && twoThreeO && twoThreeO))

            {
                // O won the game
                //need to add code for saving scores to current player 2 / AI saved info
                MessageBox.Show("O won!");

            }
            // checks if it is player 1's turn (player one is always X). If it is, it draws X where he clicks and after that playerOneTurn is set to false. Why does it allow second X to be placed if i spamclick an X i just placed?
            else if (playerOneTurn)
            {
                if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneOne == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 100, 70, 300, 170);
                    drawX.DrawLine(blackPen, 300, 70, 100, 170);
                    oneOne = true;
                    oneOneX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneTwo == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 300, 70, 500, 170);
                    drawX.DrawLine(blackPen, 500, 70, 300, 170);
                    oneTwo = true;
                    oneTwoX = true;
                    blackPen.Dispose();
                    drawX.Dispose();
                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneThree == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 500, 70, 700, 170);
                    drawX.DrawLine(blackPen, 700, 70, 500, 170);
                    oneThree = true;
                    oneThreeX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoOne == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 100, 170, 300, 270);
                    drawX.DrawLine(blackPen, 300, 170, 100, 270);
                    twoOne = true;
                    twoOneX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoTwo == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 300, 170, 500, 270);
                    drawX.DrawLine(blackPen, 500, 170, 300, 270);
                    twoTwo = true;
                    twoTwoX = true;
                    blackPen.Dispose();
                    drawX.Dispose();
                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoThree == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 500, 170, 700, 270);
                    drawX.DrawLine(blackPen, 700, 170, 500, 270);
                    twoThree = true;
                    twoThreeX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeOne == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 100, 270, 300, 370);
                    drawX.DrawLine(blackPen, 300, 270, 100, 370);
                    threeOne = true;
                    threeOneX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeTwo == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 300, 270, 500, 370);
                    drawX.DrawLine(blackPen, 500, 270, 300, 370);
                    threeTwo = true;
                    threeTwoX = true;
                    blackPen.Dispose();
                    drawX.Dispose();
                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeThree == false)
                {
                    Graphics drawX;
                    drawX = this.CreateGraphics();
                    Pen blackPen = new Pen(Color.Black, 5);
                    drawX.DrawLine(blackPen, 500, 270, 700, 370);
                    drawX.DrawLine(blackPen, 700, 270, 500, 370);
                    threeThree = true;
                    threeThreeX = true;
                    blackPen.Dispose();
                    drawX.Dispose();

                }
                playerOneTurn = false;
            }
            // PlayerOneTurn is false, thus next drawing is a circle, after that, PlayerOneTurn is set to true.
            else
            {
                //second player is not an AI
                if (!computerplayer)
                {
                    if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneOne == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 150, 70, 100, 100);
                        oneOne = true;
                        oneOneO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneTwo == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 350, 70, 100, 100);
                        oneTwo = true;
                        oneTwoO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneThree == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 550, 70, 100, 100);
                        oneThree = true;
                        oneThreeO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoOne == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 150, 170, 100, 100);
                        twoOne = true;
                        twoOneO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoTwo == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 350, 170, 100, 100);
                        twoTwo = true;
                        twoTwoO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoThree == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 550, 170, 100, 100);
                        twoThree = true;
                        twoThreeO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeOne == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 150, 270, 100, 100);
                        threeOne = true;
                        threeOneO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeTwo == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 350, 270, 100, 100);
                        threeTwo = true;
                        threeTwoO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeThree == false)
                    {
                        Graphics drawEllipse;
                        drawEllipse = this.CreateGraphics();
                        Pen blackPen = new Pen(Color.Black, 5);
                        drawEllipse.DrawEllipse(blackPen, 550, 270, 100, 100);
                        threeThree = true;
                        threeThreeO = true;
                        blackPen.Dispose();
                        drawEllipse.Dispose();

                    }
                    playerOneTurn = true;
                }
                //second player is an AI
                else
                {
                    Random rnd = new Random();
                    int rndCase = rnd.Next(1, 10);

                    while (!wasTaken)
                    {
                        switch (rndCase)
                        {
                            case 1:
                                if (!oneOne)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 150, 70, 100, 100);
                                    oneOne = true;
                                    oneOneO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 2:
                                if (!oneTwo)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 350, 70, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 3:
                                if (!oneThree)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 550, 70, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 4:
                                if (!twoOne)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 150, 170, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 5:
                                if (!twoTwo)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 350, 170, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 6:
                                if (!twoThree)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 550, 170, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 7:
                                if (!threeOne)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 150, 270, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 8:
                                if (!threeTwo)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 350, 270, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 9:
                                if (!threeThree)
                                {
                                    Graphics drawEllipse;
                                    drawEllipse = this.CreateGraphics();
                                    Pen blackPen = new Pen(Color.Black, 5);
                                    drawEllipse.DrawEllipse(blackPen, 550, 270, 100, 100);
                                    oneTwo = true;
                                    oneTwoO = true;
                                    blackPen.Dispose();
                                    drawEllipse.Dispose();
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                        }
                    }

                }

            }
        }
        */

    }
    }


