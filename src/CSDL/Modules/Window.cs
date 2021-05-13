using System;

namespace CSDL.Graphics{
  public class Window{
    private int Width;
    private int Height;
    private int X;
    private int Y;
    private int UpdateState;
    private int Color;
    public Window(int width, int height, int x, int y, Color color){
      Width = width;
      Height = height;
      X = x;
      Y = y;
      Color = color;
    }
  }
}
namespace CSDL.Graphics{
  public class WindowBatch{
    private Window[] Windows;
    private int WindowAmount;
    public WindowBatch(){
      Windows = new Window[10];
    }
    public void AddWindow(Window Window){
      if(WindowAmount >= 10){
        Console.WriteLine("There Are to Many Windows You Can Not Make More");
      } else {
        Windows[WindowAmount] = Window;
        WindowAmount +=1;
      }
    }
  }
}
