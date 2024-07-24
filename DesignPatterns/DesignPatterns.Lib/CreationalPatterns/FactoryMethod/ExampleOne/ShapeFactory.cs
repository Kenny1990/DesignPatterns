namespace DesignPatterns.Lib.CreationalPatterns.FactoryMethod.ExampleOne
{
    public abstract class ShapeFactory
    {
        public abstract IShape CreateShape(string? shapeType);
    }
}
