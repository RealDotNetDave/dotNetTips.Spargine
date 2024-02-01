## DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark-20231026-185022
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9CEB1F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9CED5BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,183FE0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,18402002028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9CED5BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED750A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9C7C2CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,16D0D9C9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,16D0D9C3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9C7C2CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9CED7BC30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,1412CC085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,1412CC02028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9CED7BCE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9C7C5CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,1F0B7D275A0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,1F0B7D21028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9C7C5CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9CEB2F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9CED6BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,1E4CD8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,1E4CD802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9CED6BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED850A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9C7C5CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,29BC3989598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,29BC3983020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9C7C5CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9CED7BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,203E78041C0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,203EB802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9CED7BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,1D21EA89598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,1D21EA83020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9CED7AEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,20C350085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,20C35002028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9CED7AF50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9C7C3CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,22C501E9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,22C501E3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9C7C3CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A57610],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CCF0
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,214463E9598
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,214463E3020
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C6CDA0
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9C7C2CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,16D0D9C9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,16D0D9C3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9C7C2CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9CED7BC30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,1412CC085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,1412CC02028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9CED7BCE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9C7C5CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,1F0B7D275A0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,1F0B7D21028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9C7C5CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9CEB2F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9CED6BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,1E4CD8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,1E4CD802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9CED6BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      qword ptr [7FF9CED850A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9C7C5CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,29BC3989598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,29BC3983020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9C7C5CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9CED7BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,203E78041C0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,203EB802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9CED7BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,1D21EA89598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,1D21EA83020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9CED7AEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,20C350085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,20C35002028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9CED7AF50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9C7C3CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,22C501E9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,22C501E3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9C7C3CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED73FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB1F008],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BB68
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,183FE0001E8
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18402002028
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB65588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED5BC18
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED750A8]
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9CED7BC30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,1412CC085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,1412CC02028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9CED7BCE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9C7C5CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,1F0B7D275A0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,1F0B7D21028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9C7C5CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CEB2F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9CED6BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,1E4CD8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,1E4CD802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9CED6BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED850A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9C7C5CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,29BC3989598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,29BC3983020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9C7C5CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9CED7BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,203E78041C0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,203EB802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9CED7BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,1D21EA89598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,1D21EA83020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9CED7AEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,20C350085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,20C35002028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9CED7AF50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9C7C3CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,22C501E9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,22C501E3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9C7C3CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CD40
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,16D0D9C9598
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16D0D9C3020
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C2CDF0
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC30
+       mov       rdx,7FF9C7C5CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1412CC085C8
+       mov       r9,1F0B7D275A0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1412CC02028
+       mov       r9,1F0B7D21028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BCE0
+       mov       rdx,7FF9C7C5CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9CEB2F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC30
+       mov       rdx,7FF9CED6BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1412CC085C8
+       mov       r9,1E4CD8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1412CC02028
+       mov       r9,1E4CD802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BCE0
+       mov       rdx,7FF9CED6BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      qword ptr [7FF9CED850A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC30
+       mov       rdx,7FF9C7C5CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1412CC085C8
+       mov       r9,29BC3989598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1412CC02028
+       mov       r9,29BC3983020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BCE0
+       mov       rdx,7FF9C7C5CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
        cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC30
+       mov       rdx,7FF9CED7BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1412CC085C8
+       mov       r9,203E78041C0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1412CC02028
+       mov       r9,203EB802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BCE0
+       mov       rdx,7FF9CED7BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC30
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1412CC085C8
+       mov       r9,1D21EA89598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1412CC02028
+       mov       r9,1D21EA83020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BCE0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC30
+       mov       rdx,7FF9CED7AEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1412CC085C8
+       mov       r9,20C350085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1412CC02028
+       mov       r9,20C35002028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BCE0
+       mov       rdx,7FF9CED7AF50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC30
+       mov       rdx,7FF9C7C3CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1412CC085C8
+       mov       r9,22C501E9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1412CC02028
+       mov       r9,22C501E3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BCE0
+       mov       rdx,7FF9C7C3CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
        cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC30
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1412CC085C8
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1412CC02028
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BCE0
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC30
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1412CC085C8
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1412CC02028
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BCE0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC30
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1412CC085C8
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1412CC02028
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BCE0
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9CEB2F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CCF0
+       mov       rdx,7FF9CED6BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1F0B7D275A0
+       mov       r9,1E4CD8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F0B7D21028
+       mov       r9,1E4CD802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDA0
+       mov       rdx,7FF9CED6BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED850A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CCF0
+       mov       rdx,7FF9C7C5CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1F0B7D275A0
+       mov       r9,29BC3989598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F0B7D21028
+       mov       r9,29BC3983020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDA0
+       mov       rdx,7FF9C7C5CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CCF0
+       mov       rdx,7FF9CED7BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1F0B7D275A0
+       mov       r9,203E78041C0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F0B7D21028
+       mov       r9,203EB802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDA0
+       mov       rdx,7FF9CED7BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CCF0
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1F0B7D275A0
+       mov       r9,1D21EA89598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F0B7D21028
+       mov       r9,1D21EA83020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDA0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CCF0
+       mov       rdx,7FF9CED7AEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1F0B7D275A0
+       mov       r9,20C350085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F0B7D21028
+       mov       r9,20C35002028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDA0
+       mov       rdx,7FF9CED7AF50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CCF0
+       mov       rdx,7FF9C7C3CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1F0B7D275A0
+       mov       r9,22C501E9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F0B7D21028
+       mov       r9,22C501E3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDA0
+       mov       rdx,7FF9C7C3CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CCF0
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1F0B7D275A0
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F0B7D21028
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDA0
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CCF0
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1F0B7D275A0
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F0B7D21028
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDA0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CCF0
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1F0B7D275A0
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F0B7D21028
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDA0
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BB68
+       mov       rdx,7FF9C7C5CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1E4CD8085C8
+       mov       r9,29BC3989598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1E4CD802028
+       mov       r9,29BC3983020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BC18
+       mov       rdx,7FF9C7C5CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED850A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BB68
+       mov       rdx,7FF9CED7BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1E4CD8085C8
+       mov       r9,203E78041C0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1E4CD802028
+       mov       r9,203EB802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BC18
+       mov       rdx,7FF9CED7BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED850A8]
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BB68
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1E4CD8085C8
+       mov       r9,1D21EA89598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1E4CD802028
+       mov       r9,1D21EA83020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BC18
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED850A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BB68
+       mov       rdx,7FF9CED7AEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1E4CD8085C8
+       mov       r9,20C350085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1E4CD802028
+       mov       r9,20C35002028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BC18
+       mov       rdx,7FF9CED7AF50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED850A8]
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BB68
+       mov       rdx,7FF9C7C3CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1E4CD8085C8
+       mov       r9,22C501E9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1E4CD802028
+       mov       r9,22C501E3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BC18
+       mov       rdx,7FF9C7C3CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED850A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BB68
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1E4CD8085C8
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1E4CD802028
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BC18
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED850A8]
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BB68
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1E4CD8085C8
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1E4CD802028
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BC18
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED850A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BB68
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1E4CD8085C8
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1E4CD802028
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED6BC18
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED850A8]
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CD40
+       mov       rdx,7FF9CED7BB68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,29BC3989598
+       mov       r9,203E78041C0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,29BC3983020
+       mov       r9,203EB802028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDF0
+       mov       rdx,7FF9CED7BC18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CD40
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,29BC3989598
+       mov       r9,1D21EA89598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,29BC3983020
+       mov       r9,1D21EA83020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDF0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CD40
+       mov       rdx,7FF9CED7AEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,29BC3989598
+       mov       r9,20C350085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,29BC3983020
+       mov       r9,20C35002028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDF0
+       mov       rdx,7FF9CED7AF50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CD40
+       mov       rdx,7FF9C7C3CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,29BC3989598
+       mov       r9,22C501E9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,29BC3983020
+       mov       r9,22C501E3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDF0
+       mov       rdx,7FF9C7C3CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CD40
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,29BC3989598
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,29BC3983020
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDF0
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       r9,[rsi+290]
        mov       rdx,r9
        cmp       dword ptr [r9+8],1
        setg      r9b
        movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CD40
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,29BC3989598
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,29BC3983020
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDF0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CD40
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,29BC3989598
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,29BC3983020
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C5CDF0
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BB68
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,203E78041C0
+       mov       r9,1D21EA89598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,203EB802028
+       mov       r9,1D21EA83020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC18
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED950A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
        cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BB68
