## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
       mov       rdx,7FFCE28BCFE8
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
       mov       rdx,7FFCE288BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE288BC08
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
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
       mov       r9,29A464085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29A46402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFCE0731570]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFCE073B5E8]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCE0731660]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
       mov       rdx,7FFCE28BCFE8
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
       mov       rdx,7FFCE288BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE288BC08
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
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
       mov       r9,202570061B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20253000030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFCE06FF570]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFCE0743D98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCE06FF660]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
       mov       rdx,7FFCE28CCFE8
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
       mov       rdx,7FFCE289BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE289BC08
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
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
       mov       r9,1E860C021E0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E862C02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFCEB4EF570]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFCEB533DB0]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCEB4EF660]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
       mov       rdx,7FFCE28BCFE8
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
       mov       rdx,7FFCE288BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE288BC08
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
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
       mov       r9,21F4E8085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21F4E802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFCED30F570]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFCED353DB0]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCED30F660]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
       mov       rdx,7FFCE28BCFE8
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
       mov       rdx,7FFCE288BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE288BC08
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
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
       mov       r9,24234C001E8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24230C02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFCEC48F270]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFCEC4D3A98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCEC48F360]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
       mov       rdx,7FFCE28DCFE8
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
       mov       rdx,7FFCE28ABC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE28ABC08
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
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
       mov       r9,1CF2A4021E0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1CF28400030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFCEC49F270]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFCEC4E3AB0]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCEC49F360]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
       mov       rdx,7FFCE28CCFE8
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
       mov       rdx,7FFCE289BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE289BC08
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
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
       mov       r9,2901B0021E0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29017000030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFCED2DF270]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFCED323AB0]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCED2DF360]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
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
       mov       rdx,7FFCE28FF700
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
       mov       rdx,7FFCE28BBC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE28BBC08
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+280]
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
       mov       r9,1D85D8001E8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D861800030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFCECE2F270]
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFCECE73AB0]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCECE2F360]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L02
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
       mov       rdx,7FFCE289BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE289BC08
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
; Total bytes of code 427
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
       call      qword ptr [7FFCE06FF6A8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCE06FF870]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L02
       call      qword ptr [7FFCE0673330]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],5
       jl        near ptr M01_L04
       lea       rcx,[rsi+0C]
       mov       rdx,246454045F0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFCE03399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L05
       lea       rcx,[rsi+16]
       mov       rdx,24645402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFCE03399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCE02F1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L06
       mov       eax,1
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      qword ptr [7FFCE0673450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFCE04F6320
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFCE04F6320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFCE064FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCE0673078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFCE0673510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFCE045FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFCE02F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCE0673078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFCE045FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L03
       lea       rcx,[rsp+50]
       call      qword ptr [7FFCE06FF750]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       cmp       edx,eax
       jae       near ptr M01_L07
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
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCE0481C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCE0481C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L00
M01_L07:
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L02
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
       mov       rdx,7FFCE28BBC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE28BBC08
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
; Total bytes of code 427
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
       call      qword ptr [7FFCE714F3A8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCE714F570]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L02
       call      qword ptr [7FFCE70C3330]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],5
       jl        near ptr M01_L04
       lea       rcx,[rsi+0C]
       mov       rdx,227400085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFCE6D899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L05
       lea       rcx,[rsi+16]
       mov       rdx,22740002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFCE6D899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCE6D41C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L06
       mov       eax,1
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      qword ptr [7FFCE70C3450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFCE6F46320
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFCE6F46320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFCE709FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCE70C3078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFCE70C3510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFCE6EAFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFCE6D43510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCE70C3078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFCE6EAFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L03
       lea       rcx,[rsp+50]
       call      qword ptr [7FFCE714F450]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       cmp       edx,eax
       jae       near ptr M01_L07
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
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCE6ED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCE6ED1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L00
M01_L07:
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L02
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
       mov       rdx,7FFCE28ABC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE28ABC08
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
; Total bytes of code 427
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
       call      qword ptr [7FFCEBD9F6A8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCEBD9F870]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L02
       call      qword ptr [7FFCEBD13330]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],5
       jl        near ptr M01_L04
       lea       rcx,[rsi+0C]
       mov       rdx,27E854001E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFCEB9D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L05
       lea       rcx,[rsi+16]
       mov       rdx,27E83400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFCEB9D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCEB991C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L06
       mov       eax,1
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      qword ptr [7FFCEBD13450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFCEBB96320
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFCEBB96320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFCEBCEFD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCEBD13078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFCEBD13510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFCEBAFFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFCEB993510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCEBD13078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFCEBAFFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L03
       lea       rcx,[rsp+50]
       call      qword ptr [7FFCEBD9F750]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       cmp       edx,eax
       jae       near ptr M01_L07
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
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCEBB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCEBB21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L00
M01_L07:
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L02
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
       mov       rdx,7FFCE289BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE289BC08
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
; Total bytes of code 427
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
       call      qword ptr [7FFCED2FF3A8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCED2FF570]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L02
       call      qword ptr [7FFCED273330]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],5
       jl        near ptr M01_L04
       lea       rcx,[rsi+0C]
       mov       rdx,1B77F8041C0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFCECF399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L05
       lea       rcx,[rsi+16]
       mov       rdx,1B77D802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFCECF399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCECEF1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L06
       mov       eax,1
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      qword ptr [7FFCED273450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFCED0F6320
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFCED0F6320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFCED24FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCED273078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFCED273510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFCED05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFCECEF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCED273078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFCED05FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L03
       lea       rcx,[rsp+50]
       call      qword ptr [7FFCED2FF450]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       cmp       edx,eax
       jae       near ptr M01_L07
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
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCED081C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L00
M01_L07:
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L02
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
       mov       rdx,7FFCE288BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE288BC08
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
; Total bytes of code 427
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
       call      qword ptr [7FFCEC49F6A8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCEC49F870]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L02
       call      qword ptr [7FFCEC413330]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],5
       jl        near ptr M01_L04
       lea       rcx,[rsi+0C]
       mov       rdx,1AE744021E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFCEC0D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L05
       lea       rcx,[rsi+16]
       mov       rdx,1AE70400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFCEC0D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCEC091C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L06
       mov       eax,1
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      qword ptr [7FFCEC413450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFCEC296320
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFCEC296320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFCEC3EFD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCEC413078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFCEC413510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFCEC1FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFCEC093510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCEC413078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFCEC1FFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L03
       lea       rcx,[rsp+50]
       call      qword ptr [7FFCEC49F750]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       cmp       edx,eax
       jae       near ptr M01_L07
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
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCEC221C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCEC221C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L00
M01_L07:
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L02
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
       mov       rdx,7FFCE28BBC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE28BBC08
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
; Total bytes of code 427
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
       call      qword ptr [7FFCEC48F6A8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCEC48F870]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L02
       call      qword ptr [7FFCEC403330]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],5
       jl        near ptr M01_L04
       lea       rcx,[rsi+0C]
       mov       rdx,1766E8085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFCEC0C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L05
       lea       rcx,[rsi+16]
       mov       rdx,1766E802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFCEC0C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCEC081C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L06
       mov       eax,1
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      qword ptr [7FFCEC403450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFCEC286320
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFCEC286320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFCEC3DFD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCEC403078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFCEC403510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFCEC1EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFCEC083510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCEC403078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFCEC1EFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L03
       lea       rcx,[rsp+50]
       call      qword ptr [7FFCEC48F750]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       cmp       edx,eax
       jae       near ptr M01_L07
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
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCEC211C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCEC211C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L00
M01_L07:
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L02
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
       mov       rdx,7FFCE287BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE287BC08
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
; Total bytes of code 427
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
       call      qword ptr [7FFCED2EF6A8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCED2EF870]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L02
       call      qword ptr [7FFCED263330]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],5
       jl        near ptr M01_L04
       lea       rcx,[rsi+0C]
       mov       rdx,235980001E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFCECF299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L05
       lea       rcx,[rsi+16]
       mov       rdx,23594000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFCECF299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCECEE1C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L06
       mov       eax,1
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      qword ptr [7FFCED263450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFCED0E6320
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFCED0E6320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFCED23FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCED263078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFCED263510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFCED04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFCECEE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCED263078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFCED04FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L03
       lea       rcx,[rsp+50]
       call      qword ptr [7FFCED2EF750]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       cmp       edx,eax
       jae       near ptr M01_L07
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
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCED071C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCED071C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L00
M01_L07:
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
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
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L02
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
       mov       rdx,7FFCE288BC08
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFCE288BC08
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
; Total bytes of code 427
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       rbp,[rbx+278]
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
       call      qword ptr [7FFCECE753A8]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFCECE75528]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L02
       call      qword ptr [7FFCECDA3330]
       mov       rdi,rax
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],5
       jl        near ptr M01_L04
       lea       rcx,[rsi+0C]
       mov       rdx,247530045F0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFCECA699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L05
       lea       rcx,[rsi+16]
       mov       rdx,24753002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFCECA699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCECA21C60]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L06
       mov       eax,1
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      qword ptr [7FFCECDA3450]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFCECC26320
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFCECC26320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFCECD7FD98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCECDA3078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFCECDA3510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFCECB8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFCECA23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFCECDA3078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFCECB8FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L03
       lea       rcx,[rsp+50]
       call      qword ptr [7FFCECE75450]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       mov       edx,eax
       sub       edx,1
       jo        short M01_L03
       cmp       edx,eax
       jae       near ptr M01_L07
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
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCECBB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFCECBB1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L00
M01_L07:
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

