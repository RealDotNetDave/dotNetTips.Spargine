## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98BAAB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L29
       cmp       qword ptr [r15+28],0
       je        short M01_L02
       mov       rcx,[r15+28]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,16A1D163020
       mov       r8,[r8]
       mov       r9,169ED161308
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA986A0350
       call      qword ptr [7FFA986A0350]
       test      eax,eax
       je        near ptr M01_L11
M01_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA986A0350
       call      qword ptr [7FFA986A0350]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFA986A0358
       call      qword ptr [7FFA986A0358]
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB6F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA986A0340
       call      qword ptr [7FFA986A0340]
       test      eax,eax
       je        near ptr M01_L27
M01_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0340
       call      qword ptr [7FFA986A0340]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0348
       call      qword ptr [7FFA986A0348]
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       ecx,4D
       mov       rdx,7FFA98B3EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFA98B3EE70
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
M01_L29:
       mov       ecx,4D
       mov       rdx,7FFA98B3EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFA98B3EE70
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
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M01_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFA986A0358
       call      qword ptr [7FFA986A0358]
M01_L30:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0348
       call      qword ptr [7FFA986A0348]
M01_L31:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1246
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFA97603C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978EDFA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA976323F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L05
       call      qword ptr [7FFA9760D330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,1C74E012E60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,1C74E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L04
       mov       rcx,rbx
M01_L02:
       test      rcx,rcx
       jne       short M01_L03
       mov       eax,1
       jmp       near ptr M01_L37
M01_L03:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L37
M01_L04:
       mov       rax,1C74E002028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FFA9760D330]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,1C74E012E68
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,1C74E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,1C74E002028
       mov       rdx,[rdx]
       call      qword ptr [7FFA971C1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L41
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFA9760D450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA9760BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9760D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9760D510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9760D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA97632AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,1C74E002028
       mov       r8,[r8]
       mov       r9,1C74E012E70
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFA9760BEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L19
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFA97632C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA96F80A68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L13:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFA97632C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L16
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFA97632DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F80A68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F80A70
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA97632B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FFA9756BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L24
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,rsi
       mov       rdx,7FFA97632F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L24:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA97632BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFA97563318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFA97632C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA96F80A58
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L34
M01_L29:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFA97632C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L31:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L32
       jmp       short M01_L33
M01_L32:
       mov       rcx,rsi
       mov       rdx,7FFA97632DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F80A58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F80A60
       call      qword ptr [r11]
       mov       eax,ebx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FFA9760D450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA9760BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9760D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9760D510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9760D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L41:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-40],0
       je        short M01_L42
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F80A70
       call      qword ptr [r11]
M01_L42:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       je        short M01_L43
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F80A60
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1974
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98BAAB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L29
       cmp       qword ptr [r15+28],0
       je        short M01_L02
       mov       rcx,[r15+28]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,1A103223020
       mov       r8,[r8]
       mov       r9,1A163221308
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA986A0350
       call      qword ptr [7FFA986A0350]
       test      eax,eax
       je        near ptr M01_L11
M01_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA986A0350
       call      qword ptr [7FFA986A0350]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFA986A0358
       call      qword ptr [7FFA986A0358]
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB6F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA986A0340
       call      qword ptr [7FFA986A0340]
       test      eax,eax
       je        near ptr M01_L27
M01_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0340
       call      qword ptr [7FFA986A0340]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0348
       call      qword ptr [7FFA986A0348]
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       ecx,4D
       mov       rdx,7FFA98B3EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFA98B3EE70
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
M01_L29:
       mov       ecx,4D
       mov       rdx,7FFA98B3EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFA98B3EE70
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
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M01_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFA986A0358
       call      qword ptr [7FFA986A0358]
M01_L30:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0348
       call      qword ptr [7FFA986A0348]
