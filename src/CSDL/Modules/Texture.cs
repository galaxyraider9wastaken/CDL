using System;

namespace CSDL.Graphics{
  public class Texture2D{
    public int Width;
    public int height;
    public string Path;
    public Texture2D(int width, int height, string path){
      Width = width;
      Height = height;
      Path = path;
    }
  }
}
namespace CSDL.Graphics{
  public class Texture3D{
    public int Width;
    public int height;
    public string Path;
    public string Length;
    public Texture3D(int width, int height, int length, string path){
      Width = width;
      Height = height;
      Lenght = length;
      Path = path;
    }
  }
}
