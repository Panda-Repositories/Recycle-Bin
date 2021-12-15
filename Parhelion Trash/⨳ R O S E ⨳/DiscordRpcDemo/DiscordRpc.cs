using System;
using System.Runtime.InteropServices;
using rK3yd3S2CKKLibAqok;
using z61u52aFDimW5J7KSq;

namespace DiscordRpcDemo
{
	// Token: 0x02000009 RID: 9
	public class DiscordRpc
	{
		// Token: 0x06000060 RID: 96
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Discord_Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x06000061 RID: 97
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Discord_RunCallbacks();

		// Token: 0x06000062 RID: 98
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Discord_Shutdown();

		// Token: 0x06000063 RID: 99
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Discord_UpdatePresence(ref DiscordRpc.RichPresence presence);

		// Token: 0x06000064 RID: 100 RVA: 0x0000259E File Offset: 0x0000079E
		internal static void Nr5Wa7josi(string string_0, ref object object_0, bool bool_0, object object_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000226E File Offset: 0x0000046E
		public DiscordRpc()
		{
			HcFeVQmjQXhdJTZBvI.nIkcPClzlf6up();
			base..ctor();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000025A5 File Offset: 0x000007A5
		internal static bool XrT1tEqAn2N5aun7i5y()
		{
			return DiscordRpc.XAJXLZqHnBVJ8AYpNt5 == null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000025AF File Offset: 0x000007AF
		internal static DiscordRpc x1dbItqUfMKpC5ArnXM()
		{
			return DiscordRpc.XAJXLZqHnBVJ8AYpNt5;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002390 File Offset: 0x00000590
		static DiscordRpc()
		{
			d81XbNfiFICS4GJsBf.mdYWToNnsX();
		}

		// Token: 0x0400003D RID: 61
		internal static DiscordRpc XAJXLZqHnBVJ8AYpNt5;

		// Token: 0x0200000A RID: 10
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class DisconnectedCallback : MulticastDelegate
		{
			// Token: 0x06000069 RID: 105
			public extern DisconnectedCallback(object @object, IntPtr method);

			// Token: 0x0600006A RID: 106
			public extern void Invoke(int errorCode, string message);

			// Token: 0x0600006B RID: 107
			public extern IAsyncResult BeginInvoke(int errorCode, string message, AsyncCallback callback, object @object);

			// Token: 0x0600006C RID: 108
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x0600006D RID: 109 RVA: 0x00002390 File Offset: 0x00000590
			static DisconnectedCallback()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x0200000B RID: 11
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class ErrorCallback : MulticastDelegate
		{
			// Token: 0x0600006E RID: 110
			public extern ErrorCallback(object @object, IntPtr method);

			// Token: 0x0600006F RID: 111
			public extern void Invoke(int errorCode, string message);

			// Token: 0x06000070 RID: 112
			public extern IAsyncResult BeginInvoke(int errorCode, string message, AsyncCallback callback, object @object);

			// Token: 0x06000071 RID: 113
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x06000072 RID: 114 RVA: 0x00002390 File Offset: 0x00000590
			static ErrorCallback()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x0200000C RID: 12
		public struct EventHandlers
		{
			// Token: 0x0400003E RID: 62
			public DiscordRpc.ReadyCallback readyCallback;

			// Token: 0x0400003F RID: 63
			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			// Token: 0x04000040 RID: 64
			public DiscordRpc.ErrorCallback errorCallback;
		}

		// Token: 0x0200000D RID: 13
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class ReadyCallback : MulticastDelegate
		{
			// Token: 0x06000073 RID: 115
			public extern ReadyCallback(object @object, IntPtr method);

			// Token: 0x06000074 RID: 116
			public extern void Invoke();

			// Token: 0x06000075 RID: 117
			public extern IAsyncResult BeginInvoke(AsyncCallback callback, object @object);

			// Token: 0x06000076 RID: 118
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x06000077 RID: 119 RVA: 0x00002390 File Offset: 0x00000590
			static ReadyCallback()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x0200000E RID: 14
		[Serializable]
		public struct RichPresence
		{
			// Token: 0x04000041 RID: 65
			public string state;

			// Token: 0x04000042 RID: 66
			public string details;

			// Token: 0x04000043 RID: 67
			public long startTimestamp;

			// Token: 0x04000044 RID: 68
			public long endTimestamp;

			// Token: 0x04000045 RID: 69
			public string largeImageKey;

			// Token: 0x04000046 RID: 70
			public string largeImageText;

			// Token: 0x04000047 RID: 71
			public string smallImageKey;

			// Token: 0x04000048 RID: 72
			public string smallImageText;

			// Token: 0x04000049 RID: 73
			public string partyId;

			// Token: 0x0400004A RID: 74
			public int partySize;

			// Token: 0x0400004B RID: 75
			public int partyMax;

			// Token: 0x0400004C RID: 76
			public string matchSecret;

			// Token: 0x0400004D RID: 77
			public string joinSecret;

			// Token: 0x0400004E RID: 78
			public string spectateSecret;

			// Token: 0x0400004F RID: 79
			public bool instance;
		}
	}
}
