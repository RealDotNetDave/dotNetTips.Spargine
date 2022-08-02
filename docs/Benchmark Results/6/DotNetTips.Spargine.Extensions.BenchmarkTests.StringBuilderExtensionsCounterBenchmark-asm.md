## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB47895768]
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4789AB38]
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
       mov       r11,7FFB472407E8
       call      qword ptr [7FFB478A07E8]
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
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
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
       mov       r9,18E0E741530
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4763B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4763B240]
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
       mov       rdx,18E2E74D338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,18E2E74D340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L06
       mov       rdx,18E0E741B88
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,18E2E741568
       mov       r14,[rdx]
       mov       rdx,18E0E741B90
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,93A
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M04_L06:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 370
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
       mov       rax,18E2E743020
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
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47234000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478A5658]
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478AAB38]
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
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478B07E8]
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
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
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
       mov       r9,166F6A51530
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4764B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4764B240]
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
       mov       rdx,166E6A58F30
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,166E6A58F38
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L06
       mov       rdx,166F6A51B88
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,166D6A51568
       mov       r14,[rdx]
       mov       rdx,166F6A51B90
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,93A
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M04_L06:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 370
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
       mov       rax,166D6A53020
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
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47244000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB47895658]
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4789AB38]
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
       mov       r11,7FFB472407E8
       call      qword ptr [7FFB478A07E8]
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
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
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
       mov       r9,281C7411530
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4763B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4763B240]
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
       mov       rdx,281E7418F30
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,281E7418F38
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L06
       mov       rdx,281C7411B88
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,281D7411568
       mov       r14,[rdx]
       mov       rdx,281C7411B90
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,93A
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M04_L06:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 370
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
       mov       rax,281D7413020
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
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47234000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478B5658]
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478BAB38]
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
       mov       r11,7FFB472607E8
       call      qword ptr [7FFB478C07E8]
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
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478C07F0]
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
       mov       r9,209A9B9C070
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4765B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4765B240]
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
       mov       rdx,209C9B93010
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,209C9B93018
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L06
       mov       rdx,209A9B9C6C8
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,209A9B91568
       mov       r14,[rdx]
       mov       rdx,209A9B9C6D0
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,93A
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M04_L06:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 370
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
       mov       rax,209A9B93020
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
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47254000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478A5658]
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478AAB38]
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
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478B07E8]
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
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
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
       mov       r9,1CA99622548
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4764B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4764B240]
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
       mov       rdx,1CAB962D338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1CAB962D340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L06
       mov       rdx,1CA99622BA0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,1CAB9621568
       mov       r14,[rdx]
       mov       rdx,1CA99622BA8
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,93A
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M04_L06:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 370
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
       mov       rax,1CAB9623020
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
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47244000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478A5768]
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478AAB38]
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
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478B07E8]
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
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
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
       mov       r9,1874AD85938
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4764B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4764B240]
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
       mov       rdx,1872AD88F30
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1872AD88F38
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L06
       mov       rdx,1874AD85F90
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,1874AD81568
       mov       r14,[rdx]
       mov       rdx,1874AD85F98
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,93A
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M04_L06:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 370
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
       mov       rax,1874AD83020
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
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47244000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB47895658]
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4789AB38]
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
       mov       r11,7FFB472407E8
       call      qword ptr [7FFB478A07E8]
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
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
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
       mov       r9,1B58F223D40
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4763B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4763B240]
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
       mov       rdx,1B56F22B340
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1B56F22B348
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L06
       mov       rdx,1B58F224398
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,1B58F221568
       mov       r14,[rdx]
       mov       rdx,1B58F2243A0
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,93A
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M04_L06:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 370
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
       mov       rax,1B56F221028
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
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47234000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478B5658]
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478BAB38]
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
       mov       r11,7FFB472607E8
       call      qword ptr [7FFB478C07E8]
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
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478C07F0]
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
       mov       r9,2220B4A5020
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4765B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4765B240]
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
       mov       rdx,2220B49D338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2220B49D340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L06
       mov       rdx,2220B4A5678
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,2220B491568
       mov       r14,[rdx]
       mov       rdx,2220B4A5680
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,93A
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M04_L06:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 370
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
       mov       rax,2220B493020
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
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47254000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB47885768]
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4788AB38]
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
       mov       r11,7FFB472307E8
       call      qword ptr [7FFB478907E8]
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
       mov       r11,7FFB472307F0
       call      qword ptr [7FFB478907F0]
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
       mov       r9,23396F31530
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4762B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4762B240]
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
       mov       rdx,233A6F3D338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,233A6F3D340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       test      rdi,rdi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L05
       mov       rcx,rsi
       test      rcx,rcx
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M04_L06
       mov       rdx,23396F31B88
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,233A6F31568
       mov       r14,[rdx]
       mov       rdx,23396F31B90
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rsi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,93A
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M04_L06:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 370
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
       mov       rax,233A6F33020
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
       mov       rdx,7FFB47224000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47224000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4789AB38]
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
       mov       rcx,15FA5712EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB4789AD80]
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
       call      qword ptr [7FFB478A29C0]
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
       mov       rdx,15FA57132F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,15FA57132F8
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
       je        near ptr M02_L25
       mov       rcx,rbp
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       je        short M02_L00
       xor       eax,eax
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M02_L03
       cmp       dword ptr [rcx+8],0
       je        short M02_L03
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L05:
       cmp       [rcx],ecx
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
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,95A
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,976
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L07:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L09:
       cmp       ebx,0FFFFFFFF
       je        short M02_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L20