M01_L31:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1246
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFA975F3C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DD3F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA976223F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L05
       call      qword ptr [7FFA975FD330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,1A4174002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,1A419400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L04
       mov       rcx,rbx
M01_L02:
       test      rcx,rcx
       jne       short M01_L03
       mov       eax,1
       jmp       near ptr M01_L37
M01_L03:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L37
M01_L04:
       mov       rax,1A419400030
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FFA975FD330]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,1A417400300
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,1A419400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,1A419400030
       mov       rdx,[rdx]
       call      qword ptr [7FFA971B1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L41
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFA975FD450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974512D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974512D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975FD510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9739FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9739FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA97622AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,1A419400030
       mov       r8,[r8]
       mov       r9,1A417400308
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFA975FBEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L19
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFA97622C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA96F70A68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L13:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFA97622C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L16
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFA97622DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F70A68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F70A70
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA97622B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FFA9755BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L24
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,rsi
       mov       rdx,7FFA97622F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L24:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA97622BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFA97553318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFA97622C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA96F70A58
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L34
M01_L29:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFA97622C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L31:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L32
       jmp       short M01_L33
M01_L32:
       mov       rcx,rsi
       mov       rdx,7FFA97622DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F70A58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F70A60
       call      qword ptr [r11]
       mov       eax,ebx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FFA975FD450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974512D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974512D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975FD510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9739FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9739FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L41:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-40],0
       je        short M01_L42
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F70A70
       call      qword ptr [r11]
M01_L42:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       je        short M01_L43
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F70A60
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1974
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98BBAB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L29
       cmp       qword ptr [r15+28],0
       je        short M01_L02
       mov       rcx,[r15+28]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98BBB260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,1A3F8B13020
       mov       r8,[r8]
       mov       r9,1A468B11308
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA98BBB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA986B0350
       call      qword ptr [7FFA986B0350]
       test      eax,eax
       je        near ptr M01_L11
M01_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFA98BBB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA98BBB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA986B0350
       call      qword ptr [7FFA986B0350]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFA986B0358
       call      qword ptr [7FFA986B0358]
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFA98BBB338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFA98BBB6F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFA98BBB388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA98BBB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA986B0340
       call      qword ptr [7FFA986B0340]
       test      eax,eax
       je        near ptr M01_L27
M01_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFA98BBB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA98BBB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA986B0340
       call      qword ptr [7FFA986B0340]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFA986B0348
       call      qword ptr [7FFA986B0348]
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       ecx,4D
       mov       rdx,7FFA98B4EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFA98B4EE70
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
M01_L29:
       mov       ecx,4D
       mov       rdx,7FFA98B4EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFA98B4EE70
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
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M01_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFA986B0358
       call      qword ptr [7FFA986B0358]
M01_L30:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFA986B0348
       call      qword ptr [7FFA986B0348]
M01_L31:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1246
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFA97603C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978FFFA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA976323F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L05
       call      qword ptr [7FFA9760D330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,1A6310002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,1A61F002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L04
       mov       rcx,rbx
M01_L02:
       test      rcx,rcx
       jne       short M01_L03
       mov       eax,1
       jmp       near ptr M01_L37
M01_L03:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L37
M01_L04:
       mov       rax,1A61F002028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FFA9760D330]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,1A631000300
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,1A61F002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,1A61F002028
       mov       rdx,[rdx]
       call      qword ptr [7FFA971C1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L41
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFA9760D450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA9760BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9760D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9760D510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9760D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA97632AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,1A61F002028
       mov       r8,[r8]
       mov       r9,1A631000308
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFA9760BEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L19
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFA97632C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA96F80A68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L13:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFA97632C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L16
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFA97632DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F80A68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F80A70
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA97632B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FFA9756BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L24
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,rsi
       mov       rdx,7FFA97632F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L24:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA97632BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFA97563318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFA97632C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA96F80A58
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L34
M01_L29:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFA97632C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L31:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L32
       jmp       short M01_L33
M01_L32:
       mov       rcx,rsi
       mov       rdx,7FFA97632DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F80A58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F80A60
       call      qword ptr [r11]
       mov       eax,ebx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FFA9760D450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA9760BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9760D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9760D510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9760D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L41:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-40],0
       je        short M01_L42
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F80A70
       call      qword ptr [r11]
M01_L42:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       je        short M01_L43
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F80A60
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1974
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98BAAB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L29
       cmp       qword ptr [r15+28],0
       je        short M01_L02
       mov       rcx,[r15+28]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,1F1760A3020
       mov       r8,[r8]
       mov       r9,1F1560A1308
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA986A0350
       call      qword ptr [7FFA986A0350]
       test      eax,eax
       je        near ptr M01_L11
