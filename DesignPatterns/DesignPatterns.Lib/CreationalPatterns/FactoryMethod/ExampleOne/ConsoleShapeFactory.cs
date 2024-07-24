namespace DesignPatterns.Lib.CreationalPatterns.FactoryMethod.ExampleOne
{
    public class ConsoleShapeFactory
        : ShapeFactory
    {
        public override IShape CreateShape(string? shapeType)
        {
            return (shapeType?.ToLower()) switch
            {
                "circle" => new Circle(),
                "rectangle" => new Rectangle(),
                "triangle" => new Triangle(),
                _ => throw new ArgumentException("Invalid shape type"),
            };
        }
    }
}
