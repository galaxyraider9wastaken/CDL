using System;

namespace CDX.Logging {
  public class Log : Globals{
    public string Path;
    public Log(bool useDefault, string path = ""){
      Path = path;
      if(UseDefault == true){
        Path = UseDefaultPath
      }
    }
  }
}
