## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,[rcx+1C0]
       test      r8,r8
       jne       short M00_L00
       mov       r8,16E8F8B85C0
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,[rcx+1C0]
       test      r8,r8
       jne       short M00_L00
       mov       r8,22145C01A90
       mov       r8,[r8]
M00_L00:
       mov       [rsp+20],r8
       mov       rcx,[rcx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA27FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,2A3C298A5B8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,2650C009670
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       rcx,[rcx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA17FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValueFromNull()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1C0]
       mov       rdx,1B25F59A5B8
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
       mov       rdx,7FFF7DCD4CD8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rax,18256409670
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
       call      qword ptr [7FFF7B847450]
       mov       rdi,rax
       mov       ecx,0A1E
       mov       rdx,7FFF7B8055E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L00:
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7BA07FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7B847450]
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
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
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
       jmp       qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA0DB10]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA0DB10]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA0DB10]
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
       call      qword ptr [7FFF7B5C3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,18256402028
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,2267D13A5B8
       mov       rcx,[rcx]
       mov       rdx,2267D13A5C0
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
       mov       rdx,7FFF7DCD4CD8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rax,1A0AF401A98
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
       call      qword ptr [7FFF7B877450]
       mov       rsi,rax
       mov       ecx,0A1E
       mov       rdx,7FFF7B8355E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L00:
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,1A0AF401A90
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA39330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7B877450]
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
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
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
       jmp       qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA3F0F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA3F0F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA3F0F0]
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
       call      qword ptr [7FFF7B5F3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,1A0A1402028
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FFF7DCC4CD8
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
       mov       rdx,7FFF7DCC4CD8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,64
       call      qword ptr [7FFF7B8635E8]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA29318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B867450]
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8255E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B863C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B867078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B867510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7B867318]
       mov       rdi,rax
       mov       rcx,24B8AC08590
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L05
       call      qword ptr [7FFF7B867450]
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B863C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B867078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B867510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B867090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B867510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B775750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       test      rcx,rcx
       je        short M01_L07
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FFF7DCC4CD8
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
       mov       rdx,7FFF7DCC4CD8
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
       mov       rdx,7FFF7DCC4CD8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       edx,5
       mov       r8d,64
       call      qword ptr [7FFF7B853630]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA19318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B857450]
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8155E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B853C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B857078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B857510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7B857318]
       mov       rbx,rax
       mov       rax,152CCC08780
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7B857450]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B853C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B857078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7B857510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B857090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7B857510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B765750]
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
       call      qword ptr [7FFF7B857318]
       mov       rbp,rax
       mov       rax,152CCC08788
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L09
       call      qword ptr [7FFF7B857450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B853C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B857078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B857510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B857090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7B857510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B765750]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,261000761B0
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L01
       mov       rcx,261000761B8
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
       mov       rax,7FFFDCC711B8
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
       mov       rax,7FFFDCC711B8
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
       mov       rax,26120073020
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
       mov       r9,26100074058
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
       mov       rcx,26120071568
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,21455804E80
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
       mov       rcx,21455804E88
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,rbx
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FFF7B8D50F0]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
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
       call      qword ptr [7FFF7B8D53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       call      qword ptr [7FFF7BA39AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFF7BA3F978]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF7BA3F978]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L09
M01_L08:
       call      qword ptr [7FFF7BA3F978]
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
       call      qword ptr [7FFF7B5D3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M01_L11
M01_L13:
       mov       rax,21455802028
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
       mov       r9,21451803448
       mov       r9,[r9]
       mov       r9,[r9+8]
       call      qword ptr [7FFF7B8D5138]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
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
       call      qword ptr [7FFF7BA39090]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FFF7BA39078]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       mov       rcx,7FFF7B8BBC30
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,21451803438
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
       call      qword ptr [7FFF7BA39990]
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
       mov       rcx,7FFF7B8BBC30
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,21451803438
       mov       r15,[rdx]
       jmp       short M03_L12
M03_L10:
       mov       ecx,21
       call      qword ptr [7FFF7B7977E0]
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
       call      qword ptr [7FFF7BA0BFC0]; System.Text.RegularExpressions.RegexInterpreterFactory.CreateInstance()
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
       call      qword ptr [7FFF7BA89300]
       int       3
M03_L17:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFF7BA89300]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,2667047A5B8
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
       mov       rax,7FFFDCC711B8
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
       mov       rax,7FFFDCC711B8
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
       mov       rax,26670473020
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
       lea       rcx,[7FFF7DD93DE0]
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
       mov       rdx,7FFF7D9E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rsi,rax
       mov       ecx,196A
       mov       rdx,7FFF7D9E4000
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
       mov       rcx,7FFF7DAF4928
       mov       edx,227
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       r9,26670471520
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7BA47FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFF7BA4D7C8]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF7BA4D7C8]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L09
M01_L08:
       call      qword ptr [7FFF7BA4D7C8]
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
       call      qword ptr [7FFF7B603390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M01_L11
M01_L13:
       mov       rax,21300402028
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,1C4E1A01AD0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
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
       mov       rdx,7FFF7DCB4CD8
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
       mov       [rsp+30],rcx
       test      rsi,rsi
       jne       short M01_L03
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       rax,[rsi]
       mov       rax,[rax+58]
       mov       rax,[rax+10]
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 140
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rax,18D6D400AD8
       mov       rdi,[rax]
       test      rdx,rdx
       je        short M00_L00
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       ecx,ecx
M00_L01:
       test      ecx,ecx
       jne       near ptr M00_L02
       call      qword ptr [7FFF7B857450]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8155E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B853C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B857078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B857510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B5C27A0]; System.Text.Encoding.GetBytes(System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA19360]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 304
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
       call      qword ptr [7FFF7B857450]
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
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B853C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B857078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B857510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
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
       jmp       qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA450F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA450F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA450F0]
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
       call      qword ptr [7FFF7B5D3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,18D6D402028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rdi
       mov       rdx,rsi
       mov       rbx,[rdi]
       mov       rax,[rbx+50]
       call      qword ptr [rax+18]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rsi+8]
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbx+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,1C81
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B73FF90]
       int       3
; Total bytes of code 131
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,221A63A1B80
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
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
       mov       rdx,7FFF7DCE4CD8
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
       mov       [rsp+30],rcx
       test      rsi,rsi
       jne       short M01_L03
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       rax,[rsi]
       mov       rax,[rax+58]
       mov       rax,[rax+10]
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 140
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rax,25320C00B88
       mov       rdi,[rax]
       test      rdx,rdx
       je        short M00_L00
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       ecx,ecx
M00_L01:
       test      ecx,ecx
       jne       near ptr M00_L02
       call      qword ptr [7FFF7B887450]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8455E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B883C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B887078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B5F27A0]; System.Text.Encoding.GetBytes(System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA47FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 304
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
       call      qword ptr [7FFF7B887450]
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
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B883C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B887078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
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
       jmp       qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA4F0F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA4F0F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA4F0F0]
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
       call      qword ptr [7FFF7B603390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,25320C02028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rdi
       mov       rdx,rsi
       mov       rbx,[rdi]
       mov       rax,[rbx+50]
       call      qword ptr [rax+18]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rsi+8]
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbx+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,1C81
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B76FF90]
       int       3
; Total bytes of code 131
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,2BBA1601B08
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
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
       mov       rdx,7FFF7DCD4CD8
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
       mov       [rsp+30],rcx
       test      rsi,rsi
       jne       short M01_L03
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       rax,[rsi]
       mov       rax,[rax+58]
       mov       rax,[rax+10]
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 140
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rax,15259800B10
       mov       rdi,[rax]
       test      rdx,rdx
       je        short M00_L00
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       ecx,ecx
M00_L01:
       test      ecx,ecx
       jne       near ptr M00_L02
       call      qword ptr [7FFF7B857450]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8155E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B853C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B857078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B857510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L04
       cmp       dword ptr [rdx+8],20
       jg        short M00_L04
       mov       rcx,rdi
       call      qword ptr [7FFF7B7CBB88]
