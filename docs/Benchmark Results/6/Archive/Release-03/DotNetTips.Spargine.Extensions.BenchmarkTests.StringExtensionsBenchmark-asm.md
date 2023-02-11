## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,[rcx+1C0]
       test      r8,r8
       jne       short M00_L00
       mov       r8,1C4918F4A90
       mov       r8,[r8]
M00_L00:
       mov       [rsp+20],r8
       mov       rcx,[rcx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 73
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,[rcx+1C0]
       test      r8,r8
       jne       short M00_L00
       mov       r8,1D372001360
       mov       r8,[r8]
M00_L00:
       mov       [rsp+20],r8
       mov       rcx,[rcx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50C3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 74
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,22615B71A80
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       rcx,[rcx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 61
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,253BFC09740
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       rcx,[rcx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50D3BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 62
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValueFromNull()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1C0]
       mov       rdx,1E696DC1A80
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L02
       cmp       dword ptr [rdx+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A1E
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValueFromNull()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+1C0]
       mov       rax,24AE6805F68
       mov       rcx,[rax]
       mov       eax,[rcx+8]
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L00
       call      qword ptr [7FFAC4EE5DB0]
       mov       rdi,rax
       mov       ecx,0A1E
       mov       rdx,7FFAC4EA52A0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EE3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EE59D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAC4EE7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DCFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L00:
       mov       edx,3
       call      qword ptr [7FFAC4C63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       test      rdi,rdi
       je        short M00_L01
       cmp       dword ptr [rdi+8],0
       je        short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdi,rcx
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50D3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 297
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M01_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M01_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L02
M01_L01:
       xor       r9d,r9d
M01_L02:
       test      r8,r8
       je        short M01_L03
       cmp       dword ptr [r8+8],0
       je        short M01_L03
       mov       rcx,r8
       jmp       near ptr M01_L06
M01_L03:
       test      r9d,r9d
       jne       near ptr M01_L06
       call      qword ptr [7FFAC4EE5DB0]
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rsi,rdi
M01_L05:
       mov       ecx,9
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EE3828]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EE59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EE7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DCFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       test      dl,dl
       jne       short M01_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAC4C63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFAC50D9810]
       test      eax,eax
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        near ptr M02_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M02_L10
       test      r14d,r14d
       jl        short M02_L07
       test      r15d,r15d
       jl        short M02_L07
       cmp       ebx,r14d
       jle       short M02_L07
M02_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFAC50D9810]
       test      eax,eax
       je        short M02_L10
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
       jmp       short M02_L10
M02_L07:
       cmp       r14d,ebx
       jae       short M02_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L08
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFAC50D9810]
       test      eax,eax
       je        short M02_L10
M02_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L07
M02_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M02_L12
       mov       rax,rsi
M02_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L12:
       test      r8d,r8d
       je        short M02_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFAC4C63390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,24AE6802028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,22FE0F3AE78
       mov       rcx,[rcx]
       mov       rdx,22FE0F3AE80
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
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
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L02
       cmp       dword ptr [rdx+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A1E
       mov       rdx,7FFAC4154D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rax,1FFD5808F30
       mov       rcx,[rax]
       mov       eax,[rcx+8]
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L00
       call      qword ptr [7FFAC4EE5DB0]
       mov       rsi,rax
       mov       ecx,0A1E
       mov       rdx,7FFAC4EA52A0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EE3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EE59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EE7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DCFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L00:
       mov       edx,3
       call      qword ptr [7FFAC4C63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,1FFD5808F28
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50D3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 284
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M01_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M01_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L02
M01_L01:
       xor       r9d,r9d
M01_L02:
       test      r8,r8
       je        short M01_L03
       cmp       dword ptr [r8+8],0
       je        short M01_L03
       mov       rcx,r8
       jmp       near ptr M01_L06
M01_L03:
       test      r9d,r9d
       jne       near ptr M01_L06
       call      qword ptr [7FFAC4EE5DB0]
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rsi,rdi
M01_L05:
       mov       ecx,9
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EE3828]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EE59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EE7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DCFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       test      dl,dl
       jne       short M01_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAC4C63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFAC50D9810]
       test      eax,eax
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        near ptr M02_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M02_L10
       test      r14d,r14d
       jl        short M02_L07
       test      r15d,r15d
       jl        short M02_L07
       cmp       ebx,r14d
       jle       short M02_L07
M02_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFAC50D9810]
       test      eax,eax
       je        short M02_L10
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
       jmp       short M02_L10
M02_L07:
       cmp       r14d,ebx
       jae       short M02_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L08
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFAC50D9810]
       test      eax,eax
       je        short M02_L10
M02_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L07
M02_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M02_L12
       mov       rax,rsi
M02_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L12:
       test      r8d,r8d
       je        short M02_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFAC4C63390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,1FFD5802028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,64
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 49
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       push      rsi
       sub       rsp,20
       mov       esi,edx
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4194D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       test      esi,esi
       jle       short M01_L03
       mov       eax,1
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,0A6A
       mov       rdx,7FFAC4194D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L05:
       test      rcx,rcx
       je        short M01_L06
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax+8],esi
       sete      al
       movzx     eax,al
       add       rsp,20
       pop       rsi
       ret
M01_L06:
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 189
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,64
       call      qword ptr [7FFAC4EE31B0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50D3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       esi,edx
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFAC4EE5DB0]
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4EA52A0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EE3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EE59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EE7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DCFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       test      esi,esi
       jle       short M01_L03
       mov       eax,1
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FFAC4EE5C78]
       mov       rdi,rax
       mov       rcx,26FA80001B0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L05
       call      qword ptr [7FFAC4EE5DB0]
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EE3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EE59D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAC4EE7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DCFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      qword ptr [7FFAC4C63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EE59F0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAC4EE7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFAC4E05750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       test      rcx,rcx
       je        short M01_L07
       mov       edx,3
       call      qword ptr [7FFAC4C63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax+8],esi
       sete      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 549
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,5
       mov       r8d,64
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       esi,edx
       mov       edi,r8d
       test      rcx,rcx
       je        short M01_L02
       cmp       dword ptr [rcx+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       test      esi,esi
       jl        short M01_L03
       cmp       esi,edi
       setle     al
       movzx     eax,al
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,0A78
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L05:
       cmp       edi,esi
       jl        short M01_L06
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L07
M01_L06:
       xor       eax,eax
M01_L07:
       test      eax,eax
       jne       short M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       ecx,0A8C
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L08:
       test      rcx,rcx
       je        short M01_L11
       mov       eax,[rcx+8]
       cmp       eax,esi
       jl        short M01_L09
       cmp       eax,edi
       setle     al
       movzx     eax,al
       jmp       short M01_L10
M01_L09:
       xor       eax,eax
M01_L10:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L11:
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 262
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,5
       mov       r8d,64
       call      qword ptr [7FFAC4EB31F8]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50A3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       esi,edx
       mov       edi,r8d
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFAC4EB5DB0]
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4E752A0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EB3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EB59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EB7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4D9FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C33510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       test      esi,esi
       jl        short M01_L03
       xor       eax,eax
       cmp       esi,edi
       setle     al
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       near ptr M01_L06
       call      qword ptr [7FFAC4EB5C78]
       mov       rbx,rax
       mov       rax,212E94003A0
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFAC4EB5DB0]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EB3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC4EB59D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAC4EB7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4D9FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      qword ptr [7FFAC4C33510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC4EB59F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAC4EB7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4DD5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       cmp       edi,esi
       jl        short M01_L07
       mov       eax,1
       jmp       short M01_L08
M01_L07:
       xor       eax,eax
M01_L08:
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFAC4EB5C78]
       mov       rbp,rax
       mov       rax,212E94003A8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L09
       call      qword ptr [7FFAC4EB5DB0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EB3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EB59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EB7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4D9FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       mov       edx,3
       call      qword ptr [7FFAC4C33510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC4EB59F0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFAC4EB7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4DD5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       test      rcx,rcx
       je        short M01_L13
       mov       eax,[rcx+8]
       cmp       eax,esi
       jl        short M01_L11
       cmp       eax,edi
       setle     al
       movzx     eax,al
       jmp       short M01_L12
M01_L11:
       xor       eax,eax
M01_L12:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L13:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 836
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,26F852BA678
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L01
       mov       rcx,26F852BA680
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L01
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rbx
       mov       rcx,rbp
       mov       r8d,1
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       r9,rdi
       test      byte ptr [rcx+48],40
       jne       short M00_L03
       xor       edi,edi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],11
       mov       [rsp+30],edi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      cl
       movzx     ecx,cl
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       mov       [rsp+40],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; Total bytes of code 228
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,26F852B3020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,26F852B8350
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       mov       [rbp-58],rsp
       mov       [rbp+10],rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       rsi,r9
       mov       r14d,[rbp+30]
       mov       r15d,[rbp+38]
       mov       r12d,[rbp+40]
       mov       edx,[rsi+8]
       cmp       edx,r12d
       jb        near ptr M03_L06
       cmp       edx,r15d
       jb        near ptr M03_L07
       cmp       [rcx],ecx
       lea       rdx,[rcx+38]
       mov       rcx,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
       test      rax,rax
       je        short M03_L02
M03_L00:
       mov       rdx,rax
M03_L01:
       mov       [rbp-40],rdx
       add       r15d,r14d
       mov       [rsp+20],r15d
       mov       [rsp+28],r12d
       mov       [rsp+30],ebx
       movzx     ecx,dil
       mov       [rsp+38],ecx
       mov       rcx,[rbp+10]
       mov       r8,[rcx+58]
       mov       [rsp+40],r8
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       mov       r8,rsi
       mov       r9d,r14d
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.RegexRunner.Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean, System.TimeSpan)
       mov       rsi,rax
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+38]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L02:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M03_L04
       mov       r13,[rdx+40]
       test      dword ptr [rdx+48],200
       jne       short M03_L05
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-48],rax
M03_L03:
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexInterpreter
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,[rbp-48]
       call      System.Text.RegularExpressions.RegexInterpreter..ctor(System.Text.RegularExpressions.RegexCode, System.Globalization.CultureInfo)
       mov       r13,[rbp-50]
       mov       rdx,r13
       jmp       near ptr M03_L01
M03_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L00
M03_L05:
       mov       rcx,26F852B1568
       mov       r8,[rcx]
       mov       rcx,r8
       mov       [rbp-48],rcx
       jmp       short M03_L03
M03_L06:
       mov       ecx,0F
       xor       edx,edx
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
       int       3
M03_L07:
       mov       ecx,8
       mov       edx,2
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       mov       rbp,[rcx+48]
       mov       [rsp+48],rbp
       lea       rbp,[rbp+0A0]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+38]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 416
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,170A7801B60
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFAC4C33510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
       mov       rcx,170A7801B68
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFAC4C33510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rbx
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FFAC4F370F0]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rbp
       mov       r9,rdi
       test      byte ptr [rcx+40],40
       jne       short M00_L03
       xor       edi,edi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],11
       mov       [rsp+30],edi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F373A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ecx,ecx
       test      rax,rax
       sete      cl
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       mov       [rsp+40],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50C5AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; Total bytes of code 207
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFAC50CB948]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        near ptr M01_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M01_L10
       test      r14d,r14d
       jl        short M01_L07
       test      r15d,r15d
       jl        short M01_L07
       cmp       ebx,r14d
       jle       short M01_L07
M01_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFAC50CB948]
       test      eax,eax
       je        short M01_L10
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
       jmp       short M01_L10
M01_L07:
       cmp       r14d,ebx
       jae       short M01_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L09
M01_L08:
       call      qword ptr [7FFAC50CB948]
       test      eax,eax
       je        short M01_L10
M01_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L07
M01_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M01_L12
       mov       rax,rsi
M01_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       test      r8d,r8d
       je        short M01_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFAC4C33390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M01_L11
M01_L13:
       mov       rax,170A9802028
       mov       rax,[rax]
       jmp       short M01_L11
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,170A9807740
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      qword ptr [7FFAC4F37138]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 41
```
```assembly
; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-58],rsp
       mov       [rbp+10],rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       rsi,r9
       mov       r14d,[rbp+30]
       mov       r15d,[rbp+38]
       mov       r12d,[rbp+40]
       mov       r13d,[rsi+8]
       cmp       r13d,r12d
       jb        near ptr M03_L16
       cmp       r13d,r15d
       jb        near ptr M03_L17
       cmp       [rcx],cl
       add       rcx,38
       xor       edx,edx
       call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
       test      rax,rax
       je        near ptr M03_L13
