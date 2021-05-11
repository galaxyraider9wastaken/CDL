using System;

namespace Logging{
  public class Log{
    private int LogState;
    private int Path;
    public Log(int logState, string path = ""){
      LogState = logState;
      Path = path
    }
  }
}