M01_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA986A0350
       call      qword ptr [7FFA986A0350]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFA986A0358
       call      qword ptr [7FFA986A0358]
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB6F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA986A0340
       call      qword ptr [7FFA986A0340]
       test      eax,eax
       je        near ptr M01_L27
M01_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA98BAB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0340
       call      qword ptr [7FFA986A0340]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0348
       call      qword ptr [7FFA986A0348]
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       ecx,4D
       mov       rdx,7FFA98B3EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFA98B3EE70
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
M01_L29:
       mov       ecx,4D
       mov       rdx,7FFA98B3EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFA98B3EE70
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
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M01_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFA986A0358
       call      qword ptr [7FFA986A0358]
M01_L30:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0348
       call      qword ptr [7FFA986A0348]
M01_L31:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1246
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFA97603C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978EF738]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA976323F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L05
       call      qword ptr [7FFA9760D330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,268AE0002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,268A4000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L04
       mov       rcx,rbx
M01_L02:
       test      rcx,rcx
       jne       short M01_L03
       mov       eax,1
       jmp       near ptr M01_L37
M01_L03:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L37
M01_L04:
       mov       rax,268A4000030
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FFA9760D330]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,268AE000300
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,268A4000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,268A4000030
       mov       rdx,[rdx]
       call      qword ptr [7FFA971C1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L41
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFA9760D450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA9760BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9760D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9760D510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9760D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA97632AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,268A4000030
       mov       r8,[r8]
       mov       r9,268AE000308
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFA9760BEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L19
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFA97632C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA96F80A68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L13:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFA97632C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L16
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFA97632DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F80A68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F80A70
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA97632B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FFA9756BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L24
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,rsi
       mov       rdx,7FFA97632F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L24:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA97632BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFA97563318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFA97632C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA96F80A58
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L34
M01_L29:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFA97632C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L31:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L32
       jmp       short M01_L33
M01_L32:
       mov       rcx,rsi
       mov       rdx,7FFA97632DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F80A58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F80A60
       call      qword ptr [r11]
       mov       eax,ebx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FFA9760D450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974612D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA9760BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9760D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9760D510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9760D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA973AFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L41:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-40],0
       je        short M01_L42
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F80A70
       call      qword ptr [r11]
M01_L42:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       je        short M01_L43
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F80A60
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1974
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98BDAB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L29
       cmp       qword ptr [r15+28],0
       je        short M01_L02
       mov       rcx,[r15+28]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,2033C2B3020
       mov       r8,[r8]
       mov       r9,2032C2B1308
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA986D0350
       call      qword ptr [7FFA986D0350]
       test      eax,eax
       je        near ptr M01_L11
M01_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA986D0350
       call      qword ptr [7FFA986D0350]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFA986D0358
       call      qword ptr [7FFA986D0358]
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB6F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA986D0340
       call      qword ptr [7FFA986D0340]
       test      eax,eax
       je        near ptr M01_L27
M01_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA986D0340
       call      qword ptr [7FFA986D0340]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFA986D0348
       call      qword ptr [7FFA986D0348]
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       ecx,4D
       mov       rdx,7FFA98B6EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFA98B6EE70
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
M01_L29:
       mov       ecx,4D
       mov       rdx,7FFA98B6EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFA98B6EE70
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
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M01_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFA986D0358
       call      qword ptr [7FFA986D0358]
M01_L30:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFA986D0348
       call      qword ptr [7FFA986D0348]