M02_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L12:
       xor       ebx,ebx
       mov       rcx,7FFB476D76E0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L13:
       mov       r9,15FA571DAE0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L15:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L24
       jmp       near ptr M02_L13
M02_L18:
       sub       ebp,ebx
       jo        near ptr M02_L24
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
       jbe       short M02_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L21
M02_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L21:
       cmp       r14d,0FFFFFFFF
       je        short M02_L22
       cmp       r14d,0FFFFFFFE
       jne       short M02_L23
M02_L22:
       mov       rdx,15FA5723918
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L23:
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
M02_L24:
       call      CORINFO_HELP_OVERFLOW
M02_L25:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,15FA5713020
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
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47234000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478AAB38]
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
       mov       rcx,22C13BB2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478AAD80]
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
       call      qword ptr [7FFB478B29C0]
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
       mov       rdx,22BF3BB1300
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,22BF3BB1300
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
       je        near ptr M02_L25
       mov       rcx,rbp
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       je        short M02_L00
       xor       eax,eax
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M02_L03
       cmp       dword ptr [rcx+8],0
       je        short M02_L03
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L05:
       cmp       [rcx],ecx
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
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,95A
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,976
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L07:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L09:
       cmp       ebx,0FFFFFFFF
       je        short M02_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L20
M02_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L12:
       xor       ebx,ebx
       mov       rcx,7FFB476E76E0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L13:
       mov       r9,22BF3BBBAE8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L15:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L24
       jmp       near ptr M02_L13
M02_L18:
       sub       ebp,ebx
       jo        near ptr M02_L24
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
       jbe       short M02_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L21
M02_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L21:
       cmp       r14d,0FFFFFFFF
       je        short M02_L22
       cmp       r14d,0FFFFFFFE
       jne       short M02_L23
M02_L22:
       mov       rdx,22BF3BC1920
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L23:
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
M02_L24:
       call      CORINFO_HELP_OVERFLOW
M02_L25:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,22BF3BB1028
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
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47244000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478AAB38]
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
       mov       rcx,2371C122EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478AAD80]
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
       call      qword ptr [7FFB478B29C0]
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
       mov       rdx,2371C1232F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,2371C1232F8
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
       je        near ptr M02_L25
       mov       rcx,rbp
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       je        short M02_L00
       xor       eax,eax
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M02_L03
       cmp       dword ptr [rcx+8],0
       je        short M02_L03
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L05:
       cmp       [rcx],ecx
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
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,95A
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,976
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L07:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L09:
       cmp       ebx,0FFFFFFFF
       je        short M02_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L20
M02_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L12:
       xor       ebx,ebx
       mov       rcx,7FFB476E76E0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L13:
       mov       r9,2371C12DAE0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L15:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L24
       jmp       near ptr M02_L13
M02_L18:
       sub       ebp,ebx
       jo        near ptr M02_L24
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
       jbe       short M02_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L21
M02_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L21:
       cmp       r14d,0FFFFFFFF
       je        short M02_L22
       cmp       r14d,0FFFFFFFE
       jne       short M02_L23
