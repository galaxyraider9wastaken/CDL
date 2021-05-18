using System;

namespace CSDL.Graphics{
  public class Camera{
    private Vector3 CameraPos;
    private Vector2 ViewPort;
    public Window Window;
    public Vector3 Orientation;
    public Camera(Vector2 viewPort, Window window){
      ViewPort = viewPort;
      Window = window;
      using (StreamWriter writer = new StreamWriter(DrawingBatchDataPath + "Camera.txt", false))  
      {  
        writer.WriteLine(CameraPos.X+","+CameraPos.Y+","CameraPos.Z+","+ViewPort.X+","+ViewPort.Y+","+Orientation.X+","+Orientation.Y+","+Orientation.Z+","+Window.DWD_ID+";");
      }  
    }
    public void FollowPosition2D(Vector2 Position, int WinWidth, int WinHeight){
      CameraPos = new Vector3(Position.X - WinWidth/2, Position.Y - WinHeight/2, Position.Z);
      using (StreamWriter writer = new StreamWriter(DrawingBatchDataPath + "Camera.txt", false))  
      {  
        writer.WriteLine(CameraPos.X+","+CameraPos.Y+ViewPort.X+","+ViewPort.Y+","+Window.DWD_ID+";");
      }  
    }
    public void SetOrientation(Vector3 orientation){
      Orientation = orientation;
    }
  }
}
