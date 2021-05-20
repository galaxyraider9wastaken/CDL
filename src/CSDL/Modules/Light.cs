using System;

namespace CSDL.Graphics{
  public class LightSource{
    public Vector3 Position;
    public Color Color;
    public LightSource(Vector3 position, Color color){
      Position = position;
      Color = color;
    }
  }
}
