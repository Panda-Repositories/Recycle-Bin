using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using rK3yd3S2CKKLibAqok;

namespace z61u52aFDimW5J7KSq
{
	// Token: 0x02000012 RID: 18
	internal class d81XbNfiFICS4GJsBf
	{
		// Token: 0x06000083 RID: 131 RVA: 0x000022EB File Offset: 0x000004EB
		private void k9JcPClFnIUFf()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007AB4 File Offset: 0x00005CB4
		internal static byte[] TWkWvTnVfd(byte[] byte_0)
		{
			uint[] array = new uint[16];
			int num = 448 - byte_0.Length * 8 % 512;
			uint num2 = (uint)((num + 512) % 512);
			if (num2 == 0U)
			{
				num2 = 512U;
			}
			uint num3 = (uint)((long)byte_0.Length + (long)((ulong)(num2 / 8U)) + 8L);
			ulong num4 = (ulong)((long)byte_0.Length * 8L);
			byte[] array2 = new byte[num3];
			for (int i = 0; i < byte_0.Length; i++)
			{
				array2[i] = byte_0[i];
			}
			byte[] array3 = array2;
			int num5 = byte_0.Length;
			array3[num5] |= 128;
			for (int j = 8; j > 0; j--)
			{
				array2[(int)(checked((IntPtr)(unchecked((ulong)num3 - (ulong)((long)j)))))] = (byte)(num4 >> (8 - j) * 8 & 255UL);
			}
			uint num6 = (uint)(array2.Length * 8 / 32);
			uint num7 = 1732584193U;
			uint num8 = 4023233417U;
			uint num9 = 2562383102U;
			uint num10 = 271733878U;
			for (uint num11 = 0U; num11 < num6 / 16U; num11 += 1U)
			{
				uint num12 = num11 << 6;
				for (uint num13 = 0U; num13 < 61U; num13 += 4U)
				{
					array[(int)((UIntPtr)(num13 >> 2))] = (uint)((int)array2[(int)((UIntPtr)(num12 + (num13 + 3U)))] << 24 | (int)array2[(int)((UIntPtr)(num12 + (num13 + 2U)))] << 16 | (int)array2[(int)((UIntPtr)(num12 + (num13 + 1U)))] << 8 | (int)array2[(int)((UIntPtr)(num12 + num13))]);
				}
				uint num14 = num7;
				uint num15 = num8;
				uint num16 = num9;
				uint num17 = num10;
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num7, num8, num9, num10, 0U, 7, 1U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num10, num7, num8, num9, 1U, 12, 2U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num9, num10, num7, num8, 2U, 17, 3U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num8, num9, num10, num7, 3U, 22, 4U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num7, num8, num9, num10, 4U, 7, 5U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num10, num7, num8, num9, 5U, 12, 6U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num9, num10, num7, num8, 6U, 17, 7U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num8, num9, num10, num7, 7U, 22, 8U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num7, num8, num9, num10, 8U, 7, 9U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num10, num7, num8, num9, 9U, 12, 10U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num9, num10, num7, num8, 10U, 17, 11U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num8, num9, num10, num7, 11U, 22, 12U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num7, num8, num9, num10, 12U, 7, 13U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num10, num7, num8, num9, 13U, 12, 14U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num9, num10, num7, num8, 14U, 17, 15U, array);
				d81XbNfiFICS4GJsBf.S1HWADRJnG(ref num8, num9, num10, num7, 15U, 22, 16U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num7, num8, num9, num10, 1U, 5, 17U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num10, num7, num8, num9, 6U, 9, 18U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num9, num10, num7, num8, 11U, 14, 19U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num8, num9, num10, num7, 0U, 20, 20U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num7, num8, num9, num10, 5U, 5, 21U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num10, num7, num8, num9, 10U, 9, 22U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num9, num10, num7, num8, 15U, 14, 23U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num8, num9, num10, num7, 4U, 20, 24U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num7, num8, num9, num10, 9U, 5, 25U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num10, num7, num8, num9, 14U, 9, 26U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num9, num10, num7, num8, 3U, 14, 27U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num8, num9, num10, num7, 8U, 20, 28U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num7, num8, num9, num10, 13U, 5, 29U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num10, num7, num8, num9, 2U, 9, 30U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num9, num10, num7, num8, 7U, 14, 31U, array);
				d81XbNfiFICS4GJsBf.nkRWNxpq8O(ref num8, num9, num10, num7, 12U, 20, 32U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num7, num8, num9, num10, 5U, 4, 33U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num10, num7, num8, num9, 8U, 11, 34U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num9, num10, num7, num8, 11U, 16, 35U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num8, num9, num10, num7, 14U, 23, 36U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num7, num8, num9, num10, 1U, 4, 37U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num10, num7, num8, num9, 4U, 11, 38U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num9, num10, num7, num8, 7U, 16, 39U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num8, num9, num10, num7, 10U, 23, 40U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num7, num8, num9, num10, 13U, 4, 41U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num10, num7, num8, num9, 0U, 11, 42U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num9, num10, num7, num8, 3U, 16, 43U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num8, num9, num10, num7, 6U, 23, 44U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num7, num8, num9, num10, 9U, 4, 45U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num10, num7, num8, num9, 12U, 11, 46U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num9, num10, num7, num8, 15U, 16, 47U, array);
				d81XbNfiFICS4GJsBf.qtkWxJ2o56(ref num8, num9, num10, num7, 2U, 23, 48U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num7, num8, num9, num10, 0U, 6, 49U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num10, num7, num8, num9, 7U, 10, 50U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num9, num10, num7, num8, 14U, 15, 51U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num8, num9, num10, num7, 5U, 21, 52U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num7, num8, num9, num10, 12U, 6, 53U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num10, num7, num8, num9, 3U, 10, 54U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num9, num10, num7, num8, 10U, 15, 55U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num8, num9, num10, num7, 1U, 21, 56U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num7, num8, num9, num10, 8U, 6, 57U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num10, num7, num8, num9, 15U, 10, 58U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num9, num10, num7, num8, 6U, 15, 59U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num8, num9, num10, num7, 13U, 21, 60U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num7, num8, num9, num10, 4U, 6, 61U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num10, num7, num8, num9, 11U, 10, 62U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num9, num10, num7, num8, 2U, 15, 63U, array);
				d81XbNfiFICS4GJsBf.FxwWGYHlMt(ref num8, num9, num10, num7, 9U, 21, 64U, array);
				num7 += num14;
				num8 += num15;
				num9 += num16;
				num10 += num17;
			}
			byte[] array4 = new byte[16];
			Array.Copy(BitConverter.GetBytes(num7), 0, array4, 0, 4);
			Array.Copy(BitConverter.GetBytes(num8), 0, array4, 4, 4);
			Array.Copy(BitConverter.GetBytes(num9), 0, array4, 8, 4);
			Array.Copy(BitConverter.GetBytes(num10), 0, array4, 12, 4);
			return array4;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000025EC File Offset: 0x000007EC
		private static void S1HWADRJnG(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
		{
			uint_0 = uint_1 + d81XbNfiFICS4GJsBf.iRsW3niM4r(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[(int)((UIntPtr)uint_4)] + d81XbNfiFICS4GJsBf.Q5TBFIClOu[(int)((UIntPtr)(uint_5 - 1U))], ushort_0);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002617 File Offset: 0x00000817
		private static void nkRWNxpq8O(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
		{
			uint_0 = uint_1 + d81XbNfiFICS4GJsBf.iRsW3niM4r(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[(int)((UIntPtr)uint_4)] + d81XbNfiFICS4GJsBf.Q5TBFIClOu[(int)((UIntPtr)(uint_5 - 1U))], ushort_0);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002642 File Offset: 0x00000842
		private static void qtkWxJ2o56(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
		{
			uint_0 = uint_1 + d81XbNfiFICS4GJsBf.iRsW3niM4r(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[(int)((UIntPtr)uint_4)] + d81XbNfiFICS4GJsBf.Q5TBFIClOu[(int)((UIntPtr)(uint_5 - 1U))], ushort_0);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000266A File Offset: 0x0000086A
		private static void FxwWGYHlMt(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
		{
			uint_0 = uint_1 + d81XbNfiFICS4GJsBf.iRsW3niM4r(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[(int)((UIntPtr)uint_4)] + d81XbNfiFICS4GJsBf.Q5TBFIClOu[(int)((UIntPtr)(uint_5 - 1U))], ushort_0);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002693 File Offset: 0x00000893
		private static uint iRsW3niM4r(uint uint_0, ushort ushort_0)
		{
			return uint_0 >> (int)(32 - ushort_0) | uint_0 << (int)ushort_0;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000026A5 File Offset: 0x000008A5
		internal static bool a9CWJX4ssR()
		{
			if (!d81XbNfiFICS4GJsBf.rgDB7Tw0y3)
			{
				d81XbNfiFICS4GJsBf.FGcWnFeVQj();
				d81XbNfiFICS4GJsBf.rgDB7Tw0y3 = true;
			}
			return d81XbNfiFICS4GJsBf.DoBBcfo2KW;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00008158 File Offset: 0x00006358
		internal static SymmetricAlgorithm u0qWbHSiL9()
		{
			SymmetricAlgorithm result = null;
			if (d81XbNfiFICS4GJsBf.a9CWJX4ssR())
			{
				result = new AesCryptoServiceProvider();
			}
			else
			{
				try
				{
					result = new RijndaelManaged();
				}
				catch
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
			return result;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000081AC File Offset: 0x000063AC
		internal static void FGcWnFeVQj()
		{
			try
			{
				d81XbNfiFICS4GJsBf.DoBBcfo2KW = CryptoConfig.AllowOnlyFipsAlgorithms;
			}
			catch
			{
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000026BE File Offset: 0x000008BE
		internal static byte[] gXhWPdJTZB(byte[] byte_0)
		{
			if (!d81XbNfiFICS4GJsBf.a9CWJX4ssR())
			{
				return new MD5CryptoServiceProvider().ComputeHash(byte_0);
			}
			return d81XbNfiFICS4GJsBf.TWkWvTnVfd(byte_0);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000081D8 File Offset: 0x000063D8
		internal static void DIHW9K3yd3(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
		{
			while (uint_0 > 0U)
			{
				int num = (uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0);
				stream_0.Read(byte_0, 0, num);
				d81XbNfiFICS4GJsBf.lCKWyKLibA(hashAlgorithm_0, byte_0, 0, num);
				uint_0 -= (uint)num;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000026D9 File Offset: 0x000008D9
		internal static void lCKWyKLibA(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
		{
			hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008214 File Offset: 0x00006414
		internal static uint SokWIvVu6e(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
		{
			for (int i = 0; i < int_0; i++)
			{
				binaryReader_0.BaseStream.Position = long_0 + (long)(i * 40 + 8);
				uint num = binaryReader_0.ReadUInt32();
				uint num2 = binaryReader_0.ReadUInt32();
				binaryReader_0.ReadUInt32();
				uint num3 = binaryReader_0.ReadUInt32();
				if (num2 <= uint_0 && uint_0 < num2 + num)
				{
					return num3 + uint_0 - num2;
				}
			}
			return 0U;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00008270 File Offset: 0x00006470
		public static void peEWXiPXKq(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			try
			{
				Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
				if (d81XbNfiFICS4GJsBf.e6wBhoXrur == null)
				{
					lock (d81XbNfiFICS4GJsBf.ImcBpkpw7g)
					{
						Dictionary<int, int> dictionary = new Dictionary<int, int>();
						BinaryReader binaryReader = new BinaryReader(typeof(d81XbNfiFICS4GJsBf).Assembly.GetManifestResourceStream("bdbgKNhBUJ5N5SPvPu.KkDie7mJl9YqQL31gu"));
						binaryReader.BaseStream.Position = 0L;
						byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
						binaryReader.Close();
						if (array.Length > 0)
						{
							int num = array.Length % 4;
							int num2 = array.Length / 4;
							byte[] array2 = new byte[array.Length];
							uint num3 = 0U;
							if (num > 0)
							{
								num2++;
							}
							for (int i = 0; i < num2; i++)
							{
								int num4 = i * 4;
								uint num5 = 255U;
								int num6 = 0;
								uint num7;
								if (i == num2 - 1 && num > 0)
								{
									num7 = 0U;
									for (int j = 0; j < num; j++)
									{
										if (j > 0)
										{
											num7 <<= 8;
										}
										num7 |= (uint)array[array.Length - (1 + j)];
									}
								}
								else
								{
									uint num8 = (uint)num4;
									num7 = (uint)((int)array[(int)((UIntPtr)(num8 + 3U))] << 24 | (int)array[(int)((UIntPtr)(num8 + 2U))] << 16 | (int)array[(int)((UIntPtr)(num8 + 1U))] << 8 | (int)array[(int)((UIntPtr)num8)]);
								}
								num3 = num3;
								num3 += d81XbNfiFICS4GJsBf.HoiWScjqJr(num3);
								if (i == num2 - 1 && num > 0)
								{
									uint num9 = num3 ^ num7;
									for (int k = 0; k < num; k++)
									{
										if (k > 0)
										{
											num5 <<= 8;
											num6 += 8;
										}
										array2[num4 + k] = (byte)((num9 & num5) >> num6);
									}
								}
								else
								{
									uint num10 = num3 ^ num7;
									array2[num4] = (byte)(num10 & 255U);
									array2[num4 + 1] = (byte)((num10 & 65280U) >> 8);
									array2[num4 + 2] = (byte)((num10 & 16711680U) >> 16);
									array2[num4 + 3] = (byte)((num10 & 4278190080U) >> 24);
								}
							}
							array = array2;
							int num11 = array.Length / 8;
							d81XbNfiFICS4GJsBf.BPhFOWbtDop7Kk5Rgn bphFOWbtDop7Kk5Rgn = new d81XbNfiFICS4GJsBf.BPhFOWbtDop7Kk5Rgn(new MemoryStream(array));
							for (int l = 0; l < num11; l++)
							{
								int key = bphFOWbtDop7Kk5Rgn.xuD6W99eMR();
								int value = bphFOWbtDop7Kk5Rgn.xuD6W99eMR();
								dictionary.Add(key, value);
							}
							bphFOWbtDop7Kk5Rgn.euF6BnKgiA();
						}
						d81XbNfiFICS4GJsBf.e6wBhoXrur = dictionary;
					}
				}
				foreach (FieldInfo fieldInfo in typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField))
				{
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = d81XbNfiFICS4GJsBf.e6wBhoXrur[metadataToken];
					bool flag2 = (num12 & 1073741824) > 0;
					num12 &= 1073741823;
					MethodInfo methodInfo = (MethodInfo)typeof(d81XbNfiFICS4GJsBf).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					}
					else
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num13 = parameters.Length + 1;
						Type[] array3 = new Type[num13];
						if (methodInfo.DeclaringType.IsValueType)
						{
							array3[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array3[0] = typeof(object);
						}
						for (int n = 0; n < parameters.Length; n++)
						{
							array3[n + 1] = parameters[n].ParameterType;
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						for (int num14 = 0; num14 < num13; num14++)
						{
							switch (num14)
							{
							case 0:
								ilgenerator.Emit(OpCodes.Ldarg_0);
								break;
							case 1:
								ilgenerator.Emit(OpCodes.Ldarg_1);
								break;
							case 2:
								ilgenerator.Emit(OpCodes.Ldarg_2);
								break;
							case 3:
								ilgenerator.Emit(OpCodes.Ldarg_3);
								break;
							default:
								ilgenerator.Emit(OpCodes.Ldarg_S, num14);
								break;
							}
						}
						ilgenerator.Emit(OpCodes.Tailcall);
						ilgenerator.Emit(flag2 ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						ilgenerator.Emit(OpCodes.Ret);
						fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000026E7 File Offset: 0x000008E7
		private static uint HoiWScjqJr(uint uint_0)
		{
			return 0U;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000022EB File Offset: 0x000004EB
		internal static void VvUW1nAfTs()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000026EA File Offset: 0x000008EA
		[d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO(typeof(d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO.Wb9p95AqPWsxojrcBl<object>[]))]
		internal static string p9BWqnQw8w(int int_0)
		{
			return null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000086E4 File Offset: 0x000068E4
		[d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO(typeof(d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO.Wb9p95AqPWsxojrcBl<object>[]))]
		internal static string qeBWL3v39l(string string_0)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(string_0);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00008714 File Offset: 0x00006914
		internal static uint IQDWKeI3de(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, [MarshalAs(UnmanagedType.U4)] uint uint_0, IntPtr intptr_3, ref uint uint_1)
		{
			IntPtr ptr = intptr_2;
			if (d81XbNfiFICS4GJsBf.uEuBH8JGyY)
			{
				ptr = intptr_1;
			}
			long num;
			if (IntPtr.Size == 4)
			{
				num = (long)Marshal.ReadInt32(ptr, IntPtr.Size * 2);
			}
			else
			{
				num = Marshal.ReadInt64(ptr, IntPtr.Size * 2);
			}
			object obj = d81XbNfiFICS4GJsBf.bvJBmrlPEB[num];
			if (obj == null)
			{
				return d81XbNfiFICS4GJsBf.C2bBJZW9F6(intptr_0, intptr_1, intptr_2, uint_0, intptr_3, ref uint_1);
			}
			d81XbNfiFICS4GJsBf.n3LBJbJhiCCwJgBQAV n3LBJbJhiCCwJgBQAV = (d81XbNfiFICS4GJsBf.n3LBJbJhiCCwJgBQAV)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(n3LBJbJhiCCwJgBQAV.KI0BuZ5usv.Length);
			Marshal.Copy(n3LBJbJhiCCwJgBQAV.KI0BuZ5usv, 0, intPtr, n3LBJbJhiCCwJgBQAV.KI0BuZ5usv.Length);
			if (n3LBJbJhiCCwJgBQAV.E7PBTRko0T)
			{
				intptr_3 = intPtr;
				uint_1 = (uint)n3LBJbJhiCCwJgBQAV.KI0BuZ5usv.Length;
				d81XbNfiFICS4GJsBf.hANBMGpEX3(intptr_3, n3LBJbJhiCCwJgBQAV.KI0BuZ5usv.Length, 64, ref d81XbNfiFICS4GJsBf.lVmBIqPav9);
				return 0U;
			}
			Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(ptr, IntPtr.Size * 3, n3LBJbJhiCCwJgBQAV.KI0BuZ5usv.Length);
			uint result = 0U;
			if (uint_0 == 216669565U && !d81XbNfiFICS4GJsBf.XNCB4FIAcs)
			{
				d81XbNfiFICS4GJsBf.XNCB4FIAcs = true;
			}
			else
			{
				result = d81XbNfiFICS4GJsBf.C2bBJZW9F6(intptr_0, intptr_1, intptr_2, uint_0, intptr_3, ref uint_1);
			}
			return result;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000026ED File Offset: 0x000008ED
		private static int c3eWlbYuJE()
		{
			return 5;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00008840 File Offset: 0x00006A40
		private static void L6qWESWhQP()
		{
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008868 File Offset: 0x00006A68
		private static Delegate fjPWrNx1c3(IntPtr intptr_0, Type type_0)
		{
			return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
			{
				typeof(IntPtr),
				typeof(Type)
			}).Invoke(null, new object[]
			{
				intptr_0,
				type_0
			});
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000022EB File Offset: 0x000004EB
		internal static void mdYWToNnsX()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000088CC File Offset: 0x00006ACC
		internal static object hmSWuCUgPv(object object_0)
		{
			try
			{
				if (File.Exists(((Assembly)object_0).Location))
				{
					return ((Assembly)object_0).Location;
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(((Assembly)object_0).GetName().CodeBase.ToString().Replace("file:///", "")))
				{
					return ((Assembly)object_0).GetName().CodeBase.ToString().Replace("file:///", "");
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(object_0.GetType().GetProperty("Location").GetValue(object_0, new object[0]).ToString()))
				{
					return object_0.GetType().GetProperty("Location").GetValue(object_0, new object[0]).ToString();
				}
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x0600009C RID: 156
		[DllImport("kernel32")]
		public static extern IntPtr LoadLibrary(string string_0);

		// Token: 0x0600009D RID: 157
		[DllImport("kernel32", CharSet = CharSet.Ansi)]
		public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

		// Token: 0x0600009E RID: 158 RVA: 0x000089D8 File Offset: 0x00006BD8
		private static IntPtr SBMBWSB2Vf(IntPtr intptr_0, string string_0, uint uint_0)
		{
			if (d81XbNfiFICS4GJsBf.H7OBScE1A2 == null)
			{
				IntPtr procAddress = d81XbNfiFICS4GJsBf.GetProcAddress(d81XbNfiFICS4GJsBf.umLocehuEC(), "Find ".Trim() + "ResourceA");
				d81XbNfiFICS4GJsBf.H7OBScE1A2 = (d81XbNfiFICS4GJsBf.dyvXRsnjjMNnIFKtlY)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(d81XbNfiFICS4GJsBf.dyvXRsnjjMNnIFKtlY));
			}
			return d81XbNfiFICS4GJsBf.H7OBScE1A2(intptr_0, string_0, uint_0);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008A34 File Offset: 0x00006C34
		private static IntPtr k9JBBijM92(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
		{
			if (d81XbNfiFICS4GJsBf.qCeB1sJ5lT == null)
			{
				IntPtr procAddress = d81XbNfiFICS4GJsBf.GetProcAddress(d81XbNfiFICS4GJsBf.umLocehuEC(), "Virtual ".Trim() + "Alloc");
				d81XbNfiFICS4GJsBf.qCeB1sJ5lT = (d81XbNfiFICS4GJsBf.ehYfPhPvxruQnIM02a)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(d81XbNfiFICS4GJsBf.ehYfPhPvxruQnIM02a));
			}
			return d81XbNfiFICS4GJsBf.qCeB1sJ5lT(intptr_0, uint_0, uint_1, uint_2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00008A90 File Offset: 0x00006C90
		private static int KFAB663pnb(IntPtr intptr_0, IntPtr intptr_1, [In] [Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
		{
			if (d81XbNfiFICS4GJsBf.bduBqULSxa == null)
			{
				IntPtr procAddress = d81XbNfiFICS4GJsBf.GetProcAddress(d81XbNfiFICS4GJsBf.umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
				d81XbNfiFICS4GJsBf.bduBqULSxa = (d81XbNfiFICS4GJsBf.lP7DIr957josiA4syL)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(d81XbNfiFICS4GJsBf.lP7DIr957josiA4syL));
			}
			return d81XbNfiFICS4GJsBf.bduBqULSxa(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00008AF8 File Offset: 0x00006CF8
		private static int hANBMGpEX3(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
		{
			if (d81XbNfiFICS4GJsBf.y4jBLNH8yc == null)
			{
				IntPtr procAddress = d81XbNfiFICS4GJsBf.GetProcAddress(d81XbNfiFICS4GJsBf.umLocehuEC(), "Virtual ".Trim() + "Protect");
				d81XbNfiFICS4GJsBf.y4jBLNH8yc = (d81XbNfiFICS4GJsBf.GnpLWkyTnVfdq1HDRJ)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(d81XbNfiFICS4GJsBf.GnpLWkyTnVfdq1HDRJ));
			}
			return d81XbNfiFICS4GJsBf.y4jBLNH8yc(intptr_0, int_0, int_1, ref int_2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00008B54 File Offset: 0x00006D54
		private static IntPtr QKUBsCPHeO(uint uint_0, int int_0, uint uint_1)
		{
			if (d81XbNfiFICS4GJsBf.gbSBKxhLOx == null)
			{
				IntPtr procAddress = d81XbNfiFICS4GJsBf.GetProcAddress(d81XbNfiFICS4GJsBf.umLocehuEC(), "Open ".Trim() + "Process");
				d81XbNfiFICS4GJsBf.gbSBKxhLOx = (d81XbNfiFICS4GJsBf.KGdkRxIpq8OttkJ2o5)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(d81XbNfiFICS4GJsBf.KGdkRxIpq8OttkJ2o5));
			}
			return d81XbNfiFICS4GJsBf.gbSBKxhLOx(uint_0, int_0, uint_1);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00008BB0 File Offset: 0x00006DB0
		private static int mEaBjuVLTK(IntPtr intptr_0)
		{
			if (d81XbNfiFICS4GJsBf.S6aBliPOMA == null)
			{
				IntPtr procAddress = d81XbNfiFICS4GJsBf.GetProcAddress(d81XbNfiFICS4GJsBf.umLocehuEC(), "Close ".Trim() + "Handle");
				d81XbNfiFICS4GJsBf.S6aBliPOMA = (d81XbNfiFICS4GJsBf.cNxwYHXlMtCRsniM4r)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(d81XbNfiFICS4GJsBf.cNxwYHXlMtCRsniM4r));
			}
			return d81XbNfiFICS4GJsBf.S6aBliPOMA(intptr_0);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000026F0 File Offset: 0x000008F0
		private static IntPtr umLocehuEC()
		{
			if (d81XbNfiFICS4GJsBf.m8vBEWgURN == IntPtr.Zero)
			{
				d81XbNfiFICS4GJsBf.m8vBEWgURN = d81XbNfiFICS4GJsBf.LoadLibrary("kernel ".Trim() + "32.dll");
			}
			return d81XbNfiFICS4GJsBf.m8vBEWgURN;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00008C08 File Offset: 0x00006E08
		[d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO(typeof(d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO.Wb9p95AqPWsxojrcBl<object>[]))]
		private static byte[] SqxBQF7JFR(string string_0)
		{
			byte[] array;
			using (FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				int num = 0;
				long length = fileStream.Length;
				int i = (int)length;
				array = new byte[i];
				while (i > 0)
				{
					int num2 = fileStream.Read(array, num, i);
					num += num2;
					i -= num2;
				}
			}
			return array;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002726 File Offset: 0x00000926
		internal static byte[] J9jBCLqec2(Stream stream_0)
		{
			return ((MemoryStream)stream_0).ToArray();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00008C70 File Offset: 0x00006E70
		[d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO(typeof(d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO.Wb9p95AqPWsxojrcBl<object>[]))]
		private static byte[] CllBe2FwB8(byte[] byte_0)
		{
			Stream stream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = d81XbNfiFICS4GJsBf.u0qWbHSiL9();
			symmetricAlgorithm.Key = new byte[]
			{
				14,
				38,
				189,
				86,
				17,
				139,
				187,
				124,
				215,
				246,
				48,
				133,
				76,
				239,
				173,
				83,
				155,
				115,
				33,
				105,
				65,
				14,
				163,
				170,
				167,
				67,
				98,
				169,
				7,
				174,
				42,
				123
			};
			symmetricAlgorithm.IV = new byte[]
			{
				132,
				152,
				203,
				65,
				199,
				34,
				73,
				129,
				52,
				231,
				92,
				125,
				18,
				6,
				8,
				48
			};
			CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
			byte[] result = d81XbNfiFICS4GJsBf.J9jBCLqec2(stream);
			HcFeVQmjQXhdJTZBvI.nIkcPClzlf6up();
			return result;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000026EA File Offset: 0x000008EA
		private byte[] vVABiUxOqf()
		{
			return null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000026EA File Offset: 0x000008EA
		private byte[] xDkB5EcOJg()
		{
			return null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00008CE8 File Offset: 0x00006EE8
		private byte[] FHqB2AJtSW()
		{
			string text = "{11111-22222-20001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00008D28 File Offset: 0x00006F28
		private byte[] xQaBYeuJoX()
		{
			string text = "{11111-22222-20001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000026EA File Offset: 0x000008EA
		private byte[] EWpB0nF4MC()
		{
			return null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000026EA File Offset: 0x000008EA
		private byte[] rplBd8YtOb()
		{
			return null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00008D68 File Offset: 0x00006F68
		internal byte[] w1kBVc11XW()
		{
			string text = "{11111-22222-40001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00008DA8 File Offset: 0x00006FA8
		internal byte[] l9oBD3D5Dc()
		{
			string text = "{11111-22222-40001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00008DE8 File Offset: 0x00006FE8
		internal byte[] FSQBtGZkQt()
		{
			string text = "{11111-22222-50001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00008E28 File Offset: 0x00007028
		internal byte[] nSJBgmdsTX()
		{
			string text = "{11111-22222-50001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000273B File Offset: 0x0000093B
		internal static object sYK36QgPCCYnm0tc6r(object object_0, object object_1)
		{
			return object_0.GetManifestResourceStream(object_1);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000274A File Offset: 0x0000094A
		internal static object YYovPskynmFhD3Zpjl(object object_0)
		{
			return object_0.KDikMXewCI();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002755 File Offset: 0x00000955
		internal static void uodkUjoCEHOHa3on9k(object object_0, long long_0)
		{
			object_0.Position = long_0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002764 File Offset: 0x00000964
		internal static long SOwNhuMBTKdylI8l7W(object object_0)
		{
			return object_0.Length;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000276F File Offset: 0x0000096F
		internal static object W3TuIk0LuakalZESG1(object object_0, int int_0)
		{
			return object_0.j2hBzIrDYO(int_0);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000277E File Offset: 0x0000097E
		internal static void ScEddNLWSyAfRGLO51(object object_0)
		{
			object_0.euF6BnKgiA();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002789 File Offset: 0x00000989
		internal static void d8SZk7F4LlYwf3fT4U(object object_0)
		{
			Array.Reverse(object_0);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002794 File Offset: 0x00000994
		internal static object VpsbrPIKBJAFyH66jA(object object_0)
		{
			return object_0.GetName();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000279F File Offset: 0x0000099F
		internal static object MmuFCTa8k5FAqAENsc(object object_0)
		{
			return object_0.GetPublicKeyToken();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000027AA File Offset: 0x000009AA
		internal static object bur7UhdxyGavSXhKO3()
		{
			return d81XbNfiFICS4GJsBf.u0qWbHSiL9();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000027B1 File Offset: 0x000009B1
		internal static void kGPWGsENj1VC1AQZy8(object object_0, CipherMode cipherMode_0)
		{
			object_0.Mode = cipherMode_0;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000027C0 File Offset: 0x000009C0
		internal static object jRQyVNcULx7ytarNxp(object object_0, object object_1, object object_2)
		{
			return object_0.CreateDecryptor(object_1, object_2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000027D3 File Offset: 0x000009D3
		internal static object sJfsIMPhn0DFF5kPNI()
		{
			return new MemoryStream();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000027DA File Offset: 0x000009DA
		internal static void Gp3iuytRMpb1dbE7hB(object object_0, object object_1, int int_0, int int_1)
		{
			object_0.Write(object_1, int_0, int_1);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000027F1 File Offset: 0x000009F1
		internal static void YX3amY5vKPi8XxIes0(object object_0)
		{
			object_0.FlushFinalBlock();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000027FC File Offset: 0x000009FC
		internal static object sai2siXb9BViaH0lnF(object object_0)
		{
			return d81XbNfiFICS4GJsBf.J9jBCLqec2(object_0);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002807 File Offset: 0x00000A07
		internal static void pOWHtIQyIcs8f2rAOh(object object_0)
		{
			object_0.Close();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002812 File Offset: 0x00000A12
		internal static int vl4jZsZ2USqH6D4aKJ(object object_0, int int_0)
		{
			return BitConverter.ToInt32(object_0, int_0);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002821 File Offset: 0x00000A21
		internal static void p8uXKHjBxhjHxF9sQU()
		{
			HcFeVQmjQXhdJTZBvI.nIkcPClzlf6up();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002828 File Offset: 0x00000A28
		internal static object RIWQFqA7wyvKCmju54()
		{
			return Encoding.Unicode;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000282F File Offset: 0x00000A2F
		internal static object LUS9xYU8RrfdflGUFM(object object_0, object object_1, int int_0, int int_1)
		{
			return object_0.GetString(object_1, int_0, int_1);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002846 File Offset: 0x00000A46
		internal static bool xN8fci24RZklcbmk2f()
		{
			return null == null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000026EA File Offset: 0x000008EA
		internal static object lqxdSLJAeYUtmrGHbi()
		{
			return null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000284C File Offset: 0x00000A4C
		internal static IntPtr KQQyX1TGYAuX00epRk(IntPtr intptr_0, int int_0)
		{
			return Marshal.ReadIntPtr(intptr_0, int_0);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000285B File Offset: 0x00000A5B
		internal static int YOy1lfCSGF5uagnGDl(IntPtr intptr_0, int int_0)
		{
			return Marshal.ReadInt32(intptr_0, int_0);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000286A File Offset: 0x00000A6A
		internal static long VLOiH3MVSwldTUJMOG(IntPtr intptr_0, int int_0)
		{
			return Marshal.ReadInt64(intptr_0, int_0);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002879 File Offset: 0x00000A79
		internal static void GTdXuY5h8JZdoQcN3M(IntPtr intptr_0, int int_0, IntPtr intptr_1)
		{
			Marshal.WriteIntPtr(intptr_0, int_0, intptr_1);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000288C File Offset: 0x00000A8C
		internal static void TPHqE7b8hNmxBijpSQ(IntPtr intptr_0, int int_0, int int_1)
		{
			Marshal.WriteInt32(intptr_0, int_0, int_1);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000289F File Offset: 0x00000A9F
		internal static void Rve5ADpS2h1br7GKOH(IntPtr intptr_0, int int_0, long long_0)
		{
			Marshal.WriteInt64(intptr_0, int_0, long_0);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000028B2 File Offset: 0x00000AB2
		internal static IntPtr vFbc0aXKDKqWgUpO73(int int_0)
		{
			return Marshal.AllocCoTaskMem(int_0);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000028BD File Offset: 0x00000ABD
		internal static void j0xTLVaL3fXNvkPOUC(object object_0, int int_0, IntPtr intptr_0, int int_1)
		{
			Marshal.Copy(object_0, int_0, intptr_0, int_1);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000028D4 File Offset: 0x00000AD4
		internal static void QY4DlJYHN2AIMML0vr()
		{
			d81XbNfiFICS4GJsBf.L6qWESWhQP();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000028DB File Offset: 0x00000ADB
		internal static object lwSRqXiVLPM4rIr5iq()
		{
			return Process.GetCurrentProcess();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000028E2 File Offset: 0x00000AE2
		internal static object aKaQPPeI6htkHVW943(object object_0)
		{
			return object_0.MainModule;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000028ED File Offset: 0x00000AED
		internal static IntPtr IPMTISuAQSnYhotVRl(object object_0)
		{
			return object_0.BaseAddress;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000028F8 File Offset: 0x00000AF8
		internal static IntPtr h6W3KmD3F77YlHRoq4(IntPtr intptr_0, object object_0, uint uint_0)
		{
			return d81XbNfiFICS4GJsBf.SBMBWSB2Vf(intptr_0, object_0, uint_0);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000290B File Offset: 0x00000B0B
		internal static bool OpoLMfLIZ9nK1JjHKF(IntPtr intptr_0, IntPtr intptr_1)
		{
			return intptr_0 != intptr_1;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002821 File Offset: 0x00000A21
		internal static void pYBasL1CX4oBcWcbIM()
		{
			HcFeVQmjQXhdJTZBvI.nIkcPClzlf6up();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000291A File Offset: 0x00000B1A
		internal static int fl8DSwFgP6uCQnVxQ1()
		{
			return IntPtr.Size;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002921 File Offset: 0x00000B21
		internal static Type hNuGk1R9u4dPjluCun(object object_0, bool bool_0)
		{
			return Type.GetType(object_0, bool_0);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002930 File Offset: 0x00000B30
		internal static bool nI8F6JfqkOweOycplX(Type type_0, Type type_1)
		{
			return type_0 != type_1;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000293F File Offset: 0x00000B3F
		internal static object C21EmdV1LJM5Gch6F3(object object_0)
		{
			return object_0.Modules;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000294A File Offset: 0x00000B4A
		internal static object By3wFOlstAb7DxUAdg(object object_0)
		{
			return object_0.GetEnumerator();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002955 File Offset: 0x00000B55
		internal static object ih8NrcApJj98Ym7qEm(object object_0)
		{
			return ((IEnumerator)object_0).Current;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002960 File Offset: 0x00000B60
		internal static object CXaiK7qBDpDsa6JHCc(object object_0)
		{
			return object_0.ModuleName;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000296B File Offset: 0x00000B6B
		internal static object CAHXI7xMURr8NmujJY(object object_0)
		{
			return object_0.ToLower();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002976 File Offset: 0x00000B76
		internal static bool P8ydxFHlJwhcYPeUvo(object object_0, object object_1)
		{
			return object_0 == object_1;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002985 File Offset: 0x00000B85
		internal static object f4A4kXvm5NTLnCASUW(object object_0)
		{
			return object_0.FileVersionInfo;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002990 File Offset: 0x00000B90
		internal static int QUtiPPSdx9tuoDpQgK(object object_0)
		{
			return object_0.ProductMajorPart;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000299B File Offset: 0x00000B9B
		internal static int heXVme0ilqjHIDC6HP(object object_0)
		{
			return object_0.ProductMinorPart;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000029A6 File Offset: 0x00000BA6
		internal static int NH36HjQS44laZGwfZ2(object object_0)
		{
			return object_0.ProductBuildPart;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000029B1 File Offset: 0x00000BB1
		internal static int GB0ptpckIXS6MhLP4O(object object_0)
		{
			return object_0.ProductPrivatePart;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000029BC File Offset: 0x00000BBC
		internal static bool BLPDyJIZCjcObNFdxX(object object_0, object object_1)
		{
			return object_0 >= object_1;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000029CB File Offset: 0x00000BCB
		internal static bool gQVHdJZH7UN2ayBuo4(object object_0, object object_1)
		{
			return object_0 < object_1;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000029DA File Offset: 0x00000BDA
		internal static bool LOrWI7sxaPXeOk3IhT(object object_0)
		{
			return ((IEnumerator)object_0).MoveNext();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000029E5 File Offset: 0x00000BE5
		internal static void U2UwLlwJ53EGluay27(object object_0)
		{
			((IDisposable)object_0).Dispose();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000273B File Offset: 0x0000093B
		internal static object XpfH3l4gNWZfFwNUHw(object object_0, object object_1)
		{
			return object_0.GetManifestResourceStream(object_1);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000274A File Offset: 0x0000094A
		internal static object YoHXw5yCGGL9IRRFGG(object object_0)
		{
			return object_0.KDikMXewCI();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002755 File Offset: 0x00000955
		internal static void aBMQ6UOEbcIXqDEe9r(object object_0, long long_0)
		{
			object_0.Position = long_0;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002764 File Offset: 0x00000964
		internal static long Ubg47H6lU2E3SiWQbX(object object_0)
		{
			return object_0.Length;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000276F File Offset: 0x0000096F
		internal static object L5i4nH9yPBD4ooWxkE(object object_0, int int_0)
		{
			return object_0.j2hBzIrDYO(int_0);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002789 File Offset: 0x00000989
		internal static void wg4ixjjnnhuYt6ECXm(object object_0)
		{
			Array.Reverse(object_0);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002794 File Offset: 0x00000994
		internal static object LyhOTUm0kSQOv2kw19(object object_0)
		{
			return object_0.GetName();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000279F File Offset: 0x0000099F
		internal static object UxIJEe3TUhN0bHbE6k(object object_0)
		{
			return object_0.GetPublicKeyToken();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000029F0 File Offset: 0x00000BF0
		internal static void DU7NtAWC2xy37uyPL9(object object_0, int int_0, int int_1)
		{
			Array.Clear(object_0, int_0, int_1);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002A03 File Offset: 0x00000C03
		internal static object KkJKjotQ96QH3M0vIf(object object_0)
		{
			return object_0.GetModules();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002A0E File Offset: 0x00000C0E
		internal static IntPtr j1wLET2ZcFRmGtUXKS(object object_0)
		{
			return Marshal.GetHINSTANCE(object_0);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002A19 File Offset: 0x00000C19
		internal static object OmACCIGJ17gCAcJQlR(object object_0)
		{
			return object_0.Location;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002A24 File Offset: 0x00000C24
		internal static int Wkl0WaNtNWRGbwL9kr(object object_0)
		{
			return object_0.Length;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002A2F File Offset: 0x00000C2F
		internal static int pH7jlegPDnyTvRvaN7(object object_0)
		{
			return object_0.xuD6W99eMR();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000027AA File Offset: 0x000009AA
		internal static object gKMZIFnZL755DZoWIx()
		{
			return d81XbNfiFICS4GJsBf.u0qWbHSiL9();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000027B1 File Offset: 0x000009B1
		internal static void BSyHGwJR3r3Btysgsj(object object_0, CipherMode cipherMode_0)
		{
			object_0.Mode = cipherMode_0;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000027C0 File Offset: 0x000009C0
		internal static object gGUtOGh9ukvE58sOUU(object object_0, object object_1, object object_2)
		{
			return object_0.CreateDecryptor(object_1, object_2);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000027DA File Offset: 0x000009DA
		internal static void PQ4L50EbOflXFW6Wop(object object_0, object object_1, int int_0, int int_1)
		{
			object_0.Write(object_1, int_0, int_1);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000027F1 File Offset: 0x000009F1
		internal static void rYteGwKumLSqHIwJwU(object object_0)
		{
			object_0.FlushFinalBlock();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002A3A File Offset: 0x00000C3A
		internal static object UWIMCnkX26nS69mGNa(object object_0)
		{
			return object_0.ToArray();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002807 File Offset: 0x00000A07
		internal static void L6n6MudPigq3HQgVlv(object object_0)
		{
			object_0.Close();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000277E File Offset: 0x0000097E
		internal static void lIJKgRolH7XnrxC1eT(object object_0)
		{
			object_0.euF6BnKgiA();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002A45 File Offset: 0x00000C45
		internal static int Dyxq31P8W5oHkZ9BnI(object object_0)
		{
			return object_0.Id;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002A50 File Offset: 0x00000C50
		internal static IntPtr fWvP5sBqfAKOhsplir(uint uint_0, int int_0, uint uint_1)
		{
			return d81XbNfiFICS4GJsBf.QKUBsCPHeO(uint_0, int_0, uint_1);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002A63 File Offset: 0x00000C63
		internal static object DnIBOGU6nSsiSKD2pr(int int_0)
		{
			return BitConverter.GetBytes(int_0);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002A6E File Offset: 0x00000C6E
		internal static long dlaQ3czkexERFQp6aM(object object_0)
		{
			return object_0.Position;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002A79 File Offset: 0x00000C79
		internal static void ssWcOr78FILUtt5WNMu(IntPtr intptr_0, int int_0)
		{
			Marshal.WriteInt32(intptr_0, int_0);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002A88 File Offset: 0x00000C88
		internal static int XqwsTI77HvhAUHELKJj(IntPtr intptr_0)
		{
			return d81XbNfiFICS4GJsBf.mEaBjuVLTK(intptr_0);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002A93 File Offset: 0x00000C93
		internal static void OoLL6i7rZfVnj0e1UVa(object object_0, object object_1, object object_2)
		{
			object_0.Add(object_1, object_2);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002AA6 File Offset: 0x00000CA6
		internal static Type xKn7qJ7TuWPAibYVQXq(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002AB1 File Offset: 0x00000CB1
		internal static int lo9JSJ7CNIba5IBPP6E(long long_0)
		{
			return Convert.ToInt32(long_0);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002ABC File Offset: 0x00000CBC
		internal static object GZBqbB7M8skjvQ5WlU8()
		{
			return Encoding.UTF8;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002AC3 File Offset: 0x00000CC3
		internal static object KSMVIZ75j4ShW1hjEPe(object object_0, object object_1)
		{
			return object_0.GetString(object_1);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002AD2 File Offset: 0x00000CD2
		internal static bool s5jx9Z7bnVDVyDaqxv5(IntPtr intptr_0, IntPtr intptr_1)
		{
			return intptr_0 == intptr_1;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002AE1 File Offset: 0x00000CE1
		internal static object S4rde57pNgYCpqhTSWp(IntPtr intptr_0, Type type_0)
		{
			return d81XbNfiFICS4GJsBf.fjPWrNx1c3(intptr_0, type_0);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002AF0 File Offset: 0x00000CF0
		internal static IntPtr WLpsen7XWaa9TCew1MG(object object_0)
		{
			return object_0();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002AFB File Offset: 0x00000CFB
		internal static int IunL0f7aweGtrprm5tf(IntPtr intptr_0)
		{
			return Marshal.ReadInt32(intptr_0);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002B06 File Offset: 0x00000D06
		internal static long qKca2D7YSbxZ44CjpkY(IntPtr intptr_0)
		{
			return Marshal.ReadInt64(intptr_0);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002B11 File Offset: 0x00000D11
		internal static IntPtr gHL5AS7iqd7kv2Nd9iZ(object object_0)
		{
			return Marshal.GetFunctionPointerForDelegate(object_0);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002B1C File Offset: 0x00000D1C
		internal static int E4wFuA7ekRwmqIifk9P(object object_0)
		{
			return object_0.ModuleMemorySize;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002B27 File Offset: 0x00000D27
		internal static object zrJeXR7uPaCFbVH7HJJ(object object_0)
		{
			return object_0.EntryPoint;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002B32 File Offset: 0x00000D32
		internal static bool oQ4ivJ7D7cEWsymQ0OO(object object_0, object object_1)
		{
			return object_0 != object_1;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002B41 File Offset: 0x00000D41
		internal static object hCS4p07LtgXlM4XSQZn(object object_0)
		{
			return object_0.Method;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002B4C File Offset: 0x00000D4C
		internal static object EcPyZa71LNul7VCfKNV(Type type_0, object object_0)
		{
			return Delegate.CreateDelegate(type_0, object_0);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002B5B File Offset: 0x00000D5B
		internal static object GBj3dN7FDN6AxmWuODV(object object_0)
		{
			return object_0.GetParameters();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002B66 File Offset: 0x00000D66
		internal static object cvGpk07RMYeO5xL6YUj(object object_0)
		{
			return object_0.ManifestModule;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002B71 File Offset: 0x00000D71
		internal static ModuleHandle QIKuab7fVsCjdHBdBnR(object object_0)
		{
			return object_0.ModuleHandle;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002B7C File Offset: 0x00000D7C
		internal static Type lSskyA7VkbebGuhdDbJ(object object_0)
		{
			return object_0.GetType();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002B87 File Offset: 0x00000D87
		internal static object oO348e7lQvoyZJHEIU4(object object_0, object object_1)
		{
			return object_0.GetValue(object_1);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002B96 File Offset: 0x00000D96
		internal static object jgRG847ALx0JPP2RWEX(long long_0)
		{
			return BitConverter.GetBytes(long_0);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002BA1 File Offset: 0x00000DA1
		internal static void HI4rRW7qGoXqFVAGmBU(object object_0)
		{
			RuntimeHelpers.PrepareDelegate(object_0);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002BAC File Offset: 0x00000DAC
		internal static RuntimeMethodHandle b0QCvy7x4X3b9kvJjeM(object object_0)
		{
			return object_0.MethodHandle;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002BB7 File Offset: 0x00000DB7
		internal static void z0Xlfu7HYSfVAgre9jY(RuntimeMethodHandle runtimeMethodHandle_0)
		{
			RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002BC2 File Offset: 0x00000DC2
		internal static void D3TlEt7vPgUu9DVOb34(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(object_0, runtimeFieldHandle_0);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002BD1 File Offset: 0x00000DD1
		internal static IntPtr gJULM17SoytGIyZk9mI(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
		{
			return d81XbNfiFICS4GJsBf.k9JBBijM92(intptr_0, uint_0, uint_1, uint_2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002BE8 File Offset: 0x00000DE8
		internal static void KYoGkd70QhqKNC1wPPB(IntPtr intptr_0, IntPtr intptr_1)
		{
			Marshal.WriteIntPtr(intptr_0, intptr_1);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002846 File Offset: 0x00000A46
		internal static bool HtdnvL7HvAi0rKP3y3()
		{
			return null == null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000026EA File Offset: 0x000008EA
		internal static object tXsAQArcCwr1r9JTyu()
		{
			return null;
		}

		// Token: 0x04000052 RID: 82
		private static IntPtr pswBfoUfEj;

		// Token: 0x04000053 RID: 83
		private static object V5FBZdTXVb;

		// Token: 0x04000054 RID: 84
		private static long JdbB39xRC0;

		// Token: 0x04000055 RID: 85
		private static IntPtr IH0BXpRhsx;

		// Token: 0x04000056 RID: 86
		private static d81XbNfiFICS4GJsBf.lP7DIr957josiA4syL bduBqULSxa;

		// Token: 0x04000057 RID: 87
		private static d81XbNfiFICS4GJsBf.KGdkRxIpq8OttkJ2o5 gbSBKxhLOx;

		// Token: 0x04000058 RID: 88
		private static IntPtr m8vBEWgURN;

		// Token: 0x04000059 RID: 89
		private static d81XbNfiFICS4GJsBf.dyvXRsnjjMNnIFKtlY H7OBScE1A2;

		// Token: 0x0400005A RID: 90
		[d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO(typeof(d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO.Wb9p95AqPWsxojrcBl<object>[]))]
		private static bool XNCB4FIAcs;

		// Token: 0x0400005B RID: 91
		private static byte[] D4MBOANpwm;

		// Token: 0x0400005C RID: 92
		private static bool rgDB7Tw0y3;

		// Token: 0x0400005D RID: 93
		private static int gW3BPugv7r;

		// Token: 0x0400005E RID: 94
		private static byte[] KkPBoAqeno;

		// Token: 0x0400005F RID: 95
		internal static d81XbNfiFICS4GJsBf.Xn6ieAG1Omt4XCtCt8 tbUBbM8skw;

		// Token: 0x04000060 RID: 96
		private static int lVmBIqPav9;

		// Token: 0x04000061 RID: 97
		internal static Assembly YgdB8ftrKc;

		// Token: 0x04000062 RID: 98
		private static object ImcBpkpw7g;

		// Token: 0x04000063 RID: 99
		private static int HkyBAiTslC;

		// Token: 0x04000064 RID: 100
		private static int wyiBGrjgeW;

		// Token: 0x04000065 RID: 101
		private static d81XbNfiFICS4GJsBf.cNxwYHXlMtCRsniM4r S6aBliPOMA;

		// Token: 0x04000066 RID: 102
		private static long TM7BnKfFHD;

		// Token: 0x04000067 RID: 103
		private static bool uEuBH8JGyY;

		// Token: 0x04000068 RID: 104
		private static d81XbNfiFICS4GJsBf.ehYfPhPvxruQnIM02a qCeB1sJ5lT;

		// Token: 0x04000069 RID: 105
		private static bool y5VB9Z34Gn;

		// Token: 0x0400006A RID: 106
		private static bool UYYByACKve;

		// Token: 0x0400006B RID: 107
		private static IntPtr OAsBa2D8Ua;

		// Token: 0x0400006C RID: 108
		private static bool tupBNvDOUD;

		// Token: 0x0400006D RID: 109
		internal static d81XbNfiFICS4GJsBf.Xn6ieAG1Omt4XCtCt8 C2bBJZW9F6;

		// Token: 0x0400006E RID: 110
		private static byte[] dbOBkHuLHf;

		// Token: 0x0400006F RID: 111
		private static int[] xudBvF70Ia;

		// Token: 0x04000070 RID: 112
		internal static RSACryptoServiceProvider yXTBUniKpv;

		// Token: 0x04000071 RID: 113
		internal static Hashtable bvJBmrlPEB;

		// Token: 0x04000072 RID: 114
		private static bool DoBBcfo2KW;

		// Token: 0x04000073 RID: 115
		private static SortedList JM2BxxZh7i;

		// Token: 0x04000074 RID: 116
		private static uint[] Q5TBFIClOu;

		// Token: 0x04000075 RID: 117
		private static Dictionary<int, int> e6wBhoXrur;

		// Token: 0x04000076 RID: 118
		private static d81XbNfiFICS4GJsBf.GnpLWkyTnVfdq1HDRJ y4jBLNH8yc;

		// Token: 0x02000013 RID: 19
		private sealed class eK2h87Zu7KKJeOYspP : MulticastDelegate
		{
			// Token: 0x06000125 RID: 293
			public extern eK2h87Zu7KKJeOYspP(object object_0, IntPtr intptr_0);

			// Token: 0x06000126 RID: 294
			public extern void Invoke(object o);

			// Token: 0x06000127 RID: 295
			public extern IAsyncResult BeginInvoke(object o, AsyncCallback callback, object @object);

			// Token: 0x06000128 RID: 296
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x06000129 RID: 297 RVA: 0x00002390 File Offset: 0x00000590
			static eK2h87Zu7KKJeOYspP()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x02000014 RID: 20
		internal class mxWYOVvAD6aRHCosQO : Attribute
		{
			// Token: 0x0600012A RID: 298 RVA: 0x00002BF7 File Offset: 0x00000DF7
			[d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO(typeof(d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO.Wb9p95AqPWsxojrcBl<object>[]))]
			public mxWYOVvAD6aRHCosQO(object object_0)
			{
			}

			// Token: 0x0600012B RID: 299 RVA: 0x00002390 File Offset: 0x00000590
			static mxWYOVvAD6aRHCosQO()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}

			// Token: 0x02000015 RID: 21
			internal class Wb9p95AqPWsxojrcBl<Fx5dBXNHW0o6ptCcth>
			{
				// Token: 0x0600012C RID: 300 RVA: 0x0000226E File Offset: 0x0000046E
				public Wb9p95AqPWsxojrcBl()
				{
					HcFeVQmjQXhdJTZBvI.nIkcPClzlf6up();
					base..ctor();
				}

				// Token: 0x0600012D RID: 301 RVA: 0x00002BFF File Offset: 0x00000DFF
				internal static bool thciwu8U4h1Ne1L0lal()
				{
					return d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO.Wb9p95AqPWsxojrcBl<Fx5dBXNHW0o6ptCcth>.kWqycR8AKh2WxevrOwn == null;
				}

				// Token: 0x0600012E RID: 302 RVA: 0x00002C09 File Offset: 0x00000E09
				internal static object trVf6A8qSfFQWqdgRXA()
				{
					return d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO.Wb9p95AqPWsxojrcBl<Fx5dBXNHW0o6ptCcth>.kWqycR8AKh2WxevrOwn;
				}

				// Token: 0x0600012F RID: 303 RVA: 0x00002390 File Offset: 0x00000590
				static Wb9p95AqPWsxojrcBl()
				{
					d81XbNfiFICS4GJsBf.mdYWToNnsX();
				}

				// Token: 0x04000077 RID: 119
				private static object kWqycR8AKh2WxevrOwn;
			}
		}

		// Token: 0x02000016 RID: 22
		internal class bC7yCfxDUc0dOWtvHL
		{
			// Token: 0x06000130 RID: 304 RVA: 0x00008E68 File Offset: 0x00007068
			[d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO(typeof(d81XbNfiFICS4GJsBf.mxWYOVvAD6aRHCosQO.Wb9p95AqPWsxojrcBl<object>[]))]
			internal static string iTKBrNj8B7(string string_0, string string_1)
			{
				byte[] bytes = Encoding.Unicode.GetBytes(string_0);
				byte[] array = bytes;
				byte[] key = new byte[]
				{
					82,
					102,
					104,
					110,
					32,
					77,
					24,
					34,
					118,
					181,
					51,
					17,
					18,
					51,
					12,
					109,
					10,
					32,
					77,
					24,
					34,
					158,
					161,
					41,
					97,
					28,
					118,
					181,
					5,
					25,
					1,
					88
				};
				byte[] iv = d81XbNfiFICS4GJsBf.gXhWPdJTZB(Encoding.Unicode.GetBytes(string_1));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = d81XbNfiFICS4GJsBf.u0qWbHSiL9();
				symmetricAlgorithm.Key = key;
				symmetricAlgorithm.IV = iv;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(memoryStream.ToArray());
			}

			// Token: 0x06000132 RID: 306 RVA: 0x00002390 File Offset: 0x00000590
			static bC7yCfxDUc0dOWtvHL()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x02000017 RID: 23
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal sealed class Xn6ieAG1Omt4XCtCt8 : MulticastDelegate
		{
			// Token: 0x06000133 RID: 307
			public extern Xn6ieAG1Omt4XCtCt8(object object_0, IntPtr intptr_0);

			// Token: 0x06000134 RID: 308
			public extern uint Invoke(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

			// Token: 0x06000135 RID: 309
			public extern IAsyncResult BeginInvoke(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode, AsyncCallback callback, object @object);

			// Token: 0x06000136 RID: 310
			public extern uint EndInvoke(ref uint nativeSizeOfCode, IAsyncResult result);

			// Token: 0x06000137 RID: 311 RVA: 0x00002390 File Offset: 0x00000590
			static Xn6ieAG1Omt4XCtCt8()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x02000018 RID: 24
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private sealed class M7hQFs38AsYVYtfYCO : MulticastDelegate
		{
			// Token: 0x06000138 RID: 312
			public extern M7hQFs38AsYVYtfYCO(object object_0, IntPtr intptr_0);

			// Token: 0x06000139 RID: 313
			public extern IntPtr Invoke();

			// Token: 0x0600013A RID: 314
			public extern IAsyncResult BeginInvoke(AsyncCallback callback, object @object);

			// Token: 0x0600013B RID: 315
			public extern IntPtr EndInvoke(IAsyncResult result);

			// Token: 0x0600013C RID: 316 RVA: 0x00002390 File Offset: 0x00000590
			static M7hQFs38AsYVYtfYCO()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x02000019 RID: 25
		internal struct n3LBJbJhiCCwJgBQAV
		{
			// Token: 0x04000078 RID: 120
			internal bool E7PBTRko0T;

			// Token: 0x04000079 RID: 121
			internal byte[] KI0BuZ5usv;
		}

		// Token: 0x0200001A RID: 26
		internal class BPhFOWbtDop7Kk5Rgn
		{
			// Token: 0x0600013D RID: 317 RVA: 0x00002C10 File Offset: 0x00000E10
			public BPhFOWbtDop7Kk5Rgn(Stream stream_0)
			{
				this.E3b66R8B1c = new BinaryReader(stream_0);
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00002C24 File Offset: 0x00000E24
			internal Stream KDikMXewCI()
			{
				return this.E3b66R8B1c.BaseStream;
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00002C31 File Offset: 0x00000E31
			internal byte[] j2hBzIrDYO(int int_0)
			{
				return this.E3b66R8B1c.ReadBytes(int_0);
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00002C3F File Offset: 0x00000E3F
			internal int Dle6RolSW9(byte[] byte_0, int int_0, int int_1)
			{
				return this.E3b66R8B1c.Read(byte_0, int_0, int_1);
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00002C4F File Offset: 0x00000E4F
			internal int xuD6W99eMR()
			{
				return this.E3b66R8B1c.ReadInt32();
			}

			// Token: 0x06000142 RID: 322 RVA: 0x00002C5C File Offset: 0x00000E5C
			internal void euF6BnKgiA()
			{
				this.E3b66R8B1c.Close();
			}

			// Token: 0x06000143 RID: 323 RVA: 0x00002390 File Offset: 0x00000590
			static BPhFOWbtDop7Kk5Rgn()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}

			// Token: 0x0400007A RID: 122
			private BinaryReader E3b66R8B1c;
		}

		// Token: 0x0200001B RID: 27
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		private sealed class dyvXRsnjjMNnIFKtlY : MulticastDelegate
		{
			// Token: 0x06000144 RID: 324
			public extern dyvXRsnjjMNnIFKtlY(object object_0, IntPtr intptr_0);

			// Token: 0x06000145 RID: 325
			public extern IntPtr Invoke(IntPtr hModule, string lpName, uint lpType);

			// Token: 0x06000146 RID: 326
			public extern IAsyncResult BeginInvoke(IntPtr hModule, string lpName, uint lpType, AsyncCallback callback, object @object);

			// Token: 0x06000147 RID: 327
			public extern IntPtr EndInvoke(IAsyncResult result);

			// Token: 0x06000148 RID: 328 RVA: 0x00002390 File Offset: 0x00000590
			static dyvXRsnjjMNnIFKtlY()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x0200001C RID: 28
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private sealed class ehYfPhPvxruQnIM02a : MulticastDelegate
		{
			// Token: 0x06000149 RID: 329
			public extern ehYfPhPvxruQnIM02a(object object_0, IntPtr intptr_0);

			// Token: 0x0600014A RID: 330
			public extern IntPtr Invoke(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

			// Token: 0x0600014B RID: 331
			public extern IAsyncResult BeginInvoke(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect, AsyncCallback callback, object @object);

			// Token: 0x0600014C RID: 332
			public extern IntPtr EndInvoke(IAsyncResult result);

			// Token: 0x0600014D RID: 333 RVA: 0x00002390 File Offset: 0x00000590
			static ehYfPhPvxruQnIM02a()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x0200001D RID: 29
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private sealed class lP7DIr957josiA4syL : MulticastDelegate
		{
			// Token: 0x0600014E RID: 334
			public extern lP7DIr957josiA4syL(object object_0, IntPtr intptr_0);

			// Token: 0x0600014F RID: 335
			public extern int Invoke(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

			// Token: 0x06000150 RID: 336
			public extern IAsyncResult BeginInvoke(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten, AsyncCallback callback, object @object);

			// Token: 0x06000151 RID: 337
			public extern int EndInvoke(out IntPtr lpNumberOfBytesWritten, IAsyncResult result);

			// Token: 0x06000152 RID: 338 RVA: 0x00002390 File Offset: 0x00000590
			static lP7DIr957josiA4syL()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x0200001E RID: 30
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private sealed class GnpLWkyTnVfdq1HDRJ : MulticastDelegate
		{
			// Token: 0x06000153 RID: 339
			public extern GnpLWkyTnVfdq1HDRJ(object object_0, IntPtr intptr_0);

			// Token: 0x06000154 RID: 340
			public extern int Invoke(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

			// Token: 0x06000155 RID: 341
			public extern IAsyncResult BeginInvoke(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect, AsyncCallback callback, object @object);

			// Token: 0x06000156 RID: 342
			public extern int EndInvoke(ref int lpflOldProtect, IAsyncResult result);

			// Token: 0x06000157 RID: 343 RVA: 0x00002390 File Offset: 0x00000590
			static GnpLWkyTnVfdq1HDRJ()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x0200001F RID: 31
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private sealed class KGdkRxIpq8OttkJ2o5 : MulticastDelegate
		{
			// Token: 0x06000158 RID: 344
			public extern KGdkRxIpq8OttkJ2o5(object object_0, IntPtr intptr_0);

			// Token: 0x06000159 RID: 345
			public extern IntPtr Invoke(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

			// Token: 0x0600015A RID: 346
			public extern IAsyncResult BeginInvoke(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId, AsyncCallback callback, object @object);

			// Token: 0x0600015B RID: 347
			public extern IntPtr EndInvoke(IAsyncResult result);

			// Token: 0x0600015C RID: 348 RVA: 0x00002390 File Offset: 0x00000590
			static KGdkRxIpq8OttkJ2o5()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x02000020 RID: 32
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private sealed class cNxwYHXlMtCRsniM4r : MulticastDelegate
		{
			// Token: 0x0600015D RID: 349
			public extern cNxwYHXlMtCRsniM4r(object object_0, IntPtr intptr_0);

			// Token: 0x0600015E RID: 350
			public extern int Invoke(IntPtr ptr);

			// Token: 0x0600015F RID: 351
			public extern IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object @object);

			// Token: 0x06000160 RID: 352
			public extern int EndInvoke(IAsyncResult result);

			// Token: 0x06000161 RID: 353 RVA: 0x00002390 File Offset: 0x00000590
			static cNxwYHXlMtCRsniM4r()
			{
				d81XbNfiFICS4GJsBf.mdYWToNnsX();
			}
		}

		// Token: 0x02000021 RID: 33
		[Flags]
		private enum a9CX4s4sRc0qHSiL9x
		{

		}
	}
}