M02_L22:
       mov       rdx,2371C133918
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L23:
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
M02_L24:
       call      CORINFO_HELP_OVERFLOW
M02_L25:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,2371C123020
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
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47244000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4789AB38]
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
       mov       rcx,220E4862EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB4789AD80]
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
       call      qword ptr [7FFB478A29C0]
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
       mov       rdx,220E48632F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,220E48632F8
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
       je        near ptr M02_L25
       mov       rcx,rbp
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       je        short M02_L00
       xor       eax,eax
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M02_L03
       cmp       dword ptr [rcx+8],0
       je        short M02_L03
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L05:
       cmp       [rcx],ecx
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
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,95A
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,976
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L07:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L09:
       cmp       ebx,0FFFFFFFF
       je        short M02_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L20
M02_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L12:
       xor       ebx,ebx
       mov       rcx,7FFB476D76E0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L13:
       mov       r9,220E486DAE0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L15:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L24
       jmp       near ptr M02_L13
M02_L18:
       sub       ebp,ebx
       jo        near ptr M02_L24
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
       jbe       short M02_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L21
M02_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L21:
       cmp       r14d,0FFFFFFFF
       je        short M02_L22
       cmp       r14d,0FFFFFFFE
       jne       short M02_L23
M02_L22:
       mov       rdx,220E4873918
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L23:
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
M02_L24:
       call      CORINFO_HELP_OVERFLOW
M02_L25:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,220E4863020
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
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47234000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4789AB38]
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
       mov       rcx,2B1DE7F2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB4789AD80]
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
       call      qword ptr [7FFB478A29C0]
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
       mov       rdx,2B1DE7F32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,2B1DE7F32F8
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
       je        near ptr M02_L25
       mov       rcx,rbp
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       je        short M02_L00
       xor       eax,eax
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M02_L03
       cmp       dword ptr [rcx+8],0
       je        short M02_L03
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L05:
       cmp       [rcx],ecx
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
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,95A
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,976
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L07:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L09:
       cmp       ebx,0FFFFFFFF
       je        short M02_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L20
M02_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L12:
       xor       ebx,ebx
       mov       rcx,7FFB476D76E0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L13:
       mov       r9,2B1FE7F96D8
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L15:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L24
       jmp       near ptr M02_L13
M02_L18:
       sub       ebp,ebx
       jo        near ptr M02_L24
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
       jbe       short M02_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L21
M02_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L21:
       cmp       r14d,0FFFFFFFF
       je        short M02_L22
       cmp       r14d,0FFFFFFFE
       jne       short M02_L23
M02_L22:
       mov       rdx,2B1EE7F1658
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L23:
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
M02_L24:
       call      CORINFO_HELP_OVERFLOW
M02_L25:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,2B1DE7F3020
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
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47234000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478AAB38]
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
       mov       rcx,20EA8802EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478AAD80]
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
       call      qword ptr [7FFB478B29C0]
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
       mov       rdx,20EA88032F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,20EA88032F8
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
       je        near ptr M02_L25
       mov       rcx,rbp
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       je        short M02_L00
       xor       eax,eax
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M02_L03
       cmp       dword ptr [rcx+8],0
       je        short M02_L03
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L05:
       cmp       [rcx],ecx
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
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,95A
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,976
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L07:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L09:
       cmp       ebx,0FFFFFFFF
       je        short M02_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L20
M02_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L12:
       xor       ebx,ebx
       mov       rcx,7FFB476E76E0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L13:
       mov       r9,20EA880DAE0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L15:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L24
       jmp       near ptr M02_L13
M02_L18:
       sub       ebp,ebx
       jo        near ptr M02_L24
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
       jbe       short M02_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L21
M02_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L21:
       cmp       r14d,0FFFFFFFF
       je        short M02_L22
       cmp       r14d,0FFFFFFFE
       jne       short M02_L23
M02_L22:
       mov       rdx,20EA8813918
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L23:
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
M02_L24:
       call      CORINFO_HELP_OVERFLOW
M02_L25:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,20EA8803020
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
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47244000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4789AB38]
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
       mov       rcx,1C778E82EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB4789AD80]
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
       call      qword ptr [7FFB478A29C0]
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
       mov       rdx,1C778E832F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1C778E832F8
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
       je        near ptr M02_L25
       mov       rcx,rbp
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       je        short M02_L00
       xor       eax,eax
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M02_L03
       cmp       dword ptr [rcx+8],0
       je        short M02_L03
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L05:
       cmp       [rcx],ecx
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
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,95A
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,976
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L07:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L09:
       cmp       ebx,0FFFFFFFF
       je        short M02_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L20
