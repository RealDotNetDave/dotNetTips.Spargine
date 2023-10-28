## DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark-20231028-030041
**Diff for DefaultIfNullWithDefaultValueFromNull method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1C0]
-       mov       rdx,1C4717E2C70
+       mov       rdx,22BCF800C90
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
+       call      qword ptr [7FF9C64097C8]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6785330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 78
+; Total bytes of code 80
 ; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
        push      rbp
-       sub       rsp,40
+       push      rdi
+       sub       rsp,38
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
-       vmovdqu   xmmword ptr [rbp-18],xmm4
+       vmovdqa   xmmword ptr [rbp-20],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
+       mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
-       mov       [rbp-8],rax
-       mov       rax,[rbp-8]
        mov       [rbp-10],rax
+       mov       rax,[rbp-10]
+       mov       [rbp-18],rax
        cmp       qword ptr [rbp+10],0
        jne       short M01_L01
        mov       rax,[rbp+18]
+       mov       [rbp-20],rax
+       mov       rax,[rbp-20]
        mov       [rbp-18],rax
-       mov       rax,[rbp-18]
-       mov       [rbp-10],rax
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
-       mov       rax,1C4517E3020
+       mov       rax,22BCD802028
        mov       rax,[rax]
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
 M01_L01:
-       mov       rax,[rbp-10]
-       add       rsp,40
+       mov       rax,[rbp-18]
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 120
+; Total bytes of code 122
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
**Diff for DefaultIfNullWithDefaultValue method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,250B0B42C70
+       mov       rcx,22706800C90
        mov       rcx,[rcx]
-       mov       rdx,250B0B42C78
+       mov       rdx,22706800C98
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
+       call      qword ptr [7FF9C64397C8]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67B3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 84
+; Total bytes of code 86
 ; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String, System.String)
        push      rbp
-       sub       rsp,40
+       push      rdi
+       sub       rsp,38
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
-       vmovdqu   xmmword ptr [rbp-18],xmm4
+       vmovdqa   xmmword ptr [rbp-20],xmm4
        xor       eax,eax
-       mov       [rbp-8],rax
+       mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
-       mov       [rbp-8],rax
-       mov       rax,[rbp-8]
        mov       [rbp-10],rax
+       mov       rax,[rbp-10]
+       mov       [rbp-18],rax
        cmp       qword ptr [rbp+10],0
        jne       short M01_L01
        mov       rax,[rbp+18]
+       mov       [rbp-20],rax
+       mov       rax,[rbp-20]
        mov       [rbp-18],rax
-       mov       rax,[rbp-18]
-       mov       [rbp-10],rax
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
-       mov       rax,25090B43020
+       mov       rax,226FC802028
        mov       rax,[rax]
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
 M01_L01:
-       mov       rax,[rbp-10]
-       add       rsp,40
+       mov       rax,[rbp-18]
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 120
+; Total bytes of code 122
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
**Diff for DefaultIfNullOrEmptyWithDefaultValueFromNull method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValueFromNull()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1C0]
-       mov       rdx,136C6631C58
+       mov       rdx,26187812980
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
+       call      qword ptr [7FF9C64097E0]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6783FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 78
+; Total bytes of code 80
 ; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,136566317A8
+       mov       r9,261878114E0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,13636633020
+       mov       r9,26187800030
        mov       r9,[r9]
        mov       rcx,[rbp+18]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C640B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        mov       [rbp+18],rcx
        mov       rcx,[rbp+10]
-       call      System.String.IsNullOrEmpty(System.String)
+       call      qword ptr [7FF9C6101810]; System.String.IsNullOrEmpty(System.String)
        mov       [rbp-14],eax
        cmp       dword ptr [rbp-14],0
        jne       short M01_L01
        mov       rax,[rbp+10]
        mov       [rbp-20],rax
        jmp       short M01_L02
        mov       rax,[rbp+18]
        mov       [rbp-20],rax
 M01_L02:
        mov       rax,[rbp-20]
        mov       [rbp-8],rax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rax,[rbp-8]
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 164
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
**Diff for DefaultIfNullOrEmptyWithDefaultValue method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,1E6763A2C70
+       mov       rcx,1E369C00C90
        mov       rcx,[rcx]
-       mov       rdx,1E6763A2C78
+       mov       rdx,1E369C00C98
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
+       call      qword ptr [7FF9C64397E0]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67B5330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 84
+; Total bytes of code 86
 ; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,1E6763A17A8
+       mov       r9,1E36BC00808
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1E6563A3020
+       mov       r9,1E367C02028
        mov       r9,[r9]
        mov       rcx,[rbp+18]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C643B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        mov       [rbp+18],rcx
        mov       rcx,[rbp+10]
-       call      System.String.IsNullOrEmpty(System.String)
+       call      qword ptr [7FF9C6131810]; System.String.IsNullOrEmpty(System.String)
        mov       [rbp-14],eax
        cmp       dword ptr [rbp-14],0
        jne       short M01_L01
        mov       rax,[rbp+10]
        mov       [rbp-20],rax
        jmp       short M01_L02
        mov       rax,[rbp+18]
        mov       [rbp-20],rax
 M01_L02:
        mov       rax,[rbp-20]
        mov       [rbp-8],rax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rax,[rbp-8]
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 164
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
**Diff for HasValueWithLength method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+28]
        mov       edx,64
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
+       call      qword ptr [7FF9C4BF98E8]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C4F75318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 49
+; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
        push      rbp
        sub       rsp,60
        lea       rbp,[rsp+60]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF9C58463D8],0
+       cmp       dword ptr [7FF9C4C06210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       r8d,r8d
        mov       [rbp-8],r8
        mov       r8,[rbp-8]
        mov       [rsp+20],r8
-       mov       r8,1B4C3F73020
+       mov       r8,1C64FC02028
        mov       r8,[r8]
        mov       [rsp+28],r8
-       mov       r8,1B4C3F83630
+       mov       r8,1C64FC12668
        mov       r8,[r8]
        mov       ecx,[rbp+18]
        mov       r9d,[rbp+18]
        mov       edx,1
-       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
+       call      qword ptr [7FF9C4BFB0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
        mov       [rbp-10],eax
        mov       ecx,[rbp-10]
        mov       [rbp+18],ecx
        cmp       qword ptr [rbp+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.String.Trim()
+       call      qword ptr [7FF9C48F3438]; System.String.Trim()
        mov       [rbp-20],rax
        mov       rcx,[rbp-20]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C48F1BA0]; System.String.get_Length()
        mov       [rbp-24],eax
        mov       eax,[rbp-24]
        cmp       eax,[rbp+18]
        sete      al
        movzx     eax,al
        mov       [rbp-14],eax
        jmp       short M01_L02
        xor       eax,eax
        mov       [rbp-14],eax
 M01_L02:
        mov       eax,[rbp-14]
        movzx     eax,al
        mov       [rbp-0C],eax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       eax,[rbp-0C]
        add       rsp,60
        pop       rbp
        ret
-; Total bytes of code 198
+; Total bytes of code 199
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for HasValueWithMinMaxCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+28]
        mov       edx,5
        mov       r8d,64
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
+       call      qword ptr [7FF9C6409930]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6783FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 55
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        xor       r8d,r8d
        mov       [rbp-8],r8
        mov       r8,[rbp-8]
        mov       [rsp+20],r8
-       mov       r8,167F3DD3020
+       mov       r8,1308F802028
        mov       r8,[r8]
        mov       [rsp+28],r8
-       mov       r8,167F3DE3CB8
+       mov       r8,1308F812D50
        mov       r8,[r8]
        mov       ecx,[rbp+18]
        mov       r9d,[rbp+20]
        xor       edx,edx
-       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
+       call      qword ptr [7FF9C640B0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
        mov       [rbp-10],eax
        mov       r8d,[rbp-10]
        mov       [rbp+18],r8d
        xor       r8d,r8d
        mov       [rbp-8],r8
        mov       r8,[rbp-8]
        mov       [rsp+20],r8
-       mov       r8,167F3DD3020
+       mov       r8,1308F802028
        mov       r8,[r8]
        mov       [rsp+28],r8
-       mov       r8,167F3DE3CC0
+       mov       r8,1308F812D58
        mov       r8,[r8]
        mov       ecx,[rbp+20]
        mov       edx,[rbp+18]
        mov       r9d,7FFFFFFF
-       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
+       call      qword ptr [7FF9C640B0C0]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
        mov       [rbp-14],eax
        mov       ecx,[rbp-14]
        mov       [rbp+20],ecx
        cmp       qword ptr [rbp+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6101BA0]; System.String.get_Length()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        mov       edx,[rbp+18]
        mov       r8d,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.NumericExtensions.IsInRange(Int32, Int32, Int32)
+       call      qword ptr [7FF9C6661180]; DotNetTips.Spargine.Extensions.NumericExtensions.IsInRange(Int32, Int32, Int32)
        mov       [rbp-20],eax
        mov       eax,[rbp-20]
        mov       [rbp-18],eax
        jmp       short M01_L02
        xor       eax,eax
        mov       [rbp-18],eax
 M01_L02:
        mov       eax,[rbp-18]
        movzx     eax,al
        mov       [rbp-0C],eax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       eax,[rbp-0C]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 269
+; Total bytes of code 271
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for HasValueWithRegEx method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
-       mov       rcx,1C2391D2C70
+       mov       rcx,272EB400C90
        mov       rcx,[rcx]
-       mov       rdx,1C2391D2C78
+       mov       rdx,272EB400C98
        mov       rdx,[rdx]
        mov       r8d,1
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
+       call      qword ptr [7FF9C6429918]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67C5708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 72
+; Total bytes of code 74
 ; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
+       push      rdi
+       sub       rsp,48
+       lea       rbp,[rsp+50]
        xor       eax,eax
-       mov       [rbp-18],rax
+       mov       [rbp-20],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
-       mov       [rbp-4],eax
-       cmp       dword ptr [rbp-4],0
-       je        short M01_L01
-       mov       rcx,[rbp+18]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
+       call      qword ptr [7FF9C64298D0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
        mov       [rbp-0C],eax
        cmp       dword ptr [rbp-0C],0
        je        short M01_L01
+       mov       rcx,[rbp+18]
+       call      qword ptr [7FF9C64298D0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
+       mov       [rbp-14],eax
+       cmp       dword ptr [rbp-14],0
+       je        short M01_L01
        mov       rcx,offset MT_System.Text.RegularExpressions.Regex
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-18],rax
-       mov       rcx,[rbp-18]
+       mov       [rbp-20],rax
+       mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8d,[rbp+20]
-       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
-       mov       rcx,[rbp-18]
+       call      qword ptr [7FF9C6689618]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
+       mov       rcx,[rbp-20]
        mov       rdx,[rbp+10]
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-1C],eax
-       mov       eax,[rbp-1C]
-       mov       [rbp-8],eax
+       call      qword ptr [7FF9C6689B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-24],eax
+       mov       eax,[rbp-24]
+       mov       [rbp-10],eax
        jmp       short M01_L02
 M01_L01:
        xor       eax,eax
-       mov       [rbp-8],eax
+       mov       [rbp-10],eax
 M01_L02:
-       mov       eax,[rbp-8]
+       mov       eax,[rbp-10]
        movzx     eax,al
-       add       rsp,40
+       add       rsp,48
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 155
+; Total bytes of code 161
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for HasValueWithString method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithString()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,1F2B71C2C70
+       mov       rdx,1F92D400C90
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, System.String)
+       call      qword ptr [7FF9C6439900]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67B3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
-       mov       [rbp-4],eax
-       cmp       dword ptr [rbp-4],0
+       call      qword ptr [7FF9C64398D0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
+       mov       [rbp-0C],eax
+       cmp       dword ptr [rbp-0C],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
        mov       r8d,4
-       call      System.String.Equals(System.String, System.String, System.StringComparison)
-       mov       [rbp-0C],eax
-       mov       eax,[rbp-0C]
-       mov       [rbp-8],eax
+       call      qword ptr [7FF9C6131378]; System.String.Equals(System.String, System.String, System.StringComparison)
+       mov       [rbp-14],eax
+       mov       eax,[rbp-14]
+       mov       [rbp-10],eax
        jmp       short M01_L02
 M01_L01:
        xor       eax,eax
-       mov       [rbp-8],eax
+       mov       [rbp-10],eax
 M01_L02:
-       mov       eax,[rbp-8]
+       mov       eax,[rbp-10]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 97
+; Total bytes of code 101
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ToByteArray_ASCII method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,1A3CEC01AD0
+       mov       rdx,22A3A800AD8
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       call      qword ptr [7FF9C6419C60]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6795030]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6426210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,1A3CEC13838
+       mov       r9,22A3A8128A8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1A3CEC03020
+       mov       r9,22A3A802028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C641B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        mov       [rbp+10],rcx
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
        xor       ecx,ecx
        mov       [rbp-18],rcx
        jmp       short M01_L02
        mov       rcx,[rbp+18]
        mov       rdx,[rbp+10]
        mov       rax,[rbp+18]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        mov       [rbp-18],rax
 M01_L02:
        mov       rax,[rbp-18]
        mov       [rbp-8],rax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rax,[rbp-8]
        add       rsp,40
        pop       rbp
        ret
-; Total bytes of code 170
+; Total bytes of code 169
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
**Diff for ToByteArray_BigEndianUnicode method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,2213BFD1B80
+       mov       rdx,16011800B88
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       call      qword ptr [7FF9C6449C60]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67C3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6456210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,2213BFE3838
+       mov       r9,160118128A8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2213BFD3020
+       mov       r9,16011802028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C644B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        mov       [rbp+10],rcx
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
        xor       ecx,ecx
        mov       [rbp-18],rcx
        jmp       short M01_L02
        mov       rcx,[rbp+18]
        mov       rdx,[rbp+10]
        mov       rax,[rbp+18]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        mov       [rbp-18],rax
 M01_L02:
        mov       rax,[rbp-18]
        mov       [rbp-8],rax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rax,[rbp-8]
        add       rsp,40
        pop       rbp
        ret
-; Total bytes of code 170
+; Total bytes of code 169
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
**Diff for ToByteArray_Default method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,170A6641B08
+       mov       rdx,2CFB0800B10
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       call      qword ptr [7FF9C6429C60]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67A3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,170A6653838
+       mov       r9,2CFAC8003F0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,170A6643020
+       mov       r9,2CFB0802028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C642B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        mov       [rbp+10],rcx
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
        xor       ecx,ecx
        mov       [rbp-18],rcx
        jmp       short M01_L02
        mov       rcx,[rbp+18]
        mov       rdx,[rbp+10]
        mov       rax,[rbp+18]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        mov       [rbp-18],rax
 M01_L02:
        mov       rax,[rbp-18]
        mov       [rbp-8],rax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rax,[rbp-8]
        add       rsp,40
        pop       rbp
        ret
-; Total bytes of code 170
+; Total bytes of code 169
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
**Diff for ToByteArray_Latin1 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,1D6C36E1B60
+       mov       rdx,2A216000B68
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       call      qword ptr [7FF9C6429C60]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67A5B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,1D6C36F3838
+       mov       r9,2A2160128A8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1D6C36E3020
+       mov       r9,2A216002028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C642B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        mov       [rbp+10],rcx
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
        xor       ecx,ecx
        mov       [rbp-18],rcx
        jmp       short M01_L02
        mov       rcx,[rbp+18]
        mov       rdx,[rbp+10]
        mov       rax,[rbp+18]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        mov       [rbp-18],rax
 M01_L02:
        mov       rax,[rbp-18]
        mov       [rbp-8],rax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rax,[rbp-8]
        add       rsp,40
        pop       rbp
        ret
-; Total bytes of code 170
+; Total bytes of code 169
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
**Diff for ToByteArray_Unicode method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,24EC0A91B88
+       mov       rdx,160CBC00B90
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       call      qword ptr [7FF9C6419C60]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6793FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58863D8],0
+       cmp       dword ptr [7FF9C6426210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,24EC0AA3838
+       mov       r9,160C7C003F0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,24EC0A93020
+       mov       r9,160CBC02028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C641B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        mov       [rbp+10],rcx
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
        xor       ecx,ecx
        mov       [rbp-18],rcx
        jmp       short M01_L02
        mov       rcx,[rbp+18]
        mov       rdx,[rbp+10]
        mov       rax,[rbp+18]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        mov       [rbp-18],rax
 M01_L02:
        mov       rax,[rbp-18]
        mov       [rbp-8],rax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rax,[rbp-8]
        add       rsp,40
        pop       rbp
        ret
-; Total bytes of code 170
+; Total bytes of code 169
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
**Diff for ToByteArray_UTF32 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,1BEB4981B90
+       mov       rdx,24167000B98
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       call      qword ptr [7FF9C6439C60]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67B5570]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,1BE54989318
+       mov       r9,241670128A8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1BEB4983020
+       mov       r9,24167002028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C643B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        mov       [rbp+10],rcx
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
        xor       ecx,ecx
        mov       [rbp-18],rcx
        jmp       short M01_L02
        mov       rcx,[rbp+18]
        mov       rdx,[rbp+10]
        mov       rax,[rbp+18]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        mov       [rbp-18],rax
 M01_L02:
        mov       rax,[rbp-18]
        mov       [rbp-8],rax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rax,[rbp-8]
        add       rsp,40
        pop       rbp
        ret
