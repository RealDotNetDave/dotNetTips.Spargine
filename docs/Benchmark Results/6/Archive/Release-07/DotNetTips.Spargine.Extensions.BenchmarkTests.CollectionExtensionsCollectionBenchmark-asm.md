## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FAD48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,24EA0761330
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24E90763020
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,24EA0761338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24E90763020
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,24E90763020
       mov       r8,[r8]
       mov       r9,24EA0761340
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp+28],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L19
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54E0380
       call      qword ptr [7FF9C54E0380]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       jmp       short M01_L18
M01_L18:
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L36
M01_L19:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L20
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L21
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB4E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L21:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L24
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L22
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB8A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L23:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L24:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L25
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L26
M01_L25:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB538
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L26:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L27
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L27
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L28
M01_L27:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L28:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L34
M01_L29:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L30
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L31
M01_L30:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L31:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L32
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L33
M01_L32:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L33:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L34:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54E0370
       call      qword ptr [7FF9C54E0370]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L29
       nop
       jmp       short M01_L35
M01_L35:
       mov       rcx,rsp
       call      M01_L39
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
       jmp       short M01_L36
M01_L36:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L38
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54E0388
       call      qword ptr [7FF9C54E0388]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L39:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L40
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54E0378
       call      qword ptr [7FF9C54E0378]
       nop
