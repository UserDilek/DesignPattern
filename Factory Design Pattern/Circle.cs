using System;
namespace Factory_Design_Pattern
{
	public class Circle:Shape
	{
		public Circle()
		{
		}

        public void drawShape()
        {
            Console.WriteLine("Drawing Circle Shape");
        }
    }
}

