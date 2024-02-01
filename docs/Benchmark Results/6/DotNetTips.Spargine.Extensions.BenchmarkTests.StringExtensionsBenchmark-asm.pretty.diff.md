## DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark-20240131-213638
**Diff for DefaultIfNullWithDefaultValueFromNull method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       r8,[rcx+1C0]
        test      r8,r8
        jne       short M00_L00
-       mov       r8,2769A482C80
+       mov       r8,23808800CA8
        mov       r8,[r8]
 M00_L00:
        mov       [rsp+20],r8
        mov       rcx,[rcx+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBF5330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 73
+; Total bytes of code 74
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
-       mov       r8,2200BDA1C68
+       mov       r8,26C4C000CA8
        mov       r8,[r8]
        mov       [rsp+20],r8
        mov       rcx,[rcx+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBD3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 61
+; Total bytes of code 62
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValueFromNull()
+       push      rdi
        push      rsi
+       push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,[rsi+1C0]
-       mov       rdx,27C76861C68
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
-       mov       [rsp+28],rax
+       mov       rdi,[rsi+1C0]
+       mov       rax,2B38C000CA8
+       mov       rcx,[rax]
+       mov       eax,[rcx+8]
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M00_L00
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rdi,rax
+       mov       ecx,9F8
+       mov       rdx,7FFF8F85B520
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rsi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L00:
+       mov       edx,3
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rcx,rax
+       test      rdi,rdi
+       je        short M00_L01
+       cmp       dword ptr [rdi+8],0
+       je        short M00_L01
+       jmp       short M00_L02
+M00_L01:
+       mov       rdi,rcx
+M00_L02:
+       mov       [rsp+28],rdi
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBF5330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 78
-; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
-       push      rsi
-       sub       rsp,20
-       mov       rsi,rcx
-       test      rdx,rdx
-       je        short M01_L02
-       cmp       dword ptr [rdx+8],0
-       je        short M01_L02
-       xor       eax,eax
+; Total bytes of code 297
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
 M01_L00:
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
+       test      rcx,rcx
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
-       mov       ecx,9F8
-       mov       rdx,7FFF90FBBA68
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
+       jne       short M01_L03
+       jmp       short M01_L02
 M01_L01:
-       cmp       [rdx],edx
-       mov       rcx,rdx
-       mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       rdx,rax
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rdi,rax
        test      rsi,rsi
        je        short M01_L04
        cmp       dword ptr [rsi+8],0
        je        short M01_L04
-       jmp       short M01_L03
-M01_L02:
-       mov       eax,1
-       jmp       short M01_L00
-M01_L03:
-       mov       rax,rsi
-       add       rsp,20
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-M01_L04:
-       mov       rax,rdx
-       add       rsp,20
+M01_L07:
+       cmp       [rcx],cl
+       mov       edx,3
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FBFD0F0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FBFD0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FBFD0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-; Total bytes of code 129
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F603390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,2B37E002028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
+       push      rdi
        push      rsi
+       push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,29BC6802C80
+       mov       rax,22470800CB0
+       mov       rcx,[rax]
+       mov       eax,[rcx+8]
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M00_L00
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rsi,rax
+       mov       ecx,9F8
+       mov       rdx,7FFF8F82B520
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rdi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L00:
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rcx,22470800CA8
        mov       rcx,[rcx]
-       mov       rdx,29BC6802C88
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
-       mov       [rsp+28],rax
+       mov       [rsp+28],rcx
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBC3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 84
-; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
-       push      rsi
-       sub       rsp,20
-       mov       rsi,rcx
-       test      rdx,rdx
-       je        short M01_L02
-       cmp       dword ptr [rdx+8],0
-       je        short M01_L02
-       xor       eax,eax
+; Total bytes of code 284
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
 M01_L00:
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
+       test      rcx,rcx
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
-       mov       ecx,9F8
-       mov       rdx,7FFF90FABA68
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
+       jne       short M01_L03
+       jmp       short M01_L02
 M01_L01:
-       cmp       [rdx],edx
-       mov       rcx,rdx
-       mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       rdx,rax
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rdi,rax
        test      rsi,rsi
        je        short M01_L04
        cmp       dword ptr [rsi+8],0
        je        short M01_L04
-       jmp       short M01_L03
-M01_L02:
-       mov       eax,1
-       jmp       short M01_L00
-M01_L03:
-       mov       rax,rsi
-       add       rsp,20
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-M01_L04:
-       mov       rax,rdx
-       add       rsp,20
+M01_L07:
+       cmp       [rcx],cl
+       mov       edx,3
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FBCBAE0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FBCBAE0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FBCBAE0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-; Total bytes of code 129
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5D3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,22466802028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
+       push      rdi
        push      rsi
-       sub       rsp,30
+       sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       edx,64
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
-       mov       [rsp+28],al
+       mov       edi,64
+       test      rcx,rcx
+       je        short M00_L00
+       mov       edx,3
+       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       xor       ecx,ecx
+       cmp       [rax+8],edi
+       sete      cl
+       jmp       short M00_L01
+M00_L00:
+       xor       ecx,ecx
+M00_L01:
+       mov       [rsp+20],cl
        mov       rcx,[rsi+18]
-       lea       rdx,[rsp+28]
+       lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBD3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
-       add       rsp,30
+       add       rsp,28
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 49
-; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
+; Total bytes of code 75
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
        push      rsi
-       sub       rsp,20
-       mov       esi,edx
-       test      esi,esi
-       jle       short M01_L00
-       mov       eax,1
-       jmp       short M01_L01
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M01_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M01_L03
 M01_L00:
-       xor       eax,eax
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M01_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M01_L03
+       jmp       short M01_L02
 M01_L01:
+       call      qword ptr [7FFF8FBDBA68]
        test      eax,eax
-       jne       short M01_L02
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
-       mov       rsi,rax
-       mov       ecx,0A44
-       mov       rdx,7FFF90F7BA68
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
-       int       3
-M01_L02:
-       test      rcx,rcx
        je        short M01_L03
-       mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       cmp       [rax+8],esi
-       sete      al
-       movzx     eax,al
-       add       rsp,20
-       pop       rsi
-       ret
+M01_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M01_L00
 M01_L03:
-       xor       eax,eax
-       add       rsp,20
+       test      dil,2
+       je        near ptr M01_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M01_L10
+       test      r14d,r14d
+       jl        short M01_L07
+       test      r15d,r15d
+       jl        short M01_L07
+       cmp       ebx,r14d
+       jle       short M01_L07
+M01_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M01_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M01_L10
+       jmp       short M01_L06
+M01_L05:
+       call      qword ptr [7FFF8FBDBA68]
+       test      eax,eax
+       je        short M01_L10
+M01_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M01_L04
+       jmp       short M01_L10
+M01_L07:
+       cmp       r14d,ebx
+       jae       short M01_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M01_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M01_L10
+       jmp       short M01_L09
+M01_L08:
+       call      qword ptr [7FFF8FBDBA68]
+       test      eax,eax
+       je        short M01_L10
+M01_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M01_L07
+M01_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M01_L12
+       mov       rax,rsi
+M01_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
        pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-; Total bytes of code 102
+M01_L12:
+       test      r8d,r8d
+       je        short M01_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5E3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M01_L11
+M01_L13:
+       mov       rax,23A99002028
+       mov       rax,[rax]
+       jmp       short M01_L11
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for HasValueWithMinMaxCount method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+28]
        mov       edx,5
        mov       r8d,64
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
+       call      qword ptr [7FFF8F879930]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBE5318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 55
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
+       push      rdi
        push      rsi
-       sub       rsp,20
+       push      rbx
+       sub       rsp,30
        test      edx,edx
        jl        short M01_L00
+       xor       eax,eax
        cmp       edx,r8d
        setle     al
-       movzx     eax,al
        jmp       short M01_L01
 M01_L00:
        xor       eax,eax
 M01_L01:
        test      eax,eax
-       jne       short M01_L02
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
+       jne       near ptr M01_L03
+       call      qword ptr [7FFF8F8E7AF8]
        mov       rsi,rax
-       mov       ecx,0A52
-       mov       rdx,7FFF90FABA68
+       mov       rax,1D4C8410C10
+       mov       rcx,[rax]
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M01_L02
+       call      qword ptr [7FFF8F8E7C30]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
        call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
-       int       3
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
 M01_L02:
-       cmp       r8d,edx
-       jl        short M01_L03
-       cmp       r8d,7FFFFFFF
-       setle     al
-       movzx     eax,al
-       jmp       short M01_L04
+       mov       edx,3
+       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7828]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F785750]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
 M01_L03:
-       xor       eax,eax
+       cmp       r8d,edx
+       jl        short M01_L04
+       mov       eax,1
+       jmp       short M01_L05
 M01_L04:
+       xor       eax,eax
+M01_L05:
+       test      eax,eax
+       jne       near ptr M01_L07
+       call      qword ptr [7FFF8F8E7AF8]
+       mov       rdi,rax
+       mov       rax,1D4C8410C18
+       mov       rcx,[rax]
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
        test      eax,eax
-       jne       short M01_L05
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8E7C30]
        mov       rsi,rax
-       mov       ecx,0A66
-       mov       rdx,7FFF90FABA68
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
        call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
-       int       3
-M01_L05:
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       mov       edx,3
+       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7828]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F785750]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L07:
        test      rcx,rcx
-       je        short M01_L08
+       je        short M01_L10
        mov       eax,[rcx+8]
        cmp       eax,edx
-       jl        short M01_L06
+       jl        short M01_L08
        cmp       eax,r8d
        setle     al
        movzx     eax,al
-       jmp       short M01_L07
-M01_L06:
+       jmp       short M01_L09
+M01_L08:
        xor       eax,eax
-M01_L07:
-       add       rsp,20
+M01_L09:
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-M01_L08:
+M01_L10:
        xor       eax,eax
-       add       rsp,20
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 171
+; Total bytes of code 614
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for HasValueWithRegEx method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,48
        mov       rsi,rcx
-       mov       rcx,26372F52C80
+       mov       rcx,17CEB000CA8
        mov       rdi,[rcx]
        mov       rcx,rdi
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        cmp       dword ptr [rax+8],0
-       setg      cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       je        near ptr M00_L01
-       mov       rcx,26372F52C88
+       jle       short M00_L01
+       mov       rcx,17CEB000CB0
        mov       rbx,[rcx]
        mov       rcx,rbx
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        cmp       dword ptr [rax+8],0
-       setg      cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       je        short M00_L01
+       jle       short M00_L01
        mov       rcx,offset MT_System.Text.RegularExpressions.Regex
        call      CORINFO_HELP_NEWSFAST
        mov       rbp,rax
        mov       rdx,rbx
        mov       rcx,rbp
        mov       r8d,1
-       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
+       call      qword ptr [7FFF8FAD9618]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
        mov       rcx,rbp
        mov       r9,rdi
-       test      byte ptr [rcx+48],40
+       test      byte ptr [rcx+40],40
        jne       short M00_L03
        xor       edi,edi
 M00_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       dword ptr [rsp+28],11
        mov       [rsp+30],edi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAD98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
+       xor       ecx,ecx
        test      rax,rax
        sete      cl
-       movzx     ecx,cl
        jmp       short M00_L02
 M00_L01:
        xor       ecx,ecx
 M00_L02:
        mov       [rsp+40],cl
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+40]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC15708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L03:
        mov       edi,11
        jmp       short M00_L00
-; Total bytes of code 228
+; Total bytes of code 207
 ; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        push      r15
        push      r14
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
+       sub       rsp,28
        mov       rsi,rcx
        mov       edi,edx
        mov       ebx,[rsi+8]
        lea       ebp,[rbx-1]
        mov       r14d,ebp
        xor       r15d,r15d
        test      dil,1
        je        short M01_L03
        xor       r15d,r15d
        test      ebx,ebx
        jle       short M01_L03
 M01_L00:
-       movsxd    rcx,r15d
+       mov       ecx,r15d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
        jae       short M01_L01
-       cmp       ecx,100
-       jae       near ptr M01_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     r12b
-       movzx     r12d,r12b
-       test      r12d,r12d
        je        short M01_L03
        jmp       short M01_L02
 M01_L01:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     r12d,al
-       test      r12d,r12d
+       call      qword ptr [7FFF8FC1DA50]
+       test      eax,eax
        je        short M01_L03
 M01_L02:
        inc       r15d
        inc       r15d
        cmp       ebx,r15d
        jg        short M01_L00
 M01_L03:
        test      dil,2
-       je        short M01_L07
+       je        near ptr M01_L10
        mov       r14d,ebp
        cmp       r14d,r15d
+       jl        near ptr M01_L10
+       test      r14d,r14d
+       jl        short M01_L07
+       test      r15d,r15d
        jl        short M01_L07
+       cmp       ebx,r14d
+       jle       short M01_L07
 M01_L04:
-       cmp       r14d,ebx
-       jae       near ptr M01_L11
-       movsxd    rcx,r14d
+       mov       ecx,r14d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
        jae       short M01_L05
-       cmp       ecx,100
-       jae       near ptr M01_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     dil
-       movzx     edi,dil
-       test      edi,edi
-       je        short M01_L07
+       je        short M01_L10
        jmp       short M01_L06
 M01_L05:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     edi,al
-       test      edi,edi
-       je        short M01_L07
+       call      qword ptr [7FFF8FC1DA50]
+       test      eax,eax
+       je        short M01_L10
 M01_L06:
        dec       r14d
        cmp       r14d,r15d
        jge       short M01_L04
+       jmp       short M01_L10
 M01_L07:
-       sub       r14d,r15d
-       lea       ecx,[r14+1]
-       cmp       ebx,ecx
-       jne       short M01_L09
-       mov       rax,rsi
+       cmp       r14d,ebx
+       jae       short M01_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M01_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M01_L10
+       jmp       short M01_L09
 M01_L08:
-       add       rsp,20
+       call      qword ptr [7FFF8FC1DA50]
+       test      eax,eax
+       je        short M01_L10
+M01_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M01_L07
+M01_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M01_L12
+       mov       rax,rsi
+M01_L11:
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r14
        pop       r15
        ret
-M01_L09:
-       test      ecx,ecx
-       je        short M01_L10
-       call      System.String.FastAllocateString(Int32)
-       mov       rbx,rax
-       mov       r8d,[rbx+8]
-       lea       rcx,[rbx+0C]
-       lea       rdx,[rsi+0C]
-       mov       eax,r15d
-       lea       rdx,[rdx+rax*2]
-       add       r8,r8
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
-       mov       rax,rbx
-       jmp       short M01_L08
-M01_L10:
-       mov       rax,26352F53020
+M01_L12:
+       test      r8d,r8d
+       je        short M01_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F603390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M01_L11
+M01_L13:
+       mov       rax,17CE9002028
        mov       rax,[rax]
-       jmp       short M01_L08
-M01_L11:
+       jmp       short M01_L11
+M01_L14:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 323
+; Total bytes of code 318
 ; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
        sub       rsp,28
        xor       r9d,r9d
        mov       [rsp+20],r9
-       mov       r9,26352F59E30
+       mov       r9,17CED0008D0
        mov       r9,[r9]
        mov       r9,[r9+8]
-       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
+       call      qword ptr [7FFF8FAD9660]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
        nop
        add       rsp,28
        ret
-; Total bytes of code 40
-; System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+; Total bytes of code 41
+; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,68
-       lea       rbp,[rsp+0A0]
+       sub       rsp,48
+       lea       rbp,[rsp+80]
+       xor       eax,eax
+       mov       [rbp-48],rax
        mov       [rbp-58],rsp
        mov       [rbp+10],rcx
        mov       edi,edx
        mov       ebx,r8d
        mov       rsi,r9
        mov       r14d,[rbp+30]
        mov       r15d,[rbp+38]
        mov       r12d,[rbp+40]
-       mov       edx,[rsi+8]
-       cmp       edx,r12d
-       jb        near ptr M03_L06
-       cmp       edx,r15d
-       jb        near ptr M03_L07
-       cmp       [rcx],ecx
-       lea       rdx,[rcx+38]
-       mov       rcx,rdx
+       mov       r13d,[rsi+8]
+       cmp       r13d,r12d
+       jb        near ptr M03_L16
+       cmp       r13d,r15d
+       jb        near ptr M03_L17
+       cmp       [rcx],cl
+       add       rcx,38
        xor       edx,edx
        call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
        test      rax,rax
-       je        short M03_L02
+       je        near ptr M03_L13
 M03_L00:
        mov       rdx,rax
-M03_L01:
-       mov       [rbp-40],rdx
-       add       r15d,r14d
-       mov       [rsp+20],r15d
-       mov       [rsp+28],r12d
-       mov       [rsp+30],ebx
-       movzx     ecx,dil
-       mov       [rsp+38],ecx
+       mov       [rbp-50],rdx
        mov       rcx,[rbp+10]
-       mov       r8,[rcx+58]
-       mov       [rsp+40],r8
-       mov       rcx,rdx
-       mov       rdx,[rbp+10]
-       mov       r8,rsi
-       mov       r9d,r14d
+       mov       rdx,[rcx+48]
+       mov       rcx,[rbp-50]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.RegexRunner.Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean, System.TimeSpan)
-       mov       rsi,rax
-       mov       rdx,[rbp+10]
-       lea       rcx,[rdx+38]
-       mov       rdx,[rbp-40]
+       call      qword ptr [7FFF8FC13CC0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
+       mov       rcx,[rbp-50]
+       lea       rcx,[rcx+8]
+       mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rax,rsi
-       add       rsp,68
+       mov       ecx,r14d
+       mov       edx,r15d
+       add       rcx,rdx
+       mov       edx,r13d
+       cmp       rcx,rdx
+       ja        near ptr M03_L10
+       mov       ecx,r14d
+       lea       r13,[rsi+rcx*2+0C]
+       mov       rcx,[rbp-50]
+       mov       rdx,rcx
+       mov       rax,[rbp+10]
+       mov       r8,rax
+       mov       [rbp-48],r13
+       mov       [rbp-40],r15d
+       mov       [rsp+20],edi
+       mov       rcx,rdx
+       mov       rdx,r8
+       lea       r8,[rbp-48]
+       mov       r9d,r12d
+       sub       r9d,r14d
+       call      qword ptr [7FFF8FC13CA8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
+       test      ebx,ebx
+       je        near ptr M03_L08
+M03_L01:
+       mov       rcx,offset MT_System.Text.RegularExpressions.CompiledRegexRunner
+       mov       rbx,[rbp-50]
+       cmp       [rbx],rcx
+       jne       near ptr M03_L06
+       mov       rax,[rbx+70]
+       mov       rdx,rbx
+       mov       [rbp-48],r13
+       mov       [rbp-40],r15d
+       mov       rcx,[rax+8]
+       lea       r8,[rbp-48]
+       call      qword ptr [rax+18]
+M03_L02:
+       mov       r15,[rbx+28]
+       mov       rdx,[r15+50]
+       cmp       dword ptr [rdx+8],0
+       jbe       short M03_L03
+       cmp       dword ptr [rdx+10],0
+       jg        short M03_L04
+       xor       ecx,ecx
+       mov       [r15+8],rcx
+       mov       rcx,7FFF8FAE4068
+       mov       edx,27
+       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
+       mov       rdx,17CED0008C0
+       mov       r15,[rdx]
+       jmp       short M03_L05
+M03_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+M03_L04:
+       test      edi,edi
+       je        short M03_L07
+       lea       rcx,[r15+8]
+       mov       rdx,rsi
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       edx,edx
+       mov       [rbx+28],rdx
+       mov       edx,[rbx+4C]
+       mov       rcx,r15
+       mov       r8d,r14d
+       mov       r9d,edi
+       call      qword ptr [7FFF8FC15648]
+M03_L05:
+       jmp       near ptr M03_L12
+M03_L06:
+       mov       rcx,rbx
+       mov       [rbp-48],r13
+       mov       [rbp-40],r15d
+       lea       rdx,[rbp-48]
+       mov       rax,[rcx]
+       mov       rax,[rax+40]
+       call      qword ptr [rax+20]
+       jmp       near ptr M03_L02
+M03_L07:
+       xor       ecx,ecx
+       mov       [r15+8],rcx
+       xor       r15d,r15d
+       jmp       short M03_L05
+M03_L08:
+       mov       ecx,r15d
+       mov       eax,1
+       mov       r8,[rbp+10]
+       test      byte ptr [r8+40],40
+       je        short M03_L09
+       xor       ecx,ecx
+       mov       eax,0FFFFFFFF
+M03_L09:
+       mov       rbx,[rbp-50]
+       cmp       [rbx+48],ecx
+       jne       short M03_L11
+       mov       rcx,7FFF8FAE4068
+       mov       edx,27
+       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
+       mov       rdx,17CED0008C0
+       mov       r15,[rdx]
+       jmp       short M03_L12
+M03_L10:
+       mov       ecx,21
+       call      qword ptr [7FFF8F7C77E0]
+       int       3
+M03_L11:
+       add       [rbx+4C],eax
+       jmp       near ptr M03_L01
+M03_L12:
+       xor       edx,edx
+       mov       [rbx+8],rdx
+       mov       rax,[rbp+10]
+       lea       rcx,[rax+38]
+       mov       rdx,rbx
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rax,r15
+       add       rsp,48
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-M03_L02:
-       mov       rdx,[rbp+10]
-       mov       rcx,[rdx+10]
-       test      rcx,rcx
-       jne       short M03_L04
-       mov       r13,[rdx+40]
-       test      dword ptr [rdx+48],200
-       jne       short M03_L05
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
-       mov       [rbp-48],rax
-M03_L03:
-       mov       rcx,offset MT_System.Text.RegularExpressions.RegexInterpreter
-       call      CORINFO_HELP_NEWSFAST
-       mov       rdx,rax
-       mov       [rbp-50],rdx
-       mov       rcx,rdx
-       mov       rdx,r13
-       mov       r8,[rbp-48]
-       call      System.Text.RegularExpressions.RegexInterpreter..ctor(System.Text.RegularExpressions.RegexCode, System.Globalization.CultureInfo)
-       mov       r13,[rbp-50]
-       mov       rdx,r13
-       jmp       near ptr M03_L01
-M03_L04:
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
+M03_L13:
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+10]
+       mov       rdx,[rax]
+       mov       r8,offset MT_System.Text.RegularExpressions.RegexInterpreterFactory
+       cmp       rdx,r8
+       jne       short M03_L14
+       mov       rcx,rax
+       call      qword ptr [7FFF8FBDB070]; System.Text.RegularExpressions.RegexInterpreterFactory.CreateInstance()
+       jmp       short M03_L15
+M03_L14:
+       mov       rcx,rax
+       mov       rax,[rdx+40]
        call      qword ptr [rax+20]
+M03_L15:
        jmp       near ptr M03_L00
-M03_L05:
-       mov       rcx,26352F51568
-       mov       r8,[rcx]
-       mov       rcx,r8
-       mov       [rbp-48],rcx
-       jmp       short M03_L03
-M03_L06:
-       mov       ecx,0F
+M03_L16:
+       mov       ecx,0E
        xor       edx,edx
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
+       call      qword ptr [7FFF8FC757B0]
        int       3
-M03_L07:
+M03_L17:
        mov       ecx,8
        mov       edx,2
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
+       call      qword ptr [7FFF8FC757B0]
        int       3
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,58
-       mov       rbp,[rcx+48]
-       mov       [rsp+48],rbp
-       lea       rbp,[rbp+0A0]
-       mov       rdx,[rbp+10]
-       lea       rcx,[rdx+38]
-       mov       rdx,[rbp-40]
+       sub       rsp,38
+       mov       rbp,[rcx+28]
+       mov       [rsp+28],rbp
+       lea       rbp,[rbp+80]
+       xor       edx,edx
+       mov       rbx,[rbp-50]
+       mov       [rbx+8],rdx
+       mov       r8,[rbp+10]
+       lea       rcx,[r8+38]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        nop
-       add       rsp,58
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 416
+; Total bytes of code 722
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for HasValueWithString method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithString()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rdi,[rsi+28]
        test      rdi,rdi
-       je        short M00_L00
+       je        short M00_L02
        mov       rcx,rdi
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        cmp       dword ptr [rax+8],0
-       setg      dl
-       movzx     edx,dl
-       test      edx,edx
-       je        short M00_L00
-       mov       rdx,276BB302C80
-       mov       rdx,[rdx]
-       mov       rcx,rdi
-       mov       r8d,4
-       call      System.String.Equals(System.String, System.String, System.StringComparison)
+       jle       short M00_L02
+       cmp       dword ptr [rdi+8],1
+       jne       short M00_L00
+       xor       ecx,ecx
+       cmp       word ptr [rdi+0C],41
+       sete      cl
        jmp       short M00_L01
 M00_L00:
-       xor       eax,eax
+       xor       ecx,ecx
 M00_L01:
-       mov       [rsp+20],al
+       movzx     ecx,cl
+       jmp       short M00_L03
+M00_L02:
+       xor       ecx,ecx
+M00_L03:
+       mov       [rsp+20],cl
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBC3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 104
+; Total bytes of code 94
 ; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        push      r15
        push      r14
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
+       sub       rsp,28
        mov       rsi,rcx
        mov       edi,edx
        mov       ebx,[rsi+8]
        lea       ebp,[rbx-1]
        mov       r14d,ebp
        xor       r15d,r15d
        test      dil,1
        je        short M01_L03
        xor       r15d,r15d
        test      ebx,ebx
        jle       short M01_L03
 M01_L00:
-       movsxd    rcx,r15d
+       mov       ecx,r15d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
        jae       short M01_L01
-       cmp       ecx,100
-       jae       near ptr M01_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     r12b
-       movzx     r12d,r12b
-       test      r12d,r12d
        je        short M01_L03
        jmp       short M01_L02
 M01_L01:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     r12d,al
-       test      r12d,r12d
+       call      qword ptr [7FFF8FBCBA68]
+       test      eax,eax
        je        short M01_L03
 M01_L02:
        inc       r15d
        inc       r15d
        cmp       ebx,r15d
        jg        short M01_L00
 M01_L03:
        test      dil,2
-       je        short M01_L07
+       je        near ptr M01_L10
        mov       r14d,ebp
        cmp       r14d,r15d
+       jl        near ptr M01_L10
+       test      r14d,r14d
+       jl        short M01_L07
+       test      r15d,r15d
        jl        short M01_L07
+       cmp       ebx,r14d
+       jle       short M01_L07
 M01_L04:
-       cmp       r14d,ebx
-       jae       near ptr M01_L11
-       movsxd    rcx,r14d
+       mov       ecx,r14d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
        jae       short M01_L05
-       cmp       ecx,100
-       jae       near ptr M01_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     dil
-       movzx     edi,dil
-       test      edi,edi
-       je        short M01_L07
+       je        short M01_L10
        jmp       short M01_L06
 M01_L05:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     edi,al
-       test      edi,edi
-       je        short M01_L07
+       call      qword ptr [7FFF8FBCBA68]
+       test      eax,eax
+       je        short M01_L10
 M01_L06:
        dec       r14d
        cmp       r14d,r15d
        jge       short M01_L04
+       jmp       short M01_L10
 M01_L07:
-       sub       r14d,r15d
-       lea       ecx,[r14+1]
-       cmp       ebx,ecx
-       jne       short M01_L09
-       mov       rax,rsi
+       cmp       r14d,ebx
+       jae       short M01_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M01_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M01_L10
+       jmp       short M01_L09
 M01_L08:
-       add       rsp,20
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       pop       r12
-       pop       r14
-       pop       r15
-       ret
-M01_L09:
-       test      ecx,ecx
+       call      qword ptr [7FFF8FBCBA68]
+       test      eax,eax
        je        short M01_L10
-       call      System.String.FastAllocateString(Int32)
-       mov       rbx,rax
-       mov       r8d,[rbx+8]
-       lea       rcx,[rbx+0C]
-       lea       rdx,[rsi+0C]
-       mov       eax,r15d
-       lea       rdx,[rdx+rax*2]
-       add       r8,r8
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
-       mov       rax,rbx
-       jmp       short M01_L08
+M01_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M01_L07
 M01_L10:
-       mov       rax,2769B303020
-       mov       rax,[rax]
-       jmp       short M01_L08
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M01_L12
+       mov       rax,rsi
 M01_L11:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
-; Total bytes of code 323
-; System.String.Equals(System.String, System.String, System.StringComparison)
-       push      rdi
-       push      rsi
-       push      rbp
-       push      rbx
-       sub       rsp,28
-       mov       rsi,rcx
-       mov       rdi,rdx
-       mov       ebx,r8d
-M02_L00:
-       cmp       rsi,rdi
-       je        short M02_L02
-       test      rsi,rsi
-       je        near ptr M02_L05
-       test      rdi,rdi
-       je        near ptr M02_L05
-       cmp       ebx,5
-       jne       short M02_L04
-       mov       eax,[rsi+8]
-       cmp       eax,[rdi+8]
-       je        short M02_L03
-M02_L01:
-       xor       eax,eax
-       add       rsp,28
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       ret
-M02_L02:
-       cmp       ebx,5
-       ja        near ptr M02_L08
-       mov       eax,1
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r14
+       pop       r15
        ret
-M02_L03:
+M01_L12:
+       test      r8d,r8d
+       je        short M01_L13
        mov       rcx,rsi
-       mov       rdx,rdi
-       add       rsp,28
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
-M02_L04:
-       cmp       ebx,5
-       ja        short M02_L07
-       mov       r8d,ebx
-       lea       rcx,[7FFF9122F600]
-       mov       ecx,[rcx+r8*4]
-       lea       rdx,[M02_L00]
-       add       rcx,rdx
-       jmp       rcx
-       mov       r8d,[rsi+8]
-       cmp       r8d,[rdi+8]
-       jne       short M02_L01
-       lea       rcx,[rsi+0C]
-       lea       rdx,[rdi+0C]
-       mov       r8d,[rsi+8]
-       add       r8d,r8d
-       add       rsp,28
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
-M02_L05:
-       cmp       ebx,5
-       ja        short M02_L08
-       jmp       near ptr M02_L01
-M02_L06:
-       movzx     eax,bpl
-       add       rsp,28
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       ret
-M02_L07:
-       mov       rcx,offset MT_System.ArgumentException
-       call      CORINFO_HELP_NEWSFAST
-       mov       rbx,rax
-       mov       ecx,0F32B
-       mov       rdx,7FFF90C84000
-       call      CORINFO_HELP_STRCNS
-       mov       rcx,rax
-       call      System.SR.GetResourceString(System.String)
-       mov       rsi,rax
-       mov       ecx,196A
-       mov       rdx,7FFF90C84000
-       call      CORINFO_HELP_STRCNS
-       mov       r8,rax
-       mov       rdx,rsi
-       mov       rcx,rbx
-       call      System.ArgumentException..ctor(System.String, System.String)
-       mov       rcx,rbx
-       call      CORINFO_HELP_THROW
-M02_L08:
-       mov       ecx,18
-       mov       edx,2A
-       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
-       int       3
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
-       mov       rcx,rax
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5D3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M01_L11
+M01_L13:
+       mov       rax,214EB402028
        mov       rax,[rax]
-       mov       rax,[rax+48]
-       call      qword ptr [rax+30]
-       mov       rcx,rax
-       mov       r9d,ebx
-       and       r9d,1
-       mov       rdx,rsi
-       mov       r8,rdi
-       cmp       [rcx],ecx
-       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
-       test      eax,eax
-       sete      bpl
-       movzx     ebp,bpl
-       jmp       near ptr M02_L06
-       mov       rcx,7FFF90D94938
-       mov       edx,227
-       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       r9,2769B301520
-       mov       rcx,[r9]
-       mov       r9d,ebx
-       and       r9d,1
-       mov       rdx,rsi
-       mov       r8,rdi
-       cmp       [rcx],ecx
-       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
-       test      eax,eax
-       sete      bpl
-       movzx     ebp,bpl
-       jmp       near ptr M02_L06
-; Total bytes of code 429
+       jmp       short M01_L11
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ToByteArray_ASCII method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
+       push      rdi
        push      rsi
+       push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,[rsi+28]
-       mov       rdx,26523371AD0
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       mov       rdx,[rsi+28]
+       mov       rax,1DC20800AD8
+       mov       rdi,[rax]
+       test      rdx,rdx
+       je        short M00_L00
+       mov       eax,[rdx+8]
+       xor       ecx,ecx
+       test      eax,eax
+       sete      cl
+       test      ecx,ecx
+       sete      cl
+       movzx     ecx,cl
+       test      eax,eax
+       jne       short M00_L01
+       jmp       short M00_L01
+M00_L00:
+       xor       ecx,ecx
+M00_L01:
+       test      ecx,ecx
+       jne       near ptr M00_L02
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rdi,rax
+       mov       ecx,301
+       mov       rdx,7FFF8F82B520
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rsi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L02:
+       cmp       [rdx],dl
+       mov       rcx,rdx
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F5C27C0]; System.Text.Encoding.GetBytes(System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBC5030]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 75
-; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+; Total bytes of code 304
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M01_L00:
+       push      rdi
        push      rsi
