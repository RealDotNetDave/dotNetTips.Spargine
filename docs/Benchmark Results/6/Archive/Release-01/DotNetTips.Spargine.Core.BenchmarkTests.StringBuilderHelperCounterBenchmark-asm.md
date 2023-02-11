## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFED0B00568]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFED0770508
       call      qword ptr [7FFED0B00508]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFED0770510
       call      qword ptr [7FFED0B00510]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,21A463A68F0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFED0AE7838]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFED0AE7840]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,21A563A3F48
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,21A563A3F50
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF2FD05AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
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
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFF2FD04AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2FD05AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFF2FD01340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFF2FCFFDC0]
       call      qword ptr [7FFF2FCFFDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFF2FCF9248]
       int       3
M03_L17:
       xor       eax,eax
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
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFF2FCFD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFF2FCFFDC8]
       call      qword ptr [7FFF2FCFFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFF2FD00578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       test      rax,rax
       jne       short M04_L01
M04_L00:
       mov       rax,21A463A3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M04_L02
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B02E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M04_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFED0B30568]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFED07A0508
       call      qword ptr [7FFED0B30508]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFED07A0510
       call      qword ptr [7FFED0B30510]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,2BFF8581CE8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFED0B17838]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFED0B17840]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,2C008583F48
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2C008583F50
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF2FD05AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
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
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFF2FD04AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2FD05AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFF2FD01340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFF2FCFFDC0]
       call      qword ptr [7FFF2FCFFDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFF2FCF9248]
       int       3
M03_L17:
       xor       eax,eax
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
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFF2FCFD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFF2FCFFDC8]
       call      qword ptr [7FFF2FCFFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFF2FD00578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       test      rax,rax
       jne       short M04_L01
M04_L00:
       mov       rax,2BFD8583020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M04_L02
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B32E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M04_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFED0B10708]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFED0780508
       call      qword ptr [7FFED0B10508]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFED0780510
       call      qword ptr [7FFED0B10510]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,1F7541758D8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFED0AF7838]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFED0AF7840]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,1F784173F48
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1F784173F50
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF2FD05AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
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
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFF2FD04AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2FD05AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFF2FD01340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFF2FCFFDC0]
       call      qword ptr [7FFF2FCFFDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFF2FCF9248]
       int       3
M03_L17:
       xor       eax,eax
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
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFF2FCFD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFF2FCFFDC8]
       call      qword ptr [7FFF2FCFFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFF2FD00578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       test      rax,rax
       jne       short M04_L01
M04_L00:
       mov       rax,1F754173020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M04_L02
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B12E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M04_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFED0B20568]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFED0790508
       call      qword ptr [7FFED0B20508]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFED0790510
       call      qword ptr [7FFED0B20510]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,1585FEE14D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFED0B07838]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFED0B07840]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,1587FEE8350
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1587FEE8358
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF2FD05AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
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
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFF2FD04AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2FD05AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFF2FD01340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFF2FCFFDC0]
       call      qword ptr [7FFF2FCFFDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFF2FCF9248]
       int       3
M03_L17:
       xor       eax,eax
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
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFF2FCFD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFF2FCFFDC8]
       call      qword ptr [7FFF2FCFFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFF2FD00578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       test      rax,rax
       jne       short M04_L01
M04_L00:
       mov       rax,1587FEE3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M04_L02
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B22E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M04_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFED0B0FF08]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFED0780508
       call      qword ptr [7FFED0B10508]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFED0780510
       call      qword ptr [7FFED0B10510]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,245A09CA8C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFED0AF7838]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFED0AF7840]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,245A09C8350
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,245A09C8358
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF2FD05AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
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
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFF2FD04AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2FD05AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFF2FD01340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFF2FCFFDC0]
       call      qword ptr [7FFF2FCFFDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFF2FCF9248]
       int       3
M03_L17:
       xor       eax,eax
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
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFF2FCFD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFF2FCFFDC8]
       call      qword ptr [7FFF2FCFFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFF2FD00578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       test      rax,rax
       jne       short M04_L01
M04_L00:
       mov       rax,245A09C3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M04_L02
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B12E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M04_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFED0B30978]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFED07A0508
       call      qword ptr [7FFED0B30508]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFED07A0510
       call      qword ptr [7FFED0B30510]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,1F56B54B0E0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFED0B17838]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFED0B17840]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,1F56B548350
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1F56B548358
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF2FD05AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
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
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFF2FD04AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2FD05AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFF2FD01340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFF2FCFFDC0]
       call      qword ptr [7FFF2FCFFDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFF2FCF9248]
       int       3
M03_L17:
       xor       eax,eax
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
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFF2FCFD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFF2FCFFDC8]
       call      qword ptr [7FFF2FCFFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFF2FD00578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       test      rax,rax
       jne       short M04_L01
M04_L00:
       mov       rax,1F56B543020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M04_L02
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B32E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M04_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFED0B40568]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFED07B0508
       call      qword ptr [7FFED0B40508]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFED07B0510
       call      qword ptr [7FFED0B40510]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,2080BEA54A8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFED0B27838]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFED0B27840]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,2080BEA3F48
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2080BEA3F50
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF2FD05AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
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
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFF2FD04AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2FD05AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFF2FD01340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFF2FCFFDC0]
       call      qword ptr [7FFF2FCFFDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFF2FCF9248]
       int       3