M00_L03:
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA17FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF7B5C27A0]; System.Text.Encoding.GetBytes(System.String)
       jmp       short M00_L03
; Total bytes of code 326
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
       call      qword ptr [7FFF7B857450]
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
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7D6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B853C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B857078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B857510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B73FF18]
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
       jmp       qword ptr [7FFF7B5D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA1F0F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA1F0F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA1F0F0]
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
       call      qword ptr [7FFF7B5D3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,15259802028
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
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rdi
       mov       rdx,rsi
       mov       rbx,[rdi]
       mov       rax,[rbx+50]
       call      qword ptr [rax+18]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rsi+8]
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbx+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L00:
       mov       ecx,1C81
       mov       rdx,7FFF7B384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B73FF90]
       int       3
; Total bytes of code 131
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,22EF9741B60
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
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
       mov       rdx,7FFF7DCA4CD8
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
       mov       [rsp+30],rcx
       test      rsi,rsi
       jne       short M01_L03
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       rax,[rsi]
       mov       rax,[rax+58]
       mov       rax,[rax+10]
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 140
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rax,1C6A6800B68
       mov       rdi,[rax]
       test      rdx,rdx
       je        short M00_L00
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       ecx,ecx
M00_L01:
       test      ecx,ecx
       jne       near ptr M00_L02
       call      qword ptr [7FFF7B847450]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8055E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B5B27A0]; System.Text.Encoding.GetBytes(System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA0B030]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 304
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
       call      qword ptr [7FFF7B847450]
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
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
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
       jmp       qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA316C0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA316C0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA316C0]
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
       call      qword ptr [7FFF7B5C3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,1C6A6802028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rdi
       mov       rdx,rsi
       mov       rbx,[rdi]
       mov       rax,[rbx+50]
       call      qword ptr [rax+18]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rsi+8]
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbx+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,1C81
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B72FF90]
       int       3
; Total bytes of code 131
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,1B2EE2E1B88
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
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
       mov       rdx,7FFF7DCB4CD8
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
       mov       [rsp+30],rcx
       test      rsi,rsi
       jne       short M01_L03
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       rax,[rsi]
       mov       rax,[rax+58]
       mov       rax,[rax+10]
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 140
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rax,2462FC00B90
       mov       rdi,[rax]
       test      rdx,rdx
       je        short M00_L00
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       ecx,ecx
M00_L01:
       test      ecx,ecx
       jne       near ptr M00_L02
       call      qword ptr [7FFF7B847450]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8055E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B5B27A0]; System.Text.Encoding.GetBytes(System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA07FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 304
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
       call      qword ptr [7FFF7B847450]
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
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
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
       jmp       qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA0F0F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA0F0F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA0F0F0]
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
       call      qword ptr [7FFF7B5C3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,2462FC02028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rdi
       mov       rdx,rsi
       mov       rbx,[rdi]
       mov       rax,[rbx+50]
       call      qword ptr [rax+18]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rsi+8]
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbx+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,1C81
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B72FF90]
       int       3
; Total bytes of code 131
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,18A19321B90
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
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
       mov       rdx,7FFF7DCE4CD8
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
       mov       [rsp+30],rcx
       test      rsi,rsi
       jne       short M01_L03
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       rax,[rsi]
       mov       rax,[rax+58]
       mov       rax,[rax+10]
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 140
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rax,1E628C00B98
       mov       rdi,[rax]
       test      rdx,rdx
       je        short M00_L00
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       ecx,ecx
M00_L01:
       test      ecx,ecx
       jne       near ptr M00_L02
       call      qword ptr [7FFF7B847450]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8055E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B5B27A0]; System.Text.Encoding.GetBytes(System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA09570]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 304
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
       call      qword ptr [7FFF7B847450]
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
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
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
       jmp       qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA0F3D8]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA0F3D8]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA0F3D8]
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
       call      qword ptr [7FFF7B5C3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,1E628C02028
       mov       rax,[rax]
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rdi
       mov       rdx,rsi
       mov       rbx,[rdi]
       mov       rax,[rbx+50]
       call      qword ptr [rax+18]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rsi+8]
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbx+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       ecx,1C81
       mov       rdx,7FFF7B374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B72FF90]
       int       3
; Total bytes of code 131
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,1FE99891BA8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
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
       mov       rdx,7FFF7DCB4CD8
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
       mov       [rsp+30],rcx
       test      rsi,rsi
       jne       short M01_L03
       xor       eax,eax
       add       rsp,20
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,[rsp+30]
       mov       rax,[rsi]
       mov       rax,[rax+58]
       mov       rax,[rax+10]
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 140
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rax,19F62800BB0
       mov       rdi,[rax]
       test      rdx,rdx
       je        short M00_L00
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       ecx,ecx
M00_L01:
       test      ecx,ecx
       jne       near ptr M00_L02
       call      qword ptr [7FFF7B877450]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8355E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L04
       cmp       dword ptr [rdx+8],20
       jg        short M00_L04
       mov       rcx,rdi
       call      qword ptr [7FFF7B7EBB88]
M00_L03:
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Byte[], System.Private.CoreLib]](Byte[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA39330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF7B5E27A0]; System.Text.Encoding.GetBytes(System.String)
       jmp       short M00_L03
; Total bytes of code 326
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
       call      qword ptr [7FFF7B877450]
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
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
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
       jmp       qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA3F3F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA3F3F0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA3F3F0]
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
       call      qword ptr [7FFF7B5F3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,19F5E800030
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
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rdi
       mov       rdx,rsi
       mov       rbx,[rdi]
       mov       rax,[rbx+50]
       call      qword ptr [rax+18]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rsi+8]
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbx+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L00:
       mov       ecx,1C81
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B75FF90]
       int       3
; Total bytes of code 131
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.CombineToString()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.String, System.Private.CoreLib]](System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       rdx,rax
       mov       r8,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.String, System.Private.CoreLib]](System.String[], System.String)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       xor       ecx,ecx
       call      DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+20],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
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
       mov       rdx,7FFF7DE771D8
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
       mov       rdx,7FFF7DCD4CD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFF7DCD4CD8
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
       mov       ecx,esi
       add       ecx,1
       jo        near ptr M02_L08
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,23A77F52EA0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF7DC8F1F8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L09
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
       jae       near ptr M02_L10
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
       jae       near ptr M02_L11
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
       je        near ptr M02_L12
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
       call      qword ptr [7FFF7DBC29C0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
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
       call      CORINFO_HELP_OVERFLOW
M02_L09:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L10:
       mov       rdx,23A77F53188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L11:
       mov       rdx,23A77F53188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L12:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 478
```
```assembly
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
       jne       short M03_L00
       mov       rax,rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L00:
       mov       rbx,[rsi+10]
       mov       rbp,rdx
       test      rbp,rbp
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rsi
       mov       rdx,7FFF7DFD5B38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbp
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M03_L03
       jmp       short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,7FFF7DFD6270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L04:
       mov       rdx,r14
       mov       r8,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M03_L05:
       mov       ecx,4D
       mov       rdx,7FFF7DCD4CD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFF7DCD4CD8
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
; Total bytes of code 246
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,7FFF7DC94E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23A77F57A48
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-28],rdx
       test      rdi,rdi
       je        short M04_L03
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M04_L03
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M04_L03
M04_L00:
       mov       rdx,[rbp-28]
       movsxd    rcx,r14d
       mov       rax,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M04_L01
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M04_L02
M04_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp-28]
       call      System.Text.StringBuilder.Append(System.String)
