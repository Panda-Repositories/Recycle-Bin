using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using rK3yd3S2CKKLibAqok;
using z61u52aFDimW5J7KSq;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool IsDebuggerPresent();

	// Token: 0x06000002 RID: 2 RVA: 0x00002C6C File Offset: 0x00000E6C
	public static void CEKQW()
	{
		<Module>.CEKQW();
		short num = 0;
		for (;;)
		{
			Stopwatch stopwatch;
			if (num == 1)
			{
				stopwatch = Stopwatch.StartNew();
				num = 2;
			}
			if (num == 5)
			{
				Application.Exit();
				num = 6;
			}
			if (num != 2)
			{
				goto IL_48;
			}
			if (Debugger.IsAttached)
			{
				num = 3;
				goto IL_48;
			}
			goto IL_88;
			IL_C8:
			if (num == 0)
			{
				num = 1;
			}
			if (num != 9)
			{
				continue;
			}
			break;
			IL_88:
			if (!<Module>.IsDebuggerPresent())
			{
				goto IL_8F;
			}
			num = 5;
			goto IL_C8;
			IL_B6:
			if (num == 7)
			{
				if (stopwatch.ElapsedMilliseconds <= 2500L)
				{
					break;
				}
				num = 8;
			}
			if (num == 8)
			{
				Application.Exit();
				num = 9;
			}
			if (num == 4)
			{
				goto IL_88;
			}
			goto IL_C8;
			IL_8F:
			stopwatch.Stop();
			num = 7;
			goto IL_B6;
			IL_48:
			if (num == 3)
			{
				Application.Exit();
				num = 4;
			}
			if (num == 6)
			{
				goto IL_8F;
			}
			goto IL_B6;
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000223C File Offset: 0x0000043C
	static <Module>()
	{
		d81XbNfiFICS4GJsBf.mdYWToNnsX();
		HcFeVQmjQXhdJTZBvI.nIkcPClzlf6up();
		<Module>.ZETRO();
		<Module>.xEQAW();
	}

	// Token: 0x06000004 RID: 4
	[DllImport("ntdll.dll", CharSet = CharSet.Auto)]
	public static extern int NtQueryInformationProcess(IntPtr intptr_0, int int_0, int[] int_1, int int_2, ref int int_3);

	// Token: 0x06000005 RID: 5 RVA: 0x00002D70 File Offset: 0x00000F70
	private static void xEQAW()
	{
		short num = 0;
		for (;;)
		{
			IntPtr ptr;
			IntPtr intPtr;
			if (num == 30)
			{
				intPtr = Marshal.ReadIntPtr(ptr, 12);
				num = 31;
			}
			if (num == 11)
			{
				goto IL_41D;
			}
			IL_42F:
			if (num != 27)
			{
				goto IL_38;
			}
			if (Marshal.ReadInt32(ptr, 44) == 1572886)
			{
				num = 28;
				goto IL_38;
			}
			goto IL_405;
			IL_209:
			IntPtr intPtr2;
			int[] array;
			int num2;
			if (num == 14)
			{
				if (<Module>.NtQueryInformationProcess(intPtr2, 31, array, 4, ref num2) != 0)
				{
					goto IL_242;
				}
				num = 15;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 34)
			{
				break;
			}
			continue;
			IL_1C4:
			if (num == 31)
			{
				IntPtr intPtr3;
				Marshal.WriteInt32(intPtr, 0, (int)intPtr3);
				num = 32;
			}
			if (num == 9)
			{
				goto IL_1EF;
			}
			goto IL_209;
			IL_1B7:
			if (num != 26)
			{
				goto IL_1C4;
			}
			goto IL_30B;
			IL_35F:
			IntPtr intPtr4;
			if (num == 24)
			{
				intPtr4 = Marshal.ReadIntPtr(intPtr2, 0);
				num = 25;
			}
			if (num == 1)
			{
				if (!Debugger.IsLogging())
				{
					goto IL_292;
				}
				num = 2;
			}
			if (num == 23)
			{
				Marshal.WriteInt32(intPtr2, 32, 0);
				num = 24;
			}
			if (num == 18)
			{
				if (array[0] == 0)
				{
					goto IL_322;
				}
				num = 19;
			}
			if (num == 8)
			{
				Environment.Exit(0);
				num = 9;
			}
			if (num == 29)
			{
				IntPtr intPtr3 = Marshal.ReadIntPtr(ptr, 8);
				num = 30;
			}
			if (num != 22)
			{
				goto IL_1B7;
			}
			goto IL_2DD;
			IL_3F6:
			if (num == 4)
			{
				Environment.Exit(0);
				num = 5;
			}
			if (num == 28)
			{
				if (Marshal.ReadInt32(Marshal.ReadIntPtr(ptr, 48), 0) != 7536749)
				{
					goto IL_405;
				}
				num = 29;
			}
			if (num == 7)
			{
				goto IL_2BD;
			}
			goto IL_35F;
			IL_405:
			if (!ptr.Equals(intPtr4))
			{
				goto IL_30B;
			}
			num = 34;
			goto IL_3F6;
			IL_1EF:
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				num = 10;
				goto IL_209;
			}
			goto IL_41D;
			IL_2BD:
			if (string.Compare(Environment.GetEnvironmentVariable("COR_ENABLE_PROFILING"), "1", StringComparison.Ordinal) != 0)
			{
				goto IL_1EF;
			}
			num = 8;
			goto IL_35F;
			IL_29C:
			if (Environment.GetEnvironmentVariable("complus_profapi_profilercompatibilitysetting") != null)
			{
				num = 6;
				goto IL_2AE;
			}
			goto IL_2BD;
			IL_292:
			if (!Debugger.IsAttached)
			{
				goto IL_29C;
			}
			num = 4;
			goto IL_374;
			IL_262:
			if (num == 10)
			{
				return;
			}
			if (num == 12)
			{
				num2 = 0;
				num = 13;
			}
			if (num == 5)
			{
				goto IL_29C;
			}
			goto IL_2AE;
			IL_242:
			if (<Module>.NtQueryInformationProcess(intPtr2, 30, array, 4, ref num2) == 0)
			{
				num = 18;
				goto IL_262;
			}
			goto IL_322;
			IL_38:
			if (num == 32)
			{
				IntPtr intPtr3;
				Marshal.WriteInt32(intPtr3, 4, (int)intPtr);
				num = 33;
			}
			if (num == 16)
			{
				Environment.Exit(0);
				num = 17;
			}
			if (num == 15)
			{
				if (array[0] == 1)
				{
					goto IL_242;
				}
				num = 16;
			}
			if (num == 21)
			{
				return;
			}
			if (num == 13)
			{
				intPtr2 = Process.GetCurrentProcess().Handle;
				num = 14;
			}
			if (num == 20)
			{
				goto IL_322;
			}
			IL_238:
			if (num == 17)
			{
				goto IL_242;
			}
			goto IL_262;
			IL_322:
			if (<Module>.NtQueryInformationProcess(intPtr2, 0, array, 24, ref num2) != 0)
			{
				num = 21;
				goto IL_238;
			}
			goto IL_2DD;
			IL_30B:
			ptr = Marshal.ReadIntPtr(ptr, 0);
			num = 27;
			goto IL_1C4;
			IL_2DD:
			intPtr2 = Marshal.ReadIntPtr(Marshal.ReadIntPtr((IntPtr)array[1], 12), 12);
			num = 23;
			goto IL_1B7;
			IL_374:
			if (num == 2)
			{
				Environment.Exit(0);
				num = 3;
			}
			if (num == 19)
			{
				Environment.Exit(0);
				num = 20;
			}
			if (num == 6)
			{
				Environment.Exit(0);
				num = 7;
			}
			if (num == 25)
			{
				ptr = intPtr4;
				num = 26;
			}
			if (num == 33)
			{
				goto IL_405;
			}
			goto IL_3F6;
			IL_2AE:
			if (num != 3)
			{
				goto IL_374;
			}
			goto IL_292;
			IL_41D:
			array = new int[6];
			num = 12;
			goto IL_42F;
		}
	}

	// Token: 0x06000006 RID: 6
	[DllImport("kernel32.dll")]
	private static extern IntPtr ZeroMemory(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x06000007 RID: 7
	[DllImport("kernel32.dll")]
	private static extern IntPtr VirtualProtect(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, ref IntPtr intptr_3);

	// Token: 0x06000008 RID: 8
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string string_0);

	// Token: 0x06000009 RID: 9 RVA: 0x00003208 File Offset: 0x00001408
	public static void OIURC()
	{
		short num = 0;
		do
		{
			IntPtr intPtr;
			if (num == 1)
			{
				intPtr = (IntPtr)0;
				num = 2;
			}
			IntPtr moduleHandle;
			if (num == 2)
			{
				moduleHandle = <Module>.GetModuleHandle(null);
				num = 3;
			}
			if (num == 4)
			{
				<Module>.ZeroMemory(moduleHandle, (IntPtr)4096);
				num = 5;
			}
			if (num == 3)
			{
				<Module>.VirtualProtect(moduleHandle, (IntPtr)4096, (IntPtr)4, ref intPtr);
				num = 4;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 5);
	}

	// Token: 0x0600000A RID: 10
	[DllImport("kernel32.dll")]
	private unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, ref uint uint_1);

	// Token: 0x0600000B RID: 11 RVA: 0x000032C4 File Offset: 0x000014C4
	public unsafe static void ZETRO()
	{
		short num = 0;
		for (;;)
		{
			if (num != 108)
			{
				goto IL_0B;
			}
			uint num2;
			uint[] array;
			int num3;
			uint[] array2;
			if (num2 < array[num3] + array2[num3])
			{
				num = 109;
				goto IL_0B;
			}
			goto IL_1681;
			IL_1479:
			byte* ptr;
			if (num == 13)
			{
				if (*(uint*)(ptr - 120) == 0U)
				{
					goto IL_BE9;
				}
				num = 14;
			}
			byte* ptr2;
			if (num == 80)
			{
				ptr2++;
				num = 81;
			}
			byte* ptr3;
			if (num == 202)
			{
				*ptr3 = 0;
				num = 203;
			}
			byte* ptr4;
			if (num == 145)
			{
				*(short*)(ptr4 + (IntPtr)4 * 2) = 108;
				num = 146;
			}
			if (num == 156)
			{
				ptr4[10] = 0;
				num = 157;
			}
			byte* ptr5;
			uint num4;
			if (num == 185)
			{
				ptr3 = ptr5 + num4;
				num = 186;
			}
			if (num == 105)
			{
				num3 = 0;
				num = 106;
			}
			if (num == 24)
			{
				goto IL_4A4;
			}
			if (num == 158)
			{
				goto IL_5AC;
			}
			if (num == 135)
			{
				goto IL_48A;
			}
			if (num == 144)
			{
				*(int*)(ptr4 + 4) = 1818504812;
				num = 145;
			}
			if (num == 30)
			{
				*(int*)(ptr4 + 4) = 1852404846;
				num = 31;
			}
			if (num == 101)
			{
				ptr += 40;
				num = 102;
			}
			if (num == 20)
			{
				*(int*)(ptr4 + 4) = 1818504812;
				num = 21;
			}
			if (num == 193)
			{
				ptr3 += 2;
				num = 194;
			}
			ushort num5;
			if (num == 6)
			{
				num5 = *(ushort*)ptr;
				num = 7;
			}
			byte* ptr6;
			if (num == 17)
			{
				byte* ptr7;
				ptr6 = ptr5 + *(uint*)ptr7 + 2;
				num = 18;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 223)
			{
				break;
			}
			continue;
			IL_1488:
			byte* ptr8;
			uint num6 = *(uint*)ptr8 + 2U;
			num = 134;
			goto IL_1479;
			IL_2F3:
			byte* ptr9;
			uint num7;
			if (num == 114)
			{
				num7 = *(uint*)ptr9;
				num = 115;
			}
			ushort num8;
			if (num == 192)
			{
				num8 = (ushort)(*ptr3);
				num = 193;
			}
			int num9;
			if (num == 137)
			{
				if (num6 >= array[num9] + array2[num9])
				{
					goto IL_1348;
				}
				num = 138;
			}
			if (num == 130)
			{
				goto IL_1488;
			}
			if (num == 106)
			{
				goto IL_F5A;
			}
			if (num == 88)
			{
				return;
			}
			if (num == 209)
			{
				if (*ptr3 != 0)
				{
					goto IL_10E5;
				}
				num = 210;
			}
			if (num == 10)
			{
				ptr4 = stackalloc byte[checked(unchecked((UIntPtr)11) * 1)];
				num = 11;
			}
			if (num == 54)
			{
				ptr2 += *(uint*)ptr2;
				num = 55;
			}
			if (num != 151)
			{
				goto IL_A1C;
			}
			goto IL_A0A;
			IL_14F7:
			int num10;
			if (num10 < (int)num5)
			{
				goto IL_96D;
			}
			num = 170;
			goto IL_2F3;
			IL_13AD:
			if (num == 134)
			{
				num9 = 0;
				num = 135;
			}
			if (num == 56)
			{
				ptr2 += 2;
				num = 57;
			}
			byte* ptr11;
			byte* ptr10;
			if (num == 16)
			{
				ptr10 = ptr5 + *(uint*)(ptr11 + 12);
				num = 17;
			}
			uint[] array3;
			if (num == 109)
			{
				num2 = num2 - array[num3] + array3[num3];
				num = 110;
			}
			if (num == 206)
			{
				goto IL_1427;
			}
			if (num == 90)
			{
				num2 = *(uint*)(ptr - 120);
				num = 91;
			}
			if (num == 58)
			{
				ptr2 += 2;
				num = 59;
			}
			int num11;
			if (num == 160)
			{
				num11++;
				num = 161;
			}
			if (num == 163)
			{
				goto IL_14F7;
			}
			if (num == 93)
			{
				array3 = new uint[(int)num5];
				num = 94;
			}
			if (num == 187)
			{
				*(int*)ptr3 = 0;
				num = 188;
			}
			uint num12;
			if (num == 18)
			{
				<Module>.VirtualProtect(ptr10, 11, 64U, ref num12);
				num = 19;
			}
			int num13;
			if (num == 64)
			{
				num13 = 0;
				num = 65;
			}
			if (num != 111)
			{
				goto IL_166F;
			}
			goto IL_1681;
			IL_1173:
			int num14;
			uint num15;
			if (array[num14] > num15)
			{
				goto IL_117F;
			}
			num = 128;
			goto IL_13AD;
			IL_C68:
			if (num14 >= (int)num5)
			{
				num = 133;
				goto IL_C77;
			}
			goto IL_1173;
			IL_1699:
			if (num == 22)
			{
				ptr4[10] = 0;
				num = 23;
			}
			if (num == 132)
			{
				goto IL_C68;
			}
			goto IL_C77;
			IL_16D9:
			if (num != 107)
			{
				goto IL_1699;
			}
			goto IL_16C8;
			IL_AE9:
			int num16;
			if (num16 < (int)num5)
			{
				goto IL_AF2;
			}
			num = 123;
			goto IL_16D9;
			IL_998:
			byte* ptr12;
			if (num == 47)
			{
				*(int*)ptr12 = 0;
				num = 48;
			}
			Module module;
			if (num == 2)
			{
				ptr5 = (byte*)((void*)Marshal.GetHINSTANCE(module));
				num = 3;
			}
			if (num == 213)
			{
				ptr3++;
				num = 214;
			}
			int num17;
			if (num == 173)
			{
				num17 = 0;
				num = 174;
			}
			if (num == 148)
			{
				goto IL_A0A;
			}
			if (num == 116)
			{
				goto IL_AE9;
			}
			if (num == 51)
			{
				<Module>.VirtualProtect(ptr2, 4, 64U, ref num12);
				num = 52;
			}
			if (num == 157)
			{
				num11 = 0;
				num = 158;
			}
			int num18;
			if (num == 219)
			{
				num18++;
				num = 220;
			}
			if (num == 197)
			{
				ptr3 += 4;
				num = 198;
			}
			if (num == 68)
			{
				ptr2++;
				num = 69;
			}
			if (num != 201)
			{
				goto IL_D83;
			}
			goto IL_D95;
			IL_989:
			int num19;
			if (num19 >= (int)num5)
			{
				num = 45;
				goto IL_998;
			}
			goto IL_DFC;
			IL_83F:
			int num20;
			if (num == 100)
			{
				array3[num20] = *(uint*)(ptr + 20);
				num = 101;
			}
			if (num == 46)
			{
				ptr2 = ptr5 + *(uint*)(ptr12 + 8);
				num = 47;
			}
			if (num == 76)
			{
				goto IL_1559;
			}
			int num21;
			if (num == 23)
			{
				num21 = 0;
				num = 24;
			}
			if (num == 7)
			{
				ptr += 14;
				num = 8;
			}
			if (num == 1)
			{
				module = typeof(<Module>).Module;
				num = 2;
			}
			if (num == 125)
			{
				num14 = 0;
				num = 126;
			}
			if (num == 15)
			{
				byte* ptr7 = ptr5 + *(uint*)ptr11;
				num = 16;
			}
			if (num == 5)
			{
				ptr += 6;
				num = 6;
			}
			if (num == 39)
			{
				goto IL_989;
			}
			if (num == 78)
			{
				ptr2++;
				num = 79;
			}
			if (num == 38)
			{
				goto IL_BE9;
			}
			goto IL_BF6;
			IL_830:
			if (num17 >= (int)num5)
			{
				num = 181;
				goto IL_83F;
			}
			goto IL_F31;
			IL_1593:
			if (num == 176)
			{
				if (num4 >= array[num17] + array2[num17])
				{
					goto IL_F3D;
				}
				num = 177;
			}
			if (num == 71)
			{
				goto IL_1559;
			}
			if (num == 198)
			{
				ptr3 += 4;
				num = 199;
			}
			if (num == 208)
			{
				ptr3++;
				num = 209;
			}
			if (num == 12)
			{
				ptr12 = ptr5 + *(uint*)(ptr - 16);
				num = 13;
			}
			if (num == 81)
			{
				goto IL_1559;
			}
			byte* ptr13;
			if (num == 182)
			{
				*(int*)(ptr13 + 4) = 0;
				num = 183;
			}
			if (num == 48)
			{
				*(int*)(ptr12 + 4) = 0;
				num = 49;
			}
			if (num == 174)
			{
				goto IL_830;
			}
			if (num == 42)
			{
				ptr += 40;
				num = 43;
			}
			int num22;
			if (num == 59)
			{
				num22 = 0;
				num = 60;
			}
			if (num == 95)
			{
				goto IL_20F;
			}
			if (num == 204)
			{
				if (*ptr3 != 0)
				{
					goto IL_1061;
				}
				num = 205;
			}
			if (num == 203)
			{
				ptr3++;
				num = 204;
			}
			if (num == 118)
			{
				if (num7 >= array[num16] + array2[num16])
				{
					goto IL_B35;
				}
				num = 119;
			}
			if (num != 86)
			{
				goto IL_27B;
			}
			goto IL_1559;
			IL_15BC:
			if (num == 141)
			{
				goto IL_48A;
			}
			goto IL_1593;
			IL_15A2:
			<Module>.VirtualProtect(ptr2, 8, 64U, ref num12);
			num = 62;
			goto IL_15BC;
			IL_1078:
			ushort num23;
			if (num22 >= (int)num23)
			{
				num = 88;
				goto IL_1087;
			}
			goto IL_15A2;
			IL_106E:
			if (num == 87)
			{
				goto IL_1078;
			}
			goto IL_1087;
			IL_F83:
			if (num == 184)
			{
				*(int*)(ptr13 + (IntPtr)3 * 4) = 0;
				num = 185;
			}
			int num24;
			if (num == 147)
			{
				num24 = 0;
				num = 148;
			}
			if (num == 143)
			{
				*(int*)ptr4 = 1818522734;
				num = 144;
			}
			if (num == 189)
			{
				ptr3 += *(uint*)ptr3;
				num = 190;
			}
			if (num == 75)
			{
				ptr2 += 2;
				num = 76;
			}
			if (num == 3)
			{
				ptr = ptr5 + 60;
				num = 4;
			}
			if (num == 94)
			{
				num20 = 0;
				num = 95;
			}
			uint num25;
			if (num == 166)
			{
				num25 = num25 - array[num10] + array3[num10];
				num = 167;
			}
			if (num == 207)
			{
				goto IL_1061;
			}
			goto IL_106E;
			IL_EC4:
			if (num == 119)
			{
				num7 = num7 - array[num16] + array3[num16];
				num = 120;
			}
			if (num == 43)
			{
				num19++;
				num = 44;
			}
			if (num == 172)
			{
				num4 = *(uint*)(ptr13 + 8);
				num = 173;
			}
			if (num == 85)
			{
				goto IL_F23;
			}
			goto IL_F83;
			IL_5BE:
			if (num == 142)
			{
				goto IL_EA6;
			}
			goto IL_EC4;
			IL_53D:
			if (num == 65)
			{
				goto IL_F23;
			}
			if (num == 74)
			{
				if (*ptr2 != 0)
				{
					goto IL_136D;
				}
				num = 75;
			}
			if (num == 91)
			{
				array = new uint[(int)num5];
				num = 92;
			}
			if (num == 167)
			{
				goto IL_E4C;
			}
			if (num == 53)
			{
				ptr2 += 12;
				num = 54;
			}
			if (num == 161)
			{
				goto IL_5AC;
			}
			goto IL_5BE;
			IL_530:
			if (num != 179)
			{
				goto IL_53D;
			}
			goto IL_F3D;
			IL_F5A:
			if (num3 >= (int)num5)
			{
				num = 113;
				goto IL_530;
			}
			goto IL_16C8;
			IL_A34:
			if (num == 97)
			{
				Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr), 8);
				num = 98;
			}
			if (num == 60)
			{
				goto IL_1078;
			}
			if (num == 67)
			{
				*ptr2 = 0;
				num = 68;
			}
			if (num == 72)
			{
				goto IL_A93;
			}
			goto IL_AA1;
			IL_A26:
			*(int*)ptr13 = 0;
			num = 182;
			goto IL_A34;
			IL_118F:
			if (num == 178)
			{
				goto IL_A26;
			}
			if (num == 205)
			{
				ptr3 += 3;
				num = 206;
			}
			if (num == 26)
			{
				num21++;
				num = 27;
			}
			if (num == 222)
			{
				goto IL_934;
			}
			goto IL_F6E;
			IL_11D3:
			if (num == 138)
			{
				num6 = num6 - array[num9] + array3[num9];
				num = 139;
			}
			if (num == 131)
			{
				goto IL_117F;
			}
			goto IL_118F;
			IL_125B:
			if (num == 218)
			{
				ptr3++;
				num = 219;
			}
			if (num == 159)
			{
				goto IL_11A1;
			}
			goto IL_11D3;
			IL_1225:
			if (num == 115)
			{
				num16 = 0;
				num = 116;
			}
			if (num == 123)
			{
				goto IL_126A;
			}
			goto IL_125B;
			IL_120E:
			if (num == 217)
			{
				goto IL_1218;
			}
			goto IL_1225;
			IL_C77:
			if (num == 152)
			{
				<Module>.VirtualProtect(ptr5 + num6, 11, 64U, ref num12);
				num = 153;
			}
			if (num == 62)
			{
				ptr2 += 4;
				num = 63;
			}
			if (num == 124)
			{
				num15 = *(uint*)(ptr9 + 12);
				num = 125;
			}
			if (num == 34)
			{
				goto IL_CE1;
			}
			if (num == 211)
			{
				goto IL_1427;
			}
			if (num == 149)
			{
				goto IL_11F9;
			}
			goto IL_120E;
			IL_A1C:
			if (num == 181)
			{
				goto IL_A26;
			}
			goto IL_A34;
			IL_A0A:
			if (num24 >= 11)
			{
				num = 152;
				goto IL_A1C;
			}
			goto IL_11F9;
			IL_15EB:
			if (num == 32)
			{
				ptr4[10] = 0;
				num = 33;
			}
			if (num == 69)
			{
				if (*ptr2 != 0)
				{
					goto IL_A93;
				}
				num = 70;
			}
			if (num == 50)
			{
				*(int*)(ptr12 + (IntPtr)3 * 4) = 0;
				num = 51;
			}
			if (num == 61)
			{
				goto IL_15A2;
			}
			goto IL_15BC;
			IL_166F:
			if (num == 117)
			{
				goto IL_AF2;
			}
			goto IL_15EB;
			IL_1681:
			num3++;
			num = 112;
			goto IL_166F;
			IL_16C8:
			if (array[num3] <= num2)
			{
				num = 108;
				goto IL_1699;
			}
			goto IL_1681;
			IL_AF2:
			if (array[num16] > num7)
			{
				goto IL_B35;
			}
			num = 118;
			goto IL_15EB;
			IL_48A:
			if (num9 < (int)num5)
			{
				goto IL_493;
			}
			num = 142;
			goto IL_1593;
			IL_7FF:
			if (num == 195)
			{
				goto IL_934;
			}
			if (num == 84)
			{
				num13++;
				num = 85;
			}
			if (num == 180)
			{
				goto IL_830;
			}
			goto IL_83F;
			IL_7EE:
			ptr10[num21] = ptr4[num21];
			num = 26;
			goto IL_7FF;
			IL_4A4:
			if (num21 >= 11)
			{
				num = 28;
				goto IL_4B6;
			}
			goto IL_7EE;
			IL_12C6:
			if (num == 153)
			{
				*(int*)ptr4 = 1866691662;
				num = 154;
			}
			if (num != 27)
			{
				goto IL_4B6;
			}
			goto IL_4A4;
			IL_1348:
			num9++;
			num = 141;
			goto IL_12C6;
			IL_493:
			if (array[num9] <= num6)
			{
				num = 137;
				goto IL_154A;
			}
			goto IL_1348;
			IL_27B:
			if (num == 136)
			{
				goto IL_493;
			}
			goto IL_154A;
			IL_1559:
			num22++;
			num = 87;
			goto IL_27B;
			IL_12B9:
			if (num != 140)
			{
				goto IL_12C6;
			}
			goto IL_1348;
			IL_129F:
			<Module>.VirtualProtect(ptr, 8, 64U, ref num12);
			num = 97;
			goto IL_12B9;
			IL_20F:
			if (num20 >= (int)num5)
			{
				num = 104;
				goto IL_170C;
			}
			goto IL_129F;
			IL_0B:
			if (num == 155)
			{
				*(short*)(ptr4 + (IntPtr)4 * 2) = 25973;
				num = 156;
			}
			if (num == 146)
			{
				ptr4[10] = 0;
				num = 147;
			}
			if (num == 190)
			{
				ptr3 = (ptr3 + 7L & -4L);
				num = 191;
			}
			if (num == 188)
			{
				ptr3 += 12;
				num = 189;
			}
			if (num == 103)
			{
				goto IL_20F;
			}
			goto IL_170C;
			IL_10F2:
			if (num == 19)
			{
				*(int*)ptr4 = 1818522734;
				num = 20;
			}
			if (num == 165)
			{
				if (num25 >= array[num10] + array2[num10])
				{
					goto IL_1128;
				}
				num = 166;
			}
			if (num == 57)
			{
				num23 = (ushort)(*ptr2);
				num = 58;
			}
			if (num == 96)
			{
				goto IL_129F;
			}
			goto IL_12B9;
			IL_10E5:
			*ptr3 = 0;
			num = 213;
			goto IL_10F2;
			IL_E2D:
			if (num == 70)
			{
				ptr2 += 3;
				num = 71;
			}
			if (num == 104)
			{
				if (num2 == 0U)
				{
					goto IL_B4F;
				}
				num = 105;
			}
			if (num == 129)
			{
				num15 = num15 - array[num14] + array3[num14];
				num = 130;
			}
			if (num == 200)
			{
				goto IL_DF1;
			}
			if (num == 212)
			{
				goto IL_10E5;
			}
			goto IL_10F2;
			IL_DFC:
			<Module>.VirtualProtect(ptr, 8, 64U, ref num12);
			num = 41;
			goto IL_E2D;
			IL_E7B:
			if (num == 73)
			{
				ptr2++;
				num = 74;
			}
			if (num == 40)
			{
				goto IL_DFC;
			}
			goto IL_E2D;
			IL_E8A:
			<Module>.VirtualProtect(ptr2, 4, 64U, ref num12);
			num = 67;
			goto IL_E7B;
			IL_F23:
			if (num13 >= 8)
			{
				num = 86;
				goto IL_F83;
			}
			goto IL_E8A;
			IL_E5A:
			if (num == 66)
			{
				goto IL_E8A;
			}
			goto IL_E7B;
			IL_E4C:
			ptr13 = ptr5 + num25;
			num = 171;
			goto IL_E5A;
			IL_E42:
			if (num == 170)
			{
				goto IL_E4C;
			}
			goto IL_E5A;
			IL_DF1:
			if (num18 >= 8)
			{
				num = 221;
				goto IL_E42;
			}
			goto IL_D95;
			IL_BA0:
			if (num == 150)
			{
				num24++;
				num = 151;
			}
			if (num == 49)
			{
				*(int*)(ptr12 + (IntPtr)2 * 4) = 0;
				num = 50;
			}
			if (num == 139)
			{
				goto IL_EA6;
			}
			if (num == 25)
			{
				goto IL_7EE;
			}
			goto IL_7FF;
			IL_BB2:
			int num26;
			ptr6[num26] = ptr4[num26];
			num = 36;
			goto IL_BA0;
			IL_CE1:
			if (num26 < 11)
			{
				goto IL_BB2;
			}
			num = 38;
			goto IL_1363;
			IL_D83:
			if (num == 177)
			{
				num4 = num4 - array[num17] + array3[num17];
				num = 178;
			}
			if (num == 98)
			{
				array[num20] = *(uint*)(ptr + 12);
				num = 99;
			}
			if (num == 63)
			{
				ptr2 += 4;
				num = 64;
			}
			if (num == 41)
			{
				Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr), 8);
				num = 42;
			}
			if (num == 21)
			{
				*(short*)(ptr4 + (IntPtr)4 * 2) = 108;
				num = 22;
			}
			if (num == 11)
			{
				if (module.FullyQualifiedName[0] == '<')
				{
					goto IL_6FD;
				}
				num = 12;
			}
			if (num == 37)
			{
				goto IL_CE1;
			}
			goto IL_1363;
			IL_D95:
			<Module>.VirtualProtect(ptr3, 4, 64U, ref num12);
			num = 202;
			goto IL_D83;
			IL_B5C:
			if (num == 191)
			{
				ptr3 += 2;
				num = 192;
			}
			if (num == 128)
			{
				if (num15 >= array[num14] + array2[num14])
				{
					goto IL_117F;
				}
				num = 129;
			}
			if (num != 35)
			{
				goto IL_BA0;
			}
			goto IL_BB2;
			IL_B4F:
			num10 = 0;
			num = 163;
			goto IL_B5C;
			IL_B45:
			if (num == 162)
			{
				goto IL_B4F;
			}
			goto IL_B5C;
			IL_B35:
			num16++;
			num = 122;
			goto IL_B45;
			IL_B0E:
			if (num == 9)
			{
				ushort num27;
				ptr = ptr + 4 + num27;
				num = 10;
			}
			if (num == 121)
			{
				goto IL_B35;
			}
			goto IL_B45;
			IL_B00:
			ptr9 = ptr5 + num2;
			num = 114;
			goto IL_B0E;
			IL_956:
			if (num == 110)
			{
				goto IL_B00;
			}
			if (num == 164)
			{
				goto IL_96D;
			}
			goto IL_97F;
			IL_93D:
			<Module>.VirtualProtect(ptr3, 8, 64U, ref num12);
			num = 197;
			goto IL_956;
			IL_934:
			int num28;
			if (num28 < (int)num8)
			{
				goto IL_93D;
			}
			num = 223;
			goto IL_F6E;
			IL_70E:
			if (num == 33)
			{
				num26 = 0;
				num = 34;
			}
			if (num == 36)
			{
				num26++;
				num = 37;
			}
			if (num == 216)
			{
				goto IL_1427;
			}
			if (num == 83)
			{
				ptr2++;
				num = 84;
			}
			if (num == 215)
			{
				ptr3++;
				num = 216;
			}
			if (num == 196)
			{
				goto IL_93D;
			}
			goto IL_956;
			IL_4B6:
			if (num == 120)
			{
				goto IL_126A;
			}
			if (num == 79)
			{
				if (*ptr2 != 0)
				{
					goto IL_AC2;
				}
				num = 80;
			}
			if (num == 52)
			{
				*(int*)ptr2 = 0;
				num = 53;
			}
			if (num == 29)
			{
				*(int*)ptr4 = 1866691662;
				num = 30;
			}
			if (num != 89)
			{
				goto IL_70E;
			}
			IL_6FD:
			num25 = *(uint*)(ptr - 16);
			num = 90;
			goto IL_70E;
			IL_AD0:
			if (num == 113)
			{
				goto IL_B00;
			}
			goto IL_B0E;
			IL_AC2:
			*ptr2 = 0;
			num = 83;
			goto IL_AD0;
			IL_AA1:
			if (num == 214)
			{
				if (*ptr3 != 0)
				{
					goto IL_1218;
				}
				num = 215;
			}
			if (num == 82)
			{
				goto IL_AC2;
			}
			goto IL_AD0;
			IL_A93:
			*ptr2 = 0;
			num = 73;
			goto IL_AA1;
			IL_97F:
			if (num == 44)
			{
				goto IL_989;
			}
			goto IL_998;
			IL_96D:
			if (array[num10] <= num25)
			{
				num = 165;
				goto IL_97F;
			}
			goto IL_1128;
			IL_170C:
			if (num == 31)
			{
				*(short*)(ptr4 + (IntPtr)4 * 2) = 25973;
				num = 32;
			}
			if (num == 186)
			{
				<Module>.VirtualProtect(ptr3, 4, 64U, ref num12);
				num = 187;
			}
			if (num == 122)
			{
				goto IL_AE9;
			}
			goto IL_16D9;
			IL_BF6:
			if (num == 8)
			{
				ushort num27 = *(ushort*)ptr;
				num = 9;
			}
			if (num == 210)
			{
				ptr3 += 2;
				num = 211;
			}
			if (num == 14)
			{
				ptr11 = ptr5 + *(uint*)(ptr - 120);
				num = 15;
			}
			if (num == 92)
			{
				array2 = new uint[(int)num5];
				num = 93;
			}
			if (num == 126)
			{
				goto IL_C68;
			}
			if (num == 4)
			{
				ptr = ptr5 + *(uint*)ptr;
				num = 5;
			}
			if (num == 99)
			{
				array2[num20] = *(uint*)(ptr + 8);
				num = 100;
			}
			if (num == 220)
			{
				goto IL_DF1;
			}
			goto IL_E42;
			IL_BE9:
			num19 = 0;
			num = 39;
			goto IL_BF6;
			IL_1138:
			if (num == 199)
			{
				num18 = 0;
				num = 200;
			}
			if (num == 194)
			{
				num28 = 0;
				num = 195;
			}
			if (num == 127)
			{
				goto IL_1173;
			}
			goto IL_13AD;
			IL_1128:
			num10++;
			num = 169;
			goto IL_1138;
			IL_1087:
			if (num == 45)
			{
				<Module>.VirtualProtect(ptr12, 72, 64U, ref num12);
				num = 46;
			}
			if (num == 28)
			{
				<Module>.VirtualProtect(ptr6, 11, 64U, ref num12);
				num = 29;
			}
			if (num != 168)
			{
				goto IL_1138;
			}
			goto IL_1128;
			IL_150B:
			if (num == 183)
			{
				*(int*)(ptr13 + (IntPtr)2 * 4) = 0;
				num = 184;
			}
			if (num == 171)
			{
				<Module>.VirtualProtect(ptr13, 72, 64U, ref num12);
				num = 172;
			}
			if (num != 169)
			{
				goto IL_2F3;
			}
			goto IL_14F7;
			IL_F31:
			if (array[num17] > num4)
			{
				goto IL_F3D;
			}
			num = 176;
			goto IL_150B;
			IL_154A:
			if (num == 55)
			{
				ptr2 = (ptr2 + 7L & -4L);
				num = 56;
			}
			if (num == 175)
			{
				goto IL_F31;
			}
			goto IL_150B;
			IL_1437:
			if (num == 154)
			{
				*(int*)(ptr4 + 4) = 1852404846;
				num = 155;
			}
			if (num == 133)
			{
				goto IL_1488;
			}
			goto IL_1479;
			IL_1427:
			num28++;
			num = 222;
			goto IL_1437;
			IL_137B:
			if (num == 102)
			{
				num20++;
				num = 103;
			}
			if (num == 221)
			{
				goto IL_1427;
			}
			goto IL_1437;
			IL_136D:
			*ptr2 = 0;
			num = 78;
			goto IL_137B;
			IL_1363:
			if (num == 77)
			{
				goto IL_136D;
			}
			goto IL_137B;
			IL_1061:
			*ptr3 = 0;
			num = 208;
			goto IL_106E;
			IL_EA6:
			<Module>.VirtualProtect(ptr5 + num15, 11, 64U, ref num12);
			num = 143;
			goto IL_EC4;
			IL_5AC:
			if (num11 >= 11)
			{
				num = 162;
				goto IL_5BE;
			}
			goto IL_11A1;
			IL_F3D:
			num17++;
			num = 180;
			goto IL_53D;
			IL_F6E:
			if (num == 112)
			{
				goto IL_F5A;
			}
			goto IL_530;
			IL_117F:
			num14++;
			num = 132;
			goto IL_118F;
			IL_11A1:
			(ptr5 + num6)[num11] = ptr4[num11];
			num = 160;
			goto IL_11D3;
			IL_126A:
			ptr8 = ptr5 + num7;
			num = 124;
			goto IL_125B;
			IL_1218:
			*ptr3 = 0;
			num = 218;
			goto IL_1225;
			IL_11F9:
			(ptr5 + num15)[num24] = ptr4[num24];
			num = 150;
			goto IL_120E;
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002252 File Offset: 0x00000452
	internal static bool gEh9kEUXfyrTvRPbA8()
	{
		return <Module>.NWV5SeAWL3buyDGmUL == null;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000225C File Offset: 0x0000045C
	internal static <Module> y5M5KnqpUZWZ0RARQB()
	{
		return <Module>.NWV5SeAWL3buyDGmUL;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002263 File Offset: 0x00000463
	internal static object bgmpglNjk49hvv8k9q(int int_0)
	{
		return d81XbNfiFICS4GJsBf.p9BWqnQw8w(int_0);
	}

	// Token: 0x04000001 RID: 1
	internal static <Module> NWV5SeAWL3buyDGmUL;
}