M01_L31:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1246
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFA975D3C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978BF738]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA976023F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L05
       call      qword ptr [7FFA975DD330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,21C850002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,21C7B002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L04
       mov       rcx,rbx
M01_L02:
       test      rcx,rcx
       jne       short M01_L03
       mov       eax,1
       jmp       near ptr M01_L37
M01_L03:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L37
M01_L04:
       mov       rax,21C7B002028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FFA975DD330]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,21C85000300
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,21C7B002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,21C7B002028
       mov       rdx,[rdx]
       call      qword ptr [7FFA97191C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L41
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFA975DD450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974312D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974312D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975DD510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9737FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA97193510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9737FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA97602AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,21C7B002028
       mov       r8,[r8]
       mov       r9,21C85000308
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFA975DBEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L19
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFA97602C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA96F50A68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L13:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFA97602C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L16
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFA97602DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F50A68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F50A70
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA97602B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FFA9753BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L24
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,rsi
       mov       rdx,7FFA97602F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L24:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA97602BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFA97533318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFA97602C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA96F50A58
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L34
M01_L29:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFA97602C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L31:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L32
       jmp       short M01_L33
M01_L32:
       mov       rcx,rsi
       mov       rdx,7FFA97602DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F50A58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F50A60
       call      qword ptr [r11]
       mov       eax,ebx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FFA975DD450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974312D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974312D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975DBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975DD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975DD510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9737FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA97193510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975DD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9737FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L41:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-40],0
       je        short M01_L42
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F50A70
       call      qword ptr [r11]
M01_L42:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       je        short M01_L43
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F50A60
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1974
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98BDAB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L29
       cmp       qword ptr [r15+28],0
       je        short M01_L02
       mov       rcx,[r15+28]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,25DDDC73020
       mov       r8,[r8]
       mov       r9,25E3DC71308
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA986D0350
       call      qword ptr [7FFA986D0350]
       test      eax,eax
       je        near ptr M01_L11
M01_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA986D0350
       call      qword ptr [7FFA986D0350]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFA986D0358
       call      qword ptr [7FFA986D0358]
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB6F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA986D0340
       call      qword ptr [7FFA986D0340]
       test      eax,eax
       je        near ptr M01_L27
M01_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA98BDB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA986D0340
       call      qword ptr [7FFA986D0340]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFA986D0348
       call      qword ptr [7FFA986D0348]
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       ecx,4D
       mov       rdx,7FFA98B6EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFA98B6EE70
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
M01_L29:
       mov       ecx,4D
       mov       rdx,7FFA98B6EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFA98B6EE70
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
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M01_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFA986D0358
       call      qword ptr [7FFA986D0358]
M01_L30:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFA986D0348
       call      qword ptr [7FFA986D0348]
M01_L31:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1246
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFA975E3C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DD738]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA976123F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L05
       call      qword ptr [7FFA975ED330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,2AA82C002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,2AA80C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L04
       mov       rcx,rbx
M01_L02:
       test      rcx,rcx
       jne       short M01_L03
       mov       eax,1
       jmp       near ptr M01_L37
M01_L03:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L37
M01_L04:
       mov       rax,2AA80C02028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FFA975ED330]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,2AA82C00300
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,2AA80C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,2AA80C02028
       mov       rdx,[rdx]
       call      qword ptr [7FFA971A1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L41
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFA975ED450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974412D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974412D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975ED510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9738FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9738FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA97612AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,2AA80C02028
       mov       r8,[r8]
       mov       r9,2AA82C00308
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFA975EBEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L19
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFA97612C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA96F60A68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L13:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFA97612C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L16
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFA97612DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F60A68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F60A70
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA97612B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FFA9754BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L24
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,rsi
       mov       rdx,7FFA97612F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L24:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA97612BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFA97543318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFA97612C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA96F60A58
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L34
M01_L29:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFA97612C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L31:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L32
       jmp       short M01_L33
M01_L32:
       mov       rcx,rsi
       mov       rdx,7FFA97612DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F60A58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F60A60
       call      qword ptr [r11]
       mov       eax,ebx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FFA975ED450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974412D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974412D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975ED510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9738FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9738FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L41:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-40],0
       je        short M01_L42
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F60A70
       call      qword ptr [r11]
M01_L42:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       je        short M01_L43
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F60A60
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1974
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98BCAB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L29
       cmp       qword ptr [r15+28],0
       je        short M01_L02
       mov       rcx,[r15+28]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98BCB260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,1F237A63020
       mov       r8,[r8]
       mov       r9,1F237A73E70
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA98BCB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA986C0350
       call      qword ptr [7FFA986C0350]
       test      eax,eax
       je        near ptr M01_L11