-; Total bytes of code 170
+; Total bytes of code 169
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
**Diff for ToByteArray_UTF8 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,22F390D1BA8
+       mov       rdx,1EBDD400BB0
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       call      qword ptr [7FF9C6439C60]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67B3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58863D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,22F390E3838
+       mov       r9,1EBD94108B0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,22F390D3020
+       mov       r9,1EBD9400030
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C643B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        mov       [rbp+10],rcx
        cmp       qword ptr [rbp+18],0
        jne       short M01_L01
        xor       ecx,ecx
        mov       [rbp-18],rcx
        jmp       short M01_L02
        mov       rcx,[rbp+18]
        mov       rdx,[rbp+10]
        mov       rax,[rbp+18]
        mov       rax,[rax]
        mov       rax,[rax+58]
        call      qword ptr [rax+10]
        mov       [rbp-18],rax
 M01_L02:
        mov       rax,[rbp-18]
        mov       [rbp-8],rax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rax,[rbp-8]
        add       rsp,40
        pop       rbp
        ret
-; Total bytes of code 170
+; Total bytes of code 169
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
**Diff for CombineToString method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.CombineToString()
        push      rdi
        push      rsi
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rsi,rcx
        mov       rdx,[rsi+28]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.String, System.Private.CoreLib]](System.Object)
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
+       call      qword ptr [7FF9C6785300]; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rdi,rax
        mov       rcx,rsi
        mov       edx,0A
        mov       r8d,0F
        mov       r9d,0F
-       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
+       call      qword ptr [7FF9C63956C0]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
        mov       rdx,rax
        mov       rcx,rdi
-       call      DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
+       call      qword ptr [7FF9C6409738]; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
        mov       [rsp+20],rax
        mov       rsi,[rsi+18]
        mov       rdx,[rsp+20]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 110
+; Total bytes of code 113
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
-       xor       eax,eax
-       mov       [rbp-28],rax
+       push      rdi
+       sub       rsp,58
+       lea       rbp,[rsp+60]
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
-       mov       [rbp-10],rax
-       mov       [rbp-8],rcx
+       mov       [rbp-10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58463D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       r9,2C629DF12A0
+       mov       r9,22E4A800328
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2C619DF3020
+       mov       r9,22E46800030
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       call      qword ptr [7FF9C64875E8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-18],rax
+       mov       rcx,[rbp-18]
+       call      qword ptr [7FF9C662FAB0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       mov       [rbp-20],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
-       mov       [rbp-20],rcx
+       mov       [rbp-28],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5BBF6B0
+       mov       rdx,7FF9C6764D40
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
-       mov       [rbp-20],rax
-M01_L02:
-       mov       rcx,[rbp-20]
-       mov       rdx,[rbp-18]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rbp-28],rax
-       mov       rax,[rbp-28]
-       add       rsp,50
+M01_L02:
+       mov       rcx,[rbp-28]
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C6785378]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
+       mov       [rbp-30],rax
+       mov       rax,[rbp-30]
+       add       rsp,58
+       pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 208
 ; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
        push      r15
        push      r14
+       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
+       sub       rsp,50
+       xor       eax,eax
+       mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       xor       eax,eax
-       mov       [rsp+40],rax
+       vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       rbx,rcx
        mov       ebp,edx
        mov       esi,r8d
        mov       edi,r9d
        mov       ecx,esi
        mov       edx,1
-       call      DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
+       call      qword ptr [7FF9C6661078]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
        mov       esi,eax
        mov       edx,esi
        add       edx,1
        jo        near ptr M02_L04
        mov       ecx,edi
-       call      DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
+       call      qword ptr [7FF9C6661078]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
        mov       edi,eax
-       mov       rcx,2C619DF2EA8
+       mov       rcx,22E4E801ED0
        mov       rcx,[rcx]
        mov       edx,100
-       call      qword ptr [7FF9C57CAA08]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
-       lea       r14,[rsp+20]
-       mov       [rsp+28],rax
+       call      qword ptr [7FF9C637C420]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
+       mov       [rsp+30],rax
        test      rax,rax
        je        near ptr M02_L05
-       lea       r8,[rax+10]
+       lea       r14,[rax+10]
        mov       r15d,[rax+8]
 M02_L00:
-       add       r14,18
-       mov       [r14],r8
-       mov       [r14+8],r15d
+       mov       [rsp+40],r14
+       mov       [rsp+48],r15d
        xor       ecx,ecx
-       mov       [rsp+30],ecx
-       mov       byte ptr [rsp+34],0
-       lea       rcx,[rsp+20]
+       mov       [rsp+38],ecx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+28]
        mov       edx,ebp
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
-       lea       rcx,[rsp+38]
-       mov       rdx,[rcx]
-       mov       ecx,[rcx+8]
-       mov       eax,[rsp+30]
-       cmp       eax,ecx
+       call      qword ptr [7FF9C62E1DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       mov       ecx,[rsp+38]
+       mov       rdx,[rsp+40]
+       mov       eax,[rsp+48]
+       cmp       ecx,eax
        jae       near ptr M02_L06
-       movsxd    rcx,eax
-       mov       word ptr [rdx+rcx*2],2D
-       inc       eax
-       mov       [rsp+30],eax
+       mov       eax,ecx
+       mov       word ptr [rdx+rax*2],2D
+       inc       ecx
+       mov       [rsp+38],ecx
 M02_L01:
-       lea       rcx,[rsp+20]
+       lea       rcx,[rsp+28]
        mov       edx,esi
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
-       lea       rcx,[rsp+38]
-       mov       rdx,[rcx]
-       mov       ecx,[rcx+8]
-       mov       eax,[rsp+30]
-       cmp       eax,ecx
+       call      qword ptr [7FF9C62E1DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       mov       ecx,[rsp+38]
+       mov       rdx,[rsp+40]
+       mov       eax,[rsp+48]
+       cmp       ecx,eax
        jae       near ptr M02_L07
-       movsxd    rcx,eax
-       mov       word ptr [rdx+rcx*2],2D
-       inc       eax
-       mov       [rsp+30],eax
+       mov       eax,ecx
+       mov       word ptr [rdx+rax*2],2D
+       inc       ecx
+       mov       [rsp+38],ecx
 M02_L02:
-       lea       rcx,[rsp+20]
+       lea       rcx,[rsp+28]
        mov       edx,edi
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
-       mov       r15,rax
+       call      qword ptr [7FF9C62E1DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FF9C61FD930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
+       mov       r12,rax
        mov       rcx,[rbx+10]
-       cmp       [rcx],ecx
-       mov       rdx,r15
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
+       cmp       [rcx],cl
+       mov       rdx,r12
+       call      qword ptr [7FF9C610B2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
        test      rax,rax
        jne       short M02_L03
        mov       r14,[rbx+10]
        mov       ecx,ebp
        mov       edx,esi
        mov       r8d,edi
-       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
+       call      qword ptr [7FF9C6409588]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
        test      rax,rax
        je        near ptr M02_L08
        mov       rdx,rax
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
-       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9C67A7438]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,rax
-       cmp       [r14],r14d
+       cmp       [r14],r14b
        mov       rcx,r14
-       mov       rdx,r15
+       mov       rdx,r12
        mov       r9d,2
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
+       call      qword ptr [7FF9C610B318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
 M02_L03:
        mov       rcx,[rbx+10]
-       mov       rdx,r15
-       cmp       [rcx],ecx
-       call      qword ptr [7FF9C5673200]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
-       nop
-       add       rsp,48
+       cmp       [rcx],cl
+       mov       rdx,r12
+       call      qword ptr [7FF9C610B2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
+       test      rax,rax
+       je        short M02_L09
+       mov       rax,[rax]
+       add       rsp,50
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r14
        pop       r15
        ret
 M02_L04:
        call      CORINFO_HELP_OVERFLOW
 M02_L05:
-       xor       r8d,r8d
+       xor       r14d,r14d
        xor       r15d,r15d
        jmp       near ptr M02_L00
 M02_L06:
-       mov       rdx,2C619DF3188
+       mov       rdx,22E46800188
        mov       rdx,[rdx]
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FF9C61FDAF8]
        jmp       near ptr M02_L01
 M02_L07:
-       mov       rdx,2C619DF3188
+       mov       rdx,22E46800188
        mov       rdx,[rdx]
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FF9C61FDAF8]
        jmp       near ptr M02_L02
 M02_L08:
        mov       ecx,10
-       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
+       call      qword ptr [7FF9C634B780]
        int       3
-; Total bytes of code 475
+M02_L09:
+       mov       rdx,r12
+       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FF9C6819138]
+       int       3
+; Total bytes of code 507
 ; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
        push      rbp
-       sub       rsp,40
+       push      rdi
+       sub       rsp,38
        lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
        mov       [rbp-18],rax
+       mov       [rbp-20],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58463D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        xor       r8d,r8d
-       mov       [rbp-4],r8d
+       mov       [rbp-0C],r8d
        mov       r8,[rbp+10]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.String, System.Private.CoreLib]](System.String[], System.String)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
