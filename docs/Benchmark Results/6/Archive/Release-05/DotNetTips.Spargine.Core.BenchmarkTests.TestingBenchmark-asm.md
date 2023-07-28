## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA98D09D08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFA98AF5FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98AF5FC0
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
; Total bytes of code 187
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,1F7310045F0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F731002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFA975B19D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFA977CB420]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977C70F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFA975B3330]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFA97545780]
       mov       rcx,rax
       call      qword ptr [7FFA975B3588]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA98D39D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFA98B25FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98B25FC0
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
; Total bytes of code 187
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,1CDF08085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1CDF0802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFA975C19D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFA977DBB40]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977D10F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFA975C3330]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFA97555780]
       mov       rcx,rax
       call      qword ptr [7FFA975C3588]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA98D19D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFA98B05FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98B05FC0
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
; Total bytes of code 187
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,2A3AFC085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2A3AFC02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFA975D19D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFA977ED330]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977E30F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFA975D3330]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFA97565780]
       mov       rcx,rax
       call      qword ptr [7FFA975D3588]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA98D09D08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFA98AF5FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98AF5FC0
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
; Total bytes of code 187
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,13B680085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,13B68002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFA975A19D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFA977BBF30]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977B10F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFA975A3330]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFA97535780]
       mov       rcx,rax
       call      qword ptr [7FFA975A3588]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA98D19D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFA98B05FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98B05FC0
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
; Total bytes of code 187
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,2351B0085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2351B002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFA975C19D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFA977DD330]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977D10F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFA975C3330]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFA97555780]
       mov       rcx,rax
       call      qword ptr [7FFA975C3588]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA98CF9D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFA98AE5FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98AE5FC0
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
; Total bytes of code 187
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,19985C085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19985C02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFA975B19D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFA977CB438]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977C30F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFA975B3330]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFA97545780]
       mov       rcx,rax
       call      qword ptr [7FFA975B3588]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA98D19D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFA98B05FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98B05FC0
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
; Total bytes of code 187
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,2726DC085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2726DC02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFA975C19D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFA977DD738]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977D39A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFA975C3330]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFA97555780]
       mov       rcx,rax
       call      qword ptr [7FFA975C3588]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFA98AF5FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98AF5FC0
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
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFA977A1138]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977A1288]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFA97593330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,207E30065D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,207E3000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,207E3000030
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFA977A11E0]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFA97593450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973A98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973A98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975259F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA97593078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97593510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9730FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA97193510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA97593078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9730FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFA98AF5FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98AF5FC0
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
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFA977D5CF0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977D5E40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFA975C3330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,126450085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,12645002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,12645002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFA977D5D98]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97361C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97361C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFA975C3450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973D98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973D98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975559F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975C3078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975C3510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9733FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975C3078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9733FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFA98B15FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98B15FC0
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
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFA977C1138]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977C1288]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFA975B3330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,17C74C085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,17C74C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,17C74C02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFA977C11E0]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFA975B3450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973C98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975459F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975B3078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975B3510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975B3078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFA98B25FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98B25FC0
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
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFA977B3480]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977B35D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFA975A3330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,2769F8085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,2769F802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,2769F802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFA977B3528]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFA975A3450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975359F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975A3078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975A3510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975A3078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFA98AF5FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98AF5FC0
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
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFA977B3480]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977B35D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFA975A3330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,182804085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,18280402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,18280402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFA977B3528]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFA975A3450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973B98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975359F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975A3078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975A3510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975A3078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFA98B05FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98B05FC0
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
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFA977D1138]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977D1288]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFA975C3330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,186D50085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,186D5002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,186D5002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFA977D11E0]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97361C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97361C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFA975C3450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973D98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973D98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975559F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975C3078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975C3510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9733FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975C3078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9733FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
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
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFA98B05FC0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFA98B05FC0
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
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFA977A3CF0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977A3E40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFA97593330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,27D51C085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,27D51C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,27D51C02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFA977A3D98]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFA97593450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973A98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973A98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975259F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA97593078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97593510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9730FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA97193510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA97593078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9730FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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