M02_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L12:
       xor       ebx,ebx
       mov       rcx,7FFB476D76E0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L13:
       mov       r9,1C778E8DAE0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L15:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L24
       jmp       near ptr M02_L13
M02_L18:
       sub       ebp,ebx
       jo        near ptr M02_L24
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
       jbe       short M02_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L21
M02_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L21:
       cmp       r14d,0FFFFFFFF
       je        short M02_L22
       cmp       r14d,0FFFFFFFE
       jne       short M02_L23
M02_L22:
       mov       rdx,1C778E93918
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L23:
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
M02_L24:
       call      CORINFO_HELP_OVERFLOW
M02_L25:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,1C778E83020
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
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47234000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478BAB38]
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
       mov       rcx,12CA2912EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478BAD80]
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
       call      qword ptr [7FFB478C29C0]
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
       mov       rdx,12CA29132F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,12CA29132F8
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
       je        near ptr M02_L25
       mov       rcx,rbp
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       je        short M02_L00
       xor       eax,eax
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M02_L03
       cmp       dword ptr [rcx+8],0
       je        short M02_L03
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L05:
       cmp       [rcx],ecx
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
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,95A
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,976
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L07:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L09:
       cmp       ebx,0FFFFFFFF
       je        short M02_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L20
M02_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L12:
       xor       ebx,ebx
       mov       rcx,7FFB476F76E0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L13:
       mov       r9,12CA291DAE0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L15:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L24
       jmp       near ptr M02_L13
M02_L18:
       sub       ebp,ebx
       jo        near ptr M02_L24
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
       jbe       short M02_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L21
M02_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L21:
       cmp       r14d,0FFFFFFFF
       je        short M02_L22
       cmp       r14d,0FFFFFFFE
       jne       short M02_L23
M02_L22:
       mov       rdx,12CA2923918
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L23:
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
M02_L24:
       call      CORINFO_HELP_OVERFLOW
M02_L25:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,12CA2913020
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
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47254000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4789AB38]
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
       mov       rcx,20BA4882EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB4789AD80]
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
       call      qword ptr [7FFB478A29C0]
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
       mov       rdx,20BA48832F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,20BA48832F8
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
       je        near ptr M02_L25
       mov       rcx,rbp
       test      rcx,rcx
       je        short M02_L00
       cmp       dword ptr [rcx+8],0
       je        short M02_L00
       xor       eax,eax
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,215
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbp,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M02_L03
       cmp       dword ptr [rcx+8],0
       je        short M02_L03
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       mov       eax,1
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,21D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L05:
       cmp       [rcx],ecx
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
       jne       short M02_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbx,rax
       mov       ecx,95A
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L06:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,r12
       mov       [rax+8],r14d
       mov       rdx,rax
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L07
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       r14,rax
       mov       ecx,976
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L07:
       mov       rcx,rsi
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       short M02_L08
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       dword ptr [rsi+18]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       edx,3D
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L09:
       cmp       ebx,0FFFFFFFF
       je        short M02_L10
       cmp       ebx,0FFFFFFFE
       jne       near ptr M02_L20
M02_L10:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L11
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L12:
       xor       ebx,ebx
       mov       rcx,7FFB476D76E0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
