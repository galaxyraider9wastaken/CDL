using System;

namespace CSDL.Graphics{
  public class Texture2D{
    public int Width;
    public int Height;
    public string Path;
    public int Filter = 1;
    public Texture2D(int width, int height, string path){
      Width = width;
      Height = height;
      Path = path;
    }
    public void TextureSetFilte(int filter){
      Filter = filter;
    }
  }
}
namespace CSDL.Graphics{
  public class Texture3D{
    public int Width;
    public int Height;
    public string Path;
    public int Length;
    public Texture3D(int width, int height, int length, string path){
      Width = width;
      Height = height;
      Length = length;
      Path = path;
    }
  }
}
