using System;
namespace Factory_Design_Pattern
{
	public class Rectangle :Shape
	{
		public Rectangle()
		{
		}

        public void drawShape()
        {
            Console.WriteLine("Drawing Circle Shape");
        }
    }
}