-       mov       [rbp-10],rax
-       mov       ecx,[rbp-4]
-       mov       rdx,[rbp-10]
-       call      DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
+       call      qword ptr [7FF9C67A7F78]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       [rbp-18],rax
-       mov       rax,[rbp-18]
-       add       rsp,40
+       mov       ecx,[rbp-0C]
+       mov       rdx,[rbp-18]
+       call      qword ptr [7FF9C67A9018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
+       mov       [rbp-20],rax
+       mov       rax,[rbp-20]
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 102
+; Total bytes of code 106
```
**Diff for Concat method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Concat()
        push      rdi
        push      rsi
-       push      rbx
-       sub       rsp,30
+       sub       rsp,28
        xor       eax,eax
-       mov       [rsp+28],rax
+       mov       [rsp+20],rax
        mov       rsi,rcx
        mov       rdx,[rsi+28]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.String, System.Private.CoreLib]](System.Object)
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
+       call      qword ptr [7FF9C67C3FA8]; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        mov       rdi,rax
-       mov       rcx,16085503190
-       mov       rbx,[rcx]
        mov       rcx,rsi
        mov       edx,0A
        mov       r8d,0F
        mov       r9d,0F
-       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
+       call      qword ptr [7FF9C63D56C0]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
        mov       r9,rax
-       mov       rdx,rbx
        mov       rcx,rdi
+       mov       rdx,2DA51C02190
+       mov       rdx,[rdx]
        mov       r8d,0FFFFFFFF
-       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
-       mov       [rsp+28],rax
+       call      qword ptr [7FF9C6449780]; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
+       mov       [rsp+20],rax
        mov       rsi,[rsi+18]
-       mov       rdx,[rsp+28]
+       mov       rdx,[rsp+20]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
-       add       rsp,30
-       pop       rbx
+       add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 134
+; Total bytes of code 132
 ; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
        push      rbp
-       sub       rsp,50
-       lea       rbp,[rsp+50]
-       xor       eax,eax
-       mov       [rbp-28],rax
+       push      rdi
+       sub       rsp,58
+       lea       rbp,[rsp+60]
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
-       mov       [rbp-10],rax
-       mov       [rbp-8],rcx
+       mov       [rbp-10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6456210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       r9,160D55012A0
+       mov       r9,2DA51C12FF8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,16085503020
+       mov       r9,2DA51C02028
        mov       r9,[r9]
        mov       rdx,[rbp+18]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       call      qword ptr [7FF9C64C75E8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-18],rax
+       mov       rcx,[rbp-18]
+       call      qword ptr [7FF9C666FAB0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       mov       [rbp-20],rax
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
-       mov       [rbp-20],rcx
+       mov       [rbp-28],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5BCF6B0
+       mov       rdx,7FF9C67A4D10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
-       mov       [rbp-20],rax
-M01_L02:
-       mov       rcx,[rbp-20]
-       mov       rdx,[rbp-18]
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rbp-28],rax
-       mov       rax,[rbp-28]
-       add       rsp,50
+M01_L02:
+       mov       rcx,[rbp-28]
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C67C5030]; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
+       mov       [rbp-30],rax
+       mov       rax,[rbp-30]
+       add       rsp,58
+       pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 208
 ; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
        push      r15
        push      r14
+       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
+       sub       rsp,50
+       xor       eax,eax
+       mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       xor       eax,eax
-       mov       [rsp+40],rax
+       vmovdqa   xmmword ptr [rsp+40],xmm4
        mov       rbx,rcx
        mov       ebp,edx
        mov       esi,r8d
        mov       edi,r9d
        mov       ecx,esi
        mov       edx,1
-       call      DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
+       call      qword ptr [7FF9C66A1078]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
        mov       esi,eax
        mov       edx,esi
        add       edx,1
        jo        near ptr M02_L04
        mov       ecx,edi
-       call      DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
+       call      qword ptr [7FF9C66A1078]; DotNetTips.Spargine.Extensions.NumericExtensions.EnsureMinimum(Int32, Int32)
        mov       edi,eax
-       mov       rcx,16085502EA8
+       mov       rcx,2DA51C01ED0
        mov       rcx,[rcx]
        mov       edx,100
-       call      qword ptr [7FF9C57DAA08]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
-       lea       r14,[rsp+20]
-       mov       [rsp+28],rax
+       call      qword ptr [7FF9C63BC420]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
+       mov       [rsp+30],rax
        test      rax,rax
        je        near ptr M02_L05
-       lea       r8,[rax+10]
+       lea       r14,[rax+10]
        mov       r15d,[rax+8]
 M02_L00:
-       add       r14,18
-       mov       [r14],r8
-       mov       [r14+8],r15d
+       mov       [rsp+40],r14
+       mov       [rsp+48],r15d
        xor       ecx,ecx
-       mov       [rsp+30],ecx
-       mov       byte ptr [rsp+34],0
-       lea       rcx,[rsp+20]
+       mov       [rsp+38],ecx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+28]
        mov       edx,ebp
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
-       lea       rcx,[rsp+38]
-       mov       rdx,[rcx]
-       mov       ecx,[rcx+8]
-       mov       eax,[rsp+30]
-       cmp       eax,ecx
+       call      qword ptr [7FF9C6321DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       mov       ecx,[rsp+38]
+       mov       rdx,[rsp+40]
+       mov       eax,[rsp+48]
+       cmp       ecx,eax
        jae       near ptr M02_L06
-       movsxd    rcx,eax
-       mov       word ptr [rdx+rcx*2],2D
-       inc       eax
-       mov       [rsp+30],eax
+       mov       eax,ecx
+       mov       word ptr [rdx+rax*2],2D
+       inc       ecx
+       mov       [rsp+38],ecx
 M02_L01:
-       lea       rcx,[rsp+20]
+       lea       rcx,[rsp+28]
        mov       edx,esi
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
-       lea       rcx,[rsp+38]
-       mov       rdx,[rcx]
-       mov       ecx,[rcx+8]
-       mov       eax,[rsp+30]
-       cmp       eax,ecx
+       call      qword ptr [7FF9C6321DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       mov       ecx,[rsp+38]
+       mov       rdx,[rsp+40]
+       mov       eax,[rsp+48]
+       cmp       ecx,eax
        jae       near ptr M02_L07
-       movsxd    rcx,eax
-       mov       word ptr [rdx+rcx*2],2D
-       inc       eax
-       mov       [rsp+30],eax
+       mov       eax,ecx
+       mov       word ptr [rdx+rax*2],2D
+       inc       ecx
+       mov       [rsp+38],ecx
 M02_L02:
-       lea       rcx,[rsp+20]
+       lea       rcx,[rsp+28]
        mov       edx,edi
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
-       mov       r15,rax
+       call      qword ptr [7FF9C6321DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FF9C623D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
+       mov       r12,rax
        mov       rcx,[rbx+10]
-       cmp       [rcx],ecx
-       mov       rdx,r15
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
+       cmp       [rcx],cl
+       mov       rdx,r12
+       call      qword ptr [7FF9C614B2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
        test      rax,rax
        jne       short M02_L03
        mov       r14,[rbx+10]
        mov       ecx,ebp
        mov       edx,esi
        mov       r8d,edi
-       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
+       call      qword ptr [7FF9C6449588]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
        test      rax,rax
        je        near ptr M02_L08
        mov       rdx,rax
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
-       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF9C67E7438]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,rax
-       cmp       [r14],r14d
+       cmp       [r14],r14b
        mov       rcx,r14
-       mov       rdx,r15
+       mov       rdx,r12
        mov       r9d,2
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
+       call      qword ptr [7FF9C614B318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
 M02_L03:
        mov       rcx,[rbx+10]
-       mov       rdx,r15
-       cmp       [rcx],ecx
-       call      qword ptr [7FF9C5683200]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
-       nop
-       add       rsp,48
+       cmp       [rcx],cl
+       mov       rdx,r12
+       call      qword ptr [7FF9C614B2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
+       test      rax,rax
+       je        short M02_L09
+       mov       rax,[rax]
+       add       rsp,50
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r14
        pop       r15
        ret
 M02_L04:
        call      CORINFO_HELP_OVERFLOW
 M02_L05:
-       xor       r8d,r8d
+       xor       r14d,r14d
        xor       r15d,r15d
        jmp       near ptr M02_L00
 M02_L06:
-       mov       rdx,16085503188
+       mov       rdx,2DA51C02180
        mov       rdx,[rdx]
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FF9C623DAF8]
        jmp       near ptr M02_L01
 M02_L07:
-       mov       rdx,16085503188
+       mov       rdx,2DA51C02180
        mov       rdx,[rdx]
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FF9C623DAF8]
        jmp       near ptr M02_L02
 M02_L08:
        mov       ecx,10
-       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
+       call      qword ptr [7FF9C638B780]
+       int       3
+M02_L09:
+       mov       rdx,r12
+       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FF9C68C7138]
        int       3
-; Total bytes of code 475
+; Total bytes of code 507
 ; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
        push      rbp
        sub       rsp,0C0
        lea       rbp,[rsp+0C0]
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M03_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M03_L00
        mov       [rbp-0A0],rsp
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        mov       [rbp+28],r9
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6456210],0
        je        short M03_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L01:
        nop
        mov       rcx,[rbp+10]
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C666F768]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
        mov       [rbp-3C],eax
        mov       ecx,[rbp-3C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M03_L02
        nop
-       mov       rcx,16085503020
+       mov       rcx,2DA51C02028
        mov       rcx,[rcx]
        mov       [rbp-18],rcx
        nop
-       jmp       near ptr M03_L15
+       jmp       near ptr M03_L14
 M03_L02:
        mov       rcx,[rbp+18]
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C666F768]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
        mov       [rbp-40],eax
        mov       ecx,[rbp-40]
        movzx     ecx,cl
        mov       [rbp-1C],ecx
        cmp       dword ptr [rbp-1C],0
        je        short M03_L03
        nop
-       mov       rcx,16085503020
+       mov       rcx,2DA51C02028
        mov       rcx,[rcx]
        mov       [rbp+18],rcx
        nop
 M03_L03:
-       mov       rcx,7FF9C5856908
+       mov       rcx,7FF9C6456700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1608550E040
+       mov       rcx,2DA51C0D0E0
        mov       rcx,[rcx]
        mov       [rbp-88],rcx
        mov       rcx,[rbp-88]
        mov       rax,[rbp-88]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+20]
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
        mov       [rbp-8],rcx
        nop
        mov       rcx,[rbp-8]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
+       call      qword ptr [7FF9C63CB288]; System.Text.StringBuilder.Append(System.String)
        mov       [rbp-50],rax
        mov       rdx,[rbp-50]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+28]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.HasItems[[System.String, System.Private.CoreLib]](System.String[])
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
+       call      qword ptr [7FF9C6755CC0]; DotNetTips.Spargine.Extensions.ArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
        mov       [rbp-54],eax
        mov       ecx,[rbp-54]
        movzx     ecx,cl
        mov       [rbp-20],ecx
        cmp       dword ptr [rbp-20],0
        je        near ptr M03_L13
        nop
        xor       ecx,ecx
        mov       [rbp-24],ecx
        nop
        jmp       near ptr M03_L12
        xor       ecx,ecx
        mov       [rbp-34],ecx
 M03_L08:
        cmp       dword ptr [rbp-34],0
        jne       short M03_L09
        mov       rcx,[rbp-8]
        mov       [rbp-70],rcx
        mov       rcx,[rbp-30]
        mov       rdx,[rbp+18]
-       call      System.String.Concat(System.String, System.String)
+       call      qword ptr [7FF9C6141C60]; System.String.Concat(System.String, System.String)
        mov       [rbp-78],rax
        mov       rcx,[rbp-70]
        mov       rdx,[rbp-78]
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
+       call      qword ptr [7FF9C63CB288]; System.Text.StringBuilder.Append(System.String)
        mov       [rbp-80],rax
        nop
        nop
        jmp       short M03_L10
 M03_L09:
        mov       rcx,[rbp-8]
        mov       rdx,[rbp-30]
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.AppendLine(System.String)
+       call      qword ptr [7FF9C63CB318]; System.Text.StringBuilder.AppendLine(System.String)
        mov       [rbp-68],rax
        nop
 M03_L10:
        mov       ecx,[rbp-24]
        mov       rdx,[rbp+28]
        cmp       ecx,[rdx+8]
        setl      cl
        movzx     ecx,cl
        mov       [rbp-38],ecx
        cmp       dword ptr [rbp-38],0
        jne       near ptr M03_L04
        nop
 M03_L13:
        mov       rcx,[rbp-8]
        mov       rax,[rbp-8]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-60],rax
        mov       rcx,[rbp-60]
        mov       [rbp-18],rcx
        nop
-       jmp       short M03_L14
-M03_L14:
        mov       rcx,rsp
-       call      M03_L16
+       call      M03_L15
        nop
-M03_L15:
+M03_L14:
        mov       rax,[rbp-18]
        add       rsp,0C0
        pop       rbp
        ret
-M03_L16:
+M03_L15:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+0C0]
        nop
-       mov       rcx,7FF9C5856908
+       mov       rcx,7FF9C6456700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1608550E040
+       mov       rcx,2DA51C0D0E0
        mov       rcx,[rcx]
        mov       [rbp-90],rcx
        mov       rcx,[rbp-90]
        mov       rdx,[rbp-8]
        mov       rax,[rbp-90]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+28]
        nop
        nop
        nop
        add       rsp,30
        pop       rbp
        ret
-; Total bytes of code 681
+; Total bytes of code 686
```
**Diff for DefaultIfNull method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,2930FC12C70
+       mov       rcx,26DA8400C90
        mov       rcx,[rcx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
+       call      qword ptr [7FF9C64297B0]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67A5330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 71
+; Total bytes of code 73
 ; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-8],rax
        mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
-       mov       [rbp-8],rax
-       mov       rax,[rbp-8]
        mov       [rbp-10],rax
+       mov       rax,[rbp-10]
+       mov       [rbp-18],rax
        cmp       qword ptr [rbp+10],0
        jne       short M01_L01
-       mov       rax,292FFC13020
+       mov       rax,26DB0402028
        mov       rax,[rax]
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
 M01_L01:
-       mov       rax,[rbp-10]
-       add       rsp,30
+       mov       rax,[rbp-18]
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 88
+; Total bytes of code 90
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
**Diff for DefaultIfNullOrEmpty method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,28E07072C70
+       mov       rcx,1CC3C400C90
        mov       rcx,[rcx]
-       mov       rdx,28E07072C78
+       mov       rdx,1CC3C400C98
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
+       call      qword ptr [7FF9C64097E0]; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6783FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 84
+; Total bytes of code 86
 ; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,28E070717A8
+       mov       r9,1CC324134D8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,28DE7073020
+       mov       r9,1CC32402028
        mov       r9,[r9]
        mov       rcx,[rbp+18]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C640B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        mov       [rbp+18],rcx
        mov       rcx,[rbp+10]
-       call      System.String.IsNullOrEmpty(System.String)
+       call      qword ptr [7FF9C6101810]; System.String.IsNullOrEmpty(System.String)
        mov       [rbp-14],eax
        cmp       dword ptr [rbp-14],0
        jne       short M01_L01
        mov       rax,[rbp+10]
        mov       [rbp-20],rax
        jmp       short M01_L02
        mov       rax,[rbp+18]
        mov       [rbp-20],rax
 M01_L02:
        mov       rax,[rbp-20]
        mov       [rbp-8],rax
        nop
-       jmp       short M01_L03
-M01_L03:
        mov       rax,[rbp-8]
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 164
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
**Diff for Extract method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,26ABEBF2C70
+       mov       rdx,18A62400C90
        mov       rdx,[rdx]
-       mov       r8,26ABEBF2C78
+       mov       r8,18A62400C98
        mov       r8,[r8]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
+       call      qword ptr [7FF9C4BD9840]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
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
-; Total bytes of code 85
+; Total bytes of code 86
 ; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
        push      rbp
        sub       rsp,70
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-40],xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C4BE6210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,26ACEC03838
+       mov       r9,18A5C4003F0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,26ACEBF3020
+       mov       r9,18A54402028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C4BDB270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-20],rax
        mov       r9,[rbp-20]
        mov       [rbp+10],r9
