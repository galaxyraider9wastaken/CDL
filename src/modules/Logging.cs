using System;

namespace CDX.Logging {
  public class Log {
    public string Path;
    public Log(bool useDeafault, string path = ""){
      Path = path;
    }
  }
}
