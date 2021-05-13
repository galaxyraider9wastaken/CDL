using System;

namespace CSDL.Graphics{
  public int Width;
  public int height;
  public string Path;
  public class Texture2D(int width, int height, string path){
    Width = width;
    Height = height;
    Path = path;
  }
}
