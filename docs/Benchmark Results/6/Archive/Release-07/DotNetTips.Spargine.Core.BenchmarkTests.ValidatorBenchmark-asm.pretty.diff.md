## DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark-20231026-190330
**Diff for CheckItemsExists_NoValidation method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_NoValidation()
        sub       rsp,28
        mov       r8,[rcx+190]
        mov       [rsp+20],r8
        mov       rcx,[rcx+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CE97F048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 48
+; Total bytes of code 49
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
**Diff for CheckItemsExists_Validation_Inlining method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation_Inlining()
        push      rdi
        push      rsi
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rsi,rcx
        mov       rdi,[rsi+190]
-       mov       r9,1B4F3A13020
+       mov       r9,19E97402028
        mov       r9,[r9]
        mov       rdx,rdi
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.CheckItemsExists[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Boolean, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean, System.String)
+       call      qword ptr [7FF9CE87F7C8]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean, System.String)
        mov       [rsp+20],rdi
        mov       rcx,[rsi+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CE98F048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 96
+; Total bytes of code 98
 ; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean, System.String)
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
        mov       [rbp+20],r8d
        mov       [rbp+28],r9
-       cmp       dword ptr [7FF9C78A6D08],0
+       cmp       dword ptr [7FF9CE5D9F50],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
        xor       ecx,ecx
        mov       [rbp-1C],ecx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+18]
-       call      DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9CE87DA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       [rbp-18],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-18],0
        setg      al
-       movzx     eax,al
        mov       [rbp-1C],eax
 M01_L02:
        mov       eax,[rbp-1C]
        movzx     eax,al
        mov       [rbp-0C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        sete      al
-       movzx     eax,al
        mov       edx,[rbp+20]
        movzx     edx,dl
        and       eax,edx
        mov       [rbp-10],eax
        cmp       dword ptr [rbp-10],0
        je        short M01_L05
        nop
        mov       rax,[rbp+28]
        mov       [rbp-28],rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionIsNullOrHasNoItems()
+       call      qword ptr [7FF9CE6B90D8]
        mov       [rbp-30],rax
        mov       rcx,[rbp-28]
        mov       rdx,[rbp-30]
-       call      DotNetTips.Spargine.Core.Validator.CreateExceptionMessage(System.String, System.String)
+       call      qword ptr [7FF9CE65B2B8]
        mov       [rbp-38],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L03
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-40],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7B3F200
+       mov       rdx,7FF9CE894580
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-40],rax
 M01_L04:
        mov       rcx,[rbp-40]
        mov       rdx,[rbp-38]
        mov       r8,[rbp+18]
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon)
+       call      qword ptr [7FF9CE87F828]
        nop
        nop
 M01_L05:
        mov       eax,[rbp-0C]
        mov       [rbp-14],eax
        nop
-       jmp       short M01_L06
-M01_L06:
        mov       eax,[rbp-14]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 272
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
**Diff for CheckItemsExists_Validation method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation()
        push      rdi
        push      rsi
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rsi,rcx
        mov       rdi,[rsi+190]
-       mov       r9,177C4B13020
+       mov       r9,26247802028
        mov       r9,[r9]
        mov       rdx,rdi
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.CheckItemsExists[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Boolean, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean, System.String)
+       call      qword ptr [7FF9CE84F7C8]; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean, System.String)
        mov       [rsp+20],rdi
        mov       rcx,[rsi+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CE95F078]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 96
+; Total bytes of code 98
 ; DotNetTips.Spargine.Core.Validator.CheckItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean, System.String)
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
        mov       [rbp+20],r8d
        mov       [rbp+28],r9
-       cmp       dword ptr [7FF9C7886D08],0
+       cmp       dword ptr [7FF9CE5A9F50],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
        xor       ecx,ecx
        mov       [rbp-1C],ecx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+18]
-       call      DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9CE84DA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        mov       [rbp-18],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-18],0
        setg      al
