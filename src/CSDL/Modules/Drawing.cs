using System;

namespace CSDL.Graphics{
  public class DrawBatch : Globals{
    public static void Draw2D(Vector2 Position, Vector2 Size, Vector2 Rotation, Texture2D Texture, int RFilter){
      using (StreamWriter writer = new StreamWriter(DrawingBatchDataPath + "Sprite2D.txt", true))  
      {  
        writer.WriteLine(Position.X+","+Position.Y+","+Size.X+","+Size.Y+","+Rotation.X+","+Rotation.Y+","+Texture.Path+","+Texture.Filter+","+RFilter+","+100+","+100"+","+;");
      }  
    }
    public static void ClearBatch2D(){
      System.IO.File.WriteAllText(DrawingBatchDataPath + "Sprite2D.txt",string.Empty);
    }
    public static void Draw3D(Camera camera, Vector3 Position, Vector3 Size, Vector3 Rotation, Texture3D Texture){
      using (StreamWriter writer = new StreamWriter(DrawingBatchDataPath + "Sprite3D.txt", true))  
      {  
        writer.WriteLine(Position.X+","+Position.Y+","+Position.Z+","+Size.X+","+Size.Y+","+Size.Z+","+Rotation.X+","+Rotation.Y+","+Rotation.Z+","+Texture.Path+","+1000+","+1000+","+";");
      }  
    }
    public static void ClearBatch3D(){
      System.IO.File.WriteAllText(DrawingBatchDataPath + "Sprite3D.txt",string.Empty);
    }
  }
}
