using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Devcade
{
  public static class Data
  {
    public static async Task<String> GetSaveData(String s3Object)
    {
      Console.Out.WriteLine("GetData|" + s3Object);
      while (await Console.In.ReadLineAsync() != "<DATA>") { }

      string data = "";
      string line;
      do
      {
        line = await Console.In.ReadLineAsync();
        if (line != "<EOM>")
        {
          data += line;
        }
      } while (line != "<EOM>");

      return data;
    }
  }
}