-       movzx     eax,al
        mov       [rbp-1C],eax
 M01_L02:
        mov       eax,[rbp-1C]
        movzx     eax,al
        mov       [rbp-0C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        sete      al
-       movzx     eax,al
        mov       edx,[rbp+20]
        movzx     edx,dl
        and       eax,edx
        mov       [rbp-10],eax
        cmp       dword ptr [rbp-10],0
        je        short M01_L05
        nop
        mov       rax,[rbp+28]
        mov       [rbp-28],rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionIsNullOrHasNoItems()
+       call      qword ptr [7FF9CE6890D8]
        mov       [rbp-30],rax
        mov       rcx,[rbp-28]
        mov       rdx,[rbp-30]
-       call      DotNetTips.Spargine.Core.Validator.CreateExceptionMessage(System.String, System.String)
+       call      qword ptr [7FF9CE62B2B8]
        mov       [rbp-38],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L03
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-40],rcx
        jmp       short M01_L04
 M01_L03:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C7B1F290
+       mov       rdx,7FF9CE864580
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-40],rax
 M01_L04:
        mov       rcx,[rbp-40]
        mov       rdx,[rbp-38]
        mov       r8,[rbp+18]
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon)
+       call      qword ptr [7FF9CE84F828]
        nop
        nop
 M01_L05:
        mov       eax,[rbp-0C]
        mov       [rbp-14],eax
        nop
-       jmp       short M01_L06
-M01_L06:
        mov       eax,[rbp-14]
        add       rsp,60
        pop       rbp
        ret
 ; Total bytes of code 272
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
**Diff for ArgumentNotNullOrEmpty_NoValidation method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_NoValidation()
        sub       rsp,28
-       mov       r8,2248CBF2B90
+       mov       r8,22540412758
        mov       r8,[r8]
        mov       [rsp+20],r8
        mov       rcx,[rcx+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CE95DFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 54
+; Total bytes of code 55
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
**Diff for ArgumentNotNullOrEmpty_Validation_Inlining method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation_Inlining()
        push      rdi
        push      rsi
        sub       rsp,38
        xor       eax,eax
        mov       [rsp+30],rax
        mov       rsi,rcx
-       mov       rcx,2CCCC589740
+       mov       rcx,1FF8D8087B0
        mov       rcx,[rcx]
        mov       [rsp+20],rcx
-       mov       rcx,2CD3C582B90
+       mov       rcx,1FF8D812758
        mov       rdi,[rcx]
        mov       rcx,rdi
-       mov       r9,2CCCC583020
+       mov       r9,1FF8D802028
        mov       r9,[r9]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CE62B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rsp+30],rdi
        mov       rcx,[rsi+18]
        lea       r8,[rsp+30]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CE95F330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,38
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 115
+; Total bytes of code 117
 ; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        push      rbp
        sub       rsp,70
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-40],xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       [rbp+20],r8
        mov       [rbp+28],r9
-       cmp       dword ptr [7FF9C7886D08],0
+       cmp       dword ptr [7FF9CE5A9F50],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
-       call      System.String.IsNullOrEmpty(System.String)
+       call      qword ptr [7FF9CE391810]; System.String.IsNullOrEmpty(System.String)
        mov       [rbp-1C],eax
+       xor       ecx,ecx
        cmp       dword ptr [rbp-1C],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        jne       short M01_L01
        mov       rcx,[rbp+20]
-       call      System.String.IsNullOrEmpty(System.String)
+       call      qword ptr [7FF9CE391810]; System.String.IsNullOrEmpty(System.String)
        mov       [rbp-44],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-44],0
        sete      al
-       movzx     eax,al
        mov       [rbp-20],eax
        jmp       short M01_L02
 M01_L01:
        mov       eax,[rbp-20]
        movzx     eax,al
        mov       [rbp-8],eax
        cmp       dword ptr [rbp-8],0
        je        short M01_L03
        nop
        mov       rax,[rbp+20]
        mov       [rbp+10],rax
        nop
        nop
        jmp       short M01_L04
 M01_L03:
+       xor       eax,eax
        cmp       dword ptr [rbp-4],0
        sete      al
-       movzx     eax,al
        mov       [rbp-0C],eax
        cmp       dword ptr [rbp-0C],0
        je        short M01_L04
        nop
        mov       rax,[rbp+28]
        mov       [rbp-30],rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       call      qword ptr [7FF9CE689498]
        mov       [rbp-38],rax
        mov       rcx,[rbp-30]
        mov       rdx,[rbp-38]
