namespace BridgePattern;

public class Linux : Platform
{
    public Linux(IShape shape) : base(shape)
    {
    }

    public override void DrawShape()
    {
        Shape.Draw("Linux");
    }
}