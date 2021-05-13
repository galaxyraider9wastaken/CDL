using System;

namespace CSDL.Graphics{
  public class Window : Globals{
    private int Width;
    private int Height;
    private int X;
    private int Y;
    private int Color;
    private string Title;
    public Window(int width, int height, int x, int y, Color color, string title){
      Width = width;
      Height = height;
      X = x;
      Y = y;
      Color = color;
      Title = title;
      using (StreamWriter writer = new StreamWriter(DrawingBatchDataPath + "Window.txt", true))  
      {  
        writer.WriteLine(Width+","+Height+","+X+","+Y+","+Color+","+Title);
      }  
    }
    public void Update(){
      
    }
  }
}
