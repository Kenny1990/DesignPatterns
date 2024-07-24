namespace DesignPatterns.Lib.CreationalPatterns.FactoryMethod.ExampleOne
{
    public class Circle
        : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
