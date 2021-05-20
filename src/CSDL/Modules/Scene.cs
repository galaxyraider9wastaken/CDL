using System;

namespace CSDL.Graphics{
  public class Scene2D{
    public Shader VertexShader;
    public Shader FragmentShader;
    public Window[] Windows;
    public Scene2D(Shader vertexShader, Shader fragmentShader, Window[] windows){
      VertexShader = vertexShader;
      FragmentShader = fragmentShader;
      Windows = windows;
    }
  }
}

namespace CSDL.Graphics{
  public class Scene3D(){
  
  }
}
