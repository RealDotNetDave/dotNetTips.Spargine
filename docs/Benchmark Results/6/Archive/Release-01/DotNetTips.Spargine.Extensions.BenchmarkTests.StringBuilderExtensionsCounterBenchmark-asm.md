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
       push      rbx
       sub       rsp,20
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
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rbx,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF1CE6A8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
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
       mov       rdx,[rax]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1D78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 211
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
       mov       r11,7FFAAEDF04D8
       call      qword ptr [7FFAAF1D04D8]
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
       mov       r11,7FFAAEDF04E0
       call      qword ptr [7FFAAF1D04E0]
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
       mov       r9,2116B4E3538
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1B7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1B76A0]
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
       mov       rdx,2116B4DB850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2116B4DB858
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2116B4D31D8
       mov       r8,[r8]
       mov       rdx,2116B4D3020
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       rdi,rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,2116B4D3020
       mov       rbx,[rax]
       mov       rax,2116B4E3970
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rdx,2116B4E3978
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L02
       mov       rdx,2116B4D1568
       mov       r14,[rdx]
       mov       rdx,2116B4E3980
       mov       r15,[rdx]
M04_L01:
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
       jo        short M04_L05
       cmp       ebp,ebx
       jg        short M04_L01
M04_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M05_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M05_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M05_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rax,2116B4D3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFAAEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEDE4000
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
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

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
       push      rbx
       sub       rsp,20
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
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rbx,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF1EE598]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
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
       mov       rdx,[rax]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 211
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
       mov       r11,7FFAAEE104D8
       call      qword ptr [7FFAAF1F04D8]
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
       mov       r11,7FFAAEE104E0
       call      qword ptr [7FFAAF1F04E0]
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
       mov       r9,24A98DEF130
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1D7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1D76A0]
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
       mov       rdx,24A98DE7448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,24A98DE7450
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,24A78DE31D8
       mov       r8,[r8]
       mov       rdx,24A78DE3020
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       rdi,rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,24A78DE3020
       mov       rbx,[rax]
       mov       rax,24A98DEF568
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rdx,24A98DEF570
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L02
       mov       rdx,24A78DE1568
       mov       r14,[rdx]
       mov       rdx,24A98DEF578
       mov       r15,[rdx]
M04_L01:
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
       jo        short M04_L05
       cmp       ebp,ebx
       jg        short M04_L01
M04_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M05_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M05_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M05_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rax,24A78DE3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

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
       push      rbx
       sub       rsp,20
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
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rbx,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF1FE6A8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
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
       mov       rdx,[rax]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF2078C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 211
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
       mov       r11,7FFAAEE204D8
       call      qword ptr [7FFAAF2004D8]
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
       mov       r11,7FFAAEE204E0
       call      qword ptr [7FFAAF2004E0]
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
       mov       r9,198A72F24E8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E76A0]
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
       mov       rdx,198D72F7448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,198D72F7450
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,198B72F11E0
       mov       r8,[r8]
       mov       rdx,198B72F1028
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       rdi,rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,198B72F1028
       mov       rbx,[rax]
       mov       rax,198A72F2920
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rdx,198A72F2928
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L02
       mov       rdx,198C72F1568
       mov       r14,[rdx]
       mov       rdx,198A72F2930
       mov       r15,[rdx]
M04_L01:
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
       jo        short M04_L05
       cmp       ebp,ebx
       jg        short M04_L01
M04_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M05_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M05_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M05_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rax,198B72F1028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFAAEE14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE14000
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
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

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
       push      rbx
       sub       rsp,20
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
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rbx,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF1EE568]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
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
       mov       rdx,[rax]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 211
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
       mov       r11,7FFAAEE104D8
       call      qword ptr [7FFAAF1F04D8]
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
       mov       r11,7FFAAEE104E0
       call      qword ptr [7FFAAF1F04E0]
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
       mov       r9,233655714D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1D7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1D76A0]
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
       mov       rdx,23355577448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,23355577450
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,233355731D8
       mov       r8,[r8]
       mov       rdx,23335573020
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       rdi,rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,23335573020
       mov       rbx,[rax]
       mov       rax,23365571908
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rdx,23365571910
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L02
       mov       rdx,23335571568
       mov       r14,[rdx]
       mov       rdx,23365571918
       mov       r15,[rdx]
M04_L01:
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
       jo        short M04_L05
       cmp       ebp,ebx
       jg        short M04_L01
