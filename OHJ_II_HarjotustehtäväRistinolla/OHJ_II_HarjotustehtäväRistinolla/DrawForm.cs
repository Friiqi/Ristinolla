using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OHJ_II_HarjotustehtäväRistinolla
{
    public partial class DrawForm : Form
    {

        // is 2nd player a computer
        public bool computerplayer;
        public GameScores playerOne;
        public GameScores playerTwo;
        public bool hasGameEnded;
        //checks if it is player one's turn.
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
        private DateTime gameStarted, gameEnded;
        private Random rnd = new Random();


        public DrawForm()
        {
            InitializeComponent();
            gameStarted = DateTime.Now;


        }
        public void DrawForm_MouseClick(object sender, MouseEventArgs e)
        {
            Point mouseCurrent = PointToClient(Cursor.Position);

            CheckPlayStuff(mouseCurrent);
        }


        // checks if either player has drawn a mark on the clicked rectangle area, if not, draws the mark of the currently active player.
        public void ActivePlayerName()
        {
            if (playerOneTurn)
            {
                lblActivePlayerName.Text = playerOne.personScores.firstName;
            }
            else if (!playerOneTurn && !computerplayer)
            {
                lblActivePlayerName.Text = playerTwo.personScores.firstName;
            }
            else if (!playerOneTurn && computerplayer)
            {
                lblActivePlayerName.Text = "Computer";
            }
        }
        public void CheckPlayStuff(Point mouseCurrent)
        {
            

            //checks if X has won


            // checks if it is player 1's turn (player one is always X). If it is, it saves the info on where he clicks and after that playerOneTurn is set to false. 
            if (playerOneTurn)
            {
                if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneOne == false)
                {
                    oneOne = true;
                    oneOneX = true;
                    playerOneTurn = false;

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneTwo == false)
                {
                    oneTwo = true;
                    oneTwoX = true;
                    playerOneTurn = false;

                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneThree == false)
                {
                    oneThree = true;
                    oneThreeX = true;
                    playerOneTurn = false;
                }
                else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoOne == false)
                {
                    twoOne = true;
                    twoOneX = true;
                    playerOneTurn = false;

                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoTwo == false)
                {
                    twoTwo = true;
                    twoTwoX = true;
                    playerOneTurn = false;
                }
                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoThree == false)
                {
                    twoThree = true;
                    twoThreeX = true;
                    playerOneTurn = false;
                }
                else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeOne == false)
                {
                    threeOne = true;
                    threeOneX = true;
                    playerOneTurn = false;
                }
                else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeTwo == false)
                {
                    threeTwo = true;
                    threeTwoX = true;
                    playerOneTurn = false;
                }

                else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeThree == false)
                {
                    threeThree = true;
                    threeThreeX = true;
                    playerOneTurn = false;
                }
                else
                {
                    MessageBox.Show("did not fall into any mouseclick check for drawing X.");
                }
                //second player is an AI. 
                this.Invalidate();
                if (computerplayer)
                {
                    if (!CheckForWinner(false))
                    {
                        int rndTimer = rnd.Next(500, 2001);
                        AINeedsToThink2.Interval = rndTimer;
                        AINeedsToThink2.Start();
                    }

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
                        oneOne = true;
                        oneOneO = true;
                        playerOneTurn = true;
                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneTwo == false)
                    {
                        oneTwo = true;
                        oneTwoO = true;
                        playerOneTurn = true;
                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170) && oneThree == false)
                    {
                        oneThree = true;
                        oneThreeO = true;
                        playerOneTurn = true;
                    }
                    else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoOne == false)
                    {
                        twoOne = true;
                        twoOneO = true;
                        playerOneTurn = true;
                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoTwo == false)
                    {
                        twoTwo = true;
                        twoTwoO = true;
                        playerOneTurn = true;
                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270) && twoThree == false)
                    {
                        twoThree = true;
                        twoThreeO = true;
                        playerOneTurn = true;
                    }
                    else if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeOne == false)
                    {
                        threeOne = true;
                        threeOneO = true;
                        playerOneTurn = true;
                    }
                    else if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeTwo == false)
                    {
                        threeTwo = true;
                        threeTwoO = true;
                        playerOneTurn = true;
                    }
                    else if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370) && threeThree == false)
                    {
                        threeThree = true;
                        threeThreeO = true;
                        playerOneTurn = true;
                    }

                }

            }
            //forces paint-event to happen.
            
        }
        //saves computerplayerinfo twofold for same reason its gives 2x the win message
        private bool CheckForWinner(bool showWinner)
        {
            string winner = "Draw!";
            bool someoneWon = false;
            if ((oneOneX && oneTwoX && oneThreeX) || (oneOneX && twoTwoX && threeThreeX) || (twoOneX && twoTwoX && twoThreeX) || (threeOneX && threeTwoX && threeThreeX) || (oneThreeX && twoTwoX && threeOneX) || (oneOneX && twoOneX && threeOneX)
                || (oneTwoX && twoTwoX && threeTwoX) || (oneThreeX && twoThreeX && threeThreeX))
            {
                playerOne.wins++;
                playerTwo.losses++;
                gameEnded = DateTime.Now;
                TimeSpan duration = gameEnded.Subtract(gameStarted);

                playerOne.totalGamePlayDuration = playerOne.totalGamePlayDuration + duration;
                playerTwo.totalGamePlayDuration = playerTwo.totalGamePlayDuration + duration;
                //  string format = "HH:mm:ss";
                SaveChanges();
                someoneWon = true;
                winner = "X won!";
                //MessageBox.Show("X won!");

            }
            //checks if O has won
            else if ((oneOneO && oneTwoO && oneThreeO) || (oneOneO && twoTwoO && threeThreeO) || (twoOneO && twoTwoO && twoThreeO) || (threeOneO && threeTwoO && threeThreeO) || (oneThreeO && twoTwoO && threeOneO) || (oneOneO && twoOneO && threeOneO)
                 || (oneTwoO && twoTwoO && threeTwoO) || (oneThreeO && twoThreeO && threeThreeO))

            {
                playerTwo.wins++;
                playerOne.losses++;
                gameEnded = DateTime.Now;
                TimeSpan duration = gameEnded.Subtract(gameStarted);

                playerOne.totalGamePlayDuration = playerOne.totalGamePlayDuration + duration;
                playerTwo.totalGamePlayDuration = playerTwo.totalGamePlayDuration + duration;
                SaveChanges();
                someoneWon = true;
                winner = "O won!";
                //MessageBox.Show("O won!");

            }
            //checks if all areas are marked, thus game ending in draw
            else if ((oneOne && oneTwo && oneThree && twoOne && twoTwo & twoThree && threeOne && threeTwo & threeThree) && !someoneWon)
            {
                playerOne.draws++;
                playerTwo.draws++;
                gameEnded = DateTime.Now;
                TimeSpan duration = gameEnded.Subtract(gameStarted);

                playerOne.totalGamePlayDuration = playerOne.totalGamePlayDuration + duration;
                playerTwo.totalGamePlayDuration = playerTwo.totalGamePlayDuration + duration;
              
                SaveChanges();
                someoneWon = true;
                //MessageBox.Show("Draw!");
            }

            if (showWinner && someoneWon)
            {
                MessageBox.Show(winner);
            }
            return someoneWon;
        }
        private void SaveChanges()
        {
            //voin tallennella totalplayedit tässä kans kunhan esittelen.

            string savePath = MainForm.savePathPlayerInfo;
            
            var existingPlayers = GameScores.DeserializeList(savePath);
            for (int i = 0; i < existingPlayers.Count; i++)
            {
                if (existingPlayers[i].personScores.Id == playerOne.personScores.Id)
                {
                    existingPlayers[i] = playerOne;
                }
                else if (existingPlayers[i].personScores.Id == playerTwo.personScores.Id)
                {
                    existingPlayers[i] = playerTwo;
                }
            }
            GameScores.Serialize(existingPlayers, savePath);

            if  (computerplayer)
            {
            string saveCompPath = MainForm.savePathComputerPlayerInfo;
                var existingComputer = GameScores.DeserializeList(saveCompPath);
                existingComputer[0] = playerTwo;
                GameScores.Serialize(existingComputer, saveCompPath);
            }
            
        }
        /*
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
        */
        //produces random numer between 1 and 9, which will trigger a case for drawing to one of the 9 available areas in game, unless that spot has been taken, if so, loops back and tries again, untill it hits an open spot.
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
                            oneOne = true;
                            oneOneO = true;
                            playerOneTurn = true;

                            break;
                        }
                        else

                            break;
                    case 2:
                        if (!oneTwo)
                        {
                            oneTwo = true;
                            oneTwoO = true;
                            playerOneTurn = true;

                            break;
                        }
                        else

                            break;
                    case 3:
                        if (!oneThree)
                        {
                            oneThree = true;
                            oneThreeO = true;
                            playerOneTurn = true;
                            break;
                        }
                        else
                            break;
                    case 4:
                        if (!twoOne)
                        {
                            twoOne = true;
                            twoOneO = true;
                            playerOneTurn = true;
                            break;
                        }
                        else
                            break;
                    case 5:
                        if (!twoTwo)
                        {
                            twoTwo = true;
                            twoTwoO = true;
                            playerOneTurn = true;
                            break;
                        }
                        else
                            break;
                    case 6:
                        if (!twoThree)
                        {
                            twoThree = true;
                            twoThreeO = true;
                            playerOneTurn = true;
                            break;
                        }
                        else
                            break;
                    case 7:
                        if (!threeOne)
                        {
                            threeOne = true;
                            threeOneO = true;
                            playerOneTurn = true;
                            break;
                        }
                        else
                            break;
                    case 8:
                        if (!threeTwo)
                        {
                            threeTwo = true;
                            threeTwoO = true;
                            playerOneTurn = true;
                            break;
                        }
                        else
                            break;
                    case 9:
                        if (!threeThree)
                        {
                            threeThree = true;
                            threeThreeO = true;
                            playerOneTurn = true;

                            break;
                        }
                        else
                            break;
                }


            } while (!playerOneTurn);
            
            //force repainting
            this.Invalidate();

            
        }

        private void DrawForm_Load(object sender, EventArgs e)
        {
            lblPlayer1FullName.Text = playerOne.personScores.Displayname;
            lblPlayer2FullName.Text = playerTwo.personScores.Displayname;
            lblActivePlayerName.Text = playerOne.personScores.firstName;
        }

        private void DrawForm_Paint(object sender, PaintEventArgs e)
        {
            ActivePlayerName();
            DrawgameField();
            DrawMarks();
            //herra ope ei keksinyt ratkaisua, elä anna miinuspisteitä tupla woittotekstille :D
            if (!hasGameEnded)
            {
                hasGameEnded = CheckForWinner(true);
            }
          
           

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
        //draw marks X and O, if CheckPlayStuff() has marked an area for a mark, used in Paint-event
        private void DrawMarks()
        {
            if (oneOneX)
            {
                DrawX(100, 70, 300, 170);
            }
            if (oneTwoX)
            {
                DrawX(300, 70, 500, 170);
            }
            if (oneThreeX)
            {
                DrawX(500, 70, 700, 170);
            }
            if (twoOneX)
            {
                DrawX(100, 170, 300, 270);
            }
            if (twoTwoX)
            {
                DrawX(300, 170, 500, 270);
            }
            if (twoThreeX)
            {
                DrawX(500, 170, 700, 270);
            }
            if (threeOneX)
            {
                DrawX(100, 270, 300, 370);
            }
            if (threeTwoX)
            {
                DrawX(300, 270, 500, 370);
            }
            if (threeThreeX)
            {
                DrawX(500, 270, 700, 370);
            }

            if (oneOneO)
            {
                DrawEllipse(150, 70);
            }
            if (oneTwoO)
            {
                DrawEllipse(350, 70);
            }
            if (oneThreeO)
            {
                DrawEllipse(550, 70);
            }
            if (twoOneO)
            {
                DrawEllipse(150, 170);
            }
            if (twoTwoO)
            {
                DrawEllipse(350, 170);
            }
            if (twoThreeO)
            {
                DrawEllipse(550, 170);
            }
            if (threeOneO)
            {
                DrawEllipse(150, 270);
            }
            if (threeTwoO)
            {
                DrawEllipse(350, 270);
            }
            if (threeThreeO)
            {
                DrawEllipse(550, 270);
            }
        }

        //draws the gameboard.
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

            formGraphics.Dispose();
        }

        private void AINeedsToThink2_Tick(object sender, EventArgs e)
        {
            AINeedsToThink2.Stop();
            AIGamePlay();
        }


    }
}







