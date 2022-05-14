## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFE645FBD30]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
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
       vucomisd  xmm0,qword ptr [7FFE645FBF30]
       setae     sil
       movzx     esi,sil
       mov       rcx,1B1E01A1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1B1E01A1380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE645FBF38]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1B2101A3F48
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
       mov       rcx,1B2101A3F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646063E8]
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
       mov       rax,1B1E01A2E98
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M02_L01
M02_L00:
       mov       rax,1B1E01A3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M02_L02
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Linq.Enumerable.ToList[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE64602E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M02_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 257
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFE6461B950]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
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
       vucomisd  xmm0,qword ptr [7FFE6461BF50]
       setae     sil
       movzx     esi,sil
       mov       rcx,23BE7241568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,23BE7241380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE6461BF58]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,23C07246358
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
       mov       rcx,23C07246360
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646263E8]
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
       mov       rax,23BE7242E98
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M02_L01
M02_L00:
       mov       rax,23C07241028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M02_L02
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Linq.Enumerable.ToList[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE64622E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M02_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 257
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFE645FBD30]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
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
       vucomisd  xmm0,qword ptr [7FFE645FBF30]
       setae     sil
       movzx     esi,sil
       mov       rcx,24833BA1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,24833BA1380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE645FBF38]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,24863BA3F48
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
       mov       rcx,24863BA3F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646063E8]
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
       mov       rax,24833BA2E98
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M02_L01
M02_L00:
       mov       rax,24833BA3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M02_L02
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Linq.Enumerable.ToList[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE64602E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M02_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 257
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFE6462B950]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
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
       vucomisd  xmm0,qword ptr [7FFE6462BF50]
       setae     sil
       movzx     esi,sil
       mov       rcx,1572B281568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1572B281380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE6462BF58]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1570B283F48
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
       mov       rcx,1570B283F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646363E8]
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
       mov       rax,1572B282E98
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M02_L01
M02_L00:
       mov       rax,1572B283020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M02_L02
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Linq.Enumerable.ToList[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE64632E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M02_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 257
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFE6461B950]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
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
       vucomisd  xmm0,qword ptr [7FFE6461BF50]
       setae     sil
       movzx     esi,sil
       mov       rcx,1E321FC1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1E321FC1380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE6461BF58]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1E341FC3F48
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
       mov       rcx,1E341FC3F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646263E8]
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
       mov       rax,1E321FC2E98
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M02_L01
M02_L00:
       mov       rax,1E321FC3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M02_L02
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Linq.Enumerable.ToList[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE64622E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M02_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 257
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFE645FBD30]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
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
       vucomisd  xmm0,qword ptr [7FFE645FBF30]
       setae     sil
       movzx     esi,sil
       mov       rcx,21AA11F1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,21AA11F1380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE645FBF38]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,21AA11F8350
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
       mov       rcx,21AA11F8358
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646063E8]
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
       mov       rax,21AA11F2E98
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M02_L01
M02_L00:
       mov       rax,21AA11F3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M02_L02
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Linq.Enumerable.ToList[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE64602E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M02_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 257
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFE645EB950]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
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
       vucomisd  xmm0,qword ptr [7FFE645EBF50]
       setae     sil
       movzx     esi,sil
       mov       rcx,20120C71568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,20120C71380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE645EBF58]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,20120C78350
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
       mov       rcx,20120C78358
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE645F63E8]
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
       mov       rax,20120C72E98
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M02_L01
M02_L00:
       mov       rax,20120C73020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M02_L02
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Linq.Enumerable.ToList[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE645F2E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M02_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 257
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFE645FD1D0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
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
       vucomisd  xmm0,qword ptr [7FFE645FD3D0]
       setae     sil
       movzx     esi,sil
       mov       rcx,1B3A6661568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1B3A6661380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE645FD3D8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1B3C6663F48
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
       mov       rcx,1B3C6663F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646063E8]
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
       mov       rax,1B3A6662E98
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M02_L01
M02_L00:
       mov       rax,1B3A6663020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M02_L02
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Linq.Enumerable.ToList[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE64602E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M02_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 257
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       vmovsd    xmm0,qword ptr [7FFE645FD1D0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       rcx,rax
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
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
       vucomisd  xmm0,qword ptr [7FFE645FD3D0]
       setae     sil
       movzx     esi,sil
       mov       rcx,1AE506E1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1AE506E1380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE645FD3D8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1AE506E5F40
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
       mov       rcx,1AE506E5F48
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646063E8]
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
       mov       rax,1AE506E2E98
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
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M02_L01
M02_L00:
       mov       rax,1AE606E1028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M02_L02
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Linq.Enumerable.ToList[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass26_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE64602E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M02_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M02_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 257
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       eax,[rsi+0A8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
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
; Total bytes of code 63
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
       vucomisd  xmm0,qword ptr [7FFE64640350]
       setae     sil
       movzx     esi,sil
       mov       rcx,1F5C2661568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1F5C2661380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE64640358]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1F5C2665F40
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
       mov       rcx,1F5C2665F48
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE64648040]
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
       mov       rax,1F5C2662E98
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
       mov       rdx,1F5D2661028
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
       mov       rdx,1F5D26611E0
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
       mov       rdx,1F5C2668898
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,1F5C2661568
       mov       r14,[rdx]
       mov       rdx,1F5C26688A0
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
       call      qword ptr [7FFE64642E80]
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
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       eax,[rsi+0A8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
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
; Total bytes of code 63
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
       vucomisd  xmm0,qword ptr [7FFE6461A1F0]
       setae     sil
       movzx     esi,sil
       mov       rcx,18FD5EC1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,18FD5EC1380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE6461A1F8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,19005EC3F48
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
       mov       rcx,19005EC3F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646263E8]
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
       mov       rax,18FD5EC2E98
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
       mov       rdx,18FD5EC3020
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
       mov       rdx,18FD5EC31D8
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
       mov       rdx,18FF5EC18B0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,18FD5EC1568
       mov       r14,[rdx]
       mov       rdx,18FF5EC18B8
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
       call      qword ptr [7FFE64622E80]
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
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       eax,[rsi+0A8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
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
; Total bytes of code 63
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
       vucomisd  xmm0,qword ptr [7FFE645FB880]
       setae     sil
       movzx     esi,sil
       mov       rcx,215FC1D1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,215FC1D1380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE645FB888]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2162C1D3F48
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
       mov       rcx,2162C1D3F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646063E8]
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
       mov       rax,215FC1D2E98
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
       mov       rdx,215FC1D3020
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
       mov       rdx,215FC1D31D8
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
       mov       rdx,2161C1D20C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,215FC1D1568
       mov       r14,[rdx]
       mov       rdx,2161C1D20D0
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
       call      qword ptr [7FFE64602E80]
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
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       eax,[rsi+0A8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
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
; Total bytes of code 63
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
       vucomisd  xmm0,qword ptr [7FFE6462B650]
       setae     sil
       movzx     esi,sil
       mov       rcx,2A588531568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,2A588531380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE6462B658]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2A5B8533F48
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
       mov       rcx,2A5B8533F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646363E8]
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
       mov       rax,2A588532E98
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
       mov       rdx,2A588533020
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
       mov       rdx,2A5885331D8
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
       mov       rdx,2A5885364D0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,2A588531568
       mov       r14,[rdx]
       mov       rdx,2A5885364D8
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
       call      qword ptr [7FFE64632E80]
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
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       eax,[rsi+0A8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
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
; Total bytes of code 63
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
       vucomisd  xmm0,qword ptr [7FFE645EB430]
       setae     sil
       movzx     esi,sil
       mov       rcx,21659731568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,21659731380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE645EB438]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,21679735F40
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
       mov       rcx,21679735F48
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE645F63E8]
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
       mov       rax,21659732E98
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
       mov       rdx,21659733020
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
       mov       rdx,216597331D8
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
       mov       rdx,21679737880
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,21659731568
       mov       r14,[rdx]
       mov       rdx,21679737888
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
       call      qword ptr [7FFE645F2E80]
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
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       eax,[rsi+0A8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
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
; Total bytes of code 63
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
       vucomisd  xmm0,qword ptr [7FFE6461A350]
       setae     sil
       movzx     esi,sil
       mov       rcx,1FD55131568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,1FD55131380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE6461A358]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,1FD65133F48
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
       mov       rcx,1FD65133F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646263E8]
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
       mov       rax,1FD55132E98
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
       mov       rdx,1FD45131028
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
       mov       rdx,1FD451311E0
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
       mov       rdx,1FD451344D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,1FD55131568
       mov       r14,[rdx]
       mov       rdx,1FD451344E0
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
       call      qword ptr [7FFE64622E80]
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
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       eax,[rsi+0A8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
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
; Total bytes of code 63
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
       vucomisd  xmm0,qword ptr [7FFE6461B800]
       setae     sil
       movzx     esi,sil
       mov       rcx,2748E321568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,2748E321380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE6461B808]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,2746E323F48
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
       mov       rcx,2746E323F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646263E8]
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
       mov       rax,2748E322E98
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
       mov       rdx,2748E323020
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
       mov       rdx,2748E3231D8
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
       mov       rdx,2748E3264D0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,2748E321568
       mov       r14,[rdx]
       mov       rdx,2748E3264D8
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
       call      qword ptr [7FFE64622E80]
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
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       eax,[rsi+0A8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
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
; Total bytes of code 63
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
       vucomisd  xmm0,qword ptr [7FFE6461B810]
       setae     sil
       movzx     esi,sil
       mov       rcx,129BAC01568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,129BAC01380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE6461B818]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,129BAC08350
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
       mov       rcx,129BAC08358
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646263E8]
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
       mov       rax,129BAC02E98
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
       mov       rdx,129BAC03020
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
       mov       rdx,129BAC031D8
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
       mov       rdx,1299AC028C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,129BAC01568
       mov       r14,[rdx]
       mov       rdx,1299AC028D0
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
       call      qword ptr [7FFE64622E80]
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
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       eax,[rsi+0A8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
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
; Total bytes of code 63
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
       vucomisd  xmm0,qword ptr [7FFE645FBEE0]
       setae     sil
       movzx     esi,sil
       mov       rcx,188317A1568
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       rdx,rax
       mov       qword ptr [rbx+8],1
       xor       ecx,ecx
       mov       r8,188317A1380
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
       vmulsd    xmm0,xmm0,qword ptr [7FFE645FBEE8]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
       mov       rdx,188617A3F48
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
       mov       rcx,188617A3F50
       mov       rcx,[rcx]
       mov       [rbp+0FFB0],rsi
       mov       [rbp+0FFB8],edi
       lea       rdx,[rbp+0FFB0]
       call      qword ptr [7FFE646063E8]
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
       mov       rax,188317A2E98
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
       mov       rdx,188317A3020
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
       mov       rdx,188317A31D8
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
       mov       rdx,188617A5888
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L06
       mov       rdx,188317A1568
       mov       r14,[rdx]
       mov       rdx,188617A5890
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
       call      qword ptr [7FFE64602E80]
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

