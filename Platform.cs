namespace BridgePattern;

public abstract class Platform
{
    public IShape Shape;

    protected Platform(IShape shape)
    {
        Shape = shape;
    }

    public abstract void DrawShape();
}