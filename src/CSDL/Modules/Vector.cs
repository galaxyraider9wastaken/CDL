using System;

namespace CSDL.LinearAlgebra{
  public class Vector2{
    public float X;
    public float Y;
    public Vector2(float x, float y){
      X = x;
      Y = y;
    }
  }
}
namespace CSDL.LinearAlgebra{
  public class Vector3{
    public float X;
    public float Y;
    public float Z;
    public Vector3(float x, float y, float z){
      X = x;
      Y = y;
      Z = z;
    }
  }
}
namespace CSDL.LinearAlgebra{
  public class Vector4{
    public float X;
    public float Y;
    public float Z;
    public float W;
    public Vector4(float x, float y, float z, float w){
      X = x;
      Y = y;
      Z = z;
      W = w;
    }
  }
}
namespace CSDL.LinearAlgebra{
  public class Vector {
    public Vector4 Add(int VType, float X1, float Y1, float Z1, float W1, float X2, float Y2, float Z2, float W2){
      var VA = new Vector4(0, 0, 0, 0);
      if(VType == 2){
        VA.X = X1 + X2;
        VA.Y = Y1 + Y2;
      }
      if(VType == 3){
        VA.X = X1 + X2;
        VA.Y = Y1 + Y2;
        VA.Z = Z1 + Z2;
      }
      if(VType == 4){
        VA.X = X1 + X2;
        VA.Y = Y1 + Y2;
        VA.Z = Z1 + Z2;
        VA.W = W1 + W2;
      }
      return VA;
    }
    public Vector4 Subtract(int VType, float X1, float Y1, float Z1, float W1, float X2, float Y2, float Z2, float W2){
      var VA = new Vector4(0, 0, 0, 0);
      if(VType == 2){
        VA.X = X1 - X2;
        VA.Y = Y1 - Y2;
      }
      if(VType == 3){
        VA.X = X1 - X2;
        VA.Y = Y1 - Y2;
        VA.Z = Z1 - Z2;
      }
      if(VType == 4){
        VA.X = X1 - X2;
        VA.Y = Y1 - Y2;
        VA.Z = Z1 - Z2;
        VA.W = W1 - W2;
      }
      return VA;
    }
    public Vector4 Multiply(int VType, float X1, float Y1, float Z1, float W1, float X2, float Y2, float Z2, float W2){
      var VA = new Vector4(0, 0, 0, 0);
      if(VType == 2){
        VA.X = X1 * X2;
        VA.Y = Y1 * Y2;
      }
      if(VType == 3){
        VA.X = X1 * X2;
        VA.Y = Y1 * Y2;
        VA.Z = Z1 * Z2;
      }
      if(VType == 4){
        VA.X = X1 * X2;
        VA.Y = Y1 * Y2;
        VA.Z = Z1 * Z2;
        VA.W = W1 * W2;
      }
      return VA;
    }
    public Vector4 Divide(int VType, float X1, float Y1, float Z1, float W1, float X2, float Y2, float Z2, float W2){
      var VA = new Vector4(0, 0, 0, 0);
      if(VType == 2){
        VA.X = X1 / X2;
        VA.Y = Y1 / Y2;
      }
      if(VType == 3){
        VA.X = X1 / X2;
        VA.Y = Y1 / Y2;
        VA.Z = Z1 / Z2;
      }
      if(VType == 4){
        VA.X = X1 / X2;
        VA.Y = Y1 / Y2;
        VA.Z = Z1 / Z2;
        VA.W = W1 / W2;
      }
      return VA;
    }
    public Vector4 Normalize(int VType, float X1, float Y1, float Z1, float W1, float X2, float Y2, float Z2, float W2){
      double distance;
      var VA = new Vector4(0, 0, 0, 0);
      if(VType == 2){
        distance = Math.Sqrt(X1 * X2 + Y1 * Y2);
        VA = new Vector4(X1/(float)distance, Y1/(float)distance, 0, 0);
      }
      if(VType == 3){
        distance = Math.Sqrt(X1 * X2 + Y1 * Y2 + Z1 * Z2);
        VA = new Vector4(X1/(float)distance, Y1/(float)distance, Z1/(float)distance, 0);
      }
      if(VType == 4){
        distance = Math.Sqrt(X1 * X2 + Y1 * Y2 + Z1 * Z2 + W1 * W2);
        VA = new Vector4(X1/(float)distance, Y1/(float)distance, Z1/(float)distance, W1/(float)distance);
      }
      return VA;
    }
  }
}