M03_L00:
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50C5090]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       rcx,[rbp-50]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       mov       edx,r15d
       add       rcx,rdx
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M03_L10
       mov       ecx,r14d
       lea       r13,[rsi+rcx*2+0C]
       mov       rcx,[rbp-50]
       mov       rdx,rcx
       mov       rax,[rbp+10]
       mov       r8,rax
       mov       [rbp-48],r13
       mov       [rbp-40],r15d
       mov       [rsp+20],edi
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-48]
       mov       r9d,r12d
       sub       r9d,r14d
       call      qword ptr [7FFAC50C5078]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       test      ebx,ebx
       je        near ptr M03_L08
M03_L01:
       mov       rcx,offset MT_System.Text.RegularExpressions.CompiledRegexRunner
       mov       rbx,[rbp-50]
       cmp       [rbx],rcx
       jne       near ptr M03_L06
       mov       rax,[rbx+70]
       mov       rdx,rbx
       mov       [rbp-48],r13
       mov       [rbp-40],r15d
       mov       rcx,[rax+8]
       lea       r8,[rbp-48]
       call      qword ptr [rax+18]
M03_L02:
       mov       r15,[rbx+28]
       mov       rdx,[r15+50]
       cmp       dword ptr [rdx+8],0
       jbe       short M03_L03
       cmp       dword ptr [rdx+10],0
       jg        short M03_L04
       xor       ecx,ecx
       mov       [r15+8],rcx
       mov       rcx,7FFAC4F1E5A0
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,170A9807730
       mov       r15,[rdx]
       jmp       short M03_L05
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M03_L04:
       test      edi,edi
       je        short M03_L07
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rbx+28],rdx
       mov       edx,[rbx+4C]
       mov       rcx,r15
       mov       r8d,r14d
       mov       r9d,edi
       call      qword ptr [7FFAC50C5990]
M03_L05:
       jmp       near ptr M03_L12
M03_L06:
       mov       rcx,rbx
       mov       [rbp-48],r13
       mov       [rbp-40],r15d
       lea       rdx,[rbp-48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L02
M03_L07:
       xor       ecx,ecx
       mov       [r15+8],rcx
       xor       r15d,r15d
       jmp       short M03_L05
M03_L08:
       mov       ecx,r15d
       mov       eax,1
       mov       r8,[rbp+10]
       test      byte ptr [r8+40],40
       je        short M03_L09
       xor       ecx,ecx
       mov       eax,0FFFFFFFF
M03_L09:
       mov       rbx,[rbp-50]
       cmp       [rbx+48],ecx
       jne       short M03_L11
       mov       rcx,7FFAC4F1E5A0
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,170A9807730
       mov       r15,[rdx]
       jmp       short M03_L12
M03_L10:
       mov       ecx,21
       call      qword ptr [7FFAC4DF77E0]
       int       3
M03_L11:
       add       [rbx+4C],eax
       jmp       near ptr M03_L01
M03_L12:
       xor       edx,edx
       mov       [rbx+8],rdx
       mov       rax,[rbp+10]
       lea       rcx,[rax+38]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L13:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rdx,[rax]
       mov       r8,offset MT_System.Text.RegularExpressions.RegexInterpreterFactory
       cmp       rdx,r8
       jne       short M03_L14
       mov       rcx,rax
       call      qword ptr [7FFAC5097FE8]; System.Text.RegularExpressions.RegexInterpreterFactory.CreateInstance()
       jmp       short M03_L15
M03_L14:
       mov       rcx,rax
       mov       rax,[rdx+40]
       call      qword ptr [rax+20]
M03_L15:
       jmp       near ptr M03_L00
M03_L16:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFAC5115360]
       int       3
M03_L17:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFAC5115360]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       xor       edx,edx
       mov       rbx,[rbp-50]
       mov       [rbx+8],rdx
       mov       r8,[rbp+10]
       lea       rcx,[r8+38]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 722
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       test      rdi,rdi
       je        short M00_L00
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      dl
       movzx     edx,dl
       test      edx,edx
       je        short M00_L00
       mov       rdx,14B24641A80
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
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
; Total bytes of code 104
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,14B14643020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
M02_L00:
       cmp       rsi,rdi
       je        short M02_L02
       test      rsi,rsi
       je        near ptr M02_L05
       test      rdi,rdi
       je        near ptr M02_L05
       cmp       ebx,5
       jne       short M02_L04
       mov       eax,[rsi+8]
       cmp       eax,[rdi+8]
       je        short M02_L03
M02_L01:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       cmp       ebx,5
       ja        near ptr M02_L08
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L04:
       cmp       ebx,5
       ja        short M02_L07
       mov       r8d,ebx
       lea       rcx,[7FFAC4239840]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       mov       r8d,[rsi+8]
       cmp       r8d,[rdi+8]
       jne       short M02_L01
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rsi+8]
       add       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L05:
       cmp       ebx,5
       ja        short M02_L08
       jmp       near ptr M02_L01
M02_L06:
       movzx     eax,bpl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F32B
       mov       rdx,7FFAC3E84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFAC3E84000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       mov       ecx,18
       mov       edx,2A
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M02_L06
       mov       rcx,7FFAC3F94928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,14B14641520
       mov       rcx,[r9]
       mov       r9d,ebx
       and       r9d,1
       mov       rdx,rsi
       mov       r8,rdi
       cmp       [rcx],ecx
       call      System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      bpl
       movzx     ebp,bpl
       jmp       near ptr M02_L06
; Total bytes of code 429
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFAC4C73510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       jle       short M00_L02
       cmp       dword ptr [rdi+8],1
       jne       short M00_L00
       xor       ecx,ecx
       cmp       word ptr [rdi+0C],41
       sete      cl
       jmp       short M00_L01
M00_L00:
       xor       ecx,ecx
M00_L01:
       movzx     ecx,cl
       jmp       short M00_L03
M00_L02:
       xor       ecx,ecx
M00_L03:
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50E3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFAC50E9798]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        near ptr M01_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M01_L10
       test      r14d,r14d
       jl        short M01_L07
       test      r15d,r15d
       jl        short M01_L07
       cmp       ebx,r14d
       jle       short M01_L07
M01_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFAC50E9798]
       test      eax,eax
       je        short M01_L10
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
       jmp       short M01_L10
M01_L07:
       cmp       r14d,ebx
       jae       short M01_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L09
M01_L08:
       call      qword ptr [7FFAC50E9798]
       test      eax,eax
       je        short M01_L10
M01_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L07
M01_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M01_L12
       mov       rax,rsi
M01_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       test      r8d,r8d
       je        short M01_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFAC4C73390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M01_L11
M01_L13:
       mov       rax,1D27DC02028
       mov       rax,[rax]
       jmp       short M01_L11
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Concat()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.String, System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,27560DF3190
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
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
       mov       rdx,7FFAC4376940
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
       mov       rdx,7FFAC41A4D78
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFAC41A4D78
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
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       esi,1
M02_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,27560DF2EA0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAC415F1F8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L08
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
M02_L04:
       add       r14,18
       mov       [r14],r8
       mov       [r14+8],r15d
       xor       ecx,ecx
       mov       [rsp+30],ecx
       mov       byte ptr [rsp+34],0
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L09
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,esi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+38]
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       mov       eax,[rsp+30]
       cmp       eax,ecx
       jae       near ptr M02_L10
       movsxd    rcx,eax
       mov       word ptr [rdx+rcx*2],2D
       inc       eax
       mov       [rsp+30],eax
M02_L06:
       lea       rcx,[rsp+20]
       mov       edx,edi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r15,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M02_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M02_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14d
       mov       rcx,r14
       mov       rdx,r15
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M02_L07:
       mov       rcx,[rbx+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFAC40829C0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L09:
       mov       rdx,27560DF3188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,27560DF3188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L11:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 465
```
```assembly
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
       test      rcx,rcx
       je        short M03_L00
       cmp       dword ptr [rcx+8],0
       je        short M03_L00
       xor       eax,eax
       jmp       short M03_L01
M03_L00:
       mov       eax,1
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       r14,rax
       mov       ecx,2E7
       mov       rdx,7FFAC41A4D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M03_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,27560DF3BA8
       mov       rbx,[rcx]
M03_L03:
       mov       rcx,7FFAC41A5518
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27570DF5A68
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       test      rsi,rsi
       je        short M03_L06
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L06
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M03_L06
M03_L04:
       movsxd    rcx,r14d
       mov       rdx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M03_L08
       cmp       edi,0FFFFFFFE
       je        short M03_L08
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M03_L05:
       add       r14d,1
       jo        short M03_L07
       cmp       r15d,r14d
       jg        short M03_L04
M03_L06:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4159E58]; System.Text.StringBuilder.ToString()
       mov       r12,rax
       jmp       short M03_L09
M03_L07:
       call      CORINFO_HELP_OVERFLOW
M03_L08:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L05
M03_L09:
       mov       rcx,27570DF5A68
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,r12
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
       mov       rcx,7FFAC41A5518
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27570DF5A68
       mov       rcx,[rcx]
       mov       rdx,[rbp-38]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
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
; Total bytes of code 490
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Concat()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       jne       near ptr M00_L02
       call      qword ptr [7FFAC4EA7C90]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L06
       lea       rcx,[rdi+0C]
       mov       rdx,2D850004728
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAC4C899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L07
       lea       rcx,[rdi+12]
       mov       rdx,2D84C002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAC4C899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAC4C41C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L08
       mov       eax,1
M00_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L01
       call      qword ptr [7FFAC4EA7DB0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EA5828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EA79D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EA9000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DC1F18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC4EA79D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4DC1F18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L02:
       call      qword ptr [7FFAC4EAB4C8]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rax,rax
       je        short M00_L03
       mov       edx,[rax+8]
       xor       ecx,ecx
       test      edx,edx
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      edx,edx
       jne       short M00_L04
       jmp       short M00_L04
M00_L03:
       xor       ecx,ecx
M00_L04:
       test      ecx,ecx
       jne       near ptr M00_L05
       call      qword ptr [7FFAC4EA7DB0]
       mov       rsi,rax
       mov       ecx,78D
       mov       rdx,7FFAC4E952A0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EA5828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EA79D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EA9000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DC1F18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L05:
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFAC5187090]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,14
       call      qword ptr [7FFAC4E676C0]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rcx,rdi
       mov       rdx,2D84C002190
       mov       rdx,[rdx]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4EA5048]; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC5201B88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4DE3C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4DE3C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L08:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M00_L00
; Total bytes of code 817
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
       jmp       qword ptr [7FFAC4C89A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFAC4C899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short M02_L04
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFAC4C899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2D84C002028
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
       call      qword ptr [7FFAC4DE3C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4DE3C78]
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
       call      qword ptr [7FFAC4EA7DB0]
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
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EA5828]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EA79D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EA9000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DC1F18]
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
       jmp       qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,[rsi+8]
       lea       ebp,[rbx-1]
       mov       r14d,ebp
       xor       r15d,r15d
       test      dil,1
       je        short M04_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M04_L03
M04_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L01
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M04_L03
       jmp       short M04_L02
M04_L01:
       call      qword ptr [7FFAC5253270]
       test      eax,eax
       je        short M04_L03
M04_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M04_L00
M04_L03:
       test      dil,2
       je        near ptr M04_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M04_L10
       test      r14d,r14d
       jl        short M04_L07
       test      r15d,r15d
       jl        short M04_L07
       cmp       ebx,r14d
       jle       short M04_L07
M04_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L05
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M04_L10
       jmp       short M04_L06
M04_L05:
       call      qword ptr [7FFAC5253270]
       test      eax,eax
       je        short M04_L10
M04_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M04_L04
       jmp       short M04_L10
M04_L07:
       cmp       r14d,ebx
       jae       short M04_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L08
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M04_L10
       jmp       short M04_L09
M04_L08:
       call      qword ptr [7FFAC5253270]
       test      eax,eax
       je        short M04_L10
