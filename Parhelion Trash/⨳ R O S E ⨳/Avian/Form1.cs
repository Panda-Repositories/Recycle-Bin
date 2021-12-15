using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DiscordRpcDemo;
using Parhelion;
using rK3yd3S2CKKLibAqok;
using Siticone.UI.WinForms;
using WeAreDevs_API;
using z61u52aFDimW5J7KSq;

namespace Avian
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000022C6 File Offset: 0x000004C6
		public Form1()
		{
			HcFeVQmjQXhdJTZBvI.nIkcPClzlf6up();
			this.b0J7tos4r = new ExploitAPI();
			this.zVJchBQAQ = null;
			base..ctor();
			this.P84tqQBkq();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000022EB File Offset: 0x000004EB
		private void V7IB03FZy(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000022EB File Offset: 0x000004EB
		private void QaI6EHyLJ(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000022ED File Offset: 0x000004ED
		private void hhQM1AxBZ(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004AF4 File Offset: 0x00002CF4
		private void JK3snb1VO(object sender, EventArgs e)
		{
			this.q3s36jI3H.Navigate(string.Format("file:///{0}Core/WebSyntax/AceEditor.html", AppDomain.CurrentDomain.BaseDirectory));
			this.de1gluJNV = default(DiscordRpc.EventHandlers);
			DiscordRpc.Discord_Initialize("912960686173351946", ref this.de1gluJNV, true, null);
			this.de1gluJNV = default(DiscordRpc.EventHandlers);
			DiscordRpc.Discord_Initialize("912960686173351946", ref this.de1gluJNV, true, null);
			this.OJVH3A9KL.details = "Download Parhelion lvl 7";
			this.OJVH3A9KL.state = "FREE ROBLOX EXPLOIT";
			this.OJVH3A9KL.state = "https://up-to-down.net/321280/parhelion-roblox-hack";
			this.OJVH3A9KL.largeImageKey = "Parhelion";
			DiscordRpc.Discord_UpdatePresence(ref this.OJVH3A9KL);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000022F4 File Offset: 0x000004F4
		private void AQLjGwn09(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000022FD File Offset: 0x000004FD
		private void YGWQ9aBsl(object sender, MouseEventArgs e)
		{
			this.vjD8y8ZCO = true;
			this.W7TFpjDBd = new Point(e.X, e.Y);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004BA8 File Offset: 0x00002DA8
		private void LTSwqt3yY(object sender, MouseEventArgs e)
		{
			if (this.vjD8y8ZCO)
			{
				Point point = base.PointToScreen(e.Location);
				base.Location = new Point(point.X - this.W7TFpjDBd.X, point.Y - this.W7TFpjDBd.Y);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000231D File Offset: 0x0000051D
		private void HieCUx1YI(object sender, MouseEventArgs e)
		{
			this.vjD8y8ZCO = false;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022EB File Offset: 0x000004EB
		private void nZ7e04ZLs(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004BFC File Offset: 0x00002DFC
		private void b3YihUMWn(object sender, EventArgs e)
		{
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000022EB File Offset: 0x000004EB
		private void i3X5PWrfo(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004C18 File Offset: 0x00002E18
		private void XfD2WnE6j(object sender, EventArgs e)
		{
			if (x8Rp74W7sE7I03FZym.x8RWp747s.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string text = File.ReadAllText(x8Rp74W7sE7I03FZym.x8RWp747s.FileName);
					this.q3s36jI3H.Document.InvokeScript("SetText", new object[]
					{
						text
					});
				}
				catch (Exception ex)
				{
					MessageBox.Show("File Error: " + ex.Message);
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002326 File Offset: 0x00000526
		private void iFKYcjTs1(object sender, EventArgs e)
		{
			this.q3s36jI3H.Document.InvokeScript("SetText", new object[]
			{
				""
			});
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004C90 File Offset: 0x00002E90
		private void PtI0Jwm62(object sender, EventArgs e)
		{
			HtmlDocument document = this.q3s36jI3H.Document;
			string scriptName = "GetText";
			object[] array = new string[0];
			object[] args = array;
			object obj = document.InvokeScript(scriptName, args);
			string text = obj.ToString();
			this.b0J7tos4r.SendLuaScript(text);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004CD8 File Offset: 0x00002ED8
		private void dhMd8e5aa(object sender, EventArgs e)
		{
			HtmlDocument document = this.q3s36jI3H.Document;
			string scriptName = "GetText";
			object[] array = new string[0];
			object[] array2 = array;
			object[] array3 = array2;
			object[] args = array3;
			object obj = document.InvokeScript(scriptName, args);
			string text = obj.ToString();
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Lua Script Txt (*.txt)|*.txt|All files (*.*)|*.*";
				saveFileDialog.Title = "Parhelion - SaveFile";
				saveFileDialog.ShowDialog();
				try
				{
					string fileName = saveFileDialog.FileName;
					string text2 = text;
					string[] contents = new string[]
					{
						text2.ToString(),
						""
					};
					File.WriteAllLines(saveFileDialog.FileName, contents);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004DA8 File Offset: 0x00002FA8
		private void HWFVnLDvl(object sender, EventArgs e)
		{
			Messiah messiah = new Messiah();
			messiah.Show();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000234C File Offset: 0x0000054C
		private void ecrDjwip8(object sender, EventArgs e)
		{
			this.b0J7tos4r.LaunchExploit();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004DC4 File Offset: 0x00002FC4
		private void P84tqQBkq()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.RWJoTjtoP = new SiticonePanel();
			this.DNXJV2lHN = new Label();
			this.dWJUK0l52 = new SiticonePanel();
			this.wyKafLI13 = new SiticoneButton();
			this.BHsfHn4Rk = new SiticoneButton();
			this.mHDhWsFJ7 = new SiticoneButton();
			this.uH8pLb8pv = new SiticonePanel();
			this.melk82gIa = new SiticonePanel();
			this.BnUO1Syo7 = new SiticonePanel();
			this.EfYZaIppr = new SiticoneButton();
			this.jw7vxZxaV = new SiticoneButton();
			this.f1UAwycCf = new SiticoneButton();
			this.vPGNdZbF6 = new SiticoneButton();
			this.KH0x7FNO3 = new SiticoneButton();
			this.KZsGvl1Io = new SiticoneButton();
			this.q3s36jI3H = new WebBrowser();
			this.RWJoTjtoP.SuspendLayout();
			base.SuspendLayout();
			this.RWJoTjtoP.BackColor = Color.FromArgb(30, 30, 30);
			this.RWJoTjtoP.Controls.Add(this.DNXJV2lHN);
			this.RWJoTjtoP.Controls.Add(this.dWJUK0l52);
			this.RWJoTjtoP.Controls.Add(this.wyKafLI13);
			this.RWJoTjtoP.Controls.Add(this.BHsfHn4Rk);
			this.RWJoTjtoP.Location = new Point(-13, -87);
			this.RWJoTjtoP.Margin = new Padding(3, 2, 3, 2);
			this.RWJoTjtoP.Name = "siticonePanel1";
			this.RWJoTjtoP.ShadowDecoration.Parent = this.RWJoTjtoP;
			this.RWJoTjtoP.Size = new Size(1027, 114);
			this.RWJoTjtoP.TabIndex = 1;
			this.RWJoTjtoP.Paint += this.V7IB03FZy;
			this.RWJoTjtoP.MouseDown += this.YGWQ9aBsl;
			this.RWJoTjtoP.MouseMove += this.LTSwqt3yY;
			this.RWJoTjtoP.MouseUp += this.HieCUx1YI;
			this.DNXJV2lHN.AutoSize = true;
			this.DNXJV2lHN.Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.DNXJV2lHN.ForeColor = Color.White;
			this.DNXJV2lHN.Location = new Point(14, 90);
			this.DNXJV2lHN.Name = "label1";
			this.DNXJV2lHN.Size = new Size(77, 20);
			this.DNXJV2lHN.TabIndex = 15;
			this.DNXJV2lHN.Text = "Parhelion";
			this.dWJUK0l52.BackColor = Color.FromArgb(30, 30, 30);
			this.dWJUK0l52.Location = new Point(8, 15);
			this.dWJUK0l52.Margin = new Padding(3, 2, 3, 2);
			this.dWJUK0l52.Name = "siticonePanel2";
			this.dWJUK0l52.ShadowDecoration.Parent = this.dWJUK0l52;
			this.dWJUK0l52.Size = new Size(1027, 49);
			this.dWJUK0l52.TabIndex = 2;
			this.wyKafLI13.BorderColor = Color.FromArgb(40, 40, 40);
			this.wyKafLI13.BorderRadius = 3;
			this.wyKafLI13.BorderThickness = 1;
			this.wyKafLI13.CheckedState.Parent = this.wyKafLI13;
			this.wyKafLI13.CustomImages.Parent = this.wyKafLI13;
			this.wyKafLI13.FillColor = Color.FromArgb(30, 30, 30);
			this.wyKafLI13.Font = new Font("Yu Gothic UI Semilight", 19.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.wyKafLI13.ForeColor = Color.White;
			this.wyKafLI13.HoveredState.Parent = this.wyKafLI13;
			this.wyKafLI13.Location = new Point(801, 85);
			this.wyKafLI13.Margin = new Padding(3, 2, 3, 2);
			this.wyKafLI13.Name = "siticoneButton9";
			this.wyKafLI13.ShadowDecoration.Parent = this.wyKafLI13;
			this.wyKafLI13.Size = new Size(59, 26);
			this.wyKafLI13.TabIndex = 14;
			this.wyKafLI13.Text = "-";
			this.wyKafLI13.Click += this.AQLjGwn09;
			this.BHsfHn4Rk.BorderColor = Color.FromArgb(40, 40, 40);
			this.BHsfHn4Rk.BorderRadius = 3;
			this.BHsfHn4Rk.BorderThickness = 1;
			this.BHsfHn4Rk.CheckedState.Parent = this.BHsfHn4Rk;
			this.BHsfHn4Rk.CustomImages.Parent = this.BHsfHn4Rk;
			this.BHsfHn4Rk.FillColor = Color.FromArgb(30, 30, 30);
			this.BHsfHn4Rk.Font = new Font("Trebuchet MS", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.BHsfHn4Rk.ForeColor = Color.White;
			this.BHsfHn4Rk.HoveredState.Parent = this.BHsfHn4Rk;
			this.BHsfHn4Rk.Location = new Point(859, 85);
			this.BHsfHn4Rk.Margin = new Padding(3, 2, 3, 2);
			this.BHsfHn4Rk.Name = "siticoneButton6";
			this.BHsfHn4Rk.ShadowDecoration.Parent = this.BHsfHn4Rk;
			this.BHsfHn4Rk.Size = new Size(59, 26);
			this.BHsfHn4Rk.TabIndex = 13;
			this.BHsfHn4Rk.Text = "X";
			this.BHsfHn4Rk.Click += this.hhQM1AxBZ;
			this.mHDhWsFJ7.BorderColor = Color.FromArgb(40, 40, 40);
			this.mHDhWsFJ7.BorderRadius = 5;
			this.mHDhWsFJ7.BorderThickness = 1;
			this.mHDhWsFJ7.CheckedState.Parent = this.mHDhWsFJ7;
			this.mHDhWsFJ7.CustomImages.Parent = this.mHDhWsFJ7;
			this.mHDhWsFJ7.FillColor = Color.FromArgb(30, 30, 30);
			this.mHDhWsFJ7.Font = new Font("Segoe UI", 9f);
			this.mHDhWsFJ7.ForeColor = Color.White;
			this.mHDhWsFJ7.HoveredState.Parent = this.mHDhWsFJ7;
			this.mHDhWsFJ7.Location = new Point(11, 80);
			this.mHDhWsFJ7.Margin = new Padding(3, 2, 3, 2);
			this.mHDhWsFJ7.Name = "Clear";
			this.mHDhWsFJ7.ShadowDecoration.Parent = this.mHDhWsFJ7;
			this.mHDhWsFJ7.Size = new Size(156, 39);
			this.mHDhWsFJ7.TabIndex = 2;
			this.mHDhWsFJ7.Text = "Clear";
			this.mHDhWsFJ7.TextAlign = HorizontalAlignment.Left;
			this.mHDhWsFJ7.Click += this.iFKYcjTs1;
			this.uH8pLb8pv.BackColor = Color.FromArgb(30, 30, 30);
			this.uH8pLb8pv.Location = new Point(-59, 12);
			this.uH8pLb8pv.Margin = new Padding(3, 2, 3, 2);
			this.uH8pLb8pv.Name = "siticonePanel3";
			this.uH8pLb8pv.ShadowDecoration.Parent = this.uH8pLb8pv;
			this.uH8pLb8pv.Size = new Size(64, 448);
			this.uH8pLb8pv.TabIndex = 10;
			this.melk82gIa.BackColor = Color.FromArgb(30, 30, 30);
			this.melk82gIa.Location = new Point(911, 4);
			this.melk82gIa.Margin = new Padding(3, 2, 3, 2);
			this.melk82gIa.Name = "siticonePanel4";
			this.melk82gIa.ShadowDecoration.Parent = this.melk82gIa;
			this.melk82gIa.Size = new Size(23, 479);
			this.melk82gIa.TabIndex = 11;
			this.BnUO1Syo7.BackColor = Color.FromArgb(30, 30, 30);
			this.BnUO1Syo7.Location = new Point(-24, 436);
			this.BnUO1Syo7.Margin = new Padding(3, 2, 3, 2);
			this.BnUO1Syo7.Name = "siticonePanel5";
			this.BnUO1Syo7.ShadowDecoration.Parent = this.BnUO1Syo7;
			this.BnUO1Syo7.Size = new Size(1027, 62);
			this.BnUO1Syo7.TabIndex = 12;
			this.EfYZaIppr.BorderColor = Color.FromArgb(40, 40, 40);
			this.EfYZaIppr.BorderRadius = 5;
			this.EfYZaIppr.BorderThickness = 1;
			this.EfYZaIppr.CheckedState.Parent = this.EfYZaIppr;
			this.EfYZaIppr.CustomImages.Parent = this.EfYZaIppr;
			this.EfYZaIppr.FillColor = Color.FromArgb(30, 30, 30);
			this.EfYZaIppr.Font = new Font("Segoe UI", 9f);
			this.EfYZaIppr.ForeColor = Color.White;
			this.EfYZaIppr.HoveredState.Parent = this.EfYZaIppr;
			this.EfYZaIppr.Location = new Point(11, 34);
			this.EfYZaIppr.Margin = new Padding(3, 2, 3, 2);
			this.EfYZaIppr.Name = "Execute";
			this.EfYZaIppr.ShadowDecoration.Parent = this.EfYZaIppr;
			this.EfYZaIppr.Size = new Size(156, 39);
			this.EfYZaIppr.TabIndex = 14;
			this.EfYZaIppr.Text = "Execute";
			this.EfYZaIppr.TextAlign = HorizontalAlignment.Left;
			this.EfYZaIppr.Click += this.PtI0Jwm62;
			this.jw7vxZxaV.BorderColor = Color.FromArgb(40, 40, 40);
			this.jw7vxZxaV.BorderRadius = 5;
			this.jw7vxZxaV.BorderThickness = 1;
			this.jw7vxZxaV.CheckedState.Parent = this.jw7vxZxaV;
			this.jw7vxZxaV.CustomImages.Parent = this.jw7vxZxaV;
			this.jw7vxZxaV.FillColor = Color.FromArgb(30, 30, 30);
			this.jw7vxZxaV.Font = new Font("Segoe UI", 9f);
			this.jw7vxZxaV.ForeColor = Color.White;
			this.jw7vxZxaV.HoveredState.Parent = this.jw7vxZxaV;
			this.jw7vxZxaV.Location = new Point(11, 126);
			this.jw7vxZxaV.Margin = new Padding(3, 2, 3, 2);
			this.jw7vxZxaV.Name = "LoadFile";
			this.jw7vxZxaV.ShadowDecoration.Parent = this.jw7vxZxaV;
			this.jw7vxZxaV.Size = new Size(156, 39);
			this.jw7vxZxaV.TabIndex = 15;
			this.jw7vxZxaV.Text = "Open";
			this.jw7vxZxaV.TextAlign = HorizontalAlignment.Left;
			this.jw7vxZxaV.Click += this.XfD2WnE6j;
			this.f1UAwycCf.BorderColor = Color.FromArgb(40, 40, 40);
			this.f1UAwycCf.BorderRadius = 5;
			this.f1UAwycCf.BorderThickness = 1;
			this.f1UAwycCf.CheckedState.Parent = this.f1UAwycCf;
			this.f1UAwycCf.CustomImages.Parent = this.f1UAwycCf;
			this.f1UAwycCf.FillColor = Color.FromArgb(30, 30, 30);
			this.f1UAwycCf.Font = new Font("Segoe UI", 9f);
			this.f1UAwycCf.ForeColor = Color.White;
			this.f1UAwycCf.HoveredState.Parent = this.f1UAwycCf;
			this.f1UAwycCf.Location = new Point(11, 172);
			this.f1UAwycCf.Margin = new Padding(3, 2, 3, 2);
			this.f1UAwycCf.Name = "SaveFile";
			this.f1UAwycCf.ShadowDecoration.Parent = this.f1UAwycCf;
			this.f1UAwycCf.Size = new Size(156, 39);
			this.f1UAwycCf.TabIndex = 16;
			this.f1UAwycCf.Text = "Save";
			this.f1UAwycCf.TextAlign = HorizontalAlignment.Left;
			this.f1UAwycCf.Click += this.dhMd8e5aa;
			this.vPGNdZbF6.BorderColor = Color.FromArgb(40, 40, 40);
			this.vPGNdZbF6.BorderRadius = 5;
			this.vPGNdZbF6.BorderThickness = 1;
			this.vPGNdZbF6.CheckedState.Parent = this.vPGNdZbF6;
			this.vPGNdZbF6.CustomImages.Parent = this.vPGNdZbF6;
			this.vPGNdZbF6.FillColor = Color.FromArgb(30, 30, 30);
			this.vPGNdZbF6.Font = new Font("Segoe UI", 9f);
			this.vPGNdZbF6.ForeColor = Color.White;
			this.vPGNdZbF6.HoveredState.Parent = this.vPGNdZbF6;
			this.vPGNdZbF6.Location = new Point(11, 218);
			this.vPGNdZbF6.Margin = new Padding(3, 2, 3, 2);
			this.vPGNdZbF6.Name = "SHHUB";
			this.vPGNdZbF6.ShadowDecoration.Parent = this.vPGNdZbF6;
			this.vPGNdZbF6.Size = new Size(156, 39);
			this.vPGNdZbF6.TabIndex = 17;
			this.vPGNdZbF6.Text = "ScriptHub";
			this.vPGNdZbF6.TextAlign = HorizontalAlignment.Left;
			this.vPGNdZbF6.Click += this.b3YihUMWn;
			this.KH0x7FNO3.BorderColor = Color.FromArgb(40, 40, 40);
			this.KH0x7FNO3.BorderRadius = 5;
			this.KH0x7FNO3.BorderThickness = 1;
			this.KH0x7FNO3.CheckedState.Parent = this.KH0x7FNO3;
			this.KH0x7FNO3.CustomImages.Parent = this.KH0x7FNO3;
			this.KH0x7FNO3.FillColor = Color.FromArgb(30, 30, 30);
			this.KH0x7FNO3.Font = new Font("Segoe UI", 9f);
			this.KH0x7FNO3.ForeColor = Color.White;
			this.KH0x7FNO3.HoveredState.Parent = this.KH0x7FNO3;
			this.KH0x7FNO3.Location = new Point(12, 345);
			this.KH0x7FNO3.Margin = new Padding(3, 2, 3, 2);
			this.KH0x7FNO3.Name = "Inject";
			this.KH0x7FNO3.ShadowDecoration.Parent = this.KH0x7FNO3;
			this.KH0x7FNO3.Size = new Size(156, 39);
			this.KH0x7FNO3.TabIndex = 19;
			this.KH0x7FNO3.Text = "Attach";
			this.KH0x7FNO3.TextAlign = HorizontalAlignment.Left;
			this.KH0x7FNO3.Click += this.ecrDjwip8;
			this.KZsGvl1Io.BorderColor = Color.FromArgb(40, 40, 40);
			this.KZsGvl1Io.BorderRadius = 5;
			this.KZsGvl1Io.BorderThickness = 1;
			this.KZsGvl1Io.CheckedState.Parent = this.KZsGvl1Io;
			this.KZsGvl1Io.CustomImages.Parent = this.KZsGvl1Io;
			this.KZsGvl1Io.FillColor = Color.FromArgb(30, 30, 30);
			this.KZsGvl1Io.Font = new Font("Segoe UI", 9f);
			this.KZsGvl1Io.ForeColor = Color.White;
			this.KZsGvl1Io.HoveredState.Parent = this.KZsGvl1Io;
			this.KZsGvl1Io.Location = new Point(12, 391);
			this.KZsGvl1Io.Margin = new Padding(3, 2, 3, 2);
			this.KZsGvl1Io.Name = "Sites";
			this.KZsGvl1Io.ShadowDecoration.Parent = this.KZsGvl1Io;
			this.KZsGvl1Io.Size = new Size(156, 39);
			this.KZsGvl1Io.TabIndex = 20;
			this.KZsGvl1Io.Text = "Info";
			this.KZsGvl1Io.TextAlign = HorizontalAlignment.Left;
			this.KZsGvl1Io.Click += this.HWFVnLDvl;
			this.q3s36jI3H.Location = new Point(173, 34);
			this.q3s36jI3H.MinimumSize = new Size(20, 20);
			this.q3s36jI3H.Name = "webBrowser1";
			this.q3s36jI3H.Size = new Size(732, 396);
			this.q3s36jI3H.TabIndex = 22;
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(25, 25, 25);
			base.ClientSize = new Size(917, 443);
			base.Controls.Add(this.q3s36jI3H);
			base.Controls.Add(this.KZsGvl1Io);
			base.Controls.Add(this.KH0x7FNO3);
			base.Controls.Add(this.vPGNdZbF6);
			base.Controls.Add(this.f1UAwycCf);
			base.Controls.Add(this.jw7vxZxaV);
			base.Controls.Add(this.EfYZaIppr);
			base.Controls.Add(this.BnUO1Syo7);
			base.Controls.Add(this.melk82gIa);
			base.Controls.Add(this.uH8pLb8pv);
			base.Controls.Add(this.mHDhWsFJ7);
			base.Controls.Add(this.RWJoTjtoP);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(3, 2, 3, 2);
			base.Name = "Form1";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Parhelion";
			base.TopMost = true;
			base.TransparencyKey = Color.Fuchsia;
			base.Load += this.JK3snb1VO;
			base.Paint += this.i3X5PWrfo;
			this.RWJoTjtoP.ResumeLayout(false);
			this.RWJoTjtoP.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000237F File Offset: 0x0000057F
		internal static bool xnyQtI3BvLX0aiDS3m()
		{
			return Form1.AtVJ057y617qZtBNgv == null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002389 File Offset: 0x00000589
		internal static Form1 ogCeMC2tmdi2IXolJA()
		{
			return Form1.AtVJ057y617qZtBNgv;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002263 File Offset: 0x00000463
		internal static object BcUF5hcr7fCpWKMm0m(int int_0)
		{
			return d81XbNfiFICS4GJsBf.p9BWqnQw8w(int_0);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002390 File Offset: 0x00000590
		static Form1()
		{
			d81XbNfiFICS4GJsBf.mdYWToNnsX();
		}

		// Token: 0x04000004 RID: 4
		private DiscordRpc.EventHandlers de1gluJNV;

		// Token: 0x04000005 RID: 5
		private DiscordRpc.RichPresence OJVH3A9KL;

		// Token: 0x04000006 RID: 6
		private bool vjD8y8ZCO;

		// Token: 0x04000007 RID: 7
		private Point W7TFpjDBd;

		// Token: 0x04000008 RID: 8
		private ExploitAPI b0J7tos4r;

		// Token: 0x0400000A RID: 10
		private SiticonePanel RWJoTjtoP;

		// Token: 0x0400000B RID: 11
		private SiticonePanel dWJUK0l52;

		// Token: 0x0400000C RID: 12
		private SiticoneButton mHDhWsFJ7;

		// Token: 0x0400000D RID: 13
		private SiticonePanel uH8pLb8pv;

		// Token: 0x0400000E RID: 14
		private SiticonePanel melk82gIa;

		// Token: 0x0400000F RID: 15
		private SiticonePanel BnUO1Syo7;

		// Token: 0x04000010 RID: 16
		private SiticoneButton BHsfHn4Rk;

		// Token: 0x04000011 RID: 17
		private SiticoneButton wyKafLI13;

		// Token: 0x04000012 RID: 18
		private SiticoneButton EfYZaIppr;

		// Token: 0x04000013 RID: 19
		private SiticoneButton jw7vxZxaV;

		// Token: 0x04000014 RID: 20
		private SiticoneButton f1UAwycCf;

		// Token: 0x04000015 RID: 21
		private SiticoneButton vPGNdZbF6;

		// Token: 0x04000016 RID: 22
		private SiticoneButton KH0x7FNO3;

		// Token: 0x04000017 RID: 23
		private SiticoneButton KZsGvl1Io;

		// Token: 0x04000018 RID: 24
		private WebBrowser q3s36jI3H;

		// Token: 0x04000019 RID: 25
		private Label DNXJV2lHN;

		// Token: 0x0400001A RID: 26
		private static Form1 AtVJ057y617qZtBNgv;
	}
}
