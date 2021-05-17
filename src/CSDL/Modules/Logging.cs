using System;
using System.IO;

namespace CSDL.Logging{
  public class Log{
    private int LogState;
    private string Path;
    public Log(int logState, string path = ""){
      LogState = logState;
      Path = path;
    }
    public void LogMsg(string Msg, int Line, string FileName, int MessageStatus = 0){
      if(LogState == 1){
        if(MessageStatus == 0){
          using (StreamWriter writer = new StreamWriter(Path, true))
          {  
            writer.WriteLine("Log:: File - " + FileName + "Line - " + Line + " >"  + "Status 0 - Message::" + Msg + "::EndLog");
          }  
        }
        if(MessageStatus == 1){
           using (StreamWriter writer = new StreamWriter(Path, true))  
          {  
            writer.WriteLine("Log:: File - " + FileName + "Line - " + Line + " >"  + "Status 1 - Warning::" + Msg + "::EndLog");
          }  
        }
        if(MessageStatus == 2){
          using (StreamWriter writer = new StreamWriter(Path, true))  
          {  
            writer.WriteLine("Log:: File - " + FileName + "Line - " + Line + " >"  + "Status 2 - Error::" + Msg + "::EndLog");
          }
        }
      }
      if(LogState == 2){
        if(MessageStatus == 0){
          Console.WriteLine("Log:: File - " + FileName + "Line - " + Line + " >"  + "Status 0 - Message::" + Msg + "::EndLog");
        }
        if(MessageStatus == 1){
          Console.WriteLine("Log:: File - " + FileName + "Line - " + Line + " >" + "Status 1 - Warning::" + Msg + "::EndLog");
        }
        if(MessageStatus == 2){
          Console.WriteLine("Log:: File - " + FileName + "Line - " + Line + " >" + "Status 2 - Error::" + Msg + "::EndLog");
        }
      }
    }
  }
}
