## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C65BF348]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C65BF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6275748],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6283060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59B1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C685D8B8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C685D900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6515748],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6523060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59B1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C687D000]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C687D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6535748],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6543060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C684D348]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C684D390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6515748],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6523060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C684FBB8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C684FC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6505748],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6513060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C686D000]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C686D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6525748],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6533060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59B1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 110
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C684D000]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C684D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6515748],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6523060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

