## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FFEBCD5A4D8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD678C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD5A730]
       setae     sil
       movzx     esi,sil
       mov       rcx,248393C1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,248393C1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD5A738]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,248393CB850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,248393CB858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD5B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,248393C2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,248393C3020
       mov       rbx,[r8]
       mov       [rsp+30],rbx
       mov       r8,248393C31D8
       mov       r8,[r8]
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+30],rbx
       mov       rax,248193C20C8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,248193C20D0
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M02_L02
       mov       rdx,248393C1568
       mov       r14,[rdx]
       mov       rdx,248193C20D8
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L05
       cmp       ebp,ebx
       jg        short M02_L01
M02_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 329
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M03_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M03_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       rax,248393C3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FFEBCD6A4F8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD778C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD6A750]
       setae     sil
       movzx     esi,sil
       mov       rcx,270AC101568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,270AC101380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD6A758]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2708C109858
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,2708C109860
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD6B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,270AC102E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2708C101028
       mov       rbx,[r8]
       mov       [rsp+30],rbx
       mov       r8,2708C1011E0
       mov       r8,[r8]
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+30],rbx
       mov       rax,270AC1040C0
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,270AC1040C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M02_L02
       mov       rdx,270AC101568
       mov       r14,[rdx]
       mov       rdx,270AC1040D0
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L05
       cmp       ebp,ebx
       jg        short M02_L01
M02_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 329
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M03_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M03_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       rax,2708C101028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FFEBCD4A4F8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD578C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD4A750]
       setae     sil
       movzx     esi,sil
       mov       rcx,29C68F21568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,29C68F21380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD4A758]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,29C78F27448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,29C78F27450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD4B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,29C68F22E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,29C48F21028
       mov       rbx,[r8]
       mov       [rsp+30],rbx
       mov       r8,29C48F211E0
       mov       r8,[r8]
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+30],rbx
       mov       rax,29C68F238A8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,29C68F238B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M02_L02
       mov       rdx,29C68F21568
       mov       r14,[rdx]
       mov       rdx,29C68F238B8
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L05
       cmp       ebp,ebx
       jg        short M02_L01
M02_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 329
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M03_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M03_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       rax,29C48F21028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FFEBCD4A478]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD578C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD4A6D0]
       setae     sil
       movzx     esi,sil
       mov       rcx,2048F211568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,2048F211380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD4A6D8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2048F21B850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,2048F21B858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD4B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,2048F212E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2048F213020
       mov       rbx,[r8]
       mov       [rsp+30],rbx
       mov       r8,2048F2131D8
       mov       r8,[r8]
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+30],rbx
       mov       rax,204AF2130E0
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,204AF2130E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M02_L02
       mov       rdx,2048F211568
       mov       r14,[rdx]
       mov       rdx,204AF2130F0
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L05
       cmp       ebp,ebx
       jg        short M02_L01
M02_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 329
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M03_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M03_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       rax,2048F213020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FFEBCD4A978]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD578C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD4ABD0]
       setae     sil
       movzx     esi,sil
       mov       rcx,23FAACF1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,23FAACF1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD4ABD8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,23FAACFB850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,23FAACFB858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD4B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,23FAACF2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,23FAACF3020
       mov       rbx,[r8]
       mov       [rsp+30],rbx
       mov       r8,23FAACF31D8
       mov       r8,[r8]
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+30],rbx
       mov       rax,23F8ACF30E0
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,23F8ACF30E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M02_L02
       mov       rdx,23FAACF1568
       mov       r14,[rdx]
       mov       rdx,23F8ACF30F0
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L05
       cmp       ebp,ebx
       jg        short M02_L01
M02_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 329
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M03_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M03_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       rax,23FAACF3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FFEBCD7A618]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD878C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD7A870]
       setae     sil
       movzx     esi,sil
       mov       rcx,1E3ED261568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1E3ED261380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD7A878]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1E3CD269858
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,1E3CD269860
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD7B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,1E3ED262E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1E3CD261028
       mov       rbx,[r8]
       mov       [rsp+30],rbx
       mov       r8,1E3CD2611E0
       mov       r8,[r8]
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+30],rbx
       mov       rax,1E3CD270908
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,1E3CD270910
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M02_L02
       mov       rdx,1E3ED261568
       mov       r14,[rdx]
       mov       rdx,1E3CD270918
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L05
       cmp       ebp,ebx
       jg        short M02_L01
M02_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 329
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M03_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M03_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       rax,1E3CD261028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC994000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC994000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FFEBCD4A4F8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD578C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD4A750]
       setae     sil
       movzx     esi,sil
       mov       rcx,24184D51568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,24184D51380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD4A758]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,241B4D57448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,241B4D57450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD4B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,24184D52E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,24194D51028
       mov       rbx,[r8]
       mov       [rsp+30],rbx
       mov       r8,24194D511E0
       mov       r8,[r8]
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+30],rbx
       mov       rax,241A4D528C8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,241A4D528D0
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M02_L02
       mov       rdx,24184D51568
       mov       r14,[rdx]
       mov       rdx,241A4D528D8
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L05
       cmp       ebp,ebx
       jg        short M02_L01
M02_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 329
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M03_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M03_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       rax,24194D51028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FFEBCD5A618]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD678C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD5A870]
       setae     sil
       movzx     esi,sil
       mov       rcx,2783C6E1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,2783C6E1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD5A878]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2784C6E7448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,2784C6E7450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD5B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,2783C6E2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2781C6E1028
       mov       rbx,[r8]
       mov       [rsp+30],rbx
       mov       r8,2781C6E11E0
       mov       r8,[r8]
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+30],rbx
       mov       rax,2781C6E44D8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,2781C6E44E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M02_L02
       mov       rdx,2783C6E1568
       mov       r14,[rdx]
       mov       rdx,2781C6E44E8
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L05
       cmp       ebp,ebx
       jg        short M02_L01
M02_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 329
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M03_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M03_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       rax,2781C6E1028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FFEBCD3A598]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD478C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD3A7F0]
       setae     sil
       movzx     esi,sil
       mov       rcx,17E6BC01568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,17E6BC01380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD3A7F8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,17E6BC0B850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,17E6BC0B858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD3B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,17E6BC02E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,17E6BC03020
       mov       rbx,[r8]
       mov       [rsp+30],rbx
       mov       r8,17E6BC031D8
       mov       r8,[r8]
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       [rsp+30],rbx
       mov       rax,17E4BC020C8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,17E4BC020D0
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M02_L02
       mov       rdx,17E6BC01568
       mov       r14,[rdx]
       mov       rdx,17E4BC020D8
       mov       r15,[rdx]