M01_L40:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2234
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C64C5C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67BF738]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C64857A0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6501A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9C64CD978]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6501F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,1B4E1412FF0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1B4E1402028
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C64CDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6502038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,1B4E1412FF8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1B4E1402028
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      qword ptr [7FF9C64CDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C65020F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,1B4E1402028
       mov       r8,[r8]
       mov       r9,1B4E1413000
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      qword ptr [7FF9C64CDEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       dword ptr [rbp+28],0
       sete      cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L18
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6502238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6502250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6502430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5E40380
       call      qword ptr [r11]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       mov       rcx,rsp
       call      M01_L35
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L34
M01_L18:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L19
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L19
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C65021C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L20:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF9C6451CA8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L23
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L21
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L21
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L22
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6502558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L22:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,7FF9C64CC990
       call      qword ptr [7FF9C5FEB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L23:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L24
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L24
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L25
M01_L24:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6502218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L25:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      qword ptr [7FF9C6427CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L26
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L26
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L27
M01_L26:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6502238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L27:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L33
M01_L28:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L29
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L29
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L30
M01_L29:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6502250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L30:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L31
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L31
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L32
M01_L31:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6502430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L32:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L33:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5E40370
       call      qword ptr [r11]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L28
       nop
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
M01_L34:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L35:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L36
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5E40388
       call      qword ptr [r11]
       nop
M01_L36:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L38
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5E40378
       call      qword ptr [r11]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2222
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5991570],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EAD48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,1C216C81330
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C1F6C83020
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,1C216C81338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C1F6C83020
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,1C1F6C83020
       mov       r8,[r8]
       mov       r9,1C216C81340
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp+28],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L19
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54D0380
       call      qword ptr [7FF9C54D0380]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       jmp       short M01_L18
M01_L18:
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L36
M01_L19:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L20
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L21
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB4E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L21:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L24
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L22
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB8A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L23:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L24:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L25
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L26
M01_L25:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB538
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L26:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L27
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L27
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L28
M01_L27:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L28:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L34
M01_L29:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L30
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L31
M01_L30:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L31:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L32
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L33
M01_L32:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59EB750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L33:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L34:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54D0370
       call      qword ptr [7FF9C54D0370]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L29
       nop
       jmp       short M01_L35
M01_L35:
       mov       rcx,rsp
       call      M01_L39
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
       jmp       short M01_L36
M01_L36:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L38
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54D0388
       call      qword ptr [7FF9C54D0388]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L39:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L40
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54D0378
       call      qword ptr [7FF9C54D0378]
       nop
M01_L40:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2234
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C64A5C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C679F3F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C64657A0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E1A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9C64AD978]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E1F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,2A818C00320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2A80EC02028
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ADE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,2A818C00328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2A80EC02028
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ADE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E20F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,2A80EC02028
       mov       r8,[r8]
       mov       r9,2A818C00330
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      qword ptr [7FF9C64ADEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       dword ptr [rbp+28],0
       sete      cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L18
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5E20380
       call      qword ptr [r11]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       mov       rcx,rsp
       call      M01_L35
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L34
M01_L18:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L19
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L19
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E21C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L20:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF9C6431CA8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L23
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L21
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L21
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L22
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L22:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,7FF9C64AC990
       call      qword ptr [7FF9C5FCB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L23:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L24
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L24
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L25
M01_L24:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L25:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      qword ptr [7FF9C6407CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L26
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L26
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L27
M01_L26:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L27:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L33
M01_L28:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L29
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L29
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L30
M01_L29:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L30:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L31
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L31
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L32
M01_L31:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L32:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L33:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5E20370
       call      qword ptr [r11]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L28
       nop
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
M01_L34:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L35:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L36
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5E20388
       call      qword ptr [r11]
       nop
M01_L36:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L38
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5E20378
       call      qword ptr [r11]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2222
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FAD48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,1A592F91330
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1A532F93020
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,1A592F91338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1A532F93020
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,1A532F93020
       mov       r8,[r8]
       mov       r9,1A592F91340
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp+28],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L19
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54E0380
       call      qword ptr [7FF9C54E0380]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       jmp       short M01_L18
M01_L18:
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L36
M01_L19:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L20
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L21
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB4E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L21:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L24
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L22
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB8A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L23:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L24:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L25
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L26
M01_L25:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB538
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L26:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L27
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L27
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L28
M01_L27:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L28:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L34
M01_L29:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L30
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L31
M01_L30:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L31:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L32
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L33
M01_L32:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59FB750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L33:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L34:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54E0370
       call      qword ptr [7FF9C54E0370]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L29
       nop
       jmp       short M01_L35
M01_L35:
       mov       rcx,rsp
       call      M01_L39
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
       jmp       short M01_L36
M01_L36:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L38
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54E0388
       call      qword ptr [7FF9C54E0388]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L39:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L40
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54E0378
       call      qword ptr [7FF9C54E0378]
       nop
M01_L40:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2234
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C64A5C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C679F738]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C64657A0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E1A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9C64AD978]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E1F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,1E410800320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E408802028
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ADE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,1E410800328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E408802028
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ADE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E20F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,1E408802028
       mov       r8,[r8]
       mov       r9,1E410800330
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      qword ptr [7FF9C64ADEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       dword ptr [rbp+28],0
       sete      cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L18
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5E20380
       call      qword ptr [r11]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       mov       rcx,rsp
       call      M01_L35
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L34
M01_L18:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L19
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L19
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E21C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L20:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF9C6431CA8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L23
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L21
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L21
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L22
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L22:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,7FF9C64AC990
       call      qword ptr [7FF9C5FCB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L23:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L24
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L24
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L25
M01_L24:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L25:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      qword ptr [7FF9C6407CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L26
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L26
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L27
M01_L26:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L27:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L33
M01_L28:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L29
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L29
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L30
M01_L29:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L30:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L31
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L31
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L32
M01_L31:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L32:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L33:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5E20370
       call      qword ptr [r11]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L28
       nop
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
M01_L34:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L35:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L36
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5E20388
       call      qword ptr [r11]
       nop
M01_L36:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L38
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5E20378
       call      qword ptr [r11]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2222
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DAD48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,17A36515738
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,17A36513020
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,17A36515740
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,17A36513020
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,17A36513020
       mov       r8,[r8]
       mov       r9,17A36515748
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp+28],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L19
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54C0380
       call      qword ptr [7FF9C54C0380]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       jmp       short M01_L18
M01_L18:
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L36
M01_L19:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L20
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L21
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB4E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L21:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L24
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L22
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB8A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L23:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L24:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L25
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L26
M01_L25:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB538
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L26:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L27
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L27
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L28
M01_L27:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L28:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L34
M01_L29:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L30
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L31
M01_L30:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L31:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L32
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L33
M01_L32:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L33:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L34:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54C0370
       call      qword ptr [7FF9C54C0370]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L29
       nop
       jmp       short M01_L35
M01_L35:
       mov       rcx,rsp
       call      M01_L39
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
       jmp       short M01_L36
M01_L36:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L38
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54C0388
       call      qword ptr [7FF9C54C0388]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L39:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L40
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54C0378
       call      qword ptr [7FF9C54C0378]
       nop
M01_L40:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2234
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C60F5C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63EF3F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C60B57A0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6131A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9C60FD978]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6131F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,13B76C00320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,13B6AC02028
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C60FDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,13B76C00328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,13B6AC02028
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      qword ptr [7FF9C60FDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C61320F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,13B6AC02028
       mov       r8,[r8]
       mov       r9,13B76C00330
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      qword ptr [7FF9C60FDEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       dword ptr [rbp+28],0
       sete      cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L18
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5A70380
       call      qword ptr [r11]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       mov       rcx,rsp
       call      M01_L35
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L34
M01_L18:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L19
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L19
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C61321C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L20:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF9C6081CA8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L23
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L21
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L21
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L22
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L22:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,7FF9C60FC990
       call      qword ptr [7FF9C5C1B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L23:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L24
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L24
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L25
M01_L24:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L25:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      qword ptr [7FF9C6057CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L26
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L26
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L27
M01_L26:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L27:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L33
M01_L28:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L29
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L29
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L30
M01_L29:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L30:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L31
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L31
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L32
M01_L31:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L32:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L33:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5A70370
       call      qword ptr [r11]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L28
       nop
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
M01_L34:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L35:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L36
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5A70388
       call      qword ptr [r11]
       nop
M01_L36:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L38
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5A70378
       call      qword ptr [r11]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2222
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C59B1570],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0AD48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,196561D1330
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,196461D3020
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,196561D1338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,196461D3020
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,196461D3020
       mov       r8,[r8]
       mov       r9,196561D1340
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp+28],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L19
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54F0380
       call      qword ptr [7FF9C54F0380]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       jmp       short M01_L18
M01_L18:
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L36
M01_L19:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L20
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L21
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B4E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L21:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L24
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L22
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B8A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L23:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L24:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L25
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L26
M01_L25:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B538
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L26:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L27
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L27
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L28
M01_L27:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L28:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L34
M01_L29:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L30
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L31
M01_L30:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L31:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L32
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L33
M01_L32:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L33:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L34:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54F0370
       call      qword ptr [7FF9C54F0370]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L29
       nop
       jmp       short M01_L35
M01_L35:
       mov       rcx,rsp
       call      M01_L39
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
       jmp       short M01_L36
M01_L36:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L38
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54F0388
       call      qword ptr [7FF9C54F0388]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L39:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L40
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54F0378
       call      qword ptr [7FF9C54F0378]
       nop
M01_L40:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2234
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C60F5C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63EF738]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C60B57A0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6131A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9C60FD978]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6131F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,1F4BD000320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F4B1002028
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C60FDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,1F4BD000328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F4B1002028
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      qword ptr [7FF9C60FDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C61320F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,1F4B1002028
       mov       r8,[r8]
       mov       r9,1F4BD000330
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      qword ptr [7FF9C60FDEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       dword ptr [rbp+28],0
       sete      cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L18
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5A70380
       call      qword ptr [r11]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       mov       rcx,rsp
       call      M01_L35
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L34
M01_L18:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L19
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L19
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C61321C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L20:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF9C6081CA8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L23
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L21
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L21
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L22
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L22:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,7FF9C60FC990
       call      qword ptr [7FF9C5C1B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L23:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L24
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L24
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L25
M01_L24:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L25:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      qword ptr [7FF9C6057CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L26
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L26
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L27
M01_L26:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L27:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L33
M01_L28:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L29
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L29
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L30
M01_L29:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L30:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L31
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L31
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L32
M01_L31:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6132430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L32:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L33:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5A70370
       call      qword ptr [r11]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L28
       nop
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
M01_L34:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L35:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L36
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5A70388
       call      qword ptr [r11]
       nop
M01_L36:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L38
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5A70378
       call      qword ptr [r11]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2222
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DAD48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,27845651330
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27815651028
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,27845651338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27815651028
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,27815651028
       mov       r8,[r8]
       mov       r9,27845651340
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp+28],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L19
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54C0380
       call      qword ptr [7FF9C54C0380]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       jmp       short M01_L18
M01_L18:
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L36
M01_L19:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L20
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L21
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB4E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L21:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L24
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L22
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB8A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L23:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L24:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L25
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L26
M01_L25:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB538
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L26:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L27
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L27
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L28
M01_L27:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L28:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L34
M01_L29:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L30
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L31
M01_L30:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L31:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L32
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L33
M01_L32:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C59DB750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L33:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L34:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54C0370
       call      qword ptr [7FF9C54C0370]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L29
       nop
       jmp       short M01_L35
M01_L35:
       mov       rcx,rsp
       call      M01_L39
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
       jmp       short M01_L36
M01_L36:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L38
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54C0388
       call      qword ptr [7FF9C54C0388]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L39:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L40
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54C0378
       call      qword ptr [7FF9C54C0378]
       nop
M01_L40:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2234
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C64B5C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67E13F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C64757A0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F1A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9C64BD978]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F1F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,21BB60127D8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21BB6002028
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C64BDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F2038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,21BB60127E0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21BB6002028
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      qword ptr [7FF9C64BDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F20F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,21BB6002028
       mov       r8,[r8]
       mov       r9,21BB60127E8
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      qword ptr [7FF9C64BDEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       dword ptr [rbp+28],0
       sete      cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L18
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F2238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F2250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F2430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5E30380
       call      qword ptr [r11]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       mov       rcx,rsp
       call      M01_L35
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L34
M01_L18:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L19
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L19
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F21C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L20:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF9C6441CA8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L23
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L21
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L21
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L22
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F2558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L22:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,7FF9C64BC990
       call      qword ptr [7FF9C5FDB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L23:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L24
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L24
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L25
M01_L24:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F2218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L25:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      qword ptr [7FF9C6417CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L26
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L26
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L27
M01_L26:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F2238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L27:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L33
M01_L28:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L29
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L29
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L30
M01_L29:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F2250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L30:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L31
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L31
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L32
M01_L31:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64F2430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L32:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L33:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5E30370
       call      qword ptr [r11]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L28
       nop
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
M01_L34:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L35:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L36
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5E30388
       call      qword ptr [r11]
       nop
M01_L36:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L38
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5E30378
       call      qword ptr [r11]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2222
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C59B1570],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0AD48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,1598AB61330
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1597AB63020
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,1598AB61338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1597AB63020
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B410
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,1597AB63020
       mov       r8,[r8]
       mov       r9,1598AB61340
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp+28],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L19
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54F0380
       call      qword ptr [7FF9C54F0380]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       jmp       short M01_L18
M01_L18:
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L36
M01_L19:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L20
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L20
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L21
M01_L20:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B4E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L21:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L24
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L22
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L22
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B8A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L23:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,offset DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L24:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L25
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L25
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L26
M01_L25:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B538
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L26:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L27
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L27
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L28
M01_L27:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L28:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L34
M01_L29:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L30
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L30
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L31
M01_L30:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L31:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L32
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L32
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L33
M01_L32:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5A0B750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L33:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L34:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54F0370
       call      qword ptr [7FF9C54F0370]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L29
       nop
       jmp       short M01_L35
M01_L35:
       mov       rcx,rsp
       call      M01_L39
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
       jmp       short M01_L36
M01_L36:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L38
       mov       rcx,[rbp-20]
       mov       r11,7FF9C54F0388
       call      qword ptr [7FF9C54F0388]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L39:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L40
       mov       rcx,[rbp-38]
       mov       r11,7FF9C54F0378
       call      qword ptr [7FF9C54F0378]
       nop
M01_L40:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2234
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.ICollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C64A5C30]; DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+20],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C679F3F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       sub       rsp,200
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-1D8],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C64657A0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E1A28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9C64AD978]; DotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-50]
       mov       [rbp-10],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-60],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E1F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-60],rax
