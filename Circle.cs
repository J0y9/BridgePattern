namespace BridgePattern;

public class Circle : IShape
{
    public void Draw(string platformName)
    {
        Console.WriteLine($"Drawing Circle in {platformName}");
    }
}