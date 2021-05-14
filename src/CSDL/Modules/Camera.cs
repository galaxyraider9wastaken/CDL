using System;

namespace CSDL.Graphics{
  public class Camera{
    private Vector3 CameraPos;
    private Vector2 ViewPort;
    public Camera(Vector2 viewPort){
      ViewPort = viewPort;
      using (StreamWriter writer = new StreamWriter(DrawingBatchDataPath + "Camera.txt", false))  
      {  
        writer.WriteLine(CameraPos.X+","+CameraPos.Y+","CameraPos.Z+","+ViewPort.X+","+ViewPort.Y);
      }  
    }
    public void FollowPosition(Vector3 Position, int WinWidth, int WinHeight){
      CameraPos = new Vector3(Position.X - WinWidth/2, Position.Y - WinHeight/2, Position.Z);
      using (StreamWriter writer = new StreamWriter(DrawingBatchDataPath + "Camera.txt", false))  
      {  
        writer.WriteLine(CameraPos.X+","+CameraPos.Y+","CameraPos.Z+","+ViewPort.X+","+ViewPort.Y);
      }  
    }
  }
}