M01_L05:
       mov       r9,19D5E412FF0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19D5E402028
       mov       r9,[r9]
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ADE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp+20],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L07:
       mov       r9,[rbp-10]
       mov       [rbp-80],r9
       mov       r9,19D5E412FF8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19D5E402028
       mov       r9,[r9]
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ADE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-88],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-90],rcx
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E20F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-90],rax
M01_L09:
       mov       r8,19D5E402028
       mov       r8,[r8]
       mov       r9,19D5E413000
       mov       r9,[r9]
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-88]
       call      qword ptr [7FF9C64ADEB8]; DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rbp-98],rax
       mov       rdx,[rbp-80]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       dword ptr [rbp+28],0
       sete      cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       je        near ptr M01_L18
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L10
       mov       rcx,[rbp-168]
       cmp       qword ptr [rcx+40],0
       je        short M01_L10
       mov       rcx,[rbp-168]
       mov       rcx,[rcx+40]
       mov       [rbp-170],rcx
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-170],rax
M01_L11:
       mov       rcx,[rbp-170]
       mov       [rbp-178],rcx
       mov       rcx,[rbp+20]
       mov       r11,[rbp-178]
       mov       rax,[rbp-178]
       call      qword ptr [rax]
       mov       [rbp-180],rax
       mov       rcx,[rbp-180]
       mov       [rbp-20],rcx
       nop
       jmp       near ptr M01_L17
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L13
       mov       rcx,[rbp-190]
       cmp       qword ptr [rcx+48],0
       je        short M01_L13
       mov       rcx,[rbp-190]
       mov       rcx,[rcx+48]
       mov       [rbp-198],rcx
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M01_L14:
       mov       rcx,[rbp-198]
       mov       [rbp-1A0],rcx
       mov       rcx,[rbp-20]
       mov       r11,[rbp-1A0]
       mov       rax,[rbp-1A0]
       call      qword ptr [rax]
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A8]
       mov       [rbp-28],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-1B0],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-1B8],rcx
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L15
       mov       rcx,[rbp-1B0]
       cmp       qword ptr [rcx+50],0
       je        short M01_L15
       mov       rcx,[rbp-1B0]
       mov       rcx,[rcx+50]
       mov       [rbp-1C0],rcx
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1C0],rax
M01_L16:
       mov       rcx,[rbp-1C0]
       mov       [rbp-1C8],rcx
       mov       rcx,[rbp-1B8]
       mov       r11,[rbp-1C8]
       mov       rdx,[rbp-28]
       mov       rax,[rbp-1C8]
       call      qword ptr [rax]
       nop
       nop
