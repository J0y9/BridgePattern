namespace BridgePattern;

public class Windows : Platform
{
    public Windows(IShape shape) : base(shape)
    {
    }

    public override void DrawShape()
    {
      Shape.Draw($"{nameof(Windows)}");
    }
}