using System;

namespace CSDL.LinearAlgebra{
  public class Matrix{
    public float[][] Translation;
    public Vector2 Size;
    public Matrix(Vector2 size){
      Size = size;
      Translation = new float[(int)Size.X][];
      for(int i =0;i<Translation.Length;i++){
        Translation[i] = new float[(int)Size.Y];
      }
    }
  }
}
namespace CSDL.LinearAlgebra{
  public class MatrixEquations{
    public static Matrix Add(int MSize, Matrix M1, Matrix M2){
      var MA = new Matrix(new Vector2(MSize, MSize));
      for(int i =0;i<MSize;i++){
        for(int i1=0;i1<MSize;i1++){
          MA.Translation[i][i1] = M1.Translation[i][i1] + M2.Translation[i][i1];
        }
      }
      return MA;
    }
    public static Matrix Subtract(int MSize, Matrix M1, Matrix M2){
      var MA = new Matrix(new Vector2(MSize, MSize));
      for(int i =0;i<MSize;i++){
        for(int i1=0;i1<MSize;i1++){
          MA.Translation[i][i1] = M1.Translation[i][i1] - M2.Translation[i][i1];
        }
      }
      return MA;
    }
  }
}
