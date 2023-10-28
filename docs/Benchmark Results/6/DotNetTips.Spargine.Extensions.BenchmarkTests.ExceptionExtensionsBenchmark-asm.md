## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5958438],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,2094B6C5868
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2094B6B3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Exception, System.Private.CoreLib]](System.Exception, System.Exception, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       [rbp+10],rcx
       mov       rcx,7FF9C5958968
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2094B6BE3A0
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-20],0
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,7FF9C5958968
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2094B6BE398
       mov       rdx,[rdx]
       mov       [rbp-78],rdx
       mov       rdx,[rbp-78]
       mov       rcx,[rbp-70]
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF9C5958968
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2094B6BE3A0
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,[rbp-70]
       mov       [rbp-30],r8
M01_L02:
       mov       r8,[rbp-30]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.Exception, System.Private.CoreLib]](System.Exception, System.Func`2<System.Exception,System.Exception>)
       call      DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FF9C5958968
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2094B6BE3A8
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       [rbp-50],rcx
       cmp       qword ptr [rbp-40],0
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,7FF9C5958968
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2094B6BE398
       mov       rdx,[rdx]
       mov       [rbp-80],rdx
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-68]
       mov       r8,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF9C5958968
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2094B6BE3A8
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,[rbp-68]
       mov       [rbp-50],r8
M01_L03:
       mov       r8,[rbp-50]
       mov       rdx,[rbp-48]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-58],rax
       mov       rdx,[rbp-58]
       mov       [rbp-8],rdx
       mov       edx,[rbp+18]
       movzx     edx,dx
       mov       r8,[rbp-8]
       mov       rcx,offset MD_System.String.Join[[System.String, System.Private.CoreLib]](Char, System.Collections.Generic.IEnumerable`1<System.String>)
       call      System.String.Join[[System.__Canon, System.Private.CoreLib]](Char, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-10],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-10]
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 645
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       edx,2C
       call      qword ptr [7FF9C66E9030]; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C66E9AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 72
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C642CD70],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,21DB6C00BB8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21DB4C02028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Exception, System.Private.CoreLib]](System.Exception, System.Exception, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       [rbp+10],rcx
       mov       rcx,7FF9C642D260
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21DB4C0D658
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-20],0
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,7FF9C642D260
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,21DB4C0D650
       mov       rdx,[rdx]
       mov       [rbp-78],rdx
       mov       rdx,[rbp-78]
       mov       rcx,[rbp-70]
       mov       r8,7FF9C66E8138
       call      qword ptr [7FF9C5FBB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF9C642D260
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-70]
       mov       rcx,21DB4C0D658
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-70]
       mov       [rbp-30],r8
M01_L02:
       mov       r8,[rbp-30]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.Exception, System.Private.CoreLib]](System.Exception, System.Func`2<System.Exception,System.Exception>)
       call      qword ptr [7FF9C66E91B0]; DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-38],rax
       mov       rcx,7FF9C642D260
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21DB4C0D660
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       [rbp-50],rcx
       cmp       qword ptr [rbp-40],0
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,7FF9C642D260
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,21DB4C0D650
       mov       rdx,[rdx]
       mov       [rbp-80],rdx
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-68]
       mov       r8,7FF9C66E8150
       call      qword ptr [7FF9C5FBB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF9C642D260
       mov       edx,4C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-68]
       mov       rcx,21DB4C0D660
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-68]
       mov       [rbp-50],r8
M01_L03:
       mov       r8,[rbp-50]
       mov       rdx,[rbp-48]
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FF9C63F7C18]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-58],rax
       mov       rdx,[rbp-58]
       mov       [rbp-8],rdx
       mov       edx,[rbp+18]
       movzx     edx,dx
       mov       r8,[rbp-8]
       mov       rcx,offset MD_System.String.Join[[System.String, System.Private.CoreLib]](Char, System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FF9C66E91F8]; System.String.Join[[System.__Canon, System.Private.CoreLib]](Char, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 649
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