-       sub       rsp,20
-       mov       rsi,rdx
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
        test      rcx,rcx
-       je        short M01_L02
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L02
-       xor       eax,eax
-M01_L00:
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
-       mov       ecx,301
-       mov       rdx,7FFF90FABA68
+       jne       short M01_L03
+       jmp       short M01_L02
+M01_L01:
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M01_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M01_L04
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
        call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M01_L07:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       rcx,rax
-       mov       [rsp+30],rcx
-       test      rsi,rsi
-       jne       short M01_L03
-       xor       eax,eax
-       add       rsp,20
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FC01CF0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FC01CF0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FC01CF0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
        pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-M01_L02:
-       mov       eax,1
-       jmp       short M01_L00
-M01_L03:
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
        mov       rcx,rsi
-       mov       rdx,[rsp+30]
-       mov       rax,[rsi]
-       mov       rax,[rax+58]
-       mov       rax,[rax+10]
-       add       rsp,20
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5D3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,1DC20802028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; System.Text.Encoding.GetBytes(System.String)
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,38
+       mov       rdi,rcx
+       mov       rsi,rdx
+       test      rsi,rsi
+       je        short M03_L00
+       mov       rcx,rdi
+       mov       rdx,rsi
+       mov       rbx,[rdi]
+       mov       rax,[rbx+50]
+       call      qword ptr [rax+18]
+       movsxd    rdx,eax
+       mov       rcx,offset MT_System.Byte[]
+       call      CORINFO_HELP_NEWARR_1_VC
+       mov       rbp,rax
+       mov       [rsp+20],rbp
+       xor       r9d,r9d
+       mov       [rsp+28],r9d
+       mov       r9d,[rsi+8]
+       mov       rcx,rdi
+       mov       rdx,rsi
+       xor       r8d,r8d
+       mov       rax,[rbx+58]
+       call      qword ptr [rax+18]
+       mov       rax,rbp
+       add       rsp,38
+       pop       rbx
+       pop       rbp
        pop       rsi
-       jmp       rax
-; Total bytes of code 140
+       pop       rdi
+       ret
+M03_L00:
+       mov       ecx,1C81
+       mov       rdx,7FFF8F384000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F79D960]
+       int       3
+; Total bytes of code 131
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
+       push      rdi
        push      rsi
+       push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,[rsi+28]
-       mov       rdx,27C38441B80
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       mov       rdx,[rsi+28]
+       mov       rax,1BB29800B88
+       mov       rdi,[rax]
+       test      rdx,rdx
+       je        short M00_L00
+       mov       eax,[rdx+8]
+       xor       ecx,ecx
+       test      eax,eax
+       sete      cl
+       test      ecx,ecx
+       sete      cl
+       movzx     ecx,cl
+       test      eax,eax
+       jne       short M00_L01
+       jmp       short M00_L01
+M00_L00:
+       xor       ecx,ecx
+M00_L01:
+       test      ecx,ecx
+       jne       near ptr M00_L02
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rdi,rax
+       mov       ecx,301
+       mov       rdx,7FFF8F85B520
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rsi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L02:
+       cmp       [rdx],dl
+       mov       rcx,rdx
+       mov       edx,3
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F5F27C0]; System.Text.Encoding.GetBytes(System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBF3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 75
-; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+; Total bytes of code 304
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M01_L00:
+       push      rdi
        push      rsi
-       sub       rsp,20
-       mov       rsi,rdx
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
        test      rcx,rcx
-       je        short M01_L02
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L02
-       xor       eax,eax
-M01_L00:
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
-       mov       ecx,301
-       mov       rdx,7FFF90FABA68
+       jne       short M01_L03
+       jmp       short M01_L02
+M01_L01:
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M01_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M01_L04
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
        call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M01_L07:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       rcx,rax
-       mov       [rsp+30],rcx
-       test      rsi,rsi
-       jne       short M01_L03
-       xor       eax,eax
-       add       rsp,20
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FBFD0F0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FBFD0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FBFD0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
        pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-M01_L02:
-       mov       eax,1
-       jmp       short M01_L00
-M01_L03:
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
        mov       rcx,rsi
-       mov       rdx,[rsp+30]
-       mov       rax,[rsi]
-       mov       rax,[rax+58]
-       mov       rax,[rax+10]
-       add       rsp,20
+       mov       edx,r15d
+       call      qword ptr [7FFF8F603390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,1BB25800030
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; System.Text.Encoding.GetBytes(System.String)
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,38
+       mov       rdi,rcx
+       mov       rsi,rdx
+       test      rsi,rsi
+       je        short M03_L00
+       mov       rcx,rdi
+       mov       rdx,rsi
+       mov       rbx,[rdi]
+       mov       rax,[rbx+50]
+       call      qword ptr [rax+18]
+       movsxd    rdx,eax
+       mov       rcx,offset MT_System.Byte[]
+       call      CORINFO_HELP_NEWARR_1_VC
+       mov       rbp,rax
+       mov       [rsp+20],rbp
+       xor       r9d,r9d
+       mov       [rsp+28],r9d
+       mov       r9d,[rsi+8]
+       mov       rcx,rdi
+       mov       rdx,rsi
+       xor       r8d,r8d
+       mov       rax,[rbx+58]
+       call      qword ptr [rax+18]
+       mov       rax,rbp
+       add       rsp,38
+       pop       rbx
+       pop       rbp
        pop       rsi
-       jmp       rax
-; Total bytes of code 140
+       pop       rdi
+       ret
+M03_L00:
+       mov       ecx,1C81
+       mov       rdx,7FFF8F3B4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F7CD960]
+       int       3
+; Total bytes of code 131
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
+       push      rdi
        push      rsi
+       push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,[rsi+28]
-       mov       rdx,2C514251B08
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       mov       rdx,[rsi+28]
+       mov       rax,1E1D8C00B10
+       mov       rdi,[rax]
+       test      rdx,rdx
+       je        short M00_L00
+       mov       eax,[rdx+8]
+       xor       ecx,ecx
+       test      eax,eax
+       sete      cl
+       test      ecx,ecx
+       sete      cl
+       movzx     ecx,cl
+       test      eax,eax
+       jne       short M00_L01
+       jmp       short M00_L01
+M00_L00:
+       xor       ecx,ecx
+M00_L01:
+       test      ecx,ecx
+       jne       near ptr M00_L02
+       call      qword ptr [7FFF8F8E7C30]
+       mov       rdi,rax
+       mov       ecx,301
+       mov       rdx,7FFF8F84B520
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rsi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L02:
+       cmp       [rdx],dl
+       mov       rcx,rdx
+       mov       edx,3
+       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdx,rax
+       test      rdx,rdx
+       je        short M00_L04
+       cmp       dword ptr [rdx+8],20
+       jg        short M00_L04
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F7EBB88]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
+M00_L03:
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBE5330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 75
-; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+M00_L04:
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F5E27C0]; System.Text.Encoding.GetBytes(System.String)
+       jmp       short M00_L03
+; Total bytes of code 326
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M01_L00:
+       push      rdi
        push      rsi
-       sub       rsp,20
-       mov       rsi,rdx
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
        test      rcx,rcx
-       je        short M01_L02
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L02
-       xor       eax,eax
-M01_L00:
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
-       mov       ecx,301
-       mov       rdx,7FFF90FBBA68
+       jne       short M01_L03
+       jmp       short M01_L02
+M01_L01:
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8E7C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M01_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M01_L04
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
        call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M01_L07:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       rcx,rax
-       mov       [rsp+30],rcx
-       test      rsi,rsi
-       jne       short M01_L03
-       xor       eax,eax
-       add       rsp,20
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FC21CF0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FC21CF0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FC21CF0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-M01_L02:
-       mov       eax,1
-       jmp       short M01_L00
-M01_L03:
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
        mov       rcx,rsi
-       mov       rdx,[rsp+30]
-       mov       rax,[rsi]
-       mov       rax,[rax+58]
-       mov       rax,[rax+10]
-       add       rsp,20
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5F3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,1E1D8C02028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
+       push      rbp
+       push      r15
+       push      r14
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,60
+       lea       rbp,[rsp+40]
+       mov       rax,[7FFFEC3B9750]
+       mov       [rbp],rax
+       mov       rsi,rcx
+       test      [rsp],esp
+       sub       rsp,60
+       lea       rdi,[rsp+40]
+       mov       ebx,[rdx+8]
+       add       rdx,0C
+       mov       [rbp+18],rdx
+       mov       r14,[rbp+18]
+       cmp       [rsi],sil
+       lea       rcx,[rbp+10]
+       mov       [rsp+20],rcx
+       lea       rcx,[rbp+8]
+       mov       [rsp+28],rcx
+       mov       rcx,r14
+       mov       edx,ebx
+       mov       r8,rdi
+       mov       r9d,60
+       call      qword ptr [7FFFEC3CC7A0]; Precode of System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
+       mov       rax,[rbp+10]
+       sub       rax,r14
+       mov       rdx,rax
+       shr       rdx,3F
+       add       rax,rdx
+       sar       rax,1
+       mov       r15d,eax
+       mov       rax,[rbp+8]
+       sub       rax,rdi
+       mov       r12d,eax
+       cmp       r15d,ebx
+       jne       short M03_L04
+M03_L00:
+       xor       eax,eax
+       mov       [rbp+18],rax
+       test      r12d,r12d
+       je        short M03_L03
+       movsxd    rcx,r12d
+       call      qword ptr [7FFFEC3C1C58]
+       mov       r15,rax
+       lea       rcx,[r15+10]
+       mov       r8d,r12d
+       mov       rdx,rdi
+       call      qword ptr [7FFFEC3C4D28]; Precode of System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       rax,r15
+M03_L01:
+       lea       rcx,[7FFFEC3B9750]
+       mov       rcx,[rcx]
+       cmp       [rbp],rcx
+       je        short M03_L02
+       call      qword ptr [7FFFEC3B97A0]; CORINFO_HELP_FAIL_FAST
+M03_L02:
+       nop
+       lea       rsp,[rbp+20]
+       pop       rbx
        pop       rsi
-       jmp       rax
-; Total bytes of code 140
+       pop       rdi
+       pop       r12
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M03_L03:
+       call      qword ptr [7FFFEC3BA440]
+       mov       rax,[rax]
+       jmp       short M03_L01
+M03_L04:
+       mov       dword ptr [rsp+20],60
+       mov       [rsp+28],r15d
+       mov       [rsp+30],r12d
+       mov       rcx,rsi
+       mov       rdx,r14
+       mov       r8d,ebx
+       mov       r9,rdi
+       call      qword ptr [7FFFEC3CC330]
+       mov       r12d,eax
+       jmp       near ptr M03_L00
+; Total bytes of code 274
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
+; System.Text.Encoding.GetBytes(System.String)
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,38
+       mov       rdi,rcx
+       mov       rsi,rdx
+       test      rsi,rsi
+       je        short M05_L00
+       mov       rcx,rdi
+       mov       rdx,rsi
+       mov       rbx,[rdi]
+       mov       rax,[rbx+50]
+       call      qword ptr [rax+18]
+       movsxd    rdx,eax
+       mov       rcx,offset MT_System.Byte[]
+       call      CORINFO_HELP_NEWARR_1_VC
+       mov       rbp,rax
+       mov       [rsp+20],rbp
+       xor       r9d,r9d
+       mov       [rsp+28],r9d
+       mov       r9d,[rsi+8]
+       mov       rcx,rdi
+       mov       rdx,rsi
+       xor       r8d,r8d
+       mov       rax,[rbx+58]
+       call      qword ptr [rax+18]
+       mov       rax,rbp
+       add       rsp,38
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       ret
+M05_L00:
+       mov       ecx,1C81
+       mov       rdx,7FFF8F3A4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F7BD960]
+       int       3
+; Total bytes of code 131
```
**Diff for ToByteArray_Latin1 method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
+       push      rdi
        push      rsi
+       push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,[rsi+28]
-       mov       rdx,217CD551B60
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       mov       rdx,[rsi+28]
+       mov       rax,29EF9400B68
+       mov       rdi,[rax]
+       test      rdx,rdx
+       je        short M00_L00
+       mov       eax,[rdx+8]
+       xor       ecx,ecx
+       test      eax,eax
+       sete      cl
+       test      ecx,ecx
+       sete      cl
+       movzx     ecx,cl
+       test      eax,eax
+       jne       short M00_L01
+       jmp       short M00_L01
+M00_L00:
+       xor       ecx,ecx
+M00_L01:
+       test      ecx,ecx
+       jne       near ptr M00_L02
+       call      qword ptr [7FFF8F907C30]
+       mov       rdi,rax
+       mov       ecx,301
+       mov       rdx,7FFF8F86B520
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F816EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F816EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rsi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F89B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F907810]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F909000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7DD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L02:
+       cmp       [rdx],dl
+       mov       rcx,rdx
+       mov       edx,3
+       call      qword ptr [7FFF8F613510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F6027C0]; System.Text.Encoding.GetBytes(System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FC05B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 75
-; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+; Total bytes of code 304
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M01_L00:
+       push      rdi
        push      rsi
-       sub       rsp,20
-       mov       rsi,rdx
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
        test      rcx,rcx
-       je        short M01_L02
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L02
-       xor       eax,eax
-M01_L00:
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
-       mov       ecx,301
-       mov       rdx,7FFF90F8BA68
+       jne       short M01_L03
+       jmp       short M01_L02
+M01_L01:
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F907C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M01_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M01_L04
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F816EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F816EB8
        call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F89B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F907810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F909000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7DD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M01_L07:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       rcx,rax
-       mov       [rsp+30],rcx
-       test      rsi,rsi
-       jne       short M01_L03
-       xor       eax,eax
-       add       rsp,20
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F613510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FC0F0F0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FC0F0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FC0F0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
        pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-M01_L02:
-       mov       eax,1
-       jmp       short M01_L00
-M01_L03:
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
        mov       rcx,rsi
-       mov       rdx,[rsp+30]
-       mov       rax,[rsi]
-       mov       rax,[rax+58]
-       mov       rax,[rax+10]
-       add       rsp,20
+       mov       edx,r15d
+       call      qword ptr [7FFF8F613390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,29EF9402028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; System.Text.Encoding.GetBytes(System.String)
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,38
+       mov       rdi,rcx
+       mov       rsi,rdx
+       test      rsi,rsi
+       je        short M03_L00
+       mov       rcx,rdi
+       mov       rdx,rsi
+       mov       rbx,[rdi]
+       mov       rax,[rbx+50]
+       call      qword ptr [rax+18]
+       movsxd    rdx,eax
+       mov       rcx,offset MT_System.Byte[]
+       call      CORINFO_HELP_NEWARR_1_VC
+       mov       rbp,rax
+       mov       [rsp+20],rbp
+       xor       r9d,r9d
+       mov       [rsp+28],r9d
+       mov       r9d,[rsi+8]
+       mov       rcx,rdi
+       mov       rdx,rsi
+       xor       r8d,r8d
+       mov       rax,[rbx+58]
+       call      qword ptr [rax+18]
+       mov       rax,rbp
+       add       rsp,38
+       pop       rbx
+       pop       rbp
        pop       rsi
-       jmp       rax
-; Total bytes of code 140
+       pop       rdi
+       ret
+M03_L00:
+       mov       ecx,1C81
+       mov       rdx,7FFF8F3C4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F7DD960]
+       int       3
+; Total bytes of code 131
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
+       push      rdi
        push      rsi
+       push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,[rsi+28]
-       mov       rdx,2B434CF1B88
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       mov       rdx,[rsi+28]
+       mov       rax,1FB94800B90
+       mov       rdi,[rax]
+       test      rdx,rdx
+       je        short M00_L00
+       mov       eax,[rdx+8]
+       xor       ecx,ecx
+       test      eax,eax
+       sete      cl
+       test      ecx,ecx
+       sete      cl
+       movzx     ecx,cl
+       test      eax,eax
+       jne       short M00_L01
+       jmp       short M00_L01
+M00_L00:
+       xor       ecx,ecx
+M00_L01:
+       test      ecx,ecx
+       jne       near ptr M00_L02
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rdi,rax
+       mov       ecx,301
+       mov       rdx,7FFF8F85B520
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rsi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L02:
+       cmp       [rdx],dl
+       mov       rcx,rdx
+       mov       edx,3
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F5F27C0]; System.Text.Encoding.GetBytes(System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBF3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 75
-; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+; Total bytes of code 304
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M01_L00:
+       push      rdi
        push      rsi
-       sub       rsp,20
-       mov       rsi,rdx
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
        test      rcx,rcx
-       je        short M01_L02
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L02
-       xor       eax,eax
-M01_L00:
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
-       mov       ecx,301
-       mov       rdx,7FFF90F7BA68
+       jne       short M01_L03
+       jmp       short M01_L02
+M01_L01:
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M01_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M01_L04
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
        call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M01_L07:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       rcx,rax
-       mov       [rsp+30],rcx
-       test      rsi,rsi
-       jne       short M01_L03
-       xor       eax,eax
-       add       rsp,20
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FBFD0F0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FBFD0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FBFD0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
        pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-M01_L02:
-       mov       eax,1
-       jmp       short M01_L00
-M01_L03:
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
        mov       rcx,rsi
-       mov       rdx,[rsp+30]
-       mov       rax,[rsi]
-       mov       rax,[rax+58]
-       mov       rax,[rax+10]
-       add       rsp,20
+       mov       edx,r15d
+       call      qword ptr [7FFF8F603390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,1FB94802028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; System.Text.Encoding.GetBytes(System.String)
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,38
+       mov       rdi,rcx
+       mov       rsi,rdx
+       test      rsi,rsi
+       je        short M03_L00
+       mov       rcx,rdi
+       mov       rdx,rsi
+       mov       rbx,[rdi]
+       mov       rax,[rbx+50]
+       call      qword ptr [rax+18]
+       movsxd    rdx,eax
+       mov       rcx,offset MT_System.Byte[]
+       call      CORINFO_HELP_NEWARR_1_VC
+       mov       rbp,rax
+       mov       [rsp+20],rbp
+       xor       r9d,r9d
+       mov       [rsp+28],r9d
+       mov       r9d,[rsi+8]
+       mov       rcx,rdi
+       mov       rdx,rsi
+       xor       r8d,r8d
+       mov       rax,[rbx+58]
+       call      qword ptr [rax+18]
+       mov       rax,rbp
+       add       rsp,38
+       pop       rbx
+       pop       rbp
        pop       rsi
-       jmp       rax
-; Total bytes of code 140
+       pop       rdi
+       ret
+M03_L00:
+       mov       ecx,1C81
+       mov       rdx,7FFF8F3B4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F7CD960]
+       int       3
+; Total bytes of code 131
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
+       push      rdi
        push      rsi
+       push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,[rsi+28]
-       mov       rdx,21BDDF51B90
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       mov       rdx,[rsi+28]
+       mov       rax,257C0800B98
+       mov       rdi,[rax]
+       test      rdx,rdx
+       je        short M00_L00
+       mov       eax,[rdx+8]
+       xor       ecx,ecx
+       test      eax,eax
+       sete      cl
+       test      ecx,ecx
+       sete      cl
+       movzx     ecx,cl
+       test      eax,eax
+       jne       short M00_L01
+       jmp       short M00_L01
+M00_L00:
+       xor       ecx,ecx
+M00_L01:
+       test      ecx,ecx
+       jne       near ptr M00_L02
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rdi,rax
+       mov       ecx,301
+       mov       rdx,7FFF8F85B520
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rsi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L02:
+       cmp       [rdx],dl
+       mov       rcx,rdx
+       mov       edx,3
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F5F27C0]; System.Text.Encoding.GetBytes(System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBF5570]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 75
-; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+; Total bytes of code 304
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M01_L00:
+       push      rdi
        push      rsi
-       sub       rsp,20
-       mov       rsi,rdx
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
        test      rcx,rcx
-       je        short M01_L02
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L02
-       xor       eax,eax
-M01_L00:
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
-       mov       ecx,301
-       mov       rdx,7FFF90FBBA68
+       jne       short M01_L03
+       jmp       short M01_L02
+M01_L01:
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M01_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M01_L04
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
        call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M01_L07:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       rcx,rax
-       mov       [rsp+30],rcx
-       test      rsi,rsi
-       jne       short M01_L03
-       xor       eax,eax
-       add       rsp,20
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FBFD1C8]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FBFD1C8]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FBFD1C8]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
        pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-M01_L02:
-       mov       eax,1
-       jmp       short M01_L00
-M01_L03:
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
        mov       rcx,rsi
-       mov       rdx,[rsp+30]
-       mov       rax,[rsi]
-       mov       rax,[rax+58]
-       mov       rax,[rax+10]
-       add       rsp,20
+       mov       edx,r15d
+       call      qword ptr [7FFF8F603390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,257C0802028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; System.Text.Encoding.GetBytes(System.String)
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,38
+       mov       rdi,rcx
+       mov       rsi,rdx
+       test      rsi,rsi
+       je        short M03_L00
+       mov       rcx,rdi
+       mov       rdx,rsi
+       mov       rbx,[rdi]
+       mov       rax,[rbx+50]
+       call      qword ptr [rax+18]
+       movsxd    rdx,eax
+       mov       rcx,offset MT_System.Byte[]
+       call      CORINFO_HELP_NEWARR_1_VC
+       mov       rbp,rax
+       mov       [rsp+20],rbp
+       xor       r9d,r9d
+       mov       [rsp+28],r9d
+       mov       r9d,[rsi+8]
+       mov       rcx,rdi
+       mov       rdx,rsi
+       xor       r8d,r8d
+       mov       rax,[rbx+58]
+       call      qword ptr [rax+18]
+       mov       rax,rbp
+       add       rsp,38
+       pop       rbx
+       pop       rbp
        pop       rsi
-       jmp       rax
-; Total bytes of code 140
+       pop       rdi
+       ret
+M03_L00:
+       mov       ecx,1C81
+       mov       rdx,7FFF8F3B4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F7CD960]
+       int       3
+; Total bytes of code 131
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
+       push      rdi
        push      rsi
+       push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,[rsi+28]
-       mov       rdx,21A917A1BA8
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+       mov       rdx,[rsi+28]
+       mov       rax,156F6C00BB0
+       mov       rdi,[rax]
+       test      rdx,rdx
+       je        short M00_L00
+       mov       eax,[rdx+8]
+       xor       ecx,ecx
+       test      eax,eax
+       sete      cl
+       test      ecx,ecx
+       sete      cl
+       movzx     ecx,cl
+       test      eax,eax
+       jne       short M00_L01
+       jmp       short M00_L01
+M00_L00:
+       xor       ecx,ecx
+M00_L01:
+       test      ecx,ecx
+       jne       near ptr M00_L02
+       call      qword ptr [7FFF8F8E7C30]
+       mov       rdi,rax
+       mov       ecx,301
+       mov       rdx,7FFF8F84B520
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rsi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L02:
+       cmp       [rdx],dl
+       mov       rcx,rdx
+       mov       edx,3
+       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdx,rax
+       test      rdx,rdx
+       je        short M00_L04
+       cmp       dword ptr [rdx+8],20
+       jg        short M00_L04
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F7EBB88]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
+M00_L03:
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBE5330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 75
-; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
+M00_L04:
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F5E27C0]; System.Text.Encoding.GetBytes(System.String)
+       jmp       short M00_L03
+; Total bytes of code 326
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M01_L00:
+       push      rdi
        push      rsi
-       sub       rsp,20
-       mov       rsi,rdx
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
        test      rcx,rcx
-       je        short M01_L02
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L02
-       xor       eax,eax
-M01_L00:
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
-       mov       ecx,301
-       mov       rdx,7FFF90F7BA68
+       jne       short M01_L03
+       jmp       short M01_L02
+M01_L01:
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8E7C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M01_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M01_L04
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
        call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M01_L07:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       rcx,rax
-       mov       [rsp+30],rcx
-       test      rsi,rsi
-       jne       short M01_L03
-       xor       eax,eax
-       add       rsp,20
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FBED3F0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FBED3F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FBED3F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-M01_L02:
-       mov       eax,1
-       jmp       short M01_L00
-M01_L03:
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
        mov       rcx,rsi
-       mov       rdx,[rsp+30]
-       mov       rax,[rsi]
-       mov       rax,[rax+58]
-       mov       rax,[rax+10]
-       add       rsp,20
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5F3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,156F6C02028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
+       push      rbp
+       push      r15
+       push      r14
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,60
+       lea       rbp,[rsp+40]
+       mov       rax,[7FFFEC3B9750]
+       mov       [rbp],rax
+       mov       rsi,rcx
+       test      [rsp],esp
+       sub       rsp,60
+       lea       rdi,[rsp+40]
+       mov       ebx,[rdx+8]
+       add       rdx,0C
+       mov       [rbp+18],rdx
+       mov       r14,[rbp+18]
+       cmp       [rsi],sil
+       lea       rcx,[rbp+10]
+       mov       [rsp+20],rcx
+       lea       rcx,[rbp+8]
+       mov       [rsp+28],rcx
+       mov       rcx,r14
+       mov       edx,ebx
+       mov       r8,rdi
+       mov       r9d,60
+       call      qword ptr [7FFFEC3CC7A0]; Precode of System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
+       mov       rax,[rbp+10]
+       sub       rax,r14
+       mov       rdx,rax
+       shr       rdx,3F
+       add       rax,rdx
+       sar       rax,1
+       mov       r15d,eax
+       mov       rax,[rbp+8]
+       sub       rax,rdi
+       mov       r12d,eax
+       cmp       r15d,ebx
+       jne       short M03_L04
+M03_L00:
+       xor       eax,eax
+       mov       [rbp+18],rax
+       test      r12d,r12d
+       je        short M03_L03
+       movsxd    rcx,r12d
+       call      qword ptr [7FFFEC3C1C58]
+       mov       r15,rax
+       lea       rcx,[r15+10]
+       mov       r8d,r12d
+       mov       rdx,rdi
+       call      qword ptr [7FFFEC3C4D28]; Precode of System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       rax,r15
+M03_L01:
+       lea       rcx,[7FFFEC3B9750]
+       mov       rcx,[rcx]
+       cmp       [rbp],rcx
+       je        short M03_L02
+       call      qword ptr [7FFFEC3B97A0]; CORINFO_HELP_FAIL_FAST
+M03_L02:
+       nop
+       lea       rsp,[rbp+20]
+       pop       rbx
        pop       rsi
-       jmp       rax
-; Total bytes of code 140
+       pop       rdi
+       pop       r12
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M03_L03:
+       call      qword ptr [7FFFEC3BA440]
+       mov       rax,[rax]
+       jmp       short M03_L01
+M03_L04:
+       mov       dword ptr [rsp+20],60
+       mov       [rsp+28],r15d
+       mov       [rsp+30],r12d
+       mov       rcx,rsi
+       mov       rdx,r14
+       mov       r8d,ebx
+       mov       r9,rdi
+       call      qword ptr [7FFFEC3CC330]
+       mov       r12d,eax
+       jmp       near ptr M03_L00
+; Total bytes of code 274
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
+; System.Text.Encoding.GetBytes(System.String)
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,38
+       mov       rdi,rcx
+       mov       rsi,rdx
+       test      rsi,rsi
+       je        short M05_L00
+       mov       rcx,rdi
+       mov       rdx,rsi
+       mov       rbx,[rdi]
+       mov       rax,[rbx+50]
+       call      qword ptr [rax+18]
+       movsxd    rdx,eax
+       mov       rcx,offset MT_System.Byte[]
+       call      CORINFO_HELP_NEWARR_1_VC
+       mov       rbp,rax
+       mov       [rsp+20],rbp
+       xor       r9d,r9d
+       mov       [rsp+28],r9d
+       mov       r9d,[rsi+8]
+       mov       rcx,rdi
+       mov       rdx,rsi
+       xor       r8d,r8d
+       mov       rax,[rbx+58]
+       call      qword ptr [rax+18]
+       mov       rax,rbp
+       add       rsp,38
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       ret
+M05_L00:
+       mov       ecx,1C81
+       mov       rdx,7FFF8F3A4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F7BD960]
+       int       3
+; Total bytes of code 131
```
**Diff for CombineToString method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.CombineToString()
        push      rdi
        push      rsi
