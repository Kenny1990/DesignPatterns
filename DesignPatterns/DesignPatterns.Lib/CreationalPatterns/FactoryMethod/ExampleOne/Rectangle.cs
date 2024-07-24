namespace DesignPatterns.Lib.CreationalPatterns.FactoryMethod.ExampleOne
{
    public class Rectangle
        : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