M04_L02:
       inc       r14d
       cmp       ebx,r14d
       jg        short M04_L00
M04_L03:
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,23A77F57A48
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,7FFF7DC94E18
       mov       edx,1B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23A77F57A48
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 301
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.CombineToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       jne       near ptr M00_L03
       call      qword ptr [7FFF7B847330]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L07
       lea       rcx,[rdi+0C]
       mov       rdx,1D01F808B10
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L08
       lea       rcx,[rdi+12]
       mov       rdx,1D01F802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rdi+8],0
       je        short M00_L02
       mov       rcx,rdi
M00_L00:
       test      rcx,rcx
       jne       short M00_L01
       mov       eax,1
       jmp       near ptr M00_L09
M00_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M00_L09
M00_L02:
       mov       rcx,1D01F802028
       mov       rcx,[rcx]
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFF7B849BE8]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rax,rax
       je        short M00_L04
       mov       edx,[rax+8]
       xor       ecx,ecx
       test      edx,edx
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      edx,edx
       jne       short M00_L05
       jmp       short M00_L05
M00_L04:
       xor       ecx,ecx
M00_L05:
       test      ecx,ecx
       jne       short M00_L06
       call      qword ptr [7FFF7B847450]
       mov       rsi,rax
       mov       ecx,78D
       mov       rdx,7FFF7B8055E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B8475A0]
       int       3
M00_L06:
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFF7BAD9FD8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFF7B7D56C0]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       rdx,rax
       mov       r8,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.String, System.Private.CoreLib]](System.String[], System.String)
       call      qword ptr [7FFF7BAFD6F0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFF7BAFD738]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAFF3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L10
       call      qword ptr [7FFF7B847450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B847078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 703
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
       jmp       qword ptr [7FFF7B609A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
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
       jne       near ptr M02_L03
       call      qword ptr [7FFF7B847330]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M02_L05
       lea       rcx,[rsi+0C]
       mov       rdx,1D01F808B10
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L06
       lea       rcx,[rsi+12]
       mov       rdx,1D01F802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M02_L02
       mov       rcx,rsi
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L07
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
M02_L02:
       mov       rcx,1D01F802028
       mov       rcx,[rcx]
       jmp       short M02_L00
M02_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFF7BA094F8]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M02_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M02_L04
       mov       rdx,rax
       call      qword ptr [7FFF7B52B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M02_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF7BAA9120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FFF7B847450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B847078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
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
       je        short M03_L03
       xor       r15d,r15d
       test      ebx,ebx
       jle       short M03_L03
M03_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L01
       mov       ecx,ecx
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M03_L03
       jmp       short M03_L02
M03_L01:
       call      qword ptr [7FFF7BB2D690]
       test      eax,eax
       je        short M03_L03
M03_L02:
       inc       r15d
       cmp       ebx,r15d
       jg        short M03_L00
M03_L03:
       test      dil,2
       je        near ptr M03_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M03_L10
       test      r14d,r14d
       jl        short M03_L07
       test      r15d,r15d
       jl        short M03_L07
       cmp       ebx,r14d
       jle       short M03_L07
M03_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L05
       mov       ecx,ecx
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M03_L10
       jmp       short M03_L06
M03_L05:
       call      qword ptr [7FFF7BB2D690]
       test      eax,eax
       je        short M03_L10
M03_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M03_L04
       jmp       short M03_L10
M03_L07:
       cmp       r14d,ebx
       jae       short M03_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L08
       mov       ecx,ecx
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M03_L10
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFF7BB2D690]
       test      eax,eax
       je        short M03_L10
M03_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M03_L07
M03_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       ebx,r8d
       jne       short M03_L12
       mov       rax,rsi
M03_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L12:
       test      r8d,r8d
       je        short M03_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFF7B5C3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M03_L11
M03_L13:
       mov       rax,1D01F802028
       mov       rax,[rax]
       jmp       short M03_L11
M03_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
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
       call      qword ptr [7FFF7BA0D150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF7BA0D330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M04_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M04_L01
       jmp       short M04_L01
M04_L00:
       xor       edx,edx
M04_L01:
       test      edx,edx
       jne       near ptr M04_L02
       call      qword ptr [7FFF7B847450]
       mov       rsi,rax
       mov       ecx,60F
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M04_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M04_L04
M04_L03:
       mov       rcx,rsi
       mov       rdx,7FFF7BAC2030
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFF7BADB048]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
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
       jle       short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       esi,1
M05_L01:
       mov       ecx,esi
       add       ecx,1
       jo        near ptr M05_L08
       cmp       edi,ecx
       jl        short M05_L02
       jmp       short M05_L03
M05_L02:
       mov       edi,ecx
M05_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,1D01F801ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF7B7C1710]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+30],rax
       test      rax,rax
       je        near ptr M05_L09
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M05_L04:
       mov       [rsp+40],r14
       mov       [rsp+48],r15d
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       byte ptr [rsp+3C],0
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FFF7B721DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+38]
       mov       rdx,[rsp+40]
       mov       eax,[rsp+48]
       cmp       ecx,eax
       jae       near ptr M05_L10
       mov       eax,ecx
       mov       word ptr [rdx+rax*2],2D
       inc       ecx
       mov       [rsp+38],ecx
M05_L05:
       lea       rcx,[rsp+28]
       mov       edx,esi
       call      qword ptr [7FFF7B721DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+38]
       mov       rdx,[rsp+40]
       mov       eax,[rsp+48]
       cmp       ecx,eax
       jae       near ptr M05_L11
       mov       eax,ecx
       mov       word ptr [rdx+rax*2],2D
       inc       ecx
       mov       [rsp+38],ecx
M05_L06:
       lea       rcx,[rsp+28]
       mov       edx,edi
       call      qword ptr [7FFF7B721DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF7B63D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,r12
       call      qword ptr [7FFF7B5CB2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M05_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      qword ptr [7FFF7B8433F0]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M05_L12
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF7BAFBB58]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,r12
       mov       r9d,2
       call      qword ptr [7FFF7B5CB318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M05_L07:
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,r12
       call      qword ptr [7FFF7B5CB2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M05_L13
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
M05_L08:
       call      CORINFO_HELP_OVERFLOW
M05_L09:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M05_L04
M05_L10:
       mov       rdx,1D01F802180
       mov       rdx,[rdx]
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF7B63DAF8]
       jmp       near ptr M05_L05
M05_L11:
       mov       rdx,1D01F802180
       mov       rdx,[rdx]
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF7B63DAF8]
       jmp       near ptr M05_L06
M05_L12:
       mov       ecx,10
       call      qword ptr [7FFF7B78B780]
       int       3
M05_L13:
       mov       rdx,r12
       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFF7BB794C8]
       int       3
; Total bytes of code 508
```
```assembly
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
       jne       short M06_L00
       mov       rax,rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L00:
       mov       rbx,[rsi+10]
       mov       rbp,rdx
       test      rbp,rbp
       jne       near ptr M06_L04
       call      qword ptr [7FFF7B847330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       dword ptr [r14+8],5
       jl        near ptr M06_L09
       lea       rcx,[r14+0C]
       mov       rdx,1D01F8085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r14+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M06_L10
       lea       rcx,[r14+16]
       mov       rdx,1D01F802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r14+8],0
       je        short M06_L03
       mov       rcx,r14
M06_L01:
       test      rcx,rcx
       jne       short M06_L02
       mov       eax,1
       jmp       near ptr M06_L11
M06_L02:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M06_L11
M06_L03:
       mov       rcx,1D01F802028
       mov       rcx,[rcx]
       jmp       short M06_L01
M06_L04:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M06_L05
       jmp       short M06_L06
