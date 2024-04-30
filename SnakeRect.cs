using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v2
{
	internal class SnakeRect // Just uses the rectangle class, but adds an extra "direction" functionality for storing the direction it is facing along with the segment itself
	{
		Rectangle rect; // main rectangle

		public Point Location { get { return rect.Location; } set { rect.Location = value; } }
		public Rectangle Rectangle { get { return rect; } } // direct reference for anything necesary, mostly paint event
		public string Direction { get; set; } // stores direction body segment last moved

		public SnakeRect()
		{
			rect.Size = new Size(40, 40); // all body segments are going to be 40x40
		}
		public void Offset(Point point)
		{
			rect.Offset(point); // for moving the segments
		}
	}
}