M02_L01:
       movsxd    rdx,ebx
       lea       rdx,[rdi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L05
       cmp       ebp,ebx
       jg        short M02_L01
M02_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 329
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M03_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M03_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       rax,17E6BC03020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC954000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC954000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
; 			var stringArray = this.GetStringArray(10, 15, 20);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L02
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
; 			for (var index = 0; index < stringArray.Length; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
; 				var testString = stringArray[index];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD678C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 218
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,1759B761028
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,1759B763B40
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,1759B763DF8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,1759B763E00
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD66EE0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE44A20
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,175BB762F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE824C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0A0]
       mov       rax,1759B761028
       mov       r15,[rax]
       mov       [rsp+30],r15
       mov       rax,1759B7643D8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rbp,rbp
       je        short M03_L01
       cmp       dword ptr [rbp+8],0
       je        short M03_L01
       xor       eax,eax
       jmp       short M03_L02
M03_L01:
       mov       eax,1
M03_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L03
       cmp       dword ptr [rax+8],0
       je        short M03_L03
       mov       rbp,[rsp+30]
       jmp       short M03_L06
M03_L03:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       r12,rcx
M03_L05:
       mov       rdx,1759B763B10
       mov       rdx,[rdx]
       mov       rcx,r12
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L06:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rdi,rdi
       je        short M03_L07
       cmp       dword ptr [rdi+8],0
       je        short M03_L07
       xor       eax,eax
       jmp       short M03_L08
M03_L07:
       mov       eax,1
M03_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L11
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L09
       cmp       dword ptr [rax+8],0
       je        short M03_L09
       mov       rdi,[rsp+30]
       jmp       short M03_L11
M03_L09:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L10
       mov       rcx,r12
       jmp       short M03_L10
M03_L10:
       mov       rdx,1759B761270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L11:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       mov       rdx,r12
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L12
       cmp       dword ptr [rdx+8],0
       je        short M03_L12
       mov       rcx,[rsp+30]
       jmp       short M03_L12
M03_L12:
       mov       rdx,1759B7643E0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L13:
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L14
       cmp       dword ptr [rdx+8],0
       je        short M03_L14
       mov       rcx,[rsp+30]
       jmp       short M03_L14
M03_L14:
       mov       rdx,1759B7643E8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L15:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L16
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L17:
       cmp       ebx,0FFFFFFFF
       je        short M03_L18
       cmp       ebx,0FFFFFFFE
       jne       near ptr M03_L28
M03_L18:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L20
M03_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L20:
       xor       ebx,ebx
       mov       rcx,7FFEBCDEACA0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M03_L21:
       mov       r9,175CB767AB0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M03_L26
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M03_L32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L22
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L23
M03_L22:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L23:
       cmp       r15d,ebp
       jae       near ptr M03_L33
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L25
M03_L24:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L25:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M03_L32
       jmp       near ptr M03_L21
M03_L26:
       sub       ebp,ebx
       jo        near ptr M03_L32
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L27
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L29
M03_L27:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L29
M03_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M03_L29:
       cmp       r14d,0FFFFFFFF
       je        short M03_L30
       cmp       r14d,0FFFFFFFE
       jne       short M03_L31
M03_L30:
       mov       rdx,1759B7639F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M03_L31:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1093
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,1759B761028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
; 			var stringArray = this.GetStringArray(10, 15, 20);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L02
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
; 			for (var index = 0; index < stringArray.Length; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
; 				var testString = stringArray[index];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD678C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 218
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,25A6BF93020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,25A6BF95B38
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,25A6BF96E08
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,25A6BF96E10
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD66F00]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE44A20
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25A6BF92F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE824C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0A0]
       mov       rax,25A6BF93020
       mov       r15,[rax]
       mov       [rsp+30],r15
       mov       rax,25A6BF973E8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rbp,rbp
       je        short M03_L01
       cmp       dword ptr [rbp+8],0
       je        short M03_L01
       xor       eax,eax
       jmp       short M03_L02
M03_L01:
       mov       eax,1
M03_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L03
       cmp       dword ptr [rax+8],0
       je        short M03_L03
       mov       rbp,[rsp+30]
       jmp       short M03_L06
M03_L03:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       r12,rcx
M03_L05:
       mov       rdx,25A6BF95B08
       mov       rdx,[rdx]
       mov       rcx,r12
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L06:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rdi,rdi
       je        short M03_L07
       cmp       dword ptr [rdi+8],0
       je        short M03_L07
       xor       eax,eax
       jmp       short M03_L08
M03_L07:
       mov       eax,1
M03_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L11
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L09
       cmp       dword ptr [rax+8],0
       je        short M03_L09
       mov       rdi,[rsp+30]
       jmp       short M03_L11
M03_L09:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L10
       mov       rcx,r12
       jmp       short M03_L10
M03_L10:
       mov       rdx,25A6BF93268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L11:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       mov       rdx,r12
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L12
       cmp       dword ptr [rdx+8],0
       je        short M03_L12
       mov       rcx,[rsp+30]
       jmp       short M03_L12
M03_L12:
       mov       rdx,25A6BF973F0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L13:
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L14
       cmp       dword ptr [rdx+8],0
       je        short M03_L14
       mov       rcx,[rsp+30]
       jmp       short M03_L14
M03_L14:
       mov       rdx,25A6BF973F8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L15:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L16
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L17:
       cmp       ebx,0FFFFFFFF
       je        short M03_L18
       cmp       ebx,0FFFFFFFE
       jne       near ptr M03_L28
M03_L18:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L20
M03_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L20:
       xor       ebx,ebx
       mov       rcx,7FFEBCDEACA0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M03_L21:
       mov       r9,25A9BF97AB0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M03_L26
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M03_L32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L22
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L23
M03_L22:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L23:
       cmp       r15d,ebp
       jae       near ptr M03_L33
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L25
M03_L24:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L25:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M03_L32
       jmp       near ptr M03_L21
M03_L26:
       sub       ebp,ebx
       jo        near ptr M03_L32
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L27
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L29
M03_L27:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L29
M03_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M03_L29:
       cmp       r14d,0FFFFFFFF
       je        short M03_L30
       cmp       r14d,0FFFFFFFE
       jne       short M03_L31
