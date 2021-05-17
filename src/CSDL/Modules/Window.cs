using System;

namespace CSDL.Graphics{
  public class Window : Globals{
    private int Width;
    private int Height;
    private int Color;
    private string Title;
    private bool FullScreen;
    public int DWD_ID;
    public Window(int width, int height, Color color, string title, bool fullScreen){
      Width = width;
      Height = height;
      Color = color;
      Title = title;
      FullScreen = fullScreen;
      WindowNum+=1;
      DWD_ID = DrawingWindowID + WindowNum;
      using (StreamWriter writer = new StreamWriter(DrawingBatchDataPath + "Window.txt", true))  
      {  
        writer.WriteLine(Width+","+Height+","+X+","+Y+","+Color.RGBA.X+","+Color.RGBA.Y+","+Color.RGBA.Z+","+Color.RGBA.W+","+Title+","+FullScreen+","+DrawingWindowID+","+DWD_ID";");
      }  
    }
  }
}