+       mov       rdx,7FF9CED7AEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,203E78041C0
+       mov       r9,20C350085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,203EB802028
+       mov       r9,20C35002028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC18
+       mov       rdx,7FF9CED7AF50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED950A8]
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BB68
+       mov       rdx,7FF9C7C3CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,203E78041C0
+       mov       r9,22C501E9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,203EB802028
+       mov       r9,22C501E3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC18
+       mov       rdx,7FF9C7C3CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED950A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BB68
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,203E78041C0
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,203EB802028
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC18
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BB68
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,203E78041C0
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,203EB802028
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC18
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED950A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BB68
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,203E78041C0
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,203EB802028
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7BC18
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED950A8]
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CCF0
+       mov       rdx,7FF9CED7AEA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1D21EA89598
+       mov       r9,20C350085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D21EA83020
+       mov       r9,20C35002028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CDA0
+       mov       rdx,7FF9CED7AF50
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED953F0]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CCF0
+       mov       rdx,7FF9C7C3CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1D21EA89598
+       mov       r9,22C501E9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D21EA83020
+       mov       r9,22C501E3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CDA0
+       mov       rdx,7FF9C7C3CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CCF0
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1D21EA89598
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D21EA83020
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CDA0
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
mov       rcx,[rbp+10]
        mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1D21EA89598
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D21EA83020
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CCF0
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,1D21EA89598
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D21EA83020
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CDA0
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AEA0
+       mov       rdx,7FF9C7C3CD40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,20C350085C8
+       mov       r9,22C501E9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20C35002028
+       mov       r9,22C501E3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AF50
+       mov       rdx,7FF9C7C3CDF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
        cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AEA0
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,20C350085C8
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20C35002028
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AF50
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AEA0
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,20C350085C8
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20C35002028
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AF50
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AEA0
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,20C350085C8
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20C35002028
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AF50
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED953F0]
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CD40
+       mov       rdx,7FF9CED7AF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,22C501E9598
+       mov       r9,224234085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,22C501E3020
+       mov       r9,22423402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CDF0
+       mov       rdx,7FF9CED7AFB0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CED950A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CD40
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,22C501E9598
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,22C501E3020
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CDF0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CD40
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,22C501E9598
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,22C501E3020
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CDF0
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+290]
-       xor       r9d,r9d
-       cmp       dword ptr [rdx+8],1
+       mov       r9,[rsi+290]
+       mov       rdx,r9
+       cmp       dword ptr [r9+8],1
        setg      r9b