M06_L05:
       mov       rcx,rsi
       mov       rdx,7FFF7BB02380
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbp
       call      qword ptr [7FFF7B637930]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M06_L07
       jmp       short M06_L08
M06_L07:
       mov       rcx,rsi
       mov       rdx,7FFF7BB02AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M06_L08:
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFF7BAFF258]; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>, System.__Canon)
       mov       rcx,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFF7B637F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M06_L09:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B751C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L11:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L12
       call      qword ptr [7FFF7B847450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L12:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B847078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 626
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,1D01F806A50
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFF7B80A790]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       test      rdi,rdi
       je        near ptr M07_L04
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M07_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M07_L04
M07_L00:
       mov       rdx,[rbp-38]
       mov       ecx,r15d
       mov       r12,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M07_L01
       cmp       [rdx],dl
       test      r12,r12
       je        short M07_L03
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M07_L03
M07_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M07_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M07_L02:
       mov       rdx,1D01F8084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFF7B7BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M07_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M07_L00
M07_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7B79D020]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFF7B80A798]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,1D01F806A50
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFF7B80A798]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 312
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
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
M09_L00:
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short M09_L01
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short M09_L03
       jmp       short M09_L02
M09_L01:
       xor       r9d,r9d
M09_L02:
       test      r8,r8
       je        short M09_L03
       cmp       dword ptr [r8+8],0
       je        short M09_L03
       mov       rcx,r8
       jmp       near ptr M09_L06
M09_L03:
       test      r9d,r9d
       jne       near ptr M09_L06
       call      qword ptr [7FFF7B847450]
       mov       rdi,rax
       test      rsi,rsi
       je        short M09_L04
       cmp       dword ptr [rsi+8],0
       je        short M09_L04
       jmp       short M09_L05
M09_L04:
       mov       rsi,rdi
M09_L05:
       mov       ecx,9
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7C6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B843C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B847078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B847510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B72FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M09_L06:
       test      dl,dl
       jne       short M09_L07
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L07:
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF7B5C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
; Total bytes of code 268
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,1ABB6D63190
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,0F
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
       mov       rdx,7FFF7DE87250
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
       mov       rdx,7FFF7DCE4CD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,785
       mov       rdx,7FFF7DCE4CD8
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
       mov       ecx,esi
       add       ecx,1
       jo        near ptr M02_L08
       cmp       edi,ecx
       jl        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       edi,ecx
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,1ABB6D62EA0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF7DC8F1F8]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       r14,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L09
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
       jae       near ptr M02_L10
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
       jae       near ptr M02_L11
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
       je        near ptr M02_L12
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
       call      qword ptr [7FFF7DBC29C0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
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
       call      CORINFO_HELP_OVERFLOW
M02_L09:
       xor       r8d,r8d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L10:
       mov       rdx,1ABB6D63188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L05
M02_L11:
       mov       rdx,1ABB6D63188
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.GrowThenCopyString(System.String)
       jmp       near ptr M02_L06
M02_L12:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 478
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
       mov       esi,r8d
       mov       rdi,r9
       mov       rcx,r14
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M03_L00
       mov       rax,1ABB6D63020
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
M03_L00:
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M03_L01
       mov       rcx,1ABB6D63020
       mov       rbx,[rcx]
M03_L01:
       mov       rcx,7FFF7DCE5488
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1ABB6D67F88
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
       test      rdi,rdi
       je        short M03_L04
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L04
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M03_L04
M03_L02:
       movsxd    rcx,r14d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M03_L06
       cmp       esi,0FFFFFFFE
       je        short M03_L06
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M03_L03:
       add       r14d,1
       jo        short M03_L05
       cmp       r15d,r14d
       jg        short M03_L02
M03_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7DC89E58]; System.Text.StringBuilder.ToString()
       mov       r12,rax
       jmp       short M03_L07
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp-38]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M03_L03
M03_L07:
       mov       rcx,1ABB6D67F88
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
       mov       rcx,7FFF7DCE5488
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1ABB6D67F88
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
; Total bytes of code 447
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       jne       near ptr M00_L03
       call      qword ptr [7FFF7B877330]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M00_L07
       lea       rcx,[rdi+0C]
       mov       rdx,1C6A8008B10
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M00_L08
       lea       rcx,[rdi+12]
       mov       rdx,1C6A8002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rdi+8],0
       je        short M00_L02
       mov       rcx,rdi
M00_L00:
       test      rcx,rcx
       jne       short M00_L01
       mov       eax,1
       jmp       near ptr M00_L09
M00_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M00_L09
M00_L02:
       mov       rcx,1C6A8002028
       mov       rcx,[rcx]
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFF7B879BE8]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rax,rax
       je        short M00_L04
       mov       edx,[rax+8]
       xor       ecx,ecx
       test      edx,edx
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      edx,edx
       jne       short M00_L05
       jmp       short M00_L05
M00_L04:
       xor       ecx,ecx