M01_L17:
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5E20380
       call      qword ptr [r11]
       mov       [rbp-184],eax
       cmp       dword ptr [rbp-184],0
       jne       near ptr M01_L12
       nop
       mov       rcx,rsp
       call      M01_L35
       nop
       mov       dword ptr [rbp-2C],1
       nop
       jmp       near ptr M01_L34
M01_L18:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L19
       mov       rcx,[rbp-0A0]
       cmp       qword ptr [rcx+30],0
       je        short M01_L19
       mov       rcx,[rbp-0A0]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E21C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A8],rax
M01_L20:
       mov       rcx,[rbp-0A8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF9C6431CA8]; System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+10]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B0]
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C8],rcx
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M01_L23
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-158],rcx
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+8],58
       jle       short M01_L21
       mov       rcx,[rbp-158]
       cmp       qword ptr [rcx+58],0
       je        short M01_L21
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+58]
       mov       [rbp-160],rcx
       jmp       short M01_L22
M01_L21:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-160],rax
M01_L22:
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-10]
       mov       r8,7FF9C64AC990
       call      qword ptr [7FF9C5FCB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-150]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-40]
       mov       [rbp-0C8],rcx
M01_L23:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L24
       mov       rcx,[rbp-0D0]
       cmp       qword ptr [rcx+38],0
       je        short M01_L24
       mov       rcx,[rbp-0D0]
       mov       rcx,[rcx+38]
       mov       [rbp-0D8],rcx
       jmp       short M01_L25
