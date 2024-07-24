namespace DesignPatterns.Lib.CreationalPatterns.FactoryMethod.ExampleOne
{
    public class Triangle
        : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
    }
}
