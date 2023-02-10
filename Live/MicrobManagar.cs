using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Live
{
	class MicrobManagar
	{
		private Random rnd;
		private int minX, minY, maxX, maxY;
		private Microbe[] microbe;

	

		public MicrobManagar( int minX, int minY, int maxX, int maxY, int countMicrobe)
		{
			this.rnd = new Random();
			this.minX = minX;
			this.minY = minY;
			this.maxX = maxX;
			this.maxY = maxY;
			this.microbe = new Microbe[countMicrobe];

			InitMicrobe();
		}

		private void InitMicrobe()
		{
			char[] looks = new[] { '@', '*' };

			for (int i = 0; i < microbe.Length; i++)
			{
				microbe[i] = new Microbe(
			rnd.Next(minX,maxX + 10),
			rnd.Next(minY,maxY + 10),
			rnd.Next(0,2)
			);
			}
		}


	

		private void MoveMicrobe()
		{
			for (int i = 0; i < microbe.Length; i++)
			{
				microbe[i].Movement();

				if (microbe[i].X > maxX || microbe[i].X < minX || microbe[i].Y > maxY || microbe[i].Y < minY)
				{
					microbe[i].X = minX;
				}
			}
		}

		private void DrawMicrobe() 
		{
			for (int i = 0; i < microbe.Length; i++)
			{
				microbe[i].ScreenOutput();
			}
		}

		public void Run() { 
			while (true)
			{
				Console.Clear();

				DrawMicrobe();

				MoveMicrobe();

				Thread.Sleep(300); 
			}
		}

	}
}
