using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Live
{
	class Microbe
	{
		private int x, y;
		private ConsoleColor color;
		private int speed;
		private char look;

		private int stepFall;

		private int hp;



		public Microbe()
		{
			x = y = 0;
			color = ConsoleColor.Gray;
			speed = 0;
			look = '#';

			stepFall= 0;

			hp= 0;
		}

		public Microbe(int x, int y, ConsoleColor color, int speed, char look)
		{
			this.x = x;
			this.y = y;
			this.color = color;
			this.speed = speed;
			this.look = look;

			this.stepFall = stepFall;

			this.hp = hp;
		}

		public void ScreenOutput()
		{
			Console.SetCursorPosition(x,y);
			Console.ForegroundColor= color;
			Console.Write(look);
		}
		public void Movement()
		{
			Random rnd = new Random();
			y += speed;

			stepFall++;

			if (stepFall % 2 == 0)
			{
				
				y = rnd.Next(1, 100);
			
			}
			else
			{
			
				y = rnd.Next(1, 100);
				
			}

			if (stepFall >= 10)
			{
				stepFall -= 10;
			}
		}

		public int X
		{
			set { x = value; }
			get { return x; }
		}

	}


}
