using System;

class Program
{
    static void Main()
    {
        // Create a rectangle instance
        var rect = new Rectangle(10, 20);
        
        // Display the rectangle's dimensions
        Console.WriteLine($"Width: {rect.Width}, Height: {rect.Height}");

        // Deconstruct the rectangle into separate variables
        (float width, float height) = rect;
        Console.WriteLine($"Deconstructed -> Width: {width}, Height: {height}");
    }
}

class Rectangle
{
    // Automatic properties for Width and Height
    public float Width { get; }
    public float Height { get; }

    // Constructor to initialize Width and Height
    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }

    // Deconstruct method
    public void Deconstruct(out float width, out float height)
    {
        width = Width;
        height = Height;
    }
}