-       sub       rsp,28
+       push      rbx
+       sub       rsp,30
        xor       eax,eax
-       mov       [rsp+20],rax
+       mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+28]
-       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.String, System.Private.CoreLib]](System.Object)
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
+       mov       rcx,[rsi+28]
+       test      rcx,rcx
+       jne       near ptr M00_L03
+       call      qword ptr [7FFF8F8C7B10]
+       mov       ecx,5
+       call      System.String.FastAllocateString(Int32)
+       mov       rdi,rax
+       cmp       dword ptr [rdi+8],3
+       jl        near ptr M00_L07
+       lea       rcx,[rdi+0C]
+       mov       rdx,1344E010EC8
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,6
+       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[rdi+8]
+       sub       ecx,3
+       cmp       ecx,2
+       jl        near ptr M00_L08
+       lea       rcx,[rdi+12]
+       mov       rdx,1344E002090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       cmp       dword ptr [rdi+8],0
+       je        short M00_L02
+       mov       rcx,rdi
+M00_L00:
+       test      rcx,rcx
+       jne       short M00_L01
+       mov       eax,1
+       jmp       near ptr M00_L09
+M00_L01:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M00_L09
+M00_L02:
+       mov       rcx,1344E002028
+       mov       rcx,[rcx]
+       jmp       short M00_L00
+M00_L03:
+       call      qword ptr [7FFF8FA7FAB0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       test      rax,rax
+       je        short M00_L04
+       mov       edx,[rax+8]
+       xor       ecx,ecx
+       test      edx,edx
+       sete      cl
+       test      ecx,ecx
+       sete      cl
+       movzx     ecx,cl
+       test      edx,edx
+       jne       short M00_L05
+       jmp       short M00_L05
+M00_L04:
+       xor       ecx,ecx
+M00_L05:
+       test      ecx,ecx
+       jne       short M00_L06
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rsi,rax
+       mov       ecx,767
+       mov       rdx,7FFF8F82B520
+       call      CORINFO_HELP_STRCNS
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9090]
+       int       3
+M00_L06:
+       cmp       [rax],al
+       mov       rcx,rax
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdx,rax
+       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.String, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FFF8FBCD678]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       rdi,rax
        mov       rcx,rsi
        mov       edx,0A
        mov       r8d,0F
        mov       r9d,0F
-       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
+       call      qword ptr [7FFF8F7E56C0]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
        mov       rdx,rax
        mov       r8,rdi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.String, System.Private.CoreLib]](System.String[], System.String)
-       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
+       call      qword ptr [7FFF8FBE7F78]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        mov       rdx,rax
        xor       ecx,ecx