M03_L30:
       mov       rdx,25A6BF959F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M03_L31:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1093
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,25A6BF93020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
; 			var stringArray = this.GetStringArray(10, 15, 20);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L02
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
; 			for (var index = 0; index < stringArray.Length; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
; 				var testString = stringArray[index];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD478C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 218
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,12A1B151028
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,129FB151730
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,129FB1519E8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,129FB1519F0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD46F00]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE24A20
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,12A2B152F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE62450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE62680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE62670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE62698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE627A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE627F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE62670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE62670
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0A0]
       mov       rax,12A1B151028
       mov       r15,[rax]
       mov       [rsp+30],r15
       mov       rax,129FB151FC8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rbp,rbp
       je        short M03_L01
       cmp       dword ptr [rbp+8],0
       je        short M03_L01
       xor       eax,eax
       jmp       short M03_L02
M03_L01:
       mov       eax,1
M03_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L03
       cmp       dword ptr [rax+8],0
       je        short M03_L03
       mov       rbp,[rsp+30]
       jmp       short M03_L06
M03_L03:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       r12,rcx
M03_L05:
       mov       rdx,129FB151700
       mov       rdx,[rdx]
       mov       rcx,r12
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L06:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rdi,rdi
       je        short M03_L07
       cmp       dword ptr [rdi+8],0
       je        short M03_L07
       xor       eax,eax
       jmp       short M03_L08
M03_L07:
       mov       eax,1
M03_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L11
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L09
       cmp       dword ptr [rax+8],0
       je        short M03_L09
       mov       rdi,[rsp+30]
       jmp       short M03_L11
M03_L09:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L10
       mov       rcx,r12
       jmp       short M03_L10
M03_L10:
       mov       rdx,12A1B151270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L11:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       mov       rdx,r12
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L12
       cmp       dword ptr [rdx+8],0
       je        short M03_L12
       mov       rcx,[rsp+30]
       jmp       short M03_L12
M03_L12:
       mov       rdx,129FB151FD0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L13:
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L14
       cmp       dword ptr [rdx+8],0
       je        short M03_L14
       mov       rcx,[rsp+30]
       jmp       short M03_L14
M03_L14:
       mov       rdx,129FB151FD8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L15:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L16
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L17:
       cmp       ebx,0FFFFFFFF
       je        short M03_L18
       cmp       ebx,0FFFFFFFE
       jne       near ptr M03_L28
M03_L18:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L20
M03_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L20:
       xor       ebx,ebx
       mov       rcx,7FFEBCDCACA0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M03_L21:
       mov       r9,12A1B159EC0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M03_L26
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M03_L32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L22
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L23
M03_L22:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L23:
       cmp       r15d,ebp
       jae       near ptr M03_L33
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L25
M03_L24:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L25:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M03_L32
       jmp       near ptr M03_L21
M03_L26:
       sub       ebp,ebx
       jo        near ptr M03_L32
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L27
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L29
M03_L27:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L29
M03_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M03_L29:
       cmp       r14d,0FFFFFFFF
       je        short M03_L30
       cmp       r14d,0FFFFFFFE
       jne       short M03_L31
M03_L30:
       mov       rdx,129FB1515E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M03_L31:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1093
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,12A1B151028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
; 			var stringArray = this.GetStringArray(10, 15, 20);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L02
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
; 			for (var index = 0; index < stringArray.Length; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
; 				var testString = stringArray[index];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD678C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 218
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,18121793020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,18121795B38
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,181417911D0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,181417911D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD66F00]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE44A20
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,18121792F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE824C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE82860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE826E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0A0]
       mov       rax,18121793020
       mov       r15,[rax]
       mov       [rsp+30],r15
       mov       rax,181417917B0
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rbp,rbp
       je        short M03_L01
       cmp       dword ptr [rbp+8],0
       je        short M03_L01
       xor       eax,eax
       jmp       short M03_L02
M03_L01:
       mov       eax,1
M03_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L03
       cmp       dword ptr [rax+8],0
       je        short M03_L03
       mov       rbp,[rsp+30]
       jmp       short M03_L06
M03_L03:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       r12,rcx
M03_L05:
       mov       rdx,18121795B08
       mov       rdx,[rdx]
       mov       rcx,r12
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L06:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rdi,rdi
       je        short M03_L07
       cmp       dword ptr [rdi+8],0
       je        short M03_L07
       xor       eax,eax
       jmp       short M03_L08
M03_L07:
       mov       eax,1
M03_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L11
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L09
       cmp       dword ptr [rax+8],0
       je        short M03_L09
       mov       rdi,[rsp+30]
       jmp       short M03_L11
M03_L09:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L10
       mov       rcx,r12
       jmp       short M03_L10
M03_L10:
       mov       rdx,18121793268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L11:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       mov       rdx,r12
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L12
       cmp       dword ptr [rdx+8],0
       je        short M03_L12
       mov       rcx,[rsp+30]
       jmp       short M03_L12
M03_L12:
       mov       rdx,181417917B8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L13:
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L14
       cmp       dword ptr [rdx+8],0
       je        short M03_L14
       mov       rcx,[rsp+30]
       jmp       short M03_L14
M03_L14:
       mov       rdx,181417917C0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L15:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L16
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L17:
       cmp       ebx,0FFFFFFFF
       je        short M03_L18
       cmp       ebx,0FFFFFFFE
       jne       near ptr M03_L28
M03_L18:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L20
M03_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L20:
       xor       ebx,ebx
       mov       rcx,7FFEBCDEACA0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M03_L21:
       mov       r9,18151797AB0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M03_L26
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M03_L32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L22
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L23
M03_L22:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L23:
       cmp       r15d,ebp
       jae       near ptr M03_L33
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L25
M03_L24:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L25:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M03_L32
       jmp       near ptr M03_L21
M03_L26:
       sub       ebp,ebx
       jo        near ptr M03_L32
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L27
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L29
M03_L27:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L29
M03_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M03_L29:
       cmp       r14d,0FFFFFFFF
       je        short M03_L30
       cmp       r14d,0FFFFFFFE
       jne       short M03_L31
