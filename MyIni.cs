// Decompiled with JetBrains decompiler
// Type: UpdateSoftware.MyIni
// Assembly: Launcher, Version=1.0.1.2, Culture=neutral, PublicKeyToken=null
// MVID: 797B882F-7CCA-427B-93A2-7C39D257D29C
// Assembly location: C:\Users\wagne\Desktop\Launcher.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace UpdateSoftware
{
  public class MyIni
  {
    private string strFilename;

    public string FileName
    {
      get
      {
        return this.strFilename;
      }
    }

    public MyIni(string Filename)
    {
      this.strFilename = Filename;
    }

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
    public static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
    public static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
    public static extern int GetPrivateProfileInt(string lpApplicationName, string lpKeyName, int nDefault, string lpFileName);

    [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString", CharSet = CharSet.Ansi)]
    public static extern int FlushPrivateProfileString(int lpApplicationName, int lpKeyName, int lpString, string lpFileName);

    public string GetString(string Section, string Key, string Default)
    {
      StringBuilder lpReturnedString = new StringBuilder(256);
      int privateProfileString = MyIni.GetPrivateProfileString(Section, Key, Default, lpReturnedString, lpReturnedString.Capacity, this.strFilename);
      return privateProfileString <= 0 ? string.Empty : Strings.Left(lpReturnedString.ToString(), privateProfileString);
    }

    public int GetInteger(string Section, string Key, int Default)
    {
      return MyIni.GetPrivateProfileInt(Section, Key, Default, this.strFilename);
    }

    public bool GetBoolean(string Section, string Key, bool Default)
    {
      return MyIni.GetPrivateProfileInt(Section, Key, -(Default ? 1 : 0), this.strFilename) == 1;
    }

    public void WriteString(string Section, string Key, string Value)
    {
      MyIni.WritePrivateProfileString(Section, Key, Value, this.strFilename);
      this.Flush();
    }

    public void WriteInteger(string Section, string Key, int Value)
    {
      this.WriteString(Section, Key, Conversions.ToString(Value));
      this.Flush();
    }

    public void WriteBoolean(string Section, string Key, bool Value)
    {
      this.WriteString(Section, Key, Conversions.ToString(-(Value ? 1 : 0)));
      this.Flush();
    }

    private void Flush()
    {
      MyIni.FlushPrivateProfileString(0, 0, 0, this.strFilename);
    }
  }
}
