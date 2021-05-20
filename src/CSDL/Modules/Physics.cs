using System;
using CSDL.LinearAlgebra;

namespace CSDL.Physics{
  public class HitBox2D{
    public Vector2 Position;
    public HitBox2D(Vector2 position){
      Position = position;
    }
  }
}

namespace CSDL.Physics{
  public class HitBox3D{
    public Vector3 Position;
    public HitBox2D(Vector3 position){
      Position = position;
    }
  }
}

namespace CSDL.Physics{
  public class RigidBody{
    public RigidBody(){
      
    }
  }
}
