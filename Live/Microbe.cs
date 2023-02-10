using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

		private int gender;

		/*private int hp;*/



		public Microbe()
		{
			x = y = 0;
			color = ConsoleColor.Gray;
			speed = 0;
			look = '#';

			stepFall= 0;


			/*hp= 100;*/
		}

		public Microbe(int x, int y, int gender )
		{
			this.x = x;
			this.y = y;
			this.gender = gender;
			this.color = gender == 0 ? ConsoleColor.Blue : ConsoleColor.Red;
			this.look = gender == 0 ? '#' : '@';
	
		

			/*this.hp = hp;*/
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

			int move = rnd.Next(0, 3 + 1);

			switch (move)
			{
				case 0:
					{
						this.Y++; break;
					}
				case 1:
					{
						this.Y--; break;
					}
				case 2:
					{
						this.X++; break;
					}
				case 3:
					{
						this.X--; break;
					}
			}
		}

		public int X
		{
			set { x = value; }
			get { return x; }
		}
		public int Y
		{
			set { y = value; }
			get { return y; }
		}


	}


}
