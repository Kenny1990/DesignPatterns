using DesignPatterns.Lib.CreationalPatterns.FactoryMethod.ExampleOne;

namespace DesignPatterns.Cons.CreationalPatterns.FactoryMethod
{
    internal class FactoryMethodDisplayManager
    {
        internal static void DisplayExampleOne()
        {
            Console.WriteLine("Enter a shape type (circle, rectangle, triangle): ");
            string? shapeType = Console.ReadLine();

            ShapeFactory shapeFactory = new ConsoleShapeFactory();
            IShape shape = shapeFactory.CreateShape(shapeType);
            shape.Draw();
        }
    }
}