-       call      DotNetTips.Spargine.Core.Validator.CreateExceptionMessage(System.String, System.String)
+       call      qword ptr [7FF9CE62B2B8]
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
        mov       rdx,[rbp+30]
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
+       call      qword ptr [7FF9CE689690]
        nop
        nop
 M01_L04:
        mov       ecx,[rbp+18]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L05
        mov       rcx,[rbp+10]
        mov       [rbp-28],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.String.Trim()
+       call      qword ptr [7FF9CE393438]; System.String.Trim()
        mov       [rbp-28],rax
 M01_L06:
        mov       rax,[rbp-28]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L07
-M01_L07:
        mov       rax,[rbp-18]
        add       rsp,70
        pop       rbp
        ret
-; Total bytes of code 280
+; Total bytes of code 281
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
**Diff for ArgumentNotNullOrEmpty_Validation method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation()
        push      rdi
        push      rsi
        sub       rsp,38
        xor       eax,eax
        mov       [rsp+30],rax
        mov       rsi,rcx
-       mov       rcx,1DB360D9740
+       mov       rcx,1FB4A8087B0
        mov       rcx,[rcx]
        mov       [rsp+20],rcx
-       mov       rcx,1DBA60D2B90
+       mov       rcx,1FB4E809B60
        mov       rdi,[rcx]
        mov       rcx,rdi
-       mov       r9,1DB360D3020
+       mov       r9,1FB4A802028
        mov       r9,[r9]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CE62B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rsp+30],rdi
        mov       rcx,[rsi+18]
        lea       r8,[rsp+30]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CE95F330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,38
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 115
+; Total bytes of code 117
 ; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        push      rbp
        sub       rsp,70
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-40],xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       [rbp+20],r8
        mov       [rbp+28],r9
-       cmp       dword ptr [7FF9C78A6D08],0
+       cmp       dword ptr [7FF9CE5A9F50],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
-       call      System.String.IsNullOrEmpty(System.String)
+       call      qword ptr [7FF9CE391810]; System.String.IsNullOrEmpty(System.String)
        mov       [rbp-1C],eax
+       xor       ecx,ecx
        cmp       dword ptr [rbp-1C],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        jne       short M01_L01
        mov       rcx,[rbp+20]
-       call      System.String.IsNullOrEmpty(System.String)
+       call      qword ptr [7FF9CE391810]; System.String.IsNullOrEmpty(System.String)
        mov       [rbp-44],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-44],0
        sete      al
-       movzx     eax,al
        mov       [rbp-20],eax
        jmp       short M01_L02
 M01_L01:
        mov       eax,[rbp-20]
        movzx     eax,al
        mov       [rbp-8],eax
        cmp       dword ptr [rbp-8],0
        je        short M01_L03
        nop
        mov       rax,[rbp+20]
        mov       [rbp+10],rax
        nop
        nop
        jmp       short M01_L04
 M01_L03:
+       xor       eax,eax
        cmp       dword ptr [rbp-4],0
        sete      al
-       movzx     eax,al
        mov       [rbp-0C],eax
        cmp       dword ptr [rbp-0C],0
        je        short M01_L04
        nop
        mov       rax,[rbp+28]
        mov       [rbp-30],rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       call      qword ptr [7FF9CE689498]
        mov       [rbp-38],rax
        mov       rcx,[rbp-30]
        mov       rdx,[rbp-38]
-       call      DotNetTips.Spargine.Core.Validator.CreateExceptionMessage(System.String, System.String)
+       call      qword ptr [7FF9CE62B2B8]
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
        mov       rdx,[rbp+30]
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
+       call      qword ptr [7FF9CE689690]
        nop
        nop
 M01_L04:
        mov       ecx,[rbp+18]
        movzx     ecx,cl
        test      ecx,ecx
        jne       short M01_L05
        mov       rcx,[rbp+10]
        mov       [rbp-28],rcx
        jmp       short M01_L06
 M01_L05:
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.String.Trim()
+       call      qword ptr [7FF9CE393438]; System.String.Trim()
        mov       [rbp-28],rax
 M01_L06:
        mov       rax,[rbp-28]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L07
-M01_L07:
        mov       rax,[rbp-18]
        add       rsp,70
        pop       rbp
        ret
-; Total bytes of code 280
+; Total bytes of code 281
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