M03_L30:
       mov       rdx,181217959F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M03_L31:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1093
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,18121793020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
; 			var stringArray = this.GetStringArray(10, 15, 20);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L02
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
; 			for (var index = 0; index < stringArray.Length; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
; 				var testString = stringArray[index];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD578C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 218
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,2151C623020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,214FC621730
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,214FC622A00
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,214FC622A08
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD56EE0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE34A20
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2151C622F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE724C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE72708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE72818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE72860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0A0]
       mov       rax,2151C623020
       mov       r15,[rax]
       mov       [rsp+30],r15
       mov       rax,214FC622FE0
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rbp,rbp
       je        short M03_L01
       cmp       dword ptr [rbp+8],0
       je        short M03_L01
       xor       eax,eax
       jmp       short M03_L02
M03_L01:
       mov       eax,1
M03_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L03
       cmp       dword ptr [rax+8],0
       je        short M03_L03
       mov       rbp,[rsp+30]
       jmp       short M03_L06
M03_L03:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       r12,rcx
M03_L05:
       mov       rdx,214FC621700
       mov       rdx,[rdx]
       mov       rcx,r12
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L06:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rdi,rdi
       je        short M03_L07
       cmp       dword ptr [rdi+8],0
       je        short M03_L07
       xor       eax,eax
       jmp       short M03_L08
M03_L07:
       mov       eax,1
M03_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L11
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L09
       cmp       dword ptr [rax+8],0
       je        short M03_L09
       mov       rdi,[rsp+30]
       jmp       short M03_L11
M03_L09:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L10
       mov       rcx,r12
       jmp       short M03_L10
M03_L10:
       mov       rdx,2151C623268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L11:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       mov       rdx,r12
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L12
       cmp       dword ptr [rdx+8],0
       je        short M03_L12
       mov       rcx,[rsp+30]
       jmp       short M03_L12
M03_L12:
       mov       rdx,214FC622FE8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L13:
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L14
       cmp       dword ptr [rdx+8],0
       je        short M03_L14
       mov       rcx,[rsp+30]
       jmp       short M03_L14
M03_L14:
       mov       rdx,214FC622FF0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L15:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L16
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L17:
       cmp       ebx,0FFFFFFFF
       je        short M03_L18
       cmp       ebx,0FFFFFFFE
       jne       near ptr M03_L28
M03_L18:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L20
M03_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L20:
       xor       ebx,ebx
       mov       rcx,7FFEBCDDACA0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M03_L21:
       mov       r9,2151C62BEB8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M03_L26
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M03_L32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L22
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L23
M03_L22:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L23:
       cmp       r15d,ebp
       jae       near ptr M03_L33
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L25
M03_L24:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L25:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M03_L32
       jmp       near ptr M03_L21
M03_L26:
       sub       ebp,ebx
       jo        near ptr M03_L32
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L27
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L29
M03_L27:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L29
M03_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M03_L29:
       cmp       r14d,0FFFFFFFF
       je        short M03_L30
       cmp       r14d,0FFFFFFFE
       jne       short M03_L31
M03_L30:
       mov       rdx,214FC6215E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M03_L31:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1093
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,2151C623020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
; 			var stringArray = this.GetStringArray(10, 15, 20);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L02
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
; 			for (var index = 0; index < stringArray.Length; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
; 				var testString = stringArray[index];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD778C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 218
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,260C6571028
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,260E6573728
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,260C65745F8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,260C6574600
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD76EE0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE54A20
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,260E6572F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE924C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE926F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE926E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE92708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE92818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE92860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE926E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE926E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0A0]
       mov       rax,260C6571028
       mov       r15,[rax]
       mov       [rsp+30],r15
       mov       rax,260C6574BD8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rbp,rbp
       je        short M03_L01
       cmp       dword ptr [rbp+8],0
       je        short M03_L01
       xor       eax,eax
       jmp       short M03_L02
M03_L01:
       mov       eax,1
M03_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L03
       cmp       dword ptr [rax+8],0
       je        short M03_L03
       mov       rbp,[rsp+30]
       jmp       short M03_L06
M03_L03:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       r12,rcx
M03_L05:
       mov       rdx,260E65736F8
       mov       rdx,[rdx]
       mov       rcx,r12
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L06:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rdi,rdi
       je        short M03_L07
       cmp       dword ptr [rdi+8],0
       je        short M03_L07
       xor       eax,eax
       jmp       short M03_L08
M03_L07:
       mov       eax,1
M03_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L11
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L09
       cmp       dword ptr [rax+8],0
       je        short M03_L09
       mov       rdi,[rsp+30]
       jmp       short M03_L11
M03_L09:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L10
       mov       rcx,r12
       jmp       short M03_L10
M03_L10:
       mov       rdx,260C6571270
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L11:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       mov       rdx,r12
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L12
       cmp       dword ptr [rdx+8],0
       je        short M03_L12
       mov       rcx,[rsp+30]
       jmp       short M03_L12
M03_L12:
       mov       rdx,260C6574BE0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L13:
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L14
       cmp       dword ptr [rdx+8],0
       je        short M03_L14
       mov       rcx,[rsp+30]
       jmp       short M03_L14
M03_L14:
       mov       rdx,260C6574BE8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L15:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L16
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L17:
       cmp       ebx,0FFFFFFFF
       je        short M03_L18
       cmp       ebx,0FFFFFFFE
       jne       near ptr M03_L28
M03_L18:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L20
M03_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L20:
       xor       ebx,ebx
       mov       rcx,7FFEBCDFACA0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M03_L21:
       mov       r9,260D6573618
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M03_L26
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M03_L32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L22
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L23
M03_L22:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L23:
       cmp       r15d,ebp
       jae       near ptr M03_L33
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L25
M03_L24:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L25:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M03_L32
       jmp       near ptr M03_L21
M03_L26:
       sub       ebp,ebx
       jo        near ptr M03_L32
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L27
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L29
M03_L27:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L29
M03_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M03_L29:
       cmp       r14d,0FFFFFFFF
       je        short M03_L30
       cmp       r14d,0FFFFFFFE
       jne       short M03_L31
M03_L30:
       mov       rdx,260E65735E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M03_L31:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1093
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,260C6571028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC994000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC994000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
; 			var stringArray = this.GetStringArray(10, 15, 20);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L02
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
; 			for (var index = 0; index < stringArray.Length; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
; 				var testString = stringArray[index];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD378C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 218
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,2C464023020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,2C444021730
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,2C464032A20
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,2C464032A28
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD36EE0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE14A20
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2C464022F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE525C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE527F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE527E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE52810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE52920
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE52968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE527E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE527E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0A0]
       mov       rax,2C464023020
       mov       r15,[rax]
       mov       [rsp+30],r15
       mov       rax,2C464033000
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rbp,rbp
       je        short M03_L01
       cmp       dword ptr [rbp+8],0
       je        short M03_L01
       xor       eax,eax
       jmp       short M03_L02
