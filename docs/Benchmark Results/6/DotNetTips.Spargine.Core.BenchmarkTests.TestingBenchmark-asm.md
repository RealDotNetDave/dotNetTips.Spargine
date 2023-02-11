## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
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
       mov       rdx,7FF7B9D2D528
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
       mov       rdx,7FF7B9CFD928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9CFD928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r9,26E13C085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,26E13C02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFF7F2EF2A0]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFF7F333A98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2EF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
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
       mov       rdx,7FF7B9D3D528
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
       mov       rdx,7FF7B9D0D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D0D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r9,1FDD78085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1FDD7802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFF7F2CF2A0]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFF7F313A98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2CF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
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
       mov       rdx,7FF7B9D5D528
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
       mov       rdx,7FF7B9D2D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D2D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r9,1C0A10085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C0A1002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFF7F2DF5A0]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFF7F323D98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2DF690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
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
       mov       rdx,7FF7B9D5D528
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
       mov       rdx,7FF7B9D2D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D2D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r9,2972F0085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2972F002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFF7F2DF5A0]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFF7F323D98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2DF690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
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
       mov       rdx,7FF7B9D5D528
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
       mov       rdx,7FF7B9D2D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D2D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r9,249AA8085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,249AA802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFF7F2CF2A0]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFF7F313A98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2CF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
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
       mov       rdx,7FF7B9D3D528
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
       mov       rdx,7FF7B9D0D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D0D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r9,1F7678085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F767802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFF7F2DF2A0]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFF7F323A98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2DF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
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
       mov       rdx,7FF7B9D5D528
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
       mov       rdx,7FF7B9D2D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D2D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r9,21541C085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21541C02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFF7F2DF5A0]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFF7F323D98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2DF690]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
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
       mov       rdx,7FF7B9D3D528
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
       mov       rdx,7FF7B9D0D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D0D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r9,2A733C085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2A733C02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFF7F2EF2A0]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFF7F333A98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2EF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
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
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 87
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
       mov       rdx,7FF7B9D3D528
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
       mov       rdx,7FF7B9D0D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D0D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r9,208A34085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,208A3402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFF7F2EF2A0]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFF7F333A98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2EF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
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
       mov       rdx,[rbx+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 149
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
       mov       rdx,7FF7B9D2D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D2D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F2CF3D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2CF5A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2435A0]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,1D72C4085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,1D72C402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1D72C402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF7F2CF480]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
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
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F2436C0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F21FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F2432E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F243780]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F2432E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F02FF18]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 149
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
       mov       rdx,7FF7B9D0D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D0D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F2EF6D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2EF8A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2635A0]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,1E10F0085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,1E10F002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1E10F002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF7F2EF780]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
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
       call      qword ptr [7FFF7F071C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F071C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F2636C0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F23FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F2632E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F263780]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F2632E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F04FF18]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 149
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
       mov       rdx,7FF7B9D3D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D3D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F2FF3D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2FF5A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2735A0]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,24C248085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,24C24802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,24C24802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF7F2FF480]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
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
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F2736C0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F24FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F2732E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F273780]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F2732E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F05FF18]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 149
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
       mov       rdx,7FF7B9D0D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D0D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F30F3D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F30F5A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2835A0]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,19FF5C065D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,19FF5C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,19FF5C00030
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF7F30F480]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
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
       call      qword ptr [7FFF7F091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F2836C0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F108CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F108CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F25FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F2832E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F283780]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F06FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F2832E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F06FF18]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 149
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
       mov       rdx,7FF7B9D0D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D0D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F30F3D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F30F5A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2835A0]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,261094085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,26109402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,26109402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF7F30F480]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
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
       call      qword ptr [7FFF7F091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F091C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F2836C0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F108CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F108CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F25FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F2832E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F283780]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F06FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F2832E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F06FF18]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 149
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
       mov       rdx,7FF7B9D0D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D0D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F2FF3D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2FF5A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2735A0]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,1F6C00085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,1F6C0002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1F6C0002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF7F2FF480]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
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
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F2736C0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F24FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F2732E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F273780]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F2732E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F05FF18]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 149
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
       mov       rdx,7FF7B9D2D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D2D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F2CF3D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2CF5A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2435A0]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,1F4530085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,1F453002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1F453002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF7F2CF480]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
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
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F2436C0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F21FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F2432E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F243780]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F2432E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F02FF18]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 149
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
       mov       rdx,7FF7B9D3D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D3D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F2FF6D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2FF8A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2735A0]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,1CF960001E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,1CF8E002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,1CF8E002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF7F2FF780]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
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
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F2736C0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F24FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F2732E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F273780]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F2732E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F05FF18]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 149
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
       mov       rdx,7FF7B9D1D928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FF7B9D1D928
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7F2DF3D8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2DF5A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2535A0]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,15B9F8085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,15B9F802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,15B9F802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF7F2DF480]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
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
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F2536C0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F22FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F2532E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F253780]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F2532E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

