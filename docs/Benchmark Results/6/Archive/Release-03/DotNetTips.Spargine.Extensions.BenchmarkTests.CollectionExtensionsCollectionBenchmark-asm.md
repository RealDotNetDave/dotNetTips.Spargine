## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+240]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
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
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA9E8C148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFAA9E324F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFAA9E324F0
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
; Total bytes of code 162
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
       je        short M02_L00
       mov       rcx,[r15+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L29
       cmp       qword ptr [r15+28],0
       je        short M02_L02
       mov       rcx,[r15+28]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E63D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,1A705E23020
       mov       r8,[r8]
       mov       r9,1A6E5E21C80
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M02_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA9A10900
       call      qword ptr [7FFAA9A10900]
       test      eax,eax
       je        near ptr M02_L11
M02_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E66F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A10900
       call      qword ptr [7FFAA9A10900]
       test      eax,eax
       jne       near ptr M02_L06
M02_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A10908
       call      qword ptr [7FFAA9A10908]
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
M02_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E64A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M02_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
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
M02_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L18
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E64E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M02_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M02_L20
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA9A108F0
       call      qword ptr [7FFAA9A108F0]
       test      eax,eax
       je        near ptr M02_L27
M02_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L23
       jmp       short M02_L24
M02_L23:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L25
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E66F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A108F0
       call      qword ptr [7FFAA9A108F0]
       test      eax,eax
       jne       near ptr M02_L22
M02_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A108F8
       call      qword ptr [7FFAA9A108F8]
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
M02_L28:
       mov       ecx,4D
       mov       rdx,7FFAA9E324F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFAA9E324F0
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
M02_L29:
       mov       ecx,4D
       mov       rdx,7FFAA9E324F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFAA9E324F0
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
       je        short M02_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A10908
       call      qword ptr [7FFAA9A10908]
M02_L30:
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
       je        short M02_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A108F8
       call      qword ptr [7FFAA9A108F8]
M02_L31:
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rcx,[rsi+240]
       test      rcx,rcx
       jne       near ptr M00_L00
       call      qword ptr [7FFAA389B348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L01
       lea       rcx,[rdi+0C]
       mov       rdx,1527F004A60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA35499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L02
       lea       rcx,[rdi+12]
       mov       rdx,1527F002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA35499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA3501C60]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3895600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA389B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA366FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L00:
       call      qword ptr [7FFAA38D3DE0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,rax
       mov       r9,15283004A18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1527F002028
       mov       r9,[r9]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3895600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFAA3AE3F60]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFAA3B4D960]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+30],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA3B4F1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3691C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3691C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 488
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFAA3549A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M02_L00
       test      rsi,rsi
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M02_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFAA35499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAA35499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,1527F002028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3691C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3691C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M03_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M03_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M03_L03
       jmp       short M03_L02
M03_L01:
       xor       r9d,r9d
M03_L02:
       test      r8,r8
       je        short M03_L03
       cmp       dword ptr [r8+8],0
       je        short M03_L03
       mov       rcx,r8
       jmp       near ptr M03_L06