M04_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M05_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M05_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M05_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rax,23335573020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

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
       push      rbx
       sub       rsp,20
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
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rbx,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF1EE598]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
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
       mov       rdx,[rax]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 211
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
       mov       r11,7FFAAEE104D8
       call      qword ptr [7FFAAF1F04D8]
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
       mov       r11,7FFAAEE104E0
       call      qword ptr [7FFAAF1F04E0]
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
       mov       r9,121CC4C14D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1D7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1D76A0]
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
       mov       rdx,121EC4CB850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,121EC4CB858
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,121EC4C31D8
       mov       r8,[r8]
       mov       rdx,121EC4C3020
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       rdi,rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,121EC4C3020
       mov       rbx,[rax]
       mov       rax,121CC4C1908
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rdx,121CC4C1910
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L02
       mov       rdx,121EC4C1568
       mov       r14,[rdx]
       mov       rdx,121CC4C1918
       mov       r15,[rdx]
M04_L01:
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
       jo        short M04_L05
       cmp       ebp,ebx
       jg        short M04_L01
M04_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M05_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M05_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M05_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rax,121EC4C3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

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
       push      rbx
       sub       rsp,20
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
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rbx,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF1FE568]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
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
       mov       rdx,[rax]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF2078C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 211
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
       mov       r11,7FFAAEE204D8
       call      qword ptr [7FFAAF2004D8]
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
       mov       r11,7FFAAEE204E0
       call      qword ptr [7FFAAF2004E0]
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
       mov       r9,13CC8DE3538
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E76A0]
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
       mov       rdx,13CC8DDB850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,13CC8DDB858
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,13CC8DD31D8
       mov       r8,[r8]
       mov       rdx,13CC8DD3020
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       rdi,rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,13CC8DD3020
       mov       rbx,[rax]
       mov       rax,13CC8DE3970
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rdx,13CC8DE3978
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L02
       mov       rdx,13CC8DD1568
       mov       r14,[rdx]
       mov       rdx,13CC8DE3980
       mov       r15,[rdx]
M04_L01:
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
       jo        short M04_L05
       cmp       ebp,ebx
       jg        short M04_L01
M04_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M05_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M05_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M05_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rax,13CC8DD3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFAAEE14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE14000
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
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

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
       push      rbx
       sub       rsp,20
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
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rbx,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF1EE598]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
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
       mov       rdx,[rax]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 211
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
       mov       r11,7FFAAEE104D8
       call      qword ptr [7FFAAF1F04D8]
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
       mov       r11,7FFAAEE104E0
       call      qword ptr [7FFAAF1F04E0]
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
       mov       r9,1D7972958D8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1D7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1D76A0]
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
       mov       rdx,1D7C7297448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1D7C7297450
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1D7972931D8
       mov       r8,[r8]
       mov       rdx,1D797293020
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       rdi,rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,1D797293020
       mov       rbx,[rax]
       mov       rax,1D797295D10
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rdx,1D797295D18
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L02
       mov       rdx,1D797291568
       mov       r14,[rdx]
       mov       rdx,1D797295D20
       mov       r15,[rdx]
M04_L01:
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
       jo        short M04_L05
       cmp       ebp,ebx
       jg        short M04_L01
M04_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M05_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M05_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M05_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rax,1D797293020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

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
       push      rbx
       sub       rsp,20
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
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rbx,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF1DE6A8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
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
       mov       rdx,[rax]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1E78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 211
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
       mov       r11,7FFAAEE004D8
       call      qword ptr [7FFAAF1E04D8]
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
       mov       r11,7FFAAEE004E0
       call      qword ptr [7FFAAF1E04E0]
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
       mov       r9,29EA37814D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1C7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1C76A0]
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
       mov       rdx,29EC378B850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,29EC378B858
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,29EC37831D8
       mov       r8,[r8]
       mov       rdx,29EC3783020
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       rdi,rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,29EC3783020
       mov       rbx,[rax]
       mov       rax,29EA3781908
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rdx,29EA3781910
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L02
       mov       rdx,29EC3781568
       mov       r14,[rdx]
       mov       rdx,29EA3781918
       mov       r15,[rdx]
M04_L01:
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
       jo        short M04_L05
       cmp       ebp,ebx
       jg        short M04_L01