-       call      DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
-       mov       [rsp+20],rax
-       mov       rsi,[rsi+18]
-       mov       rdx,[rsp+20]
-       lea       rcx,[rsi+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       eax,eax
-       mov       [rsi+8],rax
-       add       rsp,28
+       call      qword ptr [7FFF8FBE9018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
+       mov       [rsp+28],rax
+       mov       rcx,[rsi+18]
+       lea       r8,[rsp+28]
+       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
+       cmp       [rcx],ecx
+       call      qword ptr [7FFF8FBE9BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       nop
+       add       rsp,30
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 130
-; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
+M00_L07:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F761C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M00_L08:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F761C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M00_L09:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M00_L10
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L10:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+       int       3
+; Total bytes of code 703
+; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       vzeroupper
+       mov       rax,rcx
+       sub       rax,rdx
+       cmp       rax,r8
+       jae       short M01_L01
+M01_L00:
+       cmp       rcx,rdx
+       je        near ptr M01_L09
+       jmp       near ptr M01_L11
+M01_L01:
+       mov       rax,rdx
+       sub       rax,rcx
+       cmp       rax,r8
+       jb        short M01_L00
+       lea       rax,[rdx+r8]
+       lea       r9,[rcx+r8]
+       cmp       r8,10
+       jbe       short M01_L04
+       cmp       r8,40
+       ja        near ptr M01_L07
+M01_L02:
+       vmovupd   xmm0,[rdx]
+       vmovupd   [rcx],xmm0
+       cmp       r8,20
+       jbe       short M01_L03
+       vmovupd   xmm0,[rdx+10]
+       vmovupd   [rcx+10],xmm0
+       cmp       r8,30
+       jbe       short M01_L03
+       vmovupd   xmm0,[rdx+20]
+       vmovupd   [rcx+20],xmm0
+M01_L03:
+       vmovupd   xmm0,[rax-10]
+       vmovupd   [r9-10],xmm0
+       jmp       short M01_L09
+M01_L04:
+       test      r8b,18
+       je        short M01_L05
+       mov       r8,[rdx]
+       mov       [rcx],r8
+       mov       rdx,[rax-8]
+       mov       [r9-8],rdx
+       jmp       short M01_L09
+M01_L05:
+       test      r8b,4
+       je        short M01_L06
+       mov       r8d,[rdx]
+       mov       [rcx],r8d
+       mov       edx,[rax-4]
+       mov       [r9-4],edx
+       jmp       short M01_L09
+M01_L06:
+       test      r8,r8
+       je        short M01_L09
+       movzx     edx,byte ptr [rdx]
+       mov       [rcx],dl
+       test      r8b,2
+       je        short M01_L09
+       movsx     r8,word ptr [rax-2]
+       mov       [r9-2],r8w
+       jmp       short M01_L09
+M01_L07:
+       cmp       r8,800
+       ja        short M01_L11
+       mov       r10,r8
+       shr       r10,6
+M01_L08:
+       vmovdqu   ymm0,ymmword ptr [rdx]
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymm0,ymmword ptr [rdx+20]
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       add       rdx,40
+       dec       r10
+       je        short M01_L10
+       jmp       short M01_L08
+M01_L09:
+       ret
+M01_L10:
+       and       r8,3F
+       cmp       r8,10
+       ja        near ptr M01_L02
+       vmovupd   xmm0,[rax-10]
+       vmovupd   [r9-10],xmm0
+       jmp       short M01_L09
+M01_L11:
+       jmp       qword ptr [7FFF8F619A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+; Total bytes of code 270
+; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        push      rdi
        push      rsi
-       sub       rsp,28
-       mov       [rsp+20],rcx
-       mov       rsi,rcx
-       test      rdx,rdx
-       setne     cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       je        short M01_L02
-       mov       rcx,rdx
-       call      00007FFF911E00F8
-       mov       rdi,rax
-       mov       rcx,[rsi+10]
-       mov       rcx,[rcx+10]
+       push      rbx
+       sub       rsp,30
+       xor       eax,eax
+       mov       [rsp+28],rax
        test      rcx,rcx
-       je        short M01_L00
-       jmp       short M01_L01
-M01_L00:
+       jne       near ptr M02_L03
+       call      qword ptr [7FFF8F8C7B10]
+       mov       ecx,5
+       call      System.String.FastAllocateString(Int32)
+       mov       rsi,rax
+       cmp       dword ptr [rsi+8],3
+       jl        near ptr M02_L05
+       lea       rcx,[rsi+0C]
+       mov       rdx,1344E010EC8
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,6
+       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[rsi+8]
+       sub       ecx,3
+       cmp       ecx,2
+       jl        near ptr M02_L06
+       lea       rcx,[rsi+12]
+       mov       rdx,1344E002090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       cmp       dword ptr [rsi+8],0
+       je        short M02_L02
        mov       rcx,rsi
-       mov       rdx,7FFF9130DD40
-       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+M02_L00:
+       test      rcx,rcx
+       jne       short M02_L01
+       mov       eax,1
+       jmp       near ptr M02_L07
+M02_L01:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M02_L07
+M02_L02:
+       mov       rcx,1344E002028
+       mov       rcx,[rcx]
+       jmp       short M02_L00
+M02_L03:
+       mov       [rsp+28],rcx
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
+       mov       rdx,rax
+       xor       ecx,ecx
+       call      qword ptr [7FFF8F85F978]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
+       mov       r8,rax
+       test      r8,r8
+       je        short M02_L04
+       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
+       cmp       [r8],rcx
+       je        short M02_L04
+       mov       rdx,rax
+       call      qword ptr [7FFF8F53B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
+       mov       r8,rax
+M02_L04:
+       lea       rdx,[rsp+28]
+       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
+       call      qword ptr [7FFF8FBC5BA0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
+       nop
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M02_L05:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F761C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L06:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F761C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L07:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M02_L08
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-M01_L01:
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
        mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M02_L08:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+       int       3
+; Total bytes of code 571
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M03_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M03_L03
+M03_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M03_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M03_L03
+       jmp       short M03_L02
+M03_L01:
+       call      qword ptr [7FFF8FC370F0]
+       test      eax,eax
+       je        short M03_L03
+M03_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M03_L00
+M03_L03:
+       test      dil,2
+       je        near ptr M03_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M03_L10
+       test      r14d,r14d
+       jl        short M03_L07
+       test      r15d,r15d
+       jl        short M03_L07
+       cmp       ebx,r14d
+       jle       short M03_L07
+M03_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M03_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M03_L10
+       jmp       short M03_L06
+M03_L05:
+       call      qword ptr [7FFF8FC370F0]
+       test      eax,eax
+       je        short M03_L10
+M03_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M03_L04
+       jmp       short M03_L10
+M03_L07:
+       cmp       r14d,ebx
+       jae       short M03_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M03_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M03_L10
+       jmp       short M03_L09
+M03_L08:
+       call      qword ptr [7FFF8FC370F0]
+       test      eax,eax
+       je        short M03_L10
+M03_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M03_L07
+M03_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M03_L12
+       mov       rax,rsi
+M03_L11:
        add       rsp,28
+       pop       rbx
+       pop       rbp
        pop       rsi
        pop       rdi
-       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
-M01_L02:
-       mov       ecx,4D
-       mov       rdx,7FFF90F7BA68
-       call      CORINFO_HELP_STRCNS
+       pop       r14
+       pop       r15
+       ret
+M03_L12:
+       test      r8d,r8d
+       je        short M03_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5D3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M03_L11
+M03_L13:
+       mov       rax,1344E002028
+       mov       rax,[rax]
+       jmp       short M03_L11
+M03_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rcx
+       mov       rdi,rdx
+       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F85D738]; System.Text.Json.JsonSerializerOptions..ctor()
+       mov       rcx,rbx
+       mov       edx,3
+       call      qword ptr [7FFF8F85D918]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
+       mov       rcx,rdi
+       test      rcx,rcx
+       je        short M04_L00
+       mov       eax,[rcx+8]
+       xor       edx,edx
+       test      eax,eax
+       sete      dl
+       test      edx,edx
+       sete      dl
+       movzx     edx,dl
+       test      eax,eax
+       jne       short M04_L01
+       jmp       short M04_L01
+M04_L00:
+       xor       edx,edx
+M04_L01:
+       test      edx,edx
+       jne       near ptr M04_L02
+       call      qword ptr [7FFF8F8C7C30]
        mov       rsi,rax
-       mov       ecx,75F
-       mov       rdx,7FFF90F7BA68
+       mov       ecx,0B50
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
-       mov       r8,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rbx
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
        mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
        mov       rdx,rdi
-       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M04_L02:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdi,rax
+       mov       rcx,[rsi+10]
+       cmp       qword ptr [rcx+10],0
+       je        short M04_L03
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       jmp       short M04_L04
+M04_L03:
+       mov       rcx,rsi
+       mov       rdx,7FFF8FBB5B90
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
-       int       3
-; Total bytes of code 162
+M04_L04:
+       mov       rdx,rdi
+       mov       r8,rbx
+       call      qword ptr [7FFF8FBCD6D8]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
+       nop
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+; Total bytes of code 342
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
        test      esi,esi
-       jle       short M02_L00
-       jmp       short M02_L01
-M02_L00:
+       jle       short M05_L00
+       jmp       short M05_L01
+M05_L00:
        mov       esi,1
-M02_L01:
+M05_L01:
        mov       ecx,esi
        add       ecx,1
-       jo        near ptr M02_L08
+       jo        near ptr M05_L08
        cmp       edi,ecx
-       jl        short M02_L02
-       jmp       short M02_L03
-M02_L02:
+       jl        short M05_L02
+       jmp       short M05_L03
+M05_L02:
        mov       edi,ecx
-M02_L03:
+M05_L03:
        xor       ecx,ecx
-       mov       [rsp+20],rcx
-       mov       rcx,1A1E7F12EA8
+       mov       [rsp+28],rcx
+       mov       rcx,1344E001ED0
        mov       rcx,[rcx]
        mov       edx,100
-       call      qword ptr [7FFF90F30420]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
-       lea       r14,[rsp+20]
-       mov       [rsp+28],rax
+       call      qword ptr [7FFF8F7D1A40]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
+       mov       [rsp+30],rax
        test      rax,rax
-       je        near ptr M02_L09
-       lea       r8,[rax+10]
+       je        near ptr M05_L09
+       lea       r14,[rax+10]
        mov       r15d,[rax+8]
-M02_L04:
-       add       r14,18
-       mov       [r14],r8
-       mov       [r14+8],r15d
+M05_L04:
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
-       jae       near ptr M02_L10
-       movsxd    rcx,eax
-       mov       word ptr [rdx+rcx*2],2D
-       inc       eax
-       mov       [rsp+30],eax
-M02_L05:
-       lea       rcx,[rsp+20]
+       call      qword ptr [7FFF8F731DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       mov       ecx,[rsp+38]
+       mov       rdx,[rsp+40]
+       mov       eax,[rsp+48]
+       cmp       ecx,eax
+       jae       near ptr M05_L10
+       mov       eax,ecx
+       mov       word ptr [rdx+rax*2],2D
+       inc       ecx
+       mov       [rsp+38],ecx
+M05_L05:
+       lea       rcx,[rsp+28]
        mov       edx,esi
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
-       lea       rcx,[rsp+38]
-       mov       rdx,[rcx]
-       mov       ecx,[rcx+8]
-       mov       eax,[rsp+30]
-       cmp       eax,ecx
-       jae       near ptr M02_L11
-       movsxd    rcx,eax
-       mov       word ptr [rdx+rcx*2],2D
-       inc       eax
-       mov       [rsp+30],eax
-M02_L06:
-       lea       rcx,[rsp+20]
+       call      qword ptr [7FFF8F731DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       mov       ecx,[rsp+38]
+       mov       rdx,[rsp+40]
+       mov       eax,[rsp+48]
+       cmp       ecx,eax
+       jae       near ptr M05_L11
+       mov       eax,ecx
+       mov       word ptr [rdx+rax*2],2D
+       inc       ecx
+       mov       [rsp+38],ecx
+M05_L06:
+       lea       rcx,[rsp+28]
        mov       edx,edi
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
-       mov       r15,rax
+       call      qword ptr [7FFF8F731DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FFF8F64D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
+       mov       r12,rax
        mov       rcx,[rbx+10]
-       cmp       [rcx],ecx
-       mov       rdx,r15
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
+       cmp       [rcx],cl
+       mov       rdx,r12
+       call      qword ptr [7FFF8F5DB2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
        test      rax,rax
-       jne       short M02_L07
+       jne       short M05_L07
        mov       r14,[rbx+10]
        mov       ecx,ebp
        mov       edx,esi
        mov       r8d,edi
-       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
+       call      qword ptr [7FFF8F859588]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
        test      rax,rax
-       je        near ptr M02_L12
+       je        near ptr M05_L12
        mov       rdx,rax
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
-       call      00007FFF9121ED20
+       call      qword ptr [7FFF8FBE7438]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,rax
-       cmp       [r14],r14d
+       cmp       [r14],r14b
        mov       rcx,r14
-       mov       rdx,r15
+       mov       rdx,r12
        mov       r9d,2
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
-M02_L07:
+       call      qword ptr [7FFF8F5DB318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
+M05_L07:
        mov       rcx,[rbx+10]
-       mov       rdx,r15
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF90E53200]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
-       nop
-       add       rsp,48
+       cmp       [rcx],cl
+       mov       rdx,r12
+       call      qword ptr [7FFF8F5DB2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
+       test      rax,rax
+       je        short M05_L13
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
-M02_L08:
+M05_L08:
        call      CORINFO_HELP_OVERFLOW
-M02_L09:
-       xor       r8d,r8d
+M05_L09:
+       xor       r14d,r14d
        xor       r15d,r15d
-       jmp       near ptr M02_L04
-M02_L10:
-       mov       rdx,1A1E7F13188
+       jmp       near ptr M05_L04
+M05_L10:
+       mov       rdx,1344E002180
        mov       rdx,[rdx]
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
-       jmp       near ptr M02_L05
-M02_L11:
-       mov       rdx,1A1E7F13188
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FFF8F64DAF8]
+       jmp       near ptr M05_L05
+M05_L11:
+       mov       rdx,1344E002180
        mov       rdx,[rdx]
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
-       jmp       near ptr M02_L06
-M02_L12:
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FFF8F64DAF8]
+       jmp       near ptr M05_L06
+M05_L12:
        mov       ecx,10
-       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
+       call      qword ptr [7FFF8F79B780]
+       int       3
+M05_L13:
+       mov       rdx,r12
+       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FFF8FC69660]
        int       3
-; Total bytes of code 478
+; Total bytes of code 508
 ; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rcx
        mov       rdi,r8
        test      rdi,rdi
-       jne       short M03_L00
+       jne       short M06_L00
        mov       rax,rdx
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
-M03_L00:
+M06_L00:
        mov       rbx,[rsi+10]
        mov       rbp,rdx
        test      rbp,rbp
-       setne     cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       je        short M03_L05
+       jne       near ptr M06_L04
+       call      qword ptr [7FFF8F8C7B10]
+       mov       ecx,7
+       call      System.String.FastAllocateString(Int32)
+       mov       r14,rax
+       cmp       dword ptr [r14+8],5
+       jl        near ptr M06_L09
+       lea       rcx,[r14+0C]
+       mov       rdx,1344E0085C8
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,0A
+       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[r14+8]
+       sub       ecx,5
+       cmp       ecx,2
+       jl        near ptr M06_L10
+       lea       rcx,[r14+16]
+       mov       rdx,1344E002090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       cmp       dword ptr [r14+8],0
+       je        short M06_L03
+       mov       rcx,r14
+M06_L01:
+       test      rcx,rcx
+       jne       short M06_L02
+       mov       eax,1
+       jmp       near ptr M06_L11
+M06_L02:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M06_L11
+M06_L03:
+       mov       rcx,1344E002028
+       mov       rcx,[rcx]
+       jmp       short M06_L01
+M06_L04:
        mov       rcx,[rbx+18]
        test      rcx,rcx
-       je        short M03_L01
-       jmp       short M03_L02
-M03_L01:
+       je        short M06_L05
+       jmp       short M06_L06
+M06_L05:
        mov       rcx,rsi
-       mov       rdx,7FFF9132D8E0
+       mov       rdx,7FFF8FBBB728
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
-M03_L02:
+M06_L06:
        call      CORINFO_HELP_NEWSFAST
        mov       r14,rax
        mov       rcx,r14
        mov       rdx,rbp
-       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFF8F647930]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       rcx,[rbx+20]
        test      rcx,rcx
-       je        short M03_L03
-       jmp       short M03_L04
-M03_L03:
+       je        short M06_L07
+       jmp       short M06_L08
+M06_L07:
        mov       rcx,rsi
-       mov       rdx,7FFF9132E050
+       mov       rdx,7FFF8FBBBE98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
-M03_L04:
+M06_L08:
        mov       rdx,r14
        mov       r8,rdi
-       call      DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
+       call      qword ptr [7FFF8FBE9A98]; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
        mov       rcx,r14
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
-M03_L05:
-       mov       ecx,4D
-       mov       rdx,7FFF90F7BA68
-       call      CORINFO_HELP_STRCNS
+       jmp       qword ptr [7FFF8F647F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
+M06_L09:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F761C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M06_L10:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       ecx,4F
-       mov       rdx,7FFF90F7BA68
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F761C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M06_L11:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M06_L12
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
-       mov       r8,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
        mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
        mov       rdx,rdi
-       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
-       mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M06_L12:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
        int       3
-; Total bytes of code 246
+; Total bytes of code 626
 ; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
        push      rbp
+       push      r15
        push      r14
+       push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+50]
-       mov       [rbp-30],rsp
+       lea       rbp,[rsp+60]
+       mov       [rbp-40],rsp
        mov       esi,ecx
        mov       rdi,rdx
-       mov       rcx,7FFF90F36308
-       mov       edx,1D
-       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1A1E7F17E50
-       mov       rcx,[rcx]
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
-       call      qword ptr [rax+20]
+       mov       rcx,1344E006EE8
+       mov       rbx,[rcx]
+       mov       rcx,rbx
+       call      qword ptr [7FFF8FA95588]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
        mov       rdx,rax
-       mov       [rbp-28],rdx
+       mov       [rbp-38],rdx
        test      rdi,rdi
-       je        short M04_L03
-       mov       ebx,[rdi+8]
-       test      ebx,ebx
-       je        short M04_L03
-       xor       r14d,r14d
-       test      ebx,ebx
-       jle       short M04_L03
-M04_L00:
-       mov       rdx,[rbp-28]
-       movsxd    rcx,r14d
-       mov       rax,[rdi+rcx*8+10]
+       je        near ptr M07_L04
+       mov       r14d,[rdi+8]
+       test      r14d,r14d
+       je        short M07_L04
+       xor       r15d,r15d
+       test      r14d,r14d
+       jle       short M07_L04
+M07_L00:
+       mov       rdx,[rbp-38]
+       mov       ecx,r15d
+       mov       r12,[rdi+rcx*8+10]
        cmp       esi,0FFFFFFFF
-       je        short M04_L01
-       mov       rcx,rdx
-       mov       rdx,rax
-       cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
-       jmp       short M04_L02
-M04_L01:
-       cmp       [rdx],edx
-       mov       rcx,rdx
-       mov       rdx,rax
-       call      System.Text.StringBuilder.Append(System.String)
-       call      System.Environment.get_NewLine()
-       mov       rdx,rax
-       mov       rcx,[rbp-28]
-       call      System.Text.StringBuilder.Append(System.String)
-M04_L02:
-       inc       r14d
-       cmp       ebx,r14d
-       jg        short M04_L00
-M04_L03:
-       mov       rcx,[rbp-28]
+       je        short M07_L01
+       cmp       [rdx],dl
+       test      r12,r12
+       je        short M07_L03
+       mov       r8d,[r12+8]
+       lea       rdx,[r12+0C]
+       mov       rcx,[rbp-38]
+       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
+       jmp       short M07_L03
+M07_L01:
+       cmp       [rdx],dl
+       test      r12,r12
+       je        short M07_L02
+       mov       r8d,[r12+8]
+       lea       rdx,[r12+0C]
+       mov       rcx,[rbp-38]
+       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
+M07_L02:
+       mov       rdx,1344E0084B0
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       rcx,[rbp-38]
+       mov       r8d,2
+       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
+M07_L03:
+       inc       r15d
+       cmp       r14d,r15d
+       jg        short M07_L00
+M07_L04:
+       mov       rcx,[rbp-38]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF90F1AF70]; System.Text.StringBuilder.ToString()
+       call      qword ptr [7FFF8F7AD350]; System.Text.StringBuilder.ToString()
        mov       rsi,rax
-       mov       rcx,1A1E7F17E50
-       mov       rcx,[rcx]
-       mov       rdx,[rbp-28]
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
-       call      qword ptr [rax+28]
+       mov       rcx,rbx
+       mov       rdx,[rbp-38]
+       call      qword ptr [7FFF8FA95590]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
        mov       rax,rsi
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r14
+       pop       r15
        pop       rbp
        ret
        push      rbp
+       push      r15
        push      r14
+       push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
-       lea       rbp,[rbp+50]
-       mov       rcx,7FFF90F36308
-       mov       edx,1D
-       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1A1E7F17E50
-       mov       rcx,[rcx]
-       mov       rdx,[rbp-28]
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
-       call      qword ptr [rax+28]
+       lea       rbp,[rbp+60]
+       mov       rcx,1344E006EE8
+       mov       rbx,[rcx]
+       mov       rcx,rbx
+       mov       rdx,[rbp-38]
+       call      qword ptr [7FFF8FA95590]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
        nop
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r14
+       pop       r15
        pop       rbp
        ret
-; Total bytes of code 301
+; Total bytes of code 312
+; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       push      rsi
+       mov       rsi,rcx
+       mov       rdx,[r8]
+       lea       rcx,[rsi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rsi+8],rax
+       pop       rsi
+       ret
+; Total bytes of code 24
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M09_L00:
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
+       test      rcx,rcx
+       je        short M09_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
+       test      eax,eax
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
+       test      eax,eax
+       jne       short M09_L03
+       jmp       short M09_L02
+M09_L01:
+       xor       r9d,r9d
+M09_L02:
+       test      r8,r8
+       je        short M09_L03
+       cmp       dword ptr [r8+8],0
+       je        short M09_L03
+       mov       rcx,r8
+       jmp       near ptr M09_L06
+M09_L03:
+       test      r9d,r9d
+       jne       near ptr M09_L06
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M09_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M09_L04
+       jmp       short M09_L05
+M09_L04:
+       mov       rsi,rdi
+M09_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M09_L06:
+       test      dl,dl
+       jne       short M09_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M09_L07:
+       cmp       [rcx],cl
+       mov       edx,3
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+**Extern method**
+System.String.FastAllocateString(Int32)
```
**Diff for Concat method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Concat()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rdx,[rsi+28]
-       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.String, System.Private.CoreLib]](System.Object)
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
+       mov       rcx,[rsi+28]
+       test      rcx,rcx
+       jne       near ptr M00_L03
+       call      qword ptr [7FFF8F8D7B10]
+       mov       ecx,5
+       call      System.String.FastAllocateString(Int32)
+       mov       rdi,rax
+       cmp       dword ptr [rdi+8],3
+       jl        near ptr M00_L07
+       lea       rcx,[rdi+0C]
+       mov       rdx,2640D810EC8
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,6
+       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[rdi+8]
+       sub       ecx,3
+       cmp       ecx,2
+       jl        near ptr M00_L08
+       lea       rcx,[rdi+12]
+       mov       rdx,2640D802090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       cmp       dword ptr [rdi+8],0
+       je        short M00_L02
+       mov       rcx,rdi
+M00_L00:
+       test      rcx,rcx
+       jne       short M00_L01
+       mov       eax,1
+       jmp       near ptr M00_L09
+M00_L01:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M00_L09
+M00_L02:
+       mov       rcx,2640D802028
+       mov       rcx,[rcx]
+       jmp       short M00_L00
+M00_L03:
+       call      qword ptr [7FFF8FAC9540]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
+       test      rax,rax
+       je        short M00_L04
+       mov       edx,[rax+8]
+       xor       ecx,ecx
+       test      edx,edx
+       sete      cl
+       test      ecx,ecx
+       sete      cl
+       movzx     ecx,cl
+       test      edx,edx
+       jne       short M00_L05
+       jmp       short M00_L05
+M00_L04:
+       xor       ecx,ecx
+M00_L05:
+       test      ecx,ecx
+       jne       near ptr M00_L06
+       call      qword ptr [7FFF8F8D7C30]
+       mov       rsi,rax
+       mov       ecx,767
+       mov       rdx,7FFF8F83B520
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rdi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F86B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8D7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8D9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L06:
+       cmp       [rax],al
+       mov       rcx,rax
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdx,rax
+       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.String, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FFF8FC07660]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       rdi,rax
-       mov       rcx,28A546D3190
-       mov       rbx,[rcx]
        mov       rcx,rsi
        mov       edx,0A
        mov       r8d,0F
        mov       r9d,0F
-       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
+       call      qword ptr [7FFF8F7E56C0]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
        mov       r9,rax
-       mov       rdx,rbx
        mov       rcx,rdi
+       mov       rdx,2640D802190
+       mov       rdx,[rdx]
        mov       r8d,0FFFFFFFF
-       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
+       call      qword ptr [7FFF8F869780]; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
        mov       [rsp+28],rax
-       mov       rsi,[rsi+18]
-       mov       rdx,[rsp+28]
-       lea       rcx,[rsi+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       eax,eax
-       mov       [rsi+8],rax
+       mov       rcx,[rsi+18]
+       lea       r8,[rsp+28]
+       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
+       cmp       [rcx],ecx
+       call      qword ptr [7FFF8FC933F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       nop
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
+M00_L07:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F761C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M00_L08:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F761C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M00_L09:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M00_L10
+       call      qword ptr [7FFF8F8D7C30]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F86B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8D7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8D9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L10:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8D7810]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+       int       3
+; Total bytes of code 825
+; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       vzeroupper
+       mov       rax,rcx
+       sub       rax,rdx
+       cmp       rax,r8
+       jae       short M01_L01
+M01_L00:
+       cmp       rcx,rdx
+       je        near ptr M01_L09
+       jmp       near ptr M01_L11
+M01_L01:
+       mov       rax,rdx
+       sub       rax,rcx
+       cmp       rax,r8
+       jb        short M01_L00
+       lea       rax,[rdx+r8]
+       lea       r9,[rcx+r8]
+       cmp       r8,10
+       jbe       short M01_L04
+       cmp       r8,40
+       ja        near ptr M01_L07
+M01_L02:
+       vmovupd   xmm0,[rdx]
+       vmovupd   [rcx],xmm0
+       cmp       r8,20
+       jbe       short M01_L03
+       vmovupd   xmm0,[rdx+10]
+       vmovupd   [rcx+10],xmm0
+       cmp       r8,30
+       jbe       short M01_L03
+       vmovupd   xmm0,[rdx+20]
+       vmovupd   [rcx+20],xmm0
+M01_L03:
+       vmovupd   xmm0,[rax-10]
+       vmovupd   [r9-10],xmm0
+       jmp       short M01_L09
+M01_L04:
+       test      r8b,18
+       je        short M01_L05
+       mov       r8,[rdx]
+       mov       [rcx],r8
+       mov       rdx,[rax-8]
+       mov       [r9-8],rdx
+       jmp       short M01_L09
+M01_L05:
+       test      r8b,4
+       je        short M01_L06
+       mov       r8d,[rdx]
+       mov       [rcx],r8d
+       mov       edx,[rax-4]
+       mov       [r9-4],edx
+       jmp       short M01_L09
+M01_L06:
+       test      r8,r8
+       je        short M01_L09
+       movzx     edx,byte ptr [rdx]
+       mov       [rcx],dl
+       test      r8b,2
+       je        short M01_L09
+       movsx     r8,word ptr [rax-2]
+       mov       [r9-2],r8w
+       jmp       short M01_L09
+M01_L07:
+       cmp       r8,800
+       ja        short M01_L11
+       mov       r10,r8
+       shr       r10,6
+M01_L08:
+       vmovdqu   ymm0,ymmword ptr [rdx]
+       vmovdqu   ymmword ptr [rcx],ymm0
+       vmovdqu   ymm0,ymmword ptr [rdx+20]
+       vmovdqu   ymmword ptr [rcx+20],ymm0
+       add       rcx,40
+       add       rdx,40
+       dec       r10
+       je        short M01_L10
+       jmp       short M01_L08
+M01_L09:
+       ret
+M01_L10:
+       and       r8,3F
+       cmp       r8,10
+       ja        near ptr M01_L02
+       vmovupd   xmm0,[rax-10]
+       vmovupd   [r9-10],xmm0
+       jmp       short M01_L09
+M01_L11:
+       jmp       qword ptr [7FFF8F619A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+; Total bytes of code 270
+; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
        push      rdi
        push      rsi
-       sub       rsp,28
-       mov       [rsp+20],rcx
-       mov       rsi,rcx
-       test      rdx,rdx
-       setne     cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       je        short M01_L02
-       mov       rcx,rdx
-       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
-       mov       rdi,rax
-       mov       rcx,[rsi+10]
-       mov       rcx,[rcx+10]
+       push      rbx
+       sub       rsp,30
+       xor       eax,eax
+       mov       [rsp+28],rax
        test      rcx,rcx
-       je        short M01_L00
-       jmp       short M01_L01
-M01_L00:
+       jne       near ptr M02_L03
+       call      qword ptr [7FFF8F8D7B10]
+       mov       ecx,5
+       call      System.String.FastAllocateString(Int32)
+       mov       rsi,rax
+       cmp       dword ptr [rsi+8],3
+       jl        near ptr M02_L05
+       lea       rcx,[rsi+0C]
+       mov       rdx,2640D810EC8
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,6
+       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       ecx,[rsi+8]
+       sub       ecx,3
+       cmp       ecx,2
+       jl        near ptr M02_L06
+       lea       rcx,[rsi+12]
+       mov       rdx,2640D802090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [7FFF8F6199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       cmp       dword ptr [rsi+8],0
+       je        short M02_L02
        mov       rcx,rsi
-       mov       rdx,7FFF91343590
-       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+M02_L00:
+       test      rcx,rcx
+       jne       short M02_L01
+       mov       eax,1
+       jmp       near ptr M02_L07
+M02_L01:
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M02_L07
+M02_L02:
+       mov       rcx,2640D802028
+       mov       rcx,[rcx]
+       jmp       short M02_L00
+M02_L03:
+       mov       [rsp+28],rcx
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
+       mov       rdx,rax
+       xor       ecx,ecx
+       call      qword ptr [7FFF8F86F978]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
+       mov       r8,rax
+       test      r8,r8
+       je        short M02_L04
+       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
+       cmp       [r8],rcx
+       je        short M02_L04
+       mov       rdx,rax
+       call      qword ptr [7FFF8F53B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
+       mov       r8,rax
+M02_L04:
+       lea       rdx,[rsp+28]
+       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
+       call      qword ptr [7FFF8FBEFBA0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
+       nop
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M02_L05:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F761C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L06:
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F761C78]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M02_L07:
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M02_L08
+       call      qword ptr [7FFF8F8D7C30]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-M01_L01:
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F86B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8D7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8D9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M02_L08:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8D7810]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+       int       3
+; Total bytes of code 571
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M03_L00:
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
+       test      rcx,rcx
+       je        short M03_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
+       test      eax,eax
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
+       test      eax,eax
+       jne       short M03_L03
+       jmp       short M03_L02
+M03_L01:
+       xor       r9d,r9d
+M03_L02:
+       test      r8,r8
+       je        short M03_L03
+       cmp       dword ptr [r8+8],0
+       je        short M03_L03
+       mov       rcx,r8
+       jmp       near ptr M03_L06
+M03_L03:
+       test      r9d,r9d
+       jne       near ptr M03_L06
+       call      qword ptr [7FFF8F8D7C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M03_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M03_L04
+       jmp       short M03_L05
+M03_L04:
+       mov       rsi,rdi
+M03_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F86B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8D7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8D9000]
+       mov       r8,rax
        mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M03_L06:
+       test      dl,dl
+       jne       short M03_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M03_L07:
+       cmp       [rcx],cl
+       mov       edx,3
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M04_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M04_L03
+M04_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M04_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M04_L03
+       jmp       short M04_L02
+M04_L01:
+       call      qword ptr [7FFF8FC9BC60]
+       test      eax,eax
+       je        short M04_L03
+M04_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M04_L00
+M04_L03:
+       test      dil,2
+       je        near ptr M04_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M04_L10
+       test      r14d,r14d
+       jl        short M04_L07
+       test      r15d,r15d
+       jl        short M04_L07
+       cmp       ebx,r14d
+       jle       short M04_L07
+M04_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M04_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M04_L10
+       jmp       short M04_L06
+M04_L05:
+       call      qword ptr [7FFF8FC9BC60]
+       test      eax,eax
+       je        short M04_L10
+M04_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M04_L04
+       jmp       short M04_L10
+M04_L07:
+       cmp       r14d,ebx
+       jae       short M04_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M04_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M04_L10
+       jmp       short M04_L09
+M04_L08:
+       call      qword ptr [7FFF8FC9BC60]
+       test      eax,eax
+       je        short M04_L10
+M04_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M04_L07
+M04_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M04_L12
+       mov       rax,rsi
+M04_L11:
        add       rsp,28
+       pop       rbx
+       pop       rbp
        pop       rsi
        pop       rdi
-       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
-M01_L02:
-       mov       ecx,4D
-       mov       rdx,7FFF90FABA68
-       call      CORINFO_HELP_STRCNS
+       pop       r14
+       pop       r15
+       ret
+M04_L12:
+       test      r8d,r8d
+       je        short M04_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5D3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M04_L11
+M04_L13:
+       mov       rax,2640D802028
+       mov       rax,[rax]
+       jmp       short M04_L11
+M04_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rcx
+       mov       rdi,rdx
+       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F86D738]; System.Text.Json.JsonSerializerOptions..ctor()
+       mov       rcx,rbx
+       mov       edx,3
+       call      qword ptr [7FFF8F86D918]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
+       mov       rcx,rdi
+       test      rcx,rcx
+       je        short M05_L00
+       mov       eax,[rcx+8]
+       xor       edx,edx
+       test      eax,eax
+       sete      dl
+       test      edx,edx
+       sete      dl
+       movzx     edx,dl
+       test      eax,eax
+       jne       short M05_L01
+       jmp       short M05_L01
+M05_L00:
+       xor       edx,edx
+M05_L01:
+       test      edx,edx
+       jne       near ptr M05_L02
+       call      qword ptr [7FFF8F8D7C30]
        mov       rsi,rax
-       mov       ecx,75F
-       mov       rdx,7FFF90FABA68
+       mov       ecx,0B50
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
-       mov       r8,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rbx
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F86B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8D7810]
+       mov       rdx,rax
        mov       rcx,rsi
+       call      qword ptr [7FFF8F8D9000]
+       mov       r8,rax
        mov       rdx,rdi
-       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M05_L02:
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdi,rax
+       mov       rcx,[rsi+10]
+       cmp       qword ptr [rcx+10],0
+       je        short M05_L03
+       mov       rcx,[rsi+10]
+       mov       rcx,[rcx+10]
+       jmp       short M05_L04
+M05_L03:
+       mov       rcx,rsi
+       mov       rdx,7FFF8FBCF210
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
-       int       3
-; Total bytes of code 162
+M05_L04:
+       mov       rdx,rdi
+       mov       r8,rbx
+       call      qword ptr [7FFF8FC076C0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
+       nop
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+; Total bytes of code 342
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
        test      esi,esi
-       jle       short M02_L00
-       jmp       short M02_L01
-M02_L00:
+       jle       short M06_L00
+       jmp       short M06_L01
+M06_L00:
        mov       esi,1
-M02_L01:
+M06_L01:
        mov       ecx,esi
        add       ecx,1
-       jo        near ptr M02_L08
+       jo        near ptr M06_L08
        cmp       edi,ecx
-       jl        short M02_L02
-       jmp       short M02_L03
-M02_L02:
+       jl        short M06_L02
+       jmp       short M06_L03
+M06_L02:
        mov       edi,ecx
-M02_L03:
+M06_L03:
        xor       ecx,ecx
-       mov       [rsp+20],rcx
-       mov       rcx,28A546D2EA8
+       mov       [rsp+28],rcx
+       mov       rcx,2640D801ED0
        mov       rcx,[rcx]
        mov       edx,100
-       call      qword ptr [7FFF90F50420]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
-       lea       r14,[rsp+20]
-       mov       [rsp+28],rax
+       call      qword ptr [7FFF8F7D1A40]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
+       mov       [rsp+30],rax
        test      rax,rax
-       je        near ptr M02_L09
-       lea       r8,[rax+10]
+       je        near ptr M06_L09
+       lea       r14,[rax+10]
        mov       r15d,[rax+8]
-M02_L04:
-       add       r14,18
-       mov       [r14],r8
-       mov       [r14+8],r15d
+M06_L04:
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
-       jae       near ptr M02_L10
-       movsxd    rcx,eax
-       mov       word ptr [rdx+rcx*2],2D
-       inc       eax
-       mov       [rsp+30],eax
-M02_L05:
-       lea       rcx,[rsp+20]
+       call      qword ptr [7FFF8F731DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       mov       ecx,[rsp+38]
+       mov       rdx,[rsp+40]
+       mov       eax,[rsp+48]
+       cmp       ecx,eax
+       jae       near ptr M06_L10
+       mov       eax,ecx
+       mov       word ptr [rdx+rax*2],2D
+       inc       ecx
+       mov       [rsp+38],ecx
+M06_L05:
+       lea       rcx,[rsp+28]
        mov       edx,esi
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
-       lea       rcx,[rsp+38]
-       mov       rdx,[rcx]
-       mov       ecx,[rcx+8]
-       mov       eax,[rsp+30]
-       cmp       eax,ecx
-       jae       near ptr M02_L11
-       movsxd    rcx,eax
-       mov       word ptr [rdx+rcx*2],2D
-       inc       eax
-       mov       [rsp+30],eax
-M02_L06:
-       lea       rcx,[rsp+20]
+       call      qword ptr [7FFF8F731DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       mov       ecx,[rsp+38]
+       mov       rdx,[rsp+40]
+       mov       eax,[rsp+48]
+       cmp       ecx,eax
+       jae       near ptr M06_L11
+       mov       eax,ecx
+       mov       word ptr [rdx+rax*2],2D
+       inc       ecx
+       mov       [rsp+38],ecx
+M06_L06:
+       lea       rcx,[rsp+28]
        mov       edx,edi
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
-       mov       r15,rax
+       call      qword ptr [7FFF8F731DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FFF8F64D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
+       mov       r12,rax
        mov       rcx,[rbx+10]
-       cmp       [rcx],ecx
-       mov       rdx,r15
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
+       cmp       [rcx],cl
+       mov       rdx,r12
+       call      qword ptr [7FFF8F5DB2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
        test      rax,rax
-       jne       short M02_L07
+       jne       short M06_L07
        mov       r14,[rbx+10]
        mov       ecx,ebp
        mov       edx,esi
        mov       r8d,edi
-       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
+       call      qword ptr [7FFF8F869588]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
        test      rax,rax
-       je        near ptr M02_L12
+       je        near ptr M06_L12
        mov       rdx,rax
        mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
-       call      00007FFF912411C0
+       call      qword ptr [7FFF8FC31438]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       r8,rax
-       cmp       [r14],r14d
+       cmp       [r14],r14b
        mov       rcx,r14
-       mov       rdx,r15
+       mov       rdx,r12
        mov       r9d,2
-       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
-M02_L07:
+       call      qword ptr [7FFF8F5DB318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
+M06_L07:
        mov       rcx,[rbx+10]
-       mov       rdx,r15
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF90E73200]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
-       nop
-       add       rsp,48
+       cmp       [rcx],cl
+       mov       rdx,r12
+       call      qword ptr [7FFF8F5DB2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
+       test      rax,rax
+       je        short M06_L13
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
-M02_L08:
+M06_L08:
        call      CORINFO_HELP_OVERFLOW
-M02_L09:
-       xor       r8d,r8d
+M06_L09:
+       xor       r14d,r14d
        xor       r15d,r15d
-       jmp       near ptr M02_L04
-M02_L10:
-       mov       rdx,28A546D3188
+       jmp       near ptr M06_L04
+M06_L10:
+       mov       rdx,2640D802180
        mov       rdx,[rdx]
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
-       jmp       near ptr M02_L05
-M02_L11:
-       mov       rdx,28A546D3188
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FFF8F64DAF8]
+       jmp       near ptr M06_L05
+M06_L11:
+       mov       rdx,2640D802180
        mov       rdx,[rdx]
-       lea       rcx,[rsp+20]
-       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
-       jmp       near ptr M02_L06
-M02_L12:
+       lea       rcx,[rsp+28]
+       call      qword ptr [7FFF8F64DAF8]
+       jmp       near ptr M06_L06
+M06_L12:
        mov       ecx,10
-       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
+       call      qword ptr [7FFF8F79B780]
        int       3
-; Total bytes of code 478
+M06_L13:
+       mov       rdx,r12
+       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FFF8FD13228]
+       int       3
+; Total bytes of code 508
 ; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
        push      rbp
        push      r15
        push      r14
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       r14,rcx
        mov       rbx,rdx
        mov       edi,r8d
        mov       rsi,r9
        mov       rcx,r14
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8FAC91F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
        test      eax,eax
-       je        short M03_L00
-       mov       rax,28A546D3020
+       je        short M07_L00
+       mov       rax,2640D802028
        mov       rax,[rax]
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r14
        pop       r15
        pop       rbp
        ret
-M03_L00:
+M07_L00:
        mov       rcx,rbx
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8FAC91F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
        test      eax,eax
-       je        short M03_L01
-       mov       rcx,28A546D3020
+       je        short M07_L01
+       mov       rcx,2640D802028
        mov       rbx,[rcx]
-M03_L01:
-       mov       rcx,7FFF90FAC210
-       mov       edx,2D
-       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,28A546D8448
-       mov       rcx,[rcx]
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
-       call      qword ptr [rax+20]
-       mov       [rbp-38],rax
+M07_L01:
+       mov       rcx,2640D8074E8
+       mov       r15,[rcx]
+       mov       rcx,r15
+       call      qword ptr [7FFF8FABB258]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
+       mov       rdx,rax
+       mov       [rbp-38],rdx
+       cmp       [rdx],dl
+       test      r14,r14
+       je        short M07_L02
+       mov       r8d,[r14+8]
+       lea       rdx,[r14+0C]
        mov       rcx,[rbp-38]
-       mov       rdx,r14
-       cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
-       mov       [rbp-38],rax
+       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
+M07_L02:
        test      rsi,rsi
-       je        short M03_L04
+       je        near ptr M07_L07
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8FAC9060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       ecx,ecx
        test      eax,eax
        setg      cl
-       movzx     ecx,cl
        test      ecx,ecx
-       je        short M03_L04
+       je        near ptr M07_L07
        xor       r14d,r14d
-       mov       r15d,[rsi+8]
-       test      r15d,r15d
-       jle       short M03_L04
-M03_L02:
-       movsxd    rcx,r14d
-       mov       rdx,[rsi+rcx*8+10]
-       lea       ecx,[rdi+2]
-       cmp       ecx,1
-       jbe       short M03_L06
-       mov       rcx,rdx
+       mov       r12d,[rsi+8]
+       test      r12d,r12d
+       jle       short M07_L07
+M07_L03:
+       mov       ecx,r14d
+       mov       rcx,[rsi+rcx*8+10]
+       lea       edx,[rdi+2]
+       cmp       edx,1
+       jbe       short M07_L04
        mov       rdx,rbx
-       call      System.String.Concat(System.String, System.String)
+       call      qword ptr [7FFF8F5D1C60]; System.String.Concat(System.String, System.String)
        mov       rdx,rax
+       test      rdx,rdx
+       je        short M07_L06
+       mov       r8d,[rdx+8]
+       add       rdx,0C
        mov       rcx,[rbp-38]
-       cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
-M03_L03:
-       add       r14d,1
-       jo        short M03_L05
-       cmp       r15d,r14d
-       jg        short M03_L02
-M03_L04:
-       mov       rcx,[rbp-38]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF90F3AF70]; System.Text.StringBuilder.ToString()
-       mov       r12,rax
-       jmp       short M03_L07
-M03_L05:
-       call      CORINFO_HELP_OVERFLOW
-M03_L06:
+       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
+       jmp       short M07_L06
+M07_L04:
+       test      rcx,rcx
+       je        short M07_L05
+       mov       r8d,[rcx+8]
+       lea       rdx,[rcx+0C]
        mov       rcx,[rbp-38]
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
+M07_L05:
+       mov       rdx,2640D8084B0
+       mov       rdx,[rdx]
+       add       rdx,0C
        mov       rcx,[rbp-38]
-       call      System.Text.StringBuilder.Append(System.String)
-       call      System.Environment.get_NewLine()
-       mov       rdx,rax
+       mov       r8d,2
+       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
+M07_L06:
+       add       r14d,1
+       jo        short M07_L08
+       cmp       r12d,r14d
+       jg        short M07_L03
+M07_L07:
        mov       rcx,[rbp-38]
-       call      System.Text.StringBuilder.Append(System.String)
-       jmp       short M03_L03
-M03_L07:
-       mov       rcx,28A546D8448
-       mov       rcx,[rcx]
+       call      qword ptr [7FFF8F7AD350]; System.Text.StringBuilder.ToString()
+       mov       rsi,rax
+       jmp       short M07_L09
+M07_L08:
+       call      CORINFO_HELP_OVERFLOW
+       int       3
+M07_L09:
+       mov       rcx,r15
        mov       rdx,[rbp-38]
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
-       call      qword ptr [rax+28]
-       mov       rax,r12
+       call      qword ptr [7FFF8FABB260]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
+       mov       rax,rsi
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
        lea       rbp,[rbp+60]
-       mov       rcx,7FFF90FAC210
-       mov       edx,2D
-       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,28A546D8448
-       mov       rcx,[rcx]
+       mov       rcx,2640D8074E8
+       mov       r15,[rcx]
+       mov       rcx,r15
        mov       rdx,[rbp-38]
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
-       call      qword ptr [rax+28]
+       call      qword ptr [7FFF8FABB260]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
-; Total bytes of code 445
+; Total bytes of code 442
+; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       push      rsi
+       mov       rsi,rcx
+       mov       rdx,[r8]
+       lea       rcx,[rsi+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       eax,eax
+       mov       [rsi+8],rax
+       pop       rsi
+       ret
+; Total bytes of code 24
+**Extern method**
+System.String.FastAllocateString(Int32)
```
**Diff for DefaultIfNull method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
-       mov       r8,26E878F2C80
+       mov       r8,2BCD4000CA8
        mov       r8,[r8]
        mov       [rsp+20],r8
        mov       rcx,[rcx+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBC3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 61
+; Total bytes of code 62
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
+       push      rdi
        push      rsi
+       push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rcx,177DCB12C80
+       mov       rax,1ECCDC00CB0
+       mov       rcx,[rax]
+       mov       eax,[rcx+8]
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M00_L00
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rsi,rax
+       mov       ecx,9F8
+       mov       rdx,7FFF8F82B520
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rdi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L00:
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rcx,1ECCDC00CA8
        mov       rcx,[rcx]
-       mov       rdx,177DCB12C88
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
-       mov       [rsp+28],rax
+       mov       [rsp+28],rcx
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBC3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 84
-; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
-       push      rsi
-       sub       rsp,20
-       mov       rsi,rcx
-       test      rdx,rdx
-       je        short M01_L02
-       cmp       dword ptr [rdx+8],0
-       je        short M01_L02
-       xor       eax,eax
+; Total bytes of code 284
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
 M01_L00:
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
+       test      rcx,rcx
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
-       mov       ecx,9F8
-       mov       rdx,7FFF90F8BA68
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
+       jne       short M01_L03
+       jmp       short M01_L02
 M01_L01:
-       cmp       [rdx],edx
-       mov       rcx,rdx
-       mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       rdx,rax
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rdi,rax
        test      rsi,rsi
        je        short M01_L04
        cmp       dword ptr [rsi+8],0
        je        short M01_L04
-       jmp       short M01_L03
-M01_L02:
-       mov       eax,1
-       jmp       short M01_L00
-M01_L03:
-       mov       rax,rsi
-       add       rsp,20
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-M01_L04:
-       mov       rax,rdx
-       add       rsp,20
+M01_L07:
+       cmp       [rcx],cl
+       mov       edx,3
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FBCBAE0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FBCBAE0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FBCBAE0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
        ret
-; Total bytes of code 129
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5D3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,1ECCBC02028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       mov       rdx,2432A452C80
+       mov       rdx,14925800CA8
        mov       rdx,[rdx]
-       mov       r8,2432A452C88
+       mov       r8,14925800CB0
        mov       r8,[r8]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
+       call      qword ptr [7FFF8F879840]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
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
        push      rdi
        push      rsi
-       push      rbp
        push      rbx
-       sub       rsp,28
+       sub       rsp,30
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        mov       rcx,rsi
        test      rcx,rcx
-       je        near ptr M01_L06
-       cmp       dword ptr [rcx+8],0
-       je        near ptr M01_L06
+       je        short M01_L00
        xor       eax,eax
-M01_L00:
+       cmp       dword ptr [rcx+8],0
+       sete      al
        test      eax,eax
        sete      al
        movzx     eax,al
-       test      eax,eax
+       cmp       dword ptr [rcx+8],0
        jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jmp       short M01_L01
+M01_L00:
+       xor       eax,eax
+M01_L01:
+       test      eax,eax
+       jne       near ptr M01_L02
+       call      qword ptr [7FFF8F8E7C30]
        mov       rsi,rax
        mov       ecx,301
-       mov       rdx,7FFF90F7BA68
+       mov       rdx,7FFF8F84B520
        call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rdi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L02:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rsi,rax
        mov       rcx,rdi
        test      rcx,rcx
-       je        near ptr M01_L07
-       cmp       dword ptr [rcx+8],0
-       je        near ptr M01_L07
+       je        short M01_L03
        xor       eax,eax
-M01_L02:
+       cmp       dword ptr [rcx+8],0
+       sete      al
        test      eax,eax
        sete      al
        movzx     eax,al
+       cmp       dword ptr [rcx+8],0
+       jne       short M01_L04
+       jmp       short M01_L04
+M01_L03:
+       xor       eax,eax
+M01_L04:
        test      eax,eax
-       jne       short M01_L03
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       near ptr M01_L05
+       call      qword ptr [7FFF8F8E7C30]
        mov       rdi,rax
        mov       ecx,0A30
-       mov       rdx,7FFF90F7BA68
+       mov       rdx,7FFF8F84B520
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
        call      CORINFO_HELP_STRCNS
+       mov       rcx,rbx
+       mov       r9,rsi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
        mov       rdx,rax
        mov       rcx,rdi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L03:
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L05:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rdi,rax
        mov       rcx,rbx
        test      rcx,rcx
-       je        near ptr M01_L08
-       cmp       dword ptr [rcx+8],0
-       je        near ptr M01_L08
+       je        short M01_L06
        xor       eax,eax
-M01_L04:
+       cmp       dword ptr [rcx+8],0
+       sete      al
        test      eax,eax
        sete      al
        movzx     eax,al
+       cmp       dword ptr [rcx+8],0
+       jne       short M01_L07
+       jmp       short M01_L07
+M01_L06:
+       xor       eax,eax
+M01_L07:
        test      eax,eax
-       jne       short M01_L05
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
+       jne       near ptr M01_L08
+       call      qword ptr [7FFF8F8E7C30]
+       mov       rbx,rax
        mov       ecx,0A3C
-       mov       rdx,7FFF90F7BA68
+       mov       rdx,7FFF8F84B520
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
        call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L05:
-       cmp       [rcx],ecx
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8E7810]
+       mov       rdx,rax
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+M01_L08:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rbx,rax
        mov       dword ptr [rsp+20],4
-       mov       ebp,[rsi+8]
-       mov       r9d,ebp
+       mov       r9d,[rsi+8]
        mov       rcx,rsi
        mov       rdx,rdi
        xor       r8d,r8d
-       call      System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
+       call      qword ptr [7FFF8F5F36F0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
        mov       edi,eax
        mov       dword ptr [rsp+20],4
-       mov       r9d,ebp
+       mov       r9d,[rsi+8]
        mov       rcx,rsi
        mov       rdx,rbx
        xor       r8d,r8d
-       call      System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
+       call      qword ptr [7FFF8F5F36F0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
        mov       r8d,eax
        sub       r8d,edi
        mov       rcx,rsi
        mov       edx,edi
-       add       rsp,28
+       add       rsp,30
        pop       rbx
-       pop       rbp
        pop       rsi
        pop       rdi
-       jmp       near ptr System.String.Substring(Int32, Int32)
-M01_L06:
-       mov       eax,1
-       jmp       near ptr M01_L00
-M01_L07:
-       mov       eax,1
-       jmp       near ptr M01_L02
-M01_L08:
-       mov       eax,1
-       jmp       near ptr M01_L04
-; Total bytes of code 399
+       jmp       qword ptr [7FFF8F5F3360]; System.String.Substring(Int32, Int32)
+; Total bytes of code 759
```
**Diff for FromDeflateStringAsync method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
+       call      qword ptr [7FFF8FBD53D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__18 ByRef)
        mov       rax,[rsp+30]
        test      rax,rax
        je        short M00_L01
        add       rsp,58
        ret
 M00_L01:
        lea       rcx,[rsp+30]
-       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
+       call      qword ptr [7FFF8FBA1330]
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
+       jmp       qword ptr [7FFF8FBD50C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
-       mov       rcx,7FFF90DA4938
-       mov       edx,2BD
+       cmp       [rsi],sil
+       mov       rcx,7FFF8F4B4C10
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
+       call      qword ptr [7FFF8FBD52A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18.MoveNext()
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
+       call      qword ptr [7FFF8FB6D708]
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
+       call      qword ptr [7FFF8F5E7210]; System.Threading.Thread.InitializeCurrentThread()
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
+       call      qword ptr [7FFF8FB6D708]
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
+       call      qword ptr [7FFF8F779AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
 M04_L00:
        mov       rcx,rsi
-       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
+       call      qword ptr [7FFF8F779270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
        mov       ecx,[rsi+34]
        and       ecx,1600000
        cmp       ecx,1000000
-       jne       short M04_L02
+       je        short M04_L01
+       mov       rcx,rsi
+       call      qword ptr [7FFF8FBD50D8]
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
+       call      qword ptr [7FFF8FBE53D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__19 ByRef)
        mov       rax,[rsp+30]
        test      rax,rax
        je        short M00_L01
        add       rsp,58
        ret
 M00_L01:
        lea       rcx,[rsp+30]
-       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
+       call      qword ptr [7FFF8FBB1330]
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
+       jmp       qword ptr [7FFF8FBE50C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
-       mov       rcx,7FFF90DA4938
-       mov       edx,2BD
+       cmp       [rsi],sil
+       mov       rcx,7FFF8F4C4C10
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
+       call      qword ptr [7FFF8FBE52A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19.MoveNext()
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
+       call      qword ptr [7FFF8FB7D708]
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
+       call      qword ptr [7FFF8F5F7210]; System.Threading.Thread.InitializeCurrentThread()
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
+       call      qword ptr [7FFF8FB7D708]
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
+       call      qword ptr [7FFF8F789AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
 M04_L00:
        mov       rcx,rsi
-       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
+       call      qword ptr [7FFF8F789270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
        mov       ecx,[rsi+34]
        and       ecx,1600000
        cmp       ecx,1000000
-       jne       short M04_L02
+       je        short M04_L01
+       mov       rcx,rsi
+       call      qword ptr [7FFF8FBE50D8]
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+28]
        test      rcx,rcx
        je        short M00_L00
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        setg      cl
-       movzx     ecx,cl
        jmp       short M00_L01
 M00_L00:
        xor       ecx,ecx
 M00_L01:
        mov       [rsp+28],cl
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBF3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 68
+; Total bytes of code 69
 ; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        push      r15
        push      r14
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
+       sub       rsp,28
        mov       rsi,rcx
        mov       edi,edx
        mov       ebx,[rsi+8]
        lea       ebp,[rbx-1]
        mov       r14d,ebp
        xor       r15d,r15d
        test      dil,1
        je        short M01_L03
        xor       r15d,r15d
        test      ebx,ebx
        jle       short M01_L03
 M01_L00:
-       movsxd    rcx,r15d
+       mov       ecx,r15d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
        jae       short M01_L01
-       cmp       ecx,100
-       jae       near ptr M01_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     r12b
-       movzx     r12d,r12b
-       test      r12d,r12d
        je        short M01_L03
        jmp       short M01_L02
 M01_L01:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     r12d,al
-       test      r12d,r12d
+       call      qword ptr [7FFF8FBFBA68]
+       test      eax,eax
        je        short M01_L03
 M01_L02:
        inc       r15d
        inc       r15d
        cmp       ebx,r15d
        jg        short M01_L00
 M01_L03:
        test      dil,2
-       je        short M01_L07
+       je        near ptr M01_L10
        mov       r14d,ebp
        cmp       r14d,r15d
+       jl        near ptr M01_L10
+       test      r14d,r14d
+       jl        short M01_L07
+       test      r15d,r15d
        jl        short M01_L07
+       cmp       ebx,r14d
+       jle       short M01_L07
 M01_L04:
-       cmp       r14d,ebx
-       jae       near ptr M01_L11
-       movsxd    rcx,r14d
+       mov       ecx,r14d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
        jae       short M01_L05
-       cmp       ecx,100
-       jae       near ptr M01_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     dil
-       movzx     edi,dil
-       test      edi,edi
-       je        short M01_L07
+       je        short M01_L10
        jmp       short M01_L06
 M01_L05:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     edi,al
-       test      edi,edi
-       je        short M01_L07
+       call      qword ptr [7FFF8FBFBA68]
+       test      eax,eax
+       je        short M01_L10
 M01_L06:
        dec       r14d
        cmp       r14d,r15d
        jge       short M01_L04
+       jmp       short M01_L10
 M01_L07:
-       sub       r14d,r15d
-       lea       ecx,[r14+1]
-       cmp       ebx,ecx
-       jne       short M01_L09
-       mov       rax,rsi
+       cmp       r14d,ebx
+       jae       short M01_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M01_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M01_L10
+       jmp       short M01_L09
 M01_L08:
-       add       rsp,20
+       call      qword ptr [7FFF8FBFBA68]
+       test      eax,eax
+       je        short M01_L10
+M01_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M01_L07
+M01_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M01_L12
+       mov       rax,rsi
+M01_L11:
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r14
        pop       r15
        ret
-M01_L09:
-       test      ecx,ecx
-       je        short M01_L10
-       call      System.String.FastAllocateString(Int32)
-       mov       rbx,rax
-       mov       r8d,[rbx+8]
-       lea       rcx,[rbx+0C]
-       lea       rdx,[rsi+0C]
-       mov       eax,r15d
-       lea       rdx,[rdx+rax*2]
-       add       r8,r8
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
-       mov       rax,rbx
-       jmp       short M01_L08
-M01_L10:
-       mov       rax,1A5569B3020
+M01_L12:
+       test      r8d,r8d
+       je        short M01_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F603390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M01_L11
+M01_L13:
+       mov       rax,21E78802028
        mov       rax,[rax]
-       jmp       short M01_L08
-M01_L11:
+       jmp       short M01_L11
+M01_L14:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 323
+; Total bytes of code 318
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for HasWhitespace method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rcx,[rsi+28]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
+       call      qword ptr [7FFF8F889948]; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBF5318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 44
+; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
        push      rdi
        push      rsi
-       push      rbp
        push      rbx
-       sub       rsp,28
+       sub       rsp,30
        mov       rsi,rcx
        mov       rcx,rsi
        test      rcx,rcx
        je        short M01_L00
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L00
        xor       eax,eax
-       jmp       short M01_L01
-M01_L00:
-       mov       eax,1
-M01_L01:
+       cmp       dword ptr [rcx+8],0
+       sete      al
        test      eax,eax
        sete      al
        movzx     eax,al
+       cmp       dword ptr [rcx+8],0
+       jne       short M01_L01
+       jmp       short M01_L01
+M01_L00:
+       xor       eax,eax
+M01_L01:
        test      eax,eax
-       jne       short M01_L02
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       near ptr M01_L02
+       call      qword ptr [7FFF8F8F7C30]
        mov       rsi,rax
        mov       ecx,301
-       mov       rdx,7FFF90FABA68
+       mov       rdx,7FFF8F85B520
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
        call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rdi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
 M01_L02:
-       cmp       [rcx],ecx
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rsi,rax
        xor       edi,edi
        mov       ebx,[rsi+8]
        test      ebx,ebx
        jle       short M01_L06
 M01_L03:
-       movsxd    rcx,edi
+       mov       ecx,edi
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
        jae       short M01_L04
-       cmp       ecx,100
-       jae       short M01_L09
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     bpl
-       movzx     ebp,bpl
-       test      ebp,ebp
        jne       short M01_L05
        jmp       short M01_L07
 M01_L04:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     ebp,al
-       test      ebp,ebp
+       call      qword ptr [7FFF8FBFD0F0]
+       test      eax,eax
        je        short M01_L07
 M01_L05:
        add       edi,1
        add       edi,1
        jo        short M01_L08
        cmp       ebx,edi
        jg        short M01_L03
 M01_L06:
        mov       eax,1
-       add       rsp,28
+       add       rsp,30
        pop       rbx
-       pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L07:
        xor       eax,eax
-       add       rsp,28
+       add       rsp,30
        pop       rbx
-       pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L08:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M01_L09:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
-; Total bytes of code 224
+; Total bytes of code 323
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for Indent method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
+       call      qword ptr [7FFF8F889960]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FC553F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 73
+; Total bytes of code 75
 ; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,38
        lea       rbp,[rsp+60]
        mov       [rbp-40],rsp
        mov       rbx,rcx
        mov       esi,edx
        mov       edi,r8d
-       mov       rcx,7FFF90FAC210
-       mov       edx,2D
-       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,14850598448
-       mov       rcx,[rcx]
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
-       call      qword ptr [rax+20]
+       mov       rcx,2179A8074E8
+       mov       r14,[rcx]
+       mov       rcx,r14
+       call      qword ptr [7FFF8FAC5588]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
        mov       rdx,rax
        mov       [rbp-30],rdx
        test      esi,esi
        jne       short M01_L00
-       mov       rcx,rdx
-       mov       rdx,rbx
-       cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
-       mov       rdx,[rbp-30]
+       cmp       [rdx],dl
+       test      rbx,rbx
+       je        short M01_L00
+       mov       r8d,[rbx+8]
+       lea       rdx,[rbx+0C]
+       mov       rcx,[rbp-30]
+       call      qword ptr [7FFF8F7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
 M01_L00:
-       mov       r14d,1
-       jmp       short M01_L03
+       mov       rdx,[rbp-30]
+       mov       r15d,1
+       jmp       short M01_L04
 M01_L01:
        mov       ecx,[rdx+18]
-       mov       eax,ecx
-       mov       r8,[rdx+8]
-       mov       r9d,[r8+8]
-       cmp       r9d,eax
-       jbe       short M01_L08
-       movsxd    rax,eax
-       mov       [r8+rax*2+10],di
+       mov       r8d,ecx
+       mov       rax,[rdx+8]
+       mov       r9d,[rax+8]
+       cmp       r9d,r8d
+       jbe       short M01_L02
+       mov       r8d,r8d
+       mov       [rax+r8*2+10],di
        inc       ecx
        mov       [rdx+18],ecx
+       jmp       short M01_L03
 M01_L02:
-       add       r14d,1
-       jo        short M01_L07
+       movzx     edx,di
+       mov       rcx,[rbp-30]
+       mov       r8d,1
+       call      qword ptr [7FFF8F7FB258]
 M01_L03:
-       mov       ecx,esi
-       test      ecx,ecx
-       jge       short M01_L04
-       mov       ecx,esi
-       neg       ecx
-       test      ecx,ecx
-       jl        short M01_L06
+       add       r15d,1
+       jo        short M01_L08
+       mov       rdx,[rbp-30]
 M01_L04:
-       cmp       r14d,ecx
+       mov       eax,esi
+       test      eax,eax
+       jl        short M01_L07
+M01_L05:
+       cmp       r15d,eax
        jle       short M01_L01
        test      esi,esi
-       jle       short M01_L05
-       mov       rcx,rdx
-       mov       rdx,rbx
-       cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
+       jle       short M01_L06
+       cmp       [rdx],dl
+       test      rbx,rbx
+       je        short M01_L06
+       mov       r8d,[rbx+8]
+       lea       rdx,[rbx+0C]
+       mov       rcx,[rbp-30]
+       call      qword ptr [7FFF8F7FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
+M01_L06:
        mov       rdx,[rbp-30]
-M01_L05:
        mov       rcx,rdx
        cmp       [rcx],ecx
-       call      qword ptr [7FFF90F4AF70]; System.Text.StringBuilder.ToString()
-       mov       r15,rax
-       jmp       short M01_L09
-M01_L06:
-       call      System.Math.ThrowAbsOverflow()
-       int       3
+       call      qword ptr [7FFF8F7DD350]; System.Text.StringBuilder.ToString()
+       mov       rsi,rax
+       jmp       short M01_L10
 M01_L07:
-       call      CORINFO_HELP_OVERFLOW
+       mov       eax,esi
+       neg       eax
+       js        short M01_L09
+       jmp       short M01_L05
 M01_L08:
-       movzx     edx,di
-       mov       rcx,[rbp-30]
-       mov       r8d,1
-       call      System.Text.StringBuilder.Append(Char, Int32)
-       mov       rdx,[rbp-30]
-       jmp       short M01_L02
+       call      CORINFO_HELP_OVERFLOW
 M01_L09:
-       mov       rcx,14850598448
-       mov       rcx,[rcx]
+       call      qword ptr [7FFF8FA37330]
+       int       3
+M01_L10:
+       mov       rcx,r14
        mov       rdx,[rbp-30]
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
-       call      qword ptr [rax+28]
-       mov       rax,r15
+       call      qword ptr [7FFF8FAC5590]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
+       mov       rax,rsi
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbp,[rcx+20]
        mov       [rsp+20],rbp
        lea       rbp,[rbp+60]
-       mov       rcx,7FFF90FAC210
-       mov       edx,2D
-       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,14850598448
-       mov       rcx,[rcx]
+       mov       rcx,2179A8074E8
+       mov       r14,[rcx]
+       mov       rcx,r14
        mov       rdx,[rbp-30]
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
-       call      qword ptr [rax+28]
+       call      qword ptr [7FFF8FAC5590]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
        nop
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 366
+; Total bytes of code 337
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        movzx     ecx,word ptr [rsi+1F0]
        cmp       ecx,100
-       jae       short M00_L01
+       jae       short M00_L00
        add       ecx,0FFFFFFD0
+       xor       edi,edi
        cmp       ecx,9
        setbe     dil
-       movzx     edi,dil
+       jmp       short M00_L01
 M00_L00:
+       call      qword ptr [7FFF8FBED258]
+       xor       edi,edi
+       cmp       eax,8
+       sete      dil
+M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBE5318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-M00_L01:
-       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
-       cmp       eax,8
-       sete      dil
-       movzx     edi,dil
-       jmp       short M00_L00
-; Total bytes of code 85
+; Total bytes of code 83
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
-**Method was not JITted yet.**
-System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
```
**Diff for IsAsciiLetter method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        movzx     ecx,word ptr [rsi+1F0]
        cmp       ecx,7F
        ja        short M00_L01
        cmp       ecx,100
        jae       short M00_L02
-       movsxd    rcx,ecx
-       mov       rdx,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rdx,7FFFEBA8D860
+       xor       edi,edi
        test      byte ptr [rcx+rdx],60
        setne     dil
-       movzx     edi,dil
 M00_L00:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBF3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 M00_L01:
-       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
+       call      qword ptr [7FFF8FBFBBD0]
+       xor       edi,edi
        cmp       eax,4
        setbe     dil
-       movzx     edi,dil
        jmp       short M00_L00
 M00_L02:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 107
+; Total bytes of code 104
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
-**Method was not JITted yet.**
-System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
```
**Diff for IsAsciiLetterOrDigit method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
-       push      rdi
        push      rsi
-       sub       rsp,28
+       sub       rsp,30
        mov       rsi,rcx
        movzx     ecx,word ptr [rsi+1F0]
        cmp       ecx,100
-       jae       short M00_L02
-       cmp       ecx,100
-       jae       short M00_L05
-       movsxd    rcx,ecx
-       mov       rdx,7FFFEFF31478
+       jae       short M00_L03
+       mov       ecx,ecx
+       mov       rdx,7FFFEBA8D860
        movzx     ecx,byte ptr [rcx+rdx]
        and       ecx,1F
        cmp       ecx,4
        ja        short M00_L01
-       mov       edi,1
+       mov       eax,1
 M00_L00:
-       mov       [rsp+20],dil
+       jmp       short M00_L02
+M00_L01:
+       xor       eax,eax
+       cmp       ecx,8
+       sete      al
+       jmp       short M00_L00
+M00_L02:
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
-       lea       rdx,[rsp+20]
+       lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBC3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
-       add       rsp,28
+       add       rsp,30
        pop       rsi
-       pop       rdi
        ret
-M00_L01:
-       cmp       ecx,8
-       sete      dil
-       movzx     edi,dil
-       jmp       short M00_L00
-M00_L02:
-       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
+M00_L03:
+       call      qword ptr [7FFF8FBCBBD0]
        cmp       eax,4
-       jbe       short M00_L03
+       jbe       short M00_L04
        cmp       eax,8
-       sete      dil
-       movzx     edi,dil
-       jmp       short M00_L04
-M00_L03:
-       mov       edi,1
+       sete      al
+       movzx     eax,al
+       jmp       short M00_L05
 M00_L04:
-       jmp       short M00_L00
+       mov       eax,1
 M00_L05:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
-; Total bytes of code 140
+       jmp       short M00_L02
+; Total bytes of code 121
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
-**Method was not JITted yet.**
-System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
```
**Diff for IsAsciiWhitespace method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        movzx     ecx,word ptr [rsi+1F0]
        cmp       ecx,100
        jae       short M00_L01
-       cmp       ecx,100
-       jae       short M00_L02
-       movsxd    rcx,ecx
-       mov       rdx,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rdx,7FFFEBA8D860
+       xor       edi,edi
        test      byte ptr [rcx+rdx],80
        setne     dil
-       movzx     edi,dil
 M00_L00:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBF5318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 M00_L01:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     edi,al
+       call      qword ptr [7FFF8FBFD0F0]
+       mov       edi,eax
        jmp       short M00_L00
-M00_L02:
-       call      CORINFO_HELP_RNGCHKFAIL
-       int       3
-; Total bytes of code 103
+; Total bytes of code 86
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
-**Method was not JITted yet.**
-System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
```
**Diff for IsCreditCardNumber method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+190]
-       mov       rcx,1CEB76E83E8
+       mov       rcx,264DFC07488
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       movzx     ecx,al
-       mov       [rsp+28],cl
+       call      qword ptr [7FFF8FAB9B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC3DA38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 62
 ; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M01_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M01_L02
        xor       esi,esi
 M01_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAB98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        test      rax,rax
        sete      al
        movzx     eax,al
        add       rsp,40
        pop       rsi
        ret
 M01_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC75900]
        int       3
 M01_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M01_L00
-; Total bytes of code 93
+; Total bytes of code 90
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsCurrencyCode method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+198]
-       mov       rcx,2503B7883F0
+       mov       rcx,1B61F007490
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       movzx     ecx,al
-       mov       [rsp+28],cl
+       call      qword ptr [7FFF8FAB9B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC37720]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 62
 ; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M01_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M01_L02
        xor       esi,esi
 M01_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAB98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        test      rax,rax
        sete      al
        movzx     eax,al
        add       rsp,40
        pop       rsi
        ret
 M01_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC3F5D0]
        int       3
 M01_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M01_L00
-; Total bytes of code 93
+; Total bytes of code 90
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsDomainAddress method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+1A0]
-       mov       rcx,16F0CFC83F8
+       mov       rcx,14CF9C07498
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       movzx     ecx,al
-       mov       [rsp+28],cl
+       call      qword ptr [7FFF8FAA9B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC2B198]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 62
 ; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M01_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M01_L02
        xor       esi,esi
 M01_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAA98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        test      rax,rax
        sete      al
        movzx     eax,al
        add       rsp,40
        pop       rsi
        ret
 M01_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC73060]
        int       3
 M01_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M01_L00
-; Total bytes of code 93
+; Total bytes of code 90
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsEmailAddress method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+1A8]
-       mov       rcx,24740408400
+       mov       rcx,110FE4074A0
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       movzx     ecx,al
-       mov       [rsp+28],cl
+       call      qword ptr [7FFF8FAA9B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC27B28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 62
 ; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M01_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M01_L02
        xor       esi,esi
 M01_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAA98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        test      rax,rax
        sete      al
        movzx     eax,al
        add       rsp,40
        pop       rsi
        ret
 M01_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC2FA50]
        int       3
 M01_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M01_L00
-; Total bytes of code 93
+; Total bytes of code 90
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsEmpty method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
        sub       rsp,28
        xor       edx,edx
        mov       [rsp+20],edx
        mov       rcx,[rcx+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBD3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 32
+; Total bytes of code 33
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsFirstLastName method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+1D0]
-       mov       rcx,1516FEB8408
+       mov       rcx,268EE8074A8
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       movzx     ecx,al
-       mov       [rsp+28],cl
+       call      qword ptr [7FFF8FAD9B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC55EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 62
 ; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M01_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M01_L02
        xor       esi,esi
 M01_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAD98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        test      rax,rax
        sete      al
        movzx     eax,al
        add       rsp,40
        pop       rsi
        ret
 M01_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC5DDB0]
        int       3
 M01_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M01_L00
-; Total bytes of code 93
+; Total bytes of code 90
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsGuid method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
        push      rsi
        sub       rsp,30
        vzeroupper
        mov       rsi,rcx
        vmovupd   xmm0,[rsi+180]
        vmovupd   [rsp+20],xmm0
+       mov       rdx,1E0784009B8
+       mov       rdx,[rdx]
        lea       rcx,[rsp+20]
-       call      System.Guid.ToString()
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F64D9A8]; System.Guid.ToString(System.String, System.IFormatProvider)
        mov       rdx,rax
-       mov       rcx,21458A88410
+       mov       rcx,1E06A4074B0
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       movzx     eax,al
+       call      qword ptr [7FFF8FAD9B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        mov       rdx,[rsi+18]
        mov       [rdx+4C],al
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 74
-; System.Guid.ToString()
-       mov       rdx,21478A82968
-       mov       rdx,[rdx]
-       xor       r8d,r8d
-       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
-; Total bytes of code 21
+; Total bytes of code 87
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
+       call      qword ptr [7FFF8F64D9C0]; System.Guid.TryFormat(System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
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
+       mov       rdx,7FFF8F3B4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F62D030]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8FBEE8]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L09:
+       mov       rcx,1E0784009B8
+       mov       rsi,[rcx]
+       mov       ebx,[rsi+8]
+       cmp       ebx,1
+       je        near ptr M01_L00
+M01_L10:
+       mov       rcx,offset MT_System.FormatException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rsi,rax
+       mov       ecx,0C32D
+       mov       rdx,7FFF8F3B4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F62D030]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8FBEE8]
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
 ; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M02_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M02_L02
        xor       esi,esi
 M02_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAD98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        test      rax,rax
        sete      al
        movzx     eax,al
        add       rsp,40
        pop       rsi
        ret
 M02_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC5F738]
        int       3
 M02_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M02_L00
-; Total bytes of code 93
+; Total bytes of code 90
```
**Diff for IsISBN method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+1B8]
-       mov       rcx,1BF069A8418
+       mov       rcx,212F60074B8
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       movzx     ecx,al
-       mov       [rsp+28],cl
+       call      qword ptr [7FFF8FAB9B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC37438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 62
 ; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M01_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M01_L02
        xor       esi,esi
 M01_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAB98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        test      rax,rax
        sete      al
        movzx     eax,al
        add       rsp,40
        pop       rsi
        ret
 M01_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC3F300]
        int       3
 M01_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M01_L00
-; Total bytes of code 93
+; Total bytes of code 90
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsMacAddress method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
        push      rdi
        push      rsi
        sub       rsp,48
        mov       rsi,rcx
-       mov       rcx,214DD028420
+       mov       rcx,21583C074C0
        mov       rcx,[rcx]
-       mov       rdx,214FD022C80
+       mov       rdx,2158DC00CA8
        mov       r9,[rdx]
-       test      byte ptr [rcx+48],40
+       test      byte ptr [rcx+40],40
        jne       short M00_L01
        xor       edi,edi
 M00_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       dword ptr [rsp+28],11
        mov       [rsp+30],edi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAD98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
+       xor       ecx,ecx
        test      rax,rax
        sete      cl
-       movzx     ecx,cl
        mov       [rsp+40],cl
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+40]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC57168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,48
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       edi,11
        jmp       short M00_L00
-; Total bytes of code 121
-; System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+; Total bytes of code 117
+; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,68
-       lea       rbp,[rsp+0A0]
+       sub       rsp,48
+       lea       rbp,[rsp+80]
+       xor       eax,eax
+       mov       [rbp-48],rax
        mov       [rbp-58],rsp
        mov       [rbp+10],rcx
        mov       edi,edx
        mov       ebx,r8d
        mov       rsi,r9
        mov       r14d,[rbp+30]
        mov       r15d,[rbp+38]
        mov       r12d,[rbp+40]
-       mov       edx,[rsi+8]
-       cmp       edx,r12d
-       jb        near ptr M01_L06
-       cmp       edx,r15d
-       jb        near ptr M01_L07
-       cmp       [rcx],ecx
-       lea       rdx,[rcx+38]
-       mov       rcx,rdx
+       mov       r13d,[rsi+8]
+       cmp       r13d,r12d
+       jb        near ptr M01_L16
+       cmp       r13d,r15d
+       jb        near ptr M01_L17
+       cmp       [rcx],cl
+       add       rcx,38
        xor       edx,edx
        call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
        test      rax,rax
-       je        short M01_L02
+       je        near ptr M01_L13
 M01_L00:
        mov       rdx,rax
-M01_L01:
-       mov       [rbp-40],rdx
-       add       r15d,r14d
-       mov       [rsp+20],r15d
-       mov       [rsp+28],r12d
-       mov       [rsp+30],ebx
-       movzx     ecx,dil
-       mov       [rsp+38],ecx
+       mov       [rbp-50],rdx
        mov       rcx,[rbp+10]
-       mov       r8,[rcx+58]
-       mov       [rsp+40],r8
-       mov       rcx,rdx
-       mov       rdx,[rbp+10]
-       mov       r8,rsi
-       mov       r9d,r14d
+       mov       rdx,[rcx+48]
+       mov       rcx,[rbp-50]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.RegexRunner.Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean, System.TimeSpan)
-       mov       rsi,rax
-       mov       rdx,[rbp+10]
-       lea       rcx,[rdx+38]
-       mov       rdx,[rbp-40]
+       call      qword ptr [7FFF8FC15858]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
+       mov       rcx,[rbp-50]
+       lea       rcx,[rcx+8]
+       mov       rdx,rsi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       ecx,r14d
+       mov       edx,r15d
+       add       rcx,rdx
+       mov       edx,r13d
+       cmp       rcx,rdx
+       ja        near ptr M01_L10
+       mov       ecx,r14d
+       lea       r13,[rsi+rcx*2+0C]
+       mov       rcx,[rbp-50]
+       mov       rdx,rcx
+       mov       rax,[rbp+10]
+       mov       r8,rax
+       mov       [rbp-48],r13
+       mov       [rbp-40],r15d
+       mov       [rsp+20],edi
+       mov       rcx,rdx
+       mov       rdx,r8
+       lea       r8,[rbp-48]
+       mov       r9d,r12d
+       sub       r9d,r14d
+       call      qword ptr [7FFF8FC15840]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
+       test      ebx,ebx
+       je        near ptr M01_L08
+M01_L01:
+       mov       rcx,offset MT_System.Text.RegularExpressions.CompiledRegexRunner
+       mov       rbx,[rbp-50]
+       cmp       [rbx],rcx
+       jne       near ptr M01_L06
+       mov       rax,[rbx+70]
+       mov       rdx,rbx
+       mov       [rbp-48],r13
+       mov       [rbp-40],r15d
+       mov       rcx,[rax+8]
+       lea       r8,[rbp-48]
+       call      qword ptr [rax+18]
+M01_L02:
+       mov       r15,[rbx+28]
+       mov       rdx,[r15+50]
+       cmp       dword ptr [rdx+8],0
+       jbe       short M01_L03
+       cmp       dword ptr [rdx+10],0
+       jg        short M01_L04
+       xor       ecx,ecx
+       mov       [r15+8],rcx
+       mov       rcx,7FFF8FAE4068
+       mov       edx,27
+       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
+       mov       rdx,21583C094B8
+       mov       r15,[rdx]
+       jmp       short M01_L05
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+M01_L04:
+       test      edi,edi
+       je        short M01_L07
+       lea       rcx,[r15+8]
+       mov       rdx,rsi
+       call      CORINFO_HELP_ASSIGN_REF
+       xor       edx,edx
+       mov       [rbx+28],rdx
+       mov       edx,[rbx+4C]
+       mov       rcx,r15
+       mov       r8d,r14d
+       mov       r9d,edi
+       call      qword ptr [7FFF8FC55E28]
+M01_L05:
+       jmp       near ptr M01_L12
+M01_L06:
+       mov       rcx,rbx
+       mov       [rbp-48],r13
+       mov       [rbp-40],r15d
+       lea       rdx,[rbp-48]
+       mov       rax,[rcx]
+       mov       rax,[rax+40]
+       call      qword ptr [rax+20]
+       jmp       near ptr M01_L02
+M01_L07:
+       xor       ecx,ecx
+       mov       [r15+8],rcx
+       xor       r15d,r15d
+       jmp       short M01_L05
+M01_L08:
+       mov       ecx,r15d
+       mov       eax,1
+       mov       r8,[rbp+10]
+       test      byte ptr [r8+40],40
+       je        short M01_L09
+       xor       ecx,ecx
+       mov       eax,0FFFFFFFF
+M01_L09:
+       mov       rbx,[rbp-50]
+       cmp       [rbx+48],ecx
+       jne       short M01_L11
+       mov       rcx,7FFF8FAE4068
+       mov       edx,27
+       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
+       mov       rdx,21583C094B8
+       mov       r15,[rdx]
+       jmp       short M01_L12
+M01_L10:
+       mov       ecx,21
+       call      qword ptr [7FFF8F7C77E0]
+       int       3
+M01_L11:
+       add       [rbx+4C],eax
+       jmp       near ptr M01_L01
+M01_L12:
+       xor       edx,edx
+       mov       [rbx+8],rdx
+       mov       rax,[rbp+10]
+       lea       rcx,[rax+38]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rax,rsi
-       add       rsp,68
+       mov       rax,r15
+       add       rsp,48
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-M01_L02:
-       mov       rdx,[rbp+10]
-       mov       rcx,[rdx+10]
-       test      rcx,rcx
-       jne       short M01_L04
-       mov       r13,[rdx+40]
-       test      dword ptr [rdx+48],200
-       jne       short M01_L05
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
-       mov       [rbp-48],rax
-M01_L03:
-       mov       rcx,offset MT_System.Text.RegularExpressions.RegexInterpreter
-       call      CORINFO_HELP_NEWSFAST
-       mov       rdx,rax
-       mov       [rbp-50],rdx
-       mov       rcx,rdx
-       mov       rdx,r13
-       mov       r8,[rbp-48]
-       call      System.Text.RegularExpressions.RegexInterpreter..ctor(System.Text.RegularExpressions.RegexCode, System.Globalization.CultureInfo)
-       mov       r13,[rbp-50]
-       mov       rdx,r13
-       jmp       near ptr M01_L01
-M01_L04:
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
+M01_L13:
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+10]
+       mov       rdx,[rax]
+       mov       r8,offset MT_System.Text.RegularExpressions.RegexInterpreterFactory
+       cmp       rdx,r8
+       jne       short M01_L14
+       mov       rcx,rax
+       call      qword ptr [7FFF8FBDB998]; Precode of System.Text.RegularExpressions.RegexInterpreterFactory.CreateInstance()
+       jmp       short M01_L15
+M01_L14:
+       mov       rcx,rax
+       mov       rax,[rdx+40]
        call      qword ptr [rax+20]
+M01_L15:
        jmp       near ptr M01_L00
-M01_L05:
-       mov       rcx,214DD021568
-       mov       r8,[rcx]
-       mov       rcx,r8
-       mov       [rbp-48],rcx
-       jmp       short M01_L03
-M01_L06:
-       mov       ecx,0F
+M01_L16:
+       mov       ecx,0E
        xor       edx,edx
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
+       call      qword ptr [7FFF8FC5F048]
        int       3
-M01_L07:
+M01_L17:
        mov       ecx,8
        mov       edx,2
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
+       call      qword ptr [7FFF8FC5F048]
        int       3
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,58
-       mov       rbp,[rcx+48]
-       mov       [rsp+48],rbp
-       lea       rbp,[rbp+0A0]
-       mov       rdx,[rbp+10]
-       lea       rcx,[rdx+38]
-       mov       rdx,[rbp-40]
+       sub       rsp,38
+       mov       rbp,[rcx+28]
+       mov       [rsp+28],rbp
+       lea       rbp,[rbp+80]
+       xor       edx,edx
+       mov       rbx,[rbp-50]
+       mov       [rbx+8],rdx
+       mov       r8,[rbp+10]
+       lea       rcx,[r8+38]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        nop
-       add       rsp,58
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 416
+; Total bytes of code 722
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsNotEmpty method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
        sub       rsp,28
        mov       dword ptr [rsp+20],1
        mov       rcx,[rcx+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FBF3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 34
+; Total bytes of code 35
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsOneToSevenAlpha method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+1C8]
-       mov       rcx,23BF45B8428
+       mov       rcx,222260074C8
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       movzx     ecx,al
-       mov       [rsp+28],cl
+       call      qword ptr [7FFF8FAD9B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC55EB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 62
 ; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M01_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M01_L02
        xor       esi,esi
 M01_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAD98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        test      rax,rax
        sete      al
        movzx     eax,al
        add       rsp,40
        pop       rsi
        ret
 M01_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC5DD98]
        int       3
 M01_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M01_L00
-; Total bytes of code 93
+; Total bytes of code 90
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsScientific method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
        push      rdi
        push      rsi
        sub       rsp,48
        mov       rsi,rcx
-       mov       rcx,24059A28438
+       mov       rcx,2209DC074D8
        mov       rcx,[rcx]
-       mov       rdx,24079A22C80
+       mov       rdx,220A5C00CA8
        mov       r9,[rdx]
-       test      byte ptr [rcx+48],40
+       test      byte ptr [rcx+40],40
        jne       short M00_L01
        xor       edi,edi
 M00_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       dword ptr [rsp+28],0A
        mov       [rsp+30],edi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAA98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
+       xor       ecx,ecx
        test      rax,rax
        sete      cl
-       movzx     ecx,cl
        mov       [rsp+40],cl
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+40]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC27438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,48
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       edi,0A
        jmp       short M00_L00
-; Total bytes of code 121
-; System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+; Total bytes of code 117
+; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,68
-       lea       rbp,[rsp+0A0]
+       sub       rsp,48
+       lea       rbp,[rsp+80]
+       xor       eax,eax
+       mov       [rbp-48],rax
        mov       [rbp-58],rsp
        mov       [rbp+10],rcx
        mov       edi,edx
        mov       ebx,r8d
        mov       rsi,r9
        mov       r14d,[rbp+30]
        mov       r15d,[rbp+38]
        mov       r12d,[rbp+40]
-       mov       edx,[rsi+8]
-       cmp       edx,r12d
-       jb        near ptr M01_L06
-       cmp       edx,r15d
-       jb        near ptr M01_L07
-       cmp       [rcx],ecx
-       lea       rdx,[rcx+38]
-       mov       rcx,rdx
+       mov       r13d,[rsi+8]
+       cmp       r13d,r12d
+       jb        near ptr M01_L16
+       cmp       r13d,r15d
+       jb        near ptr M01_L17
+       cmp       [rcx],cl
+       add       rcx,38
        xor       edx,edx
        call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
        test      rax,rax
-       je        short M01_L02
+       je        near ptr M01_L13
 M01_L00:
        mov       rdx,rax
-M01_L01:
-       mov       [rbp-40],rdx
-       add       r15d,r14d
-       mov       [rsp+20],r15d
-       mov       [rsp+28],r12d
-       mov       [rsp+30],ebx
-       movzx     ecx,dil
-       mov       [rsp+38],ecx
+       mov       [rbp-50],rdx
        mov       rcx,[rbp+10]
-       mov       r8,[rcx+58]
-       mov       [rsp+40],r8
-       mov       rcx,rdx
-       mov       rdx,[rbp+10]
-       mov       r8,rsi
-       mov       r9d,r14d
+       mov       rdx,[rcx+48]
+       mov       rcx,[rbp-50]
        cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.RegexRunner.Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean, System.TimeSpan)
-       mov       rsi,rax
-       mov       rdx,[rbp+10]
-       lea       rcx,[rdx+38]
-       mov       rdx,[rbp-40]
+       call      qword ptr [7FFF8FBE5858]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
+       mov       rcx,[rbp-50]
+       lea       rcx,[rcx+8]
+       mov       rdx,rsi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       ecx,r14d
+       mov       edx,r15d
+       add       rcx,rdx
+       mov       edx,r13d
+       cmp       rcx,rdx
+       ja        near ptr M01_L10
+       mov       ecx,r14d
+       lea       r13,[rsi+rcx*2+0C]
+       mov       rcx,[rbp-50]
+       mov       rdx,rcx
+       mov       rax,[rbp+10]
+       mov       r8,rax
+       mov       [rbp-48],r13
+       mov       [rbp-40],r15d
+       mov       [rsp+20],edi
+       mov       rcx,rdx
+       mov       rdx,r8
+       lea       r8,[rbp-48]
+       mov       r9d,r12d
+       sub       r9d,r14d
+       call      qword ptr [7FFF8FBE5840]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
+       test      ebx,ebx
+       je        near ptr M01_L08
+M01_L01:
+       mov       rcx,offset MT_System.Text.RegularExpressions.CompiledRegexRunner
+       mov       rbx,[rbp-50]
+       cmp       [rbx],rcx
+       jne       short M01_L06
+       mov       rax,[rbx+70]
+       mov       rdx,rbx
+       mov       [rbp-48],r13
+       mov       [rbp-40],r15d
+       mov       rcx,[rax+8]
+       lea       r8,[rbp-48]
+       call      qword ptr [rax+18]
+M01_L02:
+       mov       r15,[rbx+28]
+       mov       rdx,[r15+50]
+       cmp       dword ptr [rdx+8],0
+       jbe       short M01_L03
+       cmp       dword ptr [rdx+10],0
+       jg        short M01_L04
+       xor       edx,edx
+       mov       [r15+8],rdx
+       mov       rdx,220A1C008C0
+       mov       r15,[rdx]
+       jmp       short M01_L05
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+M01_L04:
+       test      edi,edi
+       je        short M01_L07
+       lea       rcx,[r15+8]
+       mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rax,rsi
-       add       rsp,68
+       xor       edx,edx
+       mov       [rbx+28],rdx
+       mov       edx,[rbx+4C]
+       mov       rcx,r15
+       mov       r8d,r14d
+       mov       r9d,edi
+       call      qword ptr [7FFF8FC25E28]
+M01_L05:
+       jmp       short M01_L12
+M01_L06:
+       mov       rcx,rbx
+       mov       [rbp-48],r13
+       mov       [rbp-40],r15d
+       lea       rdx,[rbp-48]
+       mov       rax,[rcx]
+       mov       rax,[rax+40]
+       call      qword ptr [rax+20]
+       jmp       short M01_L02
+M01_L07:
+       xor       edx,edx
+       mov       [r15+8],rdx
+       xor       r15d,r15d
+       jmp       short M01_L05
+M01_L08:
+       mov       edx,r15d
+       mov       ecx,1
+       mov       rax,[rbp+10]
+       test      byte ptr [rax+40],40
+       je        short M01_L09
+       xor       edx,edx
+       mov       ecx,0FFFFFFFF
+M01_L09:
+       mov       rbx,[rbp-50]
+       cmp       [rbx+48],edx
+       jne       short M01_L11
+       mov       rcx,220A1C008C0
+       mov       r15,[rcx]
+       jmp       short M01_L12
+M01_L10:
+       mov       ecx,21
+       call      qword ptr [7FFF8F7977E0]
+       int       3
+M01_L11:
+       add       [rbx+4C],ecx
+       jmp       near ptr M01_L01
+M01_L12:
+       xor       edx,edx
+       mov       [rbx+8],rdx
+       mov       rax,[rbp+10]
+       lea       rcx,[rax+38]
+       mov       rdx,rbx
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rax,r15
+       add       rsp,48
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-M01_L02:
-       mov       rdx,[rbp+10]
-       mov       rcx,[rdx+10]
-       test      rcx,rcx
-       jne       short M01_L04
-       mov       r13,[rdx+40]
-       test      dword ptr [rdx+48],200
-       jne       short M01_L05
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
-       mov       [rbp-48],rax
-M01_L03:
-       mov       rcx,offset MT_System.Text.RegularExpressions.RegexInterpreter
-       call      CORINFO_HELP_NEWSFAST
-       mov       rdx,rax
-       mov       [rbp-50],rdx
-       mov       rcx,rdx
-       mov       rdx,r13
-       mov       r8,[rbp-48]
-       call      System.Text.RegularExpressions.RegexInterpreter..ctor(System.Text.RegularExpressions.RegexCode, System.Globalization.CultureInfo)
-       mov       r13,[rbp-50]
-       mov       rdx,r13
-       jmp       near ptr M01_L01
-M01_L04:
-       mov       rax,[rcx]
-       mov       rax,[rax+40]
+M01_L13:
+       mov       rcx,[rbp+10]
+       mov       rax,[rcx+10]
+       mov       rdx,[rax]
+       mov       r8,offset MT_System.Text.RegularExpressions.RegexInterpreterFactory
+       cmp       rdx,r8
+       jne       short M01_L14
+       mov       rcx,rax
+       call      qword ptr [7FFF8FBAB850]; Precode of System.Text.RegularExpressions.RegexInterpreterFactory.CreateInstance()
+       jmp       short M01_L15
+M01_L14:
+       mov       rcx,rax
+       mov       rax,[rdx+40]
        call      qword ptr [rax+20]
+M01_L15:
        jmp       near ptr M01_L00
-M01_L05:
-       mov       rcx,24059A21568
-       mov       r8,[rcx]
-       mov       rcx,r8
-       mov       [rbp-48],rcx
-       jmp       short M01_L03
-M01_L06:
-       mov       ecx,0F
+M01_L16:
+       mov       ecx,0E
        xor       edx,edx
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
+       call      qword ptr [7FFF8FC2F318]
        int       3
-M01_L07:
+M01_L17:
        mov       ecx,8
        mov       edx,2
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
+       call      qword ptr [7FFF8FC2F318]
        int       3
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,58
-       mov       rbp,[rcx+48]
-       mov       [rsp+48],rbp
-       lea       rbp,[rbp+0A0]
-       mov       rdx,[rbp+10]
-       lea       rcx,[rdx+38]
-       mov       rdx,[rbp-40]
+       sub       rsp,38
+       mov       rbp,[rcx+28]
+       mov       [rsp+28],rbp
+       lea       rbp,[rbp+80]
+       xor       edx,edx
+       mov       rbx,[rbp-50]
+       mov       [rbx+8],rdx
+       mov       rax,[rbp+10]
+       lea       rcx,[rax+38]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        nop
-       add       rsp,58
+       add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 416
+; Total bytes of code 671
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsString method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+28]
-       mov       rcx,20CDA454048
+       mov       rcx,20DFA8074F0
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       movzx     ecx,al
-       mov       [rsp+28],cl
+       call      qword ptr [7FFF8FAB9B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC37B28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 62
+; Total bytes of code 59
 ; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M01_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M01_L02
        xor       esi,esi
 M01_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAB98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        test      rax,rax
        sete      al
        movzx     eax,al
        add       rsp,40
        pop       rsi
        ret
 M01_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC3FCF0]
        int       3
 M01_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M01_L00