+       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 88
+; Total bytes of code 92
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
+       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AF00
+       mov       rdx,7FF9C7C3CCF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,224234085C8
+       mov       r9,24ACF6B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,22423402028
+       mov       r9,24ACF6B3020
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AFB0
+       mov       rdx,7FF9C7C3CDA0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED950A8]
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
+       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 336
+; Total bytes of code 337
```
**Diff for AddIf01 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+290]
        xor       r9d,r9d
        cmp       dword ptr [rdx+8],1
        setg      r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AF00
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,224234085C8
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,22423402028
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9CED7AFB0
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF9CED950A8]
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
```
**Diff for AddIf01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       r9,[rsi+290]
-       mov       rdx,r9
-       cmp       dword ptr [r9+8],1
+       mov       rdx,[rsi+290]
+       xor       r9d,r9d
+       cmp       dword ptr [rdx+8],1
        setg      r9b
-       movzx     r9d,r9b
        mov       r8,[rsi+30]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
+       call      qword ptr [7FF9CE9D3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        mov       [rsp+28],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+28]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 88
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
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
        mov       [rbp+28],r9d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CE77F008],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
+       xor       ecx,ecx
        cmp       qword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+18]
        mov       [rbp-18],rcx
        nop
        jmp       near ptr M01_L08
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-20],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CCF0
+       mov       rdx,7FF9CE9B9E68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L03:
-       mov       r9,24ACF6B9598
+       mov       r9,1B5AE4001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,24ACF6B3020
+       mov       r9,1B5B2402028
        mov       r9,[r9]
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7C5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+18],rcx
        mov       ecx,[rbp+28]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L04
        mov       rcx,[rbp+18]
        mov       [rbp-38],rcx
        jmp       short M01_L07
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L05
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-30],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7C3CDA0
+       mov       rdx,7FF9CE9B9F18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-30],rax
 M01_L06:
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FF9CE9D50A8]
        mov       [rbp-38],rax
 M01_L07:
        mov       rax,[rbp-38]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L08
 M01_L08:
        mov       rax,[rbp-18]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 337