M04_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M05_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M05_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M05_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rax,29EC3783020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFAAEDF4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEDF4000
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
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

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
       push      rbx
       sub       rsp,20
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
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rbx,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF1DE598]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
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
       mov       rdx,[rax]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1E78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 211
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
       mov       r11,7FFAAEE004D8
       call      qword ptr [7FFAAF1E04D8]
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
       mov       r11,7FFAAEE004E0
       call      qword ptr [7FFAAF1E04E0]
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
       mov       r9,17DD3FC24E8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1C7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1C76A0]
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
       mov       rdx,17DF3FCB850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,17DF3FCB858
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,17DF3FC31D8
       mov       r8,[r8]
       mov       rdx,17DF3FC3020
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.Byte, System.Private.CoreLib]](Byte[], System.String, System.String)
       mov       rdi,rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,17DF3FC3020
       mov       rbx,[rax]
       mov       rax,17DD3FC2920
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rdx,17DD3FC2928
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L02
       mov       rdx,17DF3FC1568
       mov       r14,[rdx]
       mov       rdx,17DD3FC2930
       mov       r15,[rdx]
M04_L01:
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
       jo        short M04_L05
       cmp       ebp,ebx
       jg        short M04_L01
M04_L02:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L03
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L04:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 292
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M05_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M05_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M05_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rax,17DF3FC3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFAAEDF4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEDF4000
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
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

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
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
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
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
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
; Total bytes of code 188
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,20AEDB82EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1F80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1F29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,20AEDB832F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,20AEDB832F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,20AEDB83020
       mov       r15,[rax]
       mov       rax,20AEDB92140
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       je        short M02_L01
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,20B0DB81700
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L03:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rdi,rdi
       je        short M02_L04
       cmp       dword ptr [rdi+8],0
       je        short M02_L04
       xor       eax,eax
       jmp       short M02_L05
M02_L04:
       mov       eax,1
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,20AEDB83268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L06:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,20AEDB92148
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L07:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,20AEDB92150
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L08:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L09
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L10:
       cmp       ebx,0FFFFFFFF
       je        short M02_L11
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L21
M02_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L12
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L13:
       xor       ebx,ebx
       mov       rcx,7FFAAF26C9D0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L14:
       mov       r9,20AEDB8BEB8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L19
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L25
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L15
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L16:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L17
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L18:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L25
       jmp       near ptr M02_L14
M02_L19:
       sub       ebp,ebx
       jo        near ptr M02_L25
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
       jbe       short M02_L20
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L22
M02_L20:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L22:
       cmp       r14d,0FFFFFFFF
       je        short M02_L23
       cmp       r14d,0FFFFFFFE
       jne       short M02_L24
M02_L23:
       mov       rdx,20B0DB815E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L24:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
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
       mov       rax,20AEDB83020
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
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
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
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
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
; Total bytes of code 188
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,22B2A802EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1F80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1F29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,22B2A8032F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,22B2A8032F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,22B2A803020
       mov       r15,[rax]
       mov       rax,22B4A802120
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       je        short M02_L01
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,22B4A801700
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L03:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rdi,rdi
       je        short M02_L04
       cmp       dword ptr [rdi+8],0
       je        short M02_L04
       xor       eax,eax
       jmp       short M02_L05
M02_L04:
       mov       eax,1
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,22B2A803268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L06:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,22B4A802128
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L07:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,22B4A802130
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L08:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L09
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L10:
       cmp       ebx,0FFFFFFFF
       je        short M02_L11
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L21
M02_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L12
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L13:
       xor       ebx,ebx
       mov       rcx,7FFAAF26C9D0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L14:
       mov       r9,22B5A807AB0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L19
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L25
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L15
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L16:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L17
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L18:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L25
       jmp       near ptr M02_L14
M02_L19:
       sub       ebp,ebx
       jo        near ptr M02_L25
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
       jbe       short M02_L20
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L22
M02_L20:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L22:
       cmp       r14d,0FFFFFFFF
       je        short M02_L23
       cmp       r14d,0FFFFFFFE
       jne       short M02_L24
M02_L23:
       mov       rdx,22B4A8015E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L24:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
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
       mov       rax,22B2A803020
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
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
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
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
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
; Total bytes of code 188
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1F7F1612EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1F80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1F29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,1F7F16132F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1F7F16132F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,1F7F1613020
       mov       r15,[rax]
       mov       rax,1F7D1612920
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       je        short M02_L01
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,1F7F1621F38
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L03:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rdi,rdi
       je        short M02_L04
       cmp       dword ptr [rdi+8],0
       je        short M02_L04
       xor       eax,eax
       jmp       short M02_L05
