using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using rK3yd3S2CKKLibAqok;
using Siticone.UI.WinForms;
using WeAreDevs_API;
using z61u52aFDimW5J7KSq;

namespace Avian
{
	// Token: 0x02000004 RID: 4
	public partial class ScriptHub : Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002397 File Offset: 0x00000597
		public ScriptHub()
		{
			HcFeVQmjQXhdJTZBvI.nIkcPClzlf6up();
			this.PmMEpjo6m = new ExploitAPI();
			this.b6UrMKAYB = null;
			base..ctor();
			this.qcoL0BWtO();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000023BC File Offset: 0x000005BC
		private void Ea8bpTYZh(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000023C4 File Offset: 0x000005C4
		private void QC7nXsepo(object sender, MouseEventArgs e)
		{
			this.jcvKy6Gci = true;
			this.UnKllSysK = new Point(e.X, e.Y);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00006094 File Offset: 0x00004294
		private void fHSPvtvTK(object sender, MouseEventArgs e)
		{
			if (this.jcvKy6Gci)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this.UnKllSysK.X, point.Y - this.UnKllSysK.Y);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000023E4 File Offset: 0x000005E4
		private void KTi9aue6B(object sender, MouseEventArgs e)
		{
			this.jcvKy6Gci = false;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000022EB File Offset: 0x000004EB
		private void pOFyKwpLA(object sender, EventArgs e)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000023ED File Offset: 0x000005ED
		private void mp5IFFc1u(object sender, EventArgs e)
		{
			this.PmMEpjo6m.SendLuaScript("loadstring(game:HttpGet('https://pastebin.com/raw/TZ4vLzaB'), true)()");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000023FF File Offset: 0x000005FF
		private void FLjXtnAbQ(object sender, EventArgs e)
		{
			this.PmMEpjo6m.SendLuaScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'), true)()");
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002411 File Offset: 0x00000611
		private void Nx04fSPak(object sender, EventArgs e)
		{
			this.PmMEpjo6m.SendLuaScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'), true)()");
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002423 File Offset: 0x00000623
		private void TTJmB2COf(object sender, EventArgs e)
		{
			this.PmMEpjo6m.SendLuaScript("loadstring(game:HttpGet('https://pastebin.com/raw/Caniwq2N'), true)()");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002435 File Offset: 0x00000635
		private void d2BSfl49i(object sender, EventArgs e)
		{
			this.PmMEpjo6m.SendLuaScript("loadstring(game:HttpGet('https://gitlab.com/marsscripts/marsscripts/-/raw/master/CCAimbotV2'), true)()");
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002447 File Offset: 0x00000647
		private void QTh1pkvKZ(object sender, EventArgs e)
		{
			this.PmMEpjo6m.SendLuaScript("loadstring(game:HttpGet('https://pastebin.com/raw/5Aa9DCwG'), true)()");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002459 File Offset: 0x00000659
		private void SM9qpTDpi(object sender, EventArgs e)
		{
			this.PmMEpjo6m.SendLuaScript("loadstring(game:HttpGet('https://pastebin.com/raw/uzQRru6Y'), true)()");
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000060E8 File Offset: 0x000042E8
		private void qcoL0BWtO()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ScriptHub));
			this.huTTOisEL = new SiticoneButton();
			this.XOSuI6mI3 = new SiticoneButton();
			this.wfizxjrrM = new SiticoneButton();
			this.w1FWRtS86a = new SiticoneButton();
			this.LHDWWIITie = new SiticoneButton();
			this.YdRWB5Wnk3 = new SiticoneButton();
			this.vfXW66qZ1K = new SiticoneButton();
			this.VwxWMXywl6 = new Label();
			this.s1XWsbNiFI = new SiticoneButton();
			base.SuspendLayout();
			this.huTTOisEL.BorderColor = Color.FromArgb(40, 40, 40);
			this.huTTOisEL.BorderRadius = 5;
			this.huTTOisEL.BorderThickness = 1;
			this.huTTOisEL.CheckedState.Parent = this.huTTOisEL;
			this.huTTOisEL.CustomImages.Parent = this.huTTOisEL;
			this.huTTOisEL.FillColor = Color.FromArgb(30, 30, 30);
			this.huTTOisEL.Font = new Font("Segoe UI", 9f);
			this.huTTOisEL.ForeColor = Color.White;
			this.huTTOisEL.HoveredState.Parent = this.huTTOisEL;
			this.huTTOisEL.Location = new Point(3, 44);
			this.huTTOisEL.Margin = new Padding(3, 2, 3, 2);
			this.huTTOisEL.Name = "siticoneButton1";
			this.huTTOisEL.ShadowDecoration.Parent = this.huTTOisEL;
			this.huTTOisEL.Size = new Size(218, 30);
			this.huTTOisEL.TabIndex = 15;
			this.huTTOisEL.Text = "DarkDex";
			this.huTTOisEL.TextAlign = HorizontalAlignment.Left;
			this.huTTOisEL.Click += this.mp5IFFc1u;
			this.XOSuI6mI3.BorderColor = Color.FromArgb(40, 40, 40);
			this.XOSuI6mI3.BorderRadius = 5;
			this.XOSuI6mI3.BorderThickness = 1;
			this.XOSuI6mI3.CheckedState.Parent = this.XOSuI6mI3;
			this.XOSuI6mI3.CustomImages.Parent = this.XOSuI6mI3;
			this.XOSuI6mI3.FillColor = Color.FromArgb(30, 30, 30);
			this.XOSuI6mI3.Font = new Font("Segoe UI", 9f);
			this.XOSuI6mI3.ForeColor = Color.White;
			this.XOSuI6mI3.HoveredState.Parent = this.XOSuI6mI3;
			this.XOSuI6mI3.Location = new Point(3, 149);
			this.XOSuI6mI3.Margin = new Padding(3, 2, 3, 2);
			this.XOSuI6mI3.Name = "siticoneButton2";
			this.XOSuI6mI3.ShadowDecoration.Parent = this.XOSuI6mI3;
			this.XOSuI6mI3.Size = new Size(218, 30);
			this.XOSuI6mI3.TabIndex = 16;
			this.XOSuI6mI3.Text = "Reviz Admin";
			this.XOSuI6mI3.TextAlign = HorizontalAlignment.Left;
			this.XOSuI6mI3.Click += this.TTJmB2COf;
			this.wfizxjrrM.BorderColor = Color.FromArgb(40, 40, 40);
			this.wfizxjrrM.BorderRadius = 5;
			this.wfizxjrrM.BorderThickness = 1;
			this.wfizxjrrM.CheckedState.Parent = this.wfizxjrrM;
			this.wfizxjrrM.CustomImages.Parent = this.wfizxjrrM;
			this.wfizxjrrM.FillColor = Color.FromArgb(30, 30, 30);
			this.wfizxjrrM.Font = new Font("Segoe UI", 9f);
			this.wfizxjrrM.ForeColor = Color.White;
			this.wfizxjrrM.HoveredState.Parent = this.wfizxjrrM;
			this.wfizxjrrM.Location = new Point(3, 114);
			this.wfizxjrrM.Margin = new Padding(3, 2, 3, 2);
			this.wfizxjrrM.Name = "siticoneButton3";
			this.wfizxjrrM.ShadowDecoration.Parent = this.wfizxjrrM;
			this.wfizxjrrM.Size = new Size(218, 30);
			this.wfizxjrrM.TabIndex = 17;
			this.wfizxjrrM.Text = "Infinite Yield";
			this.wfizxjrrM.TextAlign = HorizontalAlignment.Left;
			this.wfizxjrrM.Click += this.Nx04fSPak;
			this.w1FWRtS86a.BorderColor = Color.FromArgb(40, 40, 40);
			this.w1FWRtS86a.BorderRadius = 5;
			this.w1FWRtS86a.BorderThickness = 1;
			this.w1FWRtS86a.CheckedState.Parent = this.w1FWRtS86a;
			this.w1FWRtS86a.CustomImages.Parent = this.w1FWRtS86a;
			this.w1FWRtS86a.FillColor = Color.FromArgb(30, 30, 30);
			this.w1FWRtS86a.Font = new Font("Segoe UI", 9f);
			this.w1FWRtS86a.ForeColor = Color.White;
			this.w1FWRtS86a.HoveredState.Parent = this.w1FWRtS86a;
			this.w1FWRtS86a.Location = new Point(3, 79);
			this.w1FWRtS86a.Margin = new Padding(3, 2, 3, 2);
			this.w1FWRtS86a.Name = "siticoneButton4";
			this.w1FWRtS86a.ShadowDecoration.Parent = this.w1FWRtS86a;
			this.w1FWRtS86a.Size = new Size(218, 30);
			this.w1FWRtS86a.TabIndex = 18;
			this.w1FWRtS86a.Text = "OwlHub";
			this.w1FWRtS86a.TextAlign = HorizontalAlignment.Left;
			this.w1FWRtS86a.Click += this.FLjXtnAbQ;
			this.LHDWWIITie.BorderColor = Color.FromArgb(40, 40, 40);
			this.LHDWWIITie.BorderRadius = 5;
			this.LHDWWIITie.BorderThickness = 1;
			this.LHDWWIITie.CheckedState.Parent = this.LHDWWIITie;
			this.LHDWWIITie.CustomImages.Parent = this.LHDWWIITie;
			this.LHDWWIITie.FillColor = Color.FromArgb(30, 30, 30);
			this.LHDWWIITie.Font = new Font("Segoe UI", 9f);
			this.LHDWWIITie.ForeColor = Color.White;
			this.LHDWWIITie.HoveredState.Parent = this.LHDWWIITie;
			this.LHDWWIITie.Location = new Point(3, 185);
			this.LHDWWIITie.Margin = new Padding(3, 2, 3, 2);
			this.LHDWWIITie.Name = "siticoneButton5";
			this.LHDWWIITie.ShadowDecoration.Parent = this.LHDWWIITie;
			this.LHDWWIITie.Size = new Size(218, 30);
			this.LHDWWIITie.TabIndex = 19;
			this.LHDWWIITie.Text = "CC Aimbot";
			this.LHDWWIITie.TextAlign = HorizontalAlignment.Left;
			this.LHDWWIITie.Click += this.d2BSfl49i;
			this.YdRWB5Wnk3.BorderColor = Color.FromArgb(40, 40, 40);
			this.YdRWB5Wnk3.BorderRadius = 5;
			this.YdRWB5Wnk3.BorderThickness = 1;
			this.YdRWB5Wnk3.CheckedState.Parent = this.YdRWB5Wnk3;
			this.YdRWB5Wnk3.CustomImages.Parent = this.YdRWB5Wnk3;
			this.YdRWB5Wnk3.FillColor = Color.FromArgb(30, 30, 30);
			this.YdRWB5Wnk3.Font = new Font("Segoe UI", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.YdRWB5Wnk3.ForeColor = Color.White;
			this.YdRWB5Wnk3.HoveredState.Parent = this.YdRWB5Wnk3;
			this.YdRWB5Wnk3.Location = new Point(3, 219);
			this.YdRWB5Wnk3.Margin = new Padding(3, 2, 3, 2);
			this.YdRWB5Wnk3.Name = "siticoneButton6";
			this.YdRWB5Wnk3.ShadowDecoration.Parent = this.YdRWB5Wnk3;
			this.YdRWB5Wnk3.Size = new Size(217, 30);
			this.YdRWB5Wnk3.TabIndex = 20;
			this.YdRWB5Wnk3.Text = "Phantom Forces Hitbox Extender";
			this.YdRWB5Wnk3.TextAlign = HorizontalAlignment.Left;
			this.YdRWB5Wnk3.Click += this.QTh1pkvKZ;
			this.vfXW66qZ1K.BorderColor = Color.FromArgb(40, 40, 40);
			this.vfXW66qZ1K.BorderRadius = 5;
			this.vfXW66qZ1K.BorderThickness = 1;
			this.vfXW66qZ1K.CheckedState.Parent = this.vfXW66qZ1K;
			this.vfXW66qZ1K.CustomImages.Parent = this.vfXW66qZ1K;
			this.vfXW66qZ1K.FillColor = Color.FromArgb(30, 30, 30);
			this.vfXW66qZ1K.Font = new Font("Segoe UI", 9f);
			this.vfXW66qZ1K.ForeColor = Color.White;
			this.vfXW66qZ1K.HoveredState.Parent = this.vfXW66qZ1K;
			this.vfXW66qZ1K.Location = new Point(11, 342);
			this.vfXW66qZ1K.Margin = new Padding(3, 2, 3, 2);
			this.vfXW66qZ1K.Name = "siticoneButton7";
			this.vfXW66qZ1K.ShadowDecoration.Parent = this.vfXW66qZ1K;
			this.vfXW66qZ1K.Size = new Size(209, 34);
			this.vfXW66qZ1K.TabIndex = 21;
			this.vfXW66qZ1K.Text = "Close";
			this.vfXW66qZ1K.Click += this.Ea8bpTYZh;
			this.VwxWMXywl6.AutoSize = true;
			this.VwxWMXywl6.Font = new Font("Microsoft YaHei UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.VwxWMXywl6.ForeColor = Color.White;
			this.VwxWMXywl6.Location = new Point(0, 0);
			this.VwxWMXywl6.Name = "label1";
			this.VwxWMXywl6.Size = new Size(107, 27);
			this.VwxWMXywl6.TabIndex = 22;
			this.VwxWMXywl6.Text = "ScriptHub";
			this.s1XWsbNiFI.BorderColor = Color.FromArgb(40, 40, 40);
			this.s1XWsbNiFI.BorderRadius = 5;
			this.s1XWsbNiFI.BorderThickness = 1;
			this.s1XWsbNiFI.CheckedState.Parent = this.s1XWsbNiFI;
			this.s1XWsbNiFI.CustomImages.Parent = this.s1XWsbNiFI;
			this.s1XWsbNiFI.FillColor = Color.FromArgb(30, 30, 30);
			this.s1XWsbNiFI.Font = new Font("Segoe UI", 9f);
			this.s1XWsbNiFI.ForeColor = Color.White;
			this.s1XWsbNiFI.HoveredState.Parent = this.s1XWsbNiFI;
			this.s1XWsbNiFI.Location = new Point(3, 253);
			this.s1XWsbNiFI.Margin = new Padding(3, 2, 3, 2);
			this.s1XWsbNiFI.Name = "siticoneButton8";
			this.s1XWsbNiFI.ShadowDecoration.Parent = this.s1XWsbNiFI;
			this.s1XWsbNiFI.Size = new Size(218, 30);
			this.s1XWsbNiFI.TabIndex = 23;
			this.s1XWsbNiFI.Text = "Arsenal Kill All (e)";
			this.s1XWsbNiFI.TextAlign = HorizontalAlignment.Left;
			this.s1XWsbNiFI.Click += this.SM9qpTDpi;
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new Size(233, 381);
			base.Controls.Add(this.s1XWsbNiFI);
			base.Controls.Add(this.VwxWMXywl6);
			base.Controls.Add(this.vfXW66qZ1K);
			base.Controls.Add(this.YdRWB5Wnk3);
			base.Controls.Add(this.LHDWWIITie);
			base.Controls.Add(this.w1FWRtS86a);
			base.Controls.Add(this.wfizxjrrM);
			base.Controls.Add(this.XOSuI6mI3);
			base.Controls.Add(this.huTTOisEL);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(3, 2, 3, 2);
			base.Name = "ScriptHub";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "ScriptHub";
			base.TopMost = true;
			base.Load += this.pOFyKwpLA;
			base.MouseDown += this.QC7nXsepo;
			base.MouseMove += this.fHSPvtvTK;
			base.MouseUp += this.KTi9aue6B;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002490 File Offset: 0x00000690
		internal static bool Xe28P3AfWETUWhZlyVc()
		{
			return ScriptHub.AdroaiAgSXwrQ2AIIYr == null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000249A File Offset: 0x0000069A
		internal static ScriptHub EpSxgXAtv6ZgnVKnkjS()
		{
			return ScriptHub.AdroaiAgSXwrQ2AIIYr;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002263 File Offset: 0x00000463
		internal static object GTmKSNAYt1JadM9KS2T(int int_0)
		{
			return d81XbNfiFICS4GJsBf.p9BWqnQw8w(int_0);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002390 File Offset: 0x00000590
		static ScriptHub()
		{
			d81XbNfiFICS4GJsBf.mdYWToNnsX();
		}

		// Token: 0x0400001B RID: 27
		private bool jcvKy6Gci;

		// Token: 0x0400001C RID: 28
		private Point UnKllSysK;

		// Token: 0x0400001D RID: 29
		private ExploitAPI PmMEpjo6m;

		// Token: 0x0400001F RID: 31
		private SiticoneButton huTTOisEL;

		// Token: 0x04000020 RID: 32
		private SiticoneButton XOSuI6mI3;

		// Token: 0x04000021 RID: 33
		private SiticoneButton wfizxjrrM;

		// Token: 0x04000022 RID: 34
		private SiticoneButton w1FWRtS86a;

		// Token: 0x04000023 RID: 35
		private SiticoneButton LHDWWIITie;

		// Token: 0x04000024 RID: 36
		private SiticoneButton YdRWB5Wnk3;

		// Token: 0x04000025 RID: 37
		private SiticoneButton vfXW66qZ1K;

		// Token: 0x04000026 RID: 38
		private Label VwxWMXywl6;

		// Token: 0x04000027 RID: 39
		private SiticoneButton s1XWsbNiFI;

		// Token: 0x04000028 RID: 40
		private static ScriptHub AdroaiAgSXwrQ2AIIYr;
	}
}