-; Total bytes of code 93
+; Total bytes of code 90
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsStringSHA1Hash method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+1B0]
-       mov       rcx,1D133128440
+       mov       rcx,2CB220074E0
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
-       movzx     ecx,al
-       mov       [rsp+28],cl
+       call      qword ptr [7FFF8FAC9B40]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC47888]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 62
 ; System.Text.RegularExpressions.Regex.IsMatch(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M01_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M01_L02
        xor       esi,esi
 M01_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
-       mov       edx,1
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAC98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        test      rax,rax
        sete      al
        movzx     eax,al
        add       rsp,40
        pop       rsi
        ret
 M01_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC4FB70]
        int       3
 M01_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M01_L00
-; Total bytes of code 93
+; Total bytes of code 90
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for IsUrl method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+1A0]
-       mov       rcx,10CF56E8458
+       mov       rcx,29B9DC074F8
        mov       rcx,[rcx]
-       cmp       [rcx],ecx
-       call      System.Text.RegularExpressions.Regex.Match(System.String)
+       call      qword ptr [7FFF8FAC9BE8]; System.Text.RegularExpressions.Regex.Match(System.String)
+       xor       ecx,ecx
        cmp       dword ptr [rax+30],0
        setne     cl
-       movzx     ecx,cl
        mov       [rsp+28],cl
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC4F3D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 72
+; Total bytes of code 71
 ; System.Text.RegularExpressions.Regex.Match(System.String)
        push      rsi
        sub       rsp,40
        test      rdx,rdx
        je        short M01_L01
        mov       eax,[rdx+8]
        mov       r8,rcx
        mov       r9,rdx