M00_L05:
       test      ecx,ecx
       jne       near ptr M00_L06
       call      qword ptr [7FFF7B877450]
       mov       rsi,rax
       mov       ecx,78D
       mov       rdx,7FFF7B8355E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L06:
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFF7BB09FD8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       rcx,rsi
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFF7B8056C0]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rcx,rdi
       mov       rdx,1C6A8002190
       mov       rdx,[rdx]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFF7B873480]; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BBB3BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L10
       call      qword ptr [7FFF7B877450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L10:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B877078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 825
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
       jmp       qword ptr [7FFF7B639A08]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
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
       jne       near ptr M02_L03
       call      qword ptr [7FFF7B877330]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M02_L05
       lea       rcx,[rsi+0C]
       mov       rdx,1C6A8008B10
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M02_L06
       lea       rcx,[rsi+12]
       mov       rdx,1C6A8002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M02_L02
       mov       rcx,rsi
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L07
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L07
M02_L02:
       mov       rcx,1C6A8002028
       mov       rcx,[rcx]
       jmp       short M02_L00
M02_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFF7BA394F8]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M02_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M02_L04
       mov       rdx,rax
       call      qword ptr [7FFF7B55B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M02_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF7BAD9120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B781C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L08
       call      qword ptr [7FFF7B877450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B877078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
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
       call      qword ptr [7FFF7B877450]
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
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
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
       jmp       qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M04_L03
       jmp       short M04_L02
M04_L01:
       call      qword ptr [7FFF7BC014E0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M04_L10
       jmp       short M04_L06
M04_L05:
       call      qword ptr [7FFF7BC014E0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M04_L10
       jmp       short M04_L09
M04_L08:
       call      qword ptr [7FFF7BC014E0]
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
       call      qword ptr [7FFF7B5F3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M04_L11
M04_L13:
       mov       rax,1C6A8002028
       mov       rax,[rax]
       jmp       short M04_L11
M04_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 318
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
       call      qword ptr [7FFF7BA3D150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF7BA3D330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
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
       call      qword ptr [7FFF7B877450]
       mov       rsi,rax
       mov       ecx,60F
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M05_L04
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFF7BAF20A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFF7BB0B048]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
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
       jle       short M06_L00
       jmp       short M06_L01
M06_L00:
       mov       esi,1
M06_L01:
       mov       ecx,esi
       add       ecx,1
       jo        near ptr M06_L08
       cmp       edi,ecx
       jl        short M06_L02
       jmp       short M06_L03
M06_L02:
       mov       edi,ecx
M06_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,1C6A8001ED0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF7B7F1710]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+30],rax
       test      rax,rax
       je        near ptr M06_L09
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M06_L04:
       mov       [rsp+40],r14
       mov       [rsp+48],r15d
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       byte ptr [rsp+3C],0
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FFF7B751DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+38]
       mov       rdx,[rsp+40]
       mov       eax,[rsp+48]
       cmp       ecx,eax
       jae       near ptr M06_L10
       mov       eax,ecx
       mov       word ptr [rdx+rax*2],2D
       inc       ecx
       mov       [rsp+38],ecx
M06_L05:
       lea       rcx,[rsp+28]
       mov       edx,esi
       call      qword ptr [7FFF7B751DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+38]
       mov       rdx,[rsp+40]
       mov       eax,[rsp+48]
       cmp       ecx,eax
       jae       near ptr M06_L11
       mov       eax,ecx
       mov       word ptr [rdx+rax*2],2D
       inc       ecx
       mov       [rsp+38],ecx
M06_L06:
       lea       rcx,[rsp+28]
       mov       edx,edi
       call      qword ptr [7FFF7B751DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF7B66D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,r12
       call      qword ptr [7FFF7B5FB2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M06_L07
       mov       r14,[rbx+10]
       mov       ecx,ebp
       mov       edx,esi
       mov       r8d,edi
       call      qword ptr [7FFF7B8733F0]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       test      rax,rax
       je        near ptr M06_L12
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFF7BB2BB58]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,r12
       mov       r9d,2
       call      qword ptr [7FFF7B5FB318]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
M06_L07:
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,r12
       call      qword ptr [7FFF7B5FB2E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M06_L13
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
M06_L08:
       call      CORINFO_HELP_OVERFLOW
M06_L09:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M06_L04
M06_L10:
       mov       rdx,1C6A8002180
       mov       rdx,[rdx]
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF7B66DAF8]
       jmp       near ptr M06_L05
M06_L11:
       mov       rdx,1C6A8002180
       mov       rdx,[rdx]
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF7B66DAF8]
       jmp       near ptr M06_L06
M06_L12:
       mov       ecx,10
       call      qword ptr [7FFF7B7BB780]
       int       3
M06_L13:
       mov       rdx,r12
       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFF7BC354C8]
       int       3
; Total bytes of code 508
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
       mov       esi,r8d
       mov       rdi,r9
       mov       rcx,r14
       call      qword ptr [7FFF7B8798E8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M07_L00
       mov       rax,1C6A8002028
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
M07_L00:
       mov       rcx,rbx
       call      qword ptr [7FFF7B8798E8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M07_L01
       mov       rcx,1C6A8002028
       mov       rbx,[rcx]
M07_L01:
       mov       rcx,1C6A8006F90
       mov       r15,[rcx]
       mov       rcx,r15
       call      qword ptr [7FFF7B83A790]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       cmp       [rdx],dl
       test      r14,r14
       je        short M07_L02
       mov       r8d,[r14+8]
       lea       rdx,[r14+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFF7B7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M07_L02:
       test      rdi,rdi
       je        near ptr M07_L07
       mov       rcx,rdi
       call      qword ptr [7FFF7B879780]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setg      cl
       test      ecx,ecx
       je        near ptr M07_L07
       xor       r14d,r14d
       mov       r12d,[rdi+8]
       test      r12d,r12d
       jle       short M07_L07
M07_L03:
       mov       ecx,r14d
       mov       rcx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M07_L04
       cmp       esi,0FFFFFFFE
       je        short M07_L04
       mov       rdx,rbx
       call      qword ptr [7FFF7B5F1C60]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       test      rdx,rdx
       je        short M07_L06
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-38]
       call      qword ptr [7FFF7B7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M07_L06
M07_L04:
       test      rcx,rcx
       je        short M07_L05
       mov       r8d,[rcx+8]
       lea       rdx,[rcx+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFF7B7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M07_L05:
       mov       rdx,1C6A80084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFF7B7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M07_L06:
       add       r14d,1
       jo        short M07_L08
       cmp       r12d,r14d
       jg        short M07_L03
M07_L07:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFF7B7CD020]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       jmp       short M07_L09
M07_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
M07_L09:
       mov       rcx,r15
       mov       rdx,[rbp-38]
       call      qword ptr [7FFF7B83A798]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,1C6A8006F90
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,[rbp-38]
       call      qword ptr [7FFF7B83A798]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 444
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,17C2357A5B8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       r8,1EAF3C09670
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       rcx,[rcx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA37FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,1A002F245E8
       mov       rcx,[rcx]
       mov       rdx,1A002F245F0
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
       mov       rdx,7FFF7DCD4CD8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rax,1989D00A690
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
       call      qword ptr [7FFF7B887450]
       mov       rsi,rax
       mov       ecx,0A1E
       mov       rdx,7FFF7B8455E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B883C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B887078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L00:
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,1989D00A688
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA47FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7B887450]
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
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B883C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B887078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
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
       jmp       qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA4DB10]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA4DB10]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA4DB10]
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
       call      qword ptr [7FFF7B603390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,1989D002028
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,21CB55661B0
       mov       rdx,[rdx]
       mov       r8,21CB55661B8
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
       mov       rdx,7FFF7DCB4CD8
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
       mov       rdx,7FFF7DCB4CD8
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
       mov       rdx,7FFF7DCB4CD8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       mov       rdx,2340B809670
       mov       rdx,[rdx]
       mov       r8,2340B809678
       mov       r8,[r8]
       call      qword ptr [7FFF7B863540]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
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
       call      qword ptr [7FFF7B867450]
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8255E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B863C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B867078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B867510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7B867450]
       mov       rdi,rax
       mov       ecx,0A56
       mov       rdx,7FFF7B8255E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B863C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B867078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B867510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7B867450]
       mov       rbx,rax
       mov       ecx,0A62
       mov       rdx,7FFF7B8255E8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B863C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B867078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7B867510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       dword ptr [rsp+20],4
       mov       r9d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFF7B5E36F0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       edi,eax
       mov       dword ptr [rsp+20],4
       mov       r9d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFF7B5E36F0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       r8d,eax
       sub       r8d,edi
       mov       rcx,rsi
       mov       edx,edi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF7B5E3360]; System.String.Substring(Int32, Int32)
; Total bytes of code 759
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__18 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__18 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF7DAF4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FFF7BA296D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__18 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF7B9B7E58]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFF7BA293C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__18 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFF7B4B4C08
       mov       edx,2D1
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF7BA295A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__18.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFF7B9B39C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFF7B5E7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFF7B9B39C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFF7B779AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF7B779270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFF7BA293D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__19 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__19 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF7DB14928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FFF7BA196D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__19 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF7B9A7E58]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFF7BA193C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__19 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFF7B4A4C08
       mov       edx,2D1
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF7BA195A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__19.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFF7B9A39C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFF7B5D7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFF7B9A39C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFF7B769AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF7B769270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFF7BA193D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rax,7FFFDCC711B8
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
       mov       rax,7FFFDCC711B8
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
       mov       rax,14D67AE3020
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       je        short M00_L00
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7BA47FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFF7BA4D7C8]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF7BA4D7C8]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M01_L10
       jmp       short M01_L09
M01_L08:
       call      qword ptr [7FFF7BA4D7C8]
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
       call      qword ptr [7FFF7B603390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M01_L11
M01_L13:
       mov       rax,1DBE8400030
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FFF7DCB4CD8
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
       mov       rax,7FFFDCC711B8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      qword ptr [7FFF7B863648]; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA27FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B867450]
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8255E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7E6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B863C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B867078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B867510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B74FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       jne       short M01_L05
       jmp       short M01_L07
M01_L04:
       call      qword ptr [7FFF7BA2DA98]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,7FFF7DCB5488
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24CACF97F88
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
       call      qword ptr [7FFF7DC69E58]; System.Text.StringBuilder.ToString()
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
       mov       rcx,24CACF97F88
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
       mov       rcx,7FFF7DCB5488
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24CACF97F88
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7B863660]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAAFD50]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,245E2006F90
       mov       r14,[rcx]
       mov       rcx,r14
       call      qword ptr [7FFF7B82A790]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFF7B7DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFF7B7DB258]
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
       call      qword ptr [7FFF7B7DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L06:
       mov       rdx,[rbp-30]
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFF7B7BD020]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFF7B95B570]
       int       3