M01_L24:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0D8],rax
M01_L25:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       call      qword ptr [7FF9C6407CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0E0],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L26
       mov       rcx,[rbp-0E8]
       cmp       qword ptr [rcx+40],0
       je        short M01_L26
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx+40]
       mov       [rbp-0F0],rcx
       jmp       short M01_L27
M01_L26:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2238
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0F0],rax
M01_L27:
       mov       rcx,[rbp-0F0]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E0]
       mov       r11,[rbp-0F8]
       mov       rax,[rbp-0F8]
       call      qword ptr [rax]
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
       mov       [rbp-38],rcx
       nop
       jmp       near ptr M01_L33
M01_L28:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L29
       mov       rcx,[rbp-110]
       cmp       qword ptr [rcx+48],0
       je        short M01_L29
       mov       rcx,[rbp-110]
       mov       rcx,[rcx+48]
       mov       [rbp-118],rcx
       jmp       short M01_L30
M01_L29:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-118],rax
M01_L30:
       mov       rcx,[rbp-118]
       mov       [rbp-120],rcx
       mov       rcx,[rbp-38]
       mov       r11,[rbp-120]
       mov       rax,[rbp-120]
       call      qword ptr [rax]
       mov       [rbp-128],rax
       mov       rcx,[rbp-128]
       mov       [rbp-48],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       [rbp-138],rcx
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+8],50
       jle       short M01_L31
       mov       rcx,[rbp-130]
       cmp       qword ptr [rcx+50],0
       je        short M01_L31
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+50]
       mov       [rbp-140],rcx
       jmp       short M01_L32