M03_L03:
       test      r9d,r9d
       jne       near ptr M03_L06
       call      qword ptr [7FFAA389B468]
       mov       rdi,rax
       test      rsi,rsi
       je        short M03_L04
       cmp       dword ptr [rsi+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rsi,rdi
M03_L05:
       mov       ecx,9
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3895600]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA389B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA389B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA366FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       test      dl,dl
       jne       short M03_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAA3503510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M04_L02
       call      qword ptr [7FFAA389B348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M04_L04
       lea       rcx,[rdi+0C]
       mov       rdx,1527F004A60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA35499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M04_L05
       lea       rcx,[rdi+12]
       mov       rdx,1527F002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA35499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA3501C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L06
       mov       eax,1
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L01
       call      qword ptr [7FFAA389B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3895600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA389B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA389B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA366FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA3503510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA389B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA366FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M04_L02:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFAA3951318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M04_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M04_L03
       mov       rdx,rax
       call      qword ptr [7FFAA346B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M04_L03:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFAA39DD120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3691C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3691C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M04_L00
; Total bytes of code 563
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAA3955150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFAA3955330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M05_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M05_L01
       jmp       short M05_L01
M05_L00:
       xor       edx,edx
M05_L01:
       test      edx,edx
       jne       near ptr M05_L02
       call      qword ptr [7FFAA389B468]
       mov       rsi,rax
       mov       ecx,625
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3895600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA389B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA389B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA366FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA3503510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFAA3AAB6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFAA3AE3FC0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
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
       je        short M06_L00
       mov       rcx,[r15+10]
       jmp       short M06_L01
M06_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5B5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M06_L04
       call      qword ptr [7FFAA389B348]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       dword ptr [r12+8],5
       jl        near ptr M06_L34
       lea       rcx,[r12+0C]
       mov       rdx,15283004710
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFAA35499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r12+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M06_L35
       lea       rcx,[r12+16]
       mov       rdx,1527F002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA35499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [7FFAA3501C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L36
       mov       eax,1
M06_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L03
       call      qword ptr [7FFAA389B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3895600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA389B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA389B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA366FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA3503510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA389B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA366FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L04:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M06_L07
       call      qword ptr [7FFAA389B348]
       mov       r15,rax
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M06_L37
       lea       rcx,[rsi+0C]
       mov       rdx,15283004720
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFAA35499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M06_L38
       lea       rcx,[rsi+20]
       mov       rdx,1527F002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA35499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFAA3501C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L39
       mov       eax,1
M06_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L06
       call      qword ptr [7FFAA389B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA37065E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3895600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA389B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA389B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA366FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L06:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA3503510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA389B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA366FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L07:
       cmp       qword ptr [r15+28],0
       je        short M06_L08
       mov       rcx,[r15+28]
       jmp       short M06_L09
M06_L08:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5B828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L09:
       mov       r8,1527F002028
       mov       r8,[r8]
       mov       r9,15283004CA8
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFAA3B4DCC0]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M06_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M06_L10
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M06_L10
       jmp       short M06_L11
M06_L10:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5B958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L11:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA32C0990
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L17
M06_L12:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L13
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5B970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L14:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5BB50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L16:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA32C0990
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L12
M06_L17:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA32C0998
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
M06_L18:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L19
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L19
       jmp       short M06_L20
M06_L19:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5B900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L20:
       mov       rdx,rdi
       call      qword ptr [7FFAA381B4C8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M06_L23
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M06_L21
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M06_L21
       jmp       short M06_L22
M06_L21:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5BC78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L22:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA3B4CC30
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L24
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M06_L24
       jmp       short M06_L25
M06_L24:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5B938
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L25:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFAA3811918]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M06_L26
       mov       r11,[r15+40]
       test      r11,r11
       je        short M06_L26
       jmp       short M06_L27
M06_L26:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5B958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L27:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA32C0980
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L33
M06_L28:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L29
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L29
       jmp       short M06_L30
M06_L29:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5B970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L30:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L31
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L31
       jmp       short M06_L32
M06_L31:
       mov       rcx,rsi
       mov       rdx,7FFAA3B5BB50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L32:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA32C0980
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L28
M06_L33:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA32C0988
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
M06_L34:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3691C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3691C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L36:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L02
M06_L37:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3691C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3691C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L39:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L05
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
       je        short M06_L40
       mov       rcx,[rbp-40]
       mov       r11,7FFAA32C0998
       call      qword ptr [r11]
M06_L40:
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
       je        short M06_L41
       mov       rcx,[rbp-48]
       mov       r11,7FFAA32C0988
       call      qword ptr [r11]
M06_L41:
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
; Total bytes of code 1964
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+240]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
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
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA9EBC148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFAA9E624F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFAA9E624F0
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
; Total bytes of code 162
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
       je        short M02_L00
       mov       rcx,[r15+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAA116148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L29
       cmp       qword ptr [r15+28],0
       je        short M02_L02
       mov       rcx,[r15+28]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAA1163D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,1DC407B3020
       mov       r8,[r8]
       mov       r9,1DC307B5C58
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M02_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAA116500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA9A40900
       call      qword ptr [7FFAA9A40900]
       test      eax,eax
       je        near ptr M02_L11
M02_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAA116518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAA1166F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A40900
       call      qword ptr [7FFAA9A40900]
       test      eax,eax
       jne       near ptr M02_L06
M02_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A40908
       call      qword ptr [7FFAA9A40908]
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
M02_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAA1164A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M02_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAA116848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
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
M02_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L18
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFAAA1164E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M02_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M02_L20
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFAAA116500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA9A408F0
       call      qword ptr [7FFAA9A408F0]
       test      eax,eax
       je        near ptr M02_L27
M02_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L23
       jmp       short M02_L24
M02_L23:
       mov       rcx,rsi
       mov       rdx,7FFAAA116518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L25
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       mov       rdx,7FFAAA1166F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A408F0
       call      qword ptr [7FFAA9A408F0]
       test      eax,eax
       jne       near ptr M02_L22
M02_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A408F8
       call      qword ptr [7FFAA9A408F8]
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
M02_L28:
       mov       ecx,4D
       mov       rdx,7FFAA9E624F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFAA9E624F0
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
M02_L29:
       mov       ecx,4D
       mov       rdx,7FFAA9E624F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFAA9E624F0
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
       je        short M02_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A40908
       call      qword ptr [7FFAA9A40908]
M02_L30:
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
       je        short M02_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A408F8
       call      qword ptr [7FFAA9A408F8]
M02_L31:
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rcx,[rsi+240]
       test      rcx,rcx
       jne       near ptr M00_L00
       call      qword ptr [7FFAAA8BB348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L01
       lea       rcx,[rdi+0C]
       mov       rdx,23540804A60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L02
       lea       rcx,[rdi+12]
       mov       rdx,23540802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAAA521C60]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAAA8BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L00:
       call      qword ptr [7FFAAA8F3DE0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,rax
       mov       r9,23542800A40
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23540802028
       mov       r9,[r9]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFAAAB03F60]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFAAAB6DC60]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+30],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAAB6F4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 488
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFAAA569A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M02_L00
       test      rsi,rsi
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M02_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,23540802028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M03_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M03_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M03_L03
       jmp       short M03_L02
M03_L01:
       xor       r9d,r9d
M03_L02:
       test      r8,r8
       je        short M03_L03
       cmp       dword ptr [r8+8],0
       je        short M03_L03
       mov       rcx,r8
       jmp       near ptr M03_L06
M03_L03:
       test      r9d,r9d
       jne       near ptr M03_L06
       call      qword ptr [7FFAAA8BB468]
       mov       rdi,rax
       test      rsi,rsi
       je        short M03_L04
       cmp       dword ptr [rsi+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rsi,rdi
M03_L05:
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAAA8BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA8BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       test      dl,dl
       jne       short M03_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAAA523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M04_L02
       call      qword ptr [7FFAAA8BB348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M04_L04
       lea       rcx,[rdi+0C]
       mov       rdx,23540804A60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M04_L05
       lea       rcx,[rdi+12]
       mov       rdx,23540802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAAA521C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L06
       mov       eax,1
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L01
       call      qword ptr [7FFAAA8BB468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAAA8BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA8BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAAA523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAAA8BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M04_L02:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFAAA971318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M04_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M04_L03
       mov       rdx,rax
       call      qword ptr [7FFAAA48B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M04_L03:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFAAA9FD120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M04_L00
; Total bytes of code 563
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAAA975150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFAAA975330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M05_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M05_L01
       jmp       short M05_L01
M05_L00:
       xor       edx,edx
M05_L01:
       test      edx,edx
       jne       near ptr M05_L02
       call      qword ptr [7FFAAA8BB468]
       mov       rsi,rax
       mov       ecx,625
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAAA8BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA8BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAAA523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAAACB6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFAAAB03FC0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
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
       je        short M06_L00
       mov       rcx,[r15+10]
       jmp       short M06_L01
M06_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M06_L04
       call      qword ptr [7FFAAA8BB348]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       dword ptr [r12+8],5
       jl        near ptr M06_L34
       lea       rcx,[r12+0C]
       mov       rdx,23542800738
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r12+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M06_L35
       lea       rcx,[r12+16]
       mov       rdx,23540802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [7FFAAA521C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L36
       mov       eax,1
M06_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L03
       call      qword ptr [7FFAAA8BB468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAAA8BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA8BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAAA523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAAA8BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L04:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M06_L07
       call      qword ptr [7FFAAA8BB348]
       mov       r15,rax
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M06_L37
       lea       rcx,[rsi+0C]
       mov       rdx,23542800748
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M06_L38
       lea       rcx,[rsi+20]
       mov       rdx,23540802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFAAA521C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L39
       mov       eax,1
M06_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L06
       call      qword ptr [7FFAAA8BB468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAAA8BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA8BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L06:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAAA523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAAA8BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L07:
       cmp       qword ptr [r15+28],0
       je        short M06_L08
       mov       rcx,[r15+28]
       jmp       short M06_L09
M06_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L09:
       mov       r8,23540802028
       mov       r8,[r8]
       mov       r9,23542800CD0
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFAAAB6DFC0]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M06_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M06_L10
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M06_L10
       jmp       short M06_L11
M06_L10:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L11:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAAA2E09A8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L17
M06_L12:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L13
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L14:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7BB50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L16:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAAA2E09A8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L12
M06_L17:
       mov       rcx,[rbp-40]
       mov       r11,7FFAAA2E09B0
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
M06_L18:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L19
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L19
       jmp       short M06_L20
M06_L19:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L20:
       mov       rdx,rdi
       call      qword ptr [7FFAAA83B4C8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M06_L23
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M06_L21
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M06_L21
       jmp       short M06_L22
M06_L21:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7BC78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L22:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAAAB6CF30
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L24
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M06_L24
       jmp       short M06_L25
M06_L24:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B938
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L25:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFAAA831918]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M06_L26
       mov       r11,[r15+40]
       test      r11,r11
       je        short M06_L26
       jmp       short M06_L27
M06_L26:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L27:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAAA2E0998
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L33
M06_L28:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L29
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L29
       jmp       short M06_L30
M06_L29:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L30:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L31
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L31
       jmp       short M06_L32
M06_L31:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7BB50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L32:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAAA2E0998
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L28
M06_L33:
       mov       rcx,[rbp-48]
       mov       r11,7FFAAA2E09A0
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
M06_L34:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L36:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L02
M06_L37:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L39:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L05
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
       je        short M06_L40
       mov       rcx,[rbp-40]
       mov       r11,7FFAAA2E09B0
       call      qword ptr [r11]
M06_L40:
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
       je        short M06_L41
       mov       rcx,[rbp-48]
       mov       r11,7FFAAA2E09A0
       call      qword ptr [r11]
M06_L41:
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
; Total bytes of code 1964
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+240]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
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
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA9EBC148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFAA9E624F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFAA9E624F0
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
; Total bytes of code 162
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
       je        short M02_L00
       mov       rcx,[r15+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAA116148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L29
       cmp       qword ptr [r15+28],0
       je        short M02_L02
       mov       rcx,[r15+28]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAA1163D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,1C3A22E3020
       mov       r8,[r8]
       mov       r9,1C3922E6470
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M02_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAA116500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA9A40900
       call      qword ptr [7FFAA9A40900]
       test      eax,eax
       je        near ptr M02_L11
M02_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAA116518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAA1166F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A40900
       call      qword ptr [7FFAA9A40900]
       test      eax,eax
       jne       near ptr M02_L06
M02_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A40908
       call      qword ptr [7FFAA9A40908]
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
M02_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAA1164A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M02_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAA116848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
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
M02_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L18
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFAAA1164E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M02_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M02_L20
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFAAA116500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA9A408F0
       call      qword ptr [7FFAA9A408F0]
       test      eax,eax
       je        near ptr M02_L27
M02_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L23
       jmp       short M02_L24
M02_L23:
       mov       rcx,rsi
       mov       rdx,7FFAAA116518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L25
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       mov       rdx,7FFAAA1166F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A408F0
       call      qword ptr [7FFAA9A408F0]
       test      eax,eax
       jne       near ptr M02_L22
M02_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A408F8
       call      qword ptr [7FFAA9A408F8]
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
M02_L28:
       mov       ecx,4D
       mov       rdx,7FFAA9E624F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFAA9E624F0
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
M02_L29:
       mov       ecx,4D
       mov       rdx,7FFAA9E624F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFAA9E624F0
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
       je        short M02_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A40908
       call      qword ptr [7FFAA9A40908]
M02_L30:
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
       je        short M02_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A408F8
       call      qword ptr [7FFAA9A408F8]
M02_L31:
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rcx,[rsi+240]
       test      rcx,rcx
       jne       near ptr M00_L00
       call      qword ptr [7FFAAA8BB348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L01
       lea       rcx,[rdi+0C]
       mov       rdx,1C56A000658
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L02
       lea       rcx,[rdi+12]
       mov       rdx,1C56E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAAA521C60]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAAA8BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L00:
       call      qword ptr [7FFAAA8F3DE0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,rax
       mov       r9,1C56A001258
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C56E002028
       mov       r9,[r9]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFAAAB03F60]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFAAAB6D960]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+30],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAAB6F1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 488
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFAAA569A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M02_L00
       test      rsi,rsi
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M02_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,1C56E002028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M03_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M03_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M03_L03
       jmp       short M03_L02
M03_L01:
       xor       r9d,r9d
M03_L02:
       test      r8,r8
       je        short M03_L03
       cmp       dword ptr [r8+8],0
       je        short M03_L03
       mov       rcx,r8
       jmp       near ptr M03_L06
M03_L03:
       test      r9d,r9d
       jne       near ptr M03_L06
       call      qword ptr [7FFAAA8BB468]
       mov       rdi,rax
       test      rsi,rsi
       je        short M03_L04
       cmp       dword ptr [rsi+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rsi,rdi
M03_L05:
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAAA8BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA8BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       test      dl,dl
       jne       short M03_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAAA523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M04_L02
       call      qword ptr [7FFAAA8BB348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M04_L04
       lea       rcx,[rdi+0C]
       mov       rdx,1C56A000658
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M04_L05
       lea       rcx,[rdi+12]
       mov       rdx,1C56E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAAA521C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L06
       mov       eax,1
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L01
       call      qword ptr [7FFAAA8BB468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAAA8BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA8BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAAA523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAAA8BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M04_L02:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFAAA971318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M04_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M04_L03
       mov       rdx,rax
       call      qword ptr [7FFAAA48B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M04_L03:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFAAA9FD120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M04_L00
; Total bytes of code 563
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAAA975150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFAAA975330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M05_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M05_L01
       jmp       short M05_L01
M05_L00:
       xor       edx,edx
M05_L01:
       test      edx,edx
       jne       near ptr M05_L02
       call      qword ptr [7FFAAA8BB468]
       mov       rsi,rax
       mov       ecx,625
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAAA8BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA8BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAAA523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFAAAACB6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFAAAB03FC0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
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
       je        short M06_L00
       mov       rcx,[r15+10]
       jmp       short M06_L01
M06_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M06_L04
       call      qword ptr [7FFAAA8BB348]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       dword ptr [r12+8],5
       jl        near ptr M06_L34
       lea       rcx,[r12+0C]
       mov       rdx,1C56A000F50
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r12+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M06_L35
       lea       rcx,[r12+16]
       mov       rdx,1C56E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [7FFAAA521C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L36
       mov       eax,1
M06_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L03
       call      qword ptr [7FFAAA8BB468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAAA8BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA8BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAAA523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAAA8BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L04:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M06_L07
       call      qword ptr [7FFAAA8BB348]
       mov       r15,rax
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M06_L37
       lea       rcx,[rsi+0C]
       mov       rdx,1C56A000F60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M06_L38
       lea       rcx,[rsi+20]
       mov       rdx,1C56E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAAA5699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFAAA521C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L39
       mov       eax,1
M06_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L06
       call      qword ptr [7FFAAA8BB468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAAA7265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAAA8B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAAA8BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA8BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L06:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAAA523510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAAA8BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAAA68FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L07:
       cmp       qword ptr [r15+28],0
       je        short M06_L08
       mov       rcx,[r15+28]
       jmp       short M06_L09
M06_L08:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L09:
       mov       r8,1C56E002028
       mov       r8,[r8]
       mov       r9,1C56A0014E8
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFAAAB6DCC0]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M06_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M06_L10
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M06_L10
       jmp       short M06_L11
M06_L10:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L11:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAAA2E09E0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L17
M06_L12:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L13
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L14:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7BB50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L16:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAAA2E09E0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L12
M06_L17:
       mov       rcx,[rbp-40]
       mov       r11,7FFAAA2E09E8
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
M06_L18:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L19
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L19
       jmp       short M06_L20
M06_L19:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L20:
       mov       rdx,rdi
       call      qword ptr [7FFAAA83B4C8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M06_L23
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M06_L21
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M06_L21
       jmp       short M06_L22
M06_L21:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7BC78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L22:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAAAB6CC30
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L24
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M06_L24
       jmp       short M06_L25
M06_L24:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B938
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L25:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFAAA831918]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M06_L26
       mov       r11,[r15+40]
       test      r11,r11
       je        short M06_L26
       jmp       short M06_L27
M06_L26:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L27:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAAA2E09D0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L33
M06_L28:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L29
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L29
       jmp       short M06_L30
M06_L29:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7B970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L30:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L31
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L31
       jmp       short M06_L32
M06_L31:
       mov       rcx,rsi
       mov       rdx,7FFAAAB7BB50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L32:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAAA2E09D0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L28
M06_L33:
       mov       rcx,[rbp-48]
       mov       r11,7FFAAA2E09D8
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
M06_L34:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L36:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L02
M06_L37:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAAA6B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L39:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L05
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
       je        short M06_L40
       mov       rcx,[rbp-40]
       mov       r11,7FFAAA2E09E8
       call      qword ptr [r11]
M06_L40:
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
       je        short M06_L41
       mov       rcx,[rbp-48]
       mov       r11,7FFAAA2E09D8
       call      qword ptr [r11]
M06_L41:
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
; Total bytes of code 1964
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+240]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
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
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA9EAC148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFAA9E524F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFAA9E524F0
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
; Total bytes of code 162
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
       je        short M02_L00
       mov       rcx,[r15+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAA106148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L29
       cmp       qword ptr [r15+28],0
       je        short M02_L02
       mov       rcx,[r15+28]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAA1063D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,1EFC1B03020
       mov       r8,[r8]
       mov       r9,1EFB1B06470
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M02_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAA106500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA9A30900
       call      qword ptr [7FFAA9A30900]
       test      eax,eax
       je        near ptr M02_L11
M02_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAA106518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAA1066F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A30900
       call      qword ptr [7FFAA9A30900]
       test      eax,eax
       jne       near ptr M02_L06
M02_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A30908
       call      qword ptr [7FFAA9A30908]
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
M02_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAA1064A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M02_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAA106848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
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
M02_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L18
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFAAA1064E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M02_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M02_L20
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFAAA106500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA9A308F0
       call      qword ptr [7FFAA9A308F0]
       test      eax,eax
       je        near ptr M02_L27
M02_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L23
       jmp       short M02_L24
M02_L23:
       mov       rcx,rsi
       mov       rdx,7FFAAA106518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L25
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       mov       rdx,7FFAAA1066F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A308F0
       call      qword ptr [7FFAA9A308F0]
       test      eax,eax
       jne       near ptr M02_L22
M02_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A308F8
       call      qword ptr [7FFAA9A308F8]
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
M02_L28:
       mov       ecx,4D
       mov       rdx,7FFAA9E524F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFAA9E524F0
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
M02_L29:
       mov       ecx,4D
       mov       rdx,7FFAA9E524F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFAA9E524F0
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
       je        short M02_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A30908
       call      qword ptr [7FFAA9A30908]
M02_L30:
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
       je        short M02_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A308F8
       call      qword ptr [7FFAA9A308F8]
M02_L31:
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rcx,[rsi+240]
       test      rcx,rcx
       jne       near ptr M00_L00
       call      qword ptr [7FFAA7A1B348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L01
       lea       rcx,[rdi+0C]
       mov       rdx,2648A000658
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA76C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L02
       lea       rcx,[rdi+12]
       mov       rdx,26488002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA7681C60]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A15600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A1B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA77EFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L00:
       call      qword ptr [7FFAA7A53DE0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,rax
       mov       r9,2648C000A40
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,26488002028
       mov       r9,[r9]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A15600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFAA7C63F60]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFAA7CCD960]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+30],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7CCF1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7811C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7811C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 488
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFAA76C9A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M02_L00
       test      rsi,rsi
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M02_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFAA76C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAA76C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,26488002028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7811C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7811C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M03_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M03_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M03_L03
       jmp       short M03_L02
M03_L01:
       xor       r9d,r9d
M03_L02:
       test      r8,r8
       je        short M03_L03
       cmp       dword ptr [r8+8],0
       je        short M03_L03
       mov       rcx,r8
       jmp       near ptr M03_L06
M03_L03:
       test      r9d,r9d
       jne       near ptr M03_L06
       call      qword ptr [7FFAA7A1B468]
       mov       rdi,rax
       test      rsi,rsi
       je        short M03_L04
       cmp       dword ptr [rsi+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rsi,rdi
M03_L05:
       mov       ecx,9
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A15600]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A1B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A1B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA77EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       test      dl,dl
       jne       short M03_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAA7683510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M04_L02
       call      qword ptr [7FFAA7A1B348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M04_L04
       lea       rcx,[rdi+0C]
       mov       rdx,2648A000658
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA76C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M04_L05
       lea       rcx,[rdi+12]
       mov       rdx,26488002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA7681C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L06
       mov       eax,1
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L01
       call      qword ptr [7FFAA7A1B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A15600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A1B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A1B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA77EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA7683510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A1B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA77EFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M04_L02:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFAA7AD1318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M04_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M04_L03
       mov       rdx,rax
       call      qword ptr [7FFAA75EB8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M04_L03:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFAA7B5D120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7811C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7811C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M04_L00
; Total bytes of code 563
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAA7AD5150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFAA7AD5330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M05_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M05_L01
       jmp       short M05_L01
M05_L00:
       xor       edx,edx
M05_L01:
       test      edx,edx
       jne       near ptr M05_L02
       call      qword ptr [7FFAA7A1B468]
       mov       rsi,rax
       mov       ecx,625
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A15600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A1B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A1B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA77EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA7683510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFAA7C2B6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFAA7C63FC0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
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
       je        short M06_L00
       mov       rcx,[r15+10]
       jmp       short M06_L01
M06_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDB5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M06_L04
       call      qword ptr [7FFAA7A1B348]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       dword ptr [r12+8],5
       jl        near ptr M06_L34
       lea       rcx,[r12+0C]
       mov       rdx,2648C000738
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFAA76C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r12+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M06_L35
       lea       rcx,[r12+16]
       mov       rdx,26488002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [7FFAA7681C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L36
       mov       eax,1
M06_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L03
       call      qword ptr [7FFAA7A1B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A15600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A1B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A1B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA77EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA7683510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A1B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA77EFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L04:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M06_L07
       call      qword ptr [7FFAA7A1B348]
       mov       r15,rax
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M06_L37
       lea       rcx,[rsi+0C]
       mov       rdx,2648C000748
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFAA76C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M06_L38
       lea       rcx,[rsi+20]
       mov       rdx,26488002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFAA7681C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L39
       mov       eax,1
M06_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L06
       call      qword ptr [7FFAA7A1B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78865E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A15600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A1B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A1B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA77EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L06:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA7683510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A1B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA77EFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L07:
       cmp       qword ptr [r15+28],0
       je        short M06_L08
       mov       rcx,[r15+28]
       jmp       short M06_L09
M06_L08:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDB828
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L09:
       mov       r8,26488002028
       mov       r8,[r8]
       mov       r9,2648C000CD0
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFAA7CCDCC0]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M06_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M06_L10
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M06_L10
       jmp       short M06_L11
M06_L10:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDB958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L11:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA74409E0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L17
M06_L12:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L13
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDB970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L14:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDBB50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L16:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA74409E0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L12
M06_L17:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA74409E8
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
M06_L18:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L19
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L19
       jmp       short M06_L20
M06_L19:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDB900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L20:
       mov       rdx,rdi
       call      qword ptr [7FFAA799B4C8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M06_L23
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M06_L21
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M06_L21
       jmp       short M06_L22
M06_L21:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDBC78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L22:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA7CCCC30
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L24
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M06_L24
       jmp       short M06_L25
M06_L24:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDB938
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L25:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFAA7991918]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M06_L26
       mov       r11,[r15+40]
       test      r11,r11
       je        short M06_L26
       jmp       short M06_L27
M06_L26:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDB958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L27:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA74409D0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L33
M06_L28:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L29
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L29
       jmp       short M06_L30
M06_L29:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDB970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L30:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L31
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L31
       jmp       short M06_L32
M06_L31:
       mov       rcx,rsi
       mov       rdx,7FFAA7CDBB50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L32:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA74409D0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L28
M06_L33:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA74409D8
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
M06_L34:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7811C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7811C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L36:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L02
M06_L37:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7811C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7811C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L39:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L05
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
       je        short M06_L40
       mov       rcx,[rbp-40]
       mov       r11,7FFAA74409E8
       call      qword ptr [r11]
M06_L40:
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
       je        short M06_L41
       mov       rcx,[rbp-48]
       mov       r11,7FFAA74409D8
       call      qword ptr [r11]
M06_L41:
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
; Total bytes of code 1964
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+240]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
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
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA9E8C148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFAA9E324F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFAA9E324F0
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
; Total bytes of code 162
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
       je        short M02_L00
       mov       rcx,[r15+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L29
       cmp       qword ptr [r15+28],0
       je        short M02_L02
       mov       rcx,[r15+28]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E63D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,24E339C3020
       mov       r8,[r8]
       mov       r9,24E139C2C98
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M02_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA9A10900
       call      qword ptr [7FFAA9A10900]
       test      eax,eax
       je        near ptr M02_L11
M02_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E66F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A10900
       call      qword ptr [7FFAA9A10900]
       test      eax,eax
       jne       near ptr M02_L06
M02_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A10908
       call      qword ptr [7FFAA9A10908]
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
M02_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E64A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M02_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
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
M02_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L18
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E64E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M02_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M02_L20
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA9A108F0
       call      qword ptr [7FFAA9A108F0]
       test      eax,eax
       je        near ptr M02_L27
M02_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L23
       jmp       short M02_L24
M02_L23:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E6518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L25
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       mov       rdx,7FFAAA0E66F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A108F0
       call      qword ptr [7FFAA9A108F0]
       test      eax,eax
       jne       near ptr M02_L22
M02_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A108F8
       call      qword ptr [7FFAA9A108F8]
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
M02_L28:
       mov       ecx,4D
       mov       rdx,7FFAA9E324F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFAA9E324F0
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
M02_L29:
       mov       ecx,4D
       mov       rdx,7FFAA9E324F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFAA9E324F0
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
       je        short M02_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A10908
       call      qword ptr [7FFAA9A10908]
M02_L30:
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
       je        short M02_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A108F8
       call      qword ptr [7FFAA9A108F8]
M02_L31:
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rcx,[rsi+240]
       test      rcx,rcx
       jne       near ptr M00_L00
       call      qword ptr [7FFAA31BB348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L01
       lea       rcx,[rdi+0C]
       mov       rdx,1EF33008A38
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA2E699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L02
       lea       rcx,[rdi+12]
       mov       rdx,1EF33002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA2E699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA2E21C60]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA31B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA31BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA2F8FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L00:
       call      qword ptr [7FFAA31F3DE0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,rax
       mov       r9,1EF3300A650
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1EF33002028
       mov       r9,[r9]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA31B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFAA3403F60]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFAA346D960]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+30],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA346F1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA2FB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA2FB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 488
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFAA2E69A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M02_L00
       test      rsi,rsi
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M02_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFAA2E699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAA2E699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,1EF33002028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA2FB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA2FB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M03_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M03_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M03_L03
       jmp       short M03_L02
M03_L01:
       xor       r9d,r9d
M03_L02:
       test      r8,r8
       je        short M03_L03
       cmp       dword ptr [r8+8],0
       je        short M03_L03
       mov       rcx,r8
       jmp       near ptr M03_L06
M03_L03:
       test      r9d,r9d
       jne       near ptr M03_L06
       call      qword ptr [7FFAA31BB468]
       mov       rdi,rax
       test      rsi,rsi
       je        short M03_L04
       cmp       dword ptr [rsi+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rsi,rdi
M03_L05:
       mov       ecx,9
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA31B5600]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA31BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA31BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA2F8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       test      dl,dl
       jne       short M03_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAA2E23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M04_L02
       call      qword ptr [7FFAA31BB348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M04_L04
       lea       rcx,[rdi+0C]
       mov       rdx,1EF33008A38
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA2E699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M04_L05
       lea       rcx,[rdi+12]
       mov       rdx,1EF33002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA2E699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA2E21C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L06
       mov       eax,1
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L01
       call      qword ptr [7FFAA31BB468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA31B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA31BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA31BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA2F8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA2E23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA31BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA2F8FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M04_L02:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFAA3271318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M04_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M04_L03
       mov       rdx,rax
       call      qword ptr [7FFAA2D8B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M04_L03:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFAA32FD120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA2FB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA2FB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M04_L00
; Total bytes of code 563
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAA3275150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFAA3275330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M05_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M05_L01
       jmp       short M05_L01
M05_L00:
       xor       edx,edx
M05_L01:
       test      edx,edx
       jne       near ptr M05_L02
       call      qword ptr [7FFAA31BB468]
       mov       rsi,rax
       mov       ecx,625
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA31B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA31BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA31BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA2F8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA2E23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFAA33CB6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFAA3403FC0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
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
       je        short M06_L00
       mov       rcx,[r15+10]
       jmp       short M06_L01
M06_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA347B5C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M06_L04
       call      qword ptr [7FFAA31BB348]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       dword ptr [r12+8],5
       jl        near ptr M06_L34
       lea       rcx,[r12+0C]
       mov       rdx,1EF3300A348
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFAA2E699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r12+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M06_L35
       lea       rcx,[r12+16]
       mov       rdx,1EF33002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA2E699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [7FFAA2E21C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L36
       mov       eax,1
M06_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L03
       call      qword ptr [7FFAA31BB468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA31B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA31BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA31BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA2F8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA2E23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA31BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA2F8FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L04:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M06_L07
       call      qword ptr [7FFAA31BB348]
       mov       r15,rax
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M06_L37
       lea       rcx,[rsi+0C]
       mov       rdx,1EF3300A358
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFAA2E699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M06_L38
       lea       rcx,[rsi+20]
       mov       rdx,1EF33002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA2E699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFAA2E21C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L39
       mov       eax,1
M06_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L06
       call      qword ptr [7FFAA31BB468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA30265E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA31B5600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA31BB090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA31BB528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA2F8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L06:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA2E23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA31BB090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA2F8FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L07:
       cmp       qword ptr [r15+28],0
       je        short M06_L08
       mov       rcx,[r15+28]
       jmp       short M06_L09
M06_L08:
       mov       rcx,rsi
       mov       rdx,7FFAA347B848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L09:
       mov       r8,1EF33002028
       mov       r8,[r8]
       mov       r9,1EF3300A8E0
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFAA346DCC0]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M06_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M06_L10
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M06_L10
       jmp       short M06_L11
M06_L10:
       mov       rcx,rsi
       mov       rdx,7FFAA347B978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L11:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA2BE09C0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L17
M06_L12:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L13
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rsi
       mov       rdx,7FFAA347B990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L14:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rcx,rsi
       mov       rdx,7FFAA347BB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L16:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA2BE09C0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L12
M06_L17:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA2BE09C8
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
M06_L18:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L19
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L19
       jmp       short M06_L20
M06_L19:
       mov       rcx,rsi
       mov       rdx,7FFAA347B920
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L20:
       mov       rdx,rdi
       call      qword ptr [7FFAA313B4C8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M06_L23
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M06_L21
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M06_L21
       jmp       short M06_L22
M06_L21:
       mov       rcx,rsi
       mov       rdx,7FFAA347BC98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L22:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA346CC30
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L24
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M06_L24
       jmp       short M06_L25
M06_L24:
       mov       rcx,rsi
       mov       rdx,7FFAA347B958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L25:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFAA3131918]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M06_L26
       mov       r11,[r15+40]
       test      r11,r11
       je        short M06_L26
       jmp       short M06_L27
M06_L26:
       mov       rcx,rsi
       mov       rdx,7FFAA347B978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L27:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA2BE09B0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L33
M06_L28:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L29
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L29
       jmp       short M06_L30
M06_L29:
       mov       rcx,rsi
       mov       rdx,7FFAA347B990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L30:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L31
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L31
       jmp       short M06_L32
M06_L31:
       mov       rcx,rsi
       mov       rdx,7FFAA347BB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L32:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA2BE09B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L28
M06_L33:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA2BE09B8
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
M06_L34:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA2FB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA2FB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L36:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L02
M06_L37:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA2FB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA2FB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L39:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L05
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
       je        short M06_L40
       mov       rcx,[rbp-40]
       mov       r11,7FFAA2BE09C8
       call      qword ptr [r11]
M06_L40:
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
       je        short M06_L41
       mov       rcx,[rbp-48]
       mov       r11,7FFAA2BE09B8
       call      qword ptr [r11]
M06_L41:
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
; Total bytes of code 1964
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+240]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
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
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA9E9C148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFAA9E424F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFAA9E424F0
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
; Total bytes of code 162
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
       je        short M02_L00
       mov       rcx,[r15+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F6148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L29
       cmp       qword ptr [r15+28],0
       je        short M02_L02
       mov       rcx,[r15+28]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F63D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,27490EF3020
       mov       r8,[r8]
       mov       r9,27490EF6088
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M02_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F6500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA9A20900
       call      qword ptr [7FFAA9A20900]
       test      eax,eax
       je        near ptr M02_L11
M02_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F6518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F66F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A20900
       call      qword ptr [7FFAA9A20900]
       test      eax,eax
       jne       near ptr M02_L06
M02_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A20908
       call      qword ptr [7FFAA9A20908]
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
M02_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F64A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M02_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F6848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
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
M02_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L18
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F64E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M02_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M02_L20
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F6500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA9A208F0
       call      qword ptr [7FFAA9A208F0]
       test      eax,eax
       je        near ptr M02_L27
M02_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L23
       jmp       short M02_L24
M02_L23:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F6518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L25
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       mov       rdx,7FFAAA0F66F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A208F0
       call      qword ptr [7FFAA9A208F0]
       test      eax,eax
       jne       near ptr M02_L22
M02_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A208F8
       call      qword ptr [7FFAA9A208F8]
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
M02_L28:
       mov       ecx,4D
       mov       rdx,7FFAA9E424F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFAA9E424F0
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
M02_L29:
       mov       ecx,4D
       mov       rdx,7FFAA9E424F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFAA9E424F0
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
       je        short M02_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A20908
       call      qword ptr [7FFAA9A20908]
M02_L30:
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
       je        short M02_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A208F8
       call      qword ptr [7FFAA9A208F8]
M02_L31:
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rcx,[rsi+240]
       test      rcx,rcx
       jne       near ptr M00_L00
       call      qword ptr [7FFAA388B348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L01
       lea       rcx,[rdi+0C]
       mov       rdx,1A908C04A60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA35399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L02
       lea       rcx,[rdi+12]
       mov       rdx,1A908C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA35399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA34F1C60]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3885600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA388B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA365FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L00:
       call      qword ptr [7FFAA38C3DE0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,rax
       mov       r9,1A904C00A40
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1A908C02028
       mov       r9,[r9]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3885600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFAA3AD3F60]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFAA3B3D960]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+30],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA3B3F1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3681C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3681C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 488
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFAA3539A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M02_L00
       test      rsi,rsi
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M02_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFAA35399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAA35399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,1A908C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3681C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3681C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M03_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M03_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M03_L03
       jmp       short M03_L02
M03_L01:
       xor       r9d,r9d
M03_L02:
       test      r8,r8
       je        short M03_L03
       cmp       dword ptr [r8+8],0
       je        short M03_L03
       mov       rcx,r8
       jmp       near ptr M03_L06
M03_L03:
       test      r9d,r9d
       jne       near ptr M03_L06
       call      qword ptr [7FFAA388B468]
       mov       rdi,rax
       test      rsi,rsi
       je        short M03_L04
       cmp       dword ptr [rsi+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rsi,rdi
M03_L05:
       mov       ecx,9
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3885600]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA388B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA388B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA365FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       test      dl,dl
       jne       short M03_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAA34F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M04_L02
       call      qword ptr [7FFAA388B348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M04_L04
       lea       rcx,[rdi+0C]
       mov       rdx,1A908C04A60
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA35399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M04_L05
       lea       rcx,[rdi+12]
       mov       rdx,1A908C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA35399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA34F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L06
       mov       eax,1
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L01
       call      qword ptr [7FFAA388B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3885600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA388B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA388B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA365FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA34F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA388B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA365FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M04_L02:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFAA3941318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M04_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M04_L03
       mov       rdx,rax
       call      qword ptr [7FFAA345B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M04_L03:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFAA39CD120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3681C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3681C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M04_L00
; Total bytes of code 563
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAA3945150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFAA3945330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M05_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M05_L01
       jmp       short M05_L01
M05_L00:
       xor       edx,edx
M05_L01:
       test      edx,edx
       jne       near ptr M05_L02
       call      qword ptr [7FFAA388B468]
       mov       rsi,rax
       mov       ecx,625
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3885600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA388B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA388B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA365FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA34F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFAA3A9B6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFAA3AD3FC0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
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
       je        short M06_L00
       mov       rcx,[r15+10]
       jmp       short M06_L01
M06_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4B5E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M06_L04
       call      qword ptr [7FFAA388B348]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       dword ptr [r12+8],5
       jl        near ptr M06_L34
       lea       rcx,[r12+0C]
       mov       rdx,1A904C00738
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFAA35399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r12+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M06_L35
       lea       rcx,[r12+16]
       mov       rdx,1A908C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA35399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [7FFAA34F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L36
       mov       eax,1
M06_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L03
       call      qword ptr [7FFAA388B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3885600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA388B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA388B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA365FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA34F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA388B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA365FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L04:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M06_L07
       call      qword ptr [7FFAA388B348]
       mov       r15,rax
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M06_L37
       lea       rcx,[rsi+0C]
       mov       rdx,1A904C00748
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFAA35399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M06_L38
       lea       rcx,[rsi+20]
       mov       rdx,1A908C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA35399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFAA34F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L39
       mov       eax,1
M06_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L06
       call      qword ptr [7FFAA388B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA36F65E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA3885600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA388B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA388B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA365FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L06:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA34F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA388B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA365FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L07:
       cmp       qword ptr [r15+28],0
       je        short M06_L08
       mov       rcx,[r15+28]
       jmp       short M06_L09
M06_L08:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4B868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L09:
       mov       r8,1A908C02028
       mov       r8,[r8]
       mov       r9,1A904C00CD0
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFAA3B3DCC0]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M06_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M06_L10
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M06_L10
       jmp       short M06_L11
M06_L10:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4B998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L11:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA32B09E0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L17
M06_L12:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L13
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4B9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L14:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4BB90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L16:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA32B09E0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L12
M06_L17:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA32B09E8
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
M06_L18:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L19
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L19
       jmp       short M06_L20
M06_L19:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4B940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L20:
       mov       rdx,rdi
       call      qword ptr [7FFAA380B4C8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M06_L23
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M06_L21
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M06_L21
       jmp       short M06_L22
M06_L21:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4BCB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L22:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA3B3CC30
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L24
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M06_L24
       jmp       short M06_L25
M06_L24:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4B978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L25:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFAA3801918]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M06_L26
       mov       r11,[r15+40]
       test      r11,r11
       je        short M06_L26
       jmp       short M06_L27
M06_L26:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4B998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L27:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA32B09D0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L33
M06_L28:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L29
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L29
       jmp       short M06_L30
M06_L29:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4B9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L30:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L31
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L31
       jmp       short M06_L32
M06_L31:
       mov       rcx,rsi
       mov       rdx,7FFAA3B4BB90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L32:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA32B09D0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L28
M06_L33:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA32B09D8
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
M06_L34:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3681C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3681C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L36:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L02
M06_L37:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3681C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA3681C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L39:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L05
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
       je        short M06_L40
       mov       rcx,[rbp-40]
       mov       r11,7FFAA32B09E8
       call      qword ptr [r11]
M06_L40:
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
       je        short M06_L41
       mov       rcx,[rbp-48]
       mov       r11,7FFAA32B09D8
       call      qword ptr [r11]
M06_L41:
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
; Total bytes of code 1964
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+240]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
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
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA9EF3DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFAA9E624F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFAA9E624F0
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
; Total bytes of code 162
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
       je        short M02_L00
       mov       rcx,[r15+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAA127148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L29
       cmp       qword ptr [r15+28],0
       je        short M02_L02
       mov       rcx,[r15+28]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAA1273D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,237D8BD3020
       mov       r8,[r8]
       mov       r9,237D8BD6088
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M02_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAA127500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA9A40928
       call      qword ptr [7FFAA9A40928]
       test      eax,eax
       je        near ptr M02_L11
M02_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAA127518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAA1276F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A40928
       call      qword ptr [7FFAA9A40928]
       test      eax,eax
       jne       near ptr M02_L06
M02_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A40930
       call      qword ptr [7FFAA9A40930]
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
M02_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAA1274A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M02_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAA127848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
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
M02_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L18
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFAAA1274E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M02_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M02_L20
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFAAA127500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA9A40918
       call      qword ptr [7FFAA9A40918]
       test      eax,eax
       je        near ptr M02_L27
M02_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L23
       jmp       short M02_L24
M02_L23:
       mov       rcx,rsi
       mov       rdx,7FFAAA127518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L25
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       mov       rdx,7FFAAA1276F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A40918
       call      qword ptr [7FFAA9A40918]
       test      eax,eax
       jne       near ptr M02_L22
M02_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A40920
       call      qword ptr [7FFAA9A40920]
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
M02_L28:
       mov       ecx,4D
       mov       rdx,7FFAA9E624F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFAA9E624F0
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
M02_L29:
       mov       ecx,4D
       mov       rdx,7FFAA9E624F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFAA9E624F0
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
       je        short M02_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A40930
       call      qword ptr [7FFAA9A40930]
M02_L30:
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
       je        short M02_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A40920
       call      qword ptr [7FFAA9A40920]
M02_L31:
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rcx,[rsi+240]
       test      rcx,rcx
       jne       near ptr M00_L00
       call      qword ptr [7FFAA7A3B348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L01
       lea       rcx,[rdi+0C]
       mov       rdx,1F8E5C08A38
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA76E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L02
       lea       rcx,[rdi+12]
       mov       rdx,1F8E5C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA76A1C60]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A35600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A3B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA780FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L00:
       call      qword ptr [7FFAA7A73DE0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,rax
       mov       r9,1F8E1C00A48
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F8E5C02028
       mov       r9,[r9]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A35600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFAA7CBDF60]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFAA7D370F0]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+30],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7D37930]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7831C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7831C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 488
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFAA76E9A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M02_L00
       test      rsi,rsi
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M02_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFAA76E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAA76E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,1F8E5C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7831C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7831C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M03_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M03_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M03_L03
       jmp       short M03_L02
M03_L01:
       xor       r9d,r9d
M03_L02:
       test      r8,r8
       je        short M03_L03
       cmp       dword ptr [r8+8],0
       je        short M03_L03
       mov       rcx,r8
       jmp       near ptr M03_L06
M03_L03:
       test      r9d,r9d
       jne       near ptr M03_L06
       call      qword ptr [7FFAA7A3B468]
       mov       rdi,rax
       test      rsi,rsi
       je        short M03_L04
       cmp       dword ptr [rsi+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rsi,rdi
M03_L05:
       mov       ecx,9
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A35600]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A3B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A3B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA780FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       test      dl,dl
       jne       short M03_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAA76A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M04_L02
       call      qword ptr [7FFAA7A3B348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M04_L04
       lea       rcx,[rdi+0C]
       mov       rdx,1F8E5C08A38
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA76E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M04_L05
       lea       rcx,[rdi+12]
       mov       rdx,1F8E5C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA76A1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L06
       mov       eax,1
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L01
       call      qword ptr [7FFAA7A3B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A35600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A3B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A3B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA780FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA76A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A3B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA780FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M04_L02:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFAA7AFB480]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M04_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M04_L03
       mov       rdx,rax
       call      qword ptr [7FFAA760B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M04_L03:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFAA7BB7120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7831C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7831C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M04_L00
; Total bytes of code 563
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAA7AFF150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFAA7AFF330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M05_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M05_L01
       jmp       short M05_L01
M05_L00:
       xor       edx,edx
M05_L01:
       test      edx,edx
       jne       near ptr M05_L02
       call      qword ptr [7FFAA7A3B468]
       mov       rsi,rax
       mov       ecx,625
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A35600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A3B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A3B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA780FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA76A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFAA7C9ADE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFAA7CBDFC0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
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
       je        short M06_L00
       mov       rcx,[r15+10]
       jmp       short M06_L01
M06_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2BEB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M06_L04
       call      qword ptr [7FFAA7A3B348]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       dword ptr [r12+8],5
       jl        near ptr M06_L34
       lea       rcx,[r12+0C]
       mov       rdx,1F8E1C00738
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFAA76E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r12+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M06_L35
       lea       rcx,[r12+16]
       mov       rdx,1F8E5C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [7FFAA76A1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L36
       mov       eax,1
M06_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L03
       call      qword ptr [7FFAA7A3B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A35600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A3B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A3B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA780FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA76A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A3B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA780FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L04:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M06_L07
       call      qword ptr [7FFAA7A3B348]
       mov       r15,rax
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M06_L37
       lea       rcx,[rsi+0C]
       mov       rdx,1F8E1C00748
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFAA76E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M06_L38
       lea       rcx,[rsi+20]
       mov       rdx,1F8E5C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFAA76A1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L39
       mov       eax,1
M06_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L06
       call      qword ptr [7FFAA7A3B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78A65E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A35600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A3B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A3B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA780FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L06:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA76A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A3B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA780FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L07:
       cmp       qword ptr [r15+28],0
       je        short M06_L08
       mov       rcx,[r15+28]
       jmp       short M06_L09
M06_L08:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2C140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L09:
       mov       r8,1F8E5C02028
       mov       r8,[r8]
       mov       r9,1F8E1C00CD8
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFAA7D37450]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M06_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M06_L10
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M06_L10
       jmp       short M06_L11
M06_L10:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2C270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L11:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA7460B50
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L17
M06_L12:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L13
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2C288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L14:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2C468
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L16:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA7460B50
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L12
M06_L17:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA7460B58
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
M06_L18:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L19
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L19
       jmp       short M06_L20
M06_L19:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2C218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L20:
       mov       rdx,rdi
       call      qword ptr [7FFAA79BB4C8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M06_L23
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M06_L21
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M06_L21
       jmp       short M06_L22
M06_L21:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2C590
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L22:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA7D363C0
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L24
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M06_L24
       jmp       short M06_L25
M06_L24:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2C250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L25:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFAA79B1918]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M06_L26
       mov       r11,[r15+40]
       test      r11,r11
       je        short M06_L26
       jmp       short M06_L27
M06_L26:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2C270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L27:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA7460B40
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L33
M06_L28:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L29
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L29
       jmp       short M06_L30
M06_L29:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2C288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L30:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L31
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L31
       jmp       short M06_L32
M06_L31:
       mov       rcx,rsi
       mov       rdx,7FFAA7D2C468
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L32:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA7460B40
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L28
M06_L33:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA7460B48
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
M06_L34:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7831C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7831C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L36:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L02
M06_L37:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7831C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7831C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L39:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L05
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
       je        short M06_L40
       mov       rcx,[rbp-40]
       mov       r11,7FFAA7460B58
       call      qword ptr [r11]
M06_L40:
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
       je        short M06_L41
       mov       rcx,[rbp-48]
       mov       r11,7FFAA7460B48
       call      qword ptr [r11]
M06_L41:
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
; Total bytes of code 1964
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+240]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
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
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M01_L02
       mov       rcx,rdx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA9EE4D38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFAA9E524F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFAA9E524F0
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
; Total bytes of code 162
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
       je        short M02_L00
       mov       rcx,[r15+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAA117100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L28
       mov       rbx,[r12+8]
       test      rbx,rbx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L29
       cmp       qword ptr [r15+28],0
       je        short M02_L02
       mov       rcx,[r15+28]
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFAAA117388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r8,1E0163A3020
       mov       r8,[r8]
       mov       r9,1E0163AA878
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M02_L12
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L04
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAA1174B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L05:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA9A309A8
       call      qword ptr [7FFAA9A309A8]
       test      eax,eax
       je        near ptr M02_L11
M02_L06:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L07
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAA1174D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L09
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAA1176B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A309A8
       call      qword ptr [7FFAA9A309A8]
       test      eax,eax
       jne       near ptr M02_L06
M02_L11:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A309B0
       call      qword ptr [7FFAA9A309B0]
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
M02_L12:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L13
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAA117460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       mov       rdx,rdi
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M02_L17
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L15
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFAAA117800
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
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
M02_L17:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L18
       jmp       short M02_L19
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFAAA117498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L19:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M02_L20
       mov       r11,[r15+40]
       test      r11,r11
       je        short M02_L20
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFAAA1174B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L21:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA9A30998
       call      qword ptr [7FFAA9A30998]
       test      eax,eax
       je        near ptr M02_L27
M02_L22:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L23
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L23
       jmp       short M02_L24
M02_L23:
       mov       rcx,rsi
       mov       rdx,7FFAAA1174D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L24:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L25
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L25
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       mov       rdx,7FFAAA1176B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L26:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A30998
       call      qword ptr [7FFAA9A30998]
       test      eax,eax
       jne       near ptr M02_L22
M02_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A309A0
       call      qword ptr [7FFAA9A309A0]
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
M02_L28:
       mov       ecx,4D
       mov       rdx,7FFAA9E524F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,61
       mov       rdx,7FFAA9E524F0
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
M02_L29:
       mov       ecx,4D
       mov       rdx,7FFAA9E524F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0A1
       mov       rdx,7FFAA9E524F0
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
       je        short M02_L30
       mov       rcx,[rbp-40]
       mov       r11,7FFAA9A309B0
       call      qword ptr [7FFAA9A309B0]
M02_L30:
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
       je        short M02_L31
       mov       rcx,[rbp-48]
       mov       r11,7FFAA9A309A0
       call      qword ptr [7FFAA9A309A0]
M02_L31:
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rcx,[rsi+240]
       test      rcx,rcx
       jne       near ptr M00_L00
       call      qword ptr [7FFAA7A2B348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L01
       lea       rcx,[rdi+0C]
       mov       rdx,1FB97008A38
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA76D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L02
       lea       rcx,[rdi+12]
       mov       rdx,1FB97002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA7691C60]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A25600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A2B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA77FFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L00:
       call      qword ptr [7FFAA7A63DE0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,rax
       mov       r9,1FB9700A658
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1FB97002028
       mov       r9,[r9]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A25600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFAA7CADF60]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFAA7D25960]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+30],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7D27D98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7821C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7821C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 488
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jae       short M01_L01
M01_L00:
       cmp       rcx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L11
M01_L01:
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M01_L00
       lea       rax,[rdx+r8]
       lea       r9,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       ja        near ptr M01_L07
M01_L02:
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
M01_L03:
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L04:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r9-8],rdx
       jmp       short M01_L09
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r9-4],edx
       jmp       short M01_L09
M01_L06:
       test      r8,r8
       je        short M01_L09
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L09
       movsx     r8,word ptr [rax-2]
       mov       [r9-2],r8w
       jmp       short M01_L09
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       mov       r10,r8
       shr       r10,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       je        short M01_L10
       jmp       short M01_L08
M01_L09:
       ret
M01_L10:
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       vmovupd   xmm0,[rax-10]
       vmovupd   [r9-10],xmm0
       jmp       short M01_L09
M01_L11:
       jmp       qword ptr [7FFAA76D9A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M02_L00
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M02_L00
       test      rsi,rsi
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rsi,rsi
       je        near ptr M02_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        near ptr M02_L05
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFAA76D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAA76D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rax,1FB97002028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7821C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7821C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 290
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M03_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M03_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M03_L03
       jmp       short M03_L02
M03_L01:
       xor       r9d,r9d
M03_L02:
       test      r8,r8
       je        short M03_L03
       cmp       dword ptr [r8+8],0
       je        short M03_L03
       mov       rcx,r8
       jmp       near ptr M03_L06
M03_L03:
       test      r9d,r9d
       jne       near ptr M03_L06
       call      qword ptr [7FFAA7A2B468]
       mov       rdi,rax
       test      rsi,rsi
       je        short M03_L04
       cmp       dword ptr [rsi+8],0
       je        short M03_L04
       jmp       short M03_L05
M03_L04:
       mov       rsi,rdi
M03_L05:
       mov       ecx,9
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A25600]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A2B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A2B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA77FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L06:
       test      dl,dl
       jne       short M03_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAA7693510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M04_L02
       call      qword ptr [7FFAA7A2B348]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M04_L04
       lea       rcx,[rdi+0C]
       mov       rdx,1FB97008A38
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAA76D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M04_L05
       lea       rcx,[rdi+12]
       mov       rdx,1FB97002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAA7691C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L06
       mov       eax,1
M04_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M04_L01
       call      qword ptr [7FFAA7A2B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A25600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A2B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A2B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA77FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA7693510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A2B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA77FFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M04_L02:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFAA7AEB690]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M04_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M04_L03
       mov       rdx,rax
       call      qword ptr [7FFAA75FB8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M04_L03:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFAA7BA7120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7821C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7821C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M04_L00
; Total bytes of code 563
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAA7AEF150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFAA7AEF330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M05_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M05_L01
       jmp       short M05_L01
M05_L00:
       xor       edx,edx
M05_L01:
       test      edx,edx
       jne       near ptr M05_L02
       call      qword ptr [7FFAA7A2B468]
       mov       rsi,rax
       mov       ecx,625
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A25600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A2B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A2B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA77FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA7693510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFAA7C8AA10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFAA7CADFC0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
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
       je        short M06_L00
       mov       rcx,[r15+10]
       jmp       short M06_L01
M06_L00:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1CF30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M06_L04
       call      qword ptr [7FFAA7A2B348]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       dword ptr [r12+8],5
       jl        near ptr M06_L34
       lea       rcx,[r12+0C]
       mov       rdx,1FB9700A348
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFAA76D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r12+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M06_L35
       lea       rcx,[r12+16]
       mov       rdx,1FB97002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
       mov       rdx,rdi
       call      qword ptr [7FFAA7691C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L36
       mov       eax,1
M06_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L03
       call      qword ptr [7FFAA7A2B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A25600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A2B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A2B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA77FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA7693510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A2B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA77FFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L04:
       mov       rbx,[r12+8]
       test      rbx,rbx
       jne       near ptr M06_L07
       call      qword ptr [7FFAA7A2B348]
       mov       r15,rax
       mov       ecx,0C
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0A
       jl        near ptr M06_L37
       lea       rcx,[rsi+0C]
       mov       rdx,1FB9700A358
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,14
       call      qword ptr [7FFAA76D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,0A
       cmp       ecx,2
       jl        near ptr M06_L38
       lea       rcx,[rsi+20]
       mov       rdx,1FB97002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAA76D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFAA7691C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M06_L39
       mov       eax,1
M06_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L06
       call      qword ptr [7FFAA7A2B468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAA78965E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAA7A25600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAA7A2B090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7A2B528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAA77FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L06:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAA7693510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAA7A2B090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAA77FFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L07:
       cmp       qword ptr [r15+28],0
       je        short M06_L08
       mov       rcx,[r15+28]
       jmp       short M06_L09
M06_L08:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1D1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L09:
       mov       r8,1FB97002028
       mov       r8,[r8]
       mov       r9,1FB9700A8E8
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7FFAA7D278B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       jne       near ptr M06_L18
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M06_L10
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M06_L10
       jmp       short M06_L11
M06_L10:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1D2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L11:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-40],rax
       mov       rcx,rax
       mov       r11,7FFAA7450BA8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L17
M06_L12:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L13
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1D300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L14:
       mov       rcx,[rbp-40]
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rbx,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L15
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L15
       jmp       short M06_L16
M06_L15:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1D4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L16:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [r11]
       mov       rcx,[rbp-40]
       mov       r11,7FFAA7450BA8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L12
M06_L17:
       mov       rcx,[rbp-40]
       mov       r11,7FFAA7450BB0
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
M06_L18:
       xor       ebx,ebx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L19
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L19
       jmp       short M06_L20
M06_L19:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1D290
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L20:
       mov       rdx,rdi
       call      qword ptr [7FFAA79AB4C8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       r14,[r12+10]
       test      r14,r14
       jne       short M06_L23
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],58
       jle       short M06_L21
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M06_L21
       jmp       short M06_L22
M06_L21:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1D608
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L22:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA7D26828
       mov       [r14+18],rdx
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L23:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L24
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M06_L24
       jmp       short M06_L25
M06_L24:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1D2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L25:
       mov       r15,[rsi+10]
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFAA79A1918]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [r15+8],40
       jle       short M06_L26
       mov       r11,[r15+40]
       test      r11,r11
       je        short M06_L26
       jmp       short M06_L27
M06_L26:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1D2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L27:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rcx,rax
       mov       r11,7FFAA7450B98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L33
M06_L28:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L29
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M06_L29
       jmp       short M06_L30
M06_L29:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1D300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L30:
       mov       rcx,[rbp-48]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rdi,[r12+8]
       cmp       qword ptr [rcx+8],50
       jle       short M06_L31
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M06_L31
       jmp       short M06_L32
M06_L31:
       mov       rcx,rsi
       mov       rdx,7FFAA7D1D4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M06_L32:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       ebx,1
       mov       rcx,[rbp-48]
       mov       r11,7FFAA7450B98
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L28
M06_L33:
       mov       rcx,[rbp-48]
       mov       r11,7FFAA7450BA0
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
M06_L34:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7821C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L35:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7821C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L36:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L02
M06_L37:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7821C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L38:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAA7821C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L39:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L05
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
       je        short M06_L40
       mov       rcx,[rbp-40]
       mov       r11,7FFAA7450BB0
       call      qword ptr [r11]
M06_L40:
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
       je        short M06_L41
       mov       rcx,[rbp-48]
       mov       r11,7FFAA7450BA0
       call      qword ptr [r11]
M06_L41:
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
; Total bytes of code 1964
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA0F6EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A20950
       call      qword ptr [7FFAA9A20950]
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
       mov       r11,7FFAA9A20958
       call      qword ptr [7FFAA9A20958]
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
       mov       r11,7FFAA9A20958
       call      qword ptr [7FFAA9A20958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA3B2D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA3B2D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA3B3CC40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA32A08B0
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
       mov       r11,7FFAA32A08B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA36AB780]
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
       mov       r11,7FFAA32A08B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA0D6EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A00950
       call      qword ptr [7FFAA9A00950]
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
       mov       r11,7FFAA9A00958
       call      qword ptr [7FFAA9A00958]
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
       mov       r11,7FFAA9A00958
       call      qword ptr [7FFAA9A00958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAAAB7D348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAAB7D3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAAAB8CC40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAAA2F08B0
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
       mov       r11,7FFAAA2F08B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAAA6FB780]
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
       mov       r11,7FFAAA2F08B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA0E6EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A10950
       call      qword ptr [7FFAA9A10950]
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
       mov       r11,7FFAA9A10958
       call      qword ptr [7FFAA9A10958]
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
       mov       r11,7FFAA9A10958
       call      qword ptr [7FFAA9A10958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAAAB7D8B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAAB7D918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAAAB8CC40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAAA2F08B0
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
       mov       r11,7FFAAA2F08B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAAA6FB780]
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
       mov       r11,7FFAAA2F08B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA0E6E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A10950
       call      qword ptr [7FFAA9A10950]
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
       mov       r11,7FFAA9A10958
       call      qword ptr [7FFAA9A10958]
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
       mov       r11,7FFAA9A10958
       call      qword ptr [7FFAA9A10958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA7CBDBB8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7CBDC18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA7CCCC40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA74308B0
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
       mov       r11,7FFAA74308B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA783B780]
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
       mov       r11,7FFAA74308B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA0E6EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A10950
       call      qword ptr [7FFAA9A10950]
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
       mov       r11,7FFAA9A10958
       call      qword ptr [7FFAA9A10958]
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
       mov       r11,7FFAA9A10958
       call      qword ptr [7FFAA9A10958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA348DBB8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA348DC18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA349CC60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA2C008B0
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
       mov       r11,7FFAA2C008B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA300B780]
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
       mov       r11,7FFAA2C008B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA116E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A40950
       call      qword ptr [7FFAA9A40950]
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
       mov       r11,7FFAA9A40958
       call      qword ptr [7FFAA9A40958]
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
       mov       r11,7FFAA9A40958
       call      qword ptr [7FFAA9A40958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA3B1DBB8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA3B1DC18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA3B2CC80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA32908B0
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
       mov       r11,7FFAA32908B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA369B780]
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
       mov       r11,7FFAA32908B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA138DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A20A58
       call      qword ptr [7FFAA9A20A58]
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
       mov       r11,7FFAA9A20A60
       call      qword ptr [7FFAA9A20A60]
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
       mov       r11,7FFAA9A20A60
       call      qword ptr [7FFAA9A20A60]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA7D07000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7D07060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA7D3D368
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA74309E8
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
       mov       r11,7FFAA74309F0
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA783B780]
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
       mov       r11,7FFAA74309F0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA128070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A10A70
       call      qword ptr [7FFAA9A10A70]
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
       mov       r11,7FFAA9A10A78
       call      qword ptr [7FFAA9A10A78]
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
       mov       r11,7FFAA9A10A78
       call      qword ptr [7FFAA9A10A78]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA7D058B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       cmp       rax,5
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7D05918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA7D3C8F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA74309F8
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
       mov       r11,7FFAA7430A00
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA783B780]
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
       mov       r11,7FFAA7430A00
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,19EE21B3380
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,19EE21B3378
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,19EE21B3380
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAA9F87C18]
       vucomisd  xmm0,qword ptr [7FFAA9F87C20]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAAA0D59B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,19ED21B3020
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
       mov       rdx,7FFAAA0D5B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,19ED21B3020
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
       mov       rdx,7FFAA9E224F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFAA9E224F0
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,20F64C06790
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20F64C06788
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA3B4C8A0
       mov       [rbx+18],rdx
       mov       rcx,20F64C06790
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
       call      qword ptr [7FFAA3577FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA3B4F840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFAA36C77B0]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,16260B13380
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,16260B13378
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,16260B13380
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAA9F97FE8]
       vucomisd  xmm0,qword ptr [7FFAA9F97FF0]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAAA0E59B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,16280B13020
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
       mov       rdx,7FFAAA0E5B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,16280B13020
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
       mov       rdx,7FFAA9E324F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFAA9E324F0
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,2242F006790
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2242F006788
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAAAB7AFD8
       mov       [rbx+18],rdx
       mov       rcx,2242F006790
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
       call      qword ptr [7FFAAA5A7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAAB7D978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFAAA6F77B0]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,28D7F973380
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28D7F973378
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,28D7F973380
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAA9FB7D48]
       vucomisd  xmm0,qword ptr [7FFAA9FB7D50]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAAA1059B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,28D6F973020
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
       mov       rdx,7FFAAA105B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,28D6F973020
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
       mov       rdx,7FFAA9E524F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFAA9E524F0
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,27C02006790
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,27C02006788
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAAAB9C8A0
       mov       [rbx+18],rdx
       mov       rcx,27C02006790
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
       call      qword ptr [7FFAAA5C7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAAB9F840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFAAA7177B0]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,2C205BA3380
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2C205BA3378
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2C205BA3380
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAA9FC7D08]
       vucomisd  xmm0,qword ptr [7FFAA9FC7D10]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAAA1159B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,2C215BA3020
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
       mov       rdx,7FFAAA115B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,2C215BA3020
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
       mov       rdx,7FFAA9E624F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFAA9E624F0
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,1FA44002388
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FA44002380
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA7CDCBA0
       mov       [rbx+18],rdx
       mov       rcx,1FA44002388
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
       call      qword ptr [7FFAA7707FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7CDF840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFAA78577B0]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,2A3984E7788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A3984E7780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2A3984E7788
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAA9FB7D48]
       vucomisd  xmm0,qword ptr [7FFAA9FB7D50]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAAA1059B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,2A3984E3020
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
       mov       rdx,7FFAAA105B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,2A3984E3020
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
       mov       rdx,7FFAA9E524F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFAA9E524F0
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,26247406790
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,26247406788
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA34ACBA0
       mov       [rbx+18],rdx
       mov       rcx,26247406790
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
       call      qword ptr [7FFAA2ED7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA34AF840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFAA30277B0]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,1A05BB17788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A05BB17780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1A05BB17788
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAA9FB7BF8]
       vucomisd  xmm0,qword ptr [7FFAA9FB7C00]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAAA1059B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,1A05BB13020
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
       mov       rdx,7FFAAA105B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1A05BB13020
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
       mov       rdx,7FFAA9E524F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFAA9E524F0
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,23E81802388
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23E81802380
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA3B4AFD8
       mov       [rbx+18],rdx
       mov       rcx,23E81802388
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
       call      qword ptr [7FFAA3577FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA3B4D978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFAA36C77B0]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,1AA5B797788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1AA5B797780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1AA5B797788
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAA136D98]
       vucomisd  xmm0,qword ptr [7FFAAA136DA0]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAAA0F59B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,1AA5B793020
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
       mov       rdx,7FFAAA0F5B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,1AA5B793020
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
       mov       rdx,7FFAA9E324F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFAA9E324F0
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,205A5006790
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,205A5006788
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA7D16330
       mov       [rbx+18],rdx
       mov       rcx,205A5006790
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
       call      qword ptr [7FFAA76F7FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7D17CC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFAA78477B0]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,212EEB47788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,212EEB47780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,212EEB47788
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAA144E78]
       vucomisd  xmm0,qword ptr [7FFAAA144E80]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAAA105970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r9,212EEB43020
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
       mov       rdx,7FFAAA105AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       r9,212EEB43020
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
       mov       rdx,7FFAA9E424F0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,6D
       mov       rdx,7FFAA9E424F0
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,20E09804380
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20E09804378
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAA7D248A0
       mov       [rbx+18],rdx
       mov       rcx,20E09804380
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
       call      qword ptr [7FFAA7707FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       ebx,eax
M00_L03:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7D27840]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFAA78577B0]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA12ACE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A40950
       call      qword ptr [7FFAA9A40950]
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
       mov       r11,7FFAA9A40958
       call      qword ptr [7FFAA9A40958]
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
       mov       r11,7FFAA9A40958
       call      qword ptr [7FFAA9A40958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA3B3F000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA3B3F060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA3BA4630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA32A08B0
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
       mov       r11,7FFAA32A08B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA36BD780]
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
       mov       r11,7FFAA32A08B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA0D6ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A00950
       call      qword ptr [7FFAA9A00950]
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
       mov       r11,7FFAA9A00958
       call      qword ptr [7FFAA9A00958]
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
       mov       r11,7FFAA9A00958
       call      qword ptr [7FFAA9A00958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAAAB8D000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAAB8D060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAAAB9CC30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAAA3008B0
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
       mov       r11,7FFAAA3008B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAAA70B780]
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
       mov       r11,7FFAAA3008B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA0F6ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A20950
       call      qword ptr [7FFAA9A20950]
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
       mov       r11,7FFAA9A20958
       call      qword ptr [7FFAA9A20958]
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
       mov       r11,7FFAA9A20958
       call      qword ptr [7FFAA9A20958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAAAB9D8B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAAB9D918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAAABACC30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAAA3108B0
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
       mov       r11,7FFAAA3108B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAAA71B780]
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
       mov       r11,7FFAAA3108B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA0E6E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A10950
       call      qword ptr [7FFAA9A10950]
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
       mov       r11,7FFAA9A10958
       call      qword ptr [7FFAA9A10958]
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
       mov       r11,7FFAA9A10958
       call      qword ptr [7FFAA9A10958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA7CDD8B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7CDD918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA7CECC30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA74508B0
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
       mov       r11,7FFAA74508B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA785B780]
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
       mov       r11,7FFAA74508B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA106E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A30950
       call      qword ptr [7FFAA9A30950]
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
       mov       r11,7FFAA9A30958
       call      qword ptr [7FFAA9A30958]
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
       mov       r11,7FFAA9A30958
       call      qword ptr [7FFAA9A30958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA349D8B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA349D918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA34ACC50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA2C108B0
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
       mov       r11,7FFAA2C108B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA301B780]
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
       mov       r11,7FFAA2C108B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA0E6ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A10950
       call      qword ptr [7FFAA9A10950]
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
       mov       r11,7FFAA9A10958
       call      qword ptr [7FFAA9A10958]
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
       mov       r11,7FFAA9A10958
       call      qword ptr [7FFAA9A10958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA3B3DBB8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA3B3DC18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA3B4CC60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA32B08B0
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
       mov       r11,7FFAA32B08B8
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA36BB780]
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
       mov       r11,7FFAA32B08B8
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA0F6E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A20950
       call      qword ptr [7FFAA9A20950]
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
       mov       r11,7FFAA9A20958
       call      qword ptr [7FFAA9A20958]
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
       mov       r11,7FFAA9A20958
       call      qword ptr [7FFAA9A20958]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA7D07348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7D073A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA7D3D290
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA74309E8
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
       mov       r11,7FFAA74309F0
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA783B780]
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
       mov       r11,7FFAA74309F0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFAAA137DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA9A20A70
       call      qword ptr [7FFAA9A20A70]
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
       mov       r11,7FFAA9A20A78
       call      qword ptr [7FFAA9A20A78]
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
       mov       r11,7FFAA9A20A78
       call      qword ptr [7FFAA9A20A78]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+278]
       test      rdx,rdx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFAA7D058B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       xor       edi,edi
       test      rax,rax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAA7D05918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAA7D3C928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rsi,rax
       mov       [rbp-20],rsi
M01_L02:
       mov       rcx,rsi
       mov       r11,7FFAA74309F8
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
       mov       r11,7FFAA7430A00
       call      qword ptr [r11]
       mov       rax,rdi
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       ecx,10
       call      qword ptr [7FFAA783B780]
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
       mov       r11,7FFAA7430A00
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