+; Total bytes of code 336
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CEB4F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,2D90E4085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,2D90E402028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9C7A37610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,2A52BA59598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,2A52BA53020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CEB2F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,25A9E0085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,25A9E002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9C7A37610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,2A624199598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,2A624193020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CEB4F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,294B6C085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,294B6C02028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,1F2211311B8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,1F201133020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,245890085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,24589002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,235CC2B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,235CC2B3020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,1CB0B8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,1CB0B802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,20FC7D49598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,20FC7D43020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1D201279598
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D201273020
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9C7A37610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,2A52BA59598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,2A52BA53020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9CEB2F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,25A9E0085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,25A9E002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9C7A37610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,2A624199598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,2A624193020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,294B6C085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,294B6C02028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,1F2211311B8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,1F201133020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,245890085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,24589002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,235CC2B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,235CC2B3020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,1CB0B8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,1CB0B802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,20FC7D49598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,20FC7D43020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2D90E4085C8
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2D90E402028
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CEB2F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,25A9E0085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,25A9E002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,2A624199598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,2A624193020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CEB4F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,294B6C085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,294B6C02028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,1F2211311B8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,1F201133020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,245890085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,24589002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,235CC2B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,235CC2B3020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,1CB0B8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,1CB0B802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,20FC7D49598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,20FC7D43020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A52BA59598
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A52BA53020
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9C7A37610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,25A9E0085C8
+       mov       r9,2A624199598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,25A9E002028
+       mov       r9,2A624193020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9CEB4F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,25A9E0085C8
+       mov       r9,294B6C085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,25A9E002028
+       mov       r9,294B6C02028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,25A9E0085C8
+       mov       r9,1F2211311B8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,25A9E002028
+       mov       r9,1F201133020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,25A9E0085C8
+       mov       r9,245890085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,25A9E002028
+       mov       r9,24589002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,25A9E0085C8
+       mov       r9,235CC2B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,25A9E002028
+       mov       r9,235CC2B3020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,25A9E0085C8
+       mov       r9,1CB0B8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,25A9E002028
+       mov       r9,1CB0B802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,25A9E0085C8
+       mov       r9,20FC7D49598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,25A9E002028
+       mov       r9,20FC7D43020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,25A9E0085C8
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,25A9E002028
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,25A9E0085C8
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,25A9E002028
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED83FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB2F008],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,25A9E0085C8
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,25A9E002028
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB75588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED85090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CEB4F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A624199598
+       mov       r9,294B6C085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A624193020
+       mov       r9,294B6C02028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A624199598
+       mov       r9,1F2211311B8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A624193020
+       mov       r9,1F201133020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A624199598
+       mov       r9,245890085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A624193020
+       mov       r9,24589002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A624199598
+       mov       r9,235CC2B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A624193020
+       mov       r9,235CC2B3020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A624199598
+       mov       r9,1CB0B8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A624193020
+       mov       r9,1CB0B802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A624199598
+       mov       r9,20FC7D49598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A624193020
+       mov       r9,20FC7D43020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A624199598
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A624193020
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A624199598
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A624193020
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A37610],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,2A624199598
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2A624193020
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,294B6C085C8
+       mov       r9,1F2211311B8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,294B6C02028
+       mov       r9,1F201133020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,294B6C085C8
+       mov       r9,245890085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,294B6C02028
+       mov       r9,24589002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,294B6C085C8
+       mov       r9,235CC2B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,294B6C02028
+       mov       r9,235CC2B3020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,294B6C085C8
+       mov       r9,1CB0B8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,294B6C02028
+       mov       r9,1CB0B802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,294B6C085C8
+       mov       r9,20FC7D49598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,294B6C02028
+       mov       r9,20FC7D43020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,294B6C085C8
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,294B6C02028
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,294B6C085C8
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,294B6C02028
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CEDA5300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB4F008],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,294B6C085C8
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,294B6C02028
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB95588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CEDA53D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1F2211311B8
+       mov       r9,245890085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F201133020
+       mov       r9,24589002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1F2211311B8
+       mov       r9,235CC2B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F201133020
+       mov       r9,235CC2B3020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1F2211311B8
+       mov       r9,1CB0B8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F201133020
+       mov       r9,1CB0B802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1F2211311B8
+       mov       r9,20FC7D49598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F201133020
+       mov       r9,20FC7D43020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1F2211311B8
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F201133020
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1F2211311B8
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F201133020
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1F2211311B8
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F201133020
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A17610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,245890085C8
+       mov       r9,235CC2B9598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,24589002028
+       mov       r9,235CC2B3020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,245890085C8
+       mov       r9,1CB0B8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,24589002028
+       mov       r9,1CB0B802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,245890085C8
+       mov       r9,20FC7D49598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,24589002028
+       mov       r9,20FC7D43020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,245890085C8
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,24589002028
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,245890085C8
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,24589002028
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,245890085C8
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,24589002028
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,235CC2B9598
+       mov       r9,1CB0B8085C8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,235CC2B3020
+       mov       r9,1CB0B802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,235CC2B9598
+       mov       r9,20FC7D49598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,235CC2B3020
+       mov       r9,20FC7D43020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,235CC2B9598
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,235CC2B3020
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,235CC2B9598
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,235CC2B3020
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A17610],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,235CC2B9598
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,235CC2B3020
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A27610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1CB0B8085C8
+       mov       r9,20FC7D49598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1CB0B802028
+       mov       r9,20FC7D43020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1CB0B8085C8
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1CB0B802028
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1CB0B8085C8
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1CB0B802028
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED95300]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1CB0B8085C8
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1CB0B802028
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED953D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CEB3F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,20FC7D49598
+       mov       r9,1F7CD0001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20FC7D43020
+       mov       r9,1F7D1002028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        cmp       dword ptr [rbp+8],1
        setg      r8b
        movzx     r8d,r8b
        call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        test      rax,rax
        sete      r9b
        movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,20FC7D49598
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20FC7D43020
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
        call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A27610],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,20FC7D49598
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,20FC7D43020
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
-       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       movzx     r8d,r8b
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9C7A47610],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
-       xor       r9d,r9d
        test      rax,rax
        sete      r9b
