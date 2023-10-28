## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
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
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C59A1A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 114
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      qword ptr [7FF9C6893090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68958D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6515CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6523060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 112
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
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
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C59B1A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 114
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      qword ptr [7FF9C6875900]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68791F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6505CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6513060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 112
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
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
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5981A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 114
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      qword ptr [7FF9C68C3090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68C58D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6545CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6553060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 112
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
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
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5991A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 114
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      qword ptr [7FF9C6885900]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68891F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6515CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6523060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 112
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
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
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5971A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 114
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      qword ptr [7FF9C6883090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68858D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6505CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6513060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 112
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
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
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C59B1A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 114
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      qword ptr [7FF9C6885C00]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68893C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6515CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6523060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 112
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
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
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C59A1A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 114
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       r8d,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       call      qword ptr [7FF9C68B3090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68B58D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6535CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6543060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       mov       eax,[rbp-0C]
       cmp       eax,[rbp+20]
       sete      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 112
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1C6723BD730
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C6723BD728
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1C6723BD730
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       movzx     eax,al
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CE1840]
       vucomisd  xmm0,qword ptr [7FF9C5CE1848]
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C59B1A80],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       cmp       qword ptr [rbp+20],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB2F70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L06
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 204
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2029240C738
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2029240C730
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2029240C738
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C68A30F0]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C65311C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C68FBF20]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FF9C68FBF28]
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6525CA0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6874E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C68A3138]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 202
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2B122BBD730
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2B122BBD728
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2B122BBD730
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       movzx     eax,al
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CC2190]
       vucomisd  xmm0,qword ptr [7FF9C5CC2198]
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5991A80],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       cmp       qword ptr [rbp+20],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C930D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L06
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 204
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,20017C0C738
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20017C0C730
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,20017C0C738
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C6883438]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C65111C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C68DC9E0]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FF9C68DC9E8]
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6505CA0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6854F20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C6883480]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 202
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,129B7A67618
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,129B7A67610
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,129B7A67618
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       movzx     eax,al
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CC27F0]
       vucomisd  xmm0,qword ptr [7FF9C5CC27F8]
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5991A80],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       cmp       qword ptr [rbp+20],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C930F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L06
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 204
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2843980C738
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2843980C730
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2843980C738
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C68A30F0]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C65311C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C68FCE60]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FF9C68FCE68]
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6525CA0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6874BA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C68A3138]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 202
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2403F7DD730
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2403F7DD728
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2403F7DD730
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       movzx     eax,al
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CC29D0]
       vucomisd  xmm0,qword ptr [7FF9C5CC29D8]
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5991A80],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       cmp       qword ptr [rbp+20],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C930F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L06
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 204
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1F241C0C738
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F241C0C730
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1F241C0C738
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C68A30F0]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C65311C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C68FD060]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FF9C68FD068]
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6525CA0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6873168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C68A3138]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 202
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,20A4677D730
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20A4677D728
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,20A4677D730
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       movzx     eax,al
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CB2330]
       vucomisd  xmm0,qword ptr [7FF9C5CB2338]
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981A80],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       cmp       qword ptr [rbp+20],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C830F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L06
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 204
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1ACDB00A740
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1ACDB00A738
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1ACDB00A740
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C68B30F0]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C65411C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C690CF40]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FF9C690CF48]
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6535CA0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6883508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C68B3138]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 202
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2DCE20ED730
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2DCE20ED728
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2DCE20ED730
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       movzx     eax,al
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CA2410]
       vucomisd  xmm0,qword ptr [7FF9C5CA2418]
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5971A80],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       cmp       qword ptr [rbp+20],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C730F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L06
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 204
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,28C9C40C738
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28C9C40C730
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,28C9C40C738
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C68B3438]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C65411C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C690CEE0]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FF9C690CEE8]
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6535CA0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6883598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C68B3480]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 202
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,19FB7FAB738
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,19FB7FAB730
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,19FB7FAB738
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       movzx     eax,al
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CB2B10]
       vucomisd  xmm0,qword ptr [7FF9C5CB2B18]
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981A80],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       cmp       qword ptr [rbp+20],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C830F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M02_L06
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 204
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,28540C0C738
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28540C0C730
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,28540C0C738
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C68B5438]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C65511C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C691D060]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FF9C691D068]
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6545CA0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L01
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-14],ecx
       jmp       short M02_L02
M02_L01:
       mov       dword ptr [rbp-14],1
M02_L02:
       mov       ecx,[rbp-14]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L03
       nop
       mov       dword ptr [rbp-10],1
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6895268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C68B5480]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M02_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 202
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5991A80],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C68A3090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68A58D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6525CA0],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1A80],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C6883390]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6885B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6505CA0],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981A80],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C6883390]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6885B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6505CA0],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981A80],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C6875390]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6877B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6505CA0],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5971A80],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C6893090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68958D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6515CA0],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59B1A80],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C68A3390]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68A5B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6525CA0],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59B1A80],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C6883090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68858D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6505CA0],0
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5991A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C68A3090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68A58D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6525CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6533060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C68C3090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68C58D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6545CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6553060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C68A3090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68A58D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6525CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6533060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5971A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C68A3390]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68A5B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6525CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6533060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59B1A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C68B3090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68B58D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6535CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6543060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C6893900]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68971F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6525CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6533060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
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
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1A80],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       movzx     eax,al
       mov       [rbp-8],eax
       nop
       jmp       short M01_L02
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C68C3090]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68C58D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6545CA0],0
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
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6553060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

