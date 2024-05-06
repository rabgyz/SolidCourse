using System;
namespace OpenClose.Module
{
	public class Application
	{
		//23:08 SOLID
		public void Render(List<Shape> shapes)
		{
			for (int i = 0; i < shapes.Count; i++)
			{
				shapes[i].Draw();
				/*
				 * ShapeType type = shapes[i].ShapeType;
				switch (type)
				{
					case ShapeType.Rectangle:
						RenderRectangle((Rectangle)shapes[i]);
						return;
					case ShapeType.Circle:
						RenderCircle((Circle)shapes[i]);
						return;
				}
				*/
			}
		}

        /*
         * private void RenderCircle(Circle circle)
        {
			Console.WriteLine("Render circle..");
        }

        private void RenderRectangle(Rectangle rectangle)
        {
            Console.WriteLine("Render rectangle..");
        }
		*/
    }
}