M02_L04:
       mov       eax,1
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,1F7F1613268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L06:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1F7D1612928
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L07:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1F7D1612930
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L08:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L09
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L10:
       cmp       ebx,0FFFFFFFF
       je        short M02_L11
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L21
M02_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L12
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L13:
       xor       ebx,ebx
       mov       rcx,7FFAAF26C9D0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L14:
       mov       r9,1F7F161BEB8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L19
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L25
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L15
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L16:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L17
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L18:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L25
       jmp       near ptr M02_L14
M02_L19:
       sub       ebp,ebx
       jo        near ptr M02_L25
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
       jbe       short M02_L20
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L22
M02_L20:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L22:
       cmp       r14d,0FFFFFFFF
       je        short M02_L23
       cmp       r14d,0FFFFFFFE
       jne       short M02_L24
M02_L23:
       mov       rdx,1F7F1621E20
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L24:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
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
       mov       rax,1F7F1613020
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
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
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
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1D78C0]
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
; Total bytes of code 188
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,17F127A2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1D80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1D29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,17F127A32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,17F127A32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,17F127A3020
       mov       r15,[rax]
       mov       rax,17F127A3D18
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       je        short M02_L01
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,17F327A1700
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L03:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rdi,rdi
       je        short M02_L04
       cmp       dword ptr [rdi+8],0
       je        short M02_L04
       xor       eax,eax
       jmp       short M02_L05
M02_L04:
       mov       eax,1
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,17F127A3268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L06:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,17F127A3D20
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L07:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,17F127A3D28
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L08:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L09
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L10:
       cmp       ebx,0FFFFFFFF
       je        short M02_L11
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L21
M02_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L12
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L13:
       xor       ebx,ebx
       mov       rcx,7FFAAF24C9D0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L14:
       mov       r9,17F427A7AB0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L19
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L25
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L15
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L16:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L17
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L18:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L25
       jmp       near ptr M02_L14
M02_L19:
       sub       ebp,ebx
       jo        near ptr M02_L25
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
       jbe       short M02_L20
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L22
M02_L20:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L22:
       cmp       r14d,0FFFFFFFF
       je        short M02_L23
       cmp       r14d,0FFFFFFFE
       jne       short M02_L24
M02_L23:
       mov       rdx,17F327A15E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L24:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
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
       mov       rax,17F127A3020
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
       mov       rdx,7FFAAEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEDE4000
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
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
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
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF2078C0]
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
; Total bytes of code 188
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,151C94D2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF2080E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF2029C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,151C94D32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,151C94D32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,151C94D3020
       mov       r15,[rax]
       mov       rax,151C94E2958
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       je        short M02_L01
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,151C94E1F38
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L03:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rdi,rdi
       je        short M02_L04
       cmp       dword ptr [rdi+8],0
       je        short M02_L04
       xor       eax,eax
       jmp       short M02_L05
M02_L04:
       mov       eax,1
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,151C94D3268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L06:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,151C94E2960
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L07:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,151C94E2968
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L08:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L09
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L10:
       cmp       ebx,0FFFFFFFF
       je        short M02_L11
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L21
M02_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L12
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L13:
       xor       ebx,ebx
       mov       rcx,7FFAAF27C9D0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L14:
       mov       r9,151C94DBEB8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L19
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L25
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L15
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L16:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L17
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L18:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L25
       jmp       near ptr M02_L14
M02_L19:
       sub       ebp,ebx
       jo        near ptr M02_L25
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
       jbe       short M02_L20
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L22
M02_L20:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L22:
       cmp       r14d,0FFFFFFFF
       je        short M02_L23
       cmp       r14d,0FFFFFFFE
       jne       short M02_L24
M02_L23:
       mov       rdx,151C94E1E20
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L24:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
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
       mov       rax,151C94D3020
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
       mov       rdx,7FFAAEE14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE14000
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
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
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
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
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
; Total bytes of code 188
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,2B42DF12EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1F80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1F29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,2B42DF132F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,2B42DF132F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,2B42DF13020
       mov       r15,[rax]
       mov       rax,2B42DF23970
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       je        short M02_L01
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,2B42DF21F38
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L03:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rdi,rdi
       je        short M02_L04
       cmp       dword ptr [rdi+8],0
       je        short M02_L04
       xor       eax,eax
       jmp       short M02_L05
M02_L04:
       mov       eax,1
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,2B42DF13268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L06:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,2B42DF23978
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L07:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,2B42DF23980
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L08:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L09
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L10:
       cmp       ebx,0FFFFFFFF
       je        short M02_L11
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L21
M02_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L12
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L13:
       xor       ebx,ebx
       mov       rcx,7FFAAF26C9D0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L14:
       mov       r9,2B42DF1BEB8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L19
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L25
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L15
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L16:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L17
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L18:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L25
       jmp       near ptr M02_L14