M01_L31:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64E2430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-140],rax
M01_L32:
       mov       rcx,[rbp-140]
       mov       [rbp-148],rcx
       mov       rcx,[rbp-138]
       mov       r11,[rbp-148]
       mov       rdx,[rbp-48]
       mov       rax,[rbp-148]
       call      qword ptr [rax]
       nop
       mov       dword ptr [rbp-14],1
       nop
M01_L33:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5E20370
       call      qword ptr [r11]
       mov       [rbp-104],eax
       cmp       dword ptr [rbp-104],0
       jne       near ptr M01_L28
       nop
       mov       rcx,rsp
       call      M01_L37
       nop
       mov       eax,[rbp-14]
       mov       [rbp-2C],eax
       nop
M01_L34:
       mov       eax,[rbp-2C]
       add       rsp,200
       pop       rbp
       ret
M01_L35:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-20],0
       je        short M01_L36
       mov       rcx,[rbp-20]
       mov       r11,7FF9C5E20388
       call      qword ptr [r11]
       nop
M01_L36:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L37:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+200]
       cmp       qword ptr [rbp-38],0
       je        short M01_L38
       mov       rcx,[rbp-38]
       mov       r11,7FF9C5E20378
       call      qword ptr [r11]
       nop
M01_L38:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 2222
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5991570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C7FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C67BF300]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67BF3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C64857A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D21A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67BF348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5971570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C5FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C67D1300]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67D13A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C64657A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C1B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67D1348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C59B1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C9FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C67BF870]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67BF918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C64657A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C10E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67BF8B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C6FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C63CDFA8]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63CF060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C60957A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E21E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C63CF000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C6FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C6401300]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C64013A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C60957A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63F1C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C6401348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5991570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C7FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C67BF870]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67BF918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C64657A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C1050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67BF8B8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C8FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C67BF300]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67BF3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C64857A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67BF348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1D8D81AD6C0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D8D81AD6B8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D8D81AD6C0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5990C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5991570],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,1D8D81A3020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1D8D81A3020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       cmp       dword ptr [rbp-4C],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C904F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,1D8D81B45D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D8D81A3020
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L10
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 459
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,25D2B40A2B8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25D2B40A2B0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,25D2B40A2B8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C6801408]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6494E58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C64A5390]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C64957A0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67F2A30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,25D2F402028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C6801450]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67F2BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,25D2F402028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C6801450]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-4C],0
       sete      cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67F2B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,25D2D400958
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,25D2F402028
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C64DDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6187FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 460
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,23E41CCD6C0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23E41CCD6B8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23E41CCD6C0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5990C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5991570],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,23E41CC3020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,23E41CC3020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       cmp       dword ptr [rbp-4C],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C904F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,23E81CC1900
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23E41CC3020
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L10
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 459
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,20CC700C6C8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20CC700C6C0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,20CC700C6C8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67BF408]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6484E58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6495390]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C64857A0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D20B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,20CC7002028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C67BF450]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D2278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,20CC7002028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C67BF450]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-4C],0
       sete      cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D2220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,20CC7013628
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20CC7002028
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C64CDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6177FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 460
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,218004DD6C0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,218004DD6B8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,218004DD6C0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C59B0C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C59B1570],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB0378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,218004D3020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB0548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,218004D3020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       cmp       dword ptr [rbp-4C],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB04F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,218604D1900
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,218004D3020
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L10
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 459
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,13A5B8082C0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,13A5B8082B8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,13A5B8082C0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67F10C0]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6484E58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6495390]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C64857A0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67E2510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,13A57802028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C67F1108]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67E26D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,13A57802028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C67F1108]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-4C],0
       sete      cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67E2678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,13A5B80F220
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,13A57802028
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C64CDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6177FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 460
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,23B4471D6C0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23B4471D6B8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23B4471D6C0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5990C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5991570],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,23B44713020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,23B44713020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       cmp       dword ptr [rbp-4C],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C904F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,23B54711900
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23B44713020
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L10
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 459
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,27EB540A2B8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,27EB540A2B0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,27EB540A2B8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C63CF408]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6094E58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C60A5390]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C60957A0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E2510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,27EB1400030
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C63CF450]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E26D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,27EB1400030
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C63CF450]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-4C],0
       sete      cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E2678
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,27EB1403580
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27EB1400030
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C60DDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5D87FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 460
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1EC7DC7D6C0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1EC7DC7D6B8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1EC7DC7D6C0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5980C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981570],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,1EC7DC73020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1EC7DC73020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       cmp       dword ptr [rbp-4C],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C804F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,1ECFDC71900
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1EC7DC73020
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L10
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 459
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,185CBC082C0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,185CBC082B8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,185CBC082C0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C678F0C0]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6454E58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6465390]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C64557A0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A2190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,185C7C02028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C678F108]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A2350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,185C7C02028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C678F108]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-4C],0
       sete      cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A22F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,185C7C05578
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,185C7C02028
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C649DE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6147FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 460
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,29FDC32D6C0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,29FDC32D6B8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,29FDC32D6C0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C59A0C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C59A1570],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,29FDC323020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,29FDC323020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       cmp       dword ptr [rbp-4C],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA04F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,2A03C321900
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29FDC323020
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L10
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 459
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,13AF040C6C8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,13AF040C6C0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,13AF040C6C8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C679F0C0]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6464E58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6475390]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C64657A0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B2968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,13AF0402028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C679F108]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B2B28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,13AF0402028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C679F108]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-4C],0
       sete      cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B2AD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,13AF2400958
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,13AF0402028
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ADE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6157FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 460
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1E3F988B6C8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E3F988B6C0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E3F988B6C8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5970C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5971570],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C70378
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,1E3F9881028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C70548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1E3F9881028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       cmp       dword ptr [rbp-4C],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C704F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,1E409881900
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E3F9881028
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L10
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 459
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,15C4600C6C8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,15C4600C6C0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,15C4600C6C8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Predicate`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67AF0C0]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6474E58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6485390]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C64757A0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C24F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       r9,15C46002028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C67AF108]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-1C],eax
       cmp       dword ptr [rbp-1C],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C26B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,15C46002028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C67AF108]; DotNetTips.Spargine.Core.Validator.CheckIsNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, Boolean, System.String)
       mov       [rbp-4C],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-4C],0
       sete      cl
       mov       [rbp-20],ecx
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-20],1
M02_L06:
       mov       ecx,[rbp-20]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L07
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       near ptr M02_L10
M02_L07:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-28],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C2660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-28],rax
M02_L09:
       mov       r9,[rbp+18]
       mov       [rbp-30],r9
       mov       r9,15C52000958
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,15C46002028
       mov       r9,[r9]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9C64BDE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6167FC0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L10:
       mov       eax,[rbp-10]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 460
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C8FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67E1300]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67E13A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C64757A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1F40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67E1348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 174
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C8FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67CDFA8]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67CF060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C64857A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67E1F50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67CF000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 174
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C6FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67BDFA8]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67BF060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C64857A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D2388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67BF000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 174
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C6FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C63DDFA8]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63DF060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C60957A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63F1FE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C63DF000]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 174
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C6FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C63FFB70]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63FFC18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C60A57A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6401180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C63FFBB8]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 174
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C6FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67BF300]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67BF3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C64857A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D2360
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67BF348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 174
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C8FB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67AF300]; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67AF3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C64757A0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C1770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67AF348]; System.Linq.Enumerable.LongCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 174
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```
