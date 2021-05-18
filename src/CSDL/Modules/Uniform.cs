using System;

namespace CDL.Graphics{
  public class Uniform(){
    public string Name;
    public Shader Shader;
    public Uniform(){
      
    }
    public void CreateUniform(int DataType, string DataFilePath){
      using (StreamWriter writer = new StreamWriter(Path, true))
      {  
        writer.WriteLine(Name+","+Shader.ShaderPath+","+Shader.ShaderType+","+DataFilePath+","DataType+";");
      }  
    }
    public void GetLocation(Shader shader, string name){
      Name = name;
      Shader = shader;
    }
  }
}