M02_L19:
       sub       ebp,ebx
       jo        near ptr M02_L25
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
       jbe       short M02_L20
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L22
M02_L20:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L22:
       cmp       r14d,0FFFFFFFF
       je        short M02_L23
       cmp       r14d,0FFFFFFFE
       jne       short M02_L24
M02_L23:
       mov       rdx,2B42DF21E20
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L24:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
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
       mov       rax,2B42DF13020
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
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
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
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1D78C0]
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
; Total bytes of code 188
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,16476BE2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1D80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1D29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,16476BE32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,16476BE32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,16476BE3020
       mov       r15,[rax]
       mov       rax,16476BF3158
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       je        short M02_L01
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,16496BE1700
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L03:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rdi,rdi
       je        short M02_L04
       cmp       dword ptr [rdi+8],0
       je        short M02_L04
       xor       eax,eax
       jmp       short M02_L05
M02_L04:
       mov       eax,1
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,16476BE3268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L06:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,16476BF3160
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L07:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,16476BF3168
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L08:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L09
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L10:
       cmp       ebx,0FFFFFFFF
       je        short M02_L11
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L21
M02_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L12
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L13:
       xor       ebx,ebx
       mov       rcx,7FFAAF24C9D0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L14:
       mov       r9,16476BEBEB8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L19
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L25
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L15
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L16:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L17
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L18:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L25
       jmp       near ptr M02_L14
M02_L19:
       sub       ebp,ebx
       jo        near ptr M02_L25
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
       jbe       short M02_L20
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L22
M02_L20:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L22:
       cmp       r14d,0FFFFFFFF
       je        short M02_L23
       cmp       r14d,0FFFFFFFE
       jne       short M02_L24
M02_L23:
       mov       rdx,16496BE15E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L24:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
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
       mov       rax,16476BE3020
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
       mov       rdx,7FFAAEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEDE4000
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
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
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
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF2178C0]
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
; Total bytes of code 188
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,19918D02EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF2180E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF2129C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,19918D032F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,19918D032F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,19918D03020
       mov       r15,[rax]
       mov       rax,198F8D02920
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       je        short M02_L01
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,19918D11F38
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L03:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rdi,rdi
       je        short M02_L04
       cmp       dword ptr [rdi+8],0
       je        short M02_L04
       xor       eax,eax
       jmp       short M02_L05
M02_L04:
       mov       eax,1
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,19918D03268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L06:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,198F8D02928
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L07:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,198F8D02930
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L08:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L09
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L10:
       cmp       ebx,0FFFFFFFF
       je        short M02_L11
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L21
M02_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L12
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L13:
       xor       ebx,ebx
       mov       rcx,7FFAAF28C9D0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L14:
       mov       r9,19918D0BEB8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L19
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L25
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L15
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L16:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L17
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L18:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L25
       jmp       near ptr M02_L14
M02_L19:
       sub       ebp,ebx
       jo        near ptr M02_L25
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
       jbe       short M02_L20
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L22
M02_L20:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L22:
       cmp       r14d,0FFFFFFFF
       je        short M02_L23
       cmp       r14d,0FFFFFFFE
       jne       short M02_L24
M02_L23:
       mov       rdx,19918D11E20
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L24:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
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
       mov       rax,19918D03020
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
       mov       rdx,7FFAAEE24000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE24000
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
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
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
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
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
; Total bytes of code 188
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,22B664A2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1F80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1F29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,22B664A32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,22B664A32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,22B664A3020
       mov       r15,[rax]
       mov       rax,22B964ADD38
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       je        short M02_L01
       xor       eax,eax
       jmp       short M02_L02
M02_L01:
       mov       eax,1
M02_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,22B864A1700
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L03:
       cmp       [rbp],ebp
       mov       rcx,rbp
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       test      rdi,rdi
       je        short M02_L04
       cmp       dword ptr [rdi+8],0
       je        short M02_L04
       xor       eax,eax
       jmp       short M02_L05
M02_L04:
       mov       eax,1
M02_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,22B664A3268
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L06:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r12,rax
       mov       rcx,r12
       mov       [r15+8],ebx
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,22B964ADD40
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L07:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,22B964ADD48
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L08:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L09
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L10:
       cmp       ebx,0FFFFFFFF
       je        short M02_L11
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L21
M02_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L12
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L13:
       xor       ebx,ebx
       mov       rcx,7FFAAF26C9D0
       mov       edx,2D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L14:
       mov       r9,22B964A7AB0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L19
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L25
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L15
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L16:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L17
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L18:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L25
       jmp       near ptr M02_L14
