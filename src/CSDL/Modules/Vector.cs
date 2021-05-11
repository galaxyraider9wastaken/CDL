using System;

namespace CSDL.LinearAlgebra{
  public class Vector2{
    public float X;
    public float Y;
    public Vector2(float x, Float y){
      X = x;
      Y = y;
    }
  }
}
namespace LinearAlgebra{
  public class Vector3{
    public float X;
    public float Y;
    public Vector2(float x, Float y){
      X = x;
      Y = y;
    }
  }
}
namespace LinearAlgebra{
  public class Vector3{
    public float X;
    public float Y;
    public float Z;
    public Vector3(float x, Float y, float z, float w){
      X = x;
      Y = y;
      Z = z;
    }
  }
}
namespace LinearAlgebra{
  public class Vector3{
    public float X;
    public float Y;
    public float Z;
    public float W;
    public Vector3(float x, Float y, float z, float w){
      X = x;
      Y = y;
      Z = z;
      W = w;
    }
  }
}
namespace LinearAlgebra{
  public class Vector {
    public Vector4 Add(int VType, float X, float Y, float Z = 0, float W = 0, float X1, float Y2, float Z3 = 0, float W4 = 0){
      var VA = new Vector4();
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
  }
}