M04_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M04_L07
M04_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M04_L12
       mov       rax,rsi
M04_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L12:
       test      r8d,r8d
       je        short M04_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFAC4C43390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M04_L11
M04_L13:
       mov       rax,2D84C002028
       mov       rax,[rax]
       jmp       short M04_L11
M04_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
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
       jne       near ptr M05_L02
       call      qword ptr [7FFAC4EA7C90]
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M05_L04
       lea       rcx,[rdi+0C]
       mov       rdx,2D850004728
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFAC4C899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M05_L05
       lea       rcx,[rdi+12]
       mov       rdx,2D84C002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFAC4C899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFAC4C41C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M05_L06
       mov       eax,1
M05_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M05_L01
       call      qword ptr [7FFAC4EA7DB0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EA5828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EA79D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EA9000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DC1F18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC4EA79D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4DC1F18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M05_L02:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFAC50C7318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M05_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M05_L03
       mov       rdx,rax
       call      qword ptr [7FFAC4BAB8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M05_L03:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFAC5165120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4DE3C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4DE3C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M05_L00
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
       call      qword ptr [7FFAC50CB150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFAC50CB330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M06_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M06_L01
       jmp       short M06_L01
M06_L00:
       xor       edx,edx
M06_L01:
       test      edx,edx
       jne       near ptr M06_L02
       call      qword ptr [7FFAC4EA7DB0]
       mov       rsi,rax
       mov       ecx,625
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EA5828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EA79D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EA9000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DC1F18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M06_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M06_L04
M06_L03:
       mov       rcx,rsi
       mov       rdx,7FFAC515D100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFAC51870F0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       ebp,edx
       mov       esi,r8d
       mov       edi,r9d
       test      esi,esi
       jle       short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       esi,1
M07_L01:
       lea       ecx,[rsi+1]
       cmp       edi,ecx
       jl        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       edi,ecx
M07_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,2D84C001ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFAC4E51520]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+30],rax
       test      rax,rax
       je        near ptr M07_L08
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M07_L04:
       mov       [rsp+40],r14
       mov       [rsp+48],r15d
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       byte ptr [rsp+3C],0
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FFAC4DB3DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+38]
       mov       rdx,[rsp+40]
       mov       eax,[rsp+48]
       cmp       ecx,eax
       jae       near ptr M07_L09
       mov       eax,ecx
       mov       word ptr [rdx+rax*2],2D
       inc       ecx
       mov       [rsp+38],ecx
M07_L05:
       lea       rcx,[rsp+28]
       mov       edx,esi
       call      qword ptr [7FFAC4DB3DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+38]
       mov       rdx,[rsp+40]
       mov       eax,[rsp+48]
       cmp       ecx,eax
       jae       near ptr M07_L10
       mov       eax,ecx
       mov       word ptr [rdx+rax*2],2D
       inc       ecx
       mov       [rsp+38],ecx
M07_L06:
       lea       rcx,[rsp+28]
       mov       edx,edi
       call      qword ptr [7FFAC4DB3DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+28]
       call      qword ptr [7FFAC4CBF090]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,r12
       call      qword ptr [7FFAC4C4B2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M07_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      qword ptr [7FFAC4EA3DE0]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M07_L11
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFAC5045B58]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,r12
       mov       r9d,2
       call      qword ptr [7FFAC4C4B318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M07_L07:
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,r12
       call      qword ptr [7FFAC4C4B2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M07_L12
       mov       rax,[rax]
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M07_L08:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L09:
       mov       rdx,2D84C002180
       mov       rdx,[rdx]
       lea       rcx,[rsp+28]
       call      qword ptr [7FFAC4CBF258]
       jmp       near ptr M07_L05
M07_L10:
       mov       rdx,2D84C002180
       mov       rdx,[rdx]
       lea       rcx,[rsp+28]
       call      qword ptr [7FFAC4CBF258]
       jmp       near ptr M07_L06
M07_L11:
       mov       ecx,10
       call      qword ptr [7FFAC4E1D780]
       int       3
M07_L12:
       mov       rdx,r12
       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFAC5285A20]
       int       3
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       [rbp-48],rsp
       mov       rbx,rcx
       mov       r14,rdx
       mov       edi,r8d
       mov       rsi,r9
       mov       rcx,rbx
       test      rcx,rcx
       je        short M08_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M08_L01
       jmp       short M08_L01
M08_L00:
       xor       eax,eax
M08_L01:
       test      eax,eax
       jne       near ptr M08_L02
       call      qword ptr [7FFAC4EA7DB0]
       mov       rbx,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4E952A0
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,9
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E56708
       call      CORINFO_HELP_STRCNS
       mov       rcx,r14
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EA5828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFAC4EA79D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAC4EA9000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFAC4DC1F18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M08_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       test      r14,r14
       jne       short M08_L03
       mov       rcx,2D850004790
       mov       r14,[rcx]
M08_L03:
       mov       rcx,2D850002A78
       mov       r15,[rcx]
       mov       rcx,r15
       call      qword ptr [7FFAC4E9A400]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       cmp       [rdx],dl
       test      rbx,rbx
       je        short M08_L04
       mov       r8d,[rbx+8]
       lea       rdx,[rbx+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFAC4E4D9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M08_L04:
       test      rsi,rsi
       je        near ptr M08_L09
       mov       rcx,rsi
       call      qword ptr [7FFAC4EAB090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       test      ecx,ecx
       je        near ptr M08_L09
       xor       ebx,ebx
       mov       r12d,[rsi+8]
       test      r12d,r12d
       jle       short M08_L09
M08_L05:
       mov       ecx,ebx
       mov       rcx,[rsi+rcx*8+10]
       cmp       edi,0FFFFFFFF
       je        short M08_L06
       cmp       edi,0FFFFFFFE
       je        short M08_L06
       mov       rdx,r14
       call      qword ptr [7FFAC4C41C60]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       test      rdx,rdx
       je        short M08_L08
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-38]
       call      qword ptr [7FFAC4E4D9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M08_L08
M08_L06:
       test      rcx,rcx
       je        short M08_L07
       mov       r8d,[rcx+8]
       lea       rdx,[rcx+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFAC4E4D9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M08_L07:
       mov       rdx,2D8500040A8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFAC4E4D9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M08_L08:
       add       ebx,1
       jo        short M08_L10
       cmp       r12d,ebx
       jg        short M08_L05
M08_L09:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFAC4E3CE30]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       jmp       short M08_L11
M08_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
M08_L11:
       mov       rcx,r15
       mov       rdx,[rbp-38]
       call      qword ptr [7FFAC4E9A408]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
       add       rsp,40
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
       lea       rbp,[rbp+70]
       mov       rcx,2D850002A78
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,[rbp-38]
       call      qword ptr [7FFAC4E9A408]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 613
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,20110781A80
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       rcx,[rcx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 61
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,1B494400B48
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       rcx,[rcx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50D3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 62
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,247E4901A80
       mov       rcx,[rcx]
       mov       rdx,247E4901A88
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
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
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L02
       cmp       dword ptr [rdx+8],0
       je        short M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A1E
       mov       rdx,7FFAC4184D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L04:
       mov       rax,rdx
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 129
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rax,24690801368
       mov       rcx,[rax]
       mov       eax,[rcx+8]
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L00
       call      qword ptr [7FFAC4EB5DB0]
       mov       rsi,rax
       mov       ecx,0A1E
       mov       rdx,7FFAC4E752A0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EB3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EB59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EB7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4D9FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L00:
       mov       edx,3
       call      qword ptr [7FFAC4C33510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,24690801360
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50A3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 284
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M01_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M01_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L02
M01_L01:
       xor       r9d,r9d
M01_L02:
       test      r8,r8
       je        short M01_L03
       cmp       dword ptr [r8+8],0
       je        short M01_L03
       mov       rcx,r8
       jmp       near ptr M01_L06
M01_L03:
       test      r9d,r9d
       jne       near ptr M01_L06
       call      qword ptr [7FFAC4EB5DB0]
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rsi,rdi
M01_L05:
       mov       ecx,9
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EB3828]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EB59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EB7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4D9FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       test      dl,dl
       jne       short M01_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAC4C33510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFAC50A9828]
       test      eax,eax
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        near ptr M02_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M02_L10
       test      r14d,r14d
       jl        short M02_L07
       test      r15d,r15d
       jl        short M02_L07
       cmp       ebx,r14d
       jle       short M02_L07
M02_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFAC50A9828]
       test      eax,eax
       je        short M02_L10
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
       jmp       short M02_L10
M02_L07:
       cmp       r14d,ebx
       jae       short M02_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L08
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFAC50A9828]
       test      eax,eax
       je        short M02_L10
M02_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L07
M02_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M02_L12
       mov       rax,rsi
M02_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L12:
       test      r8d,r8d
       je        short M02_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFAC4C33390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,2468E802028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,1ADCF9A1A80
       mov       rdx,[rdx]
       mov       r8,1ADCF9A1A88
       mov       r8,[r8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 80
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L06
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L06
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4194D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L07
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L07
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,0A56
       mov       rdx,7FFAC4194D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L08
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L08
       xor       eax,eax
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A62
       mov       rdx,7FFAC4194D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L05:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       dword ptr [rsp+20],4
       mov       ebp,[rsi+8]
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       edi,eax
       mov       dword ptr [rsp+20],4
       mov       r9d,ebp
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       r8d,eax
       sub       r8d,edi
       mov       rcx,rsi
       mov       edx,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Substring(Int32, Int32)
M01_L06:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L07:
       mov       eax,1
       jmp       near ptr M01_L02
M01_L08:
       mov       eax,1
       jmp       near ptr M01_L04
; Total bytes of code 399
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,26476400B48
       mov       rdx,[rdx]
       mov       r8,26476400B50
       mov       r8,[r8]
       call      qword ptr [7FFAC4EC3108]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
       mov       [rsp+28],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFAC4EC5DB0]
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4E852A0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L04
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFAC4EC5DB0]
       mov       rdi,rax
       mov       ecx,0A56
       mov       rdx,7FFAC4E852A0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L06
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L07
       jmp       short M01_L07
M01_L06:
       xor       eax,eax
M01_L07:
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFAC4EC5DB0]
       mov       rbx,rax
       mov       ecx,0A62
       mov       rdx,7FFAC4E852A0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       dword ptr [rsp+20],4
       mov       r9d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFAC4C436F0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       edi,eax
       mov       dword ptr [rsp+20],4
       mov       r9d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFAC4C436F0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       r8d,eax
       sub       r8d,edi
       mov       rcx,rsi
       mov       edx,edi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAC4C43360]; System.String.Substring(Int32, Int32)
; Total bytes of code 759
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       je        short M00_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       jmp       short M00_L01
M00_L00:
       xor       ecx,ecx
M00_L01:
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 68
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        short M01_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M01_L07
M01_L04:
       cmp       r14d,ebx
       jae       near ptr M01_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       cmp       ecx,100
       jae       near ptr M01_L11
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M01_L07
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
M01_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M01_L09
       mov       rax,rsi
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L09:
       test      ecx,ecx
       je        short M01_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M01_L08
M01_L10:
       mov       rax,1A9D7A93020
       mov       rax,[rax]
       jmp       short M01_L08
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       je        short M00_L00
       mov       edx,3
       call      qword ptr [7FFAC4C53510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       setg      cl
       jmp       short M00_L01
M00_L00:
       xor       ecx,ecx
M00_L01:
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50C3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFAC50C9798]
       test      eax,eax
       je        short M01_L03
M01_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M01_L00
M01_L03:
       test      dil,2
       je        near ptr M01_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M01_L10
       test      r14d,r14d
       jl        short M01_L07
       test      r15d,r15d
       jl        short M01_L07
       cmp       ebx,r14d
       jle       short M01_L07
M01_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFAC50C9798]
       test      eax,eax
       je        short M01_L10
M01_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L04
       jmp       short M01_L10
M01_L07:
       cmp       r14d,ebx
       jae       short M01_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L09
M01_L08:
       call      qword ptr [7FFAC50C9798]
       test      eax,eax
       je        short M01_L10
M01_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L07
M01_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M01_L12
       mov       rax,rsi
