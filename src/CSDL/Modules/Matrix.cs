using System;

namespace CSDL.LinearAlgebra{
  public class Matrix{
    public float[][] Translation = new float[][];
    public Vector2 Size;
    public Matrix(Vector2 size){
      Size = size;
      Translation = new float[(int)Size.X][];
      for(int i =0;i<Translation.Lenght;i++){
        Translation[i] = new float[(int)Size.Y];
      }
    }
  }
}