M03_L01:
       mov       eax,1
M03_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L03
       cmp       dword ptr [rax+8],0
       je        short M03_L03
       mov       rbp,[rsp+30]
       jmp       short M03_L06
M03_L03:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       r12,rcx
M03_L05:
       mov       rdx,2C444021700
       mov       rdx,[rdx]
       mov       rcx,r12
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L06:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rdi,rdi
       je        short M03_L07
       cmp       dword ptr [rdi+8],0
       je        short M03_L07
       xor       eax,eax
       jmp       short M03_L08
M03_L07:
       mov       eax,1
M03_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L11
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L09
       cmp       dword ptr [rax+8],0
       je        short M03_L09
       mov       rdi,[rsp+30]
       jmp       short M03_L11
M03_L09:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L10
       mov       rcx,r12
       jmp       short M03_L10
M03_L10:
       mov       rdx,2C464023268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L11:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       mov       rdx,r12
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L12
       cmp       dword ptr [rdx+8],0
       je        short M03_L12
       mov       rcx,[rsp+30]
       jmp       short M03_L12
M03_L12:
       mov       rdx,2C464033008
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L13:
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L14
       cmp       dword ptr [rdx+8],0
       je        short M03_L14
       mov       rcx,[rsp+30]
       jmp       short M03_L14
M03_L14:
       mov       rdx,2C464033010
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L15:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L16
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L17:
       cmp       ebx,0FFFFFFFF
       je        short M03_L18
       cmp       ebx,0FFFFFFFE
       jne       near ptr M03_L28
M03_L18:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L20
M03_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L20:
       xor       ebx,ebx
       mov       rcx,7FFEBCDBACA0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M03_L21:
       mov       r9,2C46402BEB8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M03_L26
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M03_L32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L22
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L23
M03_L22:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L23:
       cmp       r15d,ebp
       jae       near ptr M03_L33
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L25
M03_L24:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L25:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M03_L32
       jmp       near ptr M03_L21
M03_L26:
       sub       ebp,ebx
       jo        near ptr M03_L32
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L27
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L29
M03_L27:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L29
M03_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M03_L29:
       cmp       r14d,0FFFFFFFF
       je        short M03_L30
       cmp       r14d,0FFFFFFFE
       jne       short M03_L31
M03_L30:
       mov       rdx,2C4440215E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M03_L31:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1093
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,2C464023020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC954000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC954000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
; 			var stringArray = this.GetStringArray(10, 15, 20);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L02
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
; 			for (var index = 0; index < stringArray.Length; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
; 				var testString = stringArray[index];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD578C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 218
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,1DDBC113020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,1DDBC115B38
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,1DDDC11E618
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,1DDDC11E620
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD56F00]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE34A20
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DDBC112F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE724C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE72708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE72818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE72860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0A0]
       mov       rax,1DDBC113020
       mov       r15,[rax]
       mov       [rsp+30],r15
       mov       rax,1DDDC11EBF8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rbp,rbp
       je        short M03_L01
       cmp       dword ptr [rbp+8],0
       je        short M03_L01
       xor       eax,eax
       jmp       short M03_L02
M03_L01:
       mov       eax,1
M03_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L03
       cmp       dword ptr [rax+8],0
       je        short M03_L03
       mov       rbp,[rsp+30]
       jmp       short M03_L06
M03_L03:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       r12,rcx
M03_L05:
       mov       rdx,1DDBC115B08
       mov       rdx,[rdx]
       mov       rcx,r12
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L06:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rdi,rdi
       je        short M03_L07
       cmp       dword ptr [rdi+8],0
       je        short M03_L07
       xor       eax,eax
       jmp       short M03_L08
M03_L07:
       mov       eax,1
M03_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L11
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L09
       cmp       dword ptr [rax+8],0
       je        short M03_L09
       mov       rdi,[rsp+30]
       jmp       short M03_L11
M03_L09:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L10
       mov       rcx,r12
       jmp       short M03_L10
M03_L10:
       mov       rdx,1DDBC113268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L11:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       mov       rdx,r12
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L12
       cmp       dword ptr [rdx+8],0
       je        short M03_L12
       mov       rcx,[rsp+30]
       jmp       short M03_L12
M03_L12:
       mov       rdx,1DDDC11EC00
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L13:
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L14
       cmp       dword ptr [rdx+8],0
       je        short M03_L14
       mov       rcx,[rsp+30]
       jmp       short M03_L14
M03_L14:
       mov       rdx,1DDDC11EC08
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L15:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L16
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L17:
       cmp       ebx,0FFFFFFFF
       je        short M03_L18
       cmp       ebx,0FFFFFFFE
       jne       near ptr M03_L28
M03_L18:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L20
M03_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L20:
       xor       ebx,ebx
       mov       rcx,7FFEBCDDACA0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M03_L21:
       mov       r9,1DDDC117AB0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M03_L26
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M03_L32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L22
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L23
M03_L22:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L23:
       cmp       r15d,ebp
       jae       near ptr M03_L33
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L25
M03_L24:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L25:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M03_L32
       jmp       near ptr M03_L21
M03_L26:
       sub       ebp,ebx
       jo        near ptr M03_L32
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L27
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L29
M03_L27:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L29
M03_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M03_L29:
       cmp       r14d,0FFFFFFFF
       je        short M03_L30
       cmp       r14d,0FFFFFFFE
       jne       short M03_L31
M03_L30:
       mov       rdx,1DDBC1159F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M03_L31:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1093
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,1DDBC113020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
; 			var stringArray = this.GetStringArray(10, 15, 20);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L02
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
; 			for (var index = 0; index < stringArray.Length; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
; 				var testString = stringArray[index];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD578C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 218
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,21F3B273020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,21F3B275B38
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,21F3B276E08
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,21F3B276E10
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD56EE0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE34A20
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,21F3B272F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE724C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE72708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE72818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE72860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE726E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0A0]
       mov       rax,21F3B273020
       mov       r15,[rax]
       mov       [rsp+30],r15
       mov       rax,21F3B2773E8
       mov       rax,[rax]
       mov       [rsp+28],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+20],rax
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+20]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rbp,rbp
       je        short M03_L01
       cmp       dword ptr [rbp+8],0
       je        short M03_L01
       xor       eax,eax
       jmp       short M03_L02