M02_L13:
       mov       r9,20BA488DAE0
       mov       rdx,[r9]
       mov       ebp,[rdi+8]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        near ptr M02_L18
       mov       r9d,r15d
       sub       r9d,ebx
       jo        near ptr M02_L24
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M02_L14
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],5C
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L15
M02_L14:
       mov       rcx,rsi
       mov       edx,5C
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L15:
       cmp       r15d,ebp
       jae       near ptr M02_L26
       movsxd    rcx,r15d
       movzx     edx,word ptr [rdi+rcx*2+0C]
       mov       ecx,[rsi+18]
       mov       r8d,ecx
       mov       rax,[rsi+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M02_L16
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L17
M02_L16:
       mov       rcx,rsi
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M02_L17:
       mov       ebx,r15d
       add       ebx,1
       jo        near ptr M02_L24
       jmp       near ptr M02_L13
M02_L18:
       sub       ebp,ebx
       jo        near ptr M02_L24
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
       jbe       short M02_L19
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M02_L21
M02_L19:
       mov       rcx,rsi
       mov       edx,22
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M02_L21:
       cmp       r14d,0FFFFFFFF
       je        short M02_L22
       cmp       r14d,0FFFFFFFE
       jne       short M02_L23
M02_L22:
       mov       rdx,20BA4893918
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M02_L23:
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
M02_L24:
       call      CORINFO_HELP_OVERFLOW
M02_L25:
       mov       ecx,4D
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476D6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 983
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
       mov       rax,20BA4883020
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
       mov       rdx,7FFB47234000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47234000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,15B6D8EF510
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4788AB38]
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
       mov       rcx,15B7D8E2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB4788AD80]
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
       call      qword ptr [7FFB478929C0]
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
       mov       rdx,15B7D8E32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,15B7D8E32F8
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L01
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
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,990
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 344
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
       mov       rax,15B7D8E3020
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
       mov       rdx,7FFB47224000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47224000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,28265011658
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB4788AB38]
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
       mov       rcx,28275012EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB4788AD80]
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
       call      qword ptr [7FFB478929C0]
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
       mov       rdx,282750132F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,282750132F8
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L01
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
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,4D
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,990
       mov       rdx,7FFB476C6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 344
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
       mov       rax,28275013020
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
       mov       rdx,7FFB47224000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47224000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,1C874073918
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478CAB38]
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
       mov       rcx,1C874062EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478CAD80]
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
       call      qword ptr [7FFB478D29C0]
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
       mov       rdx,1C8740632F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1C8740632F8
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L01
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
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       ecx,4D
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,4D
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,990
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 344
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
       mov       rax,1C874063020
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
       mov       rdx,7FFB47264000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47264000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,167C8173918
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478BAB38]
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
       mov       rcx,167C8162EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478BAD80]
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
       call      qword ptr [7FFB478C29C0]
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
       mov       rdx,167C81632F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,167C81632F8
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L01
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
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,990
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 344
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
       mov       rax,167C8163020
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
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47254000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,180FEAB3918
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478BAB38]
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
       mov       rcx,180FEAA2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478BAD80]
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
       call      qword ptr [7FFB478C29C0]
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
       mov       rdx,180FEAA32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,180FEAA32F8
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L01
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
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,990
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 344
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
       mov       rax,180FEAA3020
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
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47254000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,16EA334F510
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478BAB38]
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
       mov       rcx,16EB3342EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478BAD80]
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
       call      qword ptr [7FFB478C29C0]
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
       mov       rdx,16EB33432F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,16EB33432F8
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L01
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
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,990
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 344
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
       mov       rax,16EB3343020
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
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47254000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,1A360403918
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478CAB38]
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
       mov       rcx,1A3603F2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478CAD80]
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
       call      qword ptr [7FFB478D29C0]
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
       mov       rdx,1A3603F32F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1A3603F32F8
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L01
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
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       ecx,4D
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,4D
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,990
       mov       rdx,7FFB47706F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 344
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
       mov       rax,1A3603F3020
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
       mov       rdx,7FFB47264000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47264000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,1F9DFC9F510
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478AAB38]
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
       mov       rcx,1F9EFC92EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478AAD80]
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
       call      qword ptr [7FFB478B29C0]
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
       mov       rdx,1F9EFC932F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1F9EFC932F8
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L01
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
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,4D
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,990
       mov       rdx,7FFB476E6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 344
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
       mov       rax,1F9EFC93020
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
       mov       rdx,7FFB47244000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47244000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,1AE80461658
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
       mov       rsi,[rsi+18]
       mov       rcx,rdi
       call      qword ptr [7FFB478BAB38]
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
       mov       rcx,1AE70462EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFB478BAD80]
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
       call      qword ptr [7FFB478C29C0]
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
       mov       rdx,1AE704632F8
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M01_L05
M01_L10:
       mov       rdx,1AE704632F8
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L00
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L01
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
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,946
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,4D
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,990
       mov       rdx,7FFB476F6F48
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 344
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
       mov       rax,1AE70463020
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
       mov       rdx,7FFB47254000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFB47254000
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478B57A0]
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
       mov       rcx,[rsi+18]
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
       mov       r11,7FFB472607E8
       call      qword ptr [7FFB478C07E8]
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
       mov       r11,7FFB472607F0
       call      qword ptr [7FFB478C07F0]
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
       mov       r9,244897A5020
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4765B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4765B240]
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
       mov       rdx,2448979D338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2448979D340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M04_L05
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
       mov       rdx,244897A5678
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,24489791568
       mov       r14,[rdx]
       mov       rdx,244897A5680
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       mov       rcx,rdi
       mov       rax,[7FFB478BAB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,244897931D8
       mov       rcx,[rcx]
       mov       rdx,24489793090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M04_L06
       cmp       dword ptr [rcx+8],0
       je        short M04_L06
       xor       eax,eax
       jmp       short M04_L07
M04_L06:
       mov       eax,1
M04_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB475B0190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB475B0190
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB475B0190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478956B0]
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
       mov       rcx,[rsi+18]
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
       mov       r11,7FFB472407E8
       call      qword ptr [7FFB478A07E8]
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
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
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
       mov       r9,21D40912548
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4763B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4763B240]
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
       mov       rdx,21D1091D338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,21D1091D340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M04_L05
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
       mov       rdx,21D40912BA0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,21D10911568
       mov       r14,[rdx]
       mov       rdx,21D40912BA8
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       mov       rcx,rdi
       mov       rax,[7FFB4789AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,21D109131D8
       mov       rcx,[rcx]
       mov       rdx,21D10913090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M04_L06
       cmp       dword ptr [rcx+8],0
       je        short M04_L06
       xor       eax,eax
       jmp       short M04_L07
M04_L06:
       mov       eax,1
M04_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB47590190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB47590190
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB47590190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478A56B0]
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
       mov       rcx,[rsi+18]
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
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478B07E8]
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
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
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
       mov       r9,1EB990A2548
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4764B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4764B240]
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
       mov       rdx,1EBA90AD338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1EBA90AD340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M04_L05
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
       mov       rdx,1EB990A2BA0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,1EBA90A1568
       mov       r14,[rdx]
       mov       rdx,1EB990A2BA8
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       mov       rcx,rdi
       mov       rax,[7FFB478AAB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,1EBA90A31D8
       mov       rcx,[rcx]
       mov       rdx,1EBA90A3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M04_L06
       cmp       dword ptr [rcx+8],0
       je        short M04_L06
       xor       eax,eax
       jmp       short M04_L07
M04_L06:
       mov       eax,1
M04_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478957A0]
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
       mov       rcx,[rsi+18]
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
       mov       r11,7FFB472407E8
       call      qword ptr [7FFB478A07E8]
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
       mov       r11,7FFB472407F0
       call      qword ptr [7FFB478A07F0]
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
       mov       r9,14EED9A1530
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4763B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4763B240]
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
       mov       rdx,14EFD9AD338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,14EFD9AD340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M04_L05
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
       mov       rdx,14EED9A1B88
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,14EFD9A1568
       mov       r14,[rdx]
       mov       rdx,14EED9A1B90
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       mov       rcx,rdi
       mov       rax,[7FFB4789AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,14EFD9A31D8
       mov       rcx,[rcx]
       mov       rdx,14EFD9A3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M04_L06
       cmp       dword ptr [rcx+8],0
       je        short M04_L06
       xor       eax,eax
       jmp       short M04_L07
M04_L06:
       mov       eax,1
M04_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB47590190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB47590190
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB47590190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478A56B0]
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
       mov       rcx,[rsi+18]
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
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478B07E8]
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
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
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
       mov       r9,1C7A6CC1530
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4764B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4764B240]
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
       mov       rdx,1C7B6CC8F30
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1C7B6CC8F38
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M04_L05
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
       mov       rdx,1C7A6CC1B88
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,1C7C6CC1568
       mov       r14,[rdx]
       mov       rdx,1C7A6CC1B90
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       mov       rcx,rdi
       mov       rax,[7FFB478AAB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,1C7C6CC31D8
       mov       rcx,[rcx]
       mov       rdx,1C7C6CC3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M04_L06
       cmp       dword ptr [rcx+8],0
       je        short M04_L06
       xor       eax,eax
       jmp       short M04_L07
M04_L06:
       mov       eax,1
M04_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478A56B0]
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
       mov       rcx,[rsi+18]
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
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478B07E8]
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
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
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
       mov       r9,1D7DA2A2D60
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4764B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4764B240]
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
       mov       rdx,1D7FA2AD338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1D7FA2AD340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M04_L05
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
       mov       rdx,1D7DA2A33B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,1D7FA2A1568
       mov       r14,[rdx]
       mov       rdx,1D7DA2A33C0
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       mov       rcx,rdi
       mov       rax,[7FFB478AAB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,1D7FA2A31D8
       mov       rcx,[rcx]
       mov       rdx,1D7FA2A3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M04_L06
       cmp       dword ptr [rcx+8],0
       je        short M04_L06
       xor       eax,eax
       jmp       short M04_L07
M04_L06:
       mov       eax,1
M04_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478A57A0]
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
       mov       rcx,[rsi+18]
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
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478B07E8]
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
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
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
       mov       r9,1E9FC981530
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4764B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4764B240]
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
       mov       rdx,1EA0C988F30
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1EA0C988F38
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M04_L05
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
       mov       rdx,1E9FC981B88
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,1EA1C981568
       mov       r14,[rdx]
       mov       rdx,1E9FC981B90
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       mov       rcx,rdi
       mov       rax,[7FFB478AAB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,1EA1C9831D8
       mov       rcx,[rcx]
       mov       rdx,1EA1C983090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M04_L06
       cmp       dword ptr [rcx+8],0
       je        short M04_L06
       xor       eax,eax
       jmp       short M04_L07
M04_L06:
       mov       eax,1
M04_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478A57A0]
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
       mov       rcx,[rsi+18]
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
       mov       r11,7FFB472507E8
       call      qword ptr [7FFB478B07E8]
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
       mov       r11,7FFB472507F0
       call      qword ptr [7FFB478B07F0]
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
       mov       r9,1E860181D48
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4764B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4764B240]
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
       mov       rdx,1E88018D338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1E88018D340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M04_L05
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
       mov       rdx,1E8601823A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,1E880181568
       mov       r14,[rdx]
       mov       rdx,1E8601823A8
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       mov       rcx,rdi
       mov       rax,[7FFB478AAB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,1E8801831D8
       mov       rcx,[rcx]
       mov       rdx,1E880183090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M04_L06
       cmp       dword ptr [rcx+8],0
       je        short M04_L06
       xor       eax,eax
       jmp       short M04_L07
M04_L06:
       mov       eax,1
M04_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB475A0190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovsd    xmm0,qword ptr [7FFB478856B0]
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
       mov       rcx,[rsi+18]
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
       mov       r11,7FFB472307E8
       call      qword ptr [7FFB478907E8]
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
       mov       r11,7FFB472307F0
       call      qword ptr [7FFB478907F0]
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
       mov       r9,1F156372548
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFB4762B238]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFB4762B240]
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
       mov       rdx,1F16637D338
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1F16637D340
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
       call      qword ptr [7FFBA67C5AF0]
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
       call      qword ptr [7FFBA67C0590]
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
       call      qword ptr [7FFBA67C4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBA67C5B00]
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
       call      qword ptr [7FFBA67C1340]
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
       call      qword ptr [7FFBA67C0588]
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
       lea       r11,[7FFBA67BFDC0]
       call      qword ptr [7FFBA67BFDC0]
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
       call      qword ptr [7FFBA67C0588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFBA67B9258]
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
       call      qword ptr [7FFBA67BD150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFBA67BFDC8]
       call      qword ptr [7FFBA67BFDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFBA67C0578]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M04_L05
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
       mov       rdx,1F156372BA0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M04_L01
       mov       rdx,1F166371568
       mov       r14,[rdx]
       mov       rdx,1F156372BA8
       mov       r15,[rdx]
M04_L00:
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
       jo        short M04_L04
       cmp       ebp,ebx
       jg        short M04_L00
M04_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M04_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M04_L03
M04_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M04_L03:
       mov       rcx,rdi
       mov       rax,[7FFB4788AB38]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L04:
       call      CORINFO_HELP_OVERFLOW
M04_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,1F1663731D8
       mov       rcx,[rcx]
       mov       rdx,1F166373090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M04_L06
       cmp       dword ptr [rcx+8],0
       je        short M04_L06
       xor       eax,eax
       jmp       short M04_L07
M04_L06:
       mov       eax,1
M04_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB47580190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB47580190
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB47580190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