M01_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       test      r8d,r8d
       je        short M01_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFAC4C53390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M01_L11
M01_L13:
       mov       rax,1C0C6002028
       mov       rax,[rax]
       jmp       short M01_L11
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4174D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L06
M01_L03:
       movsxd    rcx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       cmp       ecx,100
       jae       short M01_L09
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     bpl
       movzx     ebp,bpl
       test      ebp,ebp
       jne       short M01_L05
       jmp       short M01_L07
M01_L04:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     ebp,al
       test      ebp,ebp
       je        short M01_L07
M01_L05:
       add       edi,1
       jo        short M01_L08
       cmp       ebx,edi
       jg        short M01_L03
M01_L06:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 224
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      qword ptr [7FFAC4EE3210]; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50D3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFAC4EE5DB0]
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4EA52A0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E66708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EE3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EE59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EE7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DCFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C63510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L06
M01_L03:
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       jne       short M01_L05
       jmp       short M01_L07
M01_L04:
       call      qword ptr [7FFAC50D9798]
       test      eax,eax
       je        short M01_L07
M01_L05:
       add       edi,1
       jo        short M01_L08
       cmp       ebx,edi
       jg        short M01_L03
M01_L06:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 323
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Indent()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,0A
       mov       r8d,3E
       call      DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; Total bytes of code 73
```
```assembly
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
       mov       rcx,7FFAC4165518
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,238EF2A7E78
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-30],rdx
       test      esi,esi
       jne       short M01_L00
       mov       rcx,rdx
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rdx,[rbp-30]
M01_L00:
       mov       r14d,1
       jmp       short M01_L03
M01_L01:
       mov       ecx,[rdx+18]
       mov       eax,ecx
       mov       r8,[rdx+8]
       mov       r9d,[r8+8]
       cmp       r9d,eax
       jbe       short M01_L08
       movsxd    rax,eax
       mov       [r8+rax*2+10],di
       inc       ecx
       mov       [rdx+18],ecx
M01_L02:
       add       r14d,1
       jo        short M01_L07
M01_L03:
       mov       ecx,esi
       test      ecx,ecx
       jge       short M01_L04
       mov       ecx,esi
       neg       ecx
       test      ecx,ecx
       jl        short M01_L06
M01_L04:
       cmp       r14d,ecx
       jle       short M01_L01
       test      esi,esi
       jle       short M01_L05
       mov       rcx,rdx
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rdx,[rbp-30]
M01_L05:
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4119E58]; System.Text.StringBuilder.ToString()
       mov       r15,rax
       jmp       short M01_L09
M01_L06:
       call      System.Math.ThrowAbsOverflow()
       int       3
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       movzx     edx,di
       mov       rcx,[rbp-30]
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       rdx,[rbp-30]
       jmp       short M01_L02
M01_L09:
       mov       rcx,238EF2A7E78
       mov       rcx,[rcx]
       mov       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,r15
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
       mov       rcx,7FFAC4165518
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,238EF2A7E78
       mov       rcx,[rcx]
       mov       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Indent()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,0A
       mov       r8d,3E
       call      qword ptr [7FFAC4ED3228]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC51293D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
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
       mov       rcx,1B80BC06E80
       mov       r14,[rcx]
       mov       rcx,r14
       call      qword ptr [7FFAC4E9A400]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-30],rdx
       test      esi,esi
       jne       short M01_L00
       cmp       [rdx],dl
       test      rbx,rbx
       je        short M01_L00
       mov       r8d,[rbx+8]
       lea       rdx,[rbx+0C]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFAC4E4B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L00:
       mov       rdx,[rbp-30]
       mov       r15d,1
       jmp       short M01_L04
M01_L01:
       mov       ecx,[rdx+18]
       mov       r8d,ecx
       mov       rax,[rdx+8]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L02
       mov       r8d,r8d
       mov       [rax+r8*2+10],di
       inc       ecx
       mov       [rdx+18],ecx
       jmp       short M01_L03
M01_L02:
       movzx     edx,di
       mov       rcx,[rbp-30]
       mov       r8d,1
       call      qword ptr [7FFAC4E4B258]
M01_L03:
       add       r15d,1
       jo        short M01_L08
       mov       rdx,[rbp-30]
M01_L04:
       mov       eax,esi
       test      eax,eax
       jl        short M01_L07
M01_L05:
       cmp       r15d,eax
       jle       short M01_L01
       test      esi,esi
       jle       short M01_L06
       cmp       [rdx],dl
       test      rbx,rbx
       je        short M01_L06
       mov       r8d,[rbx+8]
       lea       rdx,[rbx+0C]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFAC4E4B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L06:
       mov       rdx,[rbp-30]
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4E3CE30]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       jmp       short M01_L10
M01_L07:
       mov       eax,esi
       neg       eax
       js        short M01_L09
       jmp       short M01_L05
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       call      qword ptr [7FFAC4FCD570]
       int       3
M01_L10:
       mov       rcx,r14
       mov       rdx,[rbp-30]
       call      qword ptr [7FFAC4E9A408]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,1B80BC06E80
       mov       r14,[rcx]
       mov       rcx,r14
       mov       rdx,[rbp-30]
       call      qword ptr [7FFAC4E9A408]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 337
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1E0]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       cmp       ecx,9
       setbe     dil
       movzx     edi,dil
M00_L00:
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
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1E0]
       cmp       ecx,100
       jae       short M00_L00
       add       ecx,0FFFFFFD0
       xor       edi,edi
       cmp       ecx,9
       setbe     dil
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAC50B9900]
       xor       edi,edi
       cmp       eax,8
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50B3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 83
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1E0]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rdx,7FFB195E11B8
       test      byte ptr [rcx+rdx],60
       setne     dil
       movzx     edi,dil
M00_L00:
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
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       setbe     dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1E0]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       mov       ecx,ecx
       mov       rdx,7FFB18AED5D0
       xor       edi,edi
       test      byte ptr [rcx+rdx],60
       setne     dil
M00_L00:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50B3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FFAC50B9900]
       xor       edi,edi
       cmp       eax,4
       setbe     dil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 104
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1E0]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rdx,7FFB195E11B8
       movzx     ecx,byte ptr [rcx+rdx]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       edi,1
M00_L00:
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
M00_L01:
       cmp       ecx,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L00
M00_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M00_L03
       cmp       eax,8
       sete      dil
       movzx     edi,dil
       jmp       short M00_L04
M00_L03:
       mov       edi,1
M00_L04:
       jmp       short M00_L00
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 140
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1E0]
       cmp       ecx,100
       jae       short M00_L03
       mov       ecx,ecx
       mov       rdx,7FFB18AED5D0
       movzx     ecx,byte ptr [rcx+rdx]
       and       ecx,1F
       cmp       ecx,4
       ja        short M00_L01
       mov       eax,1
M00_L00:
       jmp       short M00_L02
M00_L01:
       xor       eax,eax
       cmp       ecx,8
       sete      al
       jmp       short M00_L00
M00_L02:
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50C3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L03:
       call      qword ptr [7FFAC50C9900]
       cmp       eax,4
       jbe       short M00_L04
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M00_L05
M00_L04:
       mov       eax,1
M00_L05:
       jmp       short M00_L02
; Total bytes of code 121
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1E0]
       cmp       ecx,100
       jae       short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rdx,7FFB195E11B8
       test      byte ptr [rcx+rdx],80
       setne     dil
       movzx     edi,dil