M02_L19:
       sub       ebp,ebx
       jo        near ptr M02_L25
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
       jbe       short M02_L20
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L22
M02_L20:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L22
M02_L21:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L22:
       cmp       r14d,0FFFFFFFF
       je        short M02_L23
       cmp       r14d,0FFFFFFFE
       jne       short M02_L24
M02_L23:
       mov       rdx,22B864A15E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L24:
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
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
       mov       rax,22B664A3020
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
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,2A84AF71E20
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF2078C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,2A84AF62EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF2080E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF2029C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,2A84AF632F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,2A84AF632F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,2A84AF63020
       mov       r14,[rax]
       mov       rax,2A82AF62920
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,2A84AF71E30
       mov       r8,[r9]
       mov       r9,r8
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 272
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
       mov       rax,2A84AF63020
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
       mov       rdx,7FFAAEE14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE14000
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,1BDBCF71E20
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1E78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1BDBCF62EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1E80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1E29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,1BDBCF632F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1BDBCF632F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,1BDBCF63020
       mov       r14,[rax]
       mov       rax,1BD9CF61908
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1BDBCF71E30
       mov       r8,[r9]
       mov       r9,r8
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 272
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
       mov       rax,1BDBCF63020
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
       mov       rdx,7FFAAEDF4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEDF4000
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,1C493A01E20
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1D78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1C4939F2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1D80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1D29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,1C4939F32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1C4939F32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,1C4939F3020
       mov       r14,[rax]
       mov       rax,1C493A02958
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1C493A01E30
       mov       r8,[r9]
       mov       r9,r8
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 272
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
       mov       rax,1C4939F3020
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
       mov       rdx,7FFAAEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEDE4000
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,1A3A3FF15E8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1A383FF2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1F80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1F29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,1A383FF32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1A383FF32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,1A383FF3020
       mov       r14,[rax]
       mov       rax,1A383FF5D10
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1A3A3FF15F8
       mov       r8,[r9]
       mov       r9,r8
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 272
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
       mov       rax,1A383FF3020
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
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,193284B1E20
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,193284A2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1F80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1F29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,193284A32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,193284A32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,193284A3020
       mov       r14,[rax]
       mov       rax,193284B2958
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,193284B1E30
       mov       r8,[r9]
       mov       r9,r8
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 272
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
       mov       rax,193284A3020
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
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,23213E815E8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1E78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,231F3E82EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1E80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1E29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,231F3E832F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,231F3E832F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,231F3E83020
       mov       r14,[rax]
       mov       rax,231F3E86D28
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,23213E815F8
       mov       r8,[r9]
       mov       r9,r8
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 272
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
       mov       rax,231F3E83020
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
       mov       rdx,7FFAAEDF4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEDF4000
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,212A39CFE28
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,212839C2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1F80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1F29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,212A39C1300
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,212A39C1300
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,212A39C1028
       mov       r14,[rax]
       mov       rax,212A39D0960
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,212A39CFE38
       mov       r8,[r9]
       mov       r9,r8
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 272
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
       mov       rax,212A39C1028
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
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,1BE97111E20
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF2078C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1BE97102EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF2080E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF2029C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,1BE971032F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1BE971032F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,1BE97103020
       mov       r14,[rax]
       mov       rax,1BE97113970
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1BE97111E30
       mov       r8,[r9]
       mov       r9,r8
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 272
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
       mov       rax,1BE97103020
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
       mov       rdx,7FFAAEE14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE14000
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,1A9DF3AFE28
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       esi,1
M01_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       edi,ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1A9BF3A2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAAF1F80E0]
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M01_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M01_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M01_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M01_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M01_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAAF1F29C0]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L09:
       mov       rdx,1A9DF3A1300
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1A9DF3A1300
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L06
M01_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L00
       mov       rax,1A9DF3A1028
       mov       r14,[rax]
       mov       rax,1A9BF3A3900
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1A9DF3AFE38
       mov       r8,[r9]
       mov       r9,r8
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(!!0[], System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 272
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
       mov       rax,1A9DF3A1028
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
       mov       rdx,7FFAAEE04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFAAEE04000
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFAAF1EE4A0]
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
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
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
; Total bytes of code 140
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
       mov       r11,7FFAAEE104D8
       call      qword ptr [7FFAAF1F04D8]
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
       mov       r11,7FFAAEE104E0
       call      qword ptr [7FFAAF1F04E0]
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
       mov       r9,283F7D434C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1D7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1D76A0]
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
       mov       rdx,28407D49440
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,28407D49448
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
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
       je        short M04_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M04_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M04_L01
