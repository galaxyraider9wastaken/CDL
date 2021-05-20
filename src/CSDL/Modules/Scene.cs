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
    public void SetSceneVertexShader(Shader shader){
      VertexShader = shader;
      using (StreamWriter writer = new StreamWriter(ScenePath + "VertexShaderPath.txt", true))
      {  
        writer.WriteLine(shader.ShaderPath+";");
      }
    }
    public void SetSceneFragmentShader(Shader shader){
      FragmentShader = shader;
      using (StreamWriter writer = new StreamWriter(ScenePath + "FragmentShaderPath.txt", true))
      {  
        writer.WriteLine(shader.ShaderPath+";");
      }
    }
  }
}

namespace CSDL.Graphics{
  public class Scene3D(Shader vertexShader, Shader fragmentShader, Window[] windows){
  
  }
}
