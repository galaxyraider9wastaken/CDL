using System;

namespace CSDL.Graphics{
  public class Shader : Globals{
    public int ShaderType;
    public string ShaderPath;
    public Shader(int shaderType, string shaderPath){
      ShaderType = shaderType;
      ShaderPath = shaderPath;
      using (StreamWriter writer = new StreamWriter(ShaderDataPath + "Shader.txt", true))
      {  
        writer.WriteLine(ShaderType+","+ShaderPath+";");
      }  
    }
  }
}