M04_L00:
       xor       eax,eax
M04_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M04_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,283E7D411E0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L02:
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
       mov       rdx,283F7D43900
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L04
       mov       rdx,283F7D41568
       mov       r14,[rdx]
       mov       rdx,283F7D43908
       mov       r15,[rdx]
M04_L03:
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
       jo        short M04_L07
       cmp       ebp,ebx
       jg        short M04_L03
M04_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L06
M04_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L06:
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFAAF1FE2B0]
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
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
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
; Total bytes of code 140
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
       mov       r11,7FFAAEE204D8
       call      qword ptr [7FFAAF2004D8]
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
       mov       r11,7FFAAEE204E0
       call      qword ptr [7FFAAF2004E0]
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
       mov       r9,1909B313538
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E76A0]
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
       mov       rdx,1909B30B850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1909B30B858
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
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
       je        short M04_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M04_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M04_L01
M04_L00:
       xor       eax,eax
M04_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M04_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,1909B3031D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L02:
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
       mov       rdx,1909B313970
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L04
       mov       rdx,1909B301568
       mov       r14,[rdx]
       mov       rdx,1909B313978
       mov       r15,[rdx]
M04_L03:
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
       jo        short M04_L07
       cmp       ebp,ebx
       jg        short M04_L03
M04_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L06
M04_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L06:
       mov       rcx,rdi
       call      qword ptr [7FFAAF2078C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFAAF1FE3A0]
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
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
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
; Total bytes of code 140
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
       mov       r11,7FFAAEE204D8
       call      qword ptr [7FFAAF2004D8]
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
       mov       r11,7FFAAEE204E0
       call      qword ptr [7FFAAF2004E0]
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
       mov       r9,1CCC00068F0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E76A0]
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
       mov       rdx,1CCF0007448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1CCF0007450
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
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
       je        short M04_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M04_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M04_L01
M04_L00:
       xor       eax,eax
M04_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M04_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,1CCC00031D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L02:
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
       mov       rdx,1CCC0006D28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L04
       mov       rdx,1CCC0001568
       mov       r14,[rdx]
       mov       rdx,1CCC0006D30
       mov       r15,[rdx]
M04_L03:
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
       jo        short M04_L07
       cmp       ebp,ebx
       jg        short M04_L03
M04_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L06
M04_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L06:
       mov       rcx,rdi
       call      qword ptr [7FFAAF2078C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFAAF1EE3C0]
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
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
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
; Total bytes of code 140
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
       mov       r11,7FFAAEE104D8
       call      qword ptr [7FFAAF1F04D8]
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
       mov       r11,7FFAAEE104E0
       call      qword ptr [7FFAAF1F04E0]
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
       mov       r9,272F03668F0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1D7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1D76A0]
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
       mov       rdx,27320367448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,27320367450
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
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
       je        short M04_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M04_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M04_L01
M04_L00:
       xor       eax,eax
M04_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M04_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,272F03631D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L02:
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
       mov       rdx,272F0366D28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L04
       mov       rdx,272F0361568
       mov       r14,[rdx]
       mov       rdx,272F0366D30
       mov       r15,[rdx]
M04_L03:
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
       jo        short M04_L07
       cmp       ebp,ebx
       jg        short M04_L03
M04_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L06
M04_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L06:
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFAAF1DE3B0]
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
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
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
; Total bytes of code 140
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
       mov       r11,7FFAAEE004D8
       call      qword ptr [7FFAAF1E04D8]
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
       mov       r11,7FFAAEE004E0
       call      qword ptr [7FFAAF1E04E0]
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
       mov       r9,151013E14D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1C7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1C76A0]
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
       mov       rdx,151213EB850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,151213EB858
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
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
       je        short M04_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M04_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M04_L01
M04_L00:
       xor       eax,eax
M04_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M04_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,151213E31D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L02:
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
       mov       rdx,151013E1908
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L04
       mov       rdx,151213E1568
       mov       r14,[rdx]
       mov       rdx,151013E1910
       mov       r15,[rdx]
M04_L03:
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
       jo        short M04_L07
       cmp       ebp,ebx
       jg        short M04_L03
