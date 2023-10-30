using BridgePattern;

IShape circle = new Circle();
Platform windows = new Windows(circle);
Platform linux = new Linux(circle);
windows.DrawShape();
linux.DrawShape();