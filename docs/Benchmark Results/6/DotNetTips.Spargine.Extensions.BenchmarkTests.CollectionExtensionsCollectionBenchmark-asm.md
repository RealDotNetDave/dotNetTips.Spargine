## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E876E70
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
       mov       rdx,7FF80E8770F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,29EE2013020
       mov       r8,[r8]
       mov       r9,29F02011B38
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
       mov       rdx,7FF80E877228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF80E1308C0
       call      qword ptr [7FF80E1308C0]
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
       mov       rdx,7FF80E877240
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
       mov       rdx,7FF80E877420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1308C0
       call      qword ptr [7FF80E1308C0]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1308C8
       call      qword ptr [7FF80E1308C8]
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
       mov       rdx,7FF80E8771D0
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
       mov       rdx,7FF80E877570
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
       mov       rdx,7FF80E877208
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
       mov       rdx,7FF80E877228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF80E1308B0
       call      qword ptr [7FF80E1308B0]
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
       mov       rdx,7FF80E877240
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
       mov       rdx,7FF80E877420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1308B0
       call      qword ptr [7FF80E1308B0]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1308B8
       call      qword ptr [7FF80E1308B8]
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FF80E5E5D70
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF80E5E5D70
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
       mov       r11,7FF80E1308C8
       call      qword ptr [7FF80E1308C8]
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
       mov       r11,7FF80E1308B8
       call      qword ptr [7FF80E1308B8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF8D0F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF8D6F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF9AA70
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
       call      qword ptr [7FF81AD1DD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,2336CC144C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,2336CC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2336CC02028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FF81AD1DD80]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,2336CC144B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,2336CC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,2336CC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF81A8E1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF81AD1DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD1D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD1F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF81AF9ACF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,2336CC02028
       mov       r8,[r8]
       mov       r9,2336CC14750
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FF81AF8D210]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
       mov       rdx,7FF81AF9AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF81A6A0900
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
       mov       rdx,7FF81AF9AE40
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
       mov       rdx,7FF81AF9B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6A0900
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6A0908
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
       mov       rdx,7FF81AF9ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FF81AC9BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF81AF9B148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF8C180
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
       mov       rdx,7FF81AF9AE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FF81AC93318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FF81AF9AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF81A6A08F0
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
       mov       rdx,7FF81AF9AE40
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
       mov       rdx,7FF81AF9B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6A08F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6A08F8
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
       call      qword ptr [7FF81AB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FF81AD1DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD1D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD1F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB21C78]
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
       mov       r11,7FF81A6A0908
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
       mov       r11,7FF81A6A08F8
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E866E70
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
       mov       rdx,7FF80E8670F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,1EE10003020
       mov       r8,[r8]
       mov       r9,1EE100156F0
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
       mov       rdx,7FF80E867228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF80E1208C0
       call      qword ptr [7FF80E1208C0]
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
       mov       rdx,7FF80E867240
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
       mov       rdx,7FF80E867420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1208C0
       call      qword ptr [7FF80E1208C0]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1208C8
       call      qword ptr [7FF80E1208C8]
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
       mov       rdx,7FF80E8671D0
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
       mov       rdx,7FF80E867570
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
       mov       rdx,7FF80E867208
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
       mov       rdx,7FF80E867228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF80E1208B0
       call      qword ptr [7FF80E1208B0]
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
       mov       rdx,7FF80E867240
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
       mov       rdx,7FF80E867420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1208B0
       call      qword ptr [7FF80E1208B0]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1208B8
       call      qword ptr [7FF80E1208B8]
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
       mov       rdx,7FF80E5D5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FF80E5D5D70
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
       mov       rdx,7FF80E5D5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF80E5D5D70
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
       mov       r11,7FF80E1208C8
       call      qword ptr [7FF80E1208C8]
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
       mov       r11,7FF80E1208B8
       call      qword ptr [7FF80E1208B8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF6D3F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF6D9F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF7AA70
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
       call      qword ptr [7FF81ACFDD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,290574144C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,29057402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29057402028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FF81ACFDD80]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,290574144B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF81A9099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,29057402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,29057402028
       mov       rdx,[rdx]
       call      qword ptr [7FF81A8C1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF81ACFDEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB729F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB729F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81ACFD438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81ACFDAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81ACFF000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AABFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81ACFDAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AABFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF81AF7ACF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,29057402028
       mov       r8,[r8]
       mov       r9,29057414750
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FF81AF6D510]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
       mov       rdx,7FF81AF7AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF81A680900
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
       mov       rdx,7FF81AF7AE40
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
       mov       rdx,7FF81AF7B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF81A680900
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FF81A680908
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
       mov       rdx,7FF81AF7ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FF81AC7BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF81AF7B148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF6C480
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
       mov       rdx,7FF81AF7AE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FF81AC73318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FF81AF7AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF81A6808F0
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
       mov       rdx,7FF81AF7AE40
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
       mov       rdx,7FF81AF7B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6808F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6808F8
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
       call      qword ptr [7FF81AB01C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB01C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FF81ACFDEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB729F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB729F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81ACFD438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81ACFDAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81ACFF000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AABFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81ACFDAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AABFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB01C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB01C78]
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
       mov       r11,7FF81A680908
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
       mov       r11,7FF81A6808F8
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E876E70
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
       mov       rdx,7FF80E8770F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,1E6D47D3020
       mov       r8,[r8]
       mov       r9,1E6F47D1B38
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
       mov       rdx,7FF80E877228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF80E1308C0
       call      qword ptr [7FF80E1308C0]
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
       mov       rdx,7FF80E877240
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
       mov       rdx,7FF80E877420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1308C0
       call      qword ptr [7FF80E1308C0]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1308C8
       call      qword ptr [7FF80E1308C8]
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
       mov       rdx,7FF80E8771D0
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
       mov       rdx,7FF80E877570
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
       mov       rdx,7FF80E877208
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
       mov       rdx,7FF80E877228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF80E1308B0
       call      qword ptr [7FF80E1308B0]
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
       mov       rdx,7FF80E877240
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
       mov       rdx,7FF80E877420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1308B0
       call      qword ptr [7FF80E1308B0]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1308B8
       call      qword ptr [7FF80E1308B8]
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FF80E5E5D70
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF80E5E5D70
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
       mov       r11,7FF80E1308C8
       call      qword ptr [7FF80E1308C8]
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
       mov       r11,7FF80E1308B8
       call      qword ptr [7FF80E1308B8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF8D0F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF8D6F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF9AA70
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
       call      qword ptr [7FF81AD1DD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,20F0A0144C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,20F0A002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20F0A002028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FF81AD1DD80]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,20F0A0144B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,20F0A002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,20F0A002028
       mov       rdx,[rdx]
       call      qword ptr [7FF81A8E1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF81AD1DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD1D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD1F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF81AF9ACF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,20F0A002028
       mov       r8,[r8]
       mov       r9,20F0A014750
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FF81AF8D210]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
       mov       rdx,7FF81AF9AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF81A6A0900
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
       mov       rdx,7FF81AF9AE40
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
       mov       rdx,7FF81AF9B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6A0900
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6A0908
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
       mov       rdx,7FF81AF9ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FF81AC9BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF81AF9B148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF8C180
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
       mov       rdx,7FF81AF9AE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FF81AC93318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FF81AF9AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF81A6A08F0
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
       mov       rdx,7FF81AF9AE40
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
       mov       rdx,7FF81AF9B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6A08F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6A08F8
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
       call      qword ptr [7FF81AB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FF81AD1DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD1D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD1F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB21C78]
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
       mov       r11,7FF81A6A0908
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
       mov       r11,7FF81A6A08F8
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E896E70
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
       mov       rdx,7FF80E8970F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,1EC10523020
       mov       r8,[r8]
       mov       r9,1EC10536708
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
       mov       rdx,7FF80E897228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF80E1508C0
       call      qword ptr [7FF80E1508C0]
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
       mov       rdx,7FF80E897240
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
       mov       rdx,7FF80E897420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1508C0
       call      qword ptr [7FF80E1508C0]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1508C8
       call      qword ptr [7FF80E1508C8]
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
       mov       rdx,7FF80E8971D0
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
       mov       rdx,7FF80E897570
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
       mov       rdx,7FF80E897208
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
       mov       rdx,7FF80E897228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF80E1508B0
       call      qword ptr [7FF80E1508B0]
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
       mov       rdx,7FF80E897240
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
       mov       rdx,7FF80E897420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1508B0
       call      qword ptr [7FF80E1508B0]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1508B8
       call      qword ptr [7FF80E1508B8]
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
       mov       rdx,7FF80E605D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FF80E605D70
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
       mov       rdx,7FF80E605D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF80E605D70
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
       mov       r11,7FF80E1508C8
       call      qword ptr [7FF80E1508C8]
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
       mov       r11,7FF80E1508B8
       call      qword ptr [7FF80E1508B8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF8D0F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF8D6F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF9AA70
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
       call      qword ptr [7FF81AD1DD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,1D53F800910
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,1D53B802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D53B802028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FF81AD1DD80]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,1D53F8008F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,1D53B802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,1D53B802028
       mov       rdx,[rdx]
       call      qword ptr [7FF81A8E1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF81AD1DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD1D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD1F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF81AF9ACF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,1D53B802028
       mov       r8,[r8]
       mov       r9,1D53F800B98
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FF81AF8D210]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
       mov       rdx,7FF81AF9AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF81A6A0900
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
       mov       rdx,7FF81AF9AE40
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
       mov       rdx,7FF81AF9B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6A0900
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6A0908
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
       mov       rdx,7FF81AF9ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FF81AC9BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF81AF9B148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF8C180
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
       mov       rdx,7FF81AF9AE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FF81AC93318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FF81AF9AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF81A6A08F0
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
       mov       rdx,7FF81AF9AE40
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
       mov       rdx,7FF81AF9B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6A08F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6A08F8
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
       call      qword ptr [7FF81AB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FF81AD1DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB929F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD1D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD1F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD1DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AADFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB21C78]
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
       mov       r11,7FF81A6A0908
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
       mov       r11,7FF81A6A08F8
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E886E70
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
       mov       rdx,7FF80E8870F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,15BB3D03020
       mov       r8,[r8]
       mov       r9,15BB3D16708
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
       mov       rdx,7FF80E887228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF80E1408C0
       call      qword ptr [7FF80E1408C0]
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
       mov       rdx,7FF80E887240
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
       mov       rdx,7FF80E887420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1408C0
       call      qword ptr [7FF80E1408C0]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1408C8
       call      qword ptr [7FF80E1408C8]
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
       mov       rdx,7FF80E8871D0
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
       mov       rdx,7FF80E887570
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
       mov       rdx,7FF80E887208
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
       mov       rdx,7FF80E887228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF80E1408B0
       call      qword ptr [7FF80E1408B0]
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
       mov       rdx,7FF80E887240
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
       mov       rdx,7FF80E887420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1408B0
       call      qword ptr [7FF80E1408B0]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1408B8
       call      qword ptr [7FF80E1408B8]
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
       mov       rdx,7FF80E5F5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FF80E5F5D70
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
       mov       rdx,7FF80E5F5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF80E5F5D70
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
       mov       r11,7FF80E1408C8
       call      qword ptr [7FF80E1408C8]
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
       mov       r11,7FF80E1408B8
       call      qword ptr [7FF80E1408B8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF7D3F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF7D9F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF8AA70
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
       call      qword ptr [7FF81AD0DD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,250238144C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,25023802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25023802028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FF81AD0DD80]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,250238144B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF81A9199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,25023802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,25023802028
       mov       rdx,[rdx]
       call      qword ptr [7FF81A8D1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF81AD0DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB829F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB829F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD0D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD0DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD0F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AACFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD0DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AACFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF81AF8ACF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,25023802028
       mov       r8,[r8]
       mov       r9,25023814750
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FF81AF7D510]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
       mov       rdx,7FF81AF8AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF81A690900
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
       mov       rdx,7FF81AF8AE40
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
       mov       rdx,7FF81AF8B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF81A690900
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FF81A690908
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
       mov       rdx,7FF81AF8ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FF81AC8BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF81AF8B148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF7C480
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
       mov       rdx,7FF81AF8AE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FF81AC83318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FF81AF8AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF81A6908F0
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
       mov       rdx,7FF81AF8AE40
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
       mov       rdx,7FF81AF8B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6908F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6908F8
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
       call      qword ptr [7FF81AB11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FF81AD0DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB829F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB829F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD0D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD0DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD0F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AACFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD0DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AACFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB11C78]
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
       mov       r11,7FF81A690908
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
       mov       r11,7FF81A6908F8
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E876E70
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
       mov       rdx,7FF80E8770F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,25CD4B23020
       mov       r8,[r8]
       mov       r9,25D14B21B38
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
       mov       rdx,7FF80E877228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF80E1308C0
       call      qword ptr [7FF80E1308C0]
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
       mov       rdx,7FF80E877240
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
       mov       rdx,7FF80E877420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1308C0
       call      qword ptr [7FF80E1308C0]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1308C8
       call      qword ptr [7FF80E1308C8]
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
       mov       rdx,7FF80E8771D0
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
       mov       rdx,7FF80E877570
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
       mov       rdx,7FF80E877208
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
       mov       rdx,7FF80E877228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF80E1308B0
       call      qword ptr [7FF80E1308B0]
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
       mov       rdx,7FF80E877240
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
       mov       rdx,7FF80E877420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1308B0
       call      qword ptr [7FF80E1308B0]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1308B8
       call      qword ptr [7FF80E1308B8]
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FF80E5E5D70
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF80E5E5D70
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
       mov       r11,7FF80E1308C8
       call      qword ptr [7FF80E1308C8]
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
       mov       r11,7FF80E1308B8
       call      qword ptr [7FF80E1308B8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF7D0F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF7D6F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF8AA70
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
       call      qword ptr [7FF81AD0DD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,1F8EE0144C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,1F8EE002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F8EE002028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FF81AD0DD80]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,1F8EE0144B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF81A9199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,1F8EE002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,1F8EE002028
       mov       rdx,[rdx]
       call      qword ptr [7FF81A8D1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF81AD0DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB829F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB829F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD0D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD0DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD0F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AACFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD0DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AACFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF81AF8ACF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,1F8EE002028
       mov       r8,[r8]
       mov       r9,1F8EE014750
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FF81AF7D210]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
       mov       rdx,7FF81AF8AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF81A690900
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
       mov       rdx,7FF81AF8AE40
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
       mov       rdx,7FF81AF8B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF81A690900
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FF81A690908
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
       mov       rdx,7FF81AF8ADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FF81AC8BD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF81AF8B148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF7C180
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
       mov       rdx,7FF81AF8AE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FF81AC83318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FF81AF8AE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF81A6908F0
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
       mov       rdx,7FF81AF8AE40
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
       mov       rdx,7FF81AF8B020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6908F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6908F8
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
       call      qword ptr [7FF81AB11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FF81AD0DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81AB829F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81AB829F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD0D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD0DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD0F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AACFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD0DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AACFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB11C78]
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
       mov       r11,7FF81A690908
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
       mov       r11,7FF81A6908F8
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E876E70
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
       mov       rdx,7FF80E8770F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,2D6FF6E1028
       mov       r8,[r8]
       mov       r9,2D6FF6F36F8
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
       mov       rdx,7FF80E877228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF80E1308C0
       call      qword ptr [7FF80E1308C0]
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
       mov       rdx,7FF80E877240
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
       mov       rdx,7FF80E877420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1308C0
       call      qword ptr [7FF80E1308C0]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1308C8
       call      qword ptr [7FF80E1308C8]
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
       mov       rdx,7FF80E8771D0
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
       mov       rdx,7FF80E877570
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
       mov       rdx,7FF80E877208
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
       mov       rdx,7FF80E877228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF80E1308B0
       call      qword ptr [7FF80E1308B0]
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
       mov       rdx,7FF80E877240
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
       mov       rdx,7FF80E877420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1308B0
       call      qword ptr [7FF80E1308B0]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1308B8
       call      qword ptr [7FF80E1308B8]
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FF80E5E5D70
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF80E5E5D70
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
       mov       r11,7FF80E1308C8
       call      qword ptr [7FF80E1308C8]
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
       mov       r11,7FF80E1308B8
       call      qword ptr [7FF80E1308B8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF9D0F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D6F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AFAAA70
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
       call      qword ptr [7FF81AD2DD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,1F40BC00910
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,1F403C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F403C02028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FF81AD2DD80]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,1F40BC008F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF81A9399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,1F403C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,1F403C02028
       mov       rdx,[rdx]
       call      qword ptr [7FF81A8F1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF81AD2DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81ABA29F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81ABA29F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD2D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD2DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD2F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AAEFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD2DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AAEFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF81AFAACF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,1F403C02028
       mov       r8,[r8]
       mov       r9,1F40BC00B98
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FF81AF9D210]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
       mov       rdx,7FF81AFAAE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF81A6B0900
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
       mov       rdx,7FF81AFAAE40
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
       mov       rdx,7FF81AFAB020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6B0900
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6B0908
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
       mov       rdx,7FF81AFAADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FF81ACABD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF81AFAB148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF9C180
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
       mov       rdx,7FF81AFAAE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FF81ACA3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FF81AFAAE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF81A6B08F0
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
       mov       rdx,7FF81AFAAE40
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
       mov       rdx,7FF81AFAB020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6B08F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6B08F8
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
       call      qword ptr [7FF81AB31C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB31C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FF81AD2DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81ABA29F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81ABA29F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD2D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD2DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD2F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AAEFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD2DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AAEFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB31C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB31C78]
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
       mov       r11,7FF81A6B0908
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
       mov       r11,7FF81A6B08F8
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E886E70
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
       mov       rdx,7FF80E8870F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,20D25DF1028
       mov       r8,[r8]
       mov       r9,20D25E036F8
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
       mov       rdx,7FF80E887228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF80E1408C0
       call      qword ptr [7FF80E1408C0]
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
       mov       rdx,7FF80E887240
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
       mov       rdx,7FF80E887420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1408C0
       call      qword ptr [7FF80E1408C0]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1408C8
       call      qword ptr [7FF80E1408C8]
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
       mov       rdx,7FF80E8871D0
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
       mov       rdx,7FF80E887570
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
       mov       rdx,7FF80E887208
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
       mov       rdx,7FF80E887228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF80E1408B0
       call      qword ptr [7FF80E1408B0]
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
       mov       rdx,7FF80E887240
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
       mov       rdx,7FF80E887420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1408B0
       call      qword ptr [7FF80E1408B0]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1408B8
       call      qword ptr [7FF80E1408B8]
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
       mov       rdx,7FF80E5F5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FF80E5F5D70
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
       mov       rdx,7FF80E5F5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF80E5F5D70
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
       mov       r11,7FF80E1408C8
       call      qword ptr [7FF80E1408C8]
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
       mov       r11,7FF80E1408B8
       call      qword ptr [7FF80E1408B8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF9D3F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D9F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AFAAA70
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
       call      qword ptr [7FF81AD2DD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,2ABA34144C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,2ABA3402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2ABA3402028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FF81AD2DD80]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,2ABA34144B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF81A9399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,2ABA3402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,2ABA3402028
       mov       rdx,[rdx]
       call      qword ptr [7FF81A8F1C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF81AD2DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81ABA29F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81ABA29F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD2D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD2DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD2F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AAEFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD2DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AAEFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF81AFAACF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,2ABA3402028
       mov       r8,[r8]
       mov       r9,2ABA3414750
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FF81AF9D510]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
       mov       rdx,7FF81AFAAE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF81A6B0900
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
       mov       rdx,7FF81AFAAE40
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
       mov       rdx,7FF81AFAB020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6B0900
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6B0908
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
       mov       rdx,7FF81AFAADD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FF81ACABD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF81AFAB148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF9C480
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
       mov       rdx,7FF81AFAAE08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FF81ACA3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FF81AFAAE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF81A6B08F0
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
       mov       rdx,7FF81AFAAE40
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
       mov       rdx,7FF81AFAB020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6B08F0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6B08F8
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
       call      qword ptr [7FF81AB31C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB31C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FF81AD2DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81ABA29F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81ABA29F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD2D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD2DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD2F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AAEFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A8F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD2DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AAEFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB31C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB31C78]
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
       mov       r11,7FF81A6B0908
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
       mov       r11,7FF81A6B08F8
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E866E70
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
       mov       rdx,7FF80E8670F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L03:
       mov       r8,257C97B3020
       mov       r8,[r8]
       mov       r9,257C97C56F0
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
       mov       rdx,7FF80E867228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF80E1208C0
       call      qword ptr [7FF80E1208C0]
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
       mov       rdx,7FF80E867240
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
       mov       rdx,7FF80E867420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1208C0
       call      qword ptr [7FF80E1208C0]
       test      eax,eax
       jne       near ptr M01_L06
M01_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FF80E1208C8
       call      qword ptr [7FF80E1208C8]
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
       mov       rdx,7FF80E8671D0
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
       mov       rdx,7FF80E867570
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
       mov       rdx,7FF80E867208
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
       mov       rdx,7FF80E867228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF80E1208B0
       call      qword ptr [7FF80E1208B0]
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
       mov       rdx,7FF80E867240
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
       mov       rdx,7FF80E867420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1208B0
       call      qword ptr [7FF80E1208B0]
       test      eax,eax
       jne       near ptr M01_L22
M01_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FF80E1208B8
       call      qword ptr [7FF80E1208B8]
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
       mov       rdx,7FF80E5D5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FF80E5D5D70
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
       mov       rdx,7FF80E5D5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FF80E5D5D70
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
       mov       r11,7FF80E1208C8
       call      qword ptr [7FF80E1208C8]
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
       mov       r11,7FF80E1208B8
       call      qword ptr [7FF80E1208B8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AFAD0F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AFAD6F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AFBAA90
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
       call      qword ptr [7FF81AD3DD80]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L35
       lea       rcx,[rbx+0C]
       mov       rdx,1714FC144C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FF81A9499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L36
       lea       rcx,[rbx+16]
       mov       rdx,1714FC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1714FC02028
       mov       rcx,[rax]
       jmp       short M01_L02
M01_L05:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M01_L08
       call      qword ptr [7FF81AD3DD80]
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],0A
       jl        near ptr M01_L39
       lea       rcx,[r15+0C]
       mov       rdx,1714FC144B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FF81A9499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M01_L40
       lea       rcx,[r15+20]
       mov       rdx,1714FC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FF81A9499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
       mov       rdx,1714FC02028
       mov       rdx,[rdx]
       call      qword ptr [7FF81A901C60]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF81AD3DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81ABB29F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81ABB29F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD3D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD3DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD3F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AAFFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A903510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD3DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AAFFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       qword ptr [r15+28],0
       je        short M01_L09
       mov       rcx,[r15+28]
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF81AFBAD18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       r8,1714FC02028
       mov       r8,[r8]
       mov       r9,1714FC14750
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FF81AFAD210]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
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
       mov       rdx,7FF81AFBAE48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L12:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FF81A6C0908
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
       mov       rdx,7FF81AFBAE60
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
       mov       rdx,7FF81AFBB040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6C0908
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-40]
       mov       r11,7FF81A6C0910
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
       mov       rdx,7FF81AFBADF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L21:
       mov       rdx,rdi
       call      qword ptr [7FF81ACBBD38]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,7FF81AFBB168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L23:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AFAC180
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
       mov       rdx,7FF81AFBAE28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L26:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FF81ACB3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M01_L27
       mov       r11,[r15+40]
       test      r11,r11
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FF81AFBAE48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L28:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FF81A6C08F8
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
       mov       rdx,7FF81AFBAE60
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
       mov       rdx,7FF81AFBB040
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L33:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6C08F8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L29
M01_L34:
       mov       rcx,[rbp-48]
       mov       r11,7FF81A6C0900
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
       call      qword ptr [7FF81AB41C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L36:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB41C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L37:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L38
       call      qword ptr [7FF81AD3DEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81ABB29F8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF81ABB29F8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF81AD3D438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF81AD3DAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AD3F000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF81AAFFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L38:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FF81A903510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF81AD3DAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF81AAFFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L39:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB41C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L40:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF81AB41C78]
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
       mov       r11,7FF81A6C0910
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
       mov       r11,7FF81A6C0900
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8685B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E120910
       call      qword ptr [7FF80E120910]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF8D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF8D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF9C578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A6A0858
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
       mov       r11,7FF81A6A0860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB4B780]
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
       mov       r11,7FF81A6A0860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8885B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E140910
       call      qword ptr [7FF80E140910]
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
       mov       r11,7FF80E140918
       call      qword ptr [7FF80E140918]
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
       mov       r11,7FF80E140918
       call      qword ptr [7FF80E140918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF6D348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF6D3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF7C578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A680858
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
       mov       r11,7FF81A680860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB2B780]
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
       mov       r11,7FF81A680860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8785B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E130910
       call      qword ptr [7FF80E130910]
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
       mov       r11,7FF80E130918
       call      qword ptr [7FF80E130918]
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
       mov       r11,7FF80E130918
       call      qword ptr [7FF80E130918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF9D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AFAC578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A6B0858
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
       mov       r11,7FF81A6B0860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB5B780]
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
       mov       r11,7FF81A6B0860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8785B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E130910
       call      qword ptr [7FF80E130910]
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
       mov       r11,7FF80E130918
       call      qword ptr [7FF80E130918]
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
       mov       r11,7FF80E130918
       call      qword ptr [7FF80E130918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AFAD000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AFAD060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AFBC578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A6C0858
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
       mov       r11,7FF81A6C0860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB6B780]
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
       mov       r11,7FF81A6C0860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8685B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E120910
       call      qword ptr [7FF80E120910]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; BenchmarkDotNet.Autogenerated.Runnable_273.__ForDisassemblyDiagnoser__()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
;             if (NotEleven == 11)
;             ^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       cmp       dword ptr [rcx+2C8],0B
       jne       short M00_L00
;                 HasItemsWithCount();
;                 ^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       call      qword ptr [7FF81AB95E40]
M00_L00:
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 44
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8885B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E140910
       call      qword ptr [7FF80E140910]
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
       mov       r11,7FF80E140918
       call      qword ptr [7FF80E140918]
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
       mov       r11,7FF80E140918
       call      qword ptr [7FF80E140918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF8D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF8D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF9C578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A6A0858
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
       mov       r11,7FF81A6A0860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB4B780]
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
       mov       r11,7FF81A6A0860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8685B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E120910
       call      qword ptr [7FF80E120910]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF8D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF8D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF9C578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A6A0858
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
       mov       r11,7FF81A6A0860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB4B780]
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
       mov       r11,7FF81A6A0860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E868550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E120910
       call      qword ptr [7FF80E120910]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF7D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF7D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF8C578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A690858
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
       mov       r11,7FF81A690860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB3B780]
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
       mov       r11,7FF81A690860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8685B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E120910
       call      qword ptr [7FF80E120910]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF9D348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AFAC598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A6B0858
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
       mov       r11,7FF81A6B0860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB5B780]
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
       mov       r11,7FF81A6B0860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,297EE91E468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,297EE91E460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,297EE91E468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rdx,7FF80E877088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,297EE913020
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
       mov       rdx,7FF80E877200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,297EE913020
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FF80E5E5D70
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1C1E700D470
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C1E700D468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF9AFD8
       mov       [rbx+18],rdx
       mov       rcx,1C1E700D470
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
       call      qword ptr [7FF81A9F7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
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
       je        short M01_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M01_L01
M01_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M01_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M01_L00
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,1A
       call      qword ptr [7FF81AB577B0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1C16917E468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C16917E460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1C16917E468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rdx,7FF80E897088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,1C169173020
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
       mov       rdx,7FF80E897200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1C169173020
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
       mov       rdx,7FF80E605D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FF80E605D70
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1C45FC0D470
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C45FC0D468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF6C330
       mov       [rbx+18],rdx
       mov       rcx,1C45FC0D470
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
       call      qword ptr [7FF81A9C7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF6DCC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
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
       je        short M01_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M01_L01
M01_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M01_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M01_L00
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,1A
       call      qword ptr [7FF81AB277B0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,268D720E468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,268D720E460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,268D720E468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rdx,7FF80E887088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,268D7203020
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
       mov       rdx,7FF80E887200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,268D7203020
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
       mov       rdx,7FF80E5F5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FF80E5F5D70
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2156080D470
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2156080D468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AFAAFD8
       mov       [rbx+18],rdx
       mov       rcx,2156080D470
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
       call      qword ptr [7FF81AA07FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AFAD978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
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
       je        short M01_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M01_L01
M01_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M01_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M01_L00
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,1A
       call      qword ptr [7FF81AB677B0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1E01FA1E468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E01FA1E460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E01FA1E468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rdx,7FF80E877088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,1E01FA13020
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
       mov       rdx,7FF80E877200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1E01FA13020
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FF80E5E5D70
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1F19D00D470
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F19D00D468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF9AFD8
       mov       [rbx+18],rdx
       mov       rcx,1F19D00D470
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
       call      qword ptr [7FF81A9F7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
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
       je        short M01_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M01_L01
M01_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M01_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M01_L00
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,1A
       call      qword ptr [7FF81AB577B0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2D9EE40A060
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2D9EE40A058
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2D9EE40A060
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rdx,7FF80E877088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,2D9CE403020
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
       mov       rdx,7FF80E877200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,2D9CE403020
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
       mov       rdx,7FF80E5E5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FF80E5E5D70
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1CD1740D470
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CD1740D468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF9C330
       mov       [rbx+18],rdx
       mov       rcx,1CD1740D470
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
       call      qword ptr [7FF81A9F7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9DCC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
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
       je        short M01_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M01_L01
M01_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M01_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M01_L00
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,1A
       call      qword ptr [7FF81AB577B0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1F37C1DA060
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F37C1DA058
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1F37C1DA060
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rdx,7FF80E887088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,1F39C1D3020
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
       mov       rdx,7FF80E887200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1F39C1D3020
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
       mov       rdx,7FF80E5F5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FF80E5F5D70
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2077E80D470
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2077E80D468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF9AFD8
       mov       [rbx+18],rdx
       mov       rcx,2077E80D470
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
       call      qword ptr [7FF81A9F7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
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
       je        short M01_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M01_L01
M01_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M01_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M01_L00
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,1A
       call      qword ptr [7FF81AB577B0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,17219DAE468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,17219DAE460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,17219DAE468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rdx,7FF80E867088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,17219DA3020
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
       mov       rdx,7FF80E867200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,17219DA3020
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
       mov       rdx,7FF80E5D5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FF80E5D5D70
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1DCB380D470
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1DCB380D468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF9AFD8
       mov       [rbx+18],rdx
       mov       rcx,1DCB380D470
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
       call      qword ptr [7FF81A9F7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
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
       je        short M01_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M01_L01
M01_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M01_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M01_L00
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,1A
       call      qword ptr [7FF81AB577B0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1D97D10E468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D97D10E460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D97D10E468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rdx,7FF80E867088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,1D97D103020
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
       mov       rdx,7FF80E867200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1D97D103020
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
       mov       rdx,7FF80E5D5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FF80E5D5D70
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2007100D470
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2007100D468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF7AFD8
       mov       [rbx+18],rdx
       mov       rcx,2007100D470
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
       call      qword ptr [7FF81A9D7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF7D978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
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
       je        short M01_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M01_L01
M01_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M01_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M01_L00
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,1A
       call      qword ptr [7FF81AB377B0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,208C1E0E468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,208C1E0E460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,208C1E0E468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
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
       mov       rdx,7FF80E887088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,208C1E03020
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
       mov       rdx,7FF80E887200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,208C1E03020
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
       mov       rdx,7FF80E5F5D70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FF80E5F5D70
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2179540D470
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2179540D468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF81AF7AFD8
       mov       [rbx+18],rdx
       mov       rcx,2179540D470
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
       call      qword ptr [7FF81A9D7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF7D978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
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
       je        short M01_L03
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M01_L01
M01_L00:
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M01_L04
       mov       edx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L02
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M01_L00
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       ecx,1A
       call      qword ptr [7FF81AB377B0]
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8985A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E150910
       call      qword ptr [7FF80E150910]
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
       mov       r11,7FF80E150918
       call      qword ptr [7FF80E150918]
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
       mov       r11,7FF80E150918
       call      qword ptr [7FF80E150918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF6D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF6D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF7C568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A680858
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
       mov       r11,7FF81A680860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB2B780]
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
       mov       r11,7FF81A680860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8685A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E120910
       call      qword ptr [7FF80E120910]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF6D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF6D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF7C568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A680858
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
       mov       r11,7FF81A680860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB2B780]
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
       mov       r11,7FF81A680860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8785A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E130910
       call      qword ptr [7FF80E130910]
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
       mov       r11,7FF80E130918
       call      qword ptr [7FF80E130918]
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
       mov       r11,7FF80E130918
       call      qword ptr [7FF80E130918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF9D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AFAC568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A6B0858
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
       mov       r11,7FF81A6B0860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB5B780]
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
       mov       r11,7FF81A6B0860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8985A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E150910
       call      qword ptr [7FF80E150910]
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
       mov       r11,7FF80E150918
       call      qword ptr [7FF80E150918]
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
       mov       r11,7FF80E150918
       call      qword ptr [7FF80E150918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF9D348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AFAC568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A6B0858
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
       mov       r11,7FF81A6B0860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB5B780]
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
       mov       r11,7FF81A6B0860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8685A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E120910
       call      qword ptr [7FF80E120910]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF6D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF6D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF7C568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A680858
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
       mov       r11,7FF81A680860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB2B780]
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
       mov       r11,7FF81A680860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8685A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E120910
       call      qword ptr [7FF80E120910]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF6D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF6D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF7C568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A680858
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
       mov       r11,7FF81A680860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB2B780]
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
       mov       r11,7FF81A680860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8685A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E120910
       call      qword ptr [7FF80E120910]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       r11,7FF80E120918
       call      qword ptr [7FF80E120918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF6D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF6D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF7C568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A680858
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
       mov       r11,7FF81A680860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB2B780]
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
       mov       r11,7FF81A680860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8985A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E150910
       call      qword ptr [7FF80E150910]
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
       mov       r11,7FF80E150918
       call      qword ptr [7FF80E150918]
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
       mov       r11,7FF80E150918
       call      qword ptr [7FF80E150918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF8D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF8D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AF9C568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A6A0858
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
       mov       r11,7FF81A6A0860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB4B780]
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
       mov       r11,7FF81A6A0860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FF80E8585A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF80E110910
       call      qword ptr [7FF80E110910]
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
       mov       r11,7FF80E110918
       call      qword ptr [7FF80E110918]
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
       mov       r11,7FF80E110918
       call      qword ptr [7FF80E110918]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF81AF9D348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81AF9D3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF81AFAC588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FF81A6B0858
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
       mov       r11,7FF81A6B0860
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FF81AB5B780]
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
       mov       r11,7FF81A6B0860
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

