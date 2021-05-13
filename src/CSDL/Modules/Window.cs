using System;

namespace CSDL.Graphics{
  public class Window{
    public Window(){
      
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
