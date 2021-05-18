using System;

namespace CSDL.Graphics{
  public class Shader : Globals{
    public int ShaderType;
    public string ShaderPath;
    public Shader(int shaderType, string shaderPath){
      ShaderType = shaderType;
      ShaderPath = shaderPath;
    }
  }
}
namespace CSDL.Graphics{
  public class ShaderManager : Globals{
    public static void SetVertexShader(Shader Shader){
      using (StreamWriter writer = new StreamWriter(ShaderDataPath + "VertexShaderPath.txt", true))
      {  
        writer.WriteLine(ShaderPath+";");
      }
    }
    public static void SetFragmentShader(Shader Shader){
      using (StreamWriter writer = new StreamWriter(ShaderDataPath + "FragmentShaderPath.txt", true))
      {  
        writer.WriteLine(ShaderPath+";");
      }
    }
    public static void UseDeafaultShaders(){
      using (StreamWriter writer = new StreamWriter(ShaderDataPath + "VertexShaderPath.txt", true))
      {  
        writer.WriteLine("Deafult.vert"+";");
      }
      using (StreamWriter writer = new StreamWriter(ShaderDataPath + "FragmentShaderPath.txt", true))
      {  
        writer.WriteLine("Deafult.frag"+";");
      }
    }
  }
}
