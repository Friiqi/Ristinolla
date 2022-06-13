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

        private int drawWhere = 0;
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
            Point mouseCurrent = PointToClient(Cursor.Position);
            CheckPlayStuff(mouseCurrent);
            if (playerOneTurn)
            {
                switch (drawWhere)
                {
                    case 11:
                        DrawX(100, 70, 300, 170);
                        drawWhere = 0;
                        break;
                    case 12:
                        DrawX(300, 70, 500, 170);
                        drawWhere = 0;
                        break;
                    case 13:
                        DrawX(500, 70, 700, 170);
                        drawWhere = 0;
                        break;
                    case 21:
                        DrawX(100, 170, 300, 270);
                        drawWhere = 0;
                        break;
                    case 22:
                        DrawX(300, 170, 500, 270);
                        drawWhere = 0;
                        break;
                    case 23:
                        DrawX(500, 170, 700, 270);
                        drawWhere = 0;
                        break;
                    case 31:
                        DrawX(100, 270, 300, 370);
                        drawWhere = 0;
                        break;
                    case 32:
                        DrawX(300, 270, 500, 370);
                        drawWhere = 0;
                        break;
                    case 33:
                        DrawX(500, 270, 700, 370);
                        drawWhere = 0;
                        break;
                }
            }
            else 
            {
                switch (drawWhere)
                {
                    case 11:
                        DrawEllipse(150, 70);
                        drawWhere = 0;
                        break;
                    case 12:
                        DrawEllipse(350, 70);
                        drawWhere = 0;
                        break;
                    case 13:
                        DrawEllipse(550, 70);
                        drawWhere = 0;
                        break;
                    case 21:
                        DrawEllipse(150, 170);
                        drawWhere = 0;
                        break;
                    case 22:
                        DrawEllipse(350, 170);
                        drawWhere = 0;
                        break;
                    case 23:
                        DrawEllipse(550, 170);
                        drawWhere = 0;
                        break;
                    case 31:
                        DrawEllipse(150, 270);
                        drawWhere = 0;
                        break;
                    case 32:
                        DrawEllipse(350, 270);
                        drawWhere = 0;
                        break;
                    case 33:
                        DrawEllipse(550, 270);
                        drawWhere = 0;
                        break;
                }
            }


        }

        // does not work, as i understand it, this would use same thread as the GUI thingy, and thus cant function, which is why i tried to fiddle with backgroundworker but dont understand it.
        public void CheckPlayStuff(Point mouseCurrent)
        {
            lblPlayer1FullName.Text = PointToClient(Cursor.Position).ToString();

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

                    drawWhere = 11;
                    oneOne = true;
                    oneOneX = true;
                    //redraws from thex command
                    //this.Invalidate();
                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneTwo == false)
                {
                    drawWhere = 12;
                    oneTwo = true;
                    oneTwoX = true;

                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneThree == false)
                {
                    drawWhere = 13;
                    oneThree = true;
                    oneThreeX = true;
                }
                else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoOne == false)
                {
                    drawWhere = 21;
                    twoOne = true;
                    twoOneX = true;

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoTwo == false)
                {
                    drawWhere = 22;
                    twoTwo = true;
                    twoTwoX = true;
                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoThree == false)
                {
                    drawWhere = 23;
                    twoThree = true;
                    twoThreeX = true;
                }
                else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeOne == false)
                {
                    drawWhere = 31;
                    threeOne = true;
                    threeOneX = true;
                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeTwo == false)
                {
                    drawWhere = 32;
                    threeTwo = true;
                    threeTwoX = true;
                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeThree == false)
                {
                    drawWhere = 33;
                    threeThree = true;
                    threeThreeX = true;
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
                        drawWhere = 11;
                        oneOne = true;
                        oneOneO = true;
                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneTwo == false)
                    {
                        drawWhere = 12;
                        oneTwo = true;
                        oneTwoO = true;
                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneThree == false)
                    {
                        drawWhere = 13;
                        oneThree = true;
                        oneThreeO = true;
                    }
                    else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoOne == false)
                    {
                        drawWhere = 21;
                        twoOne = true;
                        twoOneO = true;
                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoTwo == false)
                    {
                        drawWhere = 22;
                        twoTwo = true;
                        twoTwoO = true;
                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoThree == false)
                    {
                        drawWhere = 23;
                        twoThree = true;
                        twoThreeO = true;
                    }
                    else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeOne == false)
                    {
                        drawWhere = 31;
                        threeOne = true;
                        threeOneO = true;
                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeTwo == false)
                    {
                        drawWhere = 32;
                        threeTwo = true;
                        threeTwoO = true;
                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeThree == false)
                    {
                        drawWhere = 33;
                        threeThree = true;
                        threeThreeO = true;
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
                                    drawWhere = 11;
                                    oneOne = true;
                                    oneOneO = true;
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 2:
                                if (!oneTwo)
                                {
                                    drawWhere = 12;
                                    oneTwo = true;
                                    oneTwoO = true;
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 3:
                                if (!oneThree)
                                {
                                    drawWhere = 13;
                                    oneTwo = true;
                                    oneTwoO = true;
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 4:
                                if (!twoOne)
                                {
                                    drawWhere = 21;
                                    oneTwo = true;
                                    oneTwoO = true;
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 5:
                                if (!twoTwo)
                                {
                                    drawWhere = 22;
                                    oneTwo = true;
                                    oneTwoO = true;
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 6:
                                if (!twoThree)
                                {
                                    drawWhere = 23;
                                    oneTwo = true;
                                    oneTwoO = true;
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 7:
                                if (!threeOne)
                                {
                                    drawWhere= 31;
                                    oneTwo = true;
                                    oneTwoO = true;
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 8:
                                if (!threeTwo)
                                {
                                    drawWhere = 32;
                                    oneTwo = true;
                                    oneTwoO = true;
                                    playerOneTurn = true;
                                    break;
                                }
                                else
                                    wasTaken = true;
                                break;
                            case 9:
                                if (!threeThree)
                                {
                                    drawWhere = 33;
                                    oneTwo = true;
                                    oneTwoO = true;
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
                var g = e.Graphics;
                DrawgameField(g);


            }

            private void DrawEllipse(int x, int y)
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, x, y, 100, 100);
                oneOne = true;
                oneOneO = true;
                blackPen.Dispose();
                drawEllipse.Dispose();
            }
            //draw x with inputted coordinates
            private void DrawX(int xStart, int yStart, int xEnd, int yEnd)
            {
                Graphics drawX;
                drawX = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawX.DrawLine(blackPen, xStart, yStart, xEnd, yEnd);
                drawX.DrawLine(blackPen, xStart + 200, yStart, xStart, yEnd);
                oneOne = true;
                oneOneX = true;
                blackPen.Dispose();



            }
            private void DrawgameField(Graphics formGraphics)
            {

                System.Drawing.SolidBrush lgrayBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightGray);
                //System.Drawing.Graphics formGraphics;
                //formGraphics = this.CreateGraphics();
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

                //formGraphics.Dispose();
            }
           
           
        }
    }




   


