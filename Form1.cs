// Decompiled with JetBrains decompiler
// Type: UpdateSoftware.Form1
// Assembly: Launcher, Version=1.0.1.2, Culture=neutral, PublicKeyToken=null
// MVID: 797B882F-7CCA-427B-93A2-7C39D257D29C
// Assembly location: C:\Users\wagne\Desktop\Launcher.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UpdateSoftware.My;

namespace UpdateSoftware
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;
    [AccessedThroughProperty("PictureBox4")]
    private PictureBox _PictureBox4;
    [AccessedThroughProperty("PictureBox5")]
    private PictureBox _PictureBox5;
    [AccessedThroughProperty("PictureBox6")]
    private PictureBox _PictureBox6;
    [AccessedThroughProperty("PictureBox7")]
    private PictureBox _PictureBox7;
    [AccessedThroughProperty("PictureBox8")]
    private PictureBox _PictureBox8;
    [AccessedThroughProperty("PictureBox9")]
    private PictureBox _PictureBox9;
    [AccessedThroughProperty("BackgroundWorker1")]
    private BackgroundWorker _BackgroundWorker1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("BackgroundWorker2")]
    private BackgroundWorker _BackgroundWorker2;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("NotifyIcon1")]
    private NotifyIcon _NotifyIcon1;
    [AccessedThroughProperty("BackgroundWorker3")]
    private BackgroundWorker _BackgroundWorker3;
    [AccessedThroughProperty("ContextMenuStrip1")]
    private ContextMenuStrip _ContextMenuStrip1;
    [AccessedThroughProperty("MainMenuToolStripMenuItem")]
    private ToolStripMenuItem _MainMenuToolStripMenuItem;
    [AccessedThroughProperty("OptionsToolStripMenuItem")]
    private ToolStripMenuItem _OptionsToolStripMenuItem;
    [AccessedThroughProperty("ExitToolStripMenuItem")]
    private ToolStripMenuItem _ExitToolStripMenuItem;
    [AccessedThroughProperty("BackgroundWorker4")]
    private BackgroundWorker _BackgroundWorker4;
    [AccessedThroughProperty("LinkLabel1")]
    private LinkLabel _LinkLabel1;
    [AccessedThroughProperty("LinkLabel2")]
    private LinkLabel _LinkLabel2;
    [AccessedThroughProperty("LinkLabel3")]
    private LinkLabel _LinkLabel3;
    [AccessedThroughProperty("PictureBox10")]
    private PictureBox _PictureBox10;
    [AccessedThroughProperty("PictureBox11")]
    private PictureBox _PictureBox11;
    private MD5CryptoServiceProvider md5;
    private FileStream f;
    [AccessedThroughProperty("downl")]
    private WebClient _downl;
    private string tmpdir;
    private string CurrDir;
    private int WindowMode;
    private bool SrvOn;
    private string UpdateHost;
    private string Link1;
    private string Link2;
    private string Link3;
    private string ServerName;
    private bool Flag;
    private string MainExeName;
    private string UpdateHostTmp;
    private string txt;
    private int VarCUV;
    private int VarLUV;
    private int supd;
    private bool ift;
    private int CheckChecksums;
    private string[] CheckSumFiles;
    private string FileCount;
    private string FI_1;
    private string FI_2;
    private string FI_3;
    private bool waswrong;
    private string EditSerial;
    private string SerialOffset;
    private string Serial;
    private string EditVersion;
    private string VersionOffset;
    private string Version;
    private string DefaultSerial;
    private string DefaultVersion;
    private string MainOffset;
    private string MainIP;
    private string DefaultIP;
    private string MainName;
    private int EditMain;
    private WebClient client2;
    private int OnMainExitCloseLauncher;
    private WebRequest req;
    private WebResponse res;
    private string s2;
    private bool varisok;
    private string title1;
    private string title2;
    private string title3;
    private string RegisterLink;
    private string WebsiteLink;
    private string ForumLink;

    internal virtual PictureBox PictureBox1
    {
      get
      {
        return this._PictureBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox1_MouseUp);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox1_MouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.PictureBox1_MouseClick_1);
        if (this._PictureBox1 != null)
        {
          this._PictureBox1.MouseUp -= mouseEventHandler1;
          this._PictureBox1.MouseDown -= mouseEventHandler2;
          this._PictureBox1.MouseClick -= mouseEventHandler3;
        }
        this._PictureBox1 = value;
        if (this._PictureBox1 == null)
          return;
        this._PictureBox1.MouseUp += mouseEventHandler1;
        this._PictureBox1.MouseDown += mouseEventHandler2;
        this._PictureBox1.MouseClick += mouseEventHandler3;
      }
    }

    internal virtual PictureBox PictureBox2
    {
      get
      {
        return this._PictureBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox2_MouseUp);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox2_MouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.PictureBox2_MouseClick_1);
        if (this._PictureBox2 != null)
        {
          this._PictureBox2.MouseUp -= mouseEventHandler1;
          this._PictureBox2.MouseDown -= mouseEventHandler2;
          this._PictureBox2.MouseClick -= mouseEventHandler3;
        }
        this._PictureBox2 = value;
        if (this._PictureBox2 == null)
          return;
        this._PictureBox2.MouseUp += mouseEventHandler1;
        this._PictureBox2.MouseDown += mouseEventHandler2;
        this._PictureBox2.MouseClick += mouseEventHandler3;
      }
    }

    internal virtual PictureBox PictureBox3
    {
      get
      {
        return this._PictureBox3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox3_MouseUp);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox3_MouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.PictureBox3_MouseClick_1);
        if (this._PictureBox3 != null)
        {
          this._PictureBox3.MouseUp -= mouseEventHandler1;
          this._PictureBox3.MouseDown -= mouseEventHandler2;
          this._PictureBox3.MouseClick -= mouseEventHandler3;
        }
        this._PictureBox3 = value;
        if (this._PictureBox3 == null)
          return;
        this._PictureBox3.MouseUp += mouseEventHandler1;
        this._PictureBox3.MouseDown += mouseEventHandler2;
        this._PictureBox3.MouseClick += mouseEventHandler3;
      }
    }

    internal virtual PictureBox PictureBox4
    {
      get
      {
        return this._PictureBox4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PictureBox4_Click);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox4_MouseUp);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox4_MouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.PictureBox4_MouseClick);
        if (this._PictureBox4 != null)
        {
          this._PictureBox4.Click -= eventHandler;
          this._PictureBox4.MouseUp -= mouseEventHandler1;
          this._PictureBox4.MouseDown -= mouseEventHandler2;
          this._PictureBox4.MouseClick -= mouseEventHandler3;
        }
        this._PictureBox4 = value;
        if (this._PictureBox4 == null)
          return;
        this._PictureBox4.Click += eventHandler;
        this._PictureBox4.MouseUp += mouseEventHandler1;
        this._PictureBox4.MouseDown += mouseEventHandler2;
        this._PictureBox4.MouseClick += mouseEventHandler3;
      }
    }

    internal virtual PictureBox PictureBox5
    {
      get
      {
        return this._PictureBox5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Sticky3_MouseDown1);
        if (this._PictureBox5 != null)
          this._PictureBox5.MouseDown -= mouseEventHandler;
        this._PictureBox5 = value;
        if (this._PictureBox5 == null)
          return;
        this._PictureBox5.MouseDown += mouseEventHandler;
      }
    }

    internal virtual PictureBox PictureBox6
    {
      get
      {
        return this._PictureBox6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Sticky4_MouseDown1);
        if (this._PictureBox6 != null)
          this._PictureBox6.MouseDown -= mouseEventHandler;
        this._PictureBox6 = value;
        if (this._PictureBox6 == null)
          return;
        this._PictureBox6.MouseDown += mouseEventHandler;
      }
    }

    internal virtual PictureBox PictureBox7
    {
      get
      {
        return this._PictureBox7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.PictureBox7_MouseClick);
        if (this._PictureBox7 != null)
          this._PictureBox7.MouseClick -= mouseEventHandler;
        this._PictureBox7 = value;
        if (this._PictureBox7 == null)
          return;
        this._PictureBox7.MouseClick += mouseEventHandler;
      }
    }

    internal virtual PictureBox PictureBox8
    {
      get
      {
        return this._PictureBox8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox8_MouseUp);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox8_MouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.PictureBox8_MouseClick);
        if (this._PictureBox8 != null)
        {
          this._PictureBox8.MouseUp -= mouseEventHandler1;
          this._PictureBox8.MouseDown -= mouseEventHandler2;
          this._PictureBox8.MouseClick -= mouseEventHandler3;
        }
        this._PictureBox8 = value;
        if (this._PictureBox8 == null)
          return;
        this._PictureBox8.MouseUp += mouseEventHandler1;
        this._PictureBox8.MouseDown += mouseEventHandler2;
        this._PictureBox8.MouseClick += mouseEventHandler3;
      }
    }

    internal virtual PictureBox PictureBox9
    {
      get
      {
        return this._PictureBox9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PictureBox9_Click);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox9_MouseUp);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox9_MouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.PictureBox9_MouseClick);
        if (this._PictureBox9 != null)
        {
          this._PictureBox9.Click -= eventHandler;
          this._PictureBox9.MouseUp -= mouseEventHandler1;
          this._PictureBox9.MouseDown -= mouseEventHandler2;
          this._PictureBox9.MouseClick -= mouseEventHandler3;
        }
        this._PictureBox9 = value;
        if (this._PictureBox9 == null)
          return;
        this._PictureBox9.Click += eventHandler;
        this._PictureBox9.MouseUp += mouseEventHandler1;
        this._PictureBox9.MouseDown += mouseEventHandler2;
        this._PictureBox9.MouseClick += mouseEventHandler3;
      }
    }

    internal virtual BackgroundWorker BackgroundWorker1
    {
      get
      {
        return this._BackgroundWorker1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
        if (this._BackgroundWorker1 != null)
        {
          this._BackgroundWorker1.RunWorkerCompleted -= completedEventHandler;
          this._BackgroundWorker1.DoWork -= workEventHandler;
        }
        this._BackgroundWorker1 = value;
        if (this._BackgroundWorker1 == null)
          return;
        this._BackgroundWorker1.RunWorkerCompleted += completedEventHandler;
        this._BackgroundWorker1.DoWork += workEventHandler;
      }
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Sticky2_MouseDown1);
        if (this._Label1 != null)
          this._Label1.MouseDown -= mouseEventHandler;
        this._Label1 = value;
        if (this._Label1 == null)
          return;
        this._Label1.MouseDown += mouseEventHandler;
      }
    }

    internal virtual Label Label2
    {
      get
      {
        return this._Label2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Sticky5_MouseDown1);
        if (this._Label2 != null)
          this._Label2.MouseDown -= mouseEventHandler;
        this._Label2 = value;
        if (this._Label2 == null)
          return;
        this._Label2.MouseDown += mouseEventHandler;
      }
    }

    internal virtual BackgroundWorker BackgroundWorker2
    {
      get
      {
        return this._BackgroundWorker2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker2_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker2_RunWorkerCompleted);
        if (this._BackgroundWorker2 != null)
        {
          this._BackgroundWorker2.DoWork -= workEventHandler;
          this._BackgroundWorker2.RunWorkerCompleted -= completedEventHandler;
        }
        this._BackgroundWorker2 = value;
        if (this._BackgroundWorker2 == null)
          return;
        this._BackgroundWorker2.DoWork += workEventHandler;
        this._BackgroundWorker2.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual Label Label4
    {
      get
      {
        return this._Label4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Sticky7_MouseDown1);
        if (this._Label4 != null)
          this._Label4.MouseDown -= mouseEventHandler;
        this._Label4 = value;
        if (this._Label4 == null)
          return;
        this._Label4.MouseDown += mouseEventHandler;
      }
    }

    internal virtual NotifyIcon NotifyIcon1
    {
      get
      {
        return this._NotifyIcon1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._NotifyIcon1 = value;
      }
    }

    internal virtual BackgroundWorker BackgroundWorker3
    {
      get
      {
        return this._BackgroundWorker3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackGroundWorker3_RunWorkerCompleted);
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackGroundWorker3_DoWork);
        if (this._BackgroundWorker3 != null)
        {
          this._BackgroundWorker3.RunWorkerCompleted -= completedEventHandler;
          this._BackgroundWorker3.DoWork -= workEventHandler;
        }
        this._BackgroundWorker3 = value;
        if (this._BackgroundWorker3 == null)
          return;
        this._BackgroundWorker3.RunWorkerCompleted += completedEventHandler;
        this._BackgroundWorker3.DoWork += workEventHandler;
      }
    }

    internal virtual ContextMenuStrip ContextMenuStrip1
    {
      get
      {
        return this._ContextMenuStrip1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ContextMenuStrip1 = value;
      }
    }

    internal virtual ToolStripMenuItem MainMenuToolStripMenuItem
    {
      get
      {
        return this._MainMenuToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MainMenuToolStripMenuItem_Click);
        if (this._MainMenuToolStripMenuItem != null)
          this._MainMenuToolStripMenuItem.Click -= eventHandler;
        this._MainMenuToolStripMenuItem = value;
        if (this._MainMenuToolStripMenuItem == null)
          return;
        this._MainMenuToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem OptionsToolStripMenuItem
    {
      get
      {
        return this._OptionsToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OptionsToolStripMenuItem_Click);
        if (this._OptionsToolStripMenuItem != null)
          this._OptionsToolStripMenuItem.Click -= eventHandler;
        this._OptionsToolStripMenuItem = value;
        if (this._OptionsToolStripMenuItem == null)
          return;
        this._OptionsToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ExitToolStripMenuItem
    {
      get
      {
        return this._ExitToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ExitToolStripMenuItem_Click);
        if (this._ExitToolStripMenuItem != null)
          this._ExitToolStripMenuItem.Click -= eventHandler;
        this._ExitToolStripMenuItem = value;
        if (this._ExitToolStripMenuItem == null)
          return;
        this._ExitToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual BackgroundWorker BackgroundWorker4
    {
      get
      {
        return this._BackgroundWorker4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker4_RunWorkerCompleted);
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker4_DoWork);
        if (this._BackgroundWorker4 != null)
        {
          this._BackgroundWorker4.RunWorkerCompleted -= completedEventHandler;
          this._BackgroundWorker4.DoWork -= workEventHandler;
        }
        this._BackgroundWorker4 = value;
        if (this._BackgroundWorker4 == null)
          return;
        this._BackgroundWorker4.RunWorkerCompleted += completedEventHandler;
        this._BackgroundWorker4.DoWork += workEventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel1
    {
      get
      {
        return this._LinkLabel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = (EventHandler) ((a0, a1) => this.LinkLabel1_MouseClick_1(RuntimeHelpers.GetObjectValue(a0), (MouseEventArgs) a1));
        if (this._LinkLabel1 != null)
          this._LinkLabel1.Click -= eventHandler;
        this._LinkLabel1 = value;
        if (this._LinkLabel1 == null)
          return;
        this._LinkLabel1.Click += eventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel2
    {
      get
      {
        return this._LinkLabel2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = (EventHandler) ((a0, a1) => this.LinkLabel2_MouseClick_1(RuntimeHelpers.GetObjectValue(a0), (MouseEventArgs) a1));
        if (this._LinkLabel2 != null)
          this._LinkLabel2.Click -= eventHandler;
        this._LinkLabel2 = value;
        if (this._LinkLabel2 == null)
          return;
        this._LinkLabel2.Click += eventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel3
    {
      get
      {
        return this._LinkLabel3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = (EventHandler) ((a0, a1) => this.LinkLabel3_MouseClick_1(RuntimeHelpers.GetObjectValue(a0), (MouseEventArgs) a1));
        if (this._LinkLabel3 != null)
          this._LinkLabel3.Click -= eventHandler;
        this._LinkLabel3 = value;
        if (this._LinkLabel3 == null)
          return;
        this._LinkLabel3.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox10
    {
      get
      {
        return this._PictureBox10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox10_MouseUp);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox10_MouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.PictureBox10_MouseClick);
        if (this._PictureBox10 != null)
        {
          this._PictureBox10.MouseUp -= mouseEventHandler1;
          this._PictureBox10.MouseDown -= mouseEventHandler2;
          this._PictureBox10.MouseClick -= mouseEventHandler3;
        }
        this._PictureBox10 = value;
        if (this._PictureBox10 == null)
          return;
        this._PictureBox10.MouseUp += mouseEventHandler1;
        this._PictureBox10.MouseDown += mouseEventHandler2;
        this._PictureBox10.MouseClick += mouseEventHandler3;
      }
    }

    internal virtual PictureBox PictureBox11
    {
      get
      {
        return this._PictureBox11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._PictureBox11 = value;
      }
    }

    private virtual WebClient downl
    {
      get
      {
        return this._downl;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        AsyncCompletedEventHandler completedEventHandler = new AsyncCompletedEventHandler(this.downl_DownloadFileCompleted);
        DownloadProgressChangedEventHandler changedEventHandler = new DownloadProgressChangedEventHandler(this.downl_DownloadProgressChanged);
        if (this._downl != null)
        {
          this._downl.DownloadFileCompleted -= completedEventHandler;
          this._downl.DownloadProgressChanged -= changedEventHandler;
        }
        this._downl = value;
        if (this._downl == null)
          return;
        this._downl.DownloadFileCompleted += completedEventHandler;
        this._downl.DownloadProgressChanged += changedEventHandler;
      }
    }

    public Form1()
    {
      this.Shown += new EventHandler(this.Form1_Shown);
      this.Load += new EventHandler(this.Form1_Load);
      this.MouseDown += new MouseEventHandler(this.Sticky_MouseDown1);
      this.md5 = (MD5CryptoServiceProvider) null;
      this.f = (FileStream) null;
      this.downl = new WebClient();
      this.tmpdir = SpecialDirectories.Temp + "\\NLTMP";
      this.CurrDir = SpecialDirectories.Temp + "\\NLTMPF\\";
      this.WindowMode = 0;
      this.SrvOn = false;
      this.UpdateHost = "";
      this.Link1 = "http://www.yourweb.com";
      this.Link2 = "http://www.yourweb.com/reg.php";
      this.Link3 = "http://forum.yourweb.com";
      this.ServerName = (string) null;
      this.Flag = true;
      this.MainExeName = "main.exe";
      this.UpdateHostTmp = this.UpdateHost;
      this.txt = (string) null;
      this.VarCUV = 0;
      this.VarLUV = 0;
      this.supd = 0;
      this.ift = true;
      this.CheckChecksums = 0;
      this.CheckSumFiles = (string[]) null;
      this.FileCount = (string) null;
      this.FI_1 = (string) null;
      this.FI_2 = (string) null;
      this.FI_3 = (string) null;
      this.waswrong = true;
      this.EditSerial = "0";
      this.SerialOffset = "0";
      this.Serial = "0";
      this.EditVersion = "0";
      this.VersionOffset = "0";
      this.Version = "0";
      this.DefaultSerial = "R6Z0H7RSoXQQ7VV9";
      this.DefaultVersion = "22786";
      this.MainOffset = (string) null;
      this.MainIP = (string) null;
      this.DefaultIP = "connect.muonline.co.kr";
      this.MainName = "main.exe";
      this.EditMain = 0;
      this.client2 = new WebClient();
      this.OnMainExitCloseLauncher = 0;
      this.s2 = (string) null;
      this.varisok = false;
      this.title1 = (string) null;
      this.title2 = (string) null;
      this.title3 = (string) null;
      this.RegisterLink = (string) null;
      this.WebsiteLink = (string) null;
      this.ForumLink = (string) null;
      this.InitializeComponent();
    }

    [STAThread]
    public static void Main()
    {
      Application.Run((Form) MyProject.Forms.Form1);
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.BackgroundWorker1 = new BackgroundWorker();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.BackgroundWorker2 = new BackgroundWorker();
      this.Label4 = new Label();
      this.NotifyIcon1 = new NotifyIcon(this.components);
      this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
      this.MainMenuToolStripMenuItem = new ToolStripMenuItem();
      this.OptionsToolStripMenuItem = new ToolStripMenuItem();
      this.ExitToolStripMenuItem = new ToolStripMenuItem();
      this.BackgroundWorker3 = new BackgroundWorker();
      this.BackgroundWorker4 = new BackgroundWorker();
      this.PictureBox9 = new PictureBox();
      this.PictureBox8 = new PictureBox();
      this.PictureBox7 = new PictureBox();
      this.PictureBox6 = new PictureBox();
      this.PictureBox5 = new PictureBox();
      this.PictureBox4 = new PictureBox();
      this.PictureBox3 = new PictureBox();
      this.PictureBox2 = new PictureBox();
      this.PictureBox1 = new PictureBox();
      this.LinkLabel1 = new LinkLabel();
      this.LinkLabel2 = new LinkLabel();
      this.LinkLabel3 = new LinkLabel();
      this.PictureBox10 = new PictureBox();
      this.PictureBox11 = new PictureBox();
      this.ContextMenuStrip1.SuspendLayout();
      ((ISupportInitialize) this.PictureBox9).BeginInit();
      ((ISupportInitialize) this.PictureBox8).BeginInit();
      ((ISupportInitialize) this.PictureBox7).BeginInit();
      ((ISupportInitialize) this.PictureBox6).BeginInit();
      ((ISupportInitialize) this.PictureBox5).BeginInit();
      ((ISupportInitialize) this.PictureBox4).BeginInit();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      ((ISupportInitialize) this.PictureBox10).BeginInit();
      ((ISupportInitialize) this.PictureBox11).BeginInit();
      this.SuspendLayout();
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      this.Label1.Font = new Font("Arial", 8.25f);
      this.Label1.ForeColor = System.Drawing.Color.OrangeRed;
      this.Label1.Image = (Image) UpdateSoftware.My.Resources.Resources.mine;
      Label label1_1 = this.Label1;
      Point point1 = new Point(227, 507);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(359, 14);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 11;
      this.Label1.Text = "Please Wait...";
      this.Label1.TextAlign = ContentAlignment.MiddleCenter;
      this.Label2.BackColor = System.Drawing.Color.Transparent;
      this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Pixel);
      this.Label2.ForeColor = System.Drawing.Color.Tomato;
      Label label2_1 = this.Label2;
      point1 = new Point(385, 525);
      Point point3 = point1;
      label2_1.Location = point3;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(30, 10);
      Size size3 = size1;
      label2_2.Size = size3;
      this.Label2.TabIndex = 13;
      this.Label2.Text = "0%";
      this.Label2.TextAlign = ContentAlignment.MiddleRight;
      this.Label2.Visible = false;
      this.Label4.BackColor = System.Drawing.Color.Transparent;
      this.Label4.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = System.Drawing.Color.Gold;
      Label label4_1 = this.Label4;
      point1 = new Point(525, 452);
      Point point4 = point1;
      label4_1.Location = point4;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(38, 10);
      Size size4 = size1;
      label4_2.Size = size4;
      this.Label4.TabIndex = 15;
      this.Label4.Text = "#####";
      this.Label4.TextAlign = ContentAlignment.MiddleRight;
      this.Label4.Visible = false;
      this.NotifyIcon1.ContextMenuStrip = this.ContextMenuStrip1;
      this.NotifyIcon1.Text = "Launcher";
      this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.MainMenuToolStripMenuItem,
        (ToolStripItem) this.OptionsToolStripMenuItem,
        (ToolStripItem) this.ExitToolStripMenuItem
      });
      this.ContextMenuStrip1.Name = "ContextMenuStrip1";
      ContextMenuStrip contextMenuStrip1 = this.ContextMenuStrip1;
      size1 = new Size(133, 70);
      Size size5 = size1;
      contextMenuStrip1.Size = size5;
      this.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem1 = this.MainMenuToolStripMenuItem;
      size1 = new Size(132, 22);
      Size size6 = size1;
      toolStripMenuItem1.Size = size6;
      this.MainMenuToolStripMenuItem.Text = "MainMenu";
      this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem2 = this.OptionsToolStripMenuItem;
      size1 = new Size(132, 22);
      Size size7 = size1;
      toolStripMenuItem2.Size = size7;
      this.OptionsToolStripMenuItem.Text = "Options";
      this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem3 = this.ExitToolStripMenuItem;
      size1 = new Size(132, 22);
      Size size8 = size1;
      toolStripMenuItem3.Size = size8;
      this.ExitToolStripMenuItem.Text = "Exit";
      this.PictureBox9.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_0;
      this.PictureBox9.Enabled = false;
      PictureBox pictureBox9_1 = this.PictureBox9;
      point1 = new Point(346, 394);
      Point point5 = point1;
      pictureBox9_1.Location = point5;
      this.PictureBox9.Name = "PictureBox9";
      PictureBox pictureBox9_2 = this.PictureBox9;
      size1 = new Size(117, 114);
      Size size9 = size1;
      pictureBox9_2.Size = size9;
      this.PictureBox9.TabIndex = 8;
      this.PictureBox9.TabStop = false;
      this.PictureBox8.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox8.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.option_0;
      PictureBox pictureBox8_1 = this.PictureBox8;
      point1 = new Point(586, 459);
      Point point6 = point1;
      pictureBox8_1.Location = point6;
      this.PictureBox8.Name = "PictureBox8";
      PictureBox pictureBox8_2 = this.PictureBox8;
      size1 = new Size(144, 39);
      Size size10 = size1;
      pictureBox8_2.Size = size10;
      this.PictureBox8.TabIndex = 7;
      this.PictureBox8.TabStop = false;
      this.PictureBox7.BackColor = SystemColors.Control;
      this.PictureBox7.BackgroundImage = (Image) componentResourceManager.GetObject("PictureBox7.BackgroundImage");
      PictureBox pictureBox7_1 = this.PictureBox7;
      point1 = new Point(477, 403);
      Point point7 = point1;
      pictureBox7_1.Location = point7;
      this.PictureBox7.Name = "PictureBox7";
      PictureBox pictureBox7_2 = this.PictureBox7;
      size1 = new Size(16, 15);
      Size size11 = size1;
      pictureBox7_2.Size = size11;
      this.PictureBox7.TabIndex = 6;
      this.PictureBox7.TabStop = false;
      this.PictureBox6.BackColor = System.Drawing.Color.Transparent;
      PictureBox pictureBox6_1 = this.PictureBox6;
      point1 = new Point(118, 529);
      Point point8 = point1;
      pictureBox6_1.Location = point8;
      this.PictureBox6.Name = "PictureBox6";
      PictureBox pictureBox6_2 = this.PictureBox6;
      size1 = new Size(0, 10);
      Size size12 = size1;
      pictureBox6_2.Size = size12;
      this.PictureBox6.TabIndex = 5;
      this.PictureBox6.TabStop = false;
      this.PictureBox5.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox5.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.progbar;
      PictureBox pictureBox5_1 = this.PictureBox5;
      point1 = new Point(193, 436);
      Point point9 = point1;
      pictureBox5_1.Location = point9;
      this.PictureBox5.Name = "PictureBox5";
      PictureBox pictureBox5_2 = this.PictureBox5;
      size1 = new Size(0, 10);
      Size size13 = size1;
      pictureBox5_2.Size = size13;
      this.PictureBox5.TabIndex = 4;
      this.PictureBox5.TabStop = false;
      this.PictureBox4.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox4.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.close;
      PictureBox pictureBox4_1 = this.PictureBox4;
      point1 = new Point(613, 235);
      Point point10 = point1;
      pictureBox4_1.Location = point10;
      this.PictureBox4.Name = "PictureBox4";
      PictureBox pictureBox4_2 = this.PictureBox4;
      size1 = new Size(26, 27);
      Size size14 = size1;
      pictureBox4_2.Size = size14;
      this.PictureBox4.TabIndex = 3;
      this.PictureBox4.TabStop = false;
      this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox3.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.register_0;
      this.PictureBox3.Enabled = false;
      PictureBox pictureBox3_1 = this.PictureBox3;
      point1 = new Point(64, 418);
      Point point11 = point1;
      pictureBox3_1.Location = point11;
      this.PictureBox3.Name = "PictureBox3";
      PictureBox pictureBox3_2 = this.PictureBox3;
      size1 = new Size(136, 38);
      Size size15 = size1;
      pictureBox3_2.Size = size15;
      this.PictureBox3.TabIndex = 2;
      this.PictureBox3.TabStop = false;
      this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox2.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.forum_0;
      this.PictureBox2.Enabled = false;
      PictureBox pictureBox2_1 = this.PictureBox2;
      point1 = new Point(64, 457);
      Point point12 = point1;
      pictureBox2_1.Location = point12;
      this.PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = this.PictureBox2;
      size1 = new Size(136, 44);
      Size size16 = size1;
      pictureBox2_2.Size = size16;
      this.PictureBox2.TabIndex = 1;
      this.PictureBox2.TabStop = false;
      this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox1.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.website_0;
      this.PictureBox1.Enabled = false;
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(586, 421);
      Point point13 = point1;
      pictureBox1_1.Location = point13;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(143, 37);
      Size size17 = size1;
      pictureBox1_2.Size = size17;
      this.PictureBox1.TabIndex = 0;
      this.PictureBox1.TabStop = false;
      this.LinkLabel1.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
      this.LinkLabel1.AutoSize = true;
      this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
      this.LinkLabel1.Font = new Font("Gadugi", 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LinkLabel1.LinkColor = System.Drawing.Color.Silver;
      LinkLabel linkLabel1_1 = this.LinkLabel1;
      point1 = new Point(465, 270);
      Point point14 = point1;
      linkLabel1_1.Location = point14;
      this.LinkLabel1.Name = "LinkLabel1";
      LinkLabel linkLabel1_2 = this.LinkLabel1;
      size1 = new Size(0, 12);
      Size size18 = size1;
      linkLabel1_2.Size = size18;
      this.LinkLabel1.TabIndex = 19;
      this.LinkLabel1.TabStop = true;
      this.LinkLabel2.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
      this.LinkLabel2.AutoSize = true;
      this.LinkLabel2.BackColor = System.Drawing.Color.Transparent;
      this.LinkLabel2.Font = new Font("Gadugi", 6.75f, FontStyle.Bold);
      this.LinkLabel2.LinkColor = System.Drawing.Color.Silver;
      LinkLabel linkLabel2_1 = this.LinkLabel2;
      point1 = new Point(537, 270);
      Point point15 = point1;
      linkLabel2_1.Location = point15;
      this.LinkLabel2.Name = "LinkLabel2";
      LinkLabel linkLabel2_2 = this.LinkLabel2;
      size1 = new Size(0, 12);
      Size size19 = size1;
      linkLabel2_2.Size = size19;
      this.LinkLabel2.TabIndex = 20;
      this.LinkLabel3.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
      this.LinkLabel3.AutoSize = true;
      this.LinkLabel3.BackColor = System.Drawing.Color.Transparent;
      this.LinkLabel3.Font = new Font("Gadugi", 6.75f, FontStyle.Bold);
      this.LinkLabel3.LinkColor = System.Drawing.Color.Silver;
      LinkLabel linkLabel3_1 = this.LinkLabel3;
      point1 = new Point(525, 209);
      Point point16 = point1;
      linkLabel3_1.Location = point16;
      this.LinkLabel3.Name = "LinkLabel3";
      LinkLabel linkLabel3_2 = this.LinkLabel3;
      size1 = new Size(0, 12);
      Size size20 = size1;
      linkLabel3_2.Size = size20;
      this.LinkLabel3.TabIndex = 21;
      this.LinkLabel3.TabStop = true;
      this.PictureBox10.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox10.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.__;
      PictureBox pictureBox10_1 = this.PictureBox10;
      point1 = new Point(583, 235);
      Point point17 = point1;
      pictureBox10_1.Location = point17;
      this.PictureBox10.Name = "PictureBox10";
      PictureBox pictureBox10_2 = this.PictureBox10;
      size1 = new Size(30, 27);
      Size size21 = size1;
      pictureBox10_2.Size = size21;
      this.PictureBox10.TabIndex = 23;
      this.PictureBox10.TabStop = false;
      this.PictureBox11.BackColor = System.Drawing.Color.Transparent;
      this.PictureBox11.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.progbar1;
      PictureBox pictureBox11_1 = this.PictureBox11;
      point1 = new Point(195, 469);
      Point point18 = point1;
      pictureBox11_1.Location = point18;
      this.PictureBox11.Name = "PictureBox11";
      PictureBox pictureBox11_2 = this.PictureBox11;
      size1 = new Size(0, 10);
      Size size22 = size1;
      pictureBox11_2.Size = size22;
      this.PictureBox11.TabIndex = 4;
      this.PictureBox11.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Lime;
      this.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.main_background;
      size1 = new Size(792, 607);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.PictureBox9);
      this.Controls.Add((Control) this.PictureBox11);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.PictureBox3);
      this.Controls.Add((Control) this.PictureBox10);
      this.Controls.Add((Control) this.LinkLabel3);
      this.Controls.Add((Control) this.LinkLabel2);
      this.Controls.Add((Control) this.LinkLabel1);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.PictureBox8);
      this.Controls.Add((Control) this.PictureBox7);
      this.Controls.Add((Control) this.PictureBox6);
      this.Controls.Add((Control) this.PictureBox5);
      this.Controls.Add((Control) this.PictureBox4);
      this.Controls.Add((Control) this.PictureBox2);
      this.Controls.Add((Control) this.PictureBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "Form1";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Launcher";
      this.TransparencyKey = System.Drawing.Color.Lime;
      this.ContextMenuStrip1.ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox9).EndInit();
      ((ISupportInitialize) this.PictureBox8).EndInit();
      ((ISupportInitialize) this.PictureBox7).EndInit();
      ((ISupportInitialize) this.PictureBox6).EndInit();
      ((ISupportInitialize) this.PictureBox5).EndInit();
      ((ISupportInitialize) this.PictureBox4).EndInit();
      ((ISupportInitialize) this.PictureBox3).EndInit();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      ((ISupportInitialize) this.PictureBox10).EndInit();
      ((ISupportInitialize) this.PictureBox11).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void lbl1txt()
    {
      if (this.Label1.InvokeRequired)
        this.Label1.Invoke((Delegate) new MethodInvoker(this.lbl1txt));
      else
        this.Label1.Text = this.txt;
    }

    private void Sticky_MouseDown1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Capture = false;
      Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
      this.WndProc(ref m);
    }

    private void Sticky2_MouseDown1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Label1.Capture = false;
      Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
      this.WndProc(ref m);
    }

    private void Sticky3_MouseDown1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox5.Capture = false;
      Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
      this.WndProc(ref m);
    }

    private void Sticky4_MouseDown1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox6.Capture = false;
      Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
      this.WndProc(ref m);
    }

    private void Sticky5_MouseDown1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Label2.Capture = false;
      Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
      this.WndProc(ref m);
    }

    private void Sticky6_MouseDown1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
      this.WndProc(ref m);
    }

    private void Sticky7_MouseDown1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Label4.Capture = false;
      Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
      this.WndProc(ref m);
    }

    private void StartUpdate()
    {
      if (!this.UrlIsValid(this.WebsiteLink))
      {
        this.PictureBox1.Enabled = false;
        int num = (int) Interaction.MsgBox((object) "Edit Url's In Config.cMu", MsgBoxStyle.OkOnly, (object) null);
      }
      if (!this.UrlIsValid(this.RegisterLink))
      {
        this.PictureBox2.Enabled = false;
        int num = (int) Interaction.MsgBox((object) "Edit Url's In Config.cMu", MsgBoxStyle.OkOnly, (object) null);
      }
      if (!this.UrlIsValid(this.ForumLink))
      {
        this.PictureBox3.Enabled = false;
        int num = (int) Interaction.MsgBox((object) "Edit Url's In Config.cMu", MsgBoxStyle.OkOnly, (object) null);
      }
      if (MyProject.Computer.FileSystem.DirectoryExists(this.tmpdir))
        MyProject.Computer.FileSystem.DeleteDirectory(this.tmpdir, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing);
      this.WindowMode = Conversions.ToInteger(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "WindowMode", (object) 1337));
      if (this.WindowMode == 0)
        this.PictureBox7.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.checkbox_0;
      else if (this.WindowMode == 1)
        this.PictureBox7.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.checkbox_1;
      else if (this.WindowMode == 1337)
      {
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "WindowMode", (object) 0);
        this.WindowMode = 0;
      }
      this.VarLUV = Conversions.ToInteger(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\UpdateSoft\\" + this.ServerName + "\\Config", "VarLUV", (object) 1337));
      if (this.VarLUV == 1337)
        this.VarLUV = 0;
      this.BackgroundWorker1.RunWorkerAsync();
    }

    private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      this.txt = this.ift ? "Connecting to the update server, please wait..." : "Trying to connect to default server...";
      this.lbl1txt();
      try
      {
        MyProject.Computer.FileSystem.CreateDirectory(this.tmpdir);
        MyProject.Computer.Network.DownloadFile("http://" + this.UpdateHost + "/Launcher/var.ini", this.tmpdir + "\\var.ini", "", "", false, 10000, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.SrvOn = false;
        ProjectData.ClearProjectError();
        return;
      }
      this.SrvOn = true;
    }

    private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (this.SrvOn)
      {
        if (!this.ift)
          MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\UpdateSoft\\" + this.ServerName + "\\Config", "UH", (object) this.UpdateHostTmp, RegistryValueKind.String);
        this.txt = "Connection established...checking for updates...";
        this.lbl1txt();
        this.BackgroundWorker2.RunWorkerAsync();
      }
      else if (this.ift)
      {
        this.ift = false;
        this.UpdateHost = this.UpdateHostTmp;
        this.StartUpdate();
      }
      else
      {
        this.txt = "Could not connect to the Update Server.";
        this.lbl1txt();
        this.PictureBox9.Enabled = false;
        this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_0;
      }
    }

    private bool UrlIsValid(string url)
    {
      if (url.ToLower().StartsWith("www."))
        url = "http://" + url;
      HttpWebResponse httpWebResponse = (HttpWebResponse) null;
      bool flag;
      try
      {
        httpWebResponse = (HttpWebResponse) ((HttpWebRequest) WebRequest.Create(url)).GetResponse();
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
      }
      finally
      {
        if (httpWebResponse != null)
          httpWebResponse.Close();
      }
      return flag;
    }

    private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
    {
      MyIni myIni = new MyIni(this.tmpdir + "\\var.ini");
      try
      {
        this.OnMainExitCloseLauncher = 1;
        this.VarCUV = Conversions.ToInteger(myIni.GetString("Settings", "ClientUpdateVersion", (string) null));
        this.CheckChecksums = Conversions.ToInteger(myIni.GetString("Settings", "CheckChecksums", Conversions.ToString(0)));
        this.EditMain = Conversions.ToInteger(myIni.GetString("Settings", "EditMain", Conversions.ToString(0)));
        this.Link1 = myIni.GetString("NewSetting", "Link1", (string) null);
        this.Link2 = myIni.GetString("NewSetting", "Link2", (string) null);
        this.Link3 = myIni.GetString("NewSetting", "Link3", (string) null);
        this.UpdateHost = myIni.GetString("Settings", "UpdateHost", (string) null);
        this.MainOffset = myIni.GetString("Settings", "MainOffset", "(none)");
        this.MainIP = myIni.GetString("Settings", "MainIP", "(none)");
        this.EditSerial = myIni.GetString("Settings", "EditSerial", "(none)");
        this.SerialOffset = myIni.GetString("Settings", "SerialOffset", "(none)");
        this.Serial = myIni.GetString("Settings", "Serial", "(none)");
        this.EditVersion = myIni.GetString("Settings", "EditVersion", "(none)");
        this.VersionOffset = myIni.GetString("Settings", "VersionOffset", "(none)");
        this.Version = myIni.GetString("Settings", "Version", "(none)");
        this.MainExeName = myIni.GetString("Settings", "MainExeName", "main.exe");
        this.title1 = myIni.GetString("NewSetting", "News1", (string) null);
        this.title2 = myIni.GetString("NewSetting", "News2", (string) null);
        this.title3 = myIni.GetString("NewSetting", "News3", (string) null);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.txt = "Connection lost...please restart the launcher!";
        this.lbl1txt();
        this.PictureBox9.Enabled = false;
        this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_0;
        ProjectData.ClearProjectError();
        return;
      }
      Point point1;
      if (Strings.Len(this.title1) > 1)
      {
        this.LinkLabel1.Text = this.title1;
        this.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Aqua;
        LinkLabel linkLabel1 = this.LinkLabel1;
        point1 = new Point(457, 269);
        Point point2 = point1;
        linkLabel1.Location = point2;
      }
      else
      {
        this.LinkLabel1.Text = "";
        this.LinkLabel1.ForeColor = System.Drawing.Color.Red;
        LinkLabel linkLabel1 = this.LinkLabel1;
        point1 = new Point(457, 269);
        Point point2 = point1;
        linkLabel1.Location = point2;
      }
      if (Strings.Len(this.title2) > 1)
      {
        this.LinkLabel2.Text = this.title2;
        this.LinkLabel2.ActiveLinkColor = System.Drawing.Color.Aqua;
        LinkLabel linkLabel2 = this.LinkLabel2;
        point1 = new Point(457, 297);
        Point point2 = point1;
        linkLabel2.Location = point2;
      }
      else
      {
        this.LinkLabel2.Text = "";
        this.LinkLabel2.ForeColor = System.Drawing.Color.Red;
        LinkLabel linkLabel2 = this.LinkLabel2;
        point1 = new Point(457, 297);
        Point point2 = point1;
        linkLabel2.Location = point2;
      }
      if (Strings.Len(this.title3) > 1)
      {
        this.LinkLabel3.Text = this.title3;
        this.LinkLabel3.ActiveLinkColor = System.Drawing.Color.Aqua;
        LinkLabel linkLabel3 = this.LinkLabel3;
        point1 = new Point(457, 327);
        Point point2 = point1;
        linkLabel3.Location = point2;
      }
      else
      {
        this.LinkLabel3.Text = "";
        this.LinkLabel3.ForeColor = System.Drawing.Color.Red;
        LinkLabel linkLabel3 = this.LinkLabel3;
        point1 = new Point(457, 327);
        Point point2 = point1;
        linkLabel3.Location = point2;
      }
      if (this.VarCUV == 0 & Operators.CompareString(this.UpdateHost, (string) null, false) == 0)
      {
        this.varisok = false;
      }
      else
      {
        this.varisok = true;
        try
        {
          if (this.CheckChecksums == 1)
          {
            MyProject.Computer.FileSystem.DeleteDirectory(this.tmpdir, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing);
            MyProject.Computer.FileSystem.CreateDirectory(this.tmpdir);
            MyProject.Computer.Network.DownloadFile("http://" + this.UpdateHost + "/Launcher/CheckSumFiles.txt", this.tmpdir + "\\CheckSumFiles.txt", (string) null, (string) null, false, 100, true);
          }
          else
            MyProject.Computer.FileSystem.DeleteDirectory(this.tmpdir, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          this.VarLUV = Conversions.ToInteger(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\UpdateSoft\\" + this.ServerName + "\\Config", "VarLUV", (object) null));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.OkOnly, (object) null);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void BackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!this.varisok)
      {
        try
        {
          MyProject.Computer.FileSystem.DeleteDirectory(this.tmpdir, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.txt = "The config file on the server host is either corrupted or doesn't exist...";
        this.lbl1txt();
        this.PictureBox9.Enabled = false;
        this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_0;
      }
      else if (this.VarCUV == this.VarLUV)
      {
        this.txt = "There are no updates. You can go and play!";
        this.lbl1txt();
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\UpdateSoft\\" + this.ServerName + "\\Config", "UH", (object) this.UpdateHost, RegistryValueKind.String);
        this.PictureBox9.Enabled = true;
        this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_1;
      }
      else
      {
        if (this.VarCUV > this.VarLUV)
        {
          if (this.VarLUV >= 0)
          {
            this.supd = checked (this.VarCUV - (this.VarCUV - this.VarLUV) + 1);
          }
          else
          {
            this.VarLUV = 0;
            this.supd = 0;
          }
        }
        else
        {
          this.VarLUV = 0;
          this.supd = 0;
        }
        this.Label1.Text = "Downloading updates, please wait...";
        this.Label4.Text = Conversions.ToString(checked (this.supd - this.VarLUV)) + "/" + Conversions.ToString(checked (this.VarCUV - this.VarLUV));
        this.Label4.Visible = true;
        try
        {
          this.PictureBox5.Visible = true;
          MyProject.Computer.FileSystem.CreateDirectory(this.CurrDir);
          this.downl.DownloadFileAsync(new Uri("http://" + this.UpdateHost + "/Launcher/Updates/" + Conversions.ToString(this.supd) + ".exe"), this.CurrDir + Conversions.ToString(this.supd) + ".exe");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.Label1.Text = "Error downloading updates.";
          ProjectData.ClearProjectError();
        }
      }
    }

    private void downl_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      PictureBox pictureBox5 = this.PictureBox5;
      Size size1 = new Size(checked ((int) Math.Round(unchecked ((double) e.BytesReceived / (double) e.TotalBytesToReceive * 100.0 * 4.0))), 10);
      Size size2 = size1;
      pictureBox5.Size = size2;
      PictureBox pictureBox11 = this.PictureBox11;
      size1 = new Size(checked ((int) Math.Round(unchecked ((double) e.BytesReceived / (double) e.TotalBytesToReceive * 100.0 * 4.0))), 10);
      Size size3 = size1;
      pictureBox11.Size = size3;
      this.Label2.Show();
      this.Label2.Text = Conversions.ToString(e.ProgressPercentage) + "%";
    }

    private void downl_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
    {
      try
      {
        if (this.supd == this.VarCUV)
          this.VarLUV = this.VarCUV;
        this.TopMost = true;
        Process.Start(this.CurrDir + Conversions.ToString(this.supd) + ".exe").WaitForExit();
        MyProject.Computer.FileSystem.DeleteFile(this.CurrDir + Conversions.ToString(this.supd) + ".exe");
        this.TopMost = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\UpdateSoft\\" + this.ServerName + "\\Config", "VarLUV", (object) 0);
        if (MyProject.Computer.FileSystem.FileExists(this.CurrDir + "0.exe"))
          MyProject.Computer.FileSystem.DeleteFile(this.CurrDir + "0.exe");
        if (MyProject.Computer.FileSystem.FileExists(this.CurrDir + Conversions.ToString(this.VarCUV) + ".exe"))
          MyProject.Computer.FileSystem.DeleteFile(this.CurrDir + Conversions.ToString(this.VarCUV) + ".exe");
        this.Label1.Text = "Error downloading updates. Please restart the launcher!";
        ProjectData.ClearProjectError();
        return;
      }
      if (this.supd == this.VarCUV)
      {
        this.Label1.Text = "Decompressing files...";
        this.BackgroundWorker4.RunWorkerAsync();
      }
      else
      {
        this.Label1.Text = "Downloading updates, please wait...";
        this.supd = checked (this.supd + 1);
        this.Label4.Text = Conversions.ToString(checked (this.supd - this.VarLUV)) + "/" + Conversions.ToString(checked (this.VarCUV - this.VarLUV));
        try
        {
          this.PictureBox5.Visible = true;
          this.downl.DownloadFileAsync(new Uri("http://" + this.UpdateHost + "/Launcher/Updates/" + Conversions.ToString(this.supd) + ".exe"), this.CurrDir + Conversions.ToString(this.supd) + ".exe");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\UpdateSoft\\" + this.ServerName + "\\Config", "VarLUV", (object) 0);
          if (MyProject.Computer.FileSystem.FileExists(this.CurrDir + "0.exe"))
            MyProject.Computer.FileSystem.DeleteFile(this.CurrDir + "0.exe");
          if (MyProject.Computer.FileSystem.FileExists(this.CurrDir + Conversions.ToString(this.VarCUV) + ".exe"))
            MyProject.Computer.FileSystem.DeleteFile(this.CurrDir + Conversions.ToString(this.VarCUV) + ".exe");
          this.Label1.Text = "Error downloading updates. Please restart the launcher!";
          ProjectData.ClearProjectError();
        }
      }
    }

    protected void Shutdown()
    {
      this.NotifyIcon1.Visible = false;
      this.Flag = false;
      Application.Exit();
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void BackgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
    {
      string directoryPath = MyProject.Application.Info.DirectoryPath;
      string str = this.CurrDir.Replace(MyProject.Computer.FileSystem.GetName(SpecialDirectories.Temp + "\\NLTMPF") + "\\", MyProject.Computer.FileSystem.GetName(MyProject.Application.Info.DirectoryPath));
      if (MyProject.Computer.FileSystem.DirectoryExists(str))
        MyProject.Computer.FileSystem.DeleteDirectory(str, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing);
      MyProject.Computer.FileSystem.RenameDirectory(this.CurrDir, MyProject.Computer.FileSystem.GetName(MyProject.Application.Info.DirectoryPath));
      string destinationDirectoryName = directoryPath.Replace(MyProject.Computer.FileSystem.GetName(MyProject.Application.Info.DirectoryPath), (string) null);
      MyProject.Computer.FileSystem.CopyDirectory(str, destinationDirectoryName, true);
      if (!MyProject.Computer.FileSystem.DirectoryExists(str))
        return;
      MyProject.Computer.FileSystem.DeleteDirectory(str, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing);
    }

    private void BackgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.Label4.Visible = false;
      this.Label1.Text = "Update Completed. Have fun! =P";
      MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\UpdateSoft\\" + this.ServerName + "\\Config", "UH", (object) this.UpdateHost, RegistryValueKind.String);
      try
      {
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\UpdateSoft\\" + this.ServerName + "\\Config", "VarLUV", (object) this.VarLUV);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.OkOnly, (object) null);
        ProjectData.ClearProjectError();
      }
      this.PictureBox9.Enabled = true;
      this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_1;
    }

    private void PictureBox1_MouseClick_1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      new Thread(new ThreadStart(this.picbox1)).Start();
    }

    private void picbox1()
    {
      Process.Start(this.WebsiteLink);
    }

    private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox1.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.website_1;
    }

    private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox1.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.website_0;
    }

    private void PictureBox2_MouseClick_1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      new Thread(new ThreadStart(this.picbox2)).Start();
    }

    private void picbox2()
    {
      Process.Start(this.ForumLink);
    }

    private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox2.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.forum_1;
    }

    private void PictureBox2_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox2.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.forum_0;
    }

    private void PictureBox3_MouseClick_1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      new Thread(new ThreadStart(this.picbox3)).Start();
    }

    private void picbox3()
    {
      Process.Start(this.RegisterLink);
    }

    private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox3.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.register_1;
    }

    private void PictureBox3_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox3.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.register_0;
    }

    private void PictureBox4_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      this.Shutdown();
    }

    private void PictureBox4_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox4.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.close_1;
    }

    private void PictureBox4_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox4.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.close;
    }

    private void PictureBox10_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      this.WindowState = FormWindowState.Minimized;
    }

    private void PictureBox10_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox10.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources._Hovered;
    }

    private void PictureBox10_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox10.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.__;
    }

    private void PictureBox7_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      if (this.WindowMode == 0)
      {
        this.PictureBox7.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.checkbox_1;
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "WindowMode", (object) 1);
        this.WindowMode = 1;
      }
      else
      {
        if (this.WindowMode != 1)
          return;
        this.PictureBox7.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.checkbox_0;
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "WindowMode", (object) 0);
        this.WindowMode = 0;
      }
    }

    private void PictureBox8_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox8.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.option_0;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      this.Refresh();
      MyProject.Forms.Form2.Label1.Location = new Point(202, 399);
      MyProject.Forms.Form2.Label1.Text = this.ServerName;
      MyProject.Forms.Form2.Show();
      MyProject.Forms.Form2.BringToFront();
    }

    private void PictureBox8_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox8.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.option_1;
    }

    private void PictureBox8_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox8.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.option_0;
    }

    private void PictureBox9_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_1;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      this.Refresh();
      if (this.CheckChecksums == 1)
      {
        this.CheckSumFiles = System.IO.File.ReadAllLines(this.tmpdir + "\\CheckSumFiles.txt");
        try
        {
          MyProject.Computer.FileSystem.DeleteDirectory(this.tmpdir, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently, UICancelOption.DoNothing);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.FileCount = this.CheckSumFiles[0];
        if (Conversions.ToDouble(this.FileCount) == 0.0)
        {
          this.StartAndEditMain();
        }
        else
        {
          this.FI_1 = Conversions.ToString(2);
          this.FI_2 = Conversions.ToString(1);
          this.FI_3 = Conversions.ToString(0);
          if (MyProject.Computer.FileSystem.FileExists(this.CheckSumFiles[1]))
          {
            this.CheckSum(this.CheckSumFiles[1]);
          }
          else
          {
            int num = (int) Interaction.MsgBox((object) (this.CheckSumFiles[1] + " not found."), MsgBoxStyle.OkOnly, (object) null);
          }
        }
      }
      else
        this.StartAndEditMain();
    }

    private void PictureBox9_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_2;
    }

    private void PictureBox9_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_1;
    }

    public void CheckSum(string filename)
    {
      try
      {
        this.f = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.Message, MsgBoxStyle.OkOnly, (object) null);
        this.NotifyIcon1.Visible = false;
        ProjectData.ClearProjectError();
        return;
      }
      this.md5 = new MD5CryptoServiceProvider();
      this.md5.ComputeHash((Stream) this.f);
      byte[] hash = this.md5.Hash;
      StringBuilder stringBuilder = new StringBuilder();
      byte[] numArray = hash;
      int index = 0;
      while (index < numArray.Length)
      {
        byte num = numArray[index];
        stringBuilder.Append(string.Format("{0:X2}", (object) num));
        checked { ++index; }
      }
      if (Operators.CompareString(stringBuilder.ToString(), this.CheckSumFiles[Conversions.ToInteger(this.FI_1)], false) == 0)
      {
        this.f.Close();
        this.FI_1 = Conversions.ToString(Conversions.ToDouble(this.FI_1) + 2.0);
        this.FI_2 = Conversions.ToString(Conversions.ToDouble(this.FI_2) + 2.0);
        this.FI_3 = Conversions.ToString(Conversions.ToDouble(this.FI_3) + 1.0);
        if (Operators.CompareString(this.FI_3, this.CheckSumFiles[0], false) == 0)
          this.StartAndEditMain();
        else if (MyProject.Computer.FileSystem.FileExists(this.CheckSumFiles[Conversions.ToInteger(this.FI_2)]))
        {
          this.CheckSum(this.CheckSumFiles[Conversions.ToInteger(this.FI_2)]);
        }
        else
        {
          int num = (int) Interaction.MsgBox((object) (this.CheckSumFiles[Conversions.ToInteger(this.FI_2)] + " not found."), MsgBoxStyle.OkOnly, (object) null);
        }
      }
      else if (Operators.CompareString(this.FI_3, this.CheckSumFiles[0], false) == 0)
      {
        this.StartAndEditMain();
      }
      else
      {
        this.f.Close();
        MyProject.Computer.Network.DownloadFile("http://" + this.UpdateHost + "/Launcher/" + this.CheckSumFiles[Conversions.ToInteger(this.FI_2)].Replace("\\", "/"), this.CurrDir + this.CheckSumFiles[Conversions.ToInteger(this.FI_2)], "", "", false, 100, true);
        this.FI_1 = Conversions.ToString(Conversions.ToDouble(this.FI_1) + 2.0);
        this.FI_2 = Conversions.ToString(Conversions.ToDouble(this.FI_2) + 2.0);
        this.FI_3 = Conversions.ToString(Conversions.ToDouble(this.FI_3) + 1.0);
        if (Operators.CompareString(this.FI_3, this.CheckSumFiles[0], false) == 0)
          this.StartAndEditMain();
        else if (MyProject.Computer.FileSystem.FileExists(this.CheckSumFiles[Conversions.ToInteger(this.FI_2)]))
        {
          this.CheckSum(this.CheckSumFiles[Conversions.ToInteger(this.FI_2)]);
        }
        else
        {
          int num = (int) Interaction.MsgBox((object) (this.CheckSumFiles[Conversions.ToInteger(this.FI_2)] + " not found."), MsgBoxStyle.OkOnly, (object) null);
        }
      }
    }

    private void StartAndEditMain()
    {
      if (MyProject.Computer.FileSystem.FileExists(this.MainExeName))
      {
        if (Conversions.ToDouble(this.EditSerial) == 1.0)
        {
          using (BinaryWriter binaryWriter = new BinaryWriter((Stream) new FileStream(this.MainExeName, FileMode.Open, FileAccess.ReadWrite)))
          {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            binaryWriter.BaseStream.Seek(Conversions.ToLong("&H" + this.SerialOffset), SeekOrigin.Begin);
            binaryWriter.Write(asciiEncoding.GetBytes(this.Serial));
          }
        }
        if (Conversions.ToDouble(this.EditVersion) == 1.0)
        {
          using (BinaryWriter binaryWriter = new BinaryWriter((Stream) new FileStream(this.MainExeName, FileMode.Open, FileAccess.ReadWrite)))
          {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            binaryWriter.BaseStream.Seek(Conversions.ToLong("&H" + this.VersionOffset), SeekOrigin.Begin);
            binaryWriter.Write(asciiEncoding.GetBytes(this.Version));
          }
        }
        if (this.EditMain == 1)
        {
          uint num = 0;
          using (BinaryWriter binaryWriter = new BinaryWriter((Stream) new FileStream(this.MainExeName, FileMode.Open, FileAccess.ReadWrite)))
          {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            binaryWriter.BaseStream.Seek(Conversions.ToLong("&H" + this.MainOffset), SeekOrigin.Begin);
            binaryWriter.Write(asciiEncoding.GetBytes(this.MainIP));
            binaryWriter.Write(num);
            binaryWriter.Write(num);
            binaryWriter.Write(num);
            binaryWriter.Write(num);
          }
          this.PictureBox9.Enabled = false;
          this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_0;
          this.Hide();
          this.NotifyIcon1.Visible = true;
          this.BackgroundWorker3.RunWorkerAsync();
        }
        else
        {
          this.PictureBox9.Enabled = false;
          this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_0;
          this.Hide();
          this.NotifyIcon1.Visible = true;
          Process.Start(this.MainExeName).WaitForExit();
          if (Conversions.ToDouble(this.EditSerial) == 1.0)
          {
            using (BinaryWriter binaryWriter = new BinaryWriter((Stream) new FileStream(this.MainExeName, FileMode.Open, FileAccess.ReadWrite)))
            {
              ASCIIEncoding asciiEncoding = new ASCIIEncoding();
              binaryWriter.BaseStream.Seek(Conversions.ToLong("&H" + this.SerialOffset), SeekOrigin.Begin);
              binaryWriter.Write(asciiEncoding.GetBytes(this.DefaultSerial));
            }
          }
          if (Conversions.ToDouble(this.EditVersion) == 1.0)
          {
            using (BinaryWriter binaryWriter = new BinaryWriter((Stream) new FileStream(this.MainExeName, FileMode.Open, FileAccess.ReadWrite)))
            {
              ASCIIEncoding asciiEncoding = new ASCIIEncoding();
              binaryWriter.BaseStream.Seek(Conversions.ToLong("&H" + this.VersionOffset), SeekOrigin.Begin);
              binaryWriter.Write(asciiEncoding.GetBytes(this.DefaultVersion));
            }
          }
          if (this.OnMainExitCloseLauncher == 1)
          {
            this.Shutdown();
          }
          else
          {
            this.PictureBox9.Enabled = true;
            this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_1;
            this.NotifyIcon1.Visible = false;
            this.Show();
          }
        }
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) ("Error: Could not find " + this.MainExeName + ", please reinstall your client!"), MsgBoxStyle.OkOnly, (object) null);
      }
    }

    private void BackGroundWorker3_DoWork(object sender, DoWorkEventArgs e)
    {
      Process.Start(this.MainName).WaitForExit();
      if (Conversions.ToDouble(this.EditSerial) == 1.0)
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) new FileStream(this.MainName, FileMode.Open, FileAccess.ReadWrite)))
        {
          ASCIIEncoding asciiEncoding = new ASCIIEncoding();
          binaryWriter.BaseStream.Seek(Conversions.ToLong("&H" + this.SerialOffset), SeekOrigin.Begin);
          binaryWriter.Write(asciiEncoding.GetBytes(this.DefaultSerial));
        }
      }
      if (Conversions.ToDouble(this.EditVersion) == 1.0)
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) new FileStream(this.MainName, FileMode.Open, FileAccess.ReadWrite)))
        {
          ASCIIEncoding asciiEncoding = new ASCIIEncoding();
          binaryWriter.BaseStream.Seek(Conversions.ToLong("&H" + this.VersionOffset), SeekOrigin.Begin);
          binaryWriter.Write(asciiEncoding.GetBytes(this.DefaultVersion));
        }
      }
      uint num = 0;
      using (BinaryWriter binaryWriter = new BinaryWriter((Stream) new FileStream(this.MainName, FileMode.Open, FileAccess.ReadWrite)))
      {
        ASCIIEncoding asciiEncoding = new ASCIIEncoding();
        binaryWriter.BaseStream.Seek(Conversions.ToLong("&H" + this.MainOffset), SeekOrigin.Begin);
        binaryWriter.Write(asciiEncoding.GetBytes(this.DefaultIP));
        binaryWriter.Write(num);
        binaryWriter.Write(num);
        binaryWriter.Write(num);
        binaryWriter.Write(num);
      }
    }

    private void BackGroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (this.OnMainExitCloseLauncher == 1)
      {
        this.Shutdown();
      }
      else
      {
        this.PictureBox9.Enabled = true;
        this.PictureBox9.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.start_1;
        this.NotifyIcon1.Visible = false;
        this.Show();
      }
    }

    private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Show();
      this.NotifyIcon1.Visible = false;
    }

    private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Form2.Show();
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Shutdown();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      this.PictureBox1.Enabled = true;
      this.PictureBox2.Enabled = true;
      this.PictureBox3.Enabled = true;
      MyIni myIni = new MyIni(".//Config.cMu");
      this.UpdateHost = myIni.GetString("Settings", "UpdateHost", (string) null);
      this.ServerName = myIni.GetString("Settings", "ServerName", (string) null);
      this.WebsiteLink = myIni.GetString("Links", "WebsiteLink", (string) null);
      this.ForumLink = myIni.GetString("Links", "ForumLink", (string) null);
      this.RegisterLink = myIni.GetString("Links", "RegisterLink", (string) null);
      MyProject.Forms.Form2.Label1.Text = this.ServerName;
      if (Operators.CompareString(this.UpdateHost, "nopz", false) == 0)
      {
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\UpdateSoft\\" + this.ServerName + "\\Config", "UH", (object) this.UpdateHostTmp, RegistryValueKind.String);
        this.UpdateHost = this.UpdateHostTmp;
      }
      this.StartUpdate();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void PictureBox9_Click(object sender, EventArgs e)
    {
    }

    private void LinkLabel1_MouseClick_1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      new Thread(new ThreadStart(this.newsbox1)).Start();
    }

    private void newsbox1()
    {
      Process.Start(this.Link1);
    }

    private void LinkLabel2_MouseClick_1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      new Thread(new ThreadStart(this.newsbox2)).Start();
    }

    private void newsbox2()
    {
      Process.Start(this.Link2);
    }

    private void LinkLabel3_MouseClick_1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      new Thread(new ThreadStart(this.newsbox3)).Start();
    }

    private void newsbox3()
    {
      Process.Start(this.Link3);
    }

    private void PictureBox10_Click(object sender, EventArgs e)
    {
    }

    private void PictureBox4_Click(object sender, EventArgs e)
    {
    }
  }
}