M03_L01:
       mov       eax,1
M03_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L06
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L03
       cmp       dword ptr [rax+8],0
       je        short M03_L03
       mov       rbp,[rsp+30]
       jmp       short M03_L06
M03_L03:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       r12,rcx
M03_L05:
       mov       rdx,21F3B275B08
       mov       rdx,[rdx]
       mov       rcx,r12
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L06:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       xor       eax,eax
       mov       [rsp+30],rax
       mov       r12,r15
       test      rdi,rdi
       je        short M03_L07
       cmp       dword ptr [rdi+8],0
       je        short M03_L07
       xor       eax,eax
       jmp       short M03_L08
M03_L07:
       mov       eax,1
M03_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L11
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M03_L09
       cmp       dword ptr [rax+8],0
       je        short M03_L09
       mov       rdi,[rsp+30]
       jmp       short M03_L11
M03_L09:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [r12+8],0
       je        short M03_L10
       mov       rcx,r12
       jmp       short M03_L10
M03_L10:
       mov       rdx,21F3B273268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M03_L11:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r13,rax
       mov       rcx,r13
       mov       [r12+8],ebx
       mov       rdx,r12
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L13
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L12
       cmp       dword ptr [rdx+8],0
       je        short M03_L12
       mov       rcx,[rsp+30]
       jmp       short M03_L12
M03_L12:
       mov       rdx,21F3B2773F0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L13:
       mov       [rsp+30],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r13
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M03_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,[rsp+30]
       test      rdx,rdx
       je        short M03_L14
       cmp       dword ptr [rdx+8],0
       je        short M03_L14
       mov       rcx,[rsp+30]
       jmp       short M03_L14
M03_L14:
       mov       rdx,21F3B2773F8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M03_L15:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L16
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M03_L17
M03_L16:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L17:
       cmp       ebx,0FFFFFFFF
       je        short M03_L18
       cmp       ebx,0FFFFFFFE
       jne       near ptr M03_L28
M03_L18:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L20
M03_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L20:
       xor       ebx,ebx
       mov       rcx,7FFEBCDDACA0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M03_L21:
       mov       r9,21F5B277AB0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M03_L26
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M03_L32
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L22
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L23
M03_L22:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L23:
       cmp       r15d,ebp
       jae       near ptr M03_L33
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L25
M03_L24:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M03_L25:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M03_L32
       jmp       near ptr M03_L21
M03_L26:
       sub       ebp,ebx
       jo        near ptr M03_L32
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M03_L27
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M03_L29
M03_L27:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L29
M03_L28:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M03_L29:
       cmp       r14d,0FFFFFFFF
       je        short M03_L30
       cmp       r14d,0FFFFFFFE
       jne       short M03_L31
M03_L30:
       mov       rdx,21F3B2759F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M03_L31:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L32:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1093
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,21F3B273020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,2F18FE735E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD778C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,2F1AFE71028
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,2F18FE73728
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,2F1AFE7FA10
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,2F1AFE7FA18
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD66CA0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE448D0
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2F18FE72F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81368
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+8]
       mov       rax,2F1AFE71028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rax,2F1AFE7FFF0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,2F18FE735F0
       mov       r9,[r9]
       mov       [rsp+38],r9
       lea       r8,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String ByRef, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 320
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,2F1AFE71028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,29B5D8059F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD778C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,29B5D803020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,29B5D805B38
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,29B7D8021E8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,29B7D8021F0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD66CA0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE448D0
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,29B5D802F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE812B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE812A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE812D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE813E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE812A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE812A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+8]
       mov       rax,29B5D803020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rax,29B7D8027C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,29B5D805A00
       mov       r9,[r9]
       mov       [rsp+38],r9
       lea       r8,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String ByRef, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 320
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,29B5D803020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,20A130259F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD878C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,20A13023020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,20A13025B38
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,20A13025DF0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,20A13025DF8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD76DC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE548D0
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20A13022F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE912B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE914E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE914D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE91500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE91610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE91640
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE914D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE914D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+8]
       mov       rax,20A13023020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rax,20A130263D0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,20A13025A00
       mov       r9,[r9]
       mov       [rsp+38],r9
       lea       r8,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String ByRef, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 320
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,20A13023020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC994000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC994000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,181790615E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD878C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,18199063020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,18179061730
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,18199072A20
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,18199072A28
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD76DC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE548D0
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,18199062F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE91088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE912B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE912A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE912D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE913E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE91410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE912A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE912A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+8]
       mov       rax,18199063020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rax,18199073000
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,181790615F8
       mov       r9,[r9]
       mov       [rsp+38],r9
       lea       r8,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String ByRef, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 320
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,18199063020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC994000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC994000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,24C37CD1E20
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD578C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,24C37CC3020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,24C37CD1F68
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,24C37CD3238
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,24C37CD3240
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD46DC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE248D0
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,24C37CC2F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE61088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE612B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE612A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE612D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE613E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE61410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE612A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE612A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+8]
       mov       rax,24C37CC3020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rax,24C37CD3818
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,24C37CD1E30
       mov       r9,[r9]
       mov       [rsp+38],r9
       lea       r8,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String ByRef, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 320
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,24C37CC3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,1D4E2D315E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD878C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,1D502D33020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,1D4E2D31730
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,1D502D42A20
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,1D502D42A28
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD76CA0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE548D0
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1D502D32F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE912B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE914E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE914D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE91500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE91610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE91640
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE914D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE914D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+8]
       mov       rax,1D502D33020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rax,1D502D43000
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1D4E2D315F8
       mov       r9,[r9]
       mov       [rsp+38],r9
       lea       r8,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String ByRef, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 320
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,1D502D33020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC994000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC994000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,17A7E2335E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD778C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,17A6E231028
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,17A7E233728
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,17A6E23FA10
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,17A6E23FA18
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD66DC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE448D0
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,17A7E232F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE812B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE814E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE814D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE81640
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE814D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE814D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+8]
       mov       rax,17A6E231028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rax,17A6E23FFF0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,17A7E2335F0
       mov       r9,[r9]
       mov       [rsp+38],r9
       lea       r8,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String ByRef, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 320
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,17A6E231028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,2C99DA539F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD678C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,2C99DA51028
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,2C99DA53B40
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,2C99DA54E10
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,2C99DA54E18
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD56CA0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE348D0
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2C9BDA52F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE712B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE714E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE714D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE71500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE71610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE71640
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE714D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE714D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+8]
       mov       rax,2C99DA51028
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rax,2C99DA553F0
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,2C99DA53A08
       mov       r9,[r9]
       mov       [rsp+38],r9
       lea       r8,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String ByRef, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 320
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,2C99DA51028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC974000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0A
       mov       edx,0F
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        short M00_L00
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,2765ED71E20
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFEBCD478C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 180
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       rdx,2765ED63020
       mov       rbp,[rdx]
       mov       r14,rbp
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L02
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L02
       test      edx,edx
       je        near ptr M01_L22
       mov       esi,eax
       jmp       short M01_L05
