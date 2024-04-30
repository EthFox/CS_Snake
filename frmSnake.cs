using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_v2
{
	public partial class frmSnake : Form
	{
		private List<SnakeRect> BodyList = new List<SnakeRect>(); // SnakeRect works the exact same as a normal rectangle, but also contains a direction property
		string dirname = Directory.GetCurrentDirectory(); // dynamically gets directory of project
		char lastKeyPressed = '\0'; // allows the prevention of illeagal move attempts, like attempting to go down while moving up
		bool keyDelay = false; // only allows one input per tick, makes for smoother gameplay
		bool tailPause = false; // when an apple is eaten, the tail needs to pause for a tick to allow room for the new body
		int Score = 0;

		public frmSnake()
		{
			InitializeComponent();
		}

		private void frmSnake_Load(object sender, EventArgs e)
		{
			initializeGame();
		}

		private void initializeGame()
		{
			// sets up initial snake
			SnakeHead.Parent = Grid; // parent mainly means transparent parts show the grid and not the background of the form (can be seen in the form preview)
			SnakeTail.Parent = Grid;
			SnakeHead.Location = new Point(120, 280);
			SnakeTail.Location = new Point(0, 280);

			SnakeHead.Tag = "Right";

			SnakeRect HeadRect = new SnakeRect(); // essentially works as a hitbox for the head and tail, as they are picture boxes and thus dont work with the intersects method
			SnakeRect TailRect = new SnakeRect();

			HeadRect.Location = SnakeHead.Location;
			HeadRect.Direction = "Right";

			TailRect.Location = SnakeTail.Location;
			TailRect.Direction = "Right";

			SnakeRect InitialBody1 = new SnakeRect(); // setup intial body segments
			SnakeRect InitialBody2 = new SnakeRect();

			InitialBody1.Location = new Point(40, 280);
			InitialBody1.Direction = "Right";

			InitialBody2.Location = new Point(80, 280);
			InitialBody2.Direction = "Right";

			BodyList.Add(HeadRect); // order of parts insterted into list matters
			BodyList.Add(InitialBody1);
			BodyList.Add(InitialBody2);
			BodyList.Add(TailRect);

			// aaple
			Apple.Parent = Grid;

			// GUI initialization \\

			// X eyes on snake after death
			XEye1.Parent = ModelHead;
			XEye1.Location = new Point(3, 2);
			XEye2.Parent = ModelHead;
			XEye2.Location = new Point(3, 22);

			// aaple shown above score in GUI
			ModelApple.Parent = Menu;
			ModelApple.Location = new Point(17, 31);

			// score in GUI
			lblScoreLabel.Parent = Menu;
			lblScoreLabel.Location = new Point(0, 71);
			lblScore.Parent = Menu;
			lblScore.Location = new Point(0, 104);

			// Stopwatch icon above speed GUI
			imgSpeed.Parent = Menu;
			imgSpeed.Location = new Point(7, 150);

			// speed in GUI
			lblSpeedLabel.Parent = Menu;
			lblSpeedLabel.Location = new Point(-2, 210);
			lblSpeed.Parent = Menu;
			lblSpeed.Location = new Point(0, 243);
		}

		private void btnStart_Click(object sender, EventArgs e) // also designed to work as a restart
		{
			if (int.TryParse(txtSpeed.Text, out int VoidThis) && Convert.ToInt16(txtSpeed.Text) > 0 && Convert.ToInt16(txtSpeed.Text) <= 250)
			{
				// hide menu
				imgMenu.Hide();
				lblTitle.Hide();
				ModelHead.Hide();
				ModelBody1.Hide();
				ModelBody2.Hide();
				ModelTail.Hide();
				btnStart.Hide();
				btnClose.Hide();
				XEye1.Hide();
				XEye2.Hide();
				lblSpeedTitle.Hide();
				txtSpeed.Hide();
				txtSpeed.Enabled = false;
				lblSpeedLimits.Hide();

				// start up game MOVE
				ControlTimer.Start();

				// invert speed value so that lower numbers make the game slower and vice versa
				int Speed;
				Speed = Math.Abs(Convert.ToInt16(txtSpeed.Text) - 250) + 1;
				ControlTimer.Interval = Speed;
				lblSpeed.Text = txtSpeed.Text;

				// remove all but the original four snake parts
				BodyList.RemoveRange(3, BodyList.Count - 4);

				// reset snake properties
				lblScore.Text = "0";
				tailPause = false;
				Score = 0;

				for (int i = 0; i < 4; i++)
				{
					BodyList[i].Direction = "Right";
				}

				// get and set the head and tail to their original rotations
				Bitmap OriginalHead = new Bitmap(Snake_v2.Properties.Resources.SnakeHeadRight);
				SnakeHead.Image = OriginalHead;

				Bitmap OriginalTail = new Bitmap(Snake_v2.Properties.Resources.SnakeTailRight);
				SnakeTail.Image = OriginalTail;

				// set snake location back to start
				BodyList[0].Location = new Point(120, 280); // head
				BodyList[1].Location = new Point(80, 280); // body1
				BodyList[2].Location = new Point(40, 280); // body2
				BodyList[3].Location = new Point(0, 280); // tail ??

				SnakeHead.Location = BodyList[0].Location;
				SnakeTail.Location = BodyList[3].Location;

				SpawnApple();
				lastKeyPressed = '\0'; // null character
				lblError.Hide();
				this.Focus();

				Invalidate();
			}
			else
			{
				lblError.Show();
			}
		}

		private void ControlTimer_Tick(object sender, EventArgs e) // drives the entire game through a tick system
		{

			if (testWallHit() || testBodyHit())
			{
				Die();
			}
			else
			{
				// the entire process starts from the back, the tail, and moves forward, checking the direction the segment in front of it last moved and copying that
				// tail is moved seperately as it needs to be paused each time the snake grows
				if (tailPause == false)
				{
					Point TailPos = BodyList[BodyList.Count - 1].Location;
					if (BodyList[BodyList.Count - 2].Direction == "Right") // segment in front of the tail is moving right...
					{
						TailPos.Offset(new Point(40, 0)); // get offset location based on direction of last body
					}
					else if (BodyList[BodyList.Count - 2].Direction == "Up")
					{
						TailPos.Offset(new Point(0, -40));
					}
					else if (BodyList[BodyList.Count - 2].Direction == "Left")
					{
						TailPos.Offset(new Point(-40, 0));
					}
					else
					{
						TailPos.Offset(new Point(0, 40));
					}
					BodyList[BodyList.Count - 1].Location = TailPos; // move tail to offset location
					SnakeTail.Location = BodyList[BodyList.Count - 1].Location; // move tail image with the hitbox
				}
				else
				{
					tailPause = false;
				}

				for (int i = BodyList.Count - 2; i > 0; i--) // starts at the back and works its way up the segments, skips last two as they are the head and tail
				{
					Point bodyLoc = BodyList[i].Location;
					if (BodyList[i - 1].Direction == "Right") // checks direction of the body ahead of it
					{
						bodyLoc.Offset(new Point(40, 0)); // get offset location
						BodyList[i].Direction = "Right"; // copies direction
					}
					else if (BodyList[i - 1].Direction == "Up")
					{
						bodyLoc.Offset(new Point(0, -40));
						BodyList[i].Direction = "Up";
					}
					else if (BodyList[i - 1].Direction == "Left")
					{
						bodyLoc.Offset(new Point(-40, 0));
						BodyList[i].Direction = "Left";
					}
					else // down
					{
						bodyLoc.Offset(new Point(0, 40));
						BodyList[i].Direction = "Down";
					}
					BodyList[i].Location = bodyLoc; // move body to offset location
				}

				// rotates tail image a tick before it moves in that direction for visual appeal
				if (BodyList[BodyList.Count - 2].Direction == "Right")
				{
					Bitmap RightTail = new Bitmap(Snake_v2.Properties.Resources.SnakeTailRight);
					SnakeTail.Image = RightTail;
				}
				else if (BodyList[BodyList.Count - 2].Direction == "Up")
				{
					Bitmap UpTail = new Bitmap(Snake_v2.Properties.Resources.SnakeTailRight);
					UpTail.RotateFlip(RotateFlipType.Rotate270FlipNone); // rotate to be facing up
					SnakeTail.Image = UpTail;
				}
				else if (BodyList[BodyList.Count - 2].Direction == "Left")
				{
					Bitmap LeftTail = new Bitmap(Snake_v2.Properties.Resources.SnakeTailRight);
					LeftTail.RotateFlip(RotateFlipType.Rotate180FlipNone);
					SnakeTail.Image = LeftTail;
				}
				else // down
				{
					Bitmap DownTail = new Bitmap(Snake_v2.Properties.Resources.SnakeTailRight);
					DownTail.RotateFlip(RotateFlipType.Rotate90FlipNone);
					SnakeTail.Image = DownTail;
				}

				// move head based on last key pressed
				Point headLoc = BodyList[0].Location;
				if (lastKeyPressed == 'd' || lastKeyPressed == '\0') // moving right...
				{
					headLoc.Offset(new Point(40, 0)); // move hitbox to the right
					BodyList[0].Direction = "Right"; // set direction string to right

					// set head image to be facing the right direction
					Bitmap RightHead = new Bitmap(Snake_v2.Properties.Resources.SnakeHeadRight);
					SnakeHead.Image = RightHead;
				}
				else if (lastKeyPressed == 'w')
				{
					headLoc.Offset(new Point(0, -40));
					BodyList[0].Direction = "Up";

					Bitmap UpHead = new Bitmap(Snake_v2.Properties.Resources.SnakeHeadRight);
					UpHead.RotateFlip(RotateFlipType.Rotate270FlipNone); // rotate to be facing up
					SnakeHead.Image = UpHead;
				}
				else if (lastKeyPressed == 'a')
				{
					headLoc.Offset(new Point(-40, 0));
					BodyList[0].Direction = "Left";

					Bitmap LeftHead = new Bitmap(Snake_v2.Properties.Resources.SnakeHeadRight);
					LeftHead.RotateFlip(RotateFlipType.Rotate180FlipNone);
					SnakeHead.Image = LeftHead;
				}
				else // down
				{
					headLoc.Offset(new Point(0, 40));
					BodyList[0].Direction = "Down";

					Bitmap DownHead = new Bitmap(Snake_v2.Properties.Resources.SnakeHeadRight);
					DownHead.RotateFlip(RotateFlipType.Rotate90FlipNone);
					SnakeHead.Image = DownHead;
				}
				// move head
				BodyList[0].Location = headLoc;
				SnakeHead.Location = headLoc;

				keyDelay = true;

				if (SnakeHead.Location == Apple.Location)
				{
					SpawnApple();
					createBody();

					++Score;
					lblScore.Text = Convert.ToString(Score);
				}

				Invalidate();
			}
		}

		private void frmSnake_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (((e.KeyChar == 'w' || e.KeyChar == 'a' || e.KeyChar == 's' || e.KeyChar == 'd') && keyDelay) || e.KeyChar == ' ')
			{
				char keyPressed = e.KeyChar;

				if (keyPressed == 'w')
				{
					if (lastKeyPressed != 's') // illeagal move
					{
						lastKeyPressed = 'w';
					}
				}
				else if (keyPressed == 'a')
				{
					if (lastKeyPressed != 'd' && lastKeyPressed != '\0') // moving right, \0 means null which means the player hasn't pressed a key since starting
					{
						lastKeyPressed = 'a';
					}
				}
				else if (keyPressed == 's')
				{
					if (lastKeyPressed != 'w')
					{
						lastKeyPressed = 's';
					}
				}
				else if (keyPressed == 'd')
				{
					if (lastKeyPressed != 'a')
					{
						lastKeyPressed = 'd';
					}
				}
				else if (keyPressed == ' ')
				{
					if (ControlTimer.Enabled == true)
					{
						ControlTimer.Enabled = false;
					}
					else
					{
						ControlTimer.Enabled = true;
					}
				}
				keyDelay = false;
			}
		}

		private void createBody()
		{
			SnakeRect newBody = new SnakeRect();

			SnakeRect LastBody = BodyList[BodyList.Count - 2]; // get the last body part so that the direction can be tested, and based off the direction,
															   // place the new segment behind it and facing the right direction properly

			// put it behind last body
			if (LastBody.Direction == "Right")
			{
				newBody.Location = new Point(LastBody.Location.X - 40, LastBody.Location.Y);
			}
			else if (LastBody.Direction == "Left")
			{
				newBody.Location = new Point(LastBody.Location.X + 40, LastBody.Location.Y);
			}
			else if (LastBody.Direction == "Up")
			{
				newBody.Location = new Point(LastBody.Location.X, LastBody.Location.Y + 40);
			}
			else // down
			{
				newBody.Location = new Point(LastBody.Location.X, LastBody.Location.Y - 40);
			}

			newBody.Direction = LastBody.Direction; // copy the direction

			BodyList.Insert(BodyList.Count - 1, newBody); // insert in front of the tail
			tailPause = true;
		}

		private void Grid_Paint(object sender, PaintEventArgs e)
		{
			SolidBrush BodyBlue = new SolidBrush(Color.FromArgb(78, 124, 246)); // the color of the bodies
			for (int i = 1; i < BodyList.Count - 1; i++) // loop through every body but the first and the last, as they are the head and tail hitboxes and remain invisible
			{
				e.Graphics.FillRectangle(BodyBlue, BodyList[i].Rectangle); // fill it
			}
		}

		private void SpawnApple()
		{
			int RanAppleX;
			int RanAppleY;
			Point RanLoc;
			bool intersects;
			Random Rnd = new Random();

			do
			{
				RanAppleX = Rnd.Next(15); // random number from 0 to 14 for the grid
				RanAppleY = Rnd.Next(15);

				RanLoc = new Point(RanAppleX * 40, RanAppleY * 40);



				intersects = BodyList.Any(body => body.Rectangle.Contains(RanLoc));
			} while (intersects);

			Apple.Location = RanLoc;
		}

		private bool testBodyHit()
		{
			Point Destination = SnakeHead.Location; // the point the head WILL be at after its next move, went to kill snake before GUI updates for looks sake

			if (lastKeyPressed == 'd' || lastKeyPressed == '\0')
			{
				Destination.Offset(new Point(40, 0));
			}
			else if (lastKeyPressed == 'w')
			{
				Destination.Offset(new Point(0, -40));
			}
			else if (lastKeyPressed == 'a')
			{
				Destination.Offset(new Point(-40, 0));
			}
			else // s
			{
				Destination.Offset(new Point(0, 40));
			}

			List<SnakeRect> TempBodies = BodyList.Take(BodyList.Count - 1).ToList(); // creates a temp list of all snake parts excluding the tail, not sure of a better method

			return TempBodies.Any(body => body.Rectangle.Contains(Destination));
		}

		private bool testWallHit()
		{
			if ((lastKeyPressed == 'w' && SnakeHead.Location.Y == 0) || (lastKeyPressed == 'a' && SnakeHead.Location.X == 0) || (lastKeyPressed == 's' && SnakeHead.Location.Y == 560) || ((lastKeyPressed == 'd' || lastKeyPressed == '\0') && SnakeHead.Location.X == 560))
			{
				return true;
			}
			return false;
		}

		private void Die()
		{
			// all menu objects
			imgMenu.Show();
			lblTitle.Show();
			ModelHead.Show();
			ModelBody1.Show();
			ModelBody2.Show();
			ModelTail.Show();
			btnStart.Show();
			btnClose.Show();
			ControlTimer.Stop();
			btnStart.Text = "Retry";
			lblTitle.Text = "You Died!";
			XEye1.Show();
			XEye2.Show();
			lblSpeedTitle.Show();
			txtSpeed.Show();
			txtSpeed.Enabled = true;
			lblSpeedLimits.Show();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
