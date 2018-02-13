// Decompiled with JetBrains decompiler
// Type: UpdateSoftware.My.MySettings
// Assembly: Launcher, Version=1.0.1.2, Culture=neutral, PublicKeyToken=null
// MVID: 797B882F-7CCA-427B-93A2-7C39D257D29C
// Assembly location: C:\Users\wagne\Desktop\Launcher.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace UpdateSoftware.My
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    public static MySettings Default
    {
      get
      {
        return MySettings.defaultInstance;
      }
    }
  }
}