M01_L02:
       test      ecx,ecx
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r14,rcx
M01_L04:
       mov       rdx,2765ED71F68
       mov       rdx,[rdx]
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      edi,edi
       jle       short M01_L06
       cmp       edi,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L07
M01_L06:
       xor       edx,edx
M01_L07:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L08
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L08
       test      edx,edx
       je        near ptr M01_L22
       mov       edi,eax
       jmp       short M01_L10
M01_L08:
       test      ecx,ecx
       jne       short M01_L10
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L09
       mov       rcx,r14
       jmp       short M01_L09
M01_L09:
       mov       rdx,2763ED621E8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L10:
       lea       rax,[rsp+28]
       xor       edx,edx
       mov       [rax],rdx
       mov       r14,rbp
       test      ebx,ebx
       jle       short M01_L11
       cmp       ebx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       jmp       short M01_L12
M01_L11:
       xor       edx,edx
M01_L12:
       mov       ecx,edx
       test      edx,edx
       jne       short M01_L13
       movzx     edx,byte ptr [rax]
       movzx     r8d,dl
       mov       eax,[rax+4]
       test      r8b,r8b
       je        short M01_L13
       test      edx,edx
       je        near ptr M01_L22
       mov       ebx,eax
       jmp       short M01_L15
M01_L13:
       test      ecx,ecx
       jne       short M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L14
       mov       rcx,r14
       jmp       short M01_L14
M01_L14:
       mov       rdx,2763ED621F0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L19
M01_L16:
       mov       ecx,edi
       mov       edx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbp
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L18:
       add       r14d,1
       jo        short M01_L21
       cmp       r14d,esi
       jl        short M01_L16
