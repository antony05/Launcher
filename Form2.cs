// Decompiled with JetBrains decompiler
// Type: UpdateSoftware.Form2
// Assembly: Launcher, Version=1.0.1.2, Culture=neutral, PublicKeyToken=null
// MVID: 797B882F-7CCA-427B-93A2-7C39D257D29C
// Assembly location: C:\Users\wagne\Desktop\Launcher.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UpdateSoftware.My;

namespace UpdateSoftware
{
  [DesignerGenerated]
  public class Form2 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("CheckBox2")]
    private CheckBox _CheckBox2;
    [AccessedThroughProperty("CheckBox1")]
    private CheckBox _CheckBox1;
    [AccessedThroughProperty("RadioButton3")]
    private RadioButton _RadioButton3;
    [AccessedThroughProperty("RadioButton2")]
    private RadioButton _RadioButton2;
    [AccessedThroughProperty("RadioButton5")]
    private RadioButton _RadioButton5;
    [AccessedThroughProperty("RadioButton4")]
    private RadioButton _RadioButton4;
    [AccessedThroughProperty("RadioButton1")]
    private RadioButton _RadioButton1;
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("PictureBox3")]
    private PictureBox _PictureBox3;
    [AccessedThroughProperty("RadioButton6")]
    private RadioButton _RadioButton6;
    [AccessedThroughProperty("RadioButton7")]
    private RadioButton _RadioButton7;
    [AccessedThroughProperty("RadioButton8")]
    private RadioButton _RadioButton8;
    [AccessedThroughProperty("RadioButton9")]
    private RadioButton _RadioButton9;
    [AccessedThroughProperty("RadioButton10")]
    private RadioButton _RadioButton10;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;

    internal virtual PictureBox PictureBox1
    {
      get
      {
        return this._PictureBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox1_MouseDown);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox1_MouseClick);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.PictureBox1_MouseUp);
        if (this._PictureBox1 != null)
        {
          this._PictureBox1.MouseDown -= mouseEventHandler1;
          this._PictureBox1.MouseClick -= mouseEventHandler2;
          this._PictureBox1.MouseUp -= mouseEventHandler3;
        }
        this._PictureBox1 = value;
        if (this._PictureBox1 == null)
          return;
        this._PictureBox1.MouseDown += mouseEventHandler1;
        this._PictureBox1.MouseClick += mouseEventHandler2;
        this._PictureBox1.MouseUp += mouseEventHandler3;
      }
    }

    internal virtual TextBox TextBox1
    {
      get
      {
        return this._TextBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
        if (this._TextBox1 != null)
          this._TextBox1.TextChanged -= eventHandler;
        this._TextBox1 = value;
        if (this._TextBox1 == null)
          return;
        this._TextBox1.TextChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox2
    {
      get
      {
        return this._CheckBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.CheckBox2_MouseClick);
        if (this._CheckBox2 != null)
          this._CheckBox2.MouseClick -= mouseEventHandler;
        this._CheckBox2 = value;
        if (this._CheckBox2 == null)
          return;
        this._CheckBox2.MouseClick += mouseEventHandler;
      }
    }

    internal virtual CheckBox CheckBox1
    {
      get
      {
        return this._CheckBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.CheckBox1_MouseClick);
        if (this._CheckBox1 != null)
          this._CheckBox1.MouseClick -= mouseEventHandler;
        this._CheckBox1 = value;
        if (this._CheckBox1 == null)
          return;
        this._CheckBox1.MouseClick += mouseEventHandler;
      }
    }

    internal virtual RadioButton RadioButton3
    {
      get
      {
        return this._RadioButton3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.RadioButton3_MouseClick);
        if (this._RadioButton3 != null)
          this._RadioButton3.MouseClick -= mouseEventHandler;
        this._RadioButton3 = value;
        if (this._RadioButton3 == null)
          return;
        this._RadioButton3.MouseClick += mouseEventHandler;
      }
    }

    internal virtual RadioButton RadioButton2
    {
      get
      {
        return this._RadioButton2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.RadioButton2_MouseClick);
        if (this._RadioButton2 != null)
          this._RadioButton2.MouseClick -= mouseEventHandler;
        this._RadioButton2 = value;
        if (this._RadioButton2 == null)
          return;
        this._RadioButton2.MouseClick += mouseEventHandler;
      }
    }

    internal virtual RadioButton RadioButton5
    {
      get
      {
        return this._RadioButton5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.RadioButton5_MouseClick);
        if (this._RadioButton5 != null)
          this._RadioButton5.MouseClick -= mouseEventHandler;
        this._RadioButton5 = value;
        if (this._RadioButton5 == null)
          return;
        this._RadioButton5.MouseClick += mouseEventHandler;
      }
    }

    internal virtual RadioButton RadioButton4
    {
      get
      {
        return this._RadioButton4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.RadioButton4_MouseClick);
        if (this._RadioButton4 != null)
          this._RadioButton4.MouseClick -= mouseEventHandler;
        this._RadioButton4 = value;
        if (this._RadioButton4 == null)
          return;
        this._RadioButton4.MouseClick += mouseEventHandler;
      }
    }

    internal virtual RadioButton RadioButton1
    {
      get
      {
        return this._RadioButton1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.RadioButton1_MouseClick);
        EventHandler eventHandler = new EventHandler(this.RadioButton1_CheckedChanged);
        if (this._RadioButton1 != null)
        {
          this._RadioButton1.MouseClick -= mouseEventHandler;
          this._RadioButton1.CheckedChanged -= eventHandler;
        }
        this._RadioButton1 = value;
        if (this._RadioButton1 == null)
          return;
        this._RadioButton1.MouseClick += mouseEventHandler;
        this._RadioButton1.CheckedChanged += eventHandler;
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
        EventHandler eventHandler = new EventHandler(this.PictureBox2_Click);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox2_MouseUp);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox2_MouseDown);
        if (this._PictureBox2 != null)
        {
          this._PictureBox2.Click -= eventHandler;
          this._PictureBox2.MouseUp -= mouseEventHandler1;
          this._PictureBox2.MouseDown -= mouseEventHandler2;
        }
        this._PictureBox2 = value;
        if (this._PictureBox2 == null)
          return;
        this._PictureBox2.Click += eventHandler;
        this._PictureBox2.MouseUp += mouseEventHandler1;
        this._PictureBox2.MouseDown += mouseEventHandler2;
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
        this._Label1 = value;
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
        EventHandler eventHandler = new EventHandler(this.PictureBox3_Click);
        if (this._PictureBox3 != null)
          this._PictureBox3.Click -= eventHandler;
        this._PictureBox3 = value;
        if (this._PictureBox3 == null)
          return;
        this._PictureBox3.Click += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton6
    {
      get
      {
        return this._RadioButton6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton6 = value;
      }
    }

    internal virtual RadioButton RadioButton7
    {
      get
      {
        return this._RadioButton7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton7 = value;
      }
    }

    internal virtual RadioButton RadioButton8
    {
      get
      {
        return this._RadioButton8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton8 = value;
      }
    }

    internal virtual RadioButton RadioButton9
    {
      get
      {
        return this._RadioButton9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton9 = value;
      }
    }

    internal virtual RadioButton RadioButton10
    {
      get
      {
        return this._RadioButton10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._RadioButton10 = value;
      }
    }

    internal virtual Panel Panel1
    {
      get
      {
        return this._Panel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Panel1 = value;
      }
    }

    public Form2()
    {
      this.MouseDown += new MouseEventHandler(this.Sticky_MouseDown1);
      this.Load += new EventHandler(this.Form2_Load);
      this.Shown += new EventHandler(this.Form2_Shown);
      this.InitializeComponent();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form2));
      this.PictureBox1 = new PictureBox();
      this.TextBox1 = new TextBox();
      this.CheckBox2 = new CheckBox();
      this.CheckBox1 = new CheckBox();
      this.RadioButton3 = new RadioButton();
      this.RadioButton2 = new RadioButton();
      this.RadioButton5 = new RadioButton();
      this.RadioButton4 = new RadioButton();
      this.RadioButton1 = new RadioButton();
      this.PictureBox2 = new PictureBox();
      this.Label1 = new Label();
      this.PictureBox3 = new PictureBox();
      this.RadioButton6 = new RadioButton();
      this.RadioButton7 = new RadioButton();
      this.RadioButton8 = new RadioButton();
      this.RadioButton9 = new RadioButton();
      this.RadioButton10 = new RadioButton();
      this.Panel1 = new Panel();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      this.Panel1.SuspendLayout();
      this.SuspendLayout();
      this.PictureBox1.BackColor = Color.Transparent;
      this.PictureBox1.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.save_0;
      PictureBox pictureBox1_1 = this.PictureBox1;
      Point point1 = new Point(124, 437);
      Point point2 = point1;
      pictureBox1_1.Location = point2;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      Size size1 = new Size(146, 39);
      Size size2 = size1;
      pictureBox1_2.Size = size2;
      this.PictureBox1.TabIndex = 17;
      this.PictureBox1.TabStop = false;
      this.TextBox1.BackColor = Color.Maroon;
      this.TextBox1.BorderStyle = BorderStyle.None;
      this.TextBox1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 177);
      this.TextBox1.ForeColor = SystemColors.Desktop;
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(54, 395);
      Point point3 = point1;
      textBox1_1.Location = point3;
      this.TextBox1.MaxLength = 11;
      this.TextBox1.Multiline = true;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(119, 22);
      Size size3 = size1;
      textBox1_2.Size = size3;
      this.TextBox1.TabIndex = 14;
      this.CheckBox2.AutoSize = true;
      this.CheckBox2.BackColor = Color.Transparent;
      this.CheckBox2.FlatStyle = FlatStyle.Flat;
      CheckBox checkBox2_1 = this.CheckBox2;
      point1 = new Point(203, 350);
      Point point4 = point1;
      checkBox2_1.Location = point4;
      this.CheckBox2.Name = "CheckBox2";
      CheckBox checkBox2_2 = this.CheckBox2;
      size1 = new Size(12, 11);
      Size size4 = size1;
      checkBox2_2.Size = size4;
      this.CheckBox2.TabIndex = 15;
      this.CheckBox2.UseVisualStyleBackColor = false;
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.BackColor = Color.Transparent;
      this.CheckBox1.FlatStyle = FlatStyle.Flat;
      CheckBox checkBox1_1 = this.CheckBox1;
      point1 = new Point(66, 350);
      Point point5 = point1;
      checkBox1_1.Location = point5;
      this.CheckBox1.Name = "CheckBox1";
      CheckBox checkBox1_2 = this.CheckBox1;
      size1 = new Size(12, 11);
      Size size5 = size1;
      checkBox1_2.Size = size5;
      this.CheckBox1.TabIndex = 14;
      this.CheckBox1.UseVisualStyleBackColor = false;
      this.RadioButton3.AutoSize = true;
      this.RadioButton3.BackColor = Color.Transparent;
      this.RadioButton3.FlatStyle = FlatStyle.Flat;
      RadioButton radioButton3_1 = this.RadioButton3;
      point1 = new Point(225, 33);
      Point point6 = point1;
      radioButton3_1.Location = point6;
      this.RadioButton3.Name = "RadioButton3";
      RadioButton radioButton3_2 = this.RadioButton3;
      size1 = new Size(13, 12);
      Size size6 = size1;
      radioButton3_2.Size = size6;
      this.RadioButton3.TabIndex = 13;
      this.RadioButton3.TabStop = true;
      this.RadioButton3.UseVisualStyleBackColor = false;
      this.RadioButton2.AutoSize = true;
      this.RadioButton2.BackColor = Color.Transparent;
      this.RadioButton2.FlatStyle = FlatStyle.Flat;
      RadioButton radioButton2_1 = this.RadioButton2;
      point1 = new Point(116, 33);
      Point point7 = point1;
      radioButton2_1.Location = point7;
      this.RadioButton2.Name = "RadioButton2";
      RadioButton radioButton2_2 = this.RadioButton2;
      size1 = new Size(13, 12);
      Size size7 = size1;
      radioButton2_2.Size = size7;
      this.RadioButton2.TabIndex = 12;
      this.RadioButton2.TabStop = true;
      this.RadioButton2.UseVisualStyleBackColor = false;
      this.RadioButton5.AutoSize = true;
      this.RadioButton5.BackColor = Color.Transparent;
      this.RadioButton5.FlatStyle = FlatStyle.Flat;
      RadioButton radioButton5_1 = this.RadioButton5;
      point1 = new Point(231, 280);
      Point point8 = point1;
      radioButton5_1.Location = point8;
      this.RadioButton5.Name = "RadioButton5";
      RadioButton radioButton5_2 = this.RadioButton5;
      size1 = new Size(13, 12);
      Size size8 = size1;
      radioButton5_2.Size = size8;
      this.RadioButton5.TabIndex = 5;
      this.RadioButton5.TabStop = true;
      this.RadioButton5.UseVisualStyleBackColor = false;
      this.RadioButton4.AutoSize = true;
      this.RadioButton4.BackColor = Color.Transparent;
      this.RadioButton4.FlatStyle = FlatStyle.Flat;
      RadioButton radioButton4_1 = this.RadioButton4;
      point1 = new Point(76, 281);
      Point point9 = point1;
      radioButton4_1.Location = point9;
      this.RadioButton4.Name = "RadioButton4";
      RadioButton radioButton4_2 = this.RadioButton4;
      size1 = new Size(13, 12);
      Size size9 = size1;
      radioButton4_2.Size = size9;
      this.RadioButton4.TabIndex = 4;
      this.RadioButton4.TabStop = true;
      this.RadioButton4.UseVisualStyleBackColor = false;
      this.RadioButton1.AutoSize = true;
      this.RadioButton1.BackColor = Color.Transparent;
      this.RadioButton1.FlatStyle = FlatStyle.Flat;
      RadioButton radioButton1_1 = this.RadioButton1;
      point1 = new Point(8, 33);
      Point point10 = point1;
      radioButton1_1.Location = point10;
      this.RadioButton1.Name = "RadioButton1";
      RadioButton radioButton1_2 = this.RadioButton1;
      size1 = new Size(13, 12);
      Size size10 = size1;
      radioButton1_2.Size = size10;
      this.RadioButton1.TabIndex = 11;
      this.RadioButton1.TabStop = true;
      this.RadioButton1.UseVisualStyleBackColor = false;
      this.PictureBox2.BackColor = Color.Transparent;
      this.PictureBox2.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.close;
      PictureBox pictureBox2_1 = this.PictureBox2;
      point1 = new Point(347, 68);
      Point point11 = point1;
      pictureBox2_1.Location = point11;
      this.PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = this.PictureBox2;
      size1 = new Size(27, 27);
      Size size11 = size1;
      pictureBox2_2.Size = size11;
      this.PictureBox2.TabIndex = 26;
      this.PictureBox2.TabStop = false;
      this.Label1.AutoSize = true;
      this.Label1.BackColor = Color.Transparent;
      this.Label1.ForeColor = Color.Maroon;
      Label label1_1 = this.Label1;
      point1 = new Point(202, 343);
      Point point12 = point1;
      label1_1.Location = point12;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(0, 13);
      Size size12 = size1;
      label1_2.Size = size12;
      this.Label1.TabIndex = 27;
      this.PictureBox3.BackColor = Color.Transparent;
      this.PictureBox3.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.contact;
      PictureBox pictureBox3_1 = this.PictureBox3;
      point1 = new Point(83, 482);
      Point point13 = point1;
      pictureBox3_1.Location = point13;
      this.PictureBox3.Name = "PictureBox3";
      PictureBox pictureBox3_2 = this.PictureBox3;
      size1 = new Size(214, 75);
      Size size13 = size1;
      pictureBox3_2.Size = size13;
      this.PictureBox3.TabIndex = 28;
      this.PictureBox3.TabStop = false;
      this.RadioButton6.AutoSize = true;
      this.RadioButton6.BackColor = Color.Transparent;
      this.RadioButton6.FlatStyle = FlatStyle.Flat;
      RadioButton radioButton6_1 = this.RadioButton6;
      point1 = new Point(8, 55);
      Point point14 = point1;
      radioButton6_1.Location = point14;
      this.RadioButton6.Name = "RadioButton6";
      RadioButton radioButton6_2 = this.RadioButton6;
      size1 = new Size(13, 12);
      Size size14 = size1;
      radioButton6_2.Size = size14;
      this.RadioButton6.TabIndex = 29;
      this.RadioButton6.TabStop = true;
      this.RadioButton6.UseVisualStyleBackColor = false;
      this.RadioButton7.AutoSize = true;
      this.RadioButton7.BackColor = Color.Transparent;
      this.RadioButton7.FlatStyle = FlatStyle.Flat;
      RadioButton radioButton7_1 = this.RadioButton7;
      point1 = new Point(116, 57);
      Point point15 = point1;
      radioButton7_1.Location = point15;
      this.RadioButton7.Name = "RadioButton7";
      RadioButton radioButton7_2 = this.RadioButton7;
      size1 = new Size(13, 12);
      Size size15 = size1;
      radioButton7_2.Size = size15;
      this.RadioButton7.TabIndex = 30;
      this.RadioButton7.TabStop = true;
      this.RadioButton7.UseVisualStyleBackColor = false;
      this.RadioButton8.AutoSize = true;
      this.RadioButton8.BackColor = Color.Transparent;
      this.RadioButton8.FlatStyle = FlatStyle.Flat;
      RadioButton radioButton8_1 = this.RadioButton8;
      point1 = new Point(225, 58);
      Point point16 = point1;
      radioButton8_1.Location = point16;
      this.RadioButton8.Name = "RadioButton8";
      RadioButton radioButton8_2 = this.RadioButton8;
      size1 = new Size(13, 12);
      Size size16 = size1;
      radioButton8_2.Size = size16;
      this.RadioButton8.TabIndex = 31;
      this.RadioButton8.TabStop = true;
      this.RadioButton8.UseVisualStyleBackColor = false;
      this.RadioButton9.AutoSize = true;
      this.RadioButton9.BackColor = Color.Transparent;
      this.RadioButton9.FlatStyle = FlatStyle.Flat;
      RadioButton radioButton9_1 = this.RadioButton9;
      point1 = new Point(40, 99);
      Point point17 = point1;
      radioButton9_1.Location = point17;
      this.RadioButton9.Name = "RadioButton9";
      RadioButton radioButton9_2 = this.RadioButton9;
      size1 = new Size(13, 12);
      Size size17 = size1;
      radioButton9_2.Size = size17;
      this.RadioButton9.TabIndex = 32;
      this.RadioButton9.TabStop = true;
      this.RadioButton9.UseVisualStyleBackColor = false;
      this.RadioButton10.AutoSize = true;
      this.RadioButton10.BackColor = Color.Transparent;
      this.RadioButton10.FlatStyle = FlatStyle.Flat;
      RadioButton radioButton10_1 = this.RadioButton10;
      point1 = new Point(159, 98);
      Point point18 = point1;
      radioButton10_1.Location = point18;
      this.RadioButton10.Name = "RadioButton10";
      RadioButton radioButton10_2 = this.RadioButton10;
      size1 = new Size(13, 12);
      Size size18 = size1;
      radioButton10_2.Size = size18;
      this.RadioButton10.TabIndex = 33;
      this.RadioButton10.TabStop = true;
      this.RadioButton10.UseVisualStyleBackColor = false;
      this.Panel1.BackColor = Color.Transparent;
      this.Panel1.Controls.Add((Control) this.RadioButton10);
      this.Panel1.Controls.Add((Control) this.RadioButton9);
      this.Panel1.Controls.Add((Control) this.RadioButton8);
      this.Panel1.Controls.Add((Control) this.RadioButton7);
      this.Panel1.Controls.Add((Control) this.RadioButton6);
      this.Panel1.Controls.Add((Control) this.RadioButton1);
      this.Panel1.Controls.Add((Control) this.RadioButton3);
      this.Panel1.Controls.Add((Control) this.RadioButton2);
      Panel panel1_1 = this.Panel1;
      point1 = new Point(43, 121);
      Point point19 = point1;
      panel1_1.Location = point19;
      this.Panel1.Name = "Panel1";
      Panel panel1_2 = this.Panel1;
      size1 = new Size(304, 124);
      Size size19 = size1;
      panel1_2.Size = size19;
      this.Panel1.TabIndex = 34;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Lime;
      this.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.option_background;
      size1 = new Size(398, 599);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Panel1);
      this.Controls.Add((Control) this.PictureBox3);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.PictureBox2);
      this.Controls.Add((Control) this.CheckBox1);
      this.Controls.Add((Control) this.RadioButton4);
      this.Controls.Add((Control) this.CheckBox2);
      this.Controls.Add((Control) this.RadioButton5);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.TextBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "Form2";
      this.Opacity = 0.0;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Setting";
      this.TransparencyKey = Color.Lime;
      ((ISupportInitialize) this.PictureBox1).EndInit();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.PictureBox3).EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox1.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.save_0;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      this.Refresh();
      MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ID", (object) this.TextBox1.Text);
      if (this.RadioButton1.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object) 1);
      else if (this.RadioButton2.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object) 2);
      else if (this.RadioButton3.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object) 3);
      else if (this.RadioButton6.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object) 4);
      else if (this.RadioButton7.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object) 5);
      else if (this.RadioButton8.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object) 6);
      else if (this.RadioButton9.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object) 7);
      else if (this.RadioButton10.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object) 8);
      if (this.RadioButton4.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ColorDepth", (object) 0);
      else if (this.RadioButton5.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ColorDepth", (object) 1);
      if (this.CheckBox1.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "SoundOnOff", (object) 1);
      else
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "SoundOnOff", (object) 0);
      if (this.CheckBox2.Checked)
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "MusicOnOff", (object) 1);
      else
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "MusicOnOff", (object) 0);
      this.Close();
    }

    private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox1.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.save_1;
    }

    private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox1.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.save_0;
    }

    private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox2.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.close_1;
    }

    private void PictureBox2_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.PictureBox2.BackgroundImage = (Image) UpdateSoftware.My.Resources.Resources.close;
    }

    private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      this.Close();
    }

    private void PictureBox3_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
      this.Close();
    }

    private void Sticky_MouseDown1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Capture = false;
      Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
      this.WndProc(ref m);
    }

    private void Form2_Shown(object sender, EventArgs e)
    {
      this.TextBox1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ID", (object) ""));
      string string1 = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object) ""));
      string string2 = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ColorDepth", (object) ""));
      string string3 = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "SoundOnOff", (object) ""));
      string string4 = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "MusicOnOff", (object) ""));
      Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "LangType", (object) ""));
      string Left1 = string1;
      if (Operators.CompareString(Left1, "1", false) == 0)
        this.RadioButton1.Checked = true;
      else if (Operators.CompareString(Left1, "2", false) == 0)
        this.RadioButton2.Checked = true;
      else if (Operators.CompareString(Left1, "3", false) == 0)
        this.RadioButton3.Checked = true;
      else if (Operators.CompareString(Left1, "4", false) == 0)
        this.RadioButton6.Checked = true;
      else if (Operators.CompareString(Left1, "5", false) == 0)
        this.RadioButton7.Checked = true;
      else if (Operators.CompareString(Left1, "6", false) == 0)
        this.RadioButton8.Checked = true;
      else if (Operators.CompareString(Left1, "7", false) == 0)
        this.RadioButton9.Checked = true;
      else if (Operators.CompareString(Left1, "8", false) == 0)
      {
        this.RadioButton10.Checked = true;
      }
      else
      {
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object) 2);
        this.RadioButton2.Checked = true;
      }
      string Left2 = string2;
      if (Operators.CompareString(Left2, "0", false) == 0)
        this.RadioButton4.Checked = true;
      else if (Operators.CompareString(Left2, "1", false) == 0)
      {
        this.RadioButton5.Checked = true;
      }
      else
      {
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ColorDepth", (object) 0);
        this.RadioButton4.Checked = true;
      }
      string Left3 = string3;
      if (Operators.CompareString(Left3, "0", false) == 0)
        this.CheckBox1.Checked = false;
      else if (Operators.CompareString(Left3, "1", false) == 0)
      {
        this.CheckBox1.Checked = true;
      }
      else
      {
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "SoundOnOff", (object) 1);
        this.CheckBox1.Checked = true;
      }
      string Left4 = string4;
      if (Operators.CompareString(Left4, "0", false) == 0)
        this.CheckBox2.Checked = false;
      else if (Operators.CompareString(Left4, "1", false) == 0)
      {
        this.CheckBox2.Checked = true;
      }
      else
      {
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "MusicOnOff", (object) 1);
        this.CheckBox2.Checked = true;
      }
      this.Opacity = 100.0;
    }

    private void RadioButton1_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
    }

    private void RadioButton2_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
    }

    private void RadioButton3_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
    }

    private void RadioButton4_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
    }

    private void RadioButton5_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
    }

    private void CheckBox1_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
    }

    private void CheckBox2_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      MyProject.Computer.Audio.Play((Stream) UpdateSoftware.My.Resources.Resources.beep, AudioPlayMode.Background);
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void Form2_Load(object sender, EventArgs e)
    {
    }

    private void PictureBox2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void PictureBox3_Click(object sender, EventArgs e)
    {
      Process.Start("skype:dorcohen12");
    }
  }
}