M03_L17:
       xor       eax,eax
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
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFF2FCFD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFF2FCFFDC8]
       call      qword ptr [7FFF2FCFFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFF2FD00578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       test      rax,rax
       jne       short M04_L01
M04_L00:
       mov       rax,2081BEA3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M04_L02
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B42E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M04_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFED0B30998]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFED07A0508
       call      qword ptr [7FFED0B30508]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFED07A0510
       call      qword ptr [7FFED0B30510]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,185007B14D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFED0B17838]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFED0B17840]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,185207B8350
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,185207B8358
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF2FD05AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
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
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFF2FD04AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2FD05AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFF2FD01340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFF2FCFFDC0]
       call      qword ptr [7FFF2FCFFDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFF2FCF9248]
       int       3
M03_L17:
       xor       eax,eax
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
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFF2FCFD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFF2FCFFDC8]
       call      qword ptr [7FFF2FCFFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFF2FD00578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       test      rax,rax
       jne       short M04_L01
M04_L00:
       mov       rax,185207B3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M04_L02
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B32E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M04_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFED0B30978]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFED07A0508
       call      qword ptr [7FFED0B30508]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFED07A0510
       call      qword ptr [7FFED0B30510]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,18E4EDFA8C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFED0B17838]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFED0B17840]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,18E4EDF8350
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,18E4EDF8358
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF2FD05AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
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
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFF2FD04AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF2FD05AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFF2FD01340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFF2FCFFDC0]
       call      qword ptr [7FFF2FCFFDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFF2FD00588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFF2FCF9248]
       int       3
M03_L17:
       xor       eax,eax
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
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFF2FCFD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFF2FCFFDC8]
       call      qword ptr [7FFF2FCFFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFF2FD00578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>)
       test      rax,rax
       jne       short M04_L01
M04_L00:
       mov       rax,18E4EDF3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       imul      edx,eax,0A
       jo        near ptr M04_L02
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ForEach(System.Action`1<Byte>)
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B32E80]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M04_L02
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M01_L00
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L00:
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[7FFED0B13FC0]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
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
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,1E3202531D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
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
       mov       rdx,1E3002560F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L04
       mov       rdx,1E320251568
       mov       r14,[rdx]
       mov       rdx,1E300256100
       mov       r15,[rdx]
M02_L03:
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
       jo        short M02_L07
       cmp       ebp,ebx
       jg        short M02_L03
M02_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFED0B12E80]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
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
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M01_L00
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L00:
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[7FFED0B23FC0]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
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
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,227E0E631D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
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
       mov       rdx,227C0E658E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L04
       mov       rdx,227E0E61568
       mov       r14,[rdx]
       mov       rdx,227C0E658E8
       mov       r15,[rdx]
M02_L03:
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
       jo        short M02_L07
       cmp       ebp,ebx
       jg        short M02_L03
M02_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFED0B22E80]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
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
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M01_L00
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L00:
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[7FFED0B43FC0]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
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
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,1F51AF131D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
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
       mov       rdx,1F4FAF12920
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L04
       mov       rdx,1F51AF11568
       mov       r14,[rdx]
       mov       rdx,1F4FAF12928
       mov       r15,[rdx]
M02_L03:
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
       jo        short M02_L07
       cmp       ebp,ebx
       jg        short M02_L03
M02_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFED0B42E80]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
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
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M01_L00
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L00:
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[7FFED0B13FC0]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
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
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,270FD4531D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
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
       mov       rdx,270FD455D10
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L04
       mov       rdx,270FD451568
       mov       r14,[rdx]
       mov       rdx,270FD455D18
       mov       r15,[rdx]
M02_L03:
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
       jo        short M02_L07
       cmp       ebp,ebx
       jg        short M02_L03
M02_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFED0B12E80]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
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
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M01_L00
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L00:
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[7FFED0B13FC0]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
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
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,2005DC331D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
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
       mov       rdx,2003DC31908
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L04
       mov       rdx,2005DC31568
       mov       r14,[rdx]
       mov       rdx,2003DC31910
       mov       r15,[rdx]
M02_L03:
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
       jo        short M02_L07
       cmp       ebp,ebx
       jg        short M02_L03
M02_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFED0B12E80]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
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
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M01_L00
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L00:
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[7FFED0B13FC0]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
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
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,22253A531D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
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
       mov       rdx,22233A51908
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L04
       mov       rdx,22253A51568
       mov       r14,[rdx]
       mov       rdx,22233A51910
       mov       r15,[rdx]
M02_L03:
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
       jo        short M02_L07
       cmp       ebp,ebx
       jg        short M02_L03
M02_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFED0B12E80]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
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
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M01_L00
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L00:
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[7FFED0B03FC0]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
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
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,1CEBD3731D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
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
       mov       rdx,1CE9D372920
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L04
       mov       rdx,1CEBD371568
       mov       r14,[rdx]
       mov       rdx,1CE9D372928
       mov       r15,[rdx]
M02_L03:
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
       jo        short M02_L07
       cmp       ebp,ebx
       jg        short M02_L03
M02_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFED0B02E80]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
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
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M01_L00
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L00:
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[7FFED0B43FC0]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
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
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,295E1CF31D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
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
       mov       rdx,295E1CFA500
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L04
       mov       rdx,295E1CF1568
       mov       r14,[rdx]
       mov       rdx,295E1CFA508
       mov       r15,[rdx]
M02_L03:
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
       jo        short M02_L07
       cmp       ebp,ebx
       jg        short M02_L03
M02_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFED0B42E80]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
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
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M01_L00
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L00:
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[7FFED0B33FC0]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
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
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,187BBB631D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L02:
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
       mov       rdx,187BBB65D10
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L04
       mov       rdx,187BBB61568
       mov       r14,[rdx]
       mov       rdx,187BBB65D18
       mov       r15,[rdx]
M02_L03:
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
       jo        short M02_L07
       cmp       ebp,ebx
       jg        short M02_L03
M02_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L06:
       mov       rcx,rdi
       call      qword ptr [7FFED0B32E80]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
```