M04_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L06
M04_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L06:
       mov       rcx,rdi
       call      qword ptr [7FFAAF1E78C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFAAF1EE3B0]
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
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
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
; Total bytes of code 140
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
       mov       r11,7FFAAEE104D8
       call      qword ptr [7FFAAF1F04D8]
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
       mov       r11,7FFAAEE104E0
       call      qword ptr [7FFAAF1F04E0]
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
       mov       r9,1DA07DEE888
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1D7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1D76A0]
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
       mov       rdx,1DA07DE73B8
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1DA07DE73C0
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
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
       je        short M04_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M04_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M04_L01
M04_L00:
       xor       eax,eax
M04_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M04_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,1DA07DE31D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L02:
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
       mov       rdx,1DA07DEECC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L04
       mov       rdx,1DA07DE1568
       mov       r14,[rdx]
       mov       rdx,1DA07DEECC8
       mov       r15,[rdx]
M04_L03:
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
       jo        short M04_L07
       cmp       ebp,ebx
       jg        short M04_L03
M04_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L06
M04_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L06:
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFAAF1FE3A0]
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
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
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
; Total bytes of code 140
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
       mov       r11,7FFAAEE204D8
       call      qword ptr [7FFAAF2004D8]
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
       mov       r11,7FFAAEE204E0
       call      qword ptr [7FFAAF2004E0]
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
       mov       r9,25DF21260F0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E76A0]
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
       mov       rdx,25DD2127448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,25DD2127450
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
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
       je        short M04_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M04_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M04_L01
M04_L00:
       xor       eax,eax
M04_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M04_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,25DF21231D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L02:
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
       mov       rdx,25DF2126528
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L04
       mov       rdx,25DF2121568
       mov       r14,[rdx]
       mov       rdx,25DF2126530
       mov       r15,[rdx]
M04_L03:
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
       jo        short M04_L07
       cmp       ebp,ebx
       jg        short M04_L03
M04_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L06
M04_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L06:
       mov       rcx,rdi
       call      qword ptr [7FFAAF2078C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFAAF1CE3C0]
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
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
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
; Total bytes of code 140
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
       mov       r11,7FFAAEDF04D8
       call      qword ptr [7FFAAF1D04D8]
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
       mov       r11,7FFAAEDF04E0
       call      qword ptr [7FFAAF1D04E0]
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
       mov       r9,2AB4C7114D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1B7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1B76A0]
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
       mov       rdx,2AB6C71B850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2AB6C71B858
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
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
       je        short M04_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M04_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M04_L01
M04_L00:
       xor       eax,eax
M04_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M04_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,2AB6C7131D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L02:
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
       mov       rdx,2AB4C711908
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L04
       mov       rdx,2AB6C711568
       mov       r14,[rdx]
       mov       rdx,2AB4C711910
       mov       r15,[rdx]
M04_L03:
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
       jo        short M04_L07
       cmp       ebp,ebx
       jg        short M04_L03
M04_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L06
M04_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L06:
       mov       rcx,rdi
       call      qword ptr [7FFAAF1D78C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFAAF1EE3B0]
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
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
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
; Total bytes of code 140
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
       mov       r11,7FFAAEE104D8
       call      qword ptr [7FFAAF1F04D8]
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
       mov       r11,7FFAAEE104E0
       call      qword ptr [7FFAAF1F04E0]
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
       mov       r9,24A81DC2520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1D7698]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1D76A0]
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
       mov       rdx,24A81DBB850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,24A81DBB858
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
       call      qword ptr [7FFB0D975AE0]
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
       call      qword ptr [7FFB0D970590]
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
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
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
       call      qword ptr [7FFB0D971340]
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
       call      qword ptr [7FFB0D970588]
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
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
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
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
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
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
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
       je        short M04_L00
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      System.Linq.Enumerable.TryGetNonEnumeratedCount[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M04_L00
       cmp       dword ptr [rsp+20],0
       setg      al
       movzx     eax,al
       jmp       short M04_L01
M04_L00:
       xor       eax,eax
M04_L01:
       movzx     eax,al
       test      eax,eax
       jne       short M04_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionSizeIsNotValid()
       mov       rcx,rax
       mov       rdx,24A81DB31D8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M04_L02:
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
       mov       rdx,24A81DC2958
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L04
       mov       rdx,24A81DB1568
       mov       r14,[rdx]
       mov       rdx,24A81DC2960
       mov       r15,[rdx]
M04_L03:
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
       jo        short M04_L07
       cmp       ebp,ebx
       jg        short M04_L03
M04_L04:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L05
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L06
M04_L05:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L06:
       mov       rcx,rdi
       call      qword ptr [7FFAAF1F78C0]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 322
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