M01_L10:
       mov       rcx,r14
       mov       rdx,[rbp-30]
       call      qword ptr [7FFF7B82A798]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,245E2006F90
       mov       r14,[rcx]
       mov       rcx,r14
       mov       rdx,[rbp-30]
       call      qword ptr [7FFF7B82A798]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1F0]
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1F0]
       cmp       ecx,100
       jae       short M00_L00
       add       ecx,0FFFFFFD0
       xor       edi,edi
       cmp       ecx,9
       setbe     dil
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFF7BA2DC78]
       xor       edi,edi
       cmp       eax,8
       sete      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA29318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
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
       movsxd    rcx,ecx
       mov       rdx,7FFFDCC711B8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
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
       mov       ecx,ecx
       mov       rdx,7FFFD86BD608
       xor       edi,edi
       test      byte ptr [rcx+rdx],60
       setne     dil
M00_L00:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA27FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FFF7BA2D930]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1F0]
       cmp       ecx,100
       jae       short M00_L02
       cmp       ecx,100
       jae       short M00_L05
       movsxd    rcx,ecx
       mov       rdx,7FFFDCC711B8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1F0]
       cmp       ecx,100
       jae       short M00_L03
       mov       ecx,ecx
       mov       rdx,7FFFD86BD608
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
       call      qword ptr [7FFF7BA29318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
M00_L03:
       call      qword ptr [7FFF7BA2DC78]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1F0]
       cmp       ecx,100
       jae       short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       movsxd    rcx,ecx
       mov       rdx,7FFFDCC711B8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+1F0]
       cmp       ecx,100
       jae       short M00_L01
       mov       ecx,ecx
       mov       rdx,7FFFD86BD608
       xor       edi,edi
       test      byte ptr [rcx+rdx],80
       setne     dil
M00_L00:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA07FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FFF7BA0D7C8]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+190]
       mov       rcx,2E85B1C3B20
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+190]
       mov       rcx,23506006F30
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8F5618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BADB168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B8F53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BADFCD8]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+198]
       mov       rcx,1B6F5687F30
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+198]
       mov       rcx,1DFFBC06F38
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8E5618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAC1B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B8E53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BAC76A8]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,1BDE8973B30
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,21EC0C06F40
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8E5618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAC7198]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B8E53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BACBD08]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A8]
       mov       rcx,1EC6DE57F40
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A8]
       mov       rcx,20597406F48
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8D5618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAB3408]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B8D53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BAB9000]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       sub       rsp,28
       xor       edx,edx
       mov       [rsp+20],edx
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA17FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1D0]
       mov       rcx,1FFA6BA7F48
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1D0]
       mov       rcx,148D0804F58
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8F5618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAD1F48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B8F53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BAD7AC8]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,167C7C35F58
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
       mov       rdx,167C7C37FF8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       vmovupd   xmm0,[rsi+180]
       vmovupd   [rsp+20],xmm0
       mov       rdx,18F460003E0
       mov       rdx,[rdx]
       lea       rcx,[rsp+20]
       xor       r8d,r8d
       call      qword ptr [7FFF7B63D9A8]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,18F4A006F58
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8F5618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7B63D9C0]; System.Guid.TryFormat(System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
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
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B61D030]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B8C1450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,18F460003E0
       mov       rsi,[rcx]
       mov       ebx,[rsi+8]
       cmp       ebx,1
       je        near ptr M01_L00
M01_L10:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0C32D
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B61D030]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B8C1450]
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
       call      qword ptr [7FFF7B8F53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M02_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BAD7CC0]
       int       3
M02_L02:
       mov       r9,rdx
       mov       esi,[r9+8]
       jmp       short M02_L00
; Total bytes of code 90
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1B8]
       mov       rcx,2C86FF57F58
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1B8]
       mov       rcx,157B6406F60
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8E5618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAC1F78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B8E53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BAC7AF8]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rdi
       push      rsi
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,19CAF1E7F60
       mov       rcx,[rcx]
       mov       rdx,19CAF1EA5B8
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
       mov       rcx,19CAF1E1568
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rdi
       push      rsi
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,1F315802B60
       mov       rcx,[rcx]
       mov       rdx,1F315805268
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
       call      qword ptr [7FFF7B8E53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ecx,ecx
       test      rax,rax
       sete      cl
       mov       [rsp+40],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAC3168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7BA71090]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FFF7BA71078]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       mov       rcx,7FFF7B8CBC30
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1F315803438
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
       call      qword ptr [7FFF7BAC1E10]
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
       mov       rcx,7FFF7B8CBC30
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1F315803438
       mov       r15,[rdx]
       jmp       short M01_L12
M01_L10:
       mov       ecx,21
       call      qword ptr [7FFF7B7A77E0]
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
       call      qword ptr [7FFF7BA31BB0]; Precode of System.Text.RegularExpressions.RegexInterpreterFactory.CreateInstance()
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
       call      qword ptr [7FFF7BAC7CF0]
       int       3
M01_L17:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFF7BAC7CF0]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       mov       rcx,[rcx+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA17FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1C8]
       mov       rcx,1E5C9D07F68
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1C8]
       mov       rcx,18947004F78
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8D5618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAB1B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B8D53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BAB76A8]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rdi
       push      rsi
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,28953897F78
       mov       rcx,[rcx]
       mov       rdx,2895389A5B8
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
       mov       rcx,28953891568
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rdi
       push      rsi
       sub       rsp,48
       mov       rsi,rcx
       mov       rcx,14A79C06F80
       mov       rcx,[rcx]
       mov       rdx,14A79C09670
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
       call      qword ptr [7FFF7B8D53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ecx,ecx
       test      rax,rax
       sete      cl
       mov       [rsp+40],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAB1F78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7BA3F858]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FFF7BA3F840]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       mov       rdx,14A79C07840
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
       call      qword ptr [7FFF7BAB1A08]
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
       mov       rcx,14A79C07840
       mov       r15,[rcx]
       jmp       short M01_L12
M01_L10:
       mov       ecx,21
       call      qword ptr [7FFF7B7977E0]
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
       call      qword ptr [7FFF7BA21BB0]; Precode of System.Text.RegularExpressions.RegexInterpreterFactory.CreateInstance()
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
       call      qword ptr [7FFF7BAB7B10]
       int       3
M01_L17:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFF7BAB7B10]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rcx,26E3ED53B88
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rcx,1A3BB806F98
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8D5618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAB1F18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B8D53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BAB7DB0]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1B0]
       mov       rcx,2415EA87F80
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1B0]
       mov       rcx,28188006F88
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8C5618]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAA3168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B8C53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BAA9438]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,2515C3E7F98
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,22A38402B98
       mov       rcx,[rcx]
       call      qword ptr [7FFF7B8C56C0]; System.Text.RegularExpressions.Regex.Match(System.String)
       xor       ecx,ecx
       cmp       dword ptr [rax+30],0
       setne     cl
       mov       [rsp+28],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BAAB810]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B8C53A8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       nop
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7BB01390]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,7FFF7DCC4CD8
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
       mov       rdx,1DB56A99638
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1D8]
       call      qword ptr [7FFF7B873858]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA37FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7B877450]
       mov       rsi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8355E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rdx,2A02A006690
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8d,5
       cmp       [rcx],ecx
       call      qword ptr [7FFF7B5F12D0]; System.String.EndsWith(System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L05
       mov       ecx,[rsi+8]
       lea       r8d,[rcx-2]
       cmp       ecx,r8d
       jb        short M01_L06
       test      r8d,r8d
       jne       short M01_L03
       mov       rcx,2A02A000030
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
       call      qword ptr [7FFF7B6399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF7B5F3378]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,2D30349A5B8
       mov       rcx,[rcx]
       mov       rdx,2D30349A5C0
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
       mov       rdx,7FFF7DCB4CD8
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
       mov       rdx,7FFF7DCB4CD8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rax,1E27A409670
       mov       rdi,[rax]
       mov       rax,1E27A409678
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
       call      qword ptr [7FFF7B887450]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8455E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B883C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B887078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L00:
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7B887450]
       mov       rbx,rax
       mov       ecx,0A38
       mov       rdx,7FFF7B8455E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B883C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B887078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L01:
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       ecx,[rbx+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFF7B601228]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rsp+38],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA49018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B887450]
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
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B883C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B887078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
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
       jmp       qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA4DAE0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA4DAE0]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA4DAE0]
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
       call      qword ptr [7FFF7B603390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,1E27A402028
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
       lea       rcx,[7FFF7B5A2FD0]
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
       jmp       qword ptr [7FFF7B781000]
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
       jmp       qword ptr [7FFF7B60F318]; System.SpanHelpers.SequenceCompareTo(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FFF7B7C7768]
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
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A1CF
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B62D030]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L14:
       mov       rcx,1E27A409688
       mov       r15,[rcx]
       jmp       short M03_L16
