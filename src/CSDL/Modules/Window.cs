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
      using (StreamWriter writer = new StreamWriter(DrawingBatchDataPath + "Windows.txt", true))  
      {  
        writer.WriteLine("Draw);
      }  
    }
    public void UpdateWindow(){
      
    }
    public void DrawWindow(){
      
    }
  }
}
