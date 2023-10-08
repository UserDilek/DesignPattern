using System;
namespace Factory_Design_Pattern
{
	public class ShapeFactory
	{
		public ShapeFactory()
		{
		}

		public Shape getShape(string shapeType)
		{

			if (shapeType == "Circle")
			{
				return new Circle();
			}
			else if (shapeType == "Rectangle")
			{
				return new Rectangle();
			}
			else if (shapeType == "Square")
			{
				return new Square();
			}

			return null;
		}
	}

}