M01_L19:
       mov       rdx,[rbp+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD36DC0]
       vcvttsd2si edx,xmm0
       cmp       [rbp+10],edx
       jge       short M01_L20
       mov       edx,[rbp+10]
       mov       rcx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L20:
       mov       rcx,7FFEBCE148D0
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2765ED62F48
       mov       rcx,[rcx]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Collections.Immutable.ImmutableList`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
; Total bytes of code 568
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,[rsi+10]
       mov       rcx,rbx
       mov       rbp,[rcx+8]
       cmp       rbp,30
       jle       near ptr M02_L06
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L07
       cmp       rbp,40
       jle       near ptr M02_L08
       mov       r11,[rbx+40]
       test      r11,r11
       je        near ptr M02_L08
M02_L01:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        short M02_L04
       mov       rdx,[rsi+10]
       cmp       qword ptr [rdx+8],48
       jle       near ptr M02_L14
       mov       rcx,[rdx+48]
       test      rcx,rcx
       je        near ptr M02_L14
M02_L02:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       near ptr M02_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        near ptr M02_L15
M02_L03:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       near ptr M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M02_L16
M02_L05:
       call      System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE51010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       r15,rbx
       cmp       rbp,38
       jle       short M02_L09
       jmp       near ptr M02_L13
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFEBCE51240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L01
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFEBCE51230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L10:
       lea       rcx,[rsp+20]
       mov       rdx,rax
       mov       r8d,1
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L17
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L11:
       lea       rcx,[rsp+20]
       mov       r8,rdi
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M02_L18
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L12:
       lea       rcx,[rsp+20]
       call      System.Collections.Generic.LargeArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L13:
       mov       rax,[r15+38]
       test      rax,rax
       je        near ptr M02_L09
       jmp       short M02_L10
M02_L14:
       mov       rcx,rsi
       mov       rdx,7FFEBCE51258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFEBCE51368
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L03
M02_L16:
       mov       rcx,rsi
       mov       rdx,7FFEBCE51398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE51230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE51230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
       jmp       near ptr M02_L12
; Total bytes of code 617
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+8]
       mov       rax,2765ED63020
       mov       rax,[rax]
       mov       [rsp+38],rax
       mov       rax,2763ED627C8
       mov       rax,[rax]
       mov       [rsp+30],rax
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       [rsp+28],rax
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+28]
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String ByRef, System.String ByRef, System.String ByRef)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,2765ED71E30
       mov       r9,[r9]
       mov       [rsp+38],r9
       lea       r8,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String ByRef, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String ByRef, System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 320
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,2765ED63020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFEBC954000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFEBC954000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCD4A230]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD4A430]
       setae     sil
       movzx     esi,sil
       mov       rcx,21E86031568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,21E86031380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD4A438]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,21E8603B850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,21E8603B858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD4B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,21E86032E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,21E86033020
       mov       rdi,[rdx]
       test      rsi,rsi
       je        short M02_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdi,rcx
M02_L03:
       mov       rdx,21E860331D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21E660320C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,21E86031568
       mov       r14,[rdx]
       mov       rdx,21E660320D0
       mov       r15,[rdx]
M02_L05:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L09
       cmp       ebp,ebx
       jg        short M02_L05
M02_L06:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L07
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L08:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD478C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 349
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCD5A230]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD5A430]
       setae     sil
       movzx     esi,sil
       mov       rcx,22E63A21568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,22E63A21380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD5A438]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,22E93A27448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,22E93A27450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD5B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,22E63A22E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,22E63A23020
       mov       rdi,[rdx]
       test      rsi,rsi
       je        short M02_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdi,rcx
M02_L03:
       mov       rdx,22E63A231D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,22E63A274E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,22E63A21568
       mov       r14,[rdx]
       mov       rdx,22E63A274F0
       mov       r15,[rdx]
M02_L05:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L09
       cmp       ebp,ebx
       jg        short M02_L05
M02_L06:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L07
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L08:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD578C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 349
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCD4A3F0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD4A5F0]
       setae     sil
       movzx     esi,sil
       mov       rcx,21A3B421568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,21A3B421380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD4A5F8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,21A5B422FB0
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,21A5B422FB8
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD4B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,21A3B422E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,21A3B423020
       mov       rdi,[rdx]
       test      rsi,rsi
       je        short M02_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdi,rcx
M02_L03:
       mov       rdx,21A3B4231D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21A3B4274E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,21A3B421568
       mov       r14,[rdx]
       mov       rdx,21A3B4274F0
       mov       r15,[rdx]
M02_L05:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L09
       cmp       ebp,ebx
       jg        short M02_L05
M02_L06:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L07
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L08:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD478C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 349
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCD6A390]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD6A590]
       setae     sil
       movzx     esi,sil
       mov       rcx,18302F71568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,18302F71380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD6A598]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,182E2F72FB0
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,182E2F72FB8
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD6B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,18302F72E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,18302F73020
       mov       rdi,[rdx]
       test      rsi,rsi
       je        short M02_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdi,rcx
M02_L03:
       mov       rdx,18302F731D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,18302F7B168
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,18302F71568
       mov       r14,[rdx]
       mov       rdx,18302F7B170
       mov       r15,[rdx]
M02_L05:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L09
       cmp       ebp,ebx
       jg        short M02_L05
M02_L06:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L07
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L08:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD678C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 349
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCD6A230]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD6A430]
       setae     sil
       movzx     esi,sil
       mov       rcx,1AD721C1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1AD721C1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD6A438]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1AD921C7448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,1AD921C7450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD6B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,1AD721C2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,1AD721C3020
       mov       rdi,[rdx]
       test      rsi,rsi
       je        short M02_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdi,rcx
M02_L03:
       mov       rdx,1AD721C31D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1AD721C74E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,1AD721C1568
       mov       r14,[rdx]
       mov       rdx,1AD721C74F0
       mov       r15,[rdx]
M02_L05:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L09
       cmp       ebp,ebx
       jg        short M02_L05
M02_L06:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L07
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L08:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD678C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 349
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCD4A210]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD4A410]
       setae     sil
       movzx     esi,sil
       mov       rcx,236A9F41568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,236A9F41380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD4A418]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,236C9F49858
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,236C9F49860
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD4B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,236A9F42E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,236C9F41028
       mov       rdi,[rdx]
       test      rsi,rsi
       je        short M02_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdi,rcx
M02_L03:
       mov       rdx,236C9F411E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,236C9F51108
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,236A9F41568
       mov       r14,[rdx]
       mov       rdx,236C9F51110
       mov       r15,[rdx]
M02_L05:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L09
       cmp       ebp,ebx
       jg        short M02_L05
M02_L06:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L07
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L08:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD478C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 349
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCD6A230]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD6A430]
       setae     sil
       movzx     esi,sil
       mov       rcx,1D5655D1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1D5655D1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD6A438]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1D5655DB850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,1D5655DB858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD6B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,1D5655D2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,1D5655D3020
       mov       rdi,[rdx]
       test      rsi,rsi
       je        short M02_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdi,rcx
M02_L03:
       mov       rdx,1D5655D31D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1D5455D20C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,1D5655D1568
       mov       r14,[rdx]
       mov       rdx,1D5455D20D0
       mov       r15,[rdx]
M02_L05:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L09
       cmp       ebp,ebx
       jg        short M02_L05
M02_L06:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L07
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L08:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD678C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 349
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCD7A390]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD7A590]
       setae     sil
       movzx     esi,sil
       mov       rcx,2CF9AC21568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,2CF9AC21380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD7A598]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2CFCAC27448
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,2CFCAC27450
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD7B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,2CF9AC22E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,2CF9AC23020
       mov       rdi,[rdx]
       test      rsi,rsi
       je        short M02_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdi,rcx
M02_L03:
       mov       rdx,2CF9AC231D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2CFBAC228C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,2CF9AC21568
       mov       r14,[rdx]
       mov       rdx,2CFBAC228D0
       mov       r15,[rdx]
M02_L05:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L09
       cmp       ebp,ebx
       jg        short M02_L05
M02_L06:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L07
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L08:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD778C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 349
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFEBCD7A390]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFA0],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       vucomisd  xmm0,qword ptr [7FFEBCD7A590]
       setae     sil
       movzx     esi,sil
       mov       rcx,202BD9B1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,202BD9B1380
       mov       r8,[r8]
       mov       [rbp+0FFC0],rbx
       mov       [rbp+0FFC8],rcx
       mov       [rbp+0FFD0],rcx
       mov       [rbp+0FFD8],r8
       mov       rcx,rdi
       lea       r8,[rbp+0FFC0]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       vmovsd    xmm0,qword ptr [rbp+10]
       and       esi,1
       jne       short M01_L00
       vxorps    xmm0,xmm0,xmm0
M01_L00:
       vmulsd    xmm0,xmm0,qword ptr [7FFEBCD7A598]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,202BD9BB850
       mov       rcx,[rdx]
       mov       [rbp+0FFA8],rcx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       cmp       byte ptr [rbp+0FFE0],0
       jne       short M01_L01
       lea       rdx,[rbp+0FFE0]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      System.Threading.Monitor.ThrowLockTakenException()
       int       3
M01_L02:
       mov       rcx,202BD9BB858
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFEBCD7B0A0]
       nop
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L03
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L03:
       test      edi,edi
       je        short M01_L05
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,edi
       mov       rdx,rsi
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M01_L04:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rax,202BD9B2E98
       mov       rax,[rax]
       jmp       short M01_L04
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp+0FFE0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFA8]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,202BD9B3020
       mov       rdi,[rdx]
       test      rsi,rsi
       je        short M02_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M02_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdi,rcx
M02_L03:
       mov       rdx,202BD9B31D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2029D9B20C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,202BD9B1568
       mov       r14,[rdx]
       mov       rdx,2029D9B20D0
       mov       r15,[rdx]
M02_L05:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M02_L09
       cmp       ebp,ebx
       jg        short M02_L05
M02_L06:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L07
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L08:
       mov       rcx,rdi
       call      qword ptr [7FFEBCD778C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 349
```

