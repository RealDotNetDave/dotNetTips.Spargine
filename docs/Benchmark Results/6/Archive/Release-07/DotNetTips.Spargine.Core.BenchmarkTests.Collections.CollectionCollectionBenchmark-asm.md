## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,1B0ADD33020
       mov       r8,1B0ADD33020
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,1B0ADD39C38
       mov       r8,1B0ADD39C38
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       jmp       short M01_L01
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-10]
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 360
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CEE59888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE59900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9CE9A9F50],0
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      qword ptr [7FF9CE79D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CE79D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,1942A002028
       mov       r8,1942A002028
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,19420000040
       mov       r8,19420000040
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9CEB5BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      qword ptr [7FF9CEB5BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      qword ptr [7FF9CEE597F8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CEE597F8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 362
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,23B7C3E3020
       mov       r8,23B7C3E3020
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,23B7C3E7C40
       mov       r8,23B7C3E7C40
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       jmp       short M01_L01
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-10]
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 360
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CEE59888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE59900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9CE9A9F50],0
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      qword ptr [7FF9CE79D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CE79D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,29352002028
       mov       r8,29352002028
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,29352008C38
       mov       r8,29352008C38
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9CEB5BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      qword ptr [7FF9CEB5BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      qword ptr [7FF9CEE597F8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CEE597F8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 362
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,2648DEC3020
       mov       r8,2648DEC3020
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,2648DEC9C38
       mov       r8,2648DEC9C38
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       jmp       short M01_L01
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-10]
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 360
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CEE39888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE39900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9CE989F50],0
       cmp       dword ptr [7FF9CE989F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      qword ptr [7FF9CE77D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CE77D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,288A5C02028
       mov       r8,288A5C02028
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,288B1C00040
       mov       r8,288B1C00040
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9CEB3BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      qword ptr [7FF9CEB3BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      qword ptr [7FF9CEE397F8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CEE397F8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 362
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,24FB00A3020
       mov       r8,24FB00A3020
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,24FB00A9C38
       mov       r8,24FB00A9C38
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       jmp       short M01_L01
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-10]
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 360
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CEE59B88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE59C00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9CE9A9F50],0
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      qword ptr [7FF9CE79D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CE79D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,261C3800030
       mov       r8,261C3800030
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,261BF800040
       mov       r8,261BF800040
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9CEB5BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      qword ptr [7FF9CEB5BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      qword ptr [7FF9CEE59AF8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CEE59AF8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 362
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7876D08],0
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,29E71403020
       mov       r8,29E71403020
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,29E71409C38
       mov       r8,29E71409C38
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       jmp       short M01_L01
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-10]
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 360
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CEE49888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE49900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9CE999F50],0
       cmp       dword ptr [7FF9CE999F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      qword ptr [7FF9CE78D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CE78D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,1E0A8C02028
       mov       r8,1E0A8C02028
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,1E0A8C08C38
       mov       r8,1E0A8C08C38
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9CEB4BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      qword ptr [7FF9CEB4BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      qword ptr [7FF9CEE497F8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CEE497F8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 362
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C78A6D08],0
       cmp       dword ptr [7FF9C78A6D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,258B2913020
       mov       r8,258B2913020
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,258B2919C38
       mov       r8,258B2919C38
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       jmp       short M01_L01
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-10]
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 360
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CEE39888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE39900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9CE989F50],0
       cmp       dword ptr [7FF9CE989F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      qword ptr [7FF9CE77D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CE77D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,29453402028
       mov       r8,29453402028
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,29453408C38
       mov       r8,29453408C38
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9CEB3BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      qword ptr [7FF9CEB3BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      qword ptr [7FF9CEE397F8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CEE397F8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 362
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,26715FA3020
       mov       r8,26715FA3020
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,26715FA9C38
       mov       r8,26715FA9C38
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       jmp       short M01_L01
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-10]
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 360
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CEE29B88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE29C00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9CE979F50],0
       cmp       dword ptr [7FF9CE979F50],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
M01_L00:
       nop
       xor       ecx,ecx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       lea       rcx,[rbp-18]
       lea       rcx,[rbp-18]
       mov       edx,1
       mov       edx,1
       call      qword ptr [7FF9CE76D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CE76D9C0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       r8,[rbp-18]
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       [rsp+20],r8
       mov       r8,1ED96002028
       mov       r8,1ED96002028
       mov       r8,[r8]
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       [rsp+28],r8
       mov       r8,1ED96008C38
       mov       r8,1ED96008C38
       mov       r8,[r8]
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       edx,1
       mov       r9d,7FFFFFFF
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9CEB2BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       call      qword ptr [7FF9CEB2BA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-1C],eax
       mov       [rbp-1C],eax
       mov       ecx,[rbp-1C]
       mov       ecx,[rbp-1C]
       mov       [rbp+18],ecx
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       mov       edx,[rbp+18]
       mov       edx,[rbp+18]
       call      qword ptr [7FF9CEE29AF8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       call      qword ptr [7FF9CEE29AF8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-28]
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 362
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7876D08],0
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE538
       mov       rdx,7FF9C7CEE538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,18143249F28
M01_L03:
       mov       r9,18143249F28
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,18143243020
       mov       r9,18143243020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,18143253778
       mov       r8,18143253778
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,18143243020
       mov       rdx,18143243020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEEA08
       mov       rdx,7FF9C7CEEA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7C0
       mov       rdx,7FF9C7CEE7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7E0
       mov       rdx,7FF9C7CEE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7F8
       mov       rdx,7FF9C7CEE7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77D31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77D31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0950
       mov       r11,7FF9C75C0950
       call      qword ptr [7FF9C75C0950]
       call      qword ptr [7FF9C75C0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0958
       mov       r11,7FF9C75C0958
       call      qword ptr [7FF9C75C0958]
       call      qword ptr [7FF9C75C0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE29BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE2B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE979F50],0
       cmp       dword ptr [7FF9CE979F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FAD8
       mov       rdx,7FF9CEE0FAD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,1FB1FC08F18
M01_L03:
       mov       r9,1FB1FC08F18
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,1FB1FC02028
       mov       r9,1FB1FC02028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB2BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB2BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,1FB29C00C10
       mov       r8,1FB29C00C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,1FB1FC02028
       mov       rdx,1FB1FC02028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE29C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE29C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE29AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE29AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FD38
       mov       rdx,7FF9CEE0FD38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FD38
       mov       rdx,7FF9CEE0FD38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FF80
       mov       rdx,7FF9CEE0FF80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE28CA8
       mov       r8,7FF9CEE28CA8
       call      qword ptr [7FF9CE6CB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6CB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FD38
       mov       rdx,7FF9CEE0FD38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FD60
       mov       rdx,7FF9CEE0FD60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEA87CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEA87CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FD80
       mov       rdx,7FF9CEE0FD80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FD98
       mov       rdx,7FF9CEE0FD98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE29B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE29B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7D85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE7D85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5208C0
       mov       r11,7FF9CE5208C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5208C8
       mov       r11,7FF9CE5208C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7876D08],0
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE538
       mov       rdx,7FF9C7CEE538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,21269F21330
M01_L03:
       mov       r9,21269F21330
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,21289F23020
       mov       r9,21289F23020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,212B9F21BD0
       mov       r8,212B9F21BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,21289F23020
       mov       rdx,21289F23020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEEA08
       mov       rdx,7FF9C7CEEA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7C0
       mov       rdx,7FF9C7CEE7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7E0
       mov       rdx,7FF9C7CEE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7F8
       mov       rdx,7FF9C7CEE7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77D31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77D31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0950
       mov       r11,7FF9C75C0950
       call      qword ptr [7FF9C75C0950]
       call      qword ptr [7FF9C75C0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0958
       mov       r11,7FF9C75C0958
       call      qword ptr [7FF9C75C0958]
       call      qword ptr [7FF9C75C0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE5BBB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE5D4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE9A9F50],0
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3EA58
       mov       rdx,7FF9CEE3EA58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,2BEE7800320
M01_L03:
       mov       r9,2BEE7800320
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,2BEEB802028
       mov       r9,2BEEB802028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,2BEFB800C10
       mov       r8,2BEFB800C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,2BEEB802028
       mov       rdx,2BEEB802028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE5BC18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE5BC18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE5BAE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE5BAE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3ECB8
       mov       rdx,7FF9CEE3ECB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3ECB8
       mov       rdx,7FF9CEE3ECB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3EF00
       mov       rdx,7FF9CEE3EF00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE5ACA8
       mov       r8,7FF9CEE5ACA8
       call      qword ptr [7FF9CE6FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3ECB8
       mov       rdx,7FF9CEE3ECB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3ECE0
       mov       rdx,7FF9CEE3ECE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEAB7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEAB7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3ED00
       mov       rdx,7FF9CEE3ED00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3ED18
       mov       rdx,7FF9CEE3ED18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE5BB40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE5BB40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE8085B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE8085B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5508C0
       mov       r11,7FF9CE5508C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5508C8
       mov       r11,7FF9CE5508C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7866D08],0
       cmp       dword ptr [7FF9C7866D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CDE538
       mov       rdx,7FF9C7CDE538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,1862B1D9F28
M01_L03:
       mov       r9,1862B1D9F28
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,1862B1D3020
       mov       r9,1862B1D3020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,1868B1D1BD0
       mov       r8,1868B1D1BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,1862B1D3020
       mov       rdx,1862B1D3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CDE798
       mov       rdx,7FF9C7CDE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CDE798
       mov       rdx,7FF9C7CDE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CDEA08
       mov       rdx,7FF9C7CDEA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CDE798
       mov       rdx,7FF9C7CDE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CDE7C0
       mov       rdx,7FF9C7CDE7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CDE7E0
       mov       rdx,7FF9C7CDE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CDE7F8
       mov       rdx,7FF9C7CDE7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77C31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77C31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75B0950
       mov       r11,7FF9C75B0950
       call      qword ptr [7FF9C75B0950]
       call      qword ptr [7FF9C75B0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75B0958
       mov       r11,7FF9C75B0958
       call      qword ptr [7FF9C75B0958]
       call      qword ptr [7FF9C75B0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE69BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE6B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE9B9F50],0
       cmp       dword ptr [7FF9CE9B9F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4F748
       mov       rdx,7FF9CEE4F748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,25992400320
M01_L03:
       mov       r9,25992400320
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,2598A402028
       mov       r9,2598A402028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB6BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB6BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,25990400C10
       mov       r8,25990400C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,2598A402028
       mov       rdx,2598A402028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE69C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE69C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE69AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE69AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4F9A8
       mov       rdx,7FF9CEE4F9A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4F9A8
       mov       rdx,7FF9CEE4F9A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4FBF0
       mov       rdx,7FF9CEE4FBF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE68CA8
       mov       r8,7FF9CEE68CA8
       call      qword ptr [7FF9CE70B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE70B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4F9A8
       mov       rdx,7FF9CEE4F9A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4F9D0
       mov       rdx,7FF9CEE4F9D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEAC7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEAC7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4F9F0
       mov       rdx,7FF9CEE4F9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4FA08
       mov       rdx,7FF9CEE4FA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE69B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE69B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE8185B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE8185B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5608C0
       mov       r11,7FF9CE5608C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5608C8
       mov       r11,7FF9CE5608C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE538
       mov       rdx,7FF9C7CFE538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,140BB889F28
M01_L03:
       mov       r9,140BB889F28
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,140BB883020
       mov       r9,140BB883020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,1411B881BD0
       mov       r8,1411B881BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,140BB883020
       mov       rdx,140BB883020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFEA08
       mov       rdx,7FF9C7CFEA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7C0
       mov       rdx,7FF9C7CFE7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7E0
       mov       rdx,7FF9C7CFE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7F8
       mov       rdx,7FF9C7CFE7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77E31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77E31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75D0950
       mov       r11,7FF9C75D0950
       call      qword ptr [7FF9C75D0950]
       call      qword ptr [7FF9C75D0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75D0958
       mov       r11,7FF9C75D0958
       call      qword ptr [7FF9C75D0958]
       call      qword ptr [7FF9C75D0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE39BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE3B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE989F50],0
       cmp       dword ptr [7FF9CE989F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1FBF8
       mov       rdx,7FF9CEE1FBF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,28B99400320
M01_L03:
       mov       r9,28B99400320
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,28B9D402028
       mov       r9,28B9D402028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB3BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB3BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,28BAB400C10
       mov       r8,28BAB400C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,28B9D402028
       mov       rdx,28B9D402028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE39C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE39C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE39AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE39AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1FE58
       mov       rdx,7FF9CEE1FE58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1FE58
       mov       rdx,7FF9CEE1FE58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1FFD8
       mov       rdx,7FF9CEE1FFD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE38CA8
       mov       r8,7FF9CEE38CA8
       call      qword ptr [7FF9CE6DB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6DB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1FE58
       mov       rdx,7FF9CEE1FE58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1FE80
       mov       rdx,7FF9CEE1FE80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEA97CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEA97CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1FEA0
       mov       rdx,7FF9CEE1FEA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1FEB8
       mov       rdx,7FF9CEE1FEB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE39B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE39B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7E85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE7E85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5308C0
       mov       r11,7FF9CE5308C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5308C8
       mov       r11,7FF9CE5308C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7876D08],0
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE538
       mov       rdx,7FF9C7CEE538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,20F2BFF9F28
M01_L03:
       mov       r9,20F2BFF9F28
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,20F2BFF3020
       mov       r9,20F2BFF3020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,20F1BFF1BD0
       mov       r8,20F1BFF1BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,20F2BFF3020
       mov       rdx,20F2BFF3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEEA08
       mov       rdx,7FF9C7CEEA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7C0
       mov       rdx,7FF9C7CEE7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7E0
       mov       rdx,7FF9C7CEE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7F8
       mov       rdx,7FF9C7CEE7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77D31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77D31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0950
       mov       r11,7FF9C75C0950
       call      qword ptr [7FF9C75C0950]
       call      qword ptr [7FF9C75C0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0958
       mov       r11,7FF9C75C0958
       call      qword ptr [7FF9C75C0958]
       call      qword ptr [7FF9C75C0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE298B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE2B210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE979F50],0
       cmp       dword ptr [7FF9CE979F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F628
       mov       rdx,7FF9CEE0F628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,1E32E408F18
M01_L03:
       mov       r9,1E32E408F18
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,1E32E402028
       mov       r9,1E32E402028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB2BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB2BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,1E32C400C10
       mov       r8,1E32C400C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,1E32E402028
       mov       rdx,1E32E402028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE29918]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE29918]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE297E0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE297E0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F888
       mov       rdx,7FF9CEE0F888
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F888
       mov       rdx,7FF9CEE0F888
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FAD0
       mov       rdx,7FF9CEE0FAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE289A8
       mov       r8,7FF9CEE289A8
       call      qword ptr [7FF9CE6CB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6CB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F888
       mov       rdx,7FF9CEE0F888
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F8B0
       mov       rdx,7FF9CEE0F8B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEA87CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEA87CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F8D0
       mov       rdx,7FF9CEE0F8D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F8E8
       mov       rdx,7FF9CEE0F8E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE29840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE29840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7D85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE7D85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5208C0
       mov       r11,7FF9CE5208C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5208C8
       mov       r11,7FF9CE5208C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE538
       mov       rdx,7FF9C7CFE538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,1E9C8BA1330
M01_L03:
       mov       r9,1E9C8BA1330
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,1E9D8BA3020
       mov       r9,1E9D8BA3020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,1EA38BA1BD0
       mov       r8,1EA38BA1BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,1E9D8BA3020
       mov       rdx,1E9D8BA3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFEA08
       mov       rdx,7FF9C7CFEA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7C0
       mov       rdx,7FF9C7CFE7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7E0
       mov       rdx,7FF9C7CFE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7F8
       mov       rdx,7FF9C7CFE7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77E31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77E31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75D0950
       mov       r11,7FF9C75D0950
       call      qword ptr [7FF9C75D0950]
       call      qword ptr [7FF9C75D0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75D0958
       mov       r11,7FF9C75D0958
       call      qword ptr [7FF9C75D0958]
       call      qword ptr [7FF9C75D0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE59BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE5B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE9A9F50],0
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F6F0
       mov       rdx,7FF9CEE3F6F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,294E5000320
M01_L03:
       mov       r9,294E5000320
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,294E9002028
       mov       r9,294E9002028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,294F1000C10
       mov       r8,294F1000C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,294E9002028
       mov       rdx,294E9002028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE59C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE59C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE59AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE59AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F950
       mov       rdx,7FF9CEE3F950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F950
       mov       rdx,7FF9CEE3F950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3FB98
       mov       rdx,7FF9CEE3FB98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE58CA8
       mov       r8,7FF9CEE58CA8
       call      qword ptr [7FF9CE6FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F950
       mov       rdx,7FF9CEE3F950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F978
       mov       rdx,7FF9CEE3F978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEAB7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEAB7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F998
       mov       rdx,7FF9CEE3F998
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F9B0
       mov       rdx,7FF9CEE3F9B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE59B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE59B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE8085B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE8085B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5508C0
       mov       r11,7FF9CE5508C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5508C8
       mov       r11,7FF9CE5508C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E538
       mov       rdx,7FF9C7D0E538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,14990641330
M01_L03:
       mov       r9,14990641330
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,149B0643020
       mov       r9,149B0643020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,14A10641BD0
       mov       r8,14A10641BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,149B0643020
       mov       rdx,149B0643020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0EA08
       mov       rdx,7FF9C7D0EA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7C0
       mov       rdx,7FF9C7D0E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7E0
       mov       rdx,7FF9C7D0E7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7F8
       mov       rdx,7FF9C7D0E7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77F31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77F31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75E0950
       mov       r11,7FF9C75E0950
       call      qword ptr [7FF9C75E0950]
       call      qword ptr [7FF9C75E0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75E0958
       mov       r11,7FF9C75E0958
       call      qword ptr [7FF9C75E0958]
       call      qword ptr [7FF9C75E0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE59BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE5B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE9A9F50],0
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F1A0
       mov       rdx,7FF9CEE3F1A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,20B12408F18
M01_L03:
       mov       r9,20B12408F18
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,20B12402028
       mov       r9,20B12402028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,20B24400C10
       mov       r8,20B24400C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,20B12402028
       mov       rdx,20B12402028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE59C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE59C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE59AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE59AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F400
       mov       rdx,7FF9CEE3F400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F400
       mov       rdx,7FF9CEE3F400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F648
       mov       rdx,7FF9CEE3F648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE58CA8
       mov       r8,7FF9CEE58CA8
       call      qword ptr [7FF9CE6FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F400
       mov       rdx,7FF9CEE3F400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F428
       mov       rdx,7FF9CEE3F428
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEAB7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEAB7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F448
       mov       rdx,7FF9CEE3F448
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F460
       mov       rdx,7FF9CEE3F460
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE59B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE59B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE8085B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE8085B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5508C0
       mov       r11,7FF9CE5508C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5508C8
       mov       r11,7FF9CE5508C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE538
       mov       rdx,7FF9C7CFE538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,1A14C869F28
M01_L03:
       mov       r9,1A14C869F28
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,1A14C863020
       mov       r9,1A14C863020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,1A1AC861BD0
       mov       r8,1A1AC861BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,1A14C863020
       mov       rdx,1A14C863020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFEA08
       mov       rdx,7FF9C7CFEA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7C0
       mov       rdx,7FF9C7CFE7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7E0
       mov       rdx,7FF9C7CFE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7F8
       mov       rdx,7FF9C7CFE7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77E31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77E31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75D0950
       mov       r11,7FF9C75D0950
       call      qword ptr [7FF9C75D0950]
       call      qword ptr [7FF9C75D0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75D0958
       mov       r11,7FF9C75D0958
       call      qword ptr [7FF9C75D0958]
       call      qword ptr [7FF9C75D0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE2B8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE2D210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE979F50],0
       cmp       dword ptr [7FF9CE979F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F800
       mov       rdx,7FF9CEE0F800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,20B5A800320
M01_L03:
       mov       r9,20B5A800320
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,20B5E802028
       mov       r9,20B5E802028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB2BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB2BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,20B70800C10
       mov       r8,20B70800C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,20B5E802028
       mov       rdx,20B5E802028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE2B918]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE2B918]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE2B7E0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE2B7E0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FA60
       mov       rdx,7FF9CEE0FA60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FA60
       mov       rdx,7FF9CEE0FA60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FCA8
       mov       rdx,7FF9CEE0FCA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE2A9A8
       mov       r8,7FF9CEE2A9A8
       call      qword ptr [7FF9CE6CB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6CB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FA60
       mov       rdx,7FF9CEE0FA60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FA88
       mov       rdx,7FF9CEE0FA88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEA87CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEA87CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FAA8
       mov       rdx,7FF9CEE0FAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FAC0
       mov       rdx,7FF9CEE0FAC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE2B840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE2B840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7D85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE7D85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5208C0
       mov       r11,7FF9CE5208C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5208C8
       mov       r11,7FF9CE5208C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7876D08],0
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE538
       mov       rdx,7FF9C7CEE538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,266A5671330
M01_L03:
       mov       r9,266A5671330
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,26675673020
       mov       r9,26675673020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,266D5671BD0
       mov       r8,266D5671BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,26675673020
       mov       rdx,26675673020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEEA08
       mov       rdx,7FF9C7CEEA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7C0
       mov       rdx,7FF9C7CEE7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7E0
       mov       rdx,7FF9C7CEE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7F8
       mov       rdx,7FF9C7CEE7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77D31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77D31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0950
       mov       r11,7FF9C75C0950
       call      qword ptr [7FF9C75C0950]
       call      qword ptr [7FF9C75C0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0958
       mov       r11,7FF9C75C0958
       call      qword ptr [7FF9C75C0958]
       call      qword ptr [7FF9C75C0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE398B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE3B210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE989F50],0
       cmp       dword ptr [7FF9CE989F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1F190
       mov       rdx,7FF9CEE1F190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,1C939400320
M01_L03:
       mov       r9,1C939400320
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,1C92F402028
       mov       r9,1C92F402028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB3BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB3BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,1C941400C10
       mov       r8,1C941400C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,1C92F402028
       mov       rdx,1C92F402028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE39918]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE39918]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE397E0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE397E0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1F3F0
       mov       rdx,7FF9CEE1F3F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1F3F0
       mov       rdx,7FF9CEE1F3F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1F638
       mov       rdx,7FF9CEE1F638
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE389A8
       mov       r8,7FF9CEE389A8
       call      qword ptr [7FF9CE6DB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6DB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1F3F0
       mov       rdx,7FF9CEE1F3F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1F418
       mov       rdx,7FF9CEE1F418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEA97CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEA97CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1F438
       mov       rdx,7FF9CEE1F438
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE1F450
       mov       rdx,7FF9CEE1F450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE39840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE39840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7E85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE7E85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5308C0
       mov       r11,7FF9CE5308C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5308C8
       mov       r11,7FF9CE5308C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E538
       mov       rdx,7FF9C7D0E538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,149B1D29F28
M01_L03:
       mov       r9,149B1D29F28
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,149B1D23020
       mov       r9,149B1D23020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,14A11D21BD0
       mov       r8,14A11D21BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,149B1D23020
       mov       rdx,149B1D23020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0EA08
       mov       rdx,7FF9C7D0EA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7C0
       mov       rdx,7FF9C7D0E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7E0
       mov       rdx,7FF9C7D0E7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7F8
       mov       rdx,7FF9C7D0E7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77F31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77F31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75E0950
       mov       r11,7FF9C75E0950
       call      qword ptr [7FF9C75E0950]
       call      qword ptr [7FF9C75E0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75E0958
       mov       r11,7FF9C75E0958
       call      qword ptr [7FF9C75E0958]
       call      qword ptr [7FF9C75E0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE2BBB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE2D4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE979F50],0
       cmp       dword ptr [7FF9CE979F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F398
       mov       rdx,7FF9CEE0F398
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,1B69AC00320
M01_L03:
       mov       r9,1B69AC00320
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,1B69CC02028
       mov       r9,1B69CC02028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB2BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB2BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,1B69AC01C28
       mov       r8,1B69AC01C28
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,1B69CC02028
       mov       rdx,1B69CC02028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE2BC18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE2BC18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE2BAE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE2BAE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F5F8
       mov       rdx,7FF9CEE0F5F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F5F8
       mov       rdx,7FF9CEE0F5F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F840
       mov       rdx,7FF9CEE0F840
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE2ACA8
       mov       r8,7FF9CEE2ACA8
       call      qword ptr [7FF9CE6CB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6CB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F5F8
       mov       rdx,7FF9CEE0F5F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F620
       mov       rdx,7FF9CEE0F620
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEA87CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEA87CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F640
       mov       rdx,7FF9CEE0F640
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F658
       mov       rdx,7FF9CEE0F658
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE2BB40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE2BB40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7D85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE7D85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5208C0
       mov       r11,7FF9CE5208C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5208C8
       mov       r11,7FF9CE5208C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7876D08],0
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE538
       mov       rdx,7FF9C7CEE538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,2140D239F28
M01_L03:
       mov       r9,2140D239F28
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,2140D233020
       mov       r9,2140D233020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,2140D243778
       mov       r8,2140D243778
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,2140D233020
       mov       rdx,2140D233020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEEA08
       mov       rdx,7FF9C7CEEA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE798
       mov       rdx,7FF9C7CEE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7C0
       mov       rdx,7FF9C7CEE7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7E0
       mov       rdx,7FF9C7CEE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CEE7F8
       mov       rdx,7FF9C7CEE7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77D31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77D31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0950
       mov       r11,7FF9C75C0950
       call      qword ptr [7FF9C75C0950]
       call      qword ptr [7FF9C75C0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0958
       mov       r11,7FF9C75C0958
       call      qword ptr [7FF9C75C0958]
       call      qword ptr [7FF9C75C0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE29BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE2B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE979F50],0
       cmp       dword ptr [7FF9CE979F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F748
       mov       rdx,7FF9CEE0F748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,1EEED800320
M01_L03:
       mov       r9,1EEED800320
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,1EEF1802028
       mov       r9,1EEF1802028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB2BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB2BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,1EF01800C10
       mov       r8,1EF01800C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,1EEF1802028
       mov       rdx,1EEF1802028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE29C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE29C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE29AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE29AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F9A8
       mov       rdx,7FF9CEE0F9A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F9A8
       mov       rdx,7FF9CEE0F9A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FBF0
       mov       rdx,7FF9CEE0FBF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE28CA8
       mov       r8,7FF9CEE28CA8
       call      qword ptr [7FF9CE6CB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6CB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F9A8
       mov       rdx,7FF9CEE0F9A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F9D0
       mov       rdx,7FF9CEE0F9D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEA87CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEA87CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0F9F0
       mov       rdx,7FF9CEE0F9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE0FA08
       mov       rdx,7FF9CEE0FA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE29B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE29B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7D85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE7D85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5208C0
       mov       r11,7FF9CE5208C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5208C8
       mov       r11,7FF9CE5208C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E538
       mov       rdx,7FF9C7D0E538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,24473841330
M01_L03:
       mov       r9,24473841330
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,24483843020
       mov       r9,24483843020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,244E3841BD0
       mov       r8,244E3841BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,24483843020
       mov       rdx,24483843020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0EA08
       mov       rdx,7FF9C7D0EA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7C0
       mov       rdx,7FF9C7D0E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7E0
       mov       rdx,7FF9C7D0E7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7F8
       mov       rdx,7FF9C7D0E7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77F31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77F31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75E0950
       mov       r11,7FF9C75E0950
       call      qword ptr [7FF9C75E0950]
       call      qword ptr [7FF9C75E0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75E0958
       mov       r11,7FF9C75E0958
       call      qword ptr [7FF9C75E0958]
       call      qword ptr [7FF9C75E0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE598B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE5B210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE9A9F50],0
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F180
       mov       rdx,7FF9CEE3F180
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,19EBC000320
M01_L03:
       mov       r9,19EBC000320
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,19EBA002028
       mov       r9,19EBA002028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,19EBC001C28
       mov       r8,19EBC001C28
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,19EBA002028
       mov       rdx,19EBA002028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE59918]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE59918]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE597E0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE597E0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F3E0
       mov       rdx,7FF9CEE3F3E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F3E0
       mov       rdx,7FF9CEE3F3E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F628
       mov       rdx,7FF9CEE3F628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE589A8
       mov       r8,7FF9CEE589A8
       call      qword ptr [7FF9CE6FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F3E0
       mov       rdx,7FF9CEE3F3E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F408
       mov       rdx,7FF9CEE3F408
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEAB7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEAB7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F428
       mov       rdx,7FF9CEE3F428
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F440
       mov       rdx,7FF9CEE3F440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE59840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE59840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE8085B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE8085B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5508C0
       mov       r11,7FF9CE5508C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5508C8
       mov       r11,7FF9CE5508C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7886D08],0
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE538
       mov       rdx,7FF9C7CFE538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,1999CBA9F28
M01_L03:
       mov       r9,1999CBA9F28
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,1999CBA3020
       mov       r9,1999CBA3020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,19A0CBA1BD0
       mov       r8,19A0CBA1BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,1999CBA3020
       mov       rdx,1999CBA3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFEA08
       mov       rdx,7FF9C7CFEA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE798
       mov       rdx,7FF9C7CFE798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7C0
       mov       rdx,7FF9C7CFE7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7E0
       mov       rdx,7FF9C7CFE7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7CFE7F8
       mov       rdx,7FF9C7CFE7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77E31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77E31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75D0950
       mov       r11,7FF9C75D0950
       call      qword ptr [7FF9C75D0950]
       call      qword ptr [7FF9C75D0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75D0958
       mov       r11,7FF9C75D0958
       call      qword ptr [7FF9C75D0958]
       call      qword ptr [7FF9C75D0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE59BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE5B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE9A9F50],0
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F190
       mov       rdx,7FF9CEE3F190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,2E505C00320
M01_L03:
       mov       r9,2E505C00320
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,2E4F3C02028
       mov       r9,2E4F3C02028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,2E4F1C00C10
       mov       r8,2E4F1C00C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,2E4F3C02028
       mov       rdx,2E4F3C02028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE59C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE59C18]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE59AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE59AE0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F3F0
       mov       rdx,7FF9CEE3F3F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F3F0
       mov       rdx,7FF9CEE3F3F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F638
       mov       rdx,7FF9CEE3F638
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE58CA8
       mov       r8,7FF9CEE58CA8
       call      qword ptr [7FF9CE6FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F3F0
       mov       rdx,7FF9CEE3F3F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F418
       mov       rdx,7FF9CEE3F418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEAB7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEAB7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F438
       mov       rdx,7FF9CEE3F438
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE3F450
       mov       rdx,7FF9CEE3F450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE59B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE59B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE8085B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE8085B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5508C0
       mov       r11,7FF9CE5508C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5508C8
       mov       r11,7FF9CE5508C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7896D08],0
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E538
       mov       rdx,7FF9C7D0E538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,1C0DF849F28
M01_L03:
       mov       r9,1C0DF849F28
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,1C0DF843020
       mov       r9,1C0DF843020
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,1C0CF841BD0
       mov       r8,1C0CF841BD0
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,1C0DF843020
       mov       rdx,1C0DF843020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0EA08
       mov       rdx,7FF9C7D0EA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E798
       mov       rdx,7FF9C7D0E798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7C0
       mov       rdx,7FF9C7D0E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7E0
       mov       rdx,7FF9C7D0E7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7D0E7F8
       mov       rdx,7FF9C7D0E7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9C77F31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9C77F31C0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75E0950
       mov       r11,7FF9C75E0950
       call      qword ptr [7FF9C75E0950]
       call      qword ptr [7FF9C75E0950]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       jmp       short M01_L26
       jmp       short M01_L26
M01_L26:
       mov       rcx,rsp
M01_L26:
       mov       rcx,rsp
       call      M01_L28
       call      M01_L28
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       jmp       short M01_L27
       jmp       short M01_L27
M01_L27:
       mov       rax,[rbp-30]
M01_L27:
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L28:
       push      rbp
M01_L28:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L29
       je        short M01_L29
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75E0958
       mov       r11,7FF9C75E0958
       call      qword ptr [7FF9C75E0958]
       call      qword ptr [7FF9C75E0958]
       nop
       nop
M01_L29:
       nop
M01_L29:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2566
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF9CEE5B8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE5D210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      rbp
       sub       rsp,120
       sub       rsp,120
       lea       rbp,[rsp+120]
       lea       rbp,[rsp+120]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-0D8],rax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       add       rax,30
       jne       short M01_L00
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-10],rax
       mov       [rbp-0F8],rsp
       mov       [rbp-0F8],rsp
       mov       [rbp-8],rcx
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9CE999F50],0
       cmp       dword ptr [7FF9CE999F50],0
       je        short M01_L01
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4EB00
       mov       rdx,7FF9CEE4EB00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-38],rax
       mov       [rbp-38],rax
M01_L03:
       mov       r9,22530808F18
M01_L03:
       mov       r9,22530808F18
       mov       r9,[r9]
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+20],r9
       mov       r9,22530802028
       mov       r9,22530802028
       mov       r9,[r9]
       mov       r9,[r9]
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rdx,[rbp+18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       xor       r8d,r8d
       call      qword ptr [7FF9CEB4BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       call      qword ptr [7FF9CEB4BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-40],rax
       mov       [rbp-40],rax
       mov       r8,[rbp-40]
       mov       r8,[rbp-40]
       mov       [rbp+18],r8
       mov       [rbp+18],r8
       mov       r8,2253E800C10
       mov       r8,2253E800C10
       mov       r8,[r8]
       mov       r8,[r8]
       mov       rdx,22530802028
       mov       rdx,22530802028
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       call      qword ptr [7FF9CEE5B918]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       call      qword ptr [7FF9CEE5B918]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-44],eax
       mov       [rbp-44],eax
       mov       ecx,[rbp-44]
       mov       ecx,[rbp-44]
       mov       [rbp+20],ecx
       mov       [rbp+20],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       call      qword ptr [7FF9CEE5B7E0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      qword ptr [7FF9CEE5B7E0]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-50]
       mov       rcx,[rbp-50]
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       [rbp-58],rcx
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4ED60
       mov       rdx,7FF9CEE4ED60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-58],rax
       mov       [rbp-58],rax
M01_L05:
       mov       rcx,[rbp-58]
M01_L05:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       rcx,[rax+8]
       mov       [rbp-60],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-60]
       mov       rcx,[rbp-60]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
       cmp       qword ptr [rbp-60],0
       cmp       qword ptr [rbp-60],0
       jne       near ptr M01_L12
       jne       near ptr M01_L12
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L06
       je        short M01_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0C8],rcx
       mov       [rbp-0C8],rcx
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp+10]
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4ED60
       mov       rdx,7FF9CEE4ED60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0C8],rax
       mov       [rbp-0C8],rax
M01_L07:
       mov       rcx,[rbp-0C8]
M01_L07:
       mov       rcx,[rbp-0C8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax]
       mov       rcx,[rax]
       mov       [rbp-0D8],rcx
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+38],0
       cmp       qword ptr [rcx+38],0
       je        short M01_L08
       je        short M01_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+38]
       mov       rcx,[rcx+38]
       mov       [rbp-0E0],rcx
       mov       [rbp-0E0],rcx
       jmp       short M01_L09
       jmp       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4EFA8
       mov       rdx,7FF9CEE4EFA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E0],rax
       mov       [rbp-0E0],rax
M01_L09:
       mov       rcx,[rbp-0E0]
M01_L09:
       mov       rcx,[rbp-0E0]
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       rdx,[rbp-0D8]
       mov       rdx,[rbp-0D8]
       mov       r8,7FF9CEE5A9A8
       mov       r8,7FF9CEE5A9A8
       call      qword ptr [7FF9CE6EB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       call      qword ptr [7FF9CE6EB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+18],0
       cmp       qword ptr [rcx+18],0
       je        short M01_L10
       je        short M01_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+18]
       mov       [rbp-0E8],rcx
       mov       [rbp-0E8],rcx
       jmp       short M01_L11
       jmp       short M01_L11
M01_L10:
       mov       rcx,[rbp+10]
M01_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4ED60
       mov       rdx,7FF9CEE4ED60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0E8],rax
       mov       [rbp-0E8],rax
M01_L11:
       mov       rcx,[rbp-0E8]
M01_L11:
       mov       rcx,[rbp-0E8]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0D0]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D0]
       mov       rcx,[rbp-0D0]
       mov       [rbp-70],rcx
       mov       [rbp-70],rcx
M01_L12:
       mov       rcx,[rbp+10]
M01_L12:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+20],0
       cmp       qword ptr [rcx+20],0
       je        short M01_L13
       je        short M01_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       mov       rcx,[rcx+20]
       mov       [rbp-78],rcx
       mov       [rbp-78],rcx
       jmp       short M01_L14
       jmp       short M01_L14
M01_L13:
       mov       rcx,[rbp+10]
M01_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4ED88
       mov       rdx,7FF9CEE4ED88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-78],rax
       mov       [rbp-78],rax
M01_L14:
       mov       rcx,[rbp-78]
M01_L14:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-70]
       mov       r8,[rbp-70]
       call      qword ptr [7FF9CEAA7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      qword ptr [7FF9CEAA7CF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-80],rax
       mov       [rbp-80],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+28],0
       cmp       qword ptr [rcx+28],0
       je        short M01_L15
       je        short M01_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+28]
       mov       [rbp-88],rcx
       mov       [rbp-88],rcx
       jmp       short M01_L16
       jmp       short M01_L16
M01_L15:
       mov       rcx,[rbp+10]
M01_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4EDA8
       mov       rdx,7FF9CEE4EDA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-88],rax
       mov       [rbp-88],rax
M01_L16:
       mov       rcx,[rbp-88]
M01_L16:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       mov       rcx,[rbp-80]
       mov       r11,[rbp-90]
       mov       r11,[rbp-90]
       mov       rax,[rbp-90]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-98],rax
       mov       [rbp-98],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rbp-98]
       mov       [rbp-18],rcx
       mov       [rbp-18],rcx
       nop
       nop
       jmp       near ptr M01_L25
       jmp       near ptr M01_L25
M01_L17:
       mov       rcx,[rbp+10]
M01_L17:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+30],0
       cmp       qword ptr [rcx+30],0
       je        short M01_L18
       je        short M01_L18
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       [rbp-0A8],rcx
       mov       [rbp-0A8],rcx
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp+10]
M01_L18:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEE4EDC0
       mov       rdx,7FF9CEE4EDC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-0A8],rax
       mov       [rbp-0A8],rax
M01_L19:
       mov       rcx,[rbp-0A8]
M01_L19:
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,[rbp-0B0]
       mov       r11,[rbp-0B0]
       mov       rax,[rbp-0B0]
       mov       rax,[rbp-0B0]
       call      qword ptr [rax]
       call      qword ptr [rax]
       mov       [rbp-0B8],rax
       mov       [rbp-0B8],rax
       mov       rcx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       nop
       nop
       mov       ecx,[rbp+20]
       mov       ecx,[rbp+20]
       add       ecx,2
       add       ecx,2
       cmp       ecx,1
       cmp       ecx,1
       jbe       short M01_L20
       jbe       short M01_L20
       nop
       nop
       jmp       short M01_L21
       jmp       short M01_L21
M01_L20:
       mov       dword ptr [rbp-24],1
M01_L20:
       mov       dword ptr [rbp-24],1
       nop
       nop
       jmp       short M01_L22
       jmp       short M01_L22
M01_L21:
       xor       ecx,ecx
M01_L21:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       [rbp-24],ecx
M01_L22:
       mov       ecx,[rbp-24]
M01_L22:
       mov       ecx,[rbp-24]
       mov       [rbp-28],ecx
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       cmp       dword ptr [rbp-28],0
       je        short M01_L23
       je        short M01_L23
       nop
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEE5B840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      qword ptr [7FF9CEE5B840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       mov       [rbp-0BC],eax
       mov       [rbp-0BC],eax
       nop
       nop
       nop
       nop
       nop
       nop
       jmp       short M01_L24
       jmp       short M01_L24
M01_L23:
       nop
M01_L23:
       nop
       mov       rcx,[rbp-10]
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7F85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       call      qword ptr [7FF9CE7F85B0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       nop
       nop
M01_L24:
       nop
M01_L24:
       nop
M01_L25:
       mov       rcx,[rbp-18]
M01_L25:
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5408C0
       mov       r11,7FF9CE5408C0
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       [rbp-9C],eax
       cmp       dword ptr [rbp-9C],0
       cmp       dword ptr [rbp-9C],0
       jne       near ptr M01_L17
       jne       near ptr M01_L17
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M01_L26
       call      M01_L26
       nop
       nop
       mov       rax,[rbp-10]
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       nop
       nop
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       add       rsp,120
       add       rsp,120
       pop       rbp
       pop       rbp
       ret
       ret
M01_L26:
       push      rbp
M01_L26:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+120]
       lea       rbp,[rbp+120]
       cmp       qword ptr [rbp-18],0
       cmp       qword ptr [rbp-18],0
       je        short M01_L27
       je        short M01_L27
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE5408C8
       mov       r11,7FF9CE5408C8
       call      qword ptr [r11]
       call      qword ptr [r11]
       nop
       nop
M01_L27:
       nop
M01_L27:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2558
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