-       test      byte ptr [r8+48],40
+       test      byte ptr [r8+40],40
        jne       short M01_L02
        xor       esi,esi
 M01_L00:
        xor       edx,edx
        mov       [rsp+20],edx
        mov       [rsp+28],eax
        mov       [rsp+30],esi
+       mov       edx,2
        mov       r8d,0FFFFFFFF
-       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
+       call      qword ptr [7FFF8FAC98D0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
        nop
        add       rsp,40
        pop       rsi
        ret
 M01_L01:
        mov       ecx,7
-       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
+       call      qword ptr [7FFF8FC872A0]
        int       3
 M01_L02:
        mov       r9,rdx
        mov       esi,[r9+8]
        jmp       short M01_L00
-; Total bytes of code 80
+; Total bytes of code 87
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ReplaceEllipsisWithPeriod method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1D8]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
+       call      qword ptr [7FFF8F879B58]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBE3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 67
 ; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
+       push      rdi
        push      rsi
-       sub       rsp,20
+       push      rbx
+       sub       rsp,30
        mov       rsi,rcx
        mov       rcx,rsi
        test      rcx,rcx
-       je        near ptr M01_L03
-       cmp       dword ptr [rcx+8],0
-       je        near ptr M01_L03
-       xor       eax,eax
-M01_L00:
+       je        short M01_L00
+       mov       eax,[rcx+8]
+       xor       edx,edx
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      dl
+       test      edx,edx
+       sete      dl
+       movzx     edx,dl
        test      eax,eax
        jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jmp       short M01_L01
+M01_L00:
+       xor       edx,edx
+M01_L01:
+       test      edx,edx
+       jne       near ptr M01_L02
+       call      qword ptr [7FFF8F8E7C30]
        mov       rsi,rax
        mov       ecx,301
-       mov       rdx,7FFF90FABA68
+       mov       rdx,7FFF8F84B520
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
        call      CORINFO_HELP_STRCNS
+       mov       rcx,rdi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L02:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rsi,rax
-       mov       rdx,1CB1DE39628
+       mov       rdx,1432BC08688
        mov       rdx,[rdx]
        mov       rcx,rsi
        mov       r8d,5
        cmp       [rcx],ecx
-       call      System.String.EndsWith(System.String, System.StringComparison)
+       call      qword ptr [7FFF8F5F12D0]; System.String.EndsWith(System.String, System.StringComparison)
        test      eax,eax
-       je        short M01_L02
-       mov       r8d,[rsi+8]
-       add       r8d,0FFFFFFFE
-       mov       rcx,rsi
-       xor       edx,edx
-       call      System.String.Substring(Int32, Int32)
-       mov       rsi,rax
-M01_L02:
+       je        short M01_L05
+       mov       ecx,[rsi+8]
+       lea       r8d,[rcx-2]
+       cmp       ecx,r8d
+       jb        short M01_L06
+       test      r8d,r8d
+       jne       short M01_L03
+       mov       rcx,1432BC02028
+       mov       rsi,[rcx]
+       jmp       short M01_L05
+M01_L03:
+       cmp       ecx,r8d
+       jne       short M01_L04
+       jmp       short M01_L05
+M01_L04:
+       mov       ecx,r8d
+       call      System.String.FastAllocateString(Int32)
+       mov       rdi,rax
+       mov       r8d,[rdi+8]
+       lea       rcx,[rdi+0C]
+       lea       rdx,[rsi+0C]
+       add       r8,r8
+       call      qword ptr [7FFF8F6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       mov       rsi,rdi
+M01_L05:
        mov       rax,rsi
-       add       rsp,20
+       add       rsp,30
+       pop       rbx
        pop       rsi
+       pop       rdi
        ret
-M01_L03:
-       mov       eax,1
-       jmp       near ptr M01_L00
-; Total bytes of code 172
+M01_L06:
+       mov       rcx,rsi
+       xor       edx,edx
+       call      qword ptr [7FFF8F5F3378]
+       int       3
+; Total bytes of code 361
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
-       push      rsi
-       sub       rsp,30
-       mov       rsi,rcx
-       mov       rcx,2776BFE2C80
-       mov       rcx,[rcx]
-       mov       rdx,2776BFE2C88
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
-       mov       [rsp+28],al
-       mov       rcx,[rsi+18]
-       lea       rdx,[rsp+28]
-       cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
-       nop
-       add       rsp,30
-       pop       rsi
-       ret
-; Total bytes of code 66
-; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
        push      rdi
        push      rsi
-       sub       rsp,38
+       push      rbx
+       sub       rsp,40
        mov       rsi,rcx
-       mov       rdi,rdx
-       mov       rcx,rsi
-       test      rcx,rcx
-       je        near ptr M01_L04
-       cmp       dword ptr [rcx+8],0
-       je        near ptr M01_L04
-       xor       eax,eax
-M01_L00:
+       mov       rax,2165B400CA8
+       mov       rdi,[rax]
+       mov       rax,2165B400CB0
+       mov       rbx,[rax]
+       mov       rcx,rdi
+       mov       eax,[rcx+8]
        test      eax,eax
        sete      al
        movzx     eax,al
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M00_L00
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rdi,rax
        mov       ecx,301
-       mov       rdx,7FFF90F7BA68
+       mov       rdx,7FFF8F82B520
        call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
-       mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rbx,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rbx
+       mov       r9,rsi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
        mov       rcx,rdi
-       test      rcx,rcx
-       je        near ptr M01_L05
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L05
-       xor       eax,eax
-M01_L02:
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L00:
+       mov       edx,3
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdi,rax
+       mov       rcx,rbx
+       mov       eax,[rcx+8]
        test      eax,eax
        sete      al
        movzx     eax,al
        test      eax,eax
-       jne       short M01_L03
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M00_L01
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rbx,rax
        mov       ecx,0A12
-       mov       rdx,7FFF90F7BA68
+       mov       rdx,7FFF8F82B520
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
        call      CORINFO_HELP_STRCNS
+       mov       rcx,rdi
+       mov       r9,rsi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8C7810]
        mov       rdx,rax