M03_L15:
       mov       rcx,1E27A409690
       mov       r15,[rcx]
M03_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B62D030]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r12
       call      qword ptr [7FFF7B795750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M03_L17:
       mov       rcx,1E27A409688
       mov       rsi,[rcx]
       jmp       short M03_L19
M03_L18:
       mov       rcx,1E27A409690
       mov       rsi,[rcx]
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B62D030]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B795750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      qword ptr [7FFF7B7698A0]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFF7B971318]
       jmp       near ptr M03_L09
       mov       rcx,7FFF7B4D4C08
       mov       edx,23B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E27A4004E0
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
       call      qword ptr [7FFF7B971318]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,2594EF361B0
       mov       rcx,[rcx]
       mov       rdx,2594EF361B8
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
       mov       rdx,7FFF7DCC4CD8
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
       mov       rdx,7FFF7DCC4CD8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rsi,rcx
       mov       rax,27B8EC0A688
       mov       rdi,[rax]
       mov       rax,27B8EC0A690
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
       call      qword ptr [7FFF7B877450]
       mov       rdi,rax
       mov       ecx,2E7
       mov       rdx,7FFF7B8355E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L00:
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7B877450]
       mov       rbx,rax
       mov       ecx,0A38
       mov       rdx,7FFF7B8355E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B75FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L01:
       mov       edx,3
       call      qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       mov       ecx,[rbx+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],5
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFF7B5F1228]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       mov       [rsp+38],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA37FC0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFF7B877450]
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
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B7F6980
       call      CORINFO_HELP_STRCNS
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B873C78]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B877078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B877510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B75FF18]
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
       jmp       qword ptr [7FFF7B5F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA3DA98]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA3DA98]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA3DA98]
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
       call      qword ptr [7FFF7B5F3390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,27B8EC02028
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
       lea       rcx,[7FFF7B592EF0]
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
       jmp       qword ptr [7FFF7B771000]; System.Globalization.Ordinal.CompareStringIgnoreCase(Char ByRef, Int32, Char ByRef, Int32)
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
       jmp       qword ptr [7FFF7B5FF318]
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
       call      qword ptr [7FFF7B7B7768]
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
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0A1CF
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B61D030]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFF7B785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L14:
       mov       rcx,27B8EC0A6A0
       mov       r15,[rcx]
       jmp       short M03_L16
M03_L15:
       mov       rcx,27B8EC0A6A8
       mov       r15,[rcx]
M03_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B61D030]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r12
       call      qword ptr [7FFF7B785750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M03_L17:
       mov       rcx,27B8EC0A6A0
       mov       rsi,[rcx]
       jmp       short M03_L19
M03_L18:
       mov       rcx,27B8EC0A6A8
       mov       rsi,[rcx]
M03_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B61D030]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7B785750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      qword ptr [7FFF7B7598A0]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFF7B961318]
       jmp       near ptr M03_L09
       mov       rcx,7FFF7B4C4C08
       mov       edx,23B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27B8EC004E0
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
       call      qword ptr [7FFF7B961318]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,25344131028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L13
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       je        near ptr M01_L14
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L12
       cmp       eax,esi
       jle       near ptr M01_L15
       test      ebx,ebx
       jne       short M01_L01
       mov       rax,25344131028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       add       ebx,esi
       jo        near ptr M01_L12
       sub       ebx,1
       jo        near ptr M01_L12
       jmp       short M01_L03
M01_L02:
       add       esi,1
       jo        near ptr M01_L12
M01_L03:
       cmp       esi,ebx
       jg        short M01_L06
       cmp       esi,ebp
       jae       near ptr M01_L16
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       cmp       ecx,100
       jae       near ptr M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFFDCC711B8
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L02
       jmp       short M01_L06
M01_L04:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       sub       ebx,1
       jo        near ptr M01_L12
M01_L06:
       cmp       ebx,esi
       jl        short M01_L08
       cmp       ebx,ebp
       jae       near ptr M01_L16
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L07
       cmp       ecx,100
       jae       near ptr M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFFDCC711B8
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L05
       jmp       short M01_L08
M01_L07:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L05
M01_L08:
       sub       ebx,esi
       jo        short M01_L12
       add       ebx,1
       jo        short M01_L12
       cmp       ebp,ebx
       je        short M01_L09
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L10
M01_L09:
       mov       rax,rdi
M01_L10:
       test      ebx,ebx
       je        short M01_L11
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       mov       rax,25344131028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       ecx,0AC4
       mov       rdx,7FFF7DCD4CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L14:
       mov       ecx,0A6A
       mov       rdx,7FFF7DCD4CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
       int       3
