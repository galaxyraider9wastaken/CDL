using System;
using System.IO;

namespace CSDL.Graphics{
  public class Scene2D{
    public Shader VertexShader;
    public Shader FragmentShader;
    public Scene2D(){
      
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
  public class Scene3D : Globals{
    public Shader VertexShader;
    public Shader FragmentShader;
    public Vector3 Gravity;
    public LightSource LightSource;
    public Tetxure2D BackgroundTexture;
    public Scene3D(){
        
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
    public void SetSceneGravity(Vector3 gravity){
      Gravity = gravity;
      WGravity = Gravity;
      using (StreamWriter writer = new StreamWriter(ScenePath + "Gravity.txt", true))
      {  
        writer.WriteLine(Gravity.X+","+Gravity.Y+","+Gravity.Z+";");
      }
    }
    public void SetSceneLightSource(LightSource lightSource){
      LightSource = lightSource;
      using (StreamWriter writer = new StreamWriter(ScenePath + "Lightsource.txt", true))
      {  
        writer.WriteLine(lightSource.Position.X+","+lightSource.Position.Y+","+lightSource.Position.Z+","+lightSource.Color.RGBA.X+","+lightSource.Color.RGBA.Y+","+lightSource.Color.RGBA.Z+","+lightSource.Color.RGBA.W+";");
      }
    }
    public void SetSceneBackGroundTetxure(Texture2D backgroundTexture){
      BackgroundTetxure = backgroundTexture;
      using (StreamWriter writer = new StreamWriter(ScenePath + "BackgroundTexture.txt", true))
      {  
        writer.WriteLine(backgroundTexture.Path+";");
      }
    }
  }
}