-       mov       r9,26ABEBF2C80
+       mov       r9,18A62400CA0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,26ACEBF3020
+       mov       r9,18A54402028
        mov       r9,[r9]
        mov       rcx,[rbp+18]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C4BDB270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-28],rax
        mov       r9,[rbp-28]
        mov       [rbp+18],r9
-       mov       r9,26ABEBF2C88
+       mov       r9,18A62400CA8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,26ACEBF3020
+       mov       r9,18A54402028
        mov       r9,[r9]
        mov       rcx,[rbp+20]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C4BDB270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-30],rax
        mov       rcx,[rbp-30]
        mov       [rbp+20],rcx
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
        mov       r8d,4
        cmp       [rcx],ecx
-       call      System.String.IndexOf(System.String, System.StringComparison)
+       call      qword ptr [7FF9C48D36C0]; System.String.IndexOf(System.String, System.StringComparison)
        mov       [rbp-34],eax
        mov       ecx,[rbp-34]
        mov       [rbp-4],ecx
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+20]
        mov       r8d,4
        cmp       [rcx],ecx
-       call      System.String.IndexOf(System.String, System.StringComparison)
+       call      qword ptr [7FF9C48D36C0]; System.String.IndexOf(System.String, System.StringComparison)
        mov       [rbp-38],eax
        mov       r8d,[rbp-38]
        mov       [rbp-8],r8d
        mov       r8d,[rbp-4]
        mov       [rbp-0C],r8d
        mov       r8d,[rbp-8]
        sub       r8d,[rbp-0C]
        mov       rcx,[rbp+10]
        mov       edx,[rbp-0C]
        cmp       [rcx],ecx
-       call      System.String.Substring(Int32, Int32)
+       call      qword ptr [7FF9C48D3360]; System.String.Substring(Int32, Int32)
        mov       [rbp-40],rax
        mov       rax,[rbp-40]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L01
-M01_L01:
        mov       rax,[rbp-18]
        add       rsp,70
        pop       rbp
        ret
-; Total bytes of code 358
+; Total bytes of code 362
```
**Diff for FromDeflateStringAsync method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromDeflateStringAsync()
        sub       rsp,58
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        xor       eax,eax
        mov       [rsp+50],rax
        xor       eax,eax
        mov       [rsp+30],rax
        mov       [rsp+20],rcx
        mov       dword ptr [rsp+28],0FFFFFFFF
        lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__18 ByRef)
+       call      qword ptr [7FF9C67953D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__18 ByRef)
        mov       rax,[rsp+30]
        test      rax,rax
        je        short M00_L01
        add       rsp,58
        ret
 M00_L01:
        lea       rcx,[rsp+30]
-       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
+       call      qword ptr [7FF9C672FED0]
        jmp       short M00_L00
-; Total bytes of code 90
+; Total bytes of code 92
 ; System.Threading.Tasks.Task.GetAwaiter()
        mov       rax,rcx
        ret
 ; Total bytes of code 4
 ; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
        mov       rcx,[rcx]
        mov       eax,[rcx+34]
        and       eax,11000000
        cmp       eax,1000000
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
-; Total bytes of code 24
+       jmp       qword ptr [7FF9C67950C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
+; Total bytes of code 25
 ; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__18 ByRef)
        push      rbp
        push      rdi
        push      rsi
-       push      rbx
-       sub       rsp,48
-       lea       rbp,[rsp+60]
-       mov       [rbp-40],rsp
+       sub       rsp,40
+       lea       rbp,[rsp+50]
+       mov       [rbp-30],rsp
        mov       rsi,rcx
-       cmp       [rsi],esi
-       mov       rcx,7FF9C55E4938
-       mov       edx,2BD
+       cmp       [rsi],sil
+       mov       rcx,7FF9C5FE4C10
+       mov       edx,2D2
        call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
        mov       rax,[rax+18]
        test      rax,rax
        je        near ptr M03_L05
 M03_L00:
        mov       rdi,rax
-       mov       [rbp-20],rdi
+       mov       [rbp-18],rdi
        mov       rdx,[rax+8]
-       mov       [rbp-28],rdx
+       mov       [rbp-20],rdx
        mov       rcx,[rax+10]
-       mov       [rbp-30],rcx
+       mov       [rbp-28],rcx
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18.MoveNext()
+       call      qword ptr [7FF9C67952A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18.MoveNext()
        nop
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-28]
        cmp       rcx,[rdi+10]
        je        short M03_L01
        lea       rcx,[rdi+10]
-       mov       rdx,[rbp-30]
+       mov       rdx,[rbp-28]
        call      CORINFO_HELP_ASSIGN_REF
 M03_L01:
-       mov       rbx,[rdi+8]
-       mov       rdx,[rbp-28]
-       cmp       rdx,rbx
+       mov       rsi,[rdi+8]
+       mov       rdx,[rbp-20]
+       cmp       rdx,rsi
        je        short M03_L04
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
-       test      rbx,rbx
+       test      rsi,rsi
        je        short M03_L02
-       cmp       qword ptr [rbx+10],0
+       cmp       qword ptr [rsi+10],0
        jne       short M03_L03
 M03_L02:
-       mov       rdx,[rbp-28]
+       mov       rdx,[rbp-20]
        test      rdx,rdx
        je        short M03_L04
        cmp       qword ptr [rdx+10],0
        je        short M03_L04
 M03_L03:
-       mov       rcx,rbx
-       mov       rdx,[rbp-28]
-       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
+       mov       rcx,rsi
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C672F9F0]
 M03_L04:
        nop
-       add       rsp,48
-       pop       rbx
+       add       rsp,40
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 M03_L05:
-       call      System.Threading.Thread.InitializeCurrentThread()
+       call      qword ptr [7FF9C6117210]; System.Threading.Thread.InitializeCurrentThread()
        jmp       near ptr M03_L00
        push      rbp
        push      rdi
        push      rsi
-       push      rbx
-       sub       rsp,28
+       sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
-       lea       rbp,[rbp+60]
-       mov       rdx,[rbp-30]
-       mov       rdi,[rbp-20]
+       lea       rbp,[rbp+50]
+       mov       rdx,[rbp-28]
+       mov       rdi,[rbp-18]
        cmp       rdx,[rdi+10]
        je        short M03_L06
        lea       rcx,[rdi+10]
        call      CORINFO_HELP_ASSIGN_REF
 M03_L06:
-       mov       rbx,[rdi+8]
-       mov       rdx,[rbp-28]
-       cmp       rdx,rbx
+       mov       rsi,[rdi+8]
+       mov       rdx,[rbp-20]
+       cmp       rdx,rsi
        je        short M03_L09
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
-       test      rbx,rbx
+       test      rsi,rsi
        je        short M03_L07
-       cmp       qword ptr [rbx+10],0
+       cmp       qword ptr [rsi+10],0
        jne       short M03_L08
 M03_L07:
-       cmp       qword ptr [rbp-28],0
+       cmp       qword ptr [rbp-20],0
        je        short M03_L09
-       mov       rdx,[rbp-28]
+       mov       rdx,[rbp-20]
        cmp       qword ptr [rdx+10],0
        je        short M03_L09
 M03_L08:
-       mov       rcx,rbx
-       mov       rdx,[rbp-28]
-       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
+       mov       rcx,rsi
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C672F9F0]
 M03_L09:
        nop
-       add       rsp,28
-       pop       rbx
+       add       rsp,30
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 311
 ; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
        push      rsi
        sub       rsp,20
        mov       rsi,rcx
-       mov       ecx,[rsi+34]
-       test      ecx,1600000
+       test      dword ptr [rsi+34],1600000
        jne       short M04_L00
        mov       rcx,rsi
        xor       r8d,r8d
        mov       edx,0FFFFFFFF
-       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
+       call      qword ptr [7FF9C6349AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
 M04_L00:
        mov       rcx,rsi
-       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
+       call      qword ptr [7FF9C6349270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
        mov       ecx,[rsi+34]
        and       ecx,1600000
        cmp       ecx,1000000
-       jne       short M04_L02
+       je        short M04_L01
+       mov       rcx,rsi
+       call      qword ptr [7FF9C67950D8]
 M04_L01:
+       nop
        add       rsp,20
        pop       rsi
        ret
-M04_L02:
-       mov       rcx,rsi
-       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
-       jmp       short M04_L01
 ; Total bytes of code 76
-**Method was not JITted yet.**
-System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
```
**Diff for FromZLibStringAsync method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromZLibStringAsync()
        sub       rsp,58
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        xor       eax,eax
        mov       [rsp+50],rax
        xor       eax,eax
        mov       [rsp+30],rax
        mov       [rsp+20],rcx
        mov       dword ptr [rsp+28],0FFFFFFFF
        lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__19 ByRef)
+       call      qword ptr [7FF9C67853D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__19 ByRef)
        mov       rax,[rsp+30]
        test      rax,rax
        je        short M00_L01
        add       rsp,58
        ret
 M00_L01:
        lea       rcx,[rsp+30]
-       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
+       call      qword ptr [7FF9C671FED0]
        jmp       short M00_L00
-; Total bytes of code 90
+; Total bytes of code 92
 ; System.Threading.Tasks.Task.GetAwaiter()
        mov       rax,rcx
        ret
 ; Total bytes of code 4
 ; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
        mov       rcx,[rcx]
        mov       eax,[rcx+34]
        and       eax,11000000
        cmp       eax,1000000
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
-; Total bytes of code 24
+       jmp       qword ptr [7FF9C67850C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
+; Total bytes of code 25
 ; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__19 ByRef)
        push      rbp
        push      rdi
        push      rsi
-       push      rbx
-       sub       rsp,48
-       lea       rbp,[rsp+60]
-       mov       [rbp-40],rsp
+       sub       rsp,40
+       lea       rbp,[rsp+50]
+       mov       [rbp-30],rsp
        mov       rsi,rcx
-       cmp       [rsi],esi
-       mov       rcx,7FF9C55D4938
-       mov       edx,2BD
+       cmp       [rsi],sil
+       mov       rcx,7FF9C5FD4C10
+       mov       edx,2D2
        call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
        mov       rax,[rax+18]
        test      rax,rax
        je        near ptr M03_L05
 M03_L00:
        mov       rdi,rax
-       mov       [rbp-20],rdi
+       mov       [rbp-18],rdi
        mov       rdx,[rax+8]