M01_L15:
       mov       ecx,0ADA
       mov       rdx,7FFF7DCD4CD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0AC4
       mov       rdx,7FFF7DCD4CD8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 554
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7B883918]; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA47FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7B8898E8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,27BCC402028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       eax,esi
       neg       eax
       shr       eax,1F
       mov       ecx,esi
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       jne       near ptr M01_L02
       mov       rax,27BC8404190
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      qword ptr [7FFF7B887450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B883C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B887078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B887090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        eax,ecx
       cmp       eax,0FFFFFFFF
       jne       near ptr M01_L04
       mov       rax,27BC8404188
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFF7B887450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B883C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B887078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7B887090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       ebp,[rdi+8]
       mov       eax,ebp
       sub       eax,ebx
       jo        near ptr M01_L18
       cmp       eax,esi
       jg        near ptr M01_L06
       mov       rax,27BC8404190
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFF7B887450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7B806980
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7B883C78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7B887078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7B76FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,0ADA
       mov       rdx,7FFF7B8455E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       call      qword ptr [7FFF7B887090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7B887510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7B795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       test      ebx,ebx
       jne       short M01_L07
       mov       rax,27BCC402028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       add       ebx,esi
       jo        near ptr M01_L18
       sub       ebx,1
       jo        near ptr M01_L18
       jmp       short M01_L09
M01_L08:
       add       esi,1
       jo        near ptr M01_L18
M01_L09:
       cmp       esi,ebx
       jg        short M01_L12
       cmp       esi,ebp
       jae       near ptr M01_L19
       mov       ecx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L10
       mov       ecx,ecx
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       jne       short M01_L08
       jmp       short M01_L12
M01_L10:
       call      qword ptr [7FFF7BA4D900]
       test      eax,eax
       jne       short M01_L08
       jmp       short M01_L12
M01_L11:
       sub       ebx,1
       jo        short M01_L18
M01_L12:
       cmp       ebx,esi
       jl        short M01_L14
       cmp       ebx,ebp
       jae       short M01_L19
       mov       ecx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L13
       mov       ecx,ecx
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L14
M01_L13:
       call      qword ptr [7FFF7BA4D900]
       test      eax,eax
       jne       short M01_L11
M01_L14:
       sub       ebx,esi
       jo        short M01_L18
       add       ebx,1
       jo        short M01_L18
       cmp       ebp,ebx
       je        short M01_L15
       mov       rcx,rdi
       mov       edx,esi
       mov       r8d,ebx
       call      qword ptr [7FFF7B603360]; System.String.Substring(Int32, Int32)
       jmp       short M01_L16
M01_L15:
       mov       rax,rdi
M01_L16:
       test      ebx,ebx
       je        short M01_L17
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L17:
       mov       rax,27BCC402028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1117
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__17 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__17 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF7DAD4928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FFF7BA293D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__17 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF7B9B7E58]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFF7BA290C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__17 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFF7B4B4C08
       mov       edx,2D1
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF7BA292A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__17.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFF7B9B39C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFF7B5E7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFF7B9B39C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFF7B779AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF7B779270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFF7BA290D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,24E80FFA5B8
       mov       rbx,[rdx]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+10],0FFFFFFFF
       mov       rcx,rdi
       call      qword ptr [7FFF7DCCEBD0]; System.CharEnumerator.MoveNext()
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
       mov       rcx,7FFF7DAF4928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,24E80FF1578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,24E80FF1558
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
       mov       rdx,24E80FFA5C0
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
       mov       rdx,24E80FFA5C8
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
       call      qword ptr [7FFF7DC79E58]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFF7D9E4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       rdx,24C79401290
       mov       rbx,[rdx]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+10],0FFFFFFFF
       mov       rcx,rdi
       call      qword ptr [7FFF7B83FE70]; System.CharEnumerator.MoveNext()
       test      eax,eax
       jne       short M00_L00
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFF7B7598A0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF7B75F870]; System.Globalization.TextInfo.ToTitleCase(System.String)
       mov       rbx,rax
M00_L01:
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA39408]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,7FFF7B4C4C08
       mov       edx,244
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,24C7D400538
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,24C7D400518
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       qword ptr [7FFF7B759750]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFF7BA39270]; System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
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
       call      qword ptr [7FFF7BA39258]; System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
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
       mov       rdx,24C79401298
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,2
       call      qword ptr [7FFF7B7EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       add       ebp,2
       jmp       short M03_L09
M03_L08:
       mov       r8d,[rsp+2C]
       mov       [rsp+20],r8d
       lea       r8,[rsp+88]
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       mov       r9d,ebp
       call      qword ptr [7FFF7B75F8A0]; System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
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
       call      qword ptr [7FFF7BA39270]; System.Globalization.CharUnicodeInfo.GetCodePointFromString(System.String, Int32)
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
       call      qword ptr [7FFF7BA39258]; System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
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
       call      qword ptr [7FFF7B75F6A8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L16:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      qword ptr [7FFF7B7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L18
M03_L17:
       mov       r9d,ebp
       sub       r9d,r12d
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       cmp       [rcx],ecx
       call      qword ptr [7FFF7B7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FFF7B75F6A8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
M03_L22:
       mov       rcx,[rsp+30]
       mov       rdx,rdi
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFF7B7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M03_L24
M03_L23:
       mov       rcx,[rsp+30]
       mov       rdx,[rsp+88]
       mov       r8d,r12d
       mov       r9d,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFF7B7EB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FFF7B7EB258]
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
       call      qword ptr [7FFF7B7EB258]
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
       call      qword ptr [7FFF7B7EB258]
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
       call      qword ptr [7FFF7B7EB258]
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
       call      qword ptr [7FFF7B7EB258]
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
       call      qword ptr [7FFF7B7EB258]
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
       call      qword ptr [7FFF7B7CD020]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFF7B3A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7B75FF90]
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r11,7FFF7DA00518
       call      qword ptr [7FFF7DA00518]
       mov       rcx,rax
       mov       r11,7FFF7DA00520
       call      qword ptr [7FFF7DA00520]
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
       mov       rax,7FFFDCC711B8
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
       mov       rax,7FFFDCC711B8
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
       mov       rax,2CA34583020
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7B8898E8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
       jmp       short M00_L01
M00_L00:
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,2
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFF7B603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
M00_L01:
       mov       [rsp+20],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7BA47FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r11,7FFF7B3C0550
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FFF7B3C0558
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFF7BA4D900]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFF7BA4D900]
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
       mov       rax,7FFFD86BD608
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFF7BA4D900]
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
       call      qword ptr [7FFF7B603390]; System.String.InternalSubString(Int32, Int32)
       jmp       short M02_L11
M02_L13:
       mov       rax,196C9802028
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
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
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__20 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       near ptr System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__20 ByRef)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       rsi,rcx
       cmp       [rsi],esi
       mov       rcx,7FFF7DB04928
       mov       edx,2BD
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-20],rdi
       mov       rdx,[rax+8]
       mov       [rbp-28],rdx
       mov       rcx,[rax+10]
       mov       [rbp-30],rcx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20.MoveNext()
       nop
       mov       rcx,[rbp-30]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L02
       cmp       qword ptr [rbx+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rdx,[rbp-30]
       mov       rdi,[rbp-20]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rbx,[rdi+8]
       mov       rdx,[rbp-28]
       cmp       rdx,rbx
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-28],0
       je        short M03_L09
       mov       rdx,[rbp-28]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      System.Threading.ExecutionContext.OnValuesChanged(System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L02
M04_L01:
       add       rsp,20
       pop       rsi
       ret
M04_L02:
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
       jmp       short M04_L01
; Total bytes of code 76
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder.InitializeTaskAsPromise()

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FFF7BA293D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__20 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF7B9B7E58]
       jmp       short M00_L00
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FFF7BA290C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
; Total bytes of code 25
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__20 ByRef)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,7FFF7B4B4C08
       mov       edx,2D1
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L05
M03_L00:
       mov       rdi,rax
       mov       [rbp-18],rdi
       mov       rdx,[rax+8]
       mov       [rbp-20],rdx
       mov       rcx,[rax+10]
       mov       [rbp-28],rcx
       mov       rcx,rsi
       call      qword ptr [7FFF7BA292A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__20.MoveNext()
       nop
       mov       rcx,[rbp-28]
       cmp       rcx,[rdi+10]
       je        short M03_L01
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L02
       cmp       qword ptr [rsi+10],0
       jne       short M03_L03
M03_L02:
       mov       rdx,[rbp-20]
       test      rdx,rdx
       je        short M03_L04
       cmp       qword ptr [rdx+10],0
       je        short M03_L04
M03_L03:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFF7B9B39C0]
M03_L04:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L05:
       call      qword ptr [7FFF7B5E7210]; System.Threading.Thread.InitializeCurrentThread()
       jmp       near ptr M03_L00
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-28]
       mov       rdi,[rbp-18]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rsi,[rdi+8]
       mov       rdx,[rbp-20]
       cmp       rdx,rsi
       je        short M03_L09
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L07
       cmp       qword ptr [rsi+10],0
       jne       short M03_L08
M03_L07:
       cmp       qword ptr [rbp-20],0
       je        short M03_L09
       mov       rdx,[rbp-20]
       cmp       qword ptr [rdx+10],0
       je        short M03_L09
M03_L08:
       mov       rcx,rsi
       mov       rdx,[rbp-20]
       call      qword ptr [7FFF7B9B39C0]
M03_L09:
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 311
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      dword ptr [rsi+34],1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFF7B779AE0]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF7B779270]; System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      qword ptr [7FFF7BA290D8]
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 76
```