M00_L00:
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
M00_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 103
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```
**Method was not JITted yet.**
System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1E0]
       cmp       ecx,100
       jae       short M00_L01
       mov       ecx,ecx
       mov       rdx,7FFB18AED5D0
       xor       edi,edi
       test      byte ptr [rcx+rdx],80
       setne     dil
M00_L00:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50A3FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FFAC50A9798]
       mov       edi,eax
       jmp       short M00_L00
; Total bytes of code 86
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+190]
       mov       rcx,15FE4773A10
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     ecx,al
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 93
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+190]
       mov       rcx,206B4802A18
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F57618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC5171A08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F573A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFAC51773F0]
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+198]
       mov       rcx,22053F67E20
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     ecx,al
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 93
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+198]
       mov       rcx,1C483006E28
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F57618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC5129F18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F573A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFAC512F918]
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,1FB5E4B7E28
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     ecx,al
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 93
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,21CF3C06E30
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F57618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC512F198]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F573A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFAC5183B70]
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A8]
       mov       rcx,16D32397E30
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     ecx,al
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 93
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A8]
       mov       rcx,22BB9C06E38
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F57618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC512B408]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F573A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFAC512FE28]
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       sub       rsp,28
       xor       edx,edx
       mov       [rsp+20],edx
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 32
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       sub       rsp,28
       xor       edx,edx
       mov       [rsp+20],edx
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50A3B88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 33
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1D0]
       mov       rcx,1B555DB7E38
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     ecx,al
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 93
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1D0]
       mov       rcx,263B8406E40
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F67618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC5139F48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F673A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFAC513F930]
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+180]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rdx,rax
       mov       rcx,25EF0DA7E40
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     eax,al
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; System.Guid.ToString()
       mov       rdx,25EF0DAA050
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M02_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M02_L02
       xor       esi,esi
M02_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M02_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M02_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M02_L00
; Total bytes of code 93
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+180]
       vmovupd   [rsp+20],xmm0
       mov       rdx,1E49F409028
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       xor       r8d,r8d
       call      qword ptr [7FFAC4C7D9A8]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,1E49F406E48
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F37618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; System.Guid.ToString(System.String, System.IFormatProvider)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L09
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L09
       mov       ebx,[rsi+8]
       cmp       ebx,1
       jne       near ptr M01_L10
M01_L00:
       movzx     ebp,word ptr [rsi+0C]
       cmp       ebp,58
       ja        short M01_L05
       cmp       ebp,44
       ja        short M01_L03
       cmp       ebp,42
       je        near ptr M01_L06
       cmp       ebp,44
       jne       near ptr M01_L08
M01_L01:
       mov       ecx,24
M01_L02:
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       lea       rcx,[rbp+0C]
       mov       edx,[rbp+8]
       add       rsi,0C
       mov       [rsp+30],rcx
       mov       [rsp+38],edx
       mov       [rsp+20],rsi
       mov       [rsp+28],ebx
       mov       rcx,rdi
       lea       rdx,[rsp+30]
       lea       r9,[rsp+20]
       lea       r8,[rsp+40]
       call      qword ptr [7FFAC4C7D9C0]; System.Guid.TryFormat(System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
       mov       rax,rbp
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       cmp       ebp,4E
       jne       near ptr M01_L11
M01_L04:
       mov       ecx,20
       jmp       short M01_L02
M01_L05:
       cmp       ebp,64
       jbe       near ptr M01_L12
       cmp       ebp,6E
       je        short M01_L04
       cmp       ebp,70
       je        short M01_L06
       cmp       ebp,78
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       ecx,26
       jmp       short M01_L02
M01_L07:
       mov       ecx,44
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0C32D
       mov       rdx,7FFAC49E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4C5D030]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EBFE10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,1E49F409028
       mov       rsi,[rcx]
       mov       ebx,[rsi+8]
       cmp       ebx,1
       je        near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0C32D
       mov       rdx,7FFAC49E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4C5D030]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EBFE10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       cmp       ebp,50
       je        near ptr M01_L06
       cmp       ebp,58
       je        near ptr M01_L07
       jmp       near ptr M01_L08
M01_L12:
       cmp       ebp,62
       je        near ptr M01_L06
       cmp       ebp,64
       je        near ptr M01_L01
       jmp       near ptr M01_L08
; Total bytes of code 435
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M02_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M02_L02
       xor       esi,esi
M02_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F373A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M02_L01:
       mov       ecx,7
       call      qword ptr [7FFAC510FB28]
       int       3
M02_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M02_L00
; Total bytes of code 90
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1B8]
       mov       rcx,20F85597E48
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     ecx,al
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 93
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1B8]
       mov       rcx,22328402A48
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F37618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC510B438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F373A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFAC510FE10]
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rdi
       push      rsi
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,21A4F5C7E50
       mov       rcx,[rcx]
       mov       rdx,21A2F5C1A80
       mov       r9,[rdx]
       test      byte ptr [rcx+48],40
       jne       short M00_L01
       xor       edi,edi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],11
       mov       [rsp+30],edi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      cl
       movzx     ecx,cl
       mov       [rsp+40],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       edi,11
       jmp       short M00_L00
; Total bytes of code 121
```
```assembly
; System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       mov       [rbp-58],rsp
       mov       [rbp+10],rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       rsi,r9
       mov       r14d,[rbp+30]
       mov       r15d,[rbp+38]
       mov       r12d,[rbp+40]
       mov       edx,[rsi+8]
       cmp       edx,r12d
       jb        near ptr M01_L06
       cmp       edx,r15d
       jb        near ptr M01_L07
       cmp       [rcx],ecx
       lea       rdx,[rcx+38]
       mov       rcx,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
       test      rax,rax
       je        short M01_L02
M01_L00:
       mov       rdx,rax
M01_L01:
       mov       [rbp-40],rdx
       add       r15d,r14d
       mov       [rsp+20],r15d
       mov       [rsp+28],r12d
       mov       [rsp+30],ebx
       movzx     ecx,dil
       mov       [rsp+38],ecx
       mov       rcx,[rbp+10]
       mov       r8,[rcx+58]
       mov       [rsp+40],r8
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       mov       r8,rsi
       mov       r9d,r14d
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.RegexRunner.Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean, System.TimeSpan)
       mov       rsi,rax
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+38]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M01_L04
       mov       r13,[rdx+40]
       test      dword ptr [rdx+48],200
       jne       short M01_L05
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-48],rax
M01_L03:
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexInterpreter
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,[rbp-48]
       call      System.Text.RegularExpressions.RegexInterpreter..ctor(System.Text.RegularExpressions.RegexCode, System.Globalization.CultureInfo)
       mov       r13,[rbp-50]
       mov       rdx,r13
       jmp       near ptr M01_L01
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L00
M01_L05:
       mov       rcx,21A4F5C1568
       mov       r8,[rcx]
       mov       rcx,r8
       mov       [rbp-48],rcx
       jmp       short M01_L03
M01_L06:
       mov       ecx,0F
       xor       edx,edx
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
       int       3
M01_L07:
       mov       ecx,8
       mov       edx,2
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       mov       rbp,[rcx+48]
       mov       [rsp+48],rbp
       lea       rbp,[rbp+0A0]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+38]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 416
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rdi
       push      rsi
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,1CD0A406E58
       mov       rcx,[rcx]
       mov       rdx,1CD0C400B48
       mov       r9,[rdx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       edi,edi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],11
       mov       [rsp+30],edi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F473A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ecx,ecx
       test      rax,rax
       sete      cl
       mov       [rsp+40],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC511B168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       edi,11
       jmp       short M00_L00
; Total bytes of code 117
```
```assembly
; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-58],rsp
       mov       [rbp+10],rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       rsi,r9
       mov       r14d,[rbp+30]
       mov       r15d,[rbp+38]
       mov       r12d,[rbp+40]
       mov       r13d,[rsi+8]
       cmp       r13d,r12d
       jb        near ptr M01_L16
       cmp       r13d,r15d
       jb        near ptr M01_L17
       cmp       [rcx],cl
       add       rcx,38
       xor       edx,edx
       call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50D9090]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       rcx,[rbp-50]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       mov       edx,r15d
       add       rcx,rdx
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M01_L10
       mov       ecx,r14d
       lea       r13,[rsi+rcx*2+0C]
       mov       rcx,[rbp-50]
       mov       rdx,rcx
       mov       rax,[rbp+10]
       mov       r8,rax
       mov       [rbp-48],r13
       mov       [rbp-40],r15d
       mov       [rsp+20],edi
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-48]
       mov       r9d,r12d
       sub       r9d,r14d
       call      qword ptr [7FFAC50D9078]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       test      ebx,ebx
       je        near ptr M01_L08
M01_L01:
       mov       rcx,offset MT_System.Text.RegularExpressions.CompiledRegexRunner
       mov       rbx,[rbp-50]
       cmp       [rbx],rcx
       jne       near ptr M01_L06
       mov       rax,[rbx+70]
       mov       rdx,rbx
       mov       [rbp-48],r13
       mov       [rbp-40],r15d
       mov       rcx,[rax+8]
       lea       r8,[rbp-48]
       call      qword ptr [rax+18]
M01_L02:
       mov       r15,[rbx+28]
       mov       rdx,[r15+50]
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L03
       cmp       dword ptr [rdx+10],0
       jg        short M01_L04
       xor       ecx,ecx
       mov       [r15+8],rcx
       mov       rcx,7FFAC4F2E5A0
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1CD0A407730
       mov       r15,[rdx]
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       test      edi,edi
       je        short M01_L07
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rbx+28],rdx
       mov       edx,[rbx+4C]
       mov       rcx,r15
       mov       r8d,r14d
       mov       r9d,edi
       call      qword ptr [7FFAC5119E10]
M01_L05:
       jmp       near ptr M01_L12
M01_L06:
       mov       rcx,rbx
       mov       [rbp-48],r13
       mov       [rbp-40],r15d
       lea       rdx,[rbp-48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L02
M01_L07:
       xor       ecx,ecx
       mov       [r15+8],rcx
       xor       r15d,r15d
       jmp       short M01_L05
M01_L08:
       mov       ecx,r15d
       mov       eax,1
       mov       r8,[rbp+10]
       test      byte ptr [r8+40],40
       je        short M01_L09
       xor       ecx,ecx
       mov       eax,0FFFFFFFF
M01_L09:
       mov       rbx,[rbp-50]
       cmp       [rbx+48],ecx
       jne       short M01_L11
       mov       rcx,7FFAC4F2E5A0
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1CD0A407730
       mov       r15,[rdx]
       jmp       short M01_L12
M01_L10:
       mov       ecx,21
       call      qword ptr [7FFAC4E077E0]
       int       3
M01_L11:
       add       [rbx+4C],eax
       jmp       near ptr M01_L01
M01_L12:
       xor       edx,edx
       mov       [rbx+8],rdx
       mov       rax,[rbp+10]
       lea       rcx,[rax+38]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rdx,[rax]
       mov       r8,offset MT_System.Text.RegularExpressions.RegexInterpreterFactory
       cmp       rdx,r8
       jne       short M01_L14
       mov       rcx,rax
       call      qword ptr [7FFAC50A8860]; Precode of System.Text.RegularExpressions.RegexInterpreterFactory.CreateInstance()
       jmp       short M01_L15
M01_L14:
       mov       rcx,rax
       mov       rax,[rdx+40]
       call      qword ptr [rax+20]
M01_L15:
       jmp       near ptr M01_L00
M01_L16:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFAC511FB58]
       int       3
M01_L17:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFAC511FB58]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       xor       edx,edx
       mov       rbx,[rbp-50]
       mov       [rbx+8],rdx
       mov       r8,[rbp+10]
       lea       rcx,[r8+38]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 722
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 34
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50A3B88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 35
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1C8]
       mov       rcx,19C87587E58
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     ecx,al
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 93
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1C8]
       mov       rcx,2969E406E60
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F67618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC5139F18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F673A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFAC513F918]
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rdi
       push      rsi
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,1F11F827E68
       mov       rcx,[rcx]
       mov       rdx,1F10F822A98
       mov       r9,[rdx]
       test      byte ptr [rcx+48],40
       jne       short M00_L01
       xor       edi,edi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],0A
       mov       [rsp+30],edi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      cl
       movzx     ecx,cl
       mov       [rsp+40],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       edi,0A
       jmp       short M00_L00
; Total bytes of code 121
```
```assembly
; System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       mov       [rbp-58],rsp
       mov       [rbp+10],rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       rsi,r9
       mov       r14d,[rbp+30]
       mov       r15d,[rbp+38]
       mov       r12d,[rbp+40]
       mov       edx,[rsi+8]
       cmp       edx,r12d
       jb        near ptr M01_L06
       cmp       edx,r15d
       jb        near ptr M01_L07
       cmp       [rcx],ecx
       lea       rdx,[rcx+38]
       mov       rcx,rdx
       xor       edx,edx
       call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
       test      rax,rax
       je        short M01_L02
M01_L00:
       mov       rdx,rax
M01_L01:
       mov       [rbp-40],rdx
       add       r15d,r14d
       mov       [rsp+20],r15d
       mov       [rsp+28],r12d
       mov       [rsp+30],ebx
       movzx     ecx,dil
       mov       [rsp+38],ecx
       mov       rcx,[rbp+10]
       mov       r8,[rcx+58]
       mov       [rsp+40],r8
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       mov       r8,rsi
       mov       r9d,r14d
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.RegexRunner.Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean, System.TimeSpan)
       mov       rsi,rax
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+38]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M01_L04
       mov       r13,[rdx+40]
       test      dword ptr [rdx+48],200
       jne       short M01_L05
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp-48],rax
M01_L03:
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexInterpreter
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,[rbp-48]
       call      System.Text.RegularExpressions.RegexInterpreter..ctor(System.Text.RegularExpressions.RegexCode, System.Globalization.CultureInfo)
       mov       r13,[rbp-50]
       mov       rdx,r13
       jmp       near ptr M01_L01
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L00
M01_L05:
       mov       rcx,1F11F821568
       mov       r8,[rcx]
       mov       rcx,r8
       mov       [rbp-48],rcx
       jmp       short M01_L03
M01_L06:
       mov       ecx,0F
       xor       edx,edx
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
       int       3
M01_L07:
       mov       ecx,8
       mov       edx,2
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentOutOfRangeException(System.Text.RegularExpressions.ExceptionArgument, System.Text.RegularExpressions.ExceptionResource)
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       mov       rbp,[rcx+48]
       mov       [rsp+48],rbp
       lea       rbp,[rbp+0A0]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+38]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 416
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rdi
       push      rsi
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,1A6B1404E78
       mov       rcx,[rcx]
       mov       rdx,1A6AF403358
       mov       r9,[rdx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       edi,edi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],0A
       mov       [rsp+30],edi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F473A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ecx,ecx
       test      rax,rax
       sete      cl
       mov       [rsp+40],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC511B438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       edi,0A
       jmp       short M00_L00
; Total bytes of code 117
```
```assembly
; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-58],rsp
       mov       [rbp+10],rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       rsi,r9
       mov       r14d,[rbp+30]
       mov       r15d,[rbp+38]
       mov       r12d,[rbp+40]
       mov       r13d,[rsi+8]
       cmp       r13d,r12d
       jb        near ptr M01_L16
       cmp       r13d,r15d
       jb        near ptr M01_L17
       cmp       [rcx],cl
       add       rcx,38
       xor       edx,edx
       call      System.Threading.Interlocked.Exchange(System.Object ByRef, System.Object)
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+48]
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50D9090]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       rcx,[rbp-50]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       mov       edx,r15d
       add       rcx,rdx
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M01_L10
       mov       ecx,r14d
       lea       r13,[rsi+rcx*2+0C]
       mov       rcx,[rbp-50]
       mov       rdx,rcx
       mov       rax,[rbp+10]
       mov       r8,rax
       mov       [rbp-48],r13
       mov       [rbp-40],r15d
       mov       [rsp+20],edi
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-48]
       mov       r9d,r12d
       sub       r9d,r14d
       call      qword ptr [7FFAC50D9078]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       test      ebx,ebx
       je        near ptr M01_L08
M01_L01:
       mov       rcx,offset MT_System.Text.RegularExpressions.CompiledRegexRunner
       mov       rbx,[rbp-50]
       cmp       [rbx],rcx
       jne       short M01_L06
       mov       rax,[rbx+70]
       mov       rdx,rbx
       mov       [rbp-48],r13
       mov       [rbp-40],r15d
       mov       rcx,[rax+8]
       lea       r8,[rbp-48]
       call      qword ptr [rax+18]
M01_L02:
       mov       r15,[rbx+28]
       mov       rdx,[r15+50]
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L03
       cmp       dword ptr [rdx+10],0
       jg        short M01_L04
       xor       edx,edx
       mov       [r15+8],rdx
       mov       rdx,1A6B1405738
       mov       r15,[rdx]
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       test      edi,edi
       je        short M01_L07
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rbx+28],rdx
       mov       edx,[rbx+4C]
       mov       rcx,r15
       mov       r8d,r14d
       mov       r9d,edi
       call      qword ptr [7FFAC5119E10]
M01_L05:
       jmp       short M01_L12
M01_L06:
       mov       rcx,rbx
       mov       [rbp-48],r13
       mov       [rbp-40],r15d
       lea       rdx,[rbp-48]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L02
M01_L07:
       xor       edx,edx
       mov       [r15+8],rdx
       xor       r15d,r15d
       jmp       short M01_L05
M01_L08:
       mov       edx,r15d
       mov       ecx,1
       mov       rax,[rbp+10]
       test      byte ptr [rax+40],40
       je        short M01_L09
       xor       edx,edx
       mov       ecx,0FFFFFFFF
M01_L09:
       mov       rbx,[rbp-50]
       cmp       [rbx+48],edx
       jne       short M01_L11
       mov       rcx,1A6B1405738
       mov       r15,[rcx]
       jmp       short M01_L12
M01_L10:
       mov       ecx,21
       call      qword ptr [7FFAC4E077E0]
       int       3
M01_L11:
       add       [rbx+4C],ecx
       jmp       near ptr M01_L01
M01_L12:
       xor       edx,edx
       mov       [rbx+8],rdx
       mov       rax,[rbp+10]
       lea       rcx,[rax+38]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rdx,[rax]
       mov       r8,offset MT_System.Text.RegularExpressions.RegexInterpreterFactory
       cmp       rdx,r8
       jne       short M01_L14
       mov       rcx,rax
       call      qword ptr [7FFAC50A8860]; Precode of System.Text.RegularExpressions.RegexInterpreterFactory.CreateInstance()
       jmp       short M01_L15
M01_L14:
       mov       rcx,rax
       mov       rax,[rdx+40]
       call      qword ptr [rax+20]
M01_L15:
       jmp       near ptr M01_L00
M01_L16:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFAC511FE28]
       int       3
M01_L17:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFAC511FE28]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       xor       edx,edx
       mov       rbx,[rbp-50]
       mov       [rbx+8],rdx
       mov       rax,[rbp+10]
       lea       rcx,[rax+38]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 671
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rcx,20278753A78
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     ecx,al
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 93
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rcx,1AF78C02A80
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F67618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC513B3D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F673A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFAC5191270]
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1B0]
       mov       rcx,160A7567E70
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
       movzx     ecx,al
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,1
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 93
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1B0]
       mov       rcx,240D9406E78
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F47618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC511B168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F473A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFAC511FF60]
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,13B7DC17E88
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      System.Text.RegularExpressions.Regex.Match(System.String)
       cmp       dword ptr [rax+30],0
       setne     cl
       movzx     ecx,cl
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 72
```
```assembly
; System.Text.RegularExpressions.Regex.Match(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+48],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       call      System.Text.RegularExpressions.Regex.Run(Boolean, Int32, System.String, Int32, Int32, Int32)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      System.Text.RegularExpressions.ThrowHelper.ThrowArgumentNullException(System.Text.RegularExpressions.ExceptionArgument)
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 80
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,206AD002A88
       mov       rcx,[rcx]
       call      qword ptr [7FFAC4F676C0]; System.Text.RegularExpressions.Regex.Match(System.String)
       xor       ecx,ecx
       cmp       dword ptr [rax+30],0
       setne     cl
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC51830C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 71
```
```assembly
; System.Text.RegularExpressions.Regex.Match(System.String)
       push      rsi
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       esi,esi
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],esi
       mov       edx,2
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFAC4F673A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFAC5187A98]
       int       3
M01_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M01_L00
; Total bytes of code 87
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1D8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L03
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rdx,1A079821258
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.EndsWith(System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L02
       mov       r8d,[rsi+8]
       add       r8d,0FFFFFFFE
       mov       rcx,rsi
       xor       edx,edx
       call      System.String.Substring(Int32, Int32)
       mov       rsi,rax
M01_L02:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L03:
       mov       eax,1
       jmp       near ptr M01_L00
; Total bytes of code 172
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1D8]
       call      qword ptr [7FFAC4EC3420]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50B3BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFAC4EC5DB0]
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4E852A0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rdx,1D9028046B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8d,5
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4C412D0]; System.String.EndsWith(System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L05
       mov       ecx,[rsi+8]
       lea       r8d,[rcx-2]
       cmp       ecx,r8d
       jb        short M01_L06
       test      r8d,r8d
       jne       short M01_L03
       mov       rcx,1D902802028
       mov       rsi,[rcx]
       jmp       short M01_L05
M01_L03:
       cmp       ecx,r8d
       jne       short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       ecx,r8d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,[rdi+8]
       lea       rcx,[rdi+0C]
       lea       rdx,[rsi+0C]
       add       r8,r8
       call      qword ptr [7FFAC4C899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,rdi
M01_L05:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFAC4C43378]
       int       3
; Total bytes of code 361
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,1FA840A1A80
       mov       rcx,[rcx]
       mov       rdx,1FA840A1A88
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4194D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A38
       mov       rdx,7FFAC4194D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rax,27FCB001B60
       mov       rdi,[rax]
       mov       rax,27FCB001B68
       mov       rbx,[rax]
       mov       rcx,rdi
       mov       eax,[rcx+8]
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L00
       call      qword ptr [7FFAC4EB5DB0]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4E752A0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EB3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EB59D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAC4EB7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFAC4D9FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L00:
       mov       edx,3
       call      qword ptr [7FFAC4C33510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rbx
       mov       eax,[rcx+8]
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L01
       call      qword ptr [7FFAC4EB5DB0]
       mov       rbx,rax
       mov       ecx,0A38
       mov       rdx,7FFAC4E752A0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EB3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC4EB59D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAC4EB7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4D9FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L01:
       mov       edx,3
       call      qword ptr [7FFAC4C33510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       ecx,[rbx+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFAC4C31228]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rsp+38],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+38]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50A5018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 517
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M01_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M01_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L02
M01_L01:
       xor       r9d,r9d
M01_L02:
       test      r8,r8
       je        short M01_L03
       cmp       dword ptr [r8+8],0
       je        short M01_L03
       mov       rcx,r8
       jmp       near ptr M01_L06
M01_L03:
       test      r9d,r9d
       jne       near ptr M01_L06
       call      qword ptr [7FFAC4EB5DB0]
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rsi,rdi
M01_L05:
       mov       ecx,9
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E36708
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EB3828]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EB59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EB7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4D9FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       test      dl,dl
       jne       short M01_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAC4C33510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFAC50A97E0]
       test      eax,eax
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        near ptr M02_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M02_L10
       test      r14d,r14d
       jl        short M02_L07
       test      r15d,r15d
       jl        short M02_L07
       cmp       ebx,r14d
       jle       short M02_L07
M02_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFAC50A97E0]
       test      eax,eax
       je        short M02_L10
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
       jmp       short M02_L10
M02_L07:
       cmp       r14d,ebx
       jae       short M02_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L08
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFAC50A97E0]
       test      eax,eax
       je        short M02_L10
M02_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L07
M02_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M02_L12
       mov       rax,rsi
M02_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L12:
       test      r8d,r8d
       je        short M02_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFAC4C33390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,27FCD002028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       mov       rsi,rcx
       mov       ebx,edx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15d,[rbp+30]
       mov       r12d,[rbp+38]
M03_L00:
       cmp       r12d,5
       ja        near ptr M03_L10
       test      rsi,rsi
       je        near ptr M03_L11
       test      rdi,rdi
       je        near ptr M03_L11
       test      r15d,r15d
       jl        near ptr M03_L13
       test      ebx,ebx
       jl        near ptr M03_L15
       test      r14d,r14d
       jl        near ptr M03_L14
       mov       r13d,[rsi+8]
       sub       r13d,ebx
       js        near ptr M03_L18
       mov       r10d,[rdi+8]
       sub       r10d,r14d
       js        near ptr M03_L17
       test      r15d,r15d
       je        short M03_L06
       cmp       rsi,rdi
       je        short M03_L05
M03_L01:
       cmp       r15d,r13d
       jg        short M03_L08
       mov       eax,r15d
M03_L02:
       mov       r13d,eax
       cmp       r15d,r10d
       jg        short M03_L07
M03_L03:
       cmp       r12d,4
       ja        short M03_L04
       mov       r8d,r12d
       lea       rcx,[7FFAC4BD27D0]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[M03_L00]
       add       rcx,rdx
       jmp       rcx
M03_L04:
       movsxd    r8,ebx
       lea       rcx,[rsi+r8*2+0C]
       movsxd    r8,r14d
       lea       r8,[rdi+r8*2+0C]
       mov       edx,r13d
       mov       r9d,r15d
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFAC4DB1000]
M03_L05:
       cmp       ebx,r14d
       jne       short M03_L01
M03_L06:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L07:
       mov       r15d,r10d
       jmp       short M03_L03
M03_L08:
       mov       eax,r13d
       jmp       short M03_L02
       mov       r8d,ebx
       lea       rcx,[rsi+r8*2+0C]
       mov       r8d,r14d
       lea       r8,[rdi+r8*2+0C]
       mov       edx,r13d
       mov       r9d,r15d
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFAC4C3F318]; System.SpanHelpers.SequenceCompareTo(Char ByRef, Int32, Char ByRef, Int32)
M03_L09:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L10:
       mov       ecx,1A
       mov       edx,2A
       call      qword ptr [7FFAC4DF7768]
       int       3
M03_L11:
       cmp       rsi,rdi
       je        short M03_L06
       test      rsi,rsi
       je        short M03_L12
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L12:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,57
       mov       rdx,7FFAC49E4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A1CF
       mov       rdx,7FFAC49E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4C5D030]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFAC4DD5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L14:
       mov       rcx,27FCB001B78
       mov       r15,[rcx]
       jmp       short M03_L16
M03_L15:
       mov       rcx,27FCB001B80
       mov       r15,[rcx]
M03_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,9A9B
       mov       rdx,7FFAC49E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4C5D030]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r12
       call      qword ptr [7FFAC4DD5750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M03_L17:
       mov       rcx,27FCB001B78
       mov       rsi,[rcx]
       jmp       short M03_L19
M03_L18:
       mov       rcx,27FCB001B80
       mov       rsi,[rcx]
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9A9B
       mov       rdx,7FFAC49E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4C5D030]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DD5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      qword ptr [7FFAC4D998A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       [rsp+20],rdi
       mov       [rsp+28],r14d
       mov       [rsp+30],r15d
       and       r12d,1
       mov       [rsp+38],r12d
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9d,r13d
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4FA3210]
       jmp       near ptr M03_L09
       mov       rcx,7FFAC4B04C08
       mov       edx,23B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27FCD0004E0
       mov       rcx,[rcx]
       mov       [rsp+20],rdi
       mov       [rsp+28],r14d
       mov       [rsp+30],r15d
       mov       edx,r12d
       and       edx,1
       mov       [rsp+38],edx
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9d,r13d
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4FA3210]
       jmp       near ptr M03_L09
; Total bytes of code 828
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,1DB3AD42A98
       mov       rcx,[rcx]
       mov       rdx,1DB3AD42AA0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M01_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L04
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L05
       cmp       dword ptr [rcx+8],0
       je        short M01_L05
       xor       eax,eax
M01_L02:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,0A38
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L03:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       ecx,[rax+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rsi
       mov       r8,rax
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L05:
       mov       eax,1
       jmp       short M01_L02
; Total bytes of code 250
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rax,1F645400B48
       mov       rdi,[rax]
       mov       rax,1F645400B50
       mov       rbx,[rax]
       mov       rcx,rdi
       mov       eax,[rcx+8]
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L00
       call      qword ptr [7FFAC4EC5DB0]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4E852A0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L00:
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,rbx
       mov       eax,[rcx+8]
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L01
       call      qword ptr [7FFAC4EC5DB0]
       mov       rbx,rax
       mov       ecx,0A38
       mov       rdx,7FFAC4E852A0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L01:
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       ecx,[rbx+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFAC4C41228]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rsp+38],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+38]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50B3B88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 517
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M01_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M01_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L02
M01_L01:
       xor       r9d,r9d
M01_L02:
       test      r8,r8
       je        short M01_L03
       cmp       dword ptr [r8+8],0
       je        short M01_L03
       mov       rcx,r8
       jmp       near ptr M01_L06
M01_L03:
       test      r9d,r9d
       jne       near ptr M01_L06
       call      qword ptr [7FFAC4EC5DB0]
       mov       rdi,rax
       test      rsi,rsi
       je        short M01_L04
       cmp       dword ptr [rsi+8],0
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rsi,rdi
M01_L05:
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       test      dl,dl
       jne       short M01_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFAC50B9420]
       test      eax,eax
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        near ptr M02_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M02_L10
       test      r14d,r14d
       jl        short M02_L07
       test      r15d,r15d
       jl        short M02_L07
       cmp       ebx,r14d
       jle       short M02_L07
M02_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFAC50B9420]
       test      eax,eax
       je        short M02_L10
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
       jmp       short M02_L10
M02_L07:
       cmp       r14d,ebx
       jae       short M02_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L08
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFAC50B9420]
       test      eax,eax
       je        short M02_L10
M02_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L07
M02_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M02_L12
       mov       rax,rsi
M02_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L12:
       test      r8d,r8d
       je        short M02_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFAC4C43390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,1F649402028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       mov       rsi,rcx
       mov       ebx,edx
       mov       rdi,r8
       mov       r14d,r9d
       mov       r15d,[rbp+30]
       mov       r12d,[rbp+38]
M03_L00:
       cmp       r12d,5
       ja        near ptr M03_L10
       test      rsi,rsi
       je        near ptr M03_L11
       test      rdi,rdi
       je        near ptr M03_L11
       test      r15d,r15d
       jl        near ptr M03_L13
       test      ebx,ebx
       jl        near ptr M03_L15
       test      r14d,r14d
       jl        near ptr M03_L14
       mov       r13d,[rsi+8]
       sub       r13d,ebx
       js        near ptr M03_L18
       mov       r10d,[rdi+8]
       sub       r10d,r14d
       js        near ptr M03_L17
       test      r15d,r15d
       je        short M03_L06
       cmp       rsi,rdi
       je        short M03_L05
M03_L01:
       cmp       r15d,r13d
       jg        short M03_L08
       mov       eax,r15d
M03_L02:
       mov       r13d,eax
       cmp       r15d,r10d
       jg        short M03_L07
M03_L03:
       cmp       r12d,4
       ja        short M03_L04
       mov       r8d,r12d
       lea       rcx,[7FFAC4BE26F0]
       mov       ecx,[rcx+r8*4]
       lea       rdx,[M03_L00]
       add       rcx,rdx
       jmp       rcx
M03_L04:
       movsxd    r8,ebx
       lea       rcx,[rsi+r8*2+0C]
       movsxd    r8,r14d
       lea       r8,[rdi+r8*2+0C]
       mov       edx,r13d
       mov       r9d,r15d
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFAC4DC1000]; System.Globalization.Ordinal.CompareStringIgnoreCase(Char ByRef, Int32, Char ByRef, Int32)
M03_L05:
       cmp       ebx,r14d
       jne       short M03_L01
M03_L06:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L07:
       mov       r15d,r10d
       jmp       short M03_L03
M03_L08:
       mov       eax,r13d
       jmp       short M03_L02
       mov       r8d,ebx
       lea       rcx,[rsi+r8*2+0C]
       mov       r8d,r14d
       lea       r8,[rdi+r8*2+0C]
       mov       edx,r13d
       mov       r9d,r15d
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFAC4C4F318]
M03_L09:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L10:
       mov       ecx,1A
       mov       edx,2A
       call      qword ptr [7FFAC4E07768]
       int       3
M03_L11:
       cmp       rsi,rdi
       je        short M03_L06
       test      rsi,rsi
       je        short M03_L12
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L12:
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,57
       mov       rdx,7FFAC49F4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A1CF
       mov       rdx,7FFAC49F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4C6D030]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFAC4DE5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L14:
       mov       rcx,1F645400B60
       mov       r15,[rcx]
       jmp       short M03_L16
M03_L15:
       mov       rcx,1F645400B68
       mov       r15,[rcx]
M03_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,9A9B
       mov       rdx,7FFAC49F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4C6D030]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r12
       call      qword ptr [7FFAC4DE5750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M03_L17:
       mov       rcx,1F645400B60
       mov       rsi,[rcx]
       jmp       short M03_L19
M03_L18:
       mov       rcx,1F645400B68
       mov       rsi,[rcx]
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9A9B
       mov       rdx,7FFAC49F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4C6D030]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DE5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      qword ptr [7FFAC4DA98A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       [rsp+20],rdi
       mov       [rsp+28],r14d
       mov       [rsp+30],r15d
       and       r12d,1
       mov       [rsp+38],r12d
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9d,r13d
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4FB3210]
       jmp       near ptr M03_L09
       mov       rcx,7FFAC4B14C08
       mov       edx,23B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F6494004E0
       mov       rcx,[rcx]
       mov       [rsp+20],rdi
       mov       [rsp+28],r14d
       mov       [rsp+30],r15d
       mov       edx,r12d
       and       edx,1
       mov       [rsp+38],edx
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9d,r13d
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4FB3210]
       jmp       near ptr M03_L09
; Total bytes of code 828
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
       call      DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
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
; Total bytes of code 85
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L15
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L16
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L14
       cmp       eax,esi
       jle       near ptr M01_L17
       test      ebx,ebx
       jne       short M01_L03
       mov       rax,1E75F103020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       add       ebx,esi
       jo        near ptr M01_L14
       sub       ebx,1
       jo        near ptr M01_L14
       jmp       short M01_L05
M01_L04:
       add       esi,1
       jo        near ptr M01_L14
M01_L05:
       cmp       esi,ebx
       jg        short M01_L08
       cmp       esi,ebp
       jae       near ptr M01_L18
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L06
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L06:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L04
       jmp       short M01_L08
M01_L07:
       sub       ebx,1
       jo        near ptr M01_L14
M01_L08:
       cmp       ebx,esi
       jl        short M01_L10
       cmp       ebx,ebp
       jae       near ptr M01_L18
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       cmp       ecx,100
       jae       near ptr M01_L18
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L07
       jmp       short M01_L10
M01_L09:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L07
M01_L10:
       sub       ebx,esi
       jo        short M01_L14
       add       ebx,1
       jo        short M01_L14
       cmp       ebp,ebx
       je        short M01_L11
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L12
M01_L11:
       mov       rax,rdi
M01_L12:
       test      ebx,ebx
       je        short M01_L13
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       mov       rax,1E75F103020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
M01_L15:
       mov       ecx,0AC4
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L16:
       mov       ecx,0A6A
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L17:
       mov       ecx,0ADA
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AC4
       mov       rdx,7FFAC4164D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FFAC4EC34E0]; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50B3BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFAC4EC5DB0]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFAC4E852A0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       jne       near ptr M01_L04
       mov       rax,2B0A4408598
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFAC4EC5DB0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC4EC59F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4DE5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       jne       near ptr M01_L06
       mov       rax,2B0A4408590
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFAC4EC5DB0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFAC4EC59F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4DE5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L20
       cmp       eax,esi
       jg        near ptr M01_L08
       mov       rax,2B0A4408598
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L07
       call      qword ptr [7FFAC4EC5DB0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFAC4E46708
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFAC4EC3828]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFAC4EC59D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFAC4DAFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L07:
       mov       edx,3
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,0ADA
       mov       rdx,7FFAC4E852A0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       call      qword ptr [7FFAC4EC59F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAC4EC7000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFAC4DE5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       test      ebx,ebx
       jne       short M01_L09
       mov       rax,2B0A4402028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L09:
       add       ebx,esi
       jo        near ptr M01_L20
       sub       ebx,1
       jo        near ptr M01_L20
       jmp       short M01_L11
M01_L10:
       add       esi,1
       jo        near ptr M01_L20
M01_L11:
       cmp       esi,ebx
       jg        short M01_L14
       cmp       esi,ebp
       jae       near ptr M01_L21
       mov       ecx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       jne       short M01_L10
       jmp       short M01_L14
M01_L12:
       call      qword ptr [7FFAC50B94F8]
       test      eax,eax
       jne       short M01_L10
       jmp       short M01_L14
M01_L13:
       sub       ebx,1
       jo        short M01_L20
M01_L14:
       cmp       ebx,esi
       jl        short M01_L16
       cmp       ebx,ebp
       jae       short M01_L21
       mov       ecx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       jne       short M01_L13
       jmp       short M01_L16
M01_L15:
       call      qword ptr [7FFAC50B94F8]
       test      eax,eax
       jne       short M01_L13
M01_L16:
       sub       ebx,esi
       jo        short M01_L20
       add       ebx,1
       jo        short M01_L20
       cmp       ebp,ebx
       je        short M01_L17
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      qword ptr [7FFAC4C43360]; System.String.Substring(Int32, Int32)
       jmp       short M01_L18
M01_L17:
       mov       rax,rdi
M01_L18:
       test      ebx,ebx
       je        short M01_L19
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L19:
       mov       rax,2B0A4402028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L20:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1303
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
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
       mov       rdx,2BC75222A98
       mov       rbx,[rdx]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+10],0FFFFFFFF
       mov       rcx,rdi
       call      qword ptr [7FFAC418EBF8]; System.CharEnumerator.MoveNext()
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M00_L00
       jmp       short M00_L01
M00_L00:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rbx,rax
M00_L01:
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 164
```
```assembly
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
       movsxd    rax,eax
       movzx     eax,word ptr [rdx+rax*2+0C]
       mov       [rcx+14],ax
       mov       eax,1
       add       rsp,28
       ret
M01_L00:
       mov       eax,[rdx+8]
       mov       [rcx+10],eax
       xor       eax,eax
       add       rsp,28
       ret
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 74
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFAC3FB4928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,2BC95221578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,2BC95221558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
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
       cmp       qword ptr [rsp+88],0
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
       mov       rdx,2BC75222AA0
       mov       rdx,[rdx]
       mov       r8d,5
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       mov       ebx,eax
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L38
M03_L01:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L02
       mov       edx,1
       jmp       short M03_L03
M03_L02:
       mov       edx,2
M03_L03:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L30
       test      ebx,ebx
       je        near ptr M03_L06
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15-1]
       cmp       edx,ebp
       jle       short M03_L06
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       movsxd    rcx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L04
       cmp       edx,49
       jne       short M03_L06
M03_L04:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movsxd    rcx,ecx
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L05
       cmp       edx,4A
       jne       short M03_L06
M03_L05:
       mov       rdx,2BC75222AA8
       mov       rdx,[rdx]
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       short M03_L07
M03_L06:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L07:
       mov       r12d,ebp
       cmp       r14d,1
       sete      r13b
       movzx     r13d,r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L19
M03_L08:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L09
       mov       edx,1
       jmp       short M03_L10
M03_L09:
       mov       edx,2
M03_L10:
       mov       [rcx],edx
       mov       ecx,eax
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L11
       cmp       r14d,1
       je        short M03_L11
       cmp       r14d,2
       je        short M03_L11
       cmp       r14d,3
       je        short M03_L11
       cmp       r14d,4
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M03_L11
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       movsxd    rdx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L17
       jmp       short M03_L13
M03_L11:
       cmp       r14d,1
       jne       short M03_L12
       mov       r13d,1
M03_L12:
       add       ebp,[rsp+2C]
       jmp       short M03_L18
M03_L13:
       inc       ebp
       test      r13d,r13d
       je        short M03_L15
       test      rdi,rdi
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L14:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L16
M03_L15:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L16:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L18
M03_L17:
       mov       edx,1
       mov       ecx,r14d
       shl       edx,cl
       test      edx,1FFCF800
       jne       short M03_L19
       add       ebp,[rsp+2C]
M03_L18:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L08
M03_L19:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L22
       test      r13d,r13d
       je        short M03_L21
       test      rdi,rdi
       jne       short M03_L20
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L20:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L22:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L37
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L25
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L24
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L26
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L28
M03_L24:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L23
M03_L25:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r15,[rcx+8]
       mov       r14d,[r15+8]
       cmp       r14d,eax
       jbe       short M03_L27
       jmp       short M03_L29
M03_L26:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L28
M03_L27:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r12d,ebp
M03_L28:
       mov       ebp,r12d
       jmp       near ptr M03_L37
M03_L29:
       movsxd    rax,eax
       mov       [r15+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L28
M03_L30:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L33
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       movsxd    r8,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
M03_L31:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       movsxd    r8,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r10d,[r9+8]
       cmp       r10d,eax
       jbe       short M03_L34
       cmp       eax,r10d
       jae       near ptr M03_L41
       movsxd    rax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L36
M03_L32:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L31
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       movsxd    r8,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r14,[rcx+8]
       mov       r12d,[r14+8]
       cmp       r12d,eax
       jbe       short M03_L35
       jmp       short M03_L39
M03_L34:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       short M03_L36
M03_L35:
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r14d,ebp
M03_L36:
       mov       ebp,r14d
M03_L37:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L01
M03_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4139E58]; System.Text.StringBuilder.ToString()
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
M03_L39:
       cmp       eax,r12d
       jae       short M03_L41
       movsxd    rax,eax
       mov       [r14+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L36
M03_L40:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1962
       mov       rdx,7FFAC3EA4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1540
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
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
       mov       rdx,2294E404B20
       mov       rbx,[rdx]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+10],0FFFFFFFF
       mov       rcx,rdi
       call      qword ptr [7FFAC4E9FAB0]; System.CharEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L00
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAC4DB98A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4DBF870]; System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rbx,rax
M00_L01:
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50C3FA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
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
       mov       eax,eax
       movzx     eax,word ptr [rdx+rax*2+0C]
       mov       [rcx+14],ax
       mov       eax,1
       add       rsp,28
       ret
M01_L00:
       mov       eax,[rdx+8]
       mov       [rcx+10],eax
       xor       eax,eax
       add       rsp,28
       ret
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 73
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFAC4B24C08
       mov       edx,244
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,2294C400538
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,2294C400518
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       qword ptr [7FFAC4DB9750]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 84
```
```assembly
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
       mov       rax,[rsp+88]
       test      rax,rax
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
       cmp       dword ptr [rcx+8],3
       jl        short M03_L01
       mov       edx,[rcx+0C]
       or        edx,200020
       xor       edx,6C006E
       mov       ecx,[rcx+0E]
       or        ecx,20
       xor       ecx,2D006C
       or        ecx,edx
       sete      cl
       movzx     ecx,cl
       jmp       short M03_L02
M03_L01:
       xor       ecx,ecx
M03_L02:
       movzx     ebx,cl
       xor       ebp,ebp
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jle       near ptr M03_L39
M03_L03:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      qword ptr [7FFAC50C3E10]; System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L04
       mov       edx,1
       jmp       short M03_L05
M03_L04:
       mov       edx,2
M03_L05:
       mov       [rcx],edx
       mov       ecx,eax
       call      qword ptr [7FFAC50C3DF8]; System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       cmp       r14d,4
       ja        near ptr M03_L31
       test      ebx,ebx
       je        near ptr M03_L08
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       lea       edx,[r15-1]
       cmp       edx,ebp
       jle       short M03_L08
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       mov       ecx,ebp
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,69
       je        short M03_L06
       cmp       edx,49
       jne       short M03_L08
M03_L06:
       lea       edx,[rbp+1]
       cmp       edx,r15d
       jae       near ptr M03_L41
       mov       rdx,[rsp+88]
       lea       ecx,[rbp+1]
       movzx     edx,word ptr [rdx+rcx*2+0C]
       cmp       edx,6A
       je        short M03_L07
       cmp       edx,4A
       jne       short M03_L08
M03_L07:
       mov       rcx,[rsp+30]
       cmp       [rcx],cl
       mov       rdx,2294E404B28
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,2
       call      qword ptr [7FFAC4E4B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       add       ebp,2
       jmp       short M03_L09
M03_L08:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      qword ptr [7FFAC4DBF8A0]; System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M03_L09:
       mov       r12d,ebp
       xor       r13d,r13d
       cmp       r14d,1
       sete      r13b
       mov       rcx,[rsp+88]
       cmp       [rcx+8],r12d
       jle       near ptr M03_L21
M03_L10:
       mov       rcx,[rsp+88]
       mov       edx,ebp
       call      qword ptr [7FFAC50C3E10]; System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
       lea       rcx,[rsp+2C]
       cmp       eax,10000
       jae       short M03_L11
       mov       edx,1
       jmp       short M03_L12
M03_L11:
       mov       edx,2
M03_L12:
       mov       [rcx],edx
       mov       ecx,eax
       call      qword ptr [7FFAC50C3DF8]; System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L13
       cmp       r14d,1
       je        short M03_L13
       cmp       r14d,2
       je        short M03_L13
       cmp       r14d,3
       je        short M03_L13
       cmp       r14d,4
       je        short M03_L13
       mov       rcx,[rsp+88]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L41
       mov       rcx,[rsp+88]
       mov       edx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       jne       short M03_L19
       jmp       short M03_L15
M03_L13:
       cmp       r14d,1
       jne       short M03_L14
       mov       r13d,1
M03_L14:
       add       ebp,[rsp+2C]
       jmp       short M03_L20
M03_L15:
       inc       ebp
       test      r13d,r13d
       je        short M03_L17
       test      rdi,rdi
       jne       short M03_L16
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      qword ptr [7FFAC4DBF6A8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L16:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4E4B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L18
M03_L17:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4E4B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L18:
       mov       r12d,ebp
       mov       r13d,1
       jmp       short M03_L20
M03_L19:
       mov       ecx,1
       shlx      ecx,ecx,r14d
       test      ecx,1FFCF800
       jne       short M03_L21
       add       ebp,[rsp+2C]
M03_L20:
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L10
M03_L21:
       mov       r15d,ebp
       sub       r15d,r12d
       test      r15d,r15d
       jle       short M03_L24
       test      r13d,r13d
       je        short M03_L23
       test      rdi,rdi
       jne       short M03_L22
       mov       rcx,rsi
       mov       rdx,[rsp+88]
       call      qword ptr [7FFAC4DBF6A8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L22:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4E4B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L24
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4E4B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
M03_L24:
       mov       rcx,[rsp+88]
       mov       r13d,[rcx+8]
       cmp       r13d,ebp
       jle       near ptr M03_L38
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L28
       lea       ecx,[rbp+1]
       mov       r12d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r14d,[rax+8]
       cmp       r14d,r8d
       jbe       short M03_L25
       mov       r8d,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
       jmp       short M03_L26
M03_L25:
       mov       r8d,1
       call      qword ptr [7FFAC4E4B258]
M03_L26:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r12d,[rdx+8]
       jae       near ptr M03_L41
       mov       r8d,r12d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       cmp       [r9+8],eax
       jbe       short M03_L27
       mov       eax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L30
M03_L27:
       mov       r8d,1
       call      qword ptr [7FFAC4E4B258]
       jmp       short M03_L30
M03_L28:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       ebp,r13d
       jae       near ptr M03_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r14d,[r9+8]
       cmp       r14d,eax
       jbe       short M03_L29
       cmp       eax,r14d
       jae       near ptr M03_L41
       mov       eax,eax
       mov       [r9+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r12d,ebp
       jmp       short M03_L30
M03_L29:
       mov       r8d,1
       call      qword ptr [7FFAC4E4B258]
       mov       r12d,ebp
M03_L30:
       mov       ebp,r12d
       jmp       near ptr M03_L38
M03_L31:
       mov       ecx,[rsp+2C]
       cmp       ecx,2
       jne       near ptr M03_L35
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       ebp,[rcx+18]
       mov       r8d,ebp
       mov       rax,[rcx+8]
       mov       r12d,[rax+8]
       cmp       r12d,r8d
       jbe       short M03_L32
       cmp       r8d,r12d
       jae       near ptr M03_L41
       mov       r8d,r8d
       mov       [rax+r8*2+10],dx
       inc       ebp
       mov       [rcx+18],ebp
       jmp       short M03_L33
M03_L32:
       mov       r8d,1
       call      qword ptr [7FFAC4E4B258]
M03_L33:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       cmp       r14d,[rdx+8]
       jae       near ptr M03_L41
       mov       r8d,r14d
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       cmp       [r9+8],eax
       jbe       short M03_L34
       cmp       eax,[r9+8]
       jae       near ptr M03_L41
       mov       eax,eax
       mov       [r9+rax*2+10],dx
       inc       r8d
       mov       [rcx+18],r8d
       jmp       short M03_L37
M03_L34:
       mov       r8d,1
       call      qword ptr [7FFAC4E4B258]
       jmp       short M03_L37
M03_L35:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r15d,[rdx+8]
       cmp       ebp,r15d
       jae       near ptr M03_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rdx+r8*2+0C]
       mov       r8d,[rcx+18]
       mov       eax,r8d
       mov       r9,[rcx+8]
       mov       r12d,[r9+8]
       cmp       r12d,eax
       jbe       short M03_L36
       cmp       eax,r12d
       jae       short M03_L41
       mov       eax,eax
       mov       [r9+rax*2+10],dx
       lea       edx,[r8+1]
       mov       [rcx+18],edx
       mov       r14d,ebp
       jmp       short M03_L37
M03_L36:
       mov       r8d,1
       call      qword ptr [7FFAC4E4B258]
       mov       r14d,ebp
M03_L37:
       mov       ebp,r14d
M03_L38:
       inc       ebp
       mov       rcx,[rsp+88]
       cmp       [rcx+8],ebp
       jg        near ptr M03_L03
M03_L39:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4E3CE30]; System.Text.StringBuilder.ToString()
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
M03_L40:
       mov       ecx,15FB
       mov       rdx,7FFAC4A04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4DBFF90]
       int       3
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1553
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
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
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
M00_L01:
       mov       [rsp+20],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFAC3EB0570
       call      qword ptr [7FFAC3EB0570]
       mov       rcx,rax
       mov       r11,7FFAC3EB0578
       call      qword ptr [7FFAC3EB0578]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 67
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
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
       movsxd    rcx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     r12b
       movzx     r12d,r12b
       test      r12d,r12d
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r12d,al
       test      r12d,r12d
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        short M02_L07
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M02_L07
M02_L04:
       cmp       r14d,ebx
       jae       near ptr M02_L11
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       cmp       ecx,100
       jae       near ptr M02_L11
       movsxd    rcx,ecx
       mov       rax,7FFB195E11B8
       test      byte ptr [rcx+rax],80
       setne     dil
       movzx     edi,dil
       test      edi,edi
       je        short M02_L07
       jmp       short M02_L06
M02_L05:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     edi,al
       test      edi,edi
       je        short M02_L07
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
M02_L07:
       sub       r14d,r15d
       lea       ecx,[r14+1]
       cmp       ebx,ecx
       jne       short M02_L09
       mov       rax,rsi
M02_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L09:
       test      ecx,ecx
       je        short M02_L10
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,[rbx+8]
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       eax,r15d
       lea       rdx,[rdx+rax*2]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
       jmp       short M02_L08
M02_L10:
       mov       rax,18D792E3020
       mov       rax,[rax]
       jmp       short M02_L08
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FFAC4EC91C8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,2
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFAC4C43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
M00_L01:
       mov       [rsp+20],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFAC50B3BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FFAC4A005A8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FFAC4A005B0
       call      qword ptr [r11]
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       eax,1
       add       rsp,28
       ret
; Total bytes of code 61
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
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
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFAC50B94F8]
       test      eax,eax
       je        short M02_L03
M02_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M02_L00
M02_L03:
       test      dil,2
       je        near ptr M02_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M02_L10
       test      r14d,r14d
       jl        short M02_L07
       test      r15d,r15d
       jl        short M02_L07
       cmp       ebx,r14d
       jle       short M02_L07
M02_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFAC50B94F8]
       test      eax,eax
       je        short M02_L10
M02_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L04
       jmp       short M02_L10
M02_L07:
       cmp       r14d,ebx
       jae       short M02_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L08
       mov       ecx,ecx
       mov       rax,7FFB18AED5D0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFAC50B94F8]
       test      eax,eax
       je        short M02_L10
M02_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M02_L07
M02_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M02_L12
       mov       rax,rsi
M02_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L12:
       test      r8d,r8d
       je        short M02_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFAC4C43390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,166D2002028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