-       mov       [rbp-28],rdx
+       mov       [rbp-20],rdx
        mov       rcx,[rax+10]
-       mov       [rbp-30],rcx
+       mov       [rbp-28],rcx
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19.MoveNext()
+       call      qword ptr [7FF9C67852A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19.MoveNext()
        nop
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-28]
        cmp       rcx,[rdi+10]
        je        short M03_L01
        lea       rcx,[rdi+10]
-       mov       rdx,[rbp-30]
+       mov       rdx,[rbp-28]
        call      CORINFO_HELP_ASSIGN_REF
 M03_L01:
-       mov       rbx,[rdi+8]
-       mov       rdx,[rbp-28]
-       cmp       rdx,rbx
+       mov       rsi,[rdi+8]
+       mov       rdx,[rbp-20]
+       cmp       rdx,rsi
        je        short M03_L04
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
-       test      rbx,rbx
+       test      rsi,rsi
        je        short M03_L02
-       cmp       qword ptr [rbx+10],0
+       cmp       qword ptr [rsi+10],0
        jne       short M03_L03
 M03_L02:
-       mov       rdx,[rbp-28]
+       mov       rdx,[rbp-20]
        test      rdx,rdx
        je        short M03_L04
        cmp       qword ptr [rdx+10],0
        je        short M03_L04
 M03_L03:
-       mov       rcx,rbx
-       mov       rdx,[rbp-28]
-       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
+       mov       rcx,rsi
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C671F9F0]
 M03_L04:
        nop
-       add       rsp,48
-       pop       rbx
+       add       rsp,40
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 M03_L05:
-       call      System.Threading.Thread.InitializeCurrentThread()
+       call      qword ptr [7FF9C6107210]; System.Threading.Thread.InitializeCurrentThread()
        jmp       near ptr M03_L00
        push      rbp
        push      rdi
        push      rsi
-       push      rbx
-       sub       rsp,28
+       sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
-       lea       rbp,[rbp+60]
-       mov       rdx,[rbp-30]
-       mov       rdi,[rbp-20]
+       lea       rbp,[rbp+50]
+       mov       rdx,[rbp-28]
+       mov       rdi,[rbp-18]
        cmp       rdx,[rdi+10]
        je        short M03_L06
        lea       rcx,[rdi+10]
        call      CORINFO_HELP_ASSIGN_REF
 M03_L06:
-       mov       rbx,[rdi+8]
-       mov       rdx,[rbp-28]
-       cmp       rdx,rbx
+       mov       rsi,[rdi+8]
+       mov       rdx,[rbp-20]
+       cmp       rdx,rsi
        je        short M03_L09
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
-       test      rbx,rbx
+       test      rsi,rsi
        je        short M03_L07
-       cmp       qword ptr [rbx+10],0
+       cmp       qword ptr [rsi+10],0
        jne       short M03_L08
 M03_L07:
-       cmp       qword ptr [rbp-28],0
+       cmp       qword ptr [rbp-20],0
        je        short M03_L09
-       mov       rdx,[rbp-28]
+       mov       rdx,[rbp-20]
        cmp       qword ptr [rdx+10],0
        je        short M03_L09
 M03_L08:
-       mov       rcx,rbx
-       mov       rdx,[rbp-28]
-       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
+       mov       rcx,rsi
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C671F9F0]
 M03_L09:
        nop
-       add       rsp,28
-       pop       rbx
+       add       rsp,30
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 311
 ; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
        push      rsi
        sub       rsp,20
        mov       rsi,rcx
-       mov       ecx,[rsi+34]
-       test      ecx,1600000
+       test      dword ptr [rsi+34],1600000
        jne       short M04_L00
        mov       rcx,rsi
        xor       r8d,r8d
        mov       edx,0FFFFFFFF
