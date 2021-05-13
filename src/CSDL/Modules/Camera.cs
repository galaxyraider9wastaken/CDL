using System;

namespace CSDL.Graphics{
  public class Camera{
    private Vector3 CameraPos;
    public Camera(){
    
    }
    public void FollowPosition(Vector3 Position, int WinWidth, int WinHeight){
      CameraPos = new Vector3(Position.X - WinWidth/2, Position.Y - WinHeight/2, Position.Z);
    }
  }
}