-       mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L03:
-       cmp       [rcx],ecx
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+M00_L01:
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       ecx,[rax+8]
+       call      qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rbx,rax
+       mov       ecx,[rbx+8]
        mov       [rsp+20],ecx
        mov       dword ptr [rsp+28],4
-       mov       rcx,rsi
-       mov       r8,rax
+       mov       rcx,rdi
+       mov       r8,rbx
        xor       edx,edx
        xor       r9d,r9d
-       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
+       call      qword ptr [7FFF8F5D1228]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
+       xor       ecx,ecx
        test      eax,eax
-       sete      al
-       movzx     eax,al
-       add       rsp,38
+       sete      cl
+       mov       [rsp+38],cl
+       mov       rcx,[rsi+18]
+       lea       rdx,[rsp+38]
+       cmp       [rcx],ecx
+       call      qword ptr [7FFF8FBC5360]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       nop
+       add       rsp,40
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
+; Total bytes of code 517
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M01_L00:
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
+       test      rcx,rcx
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
+       test      eax,eax
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
+       test      eax,eax
+       jne       short M01_L03
+       jmp       short M01_L02
+M01_L01:
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8C7C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M01_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M01_L04
+       jmp       short M01_L05
 M01_L04:
-       mov       eax,1
-       jmp       near ptr M01_L00
+       mov       rsi,rdi
 M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7D6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F85B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8C7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8C9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F79D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M01_L07:
+       cmp       [rcx],cl
+       mov       edx,3
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FBCD0F0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FBCD0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FBCD0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       ret
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5D3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,21651402028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
+       push      rbp
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,48
+       lea       rbp,[rsp+80]
+       mov       rsi,rcx
+       mov       ebx,edx
+       mov       rdi,r8
+       mov       r14d,r9d
+       mov       r15d,[rbp+30]
+       mov       r12d,[rbp+38]
+M03_L00:
+       cmp       r12d,5
+       ja        near ptr M03_L10
+       test      rsi,rsi
+       je        near ptr M03_L11
+       test      rdi,rdi
+       je        near ptr M03_L11
+       test      r15d,r15d
+       jl        near ptr M03_L13
+       test      ebx,ebx
+       jl        near ptr M03_L15
+       test      r14d,r14d
+       jl        near ptr M03_L14
+       mov       r13d,[rsi+8]
+       sub       r13d,ebx
+       js        near ptr M03_L18
+       mov       r10d,[rdi+8]
+       sub       r10d,r14d
+       js        near ptr M03_L17
+       test      r15d,r15d
+       je        short M03_L06
+       cmp       rsi,rdi
+       je        short M03_L05
+M03_L01:
+       cmp       r15d,r13d
+       jg        short M03_L08
+       mov       eax,r15d
+M03_L02:
+       mov       r13d,eax
+       cmp       r15d,r10d
+       jg        short M03_L07
+M03_L03:
+       cmp       r12d,4
+       ja        short M03_L04
+       mov       r8d,r12d
+       lea       rcx,[7FFF8F5865D0]
+       mov       ecx,[rcx+r8*4]
+       lea       rdx,[M03_L00]
+       add       rcx,rdx
+       jmp       rcx
+M03_L04:
+       movsxd    r8,ebx
+       lea       rcx,[rsi+r8*2+0C]
+       movsxd    r8,r14d
+       lea       r8,[rdi+r8*2+0C]
+       mov       edx,r13d
+       mov       r9d,r15d
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       jmp       qword ptr [7FFF8FA758E8]
+M03_L05:
+       cmp       ebx,r14d
+       jne       short M03_L01
+M03_L06:
+       xor       eax,eax
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M03_L07:
+       mov       r15d,r10d
+       jmp       short M03_L03
+M03_L08:
+       mov       eax,r13d
+       jmp       short M03_L02
+       mov       r8d,ebx
+       lea       rcx,[rsi+r8*2+0C]
+       mov       r8d,r14d
+       lea       r8,[rdi+r8*2+0C]
+       mov       edx,r13d
+       mov       r9d,r15d
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       jmp       qword ptr [7FFF8F5DF318]; System.SpanHelpers.SequenceCompareTo(Char ByRef, Int32, Char ByRef, Int32)
+M03_L09:
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M03_L10:
+       mov       ecx,1A
+       mov       edx,2A
+       call      qword ptr [7FFF8F797768]
+       int       3
+M03_L11:
+       cmp       rsi,rdi
+       je        short M03_L06
+       test      rsi,rsi
+       je        short M03_L12
        mov       eax,1
-       jmp       short M01_L02
-; Total bytes of code 250
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M03_L12:
+       mov       eax,0FFFFFFFF
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M03_L13:
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       mov       ecx,57
+       mov       rdx,7FFF8F384000
+       call      CORINFO_HELP_STRCNS
+       mov       r14,rax
+       mov       ecx,0A1CF
+       mov       rdx,7FFF8F384000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F5FD030]
+       mov       r8,rax
+       mov       rdx,r14
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F765750]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+M03_L14:
+       mov       rcx,2165B400CC0
+       mov       r15,[rcx]
+       jmp       short M03_L16
+M03_L15:
+       mov       rcx,2165B400CC8
+       mov       r15,[rcx]
+M03_L16:
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       r12,rax
+       mov       ecx,9A9B
+       mov       rdx,7FFF8F384000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F5FD030]
+       mov       r8,rax
+       mov       rdx,r15
+       mov       rcx,r12
+       call      qword ptr [7FFF8F765750]
+       mov       rcx,r12
+       call      CORINFO_HELP_THROW
+M03_L17:
+       mov       rcx,2165B400CC0
+       mov       rsi,[rcx]
+       jmp       short M03_L19
+M03_L18:
+       mov       rcx,2165B400CC8
+       mov       rsi,[rcx]
+M03_L19:
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       mov       ecx,9A9B
+       mov       rdx,7FFF8F384000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F5FD030]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F765750]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+       call      qword ptr [7FFF8F7398A0]; System.Globalization.CultureInfo.get_CurrentCulture()
+       mov       rcx,rax
+       mov       rax,[rax]
+       mov       rax,[rax+48]
+       call      qword ptr [rax+30]
+       mov       rcx,rax
+       mov       [rsp+20],rdi
+       mov       [rsp+28],r14d
+       mov       [rsp+30],r15d
+       and       r12d,1
+       mov       [rsp+38],r12d
+       mov       rdx,rsi
+       mov       r8d,ebx
+       mov       r9d,r13d
+       cmp       [rcx],ecx
+       call      qword ptr [7FFF8FAE3798]
+       jmp       near ptr M03_L09
+       mov       rcx,7FFF8F4A4C10
+       mov       edx,23C
+       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
+       mov       rcx,216514004E0
+       mov       rcx,[rcx]
+       mov       [rsp+20],rdi
+       mov       [rsp+28],r14d
+       mov       [rsp+30],r15d
+       mov       edx,r12d
+       and       edx,1
+       mov       [rsp+38],edx
+       mov       rdx,rsi
+       mov       r8d,ebx
+       mov       r9d,r13d
+       cmp       [rcx],ecx
+       call      qword ptr [7FFF8FAE3798]
+       jmp       near ptr M03_L09
+; Total bytes of code 828
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for StartsWithOrdinalIgnoreCase method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
-       push      rsi
-       sub       rsp,30
-       mov       rsi,rcx
-       mov       rcx,1398E342C80
-       mov       rcx,[rcx]
-       mov       rdx,1398E342C88
-       mov       rdx,[rdx]
-       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
-       mov       [rsp+28],al
-       mov       rcx,[rsi+18]
-       lea       rdx,[rsp+28]
-       cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
-       nop
-       add       rsp,30
-       pop       rsi
-       ret
-; Total bytes of code 66
-; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
        push      rdi
        push      rsi
-       sub       rsp,38
+       push      rbx
+       sub       rsp,40
        mov       rsi,rcx
-       mov       rdi,rdx
-       mov       rcx,rsi
-       test      rcx,rcx
-       je        near ptr M01_L04
-       cmp       dword ptr [rcx+8],0
-       je        near ptr M01_L04
-       xor       eax,eax
-M01_L00:
+       mov       rax,1DC1BC00CA8
+       mov       rdi,[rax]
+       mov       rax,1DC1BC00CB0
+       mov       rbx,[rax]
+       mov       rcx,rdi
+       mov       eax,[rcx+8]
        test      eax,eax
        sete      al
        movzx     eax,al
        test      eax,eax
-       jne       short M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M00_L00
+       call      qword ptr [7FFF8F8E7C30]
+       mov       rdi,rax
        mov       ecx,301
-       mov       rdx,7FFF90FABA68
+       mov       rdx,7FFF8F84B520
        call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L01:
-       cmp       [rcx],ecx
-       mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rbx,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rbx
+       mov       r9,rsi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
+       mov       rdx,rax
        mov       rcx,rdi
-       test      rcx,rcx
-       je        near ptr M01_L05
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L05
-       xor       eax,eax
-M01_L02:
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L00:
+       mov       edx,3
+       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rdi,rax
+       mov       rcx,rbx
+       mov       eax,[rcx+8]
        test      eax,eax
        sete      al
        movzx     eax,al
        test      eax,eax
-       jne       short M01_L03
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
-       mov       rsi,rax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M00_L01
+       call      qword ptr [7FFF8F8E7C30]
+       mov       rbx,rax
        mov       ecx,0A12
-       mov       rdx,7FFF90FABA68
+       mov       rdx,7FFF8F84B520
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
        call      CORINFO_HELP_STRCNS
+       mov       rcx,rdi
+       mov       r9,rsi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8E7810]
        mov       rdx,rax
-       mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M01_L03:
-       cmp       [rcx],ecx
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+M00_L01:
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       ecx,[rax+8]
+       call      qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rbx,rax
+       mov       ecx,[rbx+8]
        mov       [rsp+20],ecx
        mov       dword ptr [rsp+28],5
-       mov       rcx,rsi
-       mov       r8,rax
+       mov       rcx,rdi
+       mov       r8,rbx
        xor       edx,edx
        xor       r9d,r9d
-       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
+       call      qword ptr [7FFF8F5F1228]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
+       xor       ecx,ecx
        test      eax,eax
-       sete      al
-       movzx     eax,al
-       add       rsp,38
+       sete      cl
+       mov       [rsp+38],cl
+       mov       rcx,[rsi+18]
+       lea       rdx,[rsp+38]
+       cmp       [rcx],ecx
+       call      qword ptr [7FFF8FBE5318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       nop
+       add       rsp,40
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
+; Total bytes of code 517
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M01_L00:
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
+       test      rcx,rcx
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
+       test      eax,eax
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
+       test      eax,eax
+       jne       short M01_L03
+       jmp       short M01_L02
+M01_L01:
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFF8F8E7C30]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M01_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M01_L04
+       jmp       short M01_L05
 M01_L04:
-       mov       eax,1
-       jmp       near ptr M01_L00
+       mov       rsi,rdi
 M01_L05:
+       mov       ecx,536
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F7F6EB8
+       call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F87B270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8E7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8E9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7BD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M01_L07:
+       cmp       [rcx],cl
+       mov       edx,3
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFF8F5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
+; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       push      r15
+       push      r14
+       push      rdi
+       push      rsi
+       push      rbp
+       push      rbx
+       sub       rsp,28
+       mov       rsi,rcx
+       mov       edi,edx
+       mov       ebx,[rsi+8]
+       lea       ebp,[rbx-1]
+       mov       r14d,ebp
+       xor       r15d,r15d
+       test      dil,1
+       je        short M02_L03
+       xor       r15d,r15d
+       test      ebx,ebx
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFF8FBED0F0]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
+       inc       r15d
+       cmp       ebx,r15d
+       jg        short M02_L00
+M02_L03:
+       test      dil,2
+       je        near ptr M02_L10
+       mov       r14d,ebp
+       cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFF8FBED0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFF8FBED0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       ret
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5F3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,1DC0BC02028
+       mov       rax,[rax]
+       jmp       short M02_L11
+M02_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 318
+; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
+       push      rbp
+       push      r15
+       push      r14
+       push      r13
+       push      r12
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,48
+       lea       rbp,[rsp+80]
+       mov       rsi,rcx
+       mov       ebx,edx
+       mov       rdi,r8
+       mov       r14d,r9d
+       mov       r15d,[rbp+30]
+       mov       r12d,[rbp+38]
+M03_L00:
+       cmp       r12d,5
+       ja        near ptr M03_L10
+       test      rsi,rsi
+       je        near ptr M03_L11
+       test      rdi,rdi
+       je        near ptr M03_L11
+       test      r15d,r15d
+       jl        near ptr M03_L13
+       test      ebx,ebx
+       jl        near ptr M03_L15
+       test      r14d,r14d
+       jl        near ptr M03_L14
+       mov       r13d,[rsi+8]
+       sub       r13d,ebx
+       js        near ptr M03_L18
+       mov       r10d,[rdi+8]
+       sub       r10d,r14d
+       js        near ptr M03_L17
+       test      r15d,r15d
+       je        short M03_L06
+       cmp       rsi,rdi
+       je        short M03_L05
+M03_L01:
+       cmp       r15d,r13d
+       jg        short M03_L08
+       mov       eax,r15d
+M03_L02:
+       mov       r13d,eax
+       cmp       r15d,r10d
+       jg        short M03_L07
+M03_L03:
+       cmp       r12d,4
+       ja        short M03_L04
+       mov       r8d,r12d
+       lea       rcx,[7FFF8F5A64F0]
+       mov       ecx,[rcx+r8*4]
+       lea       rdx,[M03_L00]
+       add       rcx,rdx
+       jmp       rcx
+M03_L04:
+       movsxd    r8,ebx
+       lea       rcx,[rsi+r8*2+0C]
+       movsxd    r8,r14d
+       lea       r8,[rdi+r8*2+0C]
+       mov       edx,r13d
+       mov       r9d,r15d
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       jmp       qword ptr [7FFF8FA958E8]; System.Globalization.Ordinal.CompareStringIgnoreCase(Char ByRef, Int32, Char ByRef, Int32)
+M03_L05:
+       cmp       ebx,r14d
+       jne       short M03_L01
+M03_L06:
+       xor       eax,eax
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M03_L07:
+       mov       r15d,r10d
+       jmp       short M03_L03
+M03_L08:
+       mov       eax,r13d
+       jmp       short M03_L02
+       mov       r8d,ebx
+       lea       rcx,[rsi+r8*2+0C]
+       mov       r8d,r14d
+       lea       r8,[rdi+r8*2+0C]
+       mov       edx,r13d
+       mov       r9d,r15d
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       jmp       qword ptr [7FFF8F5FF318]
+M03_L09:
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M03_L10:
+       mov       ecx,1A
+       mov       edx,2A
+       call      qword ptr [7FFF8F7B7768]
+       int       3
+M03_L11:
+       cmp       rsi,rdi
+       je        short M03_L06
+       test      rsi,rsi
+       je        short M03_L12
        mov       eax,1
-       jmp       short M01_L02
-; Total bytes of code 250
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M03_L12:
+       mov       eax,0FFFFFFFF
+       add       rsp,48
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r12
+       pop       r13
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M03_L13:
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       mov       ecx,57
+       mov       rdx,7FFF8F3A4000
+       call      CORINFO_HELP_STRCNS
+       mov       r14,rax
+       mov       ecx,0A1CF
+       mov       rdx,7FFF8F3A4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F61D030]
+       mov       r8,rax
+       mov       rdx,r14
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F785750]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+M03_L14:
+       mov       rcx,1DC1BC00CC0
+       mov       r15,[rcx]
+       jmp       short M03_L16
+M03_L15:
+       mov       rcx,1DC1BC00CC8
+       mov       r15,[rcx]
+M03_L16:
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       r12,rax
+       mov       ecx,9A9B
+       mov       rdx,7FFF8F3A4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F61D030]
+       mov       r8,rax
+       mov       rdx,r15
+       mov       rcx,r12
+       call      qword ptr [7FFF8F785750]
+       mov       rcx,r12
+       call      CORINFO_HELP_THROW
+M03_L17:
+       mov       rcx,1DC1BC00CC0
+       mov       rsi,[rcx]
+       jmp       short M03_L19
+M03_L18:
+       mov       rcx,1DC1BC00CC8
+       mov       rsi,[rcx]
+M03_L19:
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       mov       ecx,9A9B
+       mov       rdx,7FFF8F3A4000
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       call      qword ptr [7FFF8F61D030]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F785750]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+       call      qword ptr [7FFF8F7598A0]; System.Globalization.CultureInfo.get_CurrentCulture()
+       mov       rcx,rax
+       mov       rax,[rax]
+       mov       rax,[rax+48]
+       call      qword ptr [rax+30]
+       mov       rcx,rax
+       mov       [rsp+20],rdi
+       mov       [rsp+28],r14d
+       mov       [rsp+30],r15d
+       and       r12d,1
+       mov       [rsp+38],r12d
+       mov       rdx,rsi
+       mov       r8d,ebx
+       mov       r9d,r13d
+       cmp       [rcx],ecx
+       call      qword ptr [7FFF8FB03798]
+       jmp       near ptr M03_L09
+       mov       rcx,7FFF8F4C4C10
+       mov       edx,23C
+       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
+       mov       rcx,1DC0BC004E0
+       mov       rcx,[rcx]
+       mov       [rsp+20],rdi
+       mov       [rsp+28],r14d
+       mov       [rsp+30],r15d
+       mov       edx,r12d
+       and       edx,1
+       mov       [rsp+38],edx
+       mov       rdx,rsi
+       mov       r8d,ebx
+       mov       r9d,r13d
+       cmp       [rcx],ecx
+       call      qword ptr [7FFF8FB03798]
+       jmp       near ptr M03_L09
+; Total bytes of code 828
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for SubstringTrim method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
+       call      qword ptr [7FFF8F889C18]; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBF5B88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 85
+; Total bytes of code 87
 ; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
-       push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
+       sub       rsp,58
        vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
+       vmovdqa   xmmword ptr [rsp+40],xmm4
+       xor       eax,eax
+       mov       [rsp+50],rax
        mov       rdi,rcx
        mov       esi,edx
        mov       ebx,r8d
        mov       rcx,rdi
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8FAAF768]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
        test      eax,eax
        je        short M01_L00
-       mov       rax,1D49ACF3020
+       mov       rax,15110402028
        mov       rax,[rax]
-       add       rsp,40
+       add       rsp,58
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r14
        ret
 M01_L00:
        mov       eax,esi
        neg       eax
        shr       eax,1F
-       mov       ecx,esi
-       sar       ecx,1F
-       or        eax,ecx
+       mov       edx,esi
+       sar       edx,1F
+       or        eax,edx
        cmp       eax,0FFFFFFFF
-       je        near ptr M01_L13
+       jne       near ptr M01_L02
+       mov       rax,15110408598
+       mov       rcx,[rax]
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M01_L01
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L01:
+       mov       edx,3
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8F7828]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F795750]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+M01_L02:
        mov       eax,ebx
        neg       eax
        shr       eax,1F
-       mov       ecx,ebx
-       sar       ecx,1F
-       or        eax,ecx
+       mov       edx,ebx
+       sar       edx,1F
+       or        eax,edx
        cmp       eax,0FFFFFFFF
-       je        near ptr M01_L14
+       jne       near ptr M01_L04
+       mov       rax,15110408590
+       mov       rcx,[rax]
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M01_L03
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L03:
+       mov       edx,3
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8F7828]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F795750]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+M01_L04:
        mov       ebp,[rdi+8]
        mov       eax,ebp
        sub       eax,ebx
-       jo        near ptr M01_L12
+       jo        near ptr M01_L18
        cmp       eax,esi