-       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
+       call      qword ptr [7FF9C6339AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
 M04_L00:
        mov       rcx,rsi
-       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
+       call      qword ptr [7FF9C6339270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
        mov       ecx,[rsi+34]
        and       ecx,1600000
        cmp       ecx,1000000
-       jne       short M04_L02
+       je        short M04_L01
+       mov       rcx,rsi
+       call      qword ptr [7FF9C67850D8]
 M04_L01:
+       nop
        add       rsp,20
        pop       rsi
        ret
-M04_L02:
-       mov       rcx,rsi
-       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
-       jmp       short M04_L01
 ; Total bytes of code 76
-**Method was not JITted yet.**
-System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
```
**Diff for HasValue method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
+       call      qword ptr [7FF9C64398D0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67B3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 44
+; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
        push      rbp
-       sub       rsp,40
+       push      rdi
+       sub       rsp,38
        lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58863D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        cmp       qword ptr [rbp+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.String.Trim()
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
+       call      qword ptr [7FF9C6133438]; System.String.Trim()
+       mov       [rbp-18],rax
+       mov       rcx,[rbp-18]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
-       mov       [rbp-14],eax
-       cmp       dword ptr [rbp-14],0
+       call      qword ptr [7FF9C6131BA0]; System.String.get_Length()
+       mov       [rbp-1C],eax
+       xor       eax,eax
+       cmp       dword ptr [rbp-1C],0
        setg      al
-       movzx     eax,al
-       mov       [rbp-4],eax
+       mov       [rbp-0C],eax
        jmp       short M01_L02
 M01_L01:
        xor       eax,eax
-       mov       [rbp-4],eax
+       mov       [rbp-0C],eax
 M01_L02:
-       mov       eax,[rbp-4]
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,40
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 102
+; Total bytes of code 105
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for HasWhitespace method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
+       call      qword ptr [7FF9C6409948]; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6783FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 44
+; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp-18],xmm4
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,2605EED3838
+       mov       r9,2464700E4A0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,2605EEC3020
+       mov       r9,24643002028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C640B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        mov       [rbp+10],rcx
        xor       ecx,ecx
        mov       [rbp-4],ecx
        nop
        jmp       short M01_L04
 M01_L01:
        nop
        mov       rcx,[rbp+10]
        mov       edx,[rbp-4]
        cmp       [rcx],ecx
-       call      System.String.get_Chars(Int32)
+       call      qword ptr [7FF9C6101B88]; System.String.get_Chars(Int32)
        mov       [rbp-24],eax
        mov       ecx,[rbp-24]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
+       call      qword ptr [7FF9C64099C0]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
        mov       [rbp-28],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-28],0
        sete      al
-       movzx     eax,al
        mov       [rbp-8],eax
        cmp       dword ptr [rbp-8],0
        je        short M01_L02
        nop
        xor       eax,eax
        mov       [rbp-0C],eax
        nop
        jmp       short M01_L05
        mov       [rbp-4],eax
 M01_L04:
        mov       ecx,[rbp-4]
        mov       [rbp-1C],ecx
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6101BA0]; System.String.get_Length()
        mov       [rbp-20],eax
        mov       ecx,[rbp-1C]
        cmp       ecx,[rbp-20]
        setl      cl
        movzx     ecx,cl
        mov       [rbp-10],ecx
        cmp       dword ptr [rbp-10],0
        jne       short M01_L01
        mov       dword ptr [rbp-0C],1
        nop
-       jmp       short M01_L05
 M01_L05:
        mov       eax,[rbp-0C]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for Indent method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Indent()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
        mov       edx,0A
        mov       r8d,3E
-       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
+       call      qword ptr [7FF9C6409960]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67E53F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 73
+; Total bytes of code 75
 ; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
        push      rbp
        sub       rsp,90
        lea       rbp,[rsp+90]
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp-70],rsp
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C58463D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
-       mov       rcx,7FF9C5846908
+       mov       rcx,7FF9C6416700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1893539E040
+       mov       rcx,1F70400D0E0
        mov       rcx,[rcx]
        mov       [rbp-58],rcx
        mov       rcx,[rbp-58]
        mov       rax,[rbp-58]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+20]
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       [rbp-8],rcx
        nop
+       xor       ecx,ecx
        cmp       dword ptr [rbp+18],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L02
        nop
        mov       rcx,[rbp-8]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
+       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
        mov       [rbp-50],rax
        nop
        nop
        mov       dword ptr [rbp-10],1
        nop
        jmp       short M01_L05
 M01_L03:
        nop
        mov       edx,[rbp+20]
        movzx     edx,dx
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(Char)
+       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
        mov       [rbp-38],rax
        nop
        nop
        mov       ecx,[rbp-10]
        add       ecx,1
        jno       short M01_L04
        call      CORINFO_HELP_OVERFLOW
        mov       [rbp-10],ecx
 M01_L05:
        mov       ecx,[rbp-10]
        mov       [rbp-2C],ecx
        mov       ecx,[rbp+18]
-       call      System.Math.Abs(Int32)
+       call      qword ptr [7FF9C65B7288]; System.Math.Abs(Int32)
        mov       [rbp-30],eax
        mov       edx,[rbp-2C]
        cmp       edx,[rbp-30]
        setle     dl
        movzx     edx,dl
        mov       [rbp-14],edx
        cmp       dword ptr [rbp-14],0
        jne       short M01_L03
+       xor       ecx,ecx
        cmp       dword ptr [rbp+18],0
        setg      cl
-       movzx     ecx,cl
        mov       [rbp-18],ecx
        cmp       dword ptr [rbp-18],0
        je        short M01_L06
        nop
        mov       rcx,[rbp-8]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
+       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
        mov       [rbp-48],rax
        nop
        nop
 M01_L06:
        mov       rcx,[rbp-8]
        mov       rax,[rbp-8]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
        mov       [rbp-20],rcx
        nop
-       jmp       short M01_L07
-M01_L07:
        mov       rcx,rsp
-       call      M01_L08
+       call      M01_L07
        nop
        mov       rax,[rbp-20]
        add       rsp,90
        pop       rbp
        ret
-M01_L08:
+M01_L07:
        push      rbp
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+90]
        nop
-       mov       rcx,7FF9C5846908
+       mov       rcx,7FF9C6416700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1893539E040
+       mov       rcx,1F70400D0E0
        mov       rcx,[rcx]
        mov       [rbp-60],rcx
        mov       rcx,[rbp-60]
        mov       rdx,[rbp-8]
        mov       rax,[rbp-60]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+28]
        nop
        nop
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 466
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
**Diff for IsAsciiDigit method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        movzx     ecx,word ptr [rsi+1F0]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
+       call      qword ptr [7FF9C6439978]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67B3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
        push      rbp
-       sub       rsp,30
+       push      rdi
+       sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],ecx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       ecx,[rbp+10]
        movzx     ecx,cx
-       call      System.Char.IsDigit(Char)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6043318]; System.Char.IsDigit(Char)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 53
+; Total bytes of code 56
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsAsciiLetter method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        movzx     ecx,word ptr [rsi+1F0]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
+       call      qword ptr [7FF9C6439990]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67B3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
        push      rbp
-       sub       rsp,30
+       push      rdi
+       sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],ecx
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       ecx,[rbp+10]
        movzx     ecx,cx
-       call      System.Char.IsLetter(Char)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6043378]; System.Char.IsLetter(Char)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 53
+; Total bytes of code 56
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsAsciiLetterOrDigit method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        movzx     ecx,word ptr [rsi+1F0]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
+       call      qword ptr [7FF9C64299A8]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67A3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
        push      rbp
-       sub       rsp,30
+       push      rdi
+       sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],ecx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       ecx,[rbp+10]
        movzx     ecx,cx
-       call      System.Char.IsLetterOrDigit(Char)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6033438]; System.Char.IsLetterOrDigit(Char)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 53
+; Total bytes of code 56
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsAsciiWhitespace method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        movzx     ecx,word ptr [rsi+1F0]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
+       call      qword ptr [7FF9C64299C0]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67A3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
        push      rbp
-       sub       rsp,30
+       push      rdi
+       sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],ecx
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       ecx,[rbp+10]
        movzx     ecx,cx
-       call      System.Char.IsWhiteSpace(Char)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C60333A8]; System.Char.IsWhiteSpace(Char)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 53
+; Total bytes of code 56
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsCreditCardNumber method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+190]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsCreditCardNumber(System.String)
+       call      qword ptr [7FF9C64299D8]; DotNetTips.Spargine.Extensions.StringExtensions.IsCreditCardNumber(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6841A38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsCreditCardNumber(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58463D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5846908
+       mov       rcx,7FF9C6436700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,16C2123DFE0
+       mov       rcx,2ABC280D080
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6689B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsCurrencyCode method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+198]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsCurrencyCode(System.String)
+       call      qword ptr [7FF9C64199F0]; DotNetTips.Spargine.Extensions.StringExtensions.IsCurrencyCode(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67F5EB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsCurrencyCode(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6426210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5856908
+       mov       rcx,7FF9C6426700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1E0AB20DFE8
+       mov       rcx,1846B80D088
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6679B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsDomainAddress method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1A0]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsDomainAddress(System.String)
+       call      qword ptr [7FF9C6409A08]; DotNetTips.Spargine.Extensions.StringExtensions.IsDomainAddress(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67E9900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsDomainAddress(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58863D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5886908
+       mov       rcx,7FF9C6416700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1BF5EA4BFF8
+       mov       rcx,2C9DB80D090
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6669B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsEmailAddress method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsEmailAddress(System.String)
+       call      qword ptr [7FF9C6439A20]; DotNetTips.Spargine.Extensions.StringExtensions.IsEmailAddress(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C683BB28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsEmailAddress(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5866908
+       mov       rcx,7FF9C6446700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1D6948CDFF8
+       mov       rcx,21EFA80D098
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6699B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsEmpty method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
-       mov       rcx,1E6D7F92C70
+       mov       rcx,1FA49C00C90
        mov       rcx,[rcx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsEmpty(System.String)
+       call      qword ptr [7FF9C6449A38]; DotNetTips.Spargine.Extensions.StringExtensions.IsEmpty(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67C3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 53
+; Total bytes of code 55
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsEmpty(System.String)
        push      rbp
-       sub       rsp,30
+       push      rdi
+       sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58863D8],0
+       cmp       dword ptr [7FF9C6456210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
-       call      System.String.IsNullOrEmpty(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6141810]; System.String.IsNullOrEmpty(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 52
+; Total bytes of code 55
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsFirstLastName method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1D0]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsFirstLastName(System.String)
+       call      qword ptr [7FF9C6429A50]; DotNetTips.Spargine.Extensions.StringExtensions.IsFirstLastName(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6805EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsFirstLastName(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5866908
+       mov       rcx,7FF9C6436700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,257DA473AE0
+       mov       rcx,1F437C0D0A0
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6689B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsGuid method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
        push      rsi
        sub       rsp,30
        vzeroupper
        mov       rsi,rcx
        vmovupd   xmm0,[rsi+180]
        vmovupd   [rsp+20],xmm0
+       mov       rdx,227A50009A0
+       mov       rdx,[rdx]
        lea       rcx,[rsp+20]
-       call      System.Guid.ToString()
+       xor       r8d,r8d
+       call      qword ptr [7FF9C615D9A8]; System.Guid.ToString(System.String, System.IFormatProvider)
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
+       call      qword ptr [7FF9C6419A68]; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
        mov       rdx,[rsi+18]
        mov       [rdx+4C],al
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 56
-; System.Guid.ToString()
-       mov       rdx,233B6BD4610
-       mov       rdx,[rdx]
-       xor       r8d,r8d
-       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
-; Total bytes of code 21
+; Total bytes of code 74
+; System.Guid.ToString(System.String, System.IFormatProvider)
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,48
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
+       vmovdqa   xmmword ptr [rsp+30],xmm4
+       mov       rdi,rcx
+       mov       rsi,rdx
+       test      rsi,rsi
+       je        near ptr M01_L09
+       cmp       dword ptr [rsi+8],0
+       je        near ptr M01_L09
+       mov       ebx,[rsi+8]
+       cmp       ebx,1
+       jne       near ptr M01_L10
+M01_L00:
+       movzx     ebp,word ptr [rsi+0C]
+       cmp       ebp,58
+       ja        short M01_L05
+       cmp       ebp,44
+       ja        short M01_L03
+       cmp       ebp,42
+       je        near ptr M01_L06
+       cmp       ebp,44
+       jne       near ptr M01_L08
+M01_L01:
+       mov       ecx,24
+M01_L02:
+       call      System.String.FastAllocateString(Int32)
+       mov       rbp,rax
+       lea       rcx,[rbp+0C]
+       mov       edx,[rbp+8]
+       add       rsi,0C
+       mov       [rsp+30],rcx
+       mov       [rsp+38],edx
+       mov       [rsp+20],rsi
+       mov       [rsp+28],ebx
+       mov       rcx,rdi
+       lea       rdx,[rsp+30]
+       lea       r9,[rsp+20]
+       lea       r8,[rsp+40]
+       call      qword ptr [7FF9C615D9C0]; System.Guid.TryFormat(System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
+       mov       rax,rbp
+       add       rsp,48
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       ret
+M01_L03:
+       cmp       ebp,4E
+       jne       near ptr M01_L11
+M01_L04:
+       mov       ecx,20
+       jmp       short M01_L02
+M01_L05:
+       cmp       ebp,64
+       jbe       near ptr M01_L12
+       cmp       ebp,6E
+       je        short M01_L04
+       cmp       ebp,70
+       je        short M01_L06
+       cmp       ebp,78
+       je        short M01_L07
+       jmp       short M01_L08
+M01_L06:
+       mov       ecx,26
+       jmp       short M01_L02
+M01_L07:
+       mov       ecx,44
+       jmp       near ptr M01_L02
+M01_L08:
+       mov       rcx,offset MT_System.FormatException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       ecx,0C32D
+       mov       rdx,7FF9C5EC4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FF9C613D030]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FF9C649BEE8]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L09:
+       mov       rcx,227A50009A0
+       mov       rsi,[rcx]
+       mov       ebx,[rsi+8]
+       cmp       ebx,1
+       je        near ptr M01_L00
+M01_L10:
+       mov       rcx,offset MT_System.FormatException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       ecx,0C32D
+       mov       rdx,7FF9C5EC4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FF9C613D030]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FF9C649BEE8]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L11:
+       cmp       ebp,50
+       je        near ptr M01_L06
+       cmp       ebp,58
+       je        near ptr M01_L07
+       jmp       near ptr M01_L08
+M01_L12:
+       cmp       ebp,62
+       je        near ptr M01_L06
+       cmp       ebp,64
+       je        near ptr M01_L01
+       jmp       near ptr M01_L08
+; Total bytes of code 435
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58863D8],0
+       cmp       dword ptr [7FF9C6426210],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
-       mov       rcx,7FF9C5886908
+       mov       rcx,7FF9C6426700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,233B6BCE008
+       mov       rcx,2279700D0A8
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6679B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
```
**Diff for IsISBN method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1B8]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsISBN(System.String)
+       call      qword ptr [7FF9C6439A80]; DotNetTips.Spargine.Extensions.StringExtensions.IsISBN(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6817438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsISBN(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5866908
+       mov       rcx,7FF9C6446700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,2231574E010
+       mov       rcx,2DC2280D0B0
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6699B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsMacAddress method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
-       mov       rcx,235CFE92C70
+       mov       rcx,1DB01000C90
        mov       rcx,[rcx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
+       call      qword ptr [7FF9C6429A98]; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6807888]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 53
+; Total bytes of code 55
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5866908
+       mov       rcx,7FF9C6436700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,235BFE9E018
+       mov       rcx,1DAF300D0B8
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6689B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsNotEmpty method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
-       mov       rcx,265AE572C70
+       mov       rcx,1C295800C90
        mov       rcx,[rcx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
+       call      qword ptr [7FF9C6429AB0]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67A5318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 53
+; Total bytes of code 55
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
        push      rbp
-       sub       rsp,30
+       push      rdi
+       sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsEmpty(System.String)
-       mov       [rbp-4],eax
-       cmp       dword ptr [rbp-4],0
+       call      qword ptr [7FF9C6429A38]; DotNetTips.Spargine.Extensions.StringExtensions.IsEmpty(System.String)
+       mov       [rbp-0C],eax
+       xor       eax,eax
+       cmp       dword ptr [rbp-0C],0
        sete      al
-       movzx     eax,al
-       add       rsp,30
+       add       rsp,28
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 56
+; Total bytes of code 58
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsOneToSevenAlpha method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1C8]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsOneToSevenAlpha(System.String)
+       call      qword ptr [7FF9C6439AC8]; DotNetTips.Spargine.Extensions.StringExtensions.IsOneToSevenAlpha(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6815EB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsOneToSevenAlpha(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58863D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5886908
+       mov       rcx,7FF9C6446700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,270F55FE020
+       mov       rcx,14D8F408CB8
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6699B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsScientific method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
-       mov       rcx,2CDAF992C70
+       mov       rcx,1B1C2C00C90
        mov       rcx,[rcx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsScientific(System.String)
+       call      qword ptr [7FF9C6419AE0]; DotNetTips.Spargine.Extensions.StringExtensions.IsScientific(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67F7438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 53
+; Total bytes of code 55
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsScientific(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58863D8],0
+       cmp       dword ptr [7FF9C6426210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5886908
+       mov       rcx,7FF9C6426700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,2CD8F99BC20
+       mov       rcx,1B1C0C0D0D0
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6679B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsString method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsString(System.String)
+       call      qword ptr [7FF9C6419AF8]; DotNetTips.Spargine.Extensions.StringExtensions.IsString(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67F73D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 44
+; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsString(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6426210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5866908
+       mov       rcx,7FF9C6426700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,288F93BE048
+       mov       rcx,16D6F80D0E8
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6679B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsStringSHA1Hash method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1B0]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
+       call      qword ptr [7FF9C6439B10]; DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6817168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
        push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
+       push      rdi
+       sub       rsp,38
+       lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-10],rax
+       mov       [rbp-18],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5876908
+       mov       rcx,7FF9C6446700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1D6EED7E038
+       mov       rcx,20F6BC0D0D8
        mov       rcx,[rcx]
-       mov       [rbp-10],rcx
-       mov       rcx,[rbp-10]
+       mov       [rbp-18],rcx
+       mov       rcx,[rbp-18]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       mov       [rbp-4],eax
-       mov       eax,[rbp-4]
+       call      qword ptr [7FF9C6699B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rbp-0C],eax
+       mov       eax,[rbp-0C]
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 101
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsUrl method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+1A0]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.IsUrl(System.String)
+       call      qword ptr [7FF9C6429B28]; DotNetTips.Spargine.Extensions.StringExtensions.IsUrl(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C68433D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 47
+; Total bytes of code 49
 ; DotNetTips.Spargine.Extensions.StringExtensions.IsUrl(System.String)
        push      rbp
-       sub       rsp,40
+       push      rdi
+       sub       rsp,38
        lea       rbp,[rsp+40]
        xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-18],rax
+       mov       [rbp-10],rax
+       mov       [rbp-20],rax
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
-       mov       rcx,7FF9C5856908
+       mov       rcx,7FF9C6436700
        mov       edx,2D
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,12DEA5DE050
+       mov       rcx,25ACD40D0F0
        mov       rcx,[rcx]
-       mov       [rbp-18],rcx
-       mov       rcx,[rbp-18]
+       mov       [rbp-20],rcx
+       mov       rcx,[rbp-20]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.Match(System.String)
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
+       call      qword ptr [7FF9C6689BE8]; System.Text.RegularExpressions.Regex.Match(System.String)
+       mov       [rbp-10],rax
+       mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Group.get_Success()
-       mov       [rbp-0C],eax
-       mov       eax,[rbp-0C]
+       call      qword ptr [7FF9C67B9450]; System.Text.RegularExpressions.Group.get_Success()
+       mov       [rbp-14],eax
+       mov       eax,[rbp-14]
        movzx     eax,al
-       add       rsp,40
+       add       rsp,38
+       pop       rdi
        pop       rbp
        ret
-; Total bytes of code 120
+; Total bytes of code 124
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ReplaceEllipsisWithPeriod method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1D8]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
+       call      qword ptr [7FF9C6429B58]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67A3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 67
 ; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
        push      rbp
        sub       rsp,70
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-40],xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,246B4F33838
+       mov       r9,240BC4128A8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,246B4F23020
+       mov       r9,240BC402028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C642B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-20],rax
        mov       rdx,[rbp-20]
        mov       [rbp+10],rdx
-       mov       rdx,246B4F33700
+       mov       rdx,240BC412760
        mov       rdx,[rdx]
        mov       rcx,[rbp+10]
        mov       r8d,5
        cmp       [rcx],ecx
-       call      System.String.EndsWith(System.String, System.StringComparison)
+       call      qword ptr [7FF9C61212D0]; System.String.EndsWith(System.String, System.StringComparison)
        mov       [rbp-24],eax
        mov       ecx,[rbp-24]
        movzx     ecx,cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+10]
        mov       [rbp-10],rcx
        mov       rcx,[rbp-10]
        mov       [rbp-30],rcx
        xor       ecx,ecx
        mov       [rbp-34],ecx
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6121BA0]; System.String.get_Length()
        mov       [rbp-38],eax
        mov       r8d,[rbp-38]
        add       r8d,0FFFFFFFE
        mov       rcx,[rbp-30]
        mov       edx,[rbp-34]
        cmp       [rcx],ecx
-       call      System.String.Substring(Int32, Int32)
+       call      qword ptr [7FF9C6123360]; System.String.Substring(Int32, Int32)
        mov       [rbp-40],rax
        mov       rax,[rbp-40]
        mov       [rbp+10],rax
        nop
 M01_L01:
        mov       rax,[rbp+10]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L02
-M01_L02:
        mov       rax,[rbp-18]
        add       rsp,70
        pop       rbp
        ret
-; Total bytes of code 253
+; Total bytes of code 255
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
**Diff for StartsWithOrdinal method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
-       mov       rcx,1A5F2EF1C58
+       mov       rcx,1405B400C90
        mov       rcx,[rcx]
-       mov       rdx,1A5F2EF1C60
+       mov       rdx,1405B400C98
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
+       call      qword ptr [7FF9C6409BE8]; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C6785018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 68
 ; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
        push      rbp
        sub       rsp,70
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,1A592F03838
+       mov       r9,140514128A8
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1A592EF3020
+       mov       r9,14051402028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C640B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       r9,[rbp-10]
        mov       [rbp+10],r9
-       mov       r9,1A5F2EF1C68
+       mov       r9,1405B400CA0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1A592EF3020
+       mov       r9,14051402028
        mov       r9,[r9]
        mov       rcx,[rbp+18]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C640B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        mov       [rbp+18],rcx
        mov       rcx,[rbp+10]
        mov       [rbp-20],rcx
        xor       ecx,ecx
        mov       [rbp-24],ecx
        mov       rcx,[rbp+18]
        mov       [rbp-30],rcx
        xor       ecx,ecx
        mov       [rbp-34],ecx
        mov       rcx,[rbp+18]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6101BA0]; System.String.get_Length()
        mov       [rbp-38],eax
        mov       ecx,[rbp-38]
        mov       [rsp+20],ecx
        mov       dword ptr [rsp+28],4
        mov       rcx,[rbp-20]
        mov       edx,[rbp-24]
        mov       r8,[rbp-30]
        mov       r9d,[rbp-34]
-       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
+       call      qword ptr [7FF9C6101228]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
        mov       [rbp-3C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-3C],0
        sete      al
-       movzx     eax,al
        mov       [rbp-4],eax
        nop
-       jmp       short M01_L01
-M01_L01:
        mov       eax,[rbp-4]
        add       rsp,70
        pop       rbp
        ret
-; Total bytes of code 275
+; Total bytes of code 276
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for StartsWithOrdinalIgnoreCase method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
-       mov       rcx,22470B41C58
+       mov       rcx,1B47D000C90
        mov       rcx,[rcx]
-       mov       rdx,22470B41C60
+       mov       rdx,1B47D000C98
        mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
+       call      qword ptr [7FF9C6439C00]; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67B3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 68
 ; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
        push      rbp
        sub       rsp,70
        lea       rbp,[rsp+70]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6446210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
-       mov       r9,22410B53838
+       mov       r9,1B48100E4A0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,22410B43020
+       mov       r9,1B485002028
        mov       r9,[r9]
        mov       rcx,[rbp+10]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C643B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-10],rax
        mov       r9,[rbp-10]
        mov       [rbp+10],r9
