## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllInterfaces01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.Type, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C59881E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       r9,1C80033DEE0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C800333020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Reflection.Assembly, System.Private.CoreLib]](System.Reflection.Assembly, System.Reflection.Assembly, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+10],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M02_L03
M02_L01:
       mov       rcx,[rbp-10]
       mov       eax,[rbp-14]
       cmp       eax,[rcx+8]
       jb        short M02_L02
       call      CORINFO_HELP_RNGCHKFAIL
M02_L02:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       [rbp-50],rax
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       nop
       mov       eax,[rbp-14]
       inc       eax
       mov       [rbp-14],eax
M02_L03:
       mov       ecx,[rbp-14]
       mov       rax,[rbp-10]
       cmp       ecx,[rax+8]
       jl        short M02_L01
       mov       rax,[rbp-8]
       mov       [rbp-28],rax
       nop
       jmp       short M02_L04
M02_L04:
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 330
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllInterfaces01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FF9C6261690]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      qword ptr [7FF9C671B300]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.Type, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C671FC60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C6261678]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C645C928],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       r9,21D25C08840
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21D25C02028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Reflection.Assembly, System.Private.CoreLib]](System.Reflection.Assembly, System.Reflection.Assembly, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C64DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+10],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C6177900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M02_L03
M02_L01:
       mov       rcx,[rbp-10]
       mov       eax,[rbp-14]
       cmp       eax,[rcx+8]
       jb        short M02_L02
       call      CORINFO_HELP_RNGCHKFAIL
M02_L02:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax]
       mov       [rbp-50],rax
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6177AC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       nop
       mov       eax,[rbp-14]
       inc       eax
       mov       [rbp-14],eax
M02_L03:
       mov       ecx,[rbp-14]
       mov       rax,[rbp-10]
       cmp       ecx,[rax+8]
       jl        short M02_L01
       mov       rax,[rbp-8]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 330
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllTypes01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.Type, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C59981E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       r9,27932CC1328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27962CC3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Reflection.Assembly, System.Private.CoreLib]](System.Reflection.Assembly, System.Reflection.Assembly, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp-18],rax
       mov       rcx,7FF9C5998710
       mov       edx,37
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27942CC9F58
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-20],0
       jne       near ptr M02_L01
       mov       rcx,offset MT_System.Func`2[[System.Type, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rcx,7FF9C5998710
       mov       edx,37
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,27942CC9F50
       mov       rdx,[rdx]
       mov       [rbp-50],rdx
       mov       rdx,[rbp-50]
       mov       rcx,[rbp-48]
       mov       r8,offset DotNetTips.Spargine.Extensions.AssemblyExtensions+<>c.<GetAllTypes>b__1_0(System.Type)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF9C5998710
       mov       edx,37
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27942CC9F58
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,[rbp-48]
       mov       [rbp-30],r8
M02_L01:
       mov       r8,[rbp-30]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>, System.Func`2<System.Type,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-38],rax
       mov       rdx,[rbp-38]
       mov       rcx,offset MD_System.Linq.Enumerable.AsEnumerable[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>)
       call      System.Linq.Enumerable.AsEnumerable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-8],rax
       nop
       jmp       short M02_L02
M02_L02:
       mov       rax,[rbp-8]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 415
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllTypes01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FF9C6231690]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      qword ptr [7FF9C66E9318]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.Type, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C66EDE58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C6231678]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C642C928],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       r9,18ED6812FE8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,18ED6802028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Reflection.Assembly, System.Private.CoreLib]](System.Reflection.Assembly, System.Reflection.Assembly, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp-18],rax
       mov       rcx,7FF9C642CE18
       mov       edx,37
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18ED680D618
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-20],0
       jne       near ptr M02_L01
       mov       rcx,offset MT_System.Func`2[[System.Type, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rcx,7FF9C642CE18
       mov       edx,37
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,18ED680D610
       mov       rdx,[rdx]
       mov       [rbp-50],rdx
       mov       rdx,[rbp-50]
       mov       rcx,[rbp-48]
       mov       r8,offset DotNetTips.Spargine.Extensions.AssemblyExtensions+<>c.<GetAllTypes>b__1_0(System.Type)
       call      qword ptr [7FF9C5FBB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF9C642CE18
       mov       edx,37
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-48]
       mov       rcx,18ED680D618
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-48]
       mov       [rbp-30],r8
M02_L01:
       mov       r8,[rbp-30]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>, System.Func`2<System.Type,Boolean>)
       call      qword ptr [7FF9C63BDCF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-38],rax
       mov       rdx,[rbp-38]
       mov       rcx,offset MD_System.Linq.Enumerable.AsEnumerable[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>)
       call      qword ptr [7FF9C66E9408]; System.Linq.Enumerable.AsEnumerable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 417
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetInstances01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      System.Reflection.Assembly.GetExecutingAssembly()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.AssemblyExtensions.GetInstances[[DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark, DotNetTips.Spargine.Extensions.BenchmarkTests]](System.Reflection.Assembly)
       call      DotNetTips.Spargine.Extensions.AssemblyExtensions.GetInstances[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark, DotNetTips.Spargine.Extensions.BenchmarkTests]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetInstances[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59581E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
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
       mov       rdx,7FF9C5BC4038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       edx,0FFFFFFFE
       call      DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+18]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 152
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetInstances01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FF9C6231690]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.AssemblyExtensions.GetInstances[[DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark, DotNetTips.Spargine.Extensions.BenchmarkTests]](System.Reflection.Assembly)
       call      qword ptr [7FF9C66EB060]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetInstances[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark, DotNetTips.Spargine.Extensions.BenchmarkTests]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C66EB348]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9C6231678]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetInstances[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C642C928],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C66D5940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       mov       rcx,[rbp-20]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,0FFFFFFFE
       call      qword ptr [7FF9C66EB198]; DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+18]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-18]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 155
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