-       jle       near ptr M01_L15
+       jg        near ptr M01_L06
+       call      qword ptr [7FFF8F7698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
+       mov       rbx,rax
+       call      qword ptr [7FFF8FBF5A50]
+       mov       rdx,rax
+       mov       rcx,15110408598
+       mov       rcx,[rcx]
+       mov       [rsp+40],rcx
+       mov       rcx,15110408590
+       mov       rcx,[rcx]
+       mov       [rsp+48],rcx
+       mov       rcx,15112400CA8
+       mov       rcx,[rcx]
+       mov       [rsp+50],rcx
+       lea       rcx,[rsp+40]
+       mov       [rsp+30],rcx
+       mov       dword ptr [rsp+38],3
+       mov       rcx,rbx
+       lea       r8,[rsp+30]
+       call      qword ptr [7FFF8F601DC8]
+       mov       rbx,rax
+       mov       rax,15110408598
+       mov       rcx,[rax]
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr M01_L05
+       call      qword ptr [7FFF8F8F7C30]
+       mov       rsi,rax
+       mov       ecx,536
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,8BA
+       mov       rdx,7FFF8F806EB8
+       call      CORINFO_HELP_STRCNS
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFF8F88B270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFF8F8F7810]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F7CD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L05:
+       mov       edx,3
+       call      qword ptr [7FFF8F603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       call      qword ptr [7FFF8F8F7828]
+       mov       rdx,rax
+       mov       rcx,rbx
+       call      qword ptr [7FFF8F8F9000]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [7FFF8F795750]
+       mov       rcx,rdi
+       call      CORINFO_HELP_THROW
+M01_L06:
        test      ebx,ebx
-       jne       short M01_L01
-       mov       rax,1D49ACF3020
+       jne       short M01_L07
+       mov       rax,15110402028
        mov       rax,[rax]
-       add       rsp,40
+       add       rsp,58
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r14
        ret
-M01_L01:
+M01_L07:
        add       ebx,esi
-       jo        near ptr M01_L12
+       jo        near ptr M01_L18
        sub       ebx,1
-       jo        near ptr M01_L12
-       jmp       short M01_L03
-M01_L02:
+       jo        near ptr M01_L18
+       jmp       short M01_L09
+M01_L08:
        add       esi,1
-       jo        near ptr M01_L12
-M01_L03:
+       jo        near ptr M01_L18
+M01_L09:
        cmp       esi,ebx
-       jg        short M01_L06
+       jg        short M01_L12
        cmp       esi,ebp
-       jae       near ptr M01_L16
-       movsxd    rcx,esi
+       jae       near ptr M01_L19
+       mov       ecx,esi
        movzx     ecx,word ptr [rdi+rcx*2+0C]
        cmp       ecx,100
-       jae       short M01_L04
-       cmp       ecx,100
-       jae       near ptr M01_L16
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       jae       short M01_L10
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     r14b
-       movzx     r14d,r14b
-       test      r14d,r14d
-       jne       short M01_L02
-       jmp       short M01_L06
-M01_L04:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     r14d,al
-       test      r14d,r14d
-       jne       short M01_L02
-       jmp       short M01_L06
-M01_L05:
+       jne       short M01_L08
+       jmp       short M01_L12
+M01_L10:
+       call      qword ptr [7FFF8FBFD6A8]
+       test      eax,eax
+       jne       short M01_L08
+       jmp       short M01_L12
+M01_L11:
        sub       ebx,1
-       jo        near ptr M01_L12
-M01_L06:
+       jo        short M01_L18
+M01_L12:
        cmp       ebx,esi
-       jl        short M01_L08
+       jl        short M01_L14
        cmp       ebx,ebp
-       jae       near ptr M01_L16
-       movsxd    rcx,ebx
+       jae       short M01_L19
+       mov       ecx,ebx
        movzx     ecx,word ptr [rdi+rcx*2+0C]
        cmp       ecx,100
-       jae       short M01_L07
-       cmp       ecx,100
-       jae       near ptr M01_L16
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       jae       short M01_L13
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     r14b
-       movzx     r14d,r14b
-       test      r14d,r14d
-       jne       short M01_L05
-       jmp       short M01_L08
-M01_L07:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     r14d,al
-       test      r14d,r14d
-       jne       short M01_L05
-M01_L08:
+       jne       short M01_L11
+       jmp       short M01_L14
+M01_L13:
+       call      qword ptr [7FFF8FBFD6A8]
+       test      eax,eax
+       jne       short M01_L11
+M01_L14:
        sub       ebx,esi
-       jo        short M01_L12
+       jo        short M01_L18
        add       ebx,1
-       jo        short M01_L12
+       jo        short M01_L18
        cmp       ebp,ebx
-       je        short M01_L09
+       je        short M01_L15
        mov       rcx,rdi
        mov       edx,esi
        mov       r8d,ebx
-       call      System.String.Substring(Int32, Int32)
-       jmp       short M01_L10
-M01_L09:
+       call      qword ptr [7FFF8F603360]; System.String.Substring(Int32, Int32)
+       jmp       short M01_L16
+M01_L15:
        mov       rax,rdi
-M01_L10:
+M01_L16:
        test      ebx,ebx
-       je        short M01_L11
-       add       rsp,40
+       je        short M01_L17
+       add       rsp,58
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r14
        ret
-M01_L11:
-       mov       rax,1D49ACF3020
+M01_L17:
+       mov       rax,15110402028
        mov       rax,[rax]
-       add       rsp,40
+       add       rsp,58
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r14
        ret
-M01_L12:
+M01_L18:
        call      CORINFO_HELP_OVERFLOW
-M01_L13:
-       mov       ecx,0A92
-       mov       rdx,7FFF90F9BA68
-       call      CORINFO_HELP_STRCNS
-       mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
        int       3
-M01_L14:
-       mov       ecx,0A44
-       mov       rdx,7FFF90F9BA68
-       call      CORINFO_HELP_STRCNS
-       mov       rcx,rax
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
-       int       3
-M01_L15:
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
-       mov       rsi,rax
-       call      DotNetTips.Spargine.Extensions.Properties.Resources.get_StartIndexMustBeLessThanInputLength()
-       mov       rdi,rax
-       mov       rcx,1D49ACF9568
-       mov       rbx,[rcx]
-       mov       rcx,1D49ACF9558
-       mov       rbp,[rcx]
-       mov       rcx,1D4BACF2C80
-       mov       r14,[rcx]
-       mov       rcx,7FFF90DB4938
-       mov       edx,184
-       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1D49ACF1390
-       mov       rcx,[rcx]
-       mov       rdx,rdi
-       mov       [rsp+20],rbx
-       mov       [rsp+28],rbp
-       mov       [rsp+30],r14
-       mov       [rsp+38],rcx
-       mov       rcx,rsi
-       lea       r8,[rsp+20]
-       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
-       mov       rsi,rax
-       mov       ecx,0A92
-       mov       rdx,7FFF90F9BA68
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
-       int       3
-M01_L16:
+M01_L19:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 674
+; Total bytes of code 1224
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
+       call      qword ptr [7FFF8FC056D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__17 ByRef)
        mov       rax,[rsp+30]
        test      rax,rax
        je        short M00_L01
        add       rsp,58
        ret
 M00_L01:
        lea       rcx,[rsp+30]
-       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
+       call      qword ptr [7FFF8FBD1330]
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
+       jmp       qword ptr [7FFF8FC053C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
-       mov       rcx,7FFF90DC4938
-       mov       edx,2BD
+       cmp       [rsi],sil
+       mov       rcx,7FFF8F4E4C10
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
+       call      qword ptr [7FFF8FC055A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17.MoveNext()
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
+       call      qword ptr [7FFF8FB9D708]
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
+       call      qword ptr [7FFF8F617210]; System.Threading.Thread.InitializeCurrentThread()
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
+       call      qword ptr [7FFF8FB9D708]
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
+       call      qword ptr [7FFF8F7A9AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
 M04_L00:
        mov       rcx,rsi
-       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
+       call      qword ptr [7FFF8F7A9270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
        mov       ecx,[rsi+34]
        and       ecx,1600000
        cmp       ecx,1000000
-       jne       short M04_L02
+       je        short M04_L01
+       mov       rcx,rsi
+       call      qword ptr [7FFF8FC053D8]
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTitleCase()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,offset MT_System.CharEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,28D5AAC2C80
+       mov       rdx,24457C00CA8
        mov       rbx,[rdx]
        lea       rcx,[rdi+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       dword ptr [rdi+10],0FFFFFFFF
        mov       rcx,rdi
-       call      qword ptr [7FFF91200478]; System.CharEnumerator.MoveNext()
+       call      qword ptr [7FFF8FA99558]; System.CharEnumerator.MoveNext()
        test      eax,eax
-       sete      al
-       movzx     eax,al
-       test      eax,eax
-       je        short M00_L00
+       jne       short M00_L00
        jmp       short M00_L01
 M00_L00:
-       call      System.Globalization.CultureInfo.get_CurrentCulture()
+       call      qword ptr [7FFF8F7398A0]; System.Globalization.CultureInfo.get_CurrentCulture()
        mov       rcx,rax
        mov       rax,[rax]
        mov       rax,[rax+48]
        call      qword ptr [rax+38]
        mov       rcx,rax
        mov       rdx,rbx
        cmp       [rcx],ecx
-       call      System.Globalization.TextInfo.ToTitleCase(System.String)
+       call      qword ptr [7FFF8F73F870]; System.Globalization.TextInfo.ToTitleCase(System.String)
        mov       rbx,rax
 M00_L01:
        mov       [rsp+28],rbx
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBC53F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 164
+; Total bytes of code 159
 ; System.CharEnumerator.MoveNext()
        sub       rsp,28
        mov       eax,[rcx+10]
        mov       rdx,[rcx+8]
        mov       r8d,[rdx+8]
        dec       r8d
        cmp       eax,r8d
        jge       short M01_L00
        inc       eax
        mov       [rcx+10],eax
        cmp       eax,[rdx+8]
        jae       short M01_L01
-       movsxd    rax,eax
+       mov       eax,eax
        movzx     eax,word ptr [rdx+rax*2+0C]
        mov       [rcx+14],ax
        mov       eax,1
        add       rsp,28
        ret
        mov       eax,[rdx+8]
        mov       [rcx+10],eax
        xor       eax,eax
        add       rsp,28
        ret
 M01_L01:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 74
+; Total bytes of code 73
 ; System.Globalization.CultureInfo.get_CurrentCulture()
        sub       rsp,28
-       mov       rcx,7FFF90DB4938
-       mov       edx,230
+       mov       rcx,7FFF8F4A4C10
+       mov       edx,245
        call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
        mov       rax,[rax+8]
        test      rax,rax
        jne       short M02_L00
-       mov       rax,28D3AAC1578
+       mov       rax,24449C00538
        mov       rax,[rax]
        test      rax,rax
        jne       short M02_L00
-       mov       rax,28D3AAC1558
+       mov       rax,24449C00518
        mov       rax,[rax]
        test      rax,rax
        je        short M02_L01
        add       rsp,28
        ret
 M02_L01:
        add       rsp,28
-       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
-; Total bytes of code 83
+       jmp       qword ptr [7FFF8F739750]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
+; Total bytes of code 84
 ; System.Globalization.TextInfo.ToTitleCase(System.String)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        xor       eax,eax
        mov       [rsp+30],rax
        mov       [rsp+88],rdx
        mov       rsi,rcx
-       cmp       qword ptr [rsp+88],0
+       mov       rax,[rsp+88]
+       test      rax,rax
        je        near ptr M03_L40
        mov       rax,[rsp+88]
        cmp       dword ptr [rax+8],0
        jne       short M03_L00
        mov       rax,[rsp+88]
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
 M03_L00:
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
        mov       [rsp+30],rdi
        xor       edi,edi
        mov       rcx,[rsi+20]
-       mov       rdx,28D5AAC2C88
-       mov       rdx,[rdx]
-       mov       r8d,5
-       cmp       [rcx],ecx
-       call      System.String.StartsWith(System.String, System.StringComparison)
-       mov       ebx,eax
+       cmp       dword ptr [rcx+8],3
+       jl        short M03_L01
+       mov       edx,[rcx+0C]
+       or        edx,200020
+       xor       edx,6C006E
+       mov       ecx,[rcx+0E]
+       or        ecx,20
+       xor       ecx,2D006C
+       or        ecx,edx
+       sete      cl
+       movzx     ecx,cl
+       jmp       short M03_L02
+M03_L01:
+       xor       ecx,ecx
+M03_L02:
+       movzx     ebx,cl
        xor       ebp,ebp
        mov       rcx,[rsp+88]
        cmp       dword ptr [rcx+8],0
-       jle       near ptr M03_L38
-M03_L01:
+       jle       near ptr M03_L39
+M03_L03:
        mov       rcx,[rsp+88]
        mov       edx,ebp
-       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
+       call      qword ptr [7FFF8FBC5270]; System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
        lea       rcx,[rsp+2C]
        cmp       eax,10000
-       jae       short M03_L02
+       jae       short M03_L04
        mov       edx,1
-       jmp       short M03_L03
-M03_L02:
+       jmp       short M03_L05
+M03_L04:
        mov       edx,2
-M03_L03:
+M03_L05:
        mov       [rcx],edx
        mov       ecx,eax
-       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
+       call      qword ptr [7FFF8FBC5258]; System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
        mov       r14d,eax
        cmp       r14d,4
-       ja        near ptr M03_L30
+       ja        near ptr M03_L31
        test      ebx,ebx
-       je        near ptr M03_L06
+       je        near ptr M03_L08
        mov       rdx,[rsp+88]
        mov       r15d,[rdx+8]
        lea       edx,[r15-1]
        cmp       edx,ebp
-       jle       short M03_L06
+       jle       short M03_L08
        cmp       ebp,r15d
        jae       near ptr M03_L41
        mov       rdx,[rsp+88]
-       movsxd    rcx,ebp
+       mov       ecx,ebp
        movzx     edx,word ptr [rdx+rcx*2+0C]
        cmp       edx,69
-       je        short M03_L04
+       je        short M03_L06
        cmp       edx,49
-       jne       short M03_L06
-M03_L04:
+       jne       short M03_L08
+M03_L06:
        lea       edx,[rbp+1]
        cmp       edx,r15d
        jae       near ptr M03_L41
        mov       rdx,[rsp+88]
        lea       ecx,[rbp+1]
-       movsxd    rcx,ecx
        movzx     edx,word ptr [rdx+rcx*2+0C]
        cmp       edx,6A
-       je        short M03_L05
+       je        short M03_L07
        cmp       edx,4A
-       jne       short M03_L06
-M03_L05:
-       mov       rdx,28D5AAC2C90
-       mov       rdx,[rdx]
+       jne       short M03_L08
+M03_L07:
        mov       rcx,[rsp+30]
-       cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String)
+       cmp       [rcx],cl
+       mov       rdx,24457C00CB0
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,2
+       call      qword ptr [7FFF8F7CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
        add       ebp,2
-       jmp       short M03_L07
-M03_L06:
+       jmp       short M03_L09
+M03_L08:
        mov       r8d,[rsp+2C]
        mov       [rsp+20],r8d
        lea       r8,[rsp+88]
        lea       rdx,[rsp+30]
        mov       rcx,rsi
        mov       r9d,ebp
-       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
+       call      qword ptr [7FFF8F73F8A0]; System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
        lea       ebp,[rax+1]
-M03_L07:
+M03_L09:
        mov       r12d,ebp
+       xor       r13d,r13d
        cmp       r14d,1
        sete      r13b
-       movzx     r13d,r13b
        mov       rcx,[rsp+88]
        cmp       [rcx+8],r12d
-       jle       near ptr M03_L19
-M03_L08:
+       jle       near ptr M03_L21
+M03_L10:
        mov       rcx,[rsp+88]
        mov       edx,ebp
-       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
+       call      qword ptr [7FFF8FBC5270]; System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
        lea       rcx,[rsp+2C]
        cmp       eax,10000
-       jae       short M03_L09
+       jae       short M03_L11
        mov       edx,1
-       jmp       short M03_L10
-M03_L09:
+       jmp       short M03_L12
+M03_L11:
        mov       edx,2
-M03_L10:
+M03_L12:
        mov       [rcx],edx
        mov       ecx,eax
-       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
+       call      qword ptr [7FFF8FBC5258]; System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
        mov       r14d,eax
        test      r14d,r14d
-       je        short M03_L11
+       je        short M03_L13
        cmp       r14d,1
-       je        short M03_L11
+       je        short M03_L13
        cmp       r14d,2
-       je        short M03_L11
+       je        short M03_L13
        cmp       r14d,3
-       je        short M03_L11
+       je        short M03_L13
        cmp       r14d,4
-       sete      cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       jne       short M03_L11
+       je        short M03_L13
        mov       rcx,[rsp+88]
        cmp       ebp,[rcx+8]
        jae       near ptr M03_L41
        mov       rcx,[rsp+88]
-       movsxd    rdx,ebp
+       mov       edx,ebp
        cmp       word ptr [rcx+rdx*2+0C],27
-       jne       short M03_L17
-       jmp       short M03_L13
-M03_L11:
+       jne       short M03_L19
+       jmp       short M03_L15
+M03_L13:
        cmp       r14d,1
-       jne       short M03_L12
+       jne       short M03_L14
        mov       r13d,1
-M03_L12:
+M03_L14:
        add       ebp,[rsp+2C]
-       jmp       short M03_L18
-M03_L13:
+       jmp       short M03_L20
+M03_L15:
        inc       ebp
        test      r13d,r13d
-       je        short M03_L15
+       je        short M03_L17
        test      rdi,rdi
-       jne       short M03_L14
+       jne       short M03_L16
        mov       rcx,rsi
        mov       rdx,[rsp+88]
-       call      System.Globalization.TextInfo.ToLower(System.String)
+       call      qword ptr [7FFF8F73F6A8]; System.Globalization.TextInfo.ToLower(System.String)
        mov       rdi,rax
-M03_L14:
+M03_L16:
        mov       r9d,ebp
        sub       r9d,r12d
        mov       rcx,[rsp+30]
        mov       rdx,rdi
        mov       r8d,r12d
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
-       jmp       short M03_L16
-M03_L15:
+       call      qword ptr [7FFF8F7CB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
+       jmp       short M03_L18
+M03_L17:
        mov       r9d,ebp
        sub       r9d,r12d
        mov       rcx,[rsp+30]
        mov       rdx,[rsp+88]
        mov       r8d,r12d
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
-M03_L16:
+       call      qword ptr [7FFF8F7CB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
+M03_L18:
        mov       r12d,ebp
        mov       r13d,1
-       jmp       short M03_L18
-M03_L17:
-       mov       edx,1
-       mov       ecx,r14d
-       shl       edx,cl
-       test      edx,1FFCF800
-       jne       short M03_L19
+       jmp       short M03_L20
+M03_L19:
+       mov       ecx,1
+       shlx      ecx,ecx,r14d
+       test      ecx,1FFCF800
+       jne       short M03_L21
        add       ebp,[rsp+2C]
-M03_L18:
+M03_L20:
        mov       rcx,[rsp+88]
        cmp       [rcx+8],ebp
-       jg        near ptr M03_L08
-M03_L19:
+       jg        near ptr M03_L10
+M03_L21:
        mov       r15d,ebp
        sub       r15d,r12d
        test      r15d,r15d
-       jle       short M03_L22
+       jle       short M03_L24
        test      r13d,r13d
-       je        short M03_L21
+       je        short M03_L23
        test      rdi,rdi
-       jne       short M03_L20
+       jne       short M03_L22
        mov       rcx,rsi
        mov       rdx,[rsp+88]
-       call      System.Globalization.TextInfo.ToLower(System.String)
+       call      qword ptr [7FFF8F73F6A8]; System.Globalization.TextInfo.ToLower(System.String)
        mov       rdi,rax
-M03_L20:
+M03_L22:
        mov       rcx,[rsp+30]
        mov       rdx,rdi
        mov       r8d,r12d
        mov       r9d,r15d
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
-       jmp       short M03_L22
-M03_L21:
+       call      qword ptr [7FFF8F7CB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
+       jmp       short M03_L24
+M03_L23:
        mov       rcx,[rsp+30]
        mov       rdx,[rsp+88]
        mov       r8d,r12d
        mov       r9d,r15d
        cmp       [rcx],ecx
-       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
-M03_L22:
+       call      qword ptr [7FFF8F7CB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
+M03_L24:
        mov       rcx,[rsp+88]
        mov       r13d,[rcx+8]
        cmp       r13d,ebp
-       jle       near ptr M03_L37
+       jle       near ptr M03_L38
        mov       ecx,[rsp+2C]
        cmp       ecx,2
-       jne       near ptr M03_L25
+       jne       near ptr M03_L28
        lea       ecx,[rbp+1]
        mov       r12d,ecx
        mov       rcx,[rsp+30]
        mov       rdx,[rsp+88]
        cmp       ebp,r13d
        jae       near ptr M03_L41
-       movsxd    r8,ebp
+       mov       r8d,ebp
        movzx     edx,word ptr [rdx+r8*2+0C]
        mov       ebp,[rcx+18]
        mov       r8d,ebp
        mov       rax,[rcx+8]
        mov       r14d,[rax+8]
        cmp       r14d,r8d
-       jbe       short M03_L24
-       movsxd    r8,r8d
+       jbe       short M03_L25
+       mov       r8d,r8d
        mov       [rax+r8*2+10],dx
        inc       ebp
        mov       [rcx+18],ebp
-M03_L23:
+       jmp       short M03_L26
+M03_L25:
+       mov       r8d,1
+       call      qword ptr [7FFF8F7CB258]
+M03_L26:
        mov       rcx,[rsp+30]
        mov       rdx,[rsp+88]
        cmp       r12d,[rdx+8]
        jae       near ptr M03_L41
-       movsxd    r8,r12d
+       mov       r8d,r12d
        movzx     edx,word ptr [rdx+r8*2+0C]
        mov       r8d,[rcx+18]
        mov       eax,r8d
        mov       r9,[rcx+8]
-       mov       r10d,[r9+8]
-       cmp       r10d,eax
-       jbe       short M03_L26
-       movsxd    rax,eax
+       cmp       [r9+8],eax
+       jbe       short M03_L27
+       mov       eax,eax
        mov       [r9+rax*2+10],dx
        inc       r8d
        mov       [rcx+18],r8d
-       jmp       short M03_L28
-M03_L24:
+       jmp       short M03_L30
+M03_L27:
        mov       r8d,1
-       call      System.Text.StringBuilder.Append(Char, Int32)
-       jmp       short M03_L23
-M03_L25:
+       call      qword ptr [7FFF8F7CB258]
+       jmp       short M03_L30
+M03_L28:
        mov       rcx,[rsp+30]
        mov       rdx,[rsp+88]
        cmp       ebp,r13d
        jae       near ptr M03_L41
-       movsxd    r8,ebp
+       mov       r8d,ebp
        movzx     edx,word ptr [rdx+r8*2+0C]
        mov       r8d,[rcx+18]
        mov       eax,r8d
-       mov       r15,[rcx+8]
-       mov       r14d,[r15+8]
+       mov       r9,[rcx+8]
+       mov       r14d,[r9+8]
        cmp       r14d,eax
-       jbe       short M03_L27
-       jmp       short M03_L29
-M03_L26:
-       mov       r8d,1
-       call      System.Text.StringBuilder.Append(Char, Int32)
-       jmp       short M03_L28
-M03_L27:
-       mov       r8d,1
-       call      System.Text.StringBuilder.Append(Char, Int32)
-       mov       r12d,ebp
-M03_L28:
-       mov       ebp,r12d
-       jmp       near ptr M03_L37
-M03_L29:
-       movsxd    rax,eax
-       mov       [r15+rax*2+10],dx
+       jbe       short M03_L29
+       cmp       eax,r14d
+       jae       near ptr M03_L41
+       mov       eax,eax
+       mov       [r9+rax*2+10],dx
        lea       edx,[r8+1]
        mov       [rcx+18],edx
        mov       r12d,ebp
-       jmp       short M03_L28
+       jmp       short M03_L30
+M03_L29:
+       mov       r8d,1
+       call      qword ptr [7FFF8F7CB258]
+       mov       r12d,ebp
 M03_L30:
+       mov       ebp,r12d
+       jmp       near ptr M03_L38
+M03_L31:
        mov       ecx,[rsp+2C]
        cmp       ecx,2
-       jne       near ptr M03_L33
+       jne       near ptr M03_L35
        lea       ecx,[rbp+1]
        mov       r14d,ecx
        mov       rcx,[rsp+30]
        mov       rdx,[rsp+88]
        mov       r15d,[rdx+8]
        cmp       ebp,r15d
        jae       near ptr M03_L41
-       movsxd    r8,ebp
+       mov       r8d,ebp
        movzx     edx,word ptr [rdx+r8*2+0C]
        mov       ebp,[rcx+18]
        mov       r8d,ebp
        mov       rax,[rcx+8]
        mov       r12d,[rax+8]
        cmp       r12d,r8d
        jbe       short M03_L32
-       movsxd    r8,r8d
+       cmp       r8d,r12d
+       jae       near ptr M03_L41
+       mov       r8d,r8d
        mov       [rax+r8*2+10],dx
        inc       ebp
        mov       [rcx+18],ebp
-M03_L31:
+       jmp       short M03_L33
+M03_L32:
+       mov       r8d,1
+       call      qword ptr [7FFF8F7CB258]
+M03_L33:
        mov       rcx,[rsp+30]
        mov       rdx,[rsp+88]
        cmp       r14d,[rdx+8]
        jae       near ptr M03_L41
-       movsxd    r8,r14d
+       mov       r8d,r14d
        movzx     edx,word ptr [rdx+r8*2+0C]
        mov       r8d,[rcx+18]
        mov       eax,r8d
        mov       r9,[rcx+8]
-       mov       r10d,[r9+8]
-       cmp       r10d,eax
+       cmp       [r9+8],eax
        jbe       short M03_L34
-       cmp       eax,r10d
+       cmp       eax,[r9+8]
        jae       near ptr M03_L41
-       movsxd    rax,eax
+       mov       eax,eax
        mov       [r9+rax*2+10],dx
        inc       r8d
        mov       [rcx+18],r8d
-       jmp       short M03_L36
-M03_L32:
+       jmp       short M03_L37
+M03_L34:
        mov       r8d,1
-       call      System.Text.StringBuilder.Append(Char, Int32)
-       jmp       short M03_L31
-M03_L33:
+       call      qword ptr [7FFF8F7CB258]
+       jmp       short M03_L37
+M03_L35:
        mov       rcx,[rsp+30]
        mov       rdx,[rsp+88]
        mov       r15d,[rdx+8]
        cmp       ebp,r15d
        jae       near ptr M03_L41
-       movsxd    r8,ebp
+       mov       r8d,ebp
        movzx     edx,word ptr [rdx+r8*2+0C]
        mov       r8d,[rcx+18]
        mov       eax,r8d
-       mov       r14,[rcx+8]
-       mov       r12d,[r14+8]
+       mov       r9,[rcx+8]
+       mov       r12d,[r9+8]
        cmp       r12d,eax
-       jbe       short M03_L35
-       jmp       short M03_L39
-M03_L34:
-       mov       r8d,1
-       call      System.Text.StringBuilder.Append(Char, Int32)
-       jmp       short M03_L36
-M03_L35:
-       mov       r8d,1
-       call      System.Text.StringBuilder.Append(Char, Int32)
+       jbe       short M03_L36
+       cmp       eax,r12d
+       jae       short M03_L41
+       mov       eax,eax
+       mov       [r9+rax*2+10],dx
+       lea       edx,[r8+1]
+       mov       [rcx+18],edx
        mov       r14d,ebp
+       jmp       short M03_L37
 M03_L36:
-       mov       ebp,r14d
+       mov       r8d,1
+       call      qword ptr [7FFF8F7CB258]
+       mov       r14d,ebp
 M03_L37:
+       mov       ebp,r14d
+M03_L38:
        inc       ebp
        mov       rcx,[rsp+88]
        cmp       [rcx+8],ebp
-       jg        near ptr M03_L01
-M03_L38:
+       jg        near ptr M03_L03
+M03_L39:
        mov       rcx,[rsp+30]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF90F3AF70]; System.Text.StringBuilder.ToString()
+       call      qword ptr [7FFF8F7AD350]; System.Text.StringBuilder.ToString()
        nop
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
-M03_L39:
-       cmp       eax,r12d
-       jae       short M03_L41
-       movsxd    rax,eax
-       mov       [r14+rax*2+10],dx
-       lea       edx,[r8+1]
-       mov       [rcx+18],edx
-       mov       r14d,ebp
-       jmp       short M03_L36
 M03_L40:
-       mov       rcx,offset MT_System.ArgumentNullException
-       call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       mov       ecx,1962
-       mov       rdx,7FFF90CA4000
+       mov       ecx,15FB
+       mov       rdx,7FFF8F384000
        call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       rcx,rsi
-       call      System.ArgumentNullException..ctor(System.String)
-       mov       rcx,rsi
-       call      CORINFO_HELP_THROW
+       mov       rcx,rax
+       call      qword ptr [7FFF8F79D960]
        int       3
 M03_L41:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 1540
+; Total bytes of code 1553
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTrimmedString()
        push      rdi
        push      rsi
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rsi,rcx
        mov       rcx,rsi
        mov       rax,[rsi]
        mov       rax,[rax+40]
        call      qword ptr [rax+30]
        mov       rdi,rax
        mov       rcx,rdi
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8FA8F768]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
        test      eax,eax
        je        short M00_L00
        jmp       short M00_L01
 M00_L00:
-       cmp       [rdi],edi
+       cmp       [rdi],dil
        mov       rcx,rdi
        mov       edx,2
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       cmp       [rax],eax
+       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       cmp       [rax],al
        mov       rcx,rax
        mov       edx,1
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FFF8F5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rdi,rax
 M00_L01:
        mov       [rsp+20],rdi
        mov       rcx,[rsi+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFF8FBD5330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 118
+; Total bytes of code 123
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
        sub       rsp,28
        test      rcx,rcx
        je        short M01_L00
-       mov       r11,7FFF90CB06D8
-       call      qword ptr [7FFF90CB06D8]
+       mov       r11,7FFF8F3A0658
+       call      qword ptr [r11]
        mov       rcx,rax
-       mov       r11,7FFF90CB06E0
-       call      qword ptr [7FFF90CB06E0]
+       mov       r11,7FFF8F3A0660
+       call      qword ptr [r11]
        test      eax,eax
        sete      al
        movzx     eax,al
        add       rsp,28
        ret
 M01_L00:
        mov       eax,1
        add       rsp,28
        ret
-; Total bytes of code 67
+; Total bytes of code 61
 ; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        push      r15
        push      r14
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
+       sub       rsp,28
        mov       rsi,rcx
        mov       edi,edx
        mov       ebx,[rsi+8]
        lea       ebp,[rbx-1]
        mov       r14d,ebp
        xor       r15d,r15d
        test      dil,1
        je        short M02_L03
        xor       r15d,r15d
        test      ebx,ebx
        jle       short M02_L03
 M02_L00:
-       movsxd    rcx,r15d
+       mov       ecx,r15d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
        jae       short M02_L01
-       cmp       ecx,100
-       jae       near ptr M02_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     r12b
-       movzx     r12d,r12b
-       test      r12d,r12d
        je        short M02_L03
        jmp       short M02_L02
 M02_L01:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     r12d,al
-       test      r12d,r12d
+       call      qword ptr [7FFF8FBDD0F0]
+       test      eax,eax
        je        short M02_L03
 M02_L02:
        inc       r15d
        inc       r15d
        cmp       ebx,r15d
        jg        short M02_L00
 M02_L03:
        test      dil,2
-       je        short M02_L07
+       je        near ptr M02_L10
        mov       r14d,ebp
        cmp       r14d,r15d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
        jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
 M02_L04:
-       cmp       r14d,ebx
-       jae       near ptr M02_L11
-       movsxd    rcx,r14d
+       mov       ecx,r14d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
        jae       short M02_L05
-       cmp       ecx,100
-       jae       near ptr M02_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFFEFF31478
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
        test      byte ptr [rcx+rax],80
-       setne     dil
-       movzx     edi,dil
-       test      edi,edi
-       je        short M02_L07
+       je        short M02_L10
        jmp       short M02_L06
 M02_L05:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     edi,al
-       test      edi,edi
-       je        short M02_L07
+       call      qword ptr [7FFF8FBDD0F0]
+       test      eax,eax
+       je        short M02_L10
 M02_L06:
        dec       r14d
        cmp       r14d,r15d
        jge       short M02_L04
+       jmp       short M02_L10
 M02_L07:
-       sub       r14d,r15d
-       lea       ecx,[r14+1]
-       cmp       ebx,ecx
-       jne       short M02_L09
-       mov       rax,rsi
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
+       cmp       ecx,100
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFFEBA8D860
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L09
 M02_L08:
-       add       rsp,20
+       call      qword ptr [7FFF8FBDD0F0]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
+       mov       rax,rsi
+M02_L11:
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r14
        pop       r15
        ret
-M02_L09:
-       test      ecx,ecx
-       je        short M02_L10
-       call      System.String.FastAllocateString(Int32)
-       mov       rbx,rax
-       mov       r8d,[rbx+8]
-       lea       rcx,[rbx+0C]
-       lea       rdx,[rsi+0C]
-       mov       eax,r15d
-       lea       rdx,[rdx+rax*2]
-       add       r8,r8
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
-       mov       rax,rbx
-       jmp       short M02_L08
-M02_L10:
-       mov       rax,1A222273020
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFF8F5E3390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,26E9C402028
        mov       rax,[rax]
-       jmp       short M02_L08
-M02_L11:
+       jmp       short M02_L11
+M02_L14:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 323
+; Total bytes of code 318
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
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
+       call      qword ptr [7FFF8FBE56D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__20 ByRef)
        mov       rax,[rsp+30]
        test      rax,rax
        je        short M00_L01
        add       rsp,58
        ret
 M00_L01:
        lea       rcx,[rsp+30]
-       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
+       call      qword ptr [7FFF8FBB1330]
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
+       jmp       qword ptr [7FFF8FBE53C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
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
-       mov       rcx,7FFF90DA4938
-       mov       edx,2BD
+       cmp       [rsi],sil
+       mov       rcx,7FFF8F4C4C10
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
+       call      qword ptr [7FFF8FBE55A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20.MoveNext()
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
+       call      qword ptr [7FFF8FB7D708]
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
+       call      qword ptr [7FFF8F5F7210]; System.Threading.Thread.InitializeCurrentThread()
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
+       call      qword ptr [7FFF8FB7D708]
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
+       call      qword ptr [7FFF8F789AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
 M04_L00:
        mov       rcx,rsi
-       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
+       call      qword ptr [7FFF8F789270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
        mov       ecx,[rsi+34]
        and       ecx,1600000
        cmp       ecx,1000000
-       jne       short M04_L02
+       je        short M04_L01
+       mov       rcx,rsi
+       call      qword ptr [7FFF8FBE53D8]
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
