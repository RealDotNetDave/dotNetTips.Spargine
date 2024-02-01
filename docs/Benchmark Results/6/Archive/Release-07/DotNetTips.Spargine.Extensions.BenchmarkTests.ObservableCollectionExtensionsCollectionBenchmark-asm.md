## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5991570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C6E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C67BFBD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67BFC90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6475778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67AE700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67BFC18]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C5E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C685F360]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C685F420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6525778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C684FD30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C685F3A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5991570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C6E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C685D360]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C685D420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6525778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C684FD80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C685D3A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C7E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C687F060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C687F120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6535778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C686F0C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C687F0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C7E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C685F060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C685F120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6525778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C684FD30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C685F0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C59A1570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C7E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C685D360]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C685D420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6515778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C684EEA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C685D3A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5981570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C5E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 183
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
       mov       r8d,5
       call      qword ptr [7FF9C684F060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C684F120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C6515778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C683FD50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C684F0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       mov       eax,[rbp+20]
       cdqe
       cmp       [rbp-20],rax
       sete      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 180
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2A404BBD720
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A404BBD718
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2A404BBD720
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C59A0C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C59A1570],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C7E788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 202
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,266F100C728
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,266F100C720
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,266F100C728
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FF9C678F060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6454E30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6465A80]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C6455778],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C677FE10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C675D900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 200
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,24D5CFED720
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24D5CFED718
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,24D5CFED720
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5980C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C5981570],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C5E788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 202
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,136BD00C728
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,136BD00C720
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,136BD00C728
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FF9C684D3A8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6514E30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6525A80]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C6515778],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C683FF48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C681B900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 200
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1639B347608
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1639B347600
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1639B347608
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5980C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C5981570],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C5E788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 202
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,180D480C728
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,180D480C720
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,180D480C728
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FF9C684F060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6504E30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6515A80]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C6505778],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C683FD08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C681D900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 200
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,204E7F9D720
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,204E7F9D718
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,204E7F9D720
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C59B0C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C59B1570],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C8E788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 202
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,17F6640C728
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,17F6640C720
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,17F6640C728
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FF9C687F060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6534E30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6545A80]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C6535778],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C686FCF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C684D900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 200
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,272E1E93200
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,272E1E931F8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,272E1E93200
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5980C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C5981570],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C5E788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 202
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,180E400A730
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,180E400A728
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,180E400A730
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FF9C686F918]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6524E30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6535A80]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C6525778],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C685EAC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C683F900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 200
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2118150D720
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2118150D718
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2118150D720
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5990C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C5991570],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C6E788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 202
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1FBFD00C728
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FBFD00C720
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1FBFD00C728
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FF9C684F060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6514E30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6525A80]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C6515778],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C683F2B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C681D900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 200
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,28ED663D720
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28ED663D718
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,28ED663D720
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5970C30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       near ptr DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 27
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C5971570],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C4E788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 202
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1E3D480C728
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E3D480C720
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E3D480C728
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FF9C68913A8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6524E30]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Address1()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9C6535A80]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FF9C6525778],0
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
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M02_L06
M02_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C685FD60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C683D900]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
; Total bytes of code 200
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
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
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C5E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 178
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67BF060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67BF120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6485778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67AFDF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C67BF0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
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
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C8E330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 178
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C687F060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C687F120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6535778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C686FC28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C687F0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
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
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C7E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 178
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C685D060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C685D120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6525778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C684F888
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C685D0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
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
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C5E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 178
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C685FBD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C685FC90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6515778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C684E768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C685FC18]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5991570],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C6E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 178
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C685F060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C685F120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6525778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C684FD30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C685F0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
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
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C7E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 178
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C684D060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C684D120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6515778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C683F020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C684D0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
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
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C8E6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       movsxd    rax,eax
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
       jmp       short M01_L04
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 178
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C688D8D0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C688D990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6545778],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-10],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-18],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C687EA80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L03:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9C688D918]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       xor       eax,eax
       cdqe
       cmp       [rbp-20],rax
       setg      al
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L04:
       mov       eax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 175
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

