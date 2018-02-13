// Decompiled with JetBrains decompiler
// Type: UpdateSoftware.My.MySettingsProperty
// Assembly: Launcher, Version=1.0.1.2, Culture=neutral, PublicKeyToken=null
// MVID: 797B882F-7CCA-427B-93A2-7C39D257D29C
// Assembly location: C:\Users\wagne\Desktop\Launcher.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UpdateSoftware.My
{
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [HideModuleName]
  [StandardModule]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        return MySettings.Default;
      }
    }
  }
}