-       mov       r9,22470B41C68
+       mov       r9,1B47D000CA0
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,22410B43020
+       mov       r9,1B485002028
        mov       r9,[r9]
        mov       rcx,[rbp+18]
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9C643B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       [rbp-18],rax
        mov       rcx,[rbp-18]
        mov       [rbp+18],rcx
        mov       rcx,[rbp+10]
        mov       [rbp-20],rcx
        xor       ecx,ecx
        mov       [rbp-24],ecx
        mov       rcx,[rbp+18]
        mov       [rbp-30],rcx
        xor       ecx,ecx
        mov       [rbp-34],ecx
        mov       rcx,[rbp+18]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6131BA0]; System.String.get_Length()
        mov       [rbp-38],eax
        mov       ecx,[rbp-38]
        mov       [rsp+20],ecx
        mov       dword ptr [rsp+28],5
        mov       rcx,[rbp-20]
        mov       edx,[rbp-24]
        mov       r8,[rbp-30]
        mov       r9d,[rbp-34]
-       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
+       call      qword ptr [7FF9C6131228]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
        mov       [rbp-3C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-3C],0
        sete      al
-       movzx     eax,al
        mov       [rbp-4],eax
        nop
-       jmp       short M01_L01
-M01_L01:
        mov       eax,[rbp-4]
        add       rsp,70
        pop       rbp
        ret
-; Total bytes of code 275
+; Total bytes of code 276
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for SubstringTrim method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SubstringTrim()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,rsi
        mov       rax,[rsi]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       rcx,rax
        mov       edx,19
        mov       r8d,19
-       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
+       call      qword ptr [7FF9C6409C18]; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C6785810]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 85
+; Total bytes of code 87
 ; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
        push      rbp
        sub       rsp,0D0
        lea       rbp,[rsp+0D0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-0A0],xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C58663D8],0
+       cmp       dword ptr [7FF9C6416210],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
        mov       rcx,[rbp+10]
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C662F768]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
        mov       [rbp-3C],eax
        mov       ecx,[rbp-3C]
        movzx     ecx,cl
        mov       [rbp-14],ecx
        cmp       dword ptr [rbp-14],0
        je        short M01_L02
        nop
-       mov       rcx,15B80853020
+       mov       rcx,1460D802028
        mov       rcx,[rcx]
        mov       [rbp-20],rcx
        nop
        jmp       near ptr M01_L26
 M01_L02:
        mov       ecx,[rbp+18]
-       call      DotNetTips.Spargine.Extensions.NumericExtensions.IsNegative(Int32)
+       call      qword ptr [7FF9C6661288]; DotNetTips.Spargine.Extensions.NumericExtensions.IsNegative(Int32)
        mov       [rbp-40],eax
        mov       ecx,[rbp-40]
        movzx     ecx,cl
        mov       [rbp-24],ecx
        cmp       dword ptr [rbp-24],0
        je        short M01_L03
        nop
-       mov       rcx,15B80863640
+       mov       rcx,1460D8045C0
        mov       rcx,[rcx]
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
+       call      qword ptr [7FF9C64890C0]
        nop
        nop
 M01_L03:
        mov       ecx,[rbp+20]
-       call      DotNetTips.Spargine.Extensions.NumericExtensions.IsNegative(Int32)
+       call      qword ptr [7FF9C6661288]; DotNetTips.Spargine.Extensions.NumericExtensions.IsNegative(Int32)
        mov       [rbp-44],eax
        mov       ecx,[rbp-44]
        movzx     ecx,cl
        mov       [rbp-28],ecx
        cmp       dword ptr [rbp-28],0
        je        short M01_L04
        nop
-       mov       rcx,15B80863630
+       mov       rcx,1460D8045B8
        mov       rcx,[rcx]
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
+       call      qword ptr [7FF9C64890C0]
        nop
        nop
 M01_L04:
        mov       ecx,[rbp+18]
        mov       [rbp-48],ecx
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6101BA0]; System.String.get_Length()
        mov       [rbp-4C],eax
        mov       eax,[rbp-4C]
        sub       eax,[rbp+20]
        jno       short M01_L05
        call      CORINFO_HELP_OVERFLOW
 M01_L05:
        cmp       eax,[rbp-48]
        setle     al
        movzx     eax,al
        mov       [rbp-2C],eax
        cmp       dword ptr [rbp-2C],0
-       je        short M01_L06
+       je        near ptr M01_L06
        nop
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C62E98A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       [rbp-90],rax
-       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_StartIndexMustBeLessThanInputLength()
+       call      qword ptr [7FF9C67856D8]
        mov       [rbp-98],rax
-       mov       r9,15BA0852C70
+       mov       r9,1461B800C90
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,15B80863630
+       mov       r9,1460D8045B8
        mov       r9,[r9]
-       mov       r8,15B80863640
+       mov       r8,1460D8045C0
        mov       r8,[r8]
        mov       rcx,[rbp-90]
        mov       rdx,[rbp-98]
-       call      System.String.Format(System.IFormatProvider, System.String, System.Object, System.Object, System.Object)
+       call      qword ptr [7FF9C6101D98]
        mov       [rbp-0A0],rax
-       mov       rdx,15B80863640
+       mov       rdx,1460D8045C0
        mov       rdx,[rdx]
        mov       rcx,[rbp-0A0]
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
+       call      qword ptr [7FF9C64890D8]
        nop
        nop
 M01_L06:
+       xor       ecx,ecx
        cmp       dword ptr [rbp+20],0
        sete      cl
-       movzx     ecx,cl
        mov       [rbp-30],ecx
        cmp       dword ptr [rbp-30],0
        je        short M01_L07
        nop
-       mov       rcx,15B80853020
+       mov       rcx,1460D802028
        mov       rcx,[rcx]
        mov       [rbp-20],rcx
        nop
        jmp       near ptr M01_L26
        mov       [rbp+18],ecx
        nop
 M01_L12:
        mov       ecx,[rbp+18]
        cmp       ecx,[rbp-4]
        jg        short M01_L13
        mov       rcx,[rbp+10]
        mov       edx,[rbp+18]
        cmp       [rcx],ecx
-       call      System.String.get_Chars(Int32)
+       call      qword ptr [7FF9C6101B88]; System.String.get_Chars(Int32)
        mov       [rbp-84],eax
        mov       ecx,[rbp-84]
-       call      System.Char.IsWhiteSpace(Char)
+       call      qword ptr [7FF9C60133A8]; System.Char.IsWhiteSpace(Char)
        mov       [rbp-88],eax
        mov       ecx,[rbp-88]
        mov       [rbp-50],ecx
        jmp       short M01_L14
        mov       [rbp-4],ecx
        nop
 M01_L17:
        mov       ecx,[rbp-4]
        cmp       ecx,[rbp+18]
        jl        short M01_L18
        mov       rcx,[rbp+10]
        mov       edx,[rbp-4]
        cmp       [rcx],ecx
-       call      System.String.get_Chars(Int32)
+       call      qword ptr [7FF9C6101B88]; System.String.get_Chars(Int32)
        mov       [rbp-7C],eax
        mov       ecx,[rbp-7C]
-       call      System.Char.IsWhiteSpace(Char)
+       call      qword ptr [7FF9C60133A8]; System.Char.IsWhiteSpace(Char)
        mov       [rbp-80],eax
        mov       ecx,[rbp-80]
        mov       [rbp-54],ecx
        jmp       short M01_L19
        add       ecx,1
        jno       short M01_L21
        call      CORINFO_HELP_OVERFLOW
 M01_L21:
        mov       [rbp-8],ecx
        mov       ecx,[rbp-8]
        mov       [rbp-58],ecx
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.String.get_Length()
+       call      qword ptr [7FF9C6101BA0]; System.String.get_Length()
        mov       [rbp-5C],eax
        mov       ecx,[rbp-58]
        cmp       ecx,[rbp-5C]
        je        short M01_L22
        mov       rcx,[rbp+10]
        mov       edx,[rbp+18]
        mov       r8d,[rbp-8]
        cmp       [rcx],ecx
-       call      System.String.Substring(Int32, Int32)
+       call      qword ptr [7FF9C6103360]; System.String.Substring(Int32, Int32)
        mov       [rbp-78],rax
        mov       rax,[rbp-78]
        mov       [rbp-68],rax
        jmp       short M01_L23
        mov       rax,[rbp-68]
        mov       [rbp-10],rax
        cmp       dword ptr [rbp-8],0
        je        short M01_L24
        mov       rax,[rbp-10]
        mov       [rbp-70],rax
        jmp       short M01_L25
 M01_L24:
-       mov       rax,15B80853020
+       mov       rax,1460D802028
        mov       rax,[rax]
        mov       [rbp-70],rax
 M01_L25:
        mov       rax,[rbp-70]
        mov       [rbp-20],rax
        nop
-       jmp       short M01_L26
 M01_L26:
        mov       rax,[rbp-20]
        add       rsp,0D0
        pop       rbp
        ret
-; Total bytes of code 815
+; Total bytes of code 832
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
**Diff for ToDeflateStringAsync method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToDeflateStringAsync()
        sub       rsp,58
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        xor       eax,eax
        mov       [rsp+50],rax
        xor       eax,eax
        mov       [rsp+30],rax
        mov       [rsp+20],rcx
        mov       dword ptr [rsp+28],0FFFFFFFF
        lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__17 ByRef)
+       call      qword ptr [7FF9C67A53D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__17 ByRef)
        mov       rax,[rsp+30]
        test      rax,rax
        je        short M00_L01
        add       rsp,58
        ret
 M00_L01:
        lea       rcx,[rsp+30]
-       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
+       call      qword ptr [7FF9C673FED0]
        jmp       short M00_L00
-; Total bytes of code 90
+; Total bytes of code 92
 ; System.Threading.Tasks.Task.GetAwaiter()
        mov       rax,rcx
        ret
 ; Total bytes of code 4
 ; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
        mov       rcx,[rcx]
        mov       eax,[rcx+34]
        and       eax,11000000
        cmp       eax,1000000
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
-; Total bytes of code 24
+       jmp       qword ptr [7FF9C67A50C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
+; Total bytes of code 25
 ; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__17 ByRef)
        push      rbp
        push      rdi
        push      rsi
-       push      rbx
-       sub       rsp,48
-       lea       rbp,[rsp+60]
-       mov       [rbp-40],rsp
+       sub       rsp,40
+       lea       rbp,[rsp+50]
+       mov       [rbp-30],rsp
        mov       rsi,rcx
-       cmp       [rsi],esi
-       mov       rcx,7FF9C55C4938
-       mov       edx,2BD
+       cmp       [rsi],sil
+       mov       rcx,7FF9C5FF4C10
+       mov       edx,2D2
        call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
        mov       rax,[rax+18]
        test      rax,rax
        je        near ptr M03_L05
 M03_L00:
        mov       rdi,rax
-       mov       [rbp-20],rdi
+       mov       [rbp-18],rdi
        mov       rdx,[rax+8]
-       mov       [rbp-28],rdx
+       mov       [rbp-20],rdx
        mov       rcx,[rax+10]
-       mov       [rbp-30],rcx
+       mov       [rbp-28],rcx
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17.MoveNext()
+       call      qword ptr [7FF9C67A52A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17.MoveNext()
        nop
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-28]
        cmp       rcx,[rdi+10]
        je        short M03_L01
        lea       rcx,[rdi+10]