M01_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFA98BCB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA98BCB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA986C0350
       call      qword ptr [7FFA986C0350]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFA986C0358
       call      qword ptr [7FFA986C0358]
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFA98BCB338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FFA98BCB6F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsi
       mov       rdx,7FFA98BCB388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA98BCB3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA986C0340
       call      qword ptr [7FFA986C0340]
       test      eax,eax
       je        near ptr M01_L27
M01_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFA98BCB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA98BCB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA986C0340
       call      qword ptr [7FFA986C0340]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFA986C0348
       call      qword ptr [7FFA986C0348]
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       mov       ecx,4D
       mov       rdx,7FFA98B5EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFA98B5EE70
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
M01_L29:
       mov       ecx,4D
       mov       rdx,7FFA98B5EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFA98B5EE70
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
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M01_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFA986C0358
       call      qword ptr [7FFA986C0358]
M01_L30:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-48],0
       je        short M01_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFA986C0348
       call      qword ptr [7FFA986C0348]
M01_L31:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1246
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFA97613C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978FD3F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-38],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15,[rsi+10]
       cmp       qword ptr [r15+10],0
       je        short M01_L00
       mov       rcx,[r15+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA976423F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M01_L05
       call      qword ptr [7FFA9761D330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,1FF67412E60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA972199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,1FF67402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L04
       mov       rcx,rbx
M01_L02:
       test      rcx,rcx
       jne       short M01_L03
       mov       eax,1
       jmp       near ptr M01_L37
M01_L03:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L37
M01_L04:
       mov       rax,1FF67402028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FFA9761D330]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,1FF67412E68
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFA972199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,1FF67402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,1FF67402028
       mov       rdx,[rdx]
       call      qword ptr [7FFA971D1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L41
       mov       eax,1
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFA9761D450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974712D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974712D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA9761BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9761D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9761D510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA973BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9761D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA973BFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFA97642AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,1FF67402028
       mov       r8,[r8]
       mov       r9,1FF67412E70
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFA9761BEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M01_L19
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFA97642C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFA96F90A68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
M01_L13:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FFA97642C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L16
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rsi
       mov       rdx,7FFA97642DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F90A68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F90A70
       call      qword ptr [r11]
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rsi
       mov       rdx,7FFA97642B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FFA9757BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M01_L24
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rcx,rsi
       mov       rdx,7FFA97642F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L24:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L25
       jmp       short M01_L26
M01_L25:
       mov       rcx,rsi
       mov       rdx,7FFA97642BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFA97573318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFA97642C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFA96F90A58
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L34
M01_L29:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFA97642C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L31:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M01_L32
       jmp       short M01_L33
M01_L32:
       mov       rcx,rsi
       mov       rdx,7FFA97642DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F90A58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F90A60
       call      qword ptr [r11]
       mov       eax,ebx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FFA9761D450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA974712D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA974712D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA9761BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9761D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9761D510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA973BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9761D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA973BFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA973F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L41:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L06
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-40],0
       je        short M01_L42
       mov       rcx,[rbp-40]
       mov       r11,7FFA96F90A70
       call      qword ptr [r11]
M01_L42:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       je        short M01_L43
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F90A60
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1974
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98EEB2A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986A0B08
       call      qword ptr [7FFA986A0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986A0B10
       call      qword ptr [7FFA986A0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986A0B10
       call      qword ptr [7FFA986A0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978EF8B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978EF918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA9794CF48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F70A68
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F70A70
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973EB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F70A70
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98F1B330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986D0B08
       call      qword ptr [7FFA986D0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986D0B10
       call      qword ptr [7FFA986D0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986D0B10
       call      qword ptr [7FFA986D0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978FF348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978FF3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA97A221D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F90A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F90A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA9740B780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F90A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98F0B318
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986C0B08
       call      qword ptr [7FFA986C0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986C0B10
       call      qword ptr [7FFA986C0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986C0B10
       call      qword ptr [7FFA986C0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978DD348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DD3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA97A030C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F70A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F70A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973EB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F70A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98EFB2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986B0B08
       call      qword ptr [7FFA986B0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986B0B10
       call      qword ptr [7FFA986B0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986B0B10
       call      qword ptr [7FFA986B0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978DFBB8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DFC18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA97A013F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F70A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F70A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973EB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F70A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98F1B2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986D0B08
       call      qword ptr [7FFA986D0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986D0B10
       call      qword ptr [7FFA986D0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986D0B10
       call      qword ptr [7FFA986D0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978CD000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978CD060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA979F35E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F60A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F60A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973DB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F60A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98EFB2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986B0B08
       call      qword ptr [7FFA986B0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986B0B10
       call      qword ptr [7FFA986B0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986B0B10
       call      qword ptr [7FFA986B0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978CDBB8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978CDC18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA979F2548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F60A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F60A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973DB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F60A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rax,5
       sete      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98F0B3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986C0B08
       call      qword ptr [7FFA986C0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986C0B10
       call      qword ptr [7FFA986C0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986C0B10
       call      qword ptr [7FFA986C0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978DD000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DD060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 81
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA979C4518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F70A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F70A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973EB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F70A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,277BB50D3E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,277BB50D3E0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,277BB50D3E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98E2F588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,277BB503020
       mov       r9,[r9]
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98E2F700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,277BB503020
       mov       r9,[r9]
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M02_L05
M02_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rdx,rbx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L06
       mov       rcx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
M02_L06:
       mov       ecx,4D
       mov       rdx,7FFA98B3EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFA98B3EE70
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
; Total bytes of code 265
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,12F2D00C3F0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,12F2D00C3E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,12F2D00C3F0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      rdx,rdx
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA97287FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978D1840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M02_L01
M02_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M02_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M02_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M02_L00
M02_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1A
       call      qword ptr [7FFA973C77B0]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1FF2E65D3E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FF2E65D3E0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1FF2E65D3E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98E3F588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,1FF2E653020
       mov       r9,[r9]
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98E3F700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1FF2E653020
       mov       r9,[r9]
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M02_L05
M02_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rdx,rbx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L06
       mov       rcx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
M02_L06:
       mov       ecx,4D
       mov       rdx,7FFA98B4EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFA98B4EE70
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
; Total bytes of code 265
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,187AE40C3F0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,187AE40C3E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,187AE40C3F0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      rdx,rdx
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA97297FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978F1840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M02_L01
M02_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M02_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M02_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M02_L00
M02_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1A
       call      qword ptr [7FFA973D77B0]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,180EA5EAFD8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,180EA5EAFD0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,180EA5EAFD8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98E3F588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,1810A5E3020
       mov       r9,[r9]
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98E3F700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1810A5E3020
       mov       r9,[r9]
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M02_L05
M02_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rdx,rbx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L06
       mov       rcx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
M02_L06:
       mov       ecx,4D
       mov       rdx,7FFA98B4EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFA98B4EE70
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
; Total bytes of code 265
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,20887C0C3F0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20887C0C3E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,20887C0C3F0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      rdx,rdx
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA972A7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA97901840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M02_L01
M02_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M02_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M02_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M02_L00
M02_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1A
       call      qword ptr [7FFA973E77B0]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,159F903D3E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,159F903D3E0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,159F903D3E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98E3F588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,159F9033020
       mov       r9,[r9]
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98E3F700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,159F9033020
       mov       r9,[r9]
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M02_L05
M02_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rdx,rbx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L06
       mov       rcx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
M02_L06:
       mov       ecx,4D
       mov       rdx,7FFA98B4EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFA98B4EE70
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
; Total bytes of code 265
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,18F5A00C3F0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18F5A00C3E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,18F5A00C3F0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      rdx,rdx
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA972B7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978ED978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M02_L01
M02_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M02_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M02_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M02_L00
M02_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1A
       call      qword ptr [7FFA973F77B0]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1E252928FE0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E252928FD8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E252928FE0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98E1F588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,1E272923020
       mov       r9,[r9]
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98E1F700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1E272923020
       mov       r9,[r9]
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M02_L05
M02_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rdx,rbx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L06
       mov       rcx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
M02_L06:
       mov       ecx,4D
       mov       rdx,7FFA98B2EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFA98B2EE70
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
; Total bytes of code 265
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1F99940C3F0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F99940C3E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1F99940C3F0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      rdx,rdx
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA97297FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978CF978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M02_L01
M02_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M02_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M02_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M02_L00
M02_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1A
       call      qword ptr [7FFA973D77B0]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,25630B9D3E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25630B9D3E0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,25630B9D3E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98E2F588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,25630B93020
       mov       r9,[r9]
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98E2F700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,25630B93020
       mov       r9,[r9]
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M02_L05
M02_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rdx,rbx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L06
       mov       rcx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
M02_L06:
       mov       ecx,4D
       mov       rdx,7FFA98B3EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFA98B3EE70
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
; Total bytes of code 265
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2538240C3F0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2538240C3E8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2538240C3F0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      rdx,rdx
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA97297FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DDCC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M02_L01
M02_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M02_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M02_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M02_L00
M02_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1A
       call      qword ptr [7FFA973D77B0]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,206F208D3E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,206F208D3E0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,206F208D3E8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98E4F588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,206F2083020
       mov       r9,[r9]
       mov       rdx,rdi
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       je        short M02_L04
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFA98E4F700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,206F2083020
       mov       r9,[r9]
       mov       rdx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       test      eax,eax
       jne       short M02_L05
M02_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rdx,rbx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L06
       mov       rcx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
M02_L06:
       mov       ecx,4D
       mov       rdx,7FFA98B5EE70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFA98B5EE70
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
; Total bytes of code 265
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1377FC0A3F8
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1377FC0A3F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1377FC0A3F8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      rdx,rdx
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA97287FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978E1840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M02_L01
M02_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M02_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M02_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M02_L00
M02_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       ecx,1A
       call      qword ptr [7FFA973C77B0]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98F0B000
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986C0B08
       call      qword ptr [7FFA986C0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986C0B10
       call      qword ptr [7FFA986C0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986C0B10
       call      qword ptr [7FFA986C0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978FD348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978FD3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA97A231B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F90A68
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F90A70
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA9740B780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F90A70
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98EEB418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986A0B08
       call      qword ptr [7FFA986A0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986A0B10
       call      qword ptr [7FFA986A0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986A0B10
       call      qword ptr [7FFA986A0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978ED000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978ED060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA97A13158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F80A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F80A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973FB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F80A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98F0B2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986C0B08
       call      qword ptr [7FFA986C0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986C0B10
       call      qword ptr [7FFA986C0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986C0B10
       call      qword ptr [7FFA986C0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978CD8B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978CD918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA979F10B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F60A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F60A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973DB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F60A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98EFB2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986B0B08
       call      qword ptr [7FFA986B0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986B0B10
       call      qword ptr [7FFA986B0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986B0B10
       call      qword ptr [7FFA986B0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978CFBB8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978CFC18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA979F1480
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F60A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F60A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973DB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F60A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98EEB2D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986A0B08
       call      qword ptr [7FFA986A0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986A0B10
       call      qword ptr [7FFA986A0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986A0B10
       call      qword ptr [7FFA986A0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978DD8B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DD918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA97A01480
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F70A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F70A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973EB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F70A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98EFB3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986B0B08
       call      qword ptr [7FFA986B0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986B0B10
       call      qword ptr [7FFA986B0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986B0B10
       call      qword ptr [7FFA986B0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978CF348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978CF3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA979F2490
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F60A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F60A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973DB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F60A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L05
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA98F1B330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA986D0B08
       call      qword ptr [7FFA986D0B08]
       test      eax,eax
       je        short M01_L04
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsi
       mov       r11,7FFA986D0B10
       call      qword ptr [7FFA986D0B10]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L06
       mov       rcx,[rbp-20]
       mov       r11,7FFA986D0B10
       call      qword ptr [7FFA986D0B10]
M01_L06:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 210
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978ED348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978ED3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```
```assembly
; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       [rbp-18],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L06
       xor       edi,edi
       mov       rdx,[rcx+10]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA97A13518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFA96F80A70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L04
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       add       rdi,1
       jo        short M01_L03
       jmp       short M01_L02
M01_L05:
       mov       rcx,rsi
       mov       r11,7FFA96F80A78
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFA973FB780]
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp-20],0
       je        short M01_L07
       mov       rcx,[rbp-20]
       mov       r11,7FFA96F80A78
       call      qword ptr [r11]
M01_L07:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

