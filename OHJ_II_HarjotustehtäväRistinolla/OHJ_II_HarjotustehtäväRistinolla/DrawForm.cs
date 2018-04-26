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
        private bool playeOneClicked = false;
        private bool playerTwoClicked = false;
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
                //here the code where to increase player's total time played? where would this be best put?
            }
            */
        }
        public void DrawForm_MouseClick(object sender, MouseEventArgs e)
        {
            Point mouseCurrent = PointToClient(Cursor.Position);
            
            CheckPlayStuff(mouseCurrent);
            //inputs the current coordinates to the DrawX or DrawEllipse for drawing the players mark, if the clicked area passes through CheckPlayStuff() checks, and then the drawing of the mark happens with DrawX/DrawEllipse.
            /*
            if (playeOneClicked && playerOneTurn)
            {
                switch (drawWhere)
                {
                    case 11:
                        DrawX(100, 70, 300, 170);
                        drawWhere = 0;
                        playerOneTurn = false;
                        break;
                    case 12:
                        DrawX(300, 70, 500, 170);
                        drawWhere = 0;
                        playerOneTurn = false;
                        break;
                    case 13:
                        DrawX(500, 70, 700, 170);
                        drawWhere = 0;
                        playerOneTurn = false;
                        break;
                    case 21:
                        DrawX(100, 170, 300, 270);
                        drawWhere = 0;
                        playerOneTurn = false;
                        break;
                    case 22:
                        DrawX(300, 170, 500, 270);
                        drawWhere = 0;
                        playerOneTurn = false;
                        break;
                    case 23:
                        DrawX(500, 170, 700, 270);
                        drawWhere = 0;
                        playerOneTurn = false;
                        break;
                    case 31:
                        DrawX(100, 270, 300, 370);
                        drawWhere = 0;
                        playerOneTurn = false;
                        break;
                    case 32:
                        DrawX(300, 270, 500, 370);
                        drawWhere = 0;
                        playerOneTurn = false;
                        break;
                    case 33:
                        DrawX(500, 270, 700, 370);
                        drawWhere = 0;
                        playerOneTurn = false;
                        break;
                }
            }

            //draws second player O marks when click happens, unless it is AI (computerplayer == true)
            else  if (!computerplayer && playerTwoClicked && !playerOneTurn)
                {
                    switch (drawWhere)
                    {
                        case 11:
                            DrawEllipse(150, 70);
                            drawWhere = 0;
                        playerOneTurn = true;
                        break;
                        case 12:
                            DrawEllipse(350, 70);
                            drawWhere = 0;
                        playerOneTurn = true;
                        break;
                        case 13:
                            DrawEllipse(550, 70);
                            drawWhere = 0;
                        playerOneTurn = true;
                        break;
                        case 21:
                            DrawEllipse(150, 170);
                            drawWhere = 0;
                        playerOneTurn = true;
                        break;
                        case 22:
                            DrawEllipse(350, 170);
                            drawWhere = 0;
                        playerOneTurn = true;
                        break;
                        case 23:
                            DrawEllipse(550, 170);
                            drawWhere = 0;
                        playerOneTurn = true;
                        break;
                        case 31:
                            DrawEllipse(150, 270);
                            drawWhere = 0;
                        playerOneTurn = true;
                        break;
                        case 32:
                            DrawEllipse(350, 270);
                            drawWhere = 0;
                        playerOneTurn = true;
                        break;
                        case 33:
                            DrawEllipse(550, 270);
                            drawWhere = 0;
                        playerOneTurn = true;
                        break;
                    }
                }
            */

        }



        // checks if either player has drawn a mark on the square in question, if not, draws the mark of the currently active player.
        
        public void CheckPlayStuff(Point mouseCurrent)
        {
          

            //following 2 IF's check if there has been a 3 mark row of either X or O to see if either has won.
            if ((oneOneX && oneTwoX && oneThreeX) || (oneOneX && twoTwoX && threeThreeX) || (twoOneX && twoTwoX && twoThreeX) || (threeOneX && threeTwoX && threeThreeX) || (oneThreeX && twoTwoX && threeOneX) || (oneOneX && twoOneX && threeOneX)
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

            // checks if it is player 1's turn (player one is always X). If it is, it draws X where he clicks and after that playerOneTurn is set to false. 

            else if (playerOneTurn)
            {
                if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneOne == false)
                {

                    drawWhere = 11;
                    oneOne = true;
                    oneOneX = true;
                    DrawX(100, 70,300, 170);
                    playerOneTurn = false;
                    playeOneClicked = true;

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneTwo == false)
                {
                    drawWhere = 12;
                    oneTwo = true;
                    oneTwoX = true;
                    DrawX(300, 70,500, 170);
                    playerOneTurn = false;
                    playeOneClicked = true;

                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneThree == false)
                {
                    drawWhere = 13;
                    oneThree = true;
                    oneThreeX = true;
                    DrawX(500, 70, 700, 170);
                    playerOneTurn = false;
                    playeOneClicked = true;
                }
                else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoOne == false)
                {
                    drawWhere = 21;
                    twoOne = true;
                    twoOneX = true;
                    DrawX(100, 170, 300, 270);
                    playerOneTurn = false;
                    playeOneClicked = true;

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoTwo == false)
                {
                    drawWhere = 22;
                    twoTwo = true;
                    twoTwoX = true;
                    DrawX(300, 170, 500, 270);
                    playerOneTurn = false;
                    playeOneClicked = true;
                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoThree == false)
                {
                    drawWhere = 23;
                    twoThree = true;
                    twoThreeX = true;
                    DrawX(500, 170, 700, 270);
                    playerOneTurn = false;
                    playeOneClicked = true;
                }
                else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeOne == false)
                {
                    drawWhere = 31;
                    threeOne = true;
                    threeOneX = true;
                    DrawX(100, 270, 300, 370);
                    playerOneTurn = false;
                    playeOneClicked = true;
                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeTwo == false)
                {
                    drawWhere = 32;
                    threeTwo = true;
                    threeTwoX = true;
                    DrawX(300, 270, 500, 370);
                    playerOneTurn = false;
                    playeOneClicked = true;
                }
              
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeThree == false)
                {
                    drawWhere = 33;
                    threeThree = true;
                    threeThreeX = true;
                    DrawX(500, 270, 700, 370);
                    playerOneTurn = false;
                    playeOneClicked = true;
                }
                else
                {
                    MessageBox.Show("did not fall into any mouseclick check for drawing.");
                }
               
            }
            // PlayerOneTurn is false, thus next drawing is a circle, after that, PlayerOneTurn is set to true.
            else if (!playerOneTurn)
            {
                //second player is not an AI
                if (!computerplayer)
                {
                    if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneOne == false)
                    {
                        drawWhere = 11;
                        oneOne = true;
                        oneOneO = true;
                        DrawEllipse(150, 70);
                        playerOneTurn = true;
                        playerTwoClicked = true;
                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneTwo == false)
                    {
                        drawWhere = 12;
                        oneTwo = true;
                        oneTwoO = true;
                        DrawEllipse(350, 70);
                        playerOneTurn = true;
                        playerTwoClicked = true;
                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneThree == false)
                    {
                        drawWhere = 13;
                        oneThree = true;
                        oneThreeO = true;
                        DrawEllipse(550, 70);
                        playerOneTurn = true;
                        playerTwoClicked = true;
                    }
                    else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoOne == false)
                    {
                        drawWhere = 21;
                        twoOne = true;
                        twoOneO = true;
                        DrawEllipse(150, 170);
                        playerOneTurn = true;
                        playerTwoClicked = true;
                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoTwo == false)
                    {
                        drawWhere = 22;
                        twoTwo = true;
                        twoTwoO = true;
                        DrawEllipse(350, 170);
                        playerOneTurn = true;
                        playerTwoClicked = true;
                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoThree == false)
                    {
                        drawWhere = 23;
                        twoThree = true;
                        twoThreeO = true;
                        DrawEllipse(550, 170);
                        playerOneTurn = true;
                        playerTwoClicked = true;
                    }
                    else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeOne == false)
                    {
                        drawWhere = 31;
                        threeOne = true;
                        threeOneO = true;
                        DrawEllipse(150, 270);
                        playerOneTurn = true;
                        playerTwoClicked = true;
                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeTwo == false)
                    {
                        drawWhere = 32;
                        threeTwo = true;
                        threeTwoO = true;
                        DrawEllipse(350, 270);
                        playerOneTurn = true;
                        playerTwoClicked = true;
                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeThree == false)
                    {
                        drawWhere = 33;
                        threeThree = true;
                        threeThreeO = true;
                        DrawEllipse(550, 270);
                        playerOneTurn = true;
                        playerTwoClicked = true;
                    }
                    
                }

            
                //second player is an AI. Need to move this to happen outside of mouseclick_event.
                else
                {
                    AIGamePlay();
                    MessageBox.Show("Playertwo side something is wrong");
                 
                }
                


            }
        }


        private void AIDraw()
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
        //this should produce a random spot on the gameboard where to draw AI's mark, if its taken ,it rolls new random and tries again. this only happens atm when player clicks the gameboard tho, and seems like X always wins for some reason. NEEDS FIXING
        private void AIGamePlay()
        {
            Random rnd = new Random();
           
           
            do
            {
                int rndCase = rnd.Next(1, 10);
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
                            drawWhere = 31;
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
                   
                
            } while (!wasTaken);
            wasTaken = false;
            
            AIDraw();
        }

            private void DrawForm_Load(object sender, EventArgs e)
            {
            

        }

            private void DrawForm_Paint(object sender, PaintEventArgs e)
            {
            //is this the only place where this works? how about when it draws over already drawn X / O marks? why does it draw over when either player wins? 
            DrawgameField();

        }
        //for drawing O mark in inputted coordinates
            private void DrawEllipse(int x, int y)
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, x, y, 100, 100);
                
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
               
                blackPen.Dispose();



            }
        //draws the gameboard. does not do this. why.
            private void DrawgameField()
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

               // formGraphics.Dispose();
            }

        private void DrawForm_MouseMove(object sender, MouseEventArgs e)
        {
            //for cursor tracking purpose, remove when no need for this anymore.
            lblPlayer1FullName.Text = PointToClient(Cursor.Position).ToString();
        }
    }
    }




   