-       mov       rdx,[rbp-30]
+       mov       rdx,[rbp-28]
        call      CORINFO_HELP_ASSIGN_REF
 M03_L01:
-       mov       rbx,[rdi+8]
-       mov       rdx,[rbp-28]
-       cmp       rdx,rbx
+       mov       rsi,[rdi+8]
+       mov       rdx,[rbp-20]
+       cmp       rdx,rsi
        je        short M03_L04
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
-       test      rbx,rbx
+       test      rsi,rsi
        je        short M03_L02
-       cmp       qword ptr [rbx+10],0
+       cmp       qword ptr [rsi+10],0
        jne       short M03_L03
 M03_L02:
-       mov       rdx,[rbp-28]
+       mov       rdx,[rbp-20]
        test      rdx,rdx
        je        short M03_L04
        cmp       qword ptr [rdx+10],0
        je        short M03_L04
 M03_L03:
-       mov       rcx,rbx
-       mov       rdx,[rbp-28]
-       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
+       mov       rcx,rsi
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C673F9F0]
 M03_L04:
        nop
-       add       rsp,48
-       pop       rbx
+       add       rsp,40
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 M03_L05:
-       call      System.Threading.Thread.InitializeCurrentThread()
+       call      qword ptr [7FF9C6127210]; System.Threading.Thread.InitializeCurrentThread()
        jmp       near ptr M03_L00
        push      rbp
        push      rdi
        push      rsi
-       push      rbx
-       sub       rsp,28
+       sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
-       lea       rbp,[rbp+60]
-       mov       rdx,[rbp-30]
-       mov       rdi,[rbp-20]
+       lea       rbp,[rbp+50]
+       mov       rdx,[rbp-28]
+       mov       rdi,[rbp-18]
        cmp       rdx,[rdi+10]
        je        short M03_L06
        lea       rcx,[rdi+10]
        call      CORINFO_HELP_ASSIGN_REF
 M03_L06:
-       mov       rbx,[rdi+8]
-       mov       rdx,[rbp-28]
-       cmp       rdx,rbx
+       mov       rsi,[rdi+8]
+       mov       rdx,[rbp-20]
+       cmp       rdx,rsi
        je        short M03_L09
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
-       test      rbx,rbx
+       test      rsi,rsi
        je        short M03_L07
-       cmp       qword ptr [rbx+10],0
+       cmp       qword ptr [rsi+10],0
        jne       short M03_L08
 M03_L07:
-       cmp       qword ptr [rbp-28],0
+       cmp       qword ptr [rbp-20],0
        je        short M03_L09
-       mov       rdx,[rbp-28]
+       mov       rdx,[rbp-20]
        cmp       qword ptr [rdx+10],0
        je        short M03_L09
 M03_L08:
-       mov       rcx,rbx
-       mov       rdx,[rbp-28]
-       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
+       mov       rcx,rsi
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C673F9F0]
 M03_L09:
        nop
-       add       rsp,28
-       pop       rbx
+       add       rsp,30
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 311
 ; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
        push      rsi
        sub       rsp,20
        mov       rsi,rcx
-       mov       ecx,[rsi+34]
-       test      ecx,1600000
+       test      dword ptr [rsi+34],1600000
        jne       short M04_L00
        mov       rcx,rsi
        xor       r8d,r8d
        mov       edx,0FFFFFFFF
-       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
+       call      qword ptr [7FF9C6359AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
 M04_L00:
        mov       rcx,rsi
-       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
+       call      qword ptr [7FF9C6359270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
        mov       ecx,[rsi+34]
        and       ecx,1600000
        cmp       ecx,1000000
-       jne       short M04_L02
+       je        short M04_L01
+       mov       rcx,rsi
+       call      qword ptr [7FF9C67A50D8]
 M04_L01:
+       nop
        add       rsp,20
        pop       rsi
        ret
-M04_L02:
-       mov       rcx,rsi
-       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
-       jmp       short M04_L01
 ; Total bytes of code 76
-**Method was not JITted yet.**
-System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
```
**Diff for ToTitleCase method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTitleCase()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,2C792792C70
+       mov       rcx,2AF85C00C90
        mov       rcx,[rcx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
+       call      qword ptr [7FF9C6429CA8]; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67A53F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 71
+; Total bytes of code 73
 ; DotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-30],xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58563D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C664F768]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
        mov       [rbp-14],eax
        mov       eax,[rbp-14]
        movzx     eax,al
        mov       [rbp-4],eax
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        mov       rax,[rbp+10]
        mov       [rbp-10],rax
        nop
        jmp       short M01_L02
 M01_L01:
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FF9C63098A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       [rbp-20],rax
        mov       rcx,[rbp-20]
        mov       rax,[rbp-20]
        mov       rax,[rax]
        mov       rax,[rax+48]
        call      qword ptr [rax+38]
        mov       [rbp-28],rax
        mov       rcx,[rbp-28]
        mov       rdx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.Globalization.TextInfo.ToTitleCase(System.String)
+       call      qword ptr [7FF9C630F870]; System.Globalization.TextInfo.ToTitleCase(System.String)
        mov       [rbp-30],rax
        mov       rax,[rbp-30]
        mov       [rbp-10],rax
        nop
-       jmp       short M01_L02
 M01_L02:
        mov       rax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 158
+; Total bytes of code 159
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
**Diff for ToTrimmedString method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTrimmedString()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,rsi
        mov       rax,[rsi]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
+       call      qword ptr [7FF9C6429CC0]; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C67A5330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 74
+; Total bytes of code 76
 ; DotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-20],xmm4
        vmovdqa   xmmword ptr [rbp-10],xmm4
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C58763D8],0
+       cmp       dword ptr [7FF9C6436210],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C664F768]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
        mov       [rbp-14],eax
        mov       ecx,[rbp-14]
        movzx     ecx,cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        mov       rcx,[rbp+10]
        mov       [rbp-10],rcx
        nop
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
-       call      System.String.TrimEnd()
+       call      qword ptr [7FF9C61234C8]; System.String.TrimEnd()
        mov       [rbp-20],rax
        mov       rcx,[rbp-20]
        cmp       [rcx],ecx
-       call      System.String.TrimStart()
+       call      qword ptr [7FF9C6123480]; System.String.TrimStart()
        mov       [rbp-28],rax
        mov       rax,[rbp-28]
        mov       [rbp-10],rax
        nop
-       jmp       short M01_L02
 M01_L02:
        mov       rax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 139
+; Total bytes of code 140
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
**Diff for ToZLibStringAsync method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToZLibStringAsync()
        sub       rsp,58
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
        xor       eax,eax
        mov       [rsp+50],rax
        xor       eax,eax
        mov       [rsp+30],rax
        mov       [rsp+20],rcx
        mov       dword ptr [rsp+28],0FFFFFFFF
        lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__20 ByRef)
+       call      qword ptr [7FF9C67C53D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__20 ByRef)
        mov       rax,[rsp+30]
        test      rax,rax
        je        short M00_L01
        add       rsp,58
        ret
 M00_L01:
        lea       rcx,[rsp+30]
-       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
+       call      qword ptr [7FF9C675FED0]
        jmp       short M00_L00
-; Total bytes of code 90
+; Total bytes of code 92
 ; System.Threading.Tasks.Task.GetAwaiter()
        mov       rax,rcx
        ret
 ; Total bytes of code 4
 ; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
        mov       rcx,[rcx]
        mov       eax,[rcx+34]
        and       eax,11000000
        cmp       eax,1000000
        jne       short M02_L00
        ret
 M02_L00:
-       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
-; Total bytes of code 24
+       jmp       qword ptr [7FF9C67C50C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
+; Total bytes of code 25
 ; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__20 ByRef)
        push      rbp
        push      rdi
        push      rsi
-       push      rbx
-       sub       rsp,48
-       lea       rbp,[rsp+60]
-       mov       [rbp-40],rsp
+       sub       rsp,40
+       lea       rbp,[rsp+50]
+       mov       [rbp-30],rsp
        mov       rsi,rcx
-       cmp       [rsi],esi
-       mov       rcx,7FF9C55C4938
-       mov       edx,2BD
+       cmp       [rsi],sil
+       mov       rcx,7FF9C6014C10
+       mov       edx,2D2
        call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
        mov       rax,[rax+18]
        test      rax,rax
        je        near ptr M03_L05
 M03_L00:
        mov       rdi,rax
-       mov       [rbp-20],rdi
+       mov       [rbp-18],rdi
        mov       rdx,[rax+8]
-       mov       [rbp-28],rdx
+       mov       [rbp-20],rdx
        mov       rcx,[rax+10]
-       mov       [rbp-30],rcx
+       mov       [rbp-28],rcx
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20.MoveNext()
+       call      qword ptr [7FF9C67C52A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20.MoveNext()
        nop
-       mov       rcx,[rbp-30]
+       mov       rcx,[rbp-28]
        cmp       rcx,[rdi+10]
        je        short M03_L01
        lea       rcx,[rdi+10]
-       mov       rdx,[rbp-30]
+       mov       rdx,[rbp-28]
        call      CORINFO_HELP_ASSIGN_REF
 M03_L01:
-       mov       rbx,[rdi+8]
-       mov       rdx,[rbp-28]
-       cmp       rdx,rbx
+       mov       rsi,[rdi+8]
+       mov       rdx,[rbp-20]
+       cmp       rdx,rsi
        je        short M03_L04
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
-       test      rbx,rbx
+       test      rsi,rsi
        je        short M03_L02
-       cmp       qword ptr [rbx+10],0
+       cmp       qword ptr [rsi+10],0
        jne       short M03_L03
 M03_L02:
-       mov       rdx,[rbp-28]
+       mov       rdx,[rbp-20]
        test      rdx,rdx
        je        short M03_L04
        cmp       qword ptr [rdx+10],0
        je        short M03_L04
 M03_L03:
-       mov       rcx,rbx
-       mov       rdx,[rbp-28]
-       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
+       mov       rcx,rsi
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C675F9F0]
 M03_L04:
        nop
-       add       rsp,48
-       pop       rbx
+       add       rsp,40
        pop       rsi
        pop       rdi
        pop       rbp
        ret
 M03_L05:
-       call      System.Threading.Thread.InitializeCurrentThread()
+       call      qword ptr [7FF9C6147210]; System.Threading.Thread.InitializeCurrentThread()
        jmp       near ptr M03_L00
        push      rbp
        push      rdi
        push      rsi
-       push      rbx
-       sub       rsp,28
+       sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
-       lea       rbp,[rbp+60]
-       mov       rdx,[rbp-30]
-       mov       rdi,[rbp-20]
+       lea       rbp,[rbp+50]
+       mov       rdx,[rbp-28]
+       mov       rdi,[rbp-18]
        cmp       rdx,[rdi+10]
        je        short M03_L06
        lea       rcx,[rdi+10]
        call      CORINFO_HELP_ASSIGN_REF
 M03_L06:
-       mov       rbx,[rdi+8]
-       mov       rdx,[rbp-28]
-       cmp       rdx,rbx
+       mov       rsi,[rdi+8]
+       mov       rdx,[rbp-20]
+       cmp       rdx,rsi
        je        short M03_L09
        lea       rcx,[rdi+8]
        call      CORINFO_HELP_ASSIGN_REF
-       test      rbx,rbx
+       test      rsi,rsi
        je        short M03_L07
-       cmp       qword ptr [rbx+10],0
+       cmp       qword ptr [rsi+10],0
        jne       short M03_L08
 M03_L07:
-       cmp       qword ptr [rbp-28],0
+       cmp       qword ptr [rbp-20],0
        je        short M03_L09
-       mov       rdx,[rbp-28]
+       mov       rdx,[rbp-20]
        cmp       qword ptr [rdx+10],0
        je        short M03_L09
 M03_L08:
-       mov       rcx,rbx
-       mov       rdx,[rbp-28]
-       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
+       mov       rcx,rsi
+       mov       rdx,[rbp-20]
+       call      qword ptr [7FF9C675F9F0]
 M03_L09:
        nop
-       add       rsp,28
-       pop       rbx
+       add       rsp,30
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 310
+; Total bytes of code 311
 ; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
        push      rsi
        sub       rsp,20
        mov       rsi,rcx
-       mov       ecx,[rsi+34]
-       test      ecx,1600000
+       test      dword ptr [rsi+34],1600000
        jne       short M04_L00
        mov       rcx,rsi
        xor       r8d,r8d
        mov       edx,0FFFFFFFF
-       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
+       call      qword ptr [7FF9C6379AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
 M04_L00:
        mov       rcx,rsi
-       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
+       call      qword ptr [7FF9C6379270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
        mov       ecx,[rsi+34]
        and       ecx,1600000
        cmp       ecx,1000000
-       jne       short M04_L02
+       je        short M04_L01
+       mov       rcx,rsi
+       call      qword ptr [7FF9C67C50D8]
 M04_L01:
+       nop
        add       rsp,20
        pop       rsi
        ret
-M04_L02:
-       mov       rcx,rsi
-       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
-       jmp       short M04_L01
 ; Total bytes of code 76
-**Method was not JITted yet.**
-System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
```