+       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1F7CD0001E8
+       mov       r9,18318419598
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F7D1002028
+       mov       r9,18318413020
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
+       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 309
+; Total bytes of code 310
```
**Diff for AddIf02 method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
        xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       call      qword ptr [7FF9CED93FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9CEB3F008],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
        xor       r9d,r9d
        test      rax,rax
        sete      r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,1F7CD0001E8
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1F7D1002028
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      qword ptr [7FF9CEB85588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      qword ptr [7FF9CED95090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
```
**Diff for AddIf02 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,110
        xor       eax,eax
        mov       [rsp+98],rax
        mov       rbx,rcx
        mov       rbp,[rbx+288]
        mov       r14,rbp
        lea       rsi,[rbx+0A0]
        lea       rdi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        lea       rdi,[rsp+28]
        lea       rsi,[rsp+0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,r14
        lea       rdx,[rsp+28]
+       xor       r8d,r8d
        cmp       dword ptr [rbp+8],1
        setg      r8b
-       movzx     r8d,r8b
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
+       call      qword ptr [7FF9CE9B3FA8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        mov       [rsp+98],rax
        mov       rsi,[rbx+18]
        mov       rdx,[rsp+98]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,110
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 ; Total bytes of code 154
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
        push      rbp
        push      rdi
        push      rsi
        sub       rsp,0C0
        lea       rbp,[rsp+0D0]
        xor       eax,eax
        mov       [rbp-0A8],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rbp+rax-10],xmm4
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C7A47610],0
+       cmp       dword ptr [7FF9CE75F008],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rdx,[rbp+18]
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person
        call      CORINFO_HELP_BOX
+       xor       r9d,r9d
        test      rax,rax
        sete      r9b
-       movzx     r9d,r9b
        mov       [rbp-14],r9d
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
        mov       r9,[rbp+10]
        mov       [rbp-20],r9
        nop
        jmp       near ptr M01_L05
 M01_L02:
-       mov       r9,18318419598
+       mov       r9,1ACA48001E8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,18318413020
+       mov       r9,1ACA8802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9CE7A5588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp+10],rcx
        mov       ecx,[rbp+20]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L03
        mov       rcx,[rbp+10]
        mov       [rbp-30],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
        mov       [rbp-0A8],rcx
        mov       rsi,[rbp+18]
        lea       rdi,[rbp-0A0]
        mov       ecx,0E
        rep movsq
        mov       rcx,[rbp-0A8]
        lea       rdx,[rbp-0A0]
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
+       call      qword ptr [7FF9CE9B5090]; DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
        mov       [rbp-30],rax
 M01_L04:
        mov       rax,[rbp-30]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       rax,[rbp-20]
        add       rsp,0C0
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 309
```
