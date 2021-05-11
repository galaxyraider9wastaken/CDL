using System;

namespace Logging{
  public class Log{
    private int LogState;
    private int Path;
    public Log(int logState, string path = ""){
      LogState = logState;
      Path = path
    }
    public void LogMsg(string Msg, int Line, string FileName, int MessageStatus = 0){
      if(LogState == 1){
        
      }
      if(LogState == 2){
        if(MessageStatus = 0){
          Console.WriteLine("Log:: File - " + File + "Line - " + Line " >"  + "Status 0 - Message::" + Msg + "::EndLog");
        }
        if(MessageStatus = 1){
          Console.WriteLine("Log:: File - " + File + "Line - " + Line " >" + "Status 1 - Warning::" + Msg + "::EndLog");
        }
        if(MessageStatus = 2){
          Console.WriteLine("Log:: File - " + File + "Line - " + Line " >" + "Status 2 - Error::" + Msg + "::EndLog");
        }
      }
    }
    private void Write(string Msg, int MessageStatus){
      
    }
  }
}
