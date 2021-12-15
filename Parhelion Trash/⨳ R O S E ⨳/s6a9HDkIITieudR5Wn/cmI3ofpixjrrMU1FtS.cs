using System;
using System.Reflection;
using rK3yd3S2CKKLibAqok;
using z61u52aFDimW5J7KSq;

namespace s6a9HDkIITieudR5Wn
{
	// Token: 0x02000010 RID: 16
	internal class cmI3ofpixjrrMU1FtS
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00007A48 File Offset: 0x00005C48
		internal static void mfhcPCll0dVkK(int typemdt)
		{
			Type type = cmI3ofpixjrrMU1FtS.E4sWZyLxnp.ResolveType(33554432 + typemdt);
			foreach (FieldInfo fieldInfo in type.GetFields())
			{
				MethodInfo method = (MethodInfo)cmI3ofpixjrrMU1FtS.E4sWZyLxnp.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000226E File Offset: 0x0000046E
		public cmI3ofpixjrrMU1FtS()
		{
			HcFeVQmjQXhdJTZBvI.nIkcPClzlf6up();
			base..ctor();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000025B6 File Offset: 0x000007B6
		static cmI3ofpixjrrMU1FtS()
		{
			d81XbNfiFICS4GJsBf.mdYWToNnsX();
			HcFeVQmjQXhdJTZBvI.nIkcPClzlf6up();
			cmI3ofpixjrrMU1FtS.E4sWZyLxnp = typeof(cmI3ofpixjrrMU1FtS).Assembly.ManifestModule;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000025DB File Offset: 0x000007DB
		internal static bool MXcPLVql9pqthnZcTXK()
		{
			return cmI3ofpixjrrMU1FtS.nduusVqPcV38K2LQeqU == null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000025E5 File Offset: 0x000007E5
		internal static cmI3ofpixjrrMU1FtS spKLlhqw2DdXB1LVUME()
		{
			return cmI3ofpixjrrMU1FtS.nduusVqPcV38K2LQeqU;
		}

		// Token: 0x04000050 RID: 80
		internal static Module E4sWZyLxnp;

		// Token: 0x04000051 RID: 81
		private static cmI3ofpixjrrMU1FtS nduusVqPcV38K2LQeqU;

		// Token: 0x02000011 RID: 17
		internal sealed class z3cfX6OqZ1KEwxXywl : MulticastDelegate
		{
			// Token: 0x0600007E RID: 126
			public extern z3cfX6OqZ1KEwxXywl(object object_0, IntPtr intptr_0);

			// Token: 0x0600007F RID: 127
			public extern void Invoke(object o);

			// Token: 0x06000080 RID: 128
			public extern IAsyncResult BeginInvoke(object o, AsyncCallback callback, object @object);

			// Token: 0x06000081 RID: 129
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x06000082 RID: 130 RVA: 0x00002390 File Offset: 0x00000590
			static z3cfX6OqZ1KEwxXywl()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}
	}
}
