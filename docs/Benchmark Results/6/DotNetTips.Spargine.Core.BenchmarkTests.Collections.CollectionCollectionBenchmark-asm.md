## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L06
M01_L02:
       test      edx,edx
       jne       near ptr M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       rcx,22E26C09BD0
       mov       rcx,[rcx]
       jmp       near ptr M01_L07
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 377
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFA97889888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA97889900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA975BB318]
       mov       rdi,rax
       mov       rcx,11894008BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA975BB450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA973E98E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA973E98E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA975B9C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975BB078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975BB510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9734FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA971D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975BB090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA975BB510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA97375750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA97257918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 340
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L06
M01_L02:
       test      edx,edx
       jne       near ptr M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       rcx,25A9D609BD0
       mov       rcx,[rcx]
       jmp       near ptr M01_L07
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 377
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFA96F17888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA96F17900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA96C4B318]
       mov       rdi,rax
       mov       rcx,27EEF008BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA96C4B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A798E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A798E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C49C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C4B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C4B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969DFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA96863510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C4B090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA96C4B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA96A05750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA968E7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 340
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L06
M01_L02:
       test      edx,edx
       jne       near ptr M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       rcx,222F8E77BD8
       mov       rcx,[rcx]
       jmp       near ptr M01_L07
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 377
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFA96F29B88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA96F29C00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA96C5B318]
       mov       rdi,rax
       mov       rcx,1FBD0C00808
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA96C5B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C59C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C5B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA96873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C5B090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA96A15750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA968F7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 340
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L06
M01_L02:
       test      edx,edx
       jne       near ptr M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       rcx,2736C8957C8
       mov       rcx,[rcx]
       jmp       near ptr M01_L07
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 377
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFA96F17888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA96F17900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA96C4B318]
       mov       rdi,rax
       mov       rcx,23097808BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA96C4B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A798E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A798E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C49C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C4B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C4B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969DFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA96863510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C4B090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA96C4B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA96A05750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA968E7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 340
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L06
M01_L02:
       test      edx,edx
       jne       near ptr M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       rcx,2C72B4117F0
       mov       rcx,[rcx]
       jmp       near ptr M01_L07
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 377
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFA97869B88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA97869C00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA9759B318]
       mov       rdi,rax
       mov       rcx,1CD0F800808
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA97355750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA97237918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 340
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L06
M01_L02:
       test      edx,edx
       jne       near ptr M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       rcx,1EE41B257C8
       mov       rcx,[rcx]
       jmp       near ptr M01_L07
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 377
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFA97877888]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA97877900]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA975AB318]
       mov       rdi,rax
       mov       rcx,2345C8067D8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA975AB450]
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
       call      qword ptr [7FFA975A9C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975AB078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9733FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975AB090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA97365750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA97247918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 340
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L06
M01_L02:
       test      edx,edx
       jne       near ptr M01_L06
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rdi,rax
       mov       rcx,2349DB79BD0
       mov       rcx,[rcx]
       jmp       near ptr M01_L07
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA989561A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L05:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L03
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 377
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFA97859B88]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA97859C00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,1
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA9758B318]
       mov       rdi,rax
       mov       rcx,16A4D008BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA9758B450]
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
       call      qword ptr [7FFA97589C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9758B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9758B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9758B090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA9758B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA97345750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA97227918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 340
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DADDE8
       mov       rdx,7FFA98DADDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBA0
       mov       rdx,7FFA98DADBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBC0
       mov       rdx,7FFA98DADBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986A0940
       mov       r11,7FFA986A0940
       call      qword ptr [7FFA986A0940]
       call      qword ptr [7FFA986A0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBD8
       mov       rdx,7FFA98DADBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986A0940
       mov       r11,7FFA986A0940
       call      qword ptr [7FFA986A0940]
       call      qword ptr [7FFA986A0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986A0948
       mov       r11,7FFA986A0948
       call      qword ptr [7FFA986A0948]
       call      qword ptr [7FFA986A0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,19530781BA0
       mov       rcx,19530781BA0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,194E0783090
       mov       rdx,194E0783090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,194E0783020
       mov       rdx,194E0783020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,19530781BA8
       mov       rax,19530781BA8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0948
       mov       r11,7FFA986A0948
       call      qword ptr [7FFA986A0948]
       call      qword ptr [7FFA986A0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA978698B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA9786B210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA9759B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,220C6C002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,220D6C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,220D6C02028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA97088D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA9759B198]
       mov       r15,rax
       mov       rcx,220C6C01C00
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9759B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA97355750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97237900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA9784E118
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA9784E118
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA9784E360
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA9784E118
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA9784E140
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA974D3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA9784E160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96F70A88
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA9784E178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97869840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97237A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96F70A88
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96F70A90
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA97351C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9759B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA9732FF90]
       int       3
M01_L32:
       call      qword ptr [7FFA9711B630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F70A90
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DADDE8
       mov       rdx,7FFA98DADDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBA0
       mov       rdx,7FFA98DADBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBC0
       mov       rdx,7FFA98DADBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986A0940
       mov       r11,7FFA986A0940
       call      qword ptr [7FFA986A0940]
       call      qword ptr [7FFA986A0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBD8
       mov       rdx,7FFA98DADBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986A0940
       mov       r11,7FFA986A0940
       call      qword ptr [7FFA986A0940]
       call      qword ptr [7FFA986A0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986A0948
       mov       r11,7FFA986A0948
       call      qword ptr [7FFA986A0948]
       call      qword ptr [7FFA986A0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,1FB7BBE1BA0
       mov       rcx,1FB7BBE1BA0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1FB3BBE3090
       mov       rdx,1FB3BBE3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1FB3BBE3020
       mov       rdx,1FB3BBE3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,1FB7BBE1BA8
       mov       rax,1FB7BBE1BA8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0948
       mov       r11,7FFA986A0948
       call      qword ptr [7FFA986A0948]
       call      qword ptr [7FFA986A0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA96F278B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA96F29210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA96C5B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1D3C40002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA968B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1D3BC002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA968B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,1D3BC002028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA96748D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA96C5B198]
       mov       r15,rax
       mov       rcx,1D3C6000BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA96C5B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C59C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C5B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA96873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C5B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA96A15750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA968F7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA96F0ED40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EB20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA96B93318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EB40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96630A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EB58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA96F27840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA968F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96630A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96630A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA96A11C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96A11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA96C5B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C59C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C5B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA96873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C5B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA969EFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96624000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA969EFF90]
       int       3
M01_L32:
       call      qword ptr [7FFA967DB630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96630A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDDE8
       mov       rdx,7FFA98DCDDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBA0
       mov       rdx,7FFA98DCDBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBC0
       mov       rdx,7FFA98DCDBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBD8
       mov       rdx,7FFA98DCDBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,20BFD541BA0
       mov       rcx,20BFD541BA0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,20B9D543090
       mov       rdx,20B9D543090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,20B9D543020
       mov       rdx,20B9D543020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,20BFD541BA8
       mov       rax,20BFD541BA8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA96F278B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA96F29210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA96C5B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,196C04002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA968B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,196BC402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA968B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,196BC402028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA96748D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA96C5B198]
       mov       r15,rax
       mov       rcx,196C6400BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA96C5B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C59C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C5B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA96873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C5B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA96A15750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA968F7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EBE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EBE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EE28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EBE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EC08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA96B93318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EC28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96630A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA96F0EC40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA96F27840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA968F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96630A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96630A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA96A11C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96A11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA96C5B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C59C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C5B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA96873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C5B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA969EFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96624000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA969EFF90]
       int       3
M01_L32:
       call      qword ptr [7FFA967DB630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96630A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDDE8
       mov       rdx,7FFA98DCDDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBA0
       mov       rdx,7FFA98DCDBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBC0
       mov       rdx,7FFA98DCDBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBD8
       mov       rdx,7FFA98DCDBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,21DD3221BA0
       mov       rcx,21DD3221BA0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,21D63223090
       mov       rdx,21D63223090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,21D63223020
       mov       rdx,21D63223020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,21DD3221BA8
       mov       rax,21DD3221BA8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA96F3B8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA96F3D210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA96C5B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,196C50002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA968B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,196C1002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA968B99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,196C1002028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA96748D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA96C5B198]
       mov       r15,rax
       mov       rcx,196C1004FF0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA96C5B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C59C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C5B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA96873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C5B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA96A15750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA968F7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA96F2C298
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA96F2C298
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA96F2C4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA96F2C298
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA96F2C2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA96B93318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA96F2C2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96630A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA96F2C2F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA96F3B840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA968F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96630A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96630A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA96A11C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96A11C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA96C5B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A898E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C59C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C5B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C5B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA96873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C5B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA969EFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96624000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA969EFF90]
       int       3
M01_L32:
       call      qword ptr [7FFA967DB630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96630A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DB78
       mov       rdx,7FFA98D9DB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DB78
       mov       rdx,7FFA98D9DB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DDE8
       mov       rdx,7FFA98D9DDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DB78
       mov       rdx,7FFA98D9DB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DBA0
       mov       rdx,7FFA98D9DBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DBC0
       mov       rdx,7FFA98D9DBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA98690940
       mov       r11,7FFA98690940
       call      qword ptr [7FFA98690940]
       call      qword ptr [7FFA98690940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DBD8
       mov       rdx,7FFA98D9DBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA98690940
       mov       r11,7FFA98690940
       call      qword ptr [7FFA98690940]
       call      qword ptr [7FFA98690940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA98690948
       mov       r11,7FFA98690948
       call      qword ptr [7FFA98690948]
       call      qword ptr [7FFA98690948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,165043E1BA0
       mov       rcx,165043E1BA0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,164A43E3090
       mov       rdx,164A43E3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,164A43E3020
       mov       rdx,164A43E3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,165043E1BA8
       mov       rax,165043E1BA8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA98690948
       mov       r11,7FFA98690948
       call      qword ptr [7FFA98690948]
       call      qword ptr [7FFA98690948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA97847BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978494B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA9757B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,15000008EF0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,15000002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,15000002028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA97068D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA9757B198]
       mov       r15,rax
       mov       rcx,15012000BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA9757B450]
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
       call      qword ptr [7FFA97579C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9757B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9757B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9730FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA97193510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9757B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA9757B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA97335750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97217900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA9782F198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA9782F198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA9782F3E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA9782F198
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA9782F1C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA974B3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA9782F1E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96F50A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA9782F1F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97847B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97217A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96F50A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96F50A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA97331C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97331C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA9757B450]
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
       call      qword ptr [7FFA97579C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9757B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9757B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9730FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA97193510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9757B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9730FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA9730FF90]
       int       3
M01_L32:
       call      qword ptr [7FFA970FB630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F50A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDDE8
       mov       rdx,7FFA98DCDDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBA0
       mov       rdx,7FFA98DCDBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBC0
       mov       rdx,7FFA98DCDBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBD8
       mov       rdx,7FFA98DCDBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,2239A0B9B38
       mov       rcx,2239A0B9B38
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,2235A0B3090
       mov       rdx,2235A0B3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,2235A0B3020
       mov       rdx,2235A0B3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,2239A0B9B40
       mov       rax,2239A0B9B40
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA97869BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA9786B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA9759B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1C90AC08EF0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1C90AC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,1C90AC02028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA97088D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA9759B198]
       mov       r15,rax
       mov       rcx,1C914C00BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9759B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA97355750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97237900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA9784F148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA9784F148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA9784F390
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA9784F148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA9784F170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA974D3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA9784F190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96F70A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA9784F1A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97869B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97237A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96F70A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96F70A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA97351C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9759B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA9732FF90]
       int       3
M01_L32:
       call      qword ptr [7FFA9711B630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F70A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDDE8
       mov       rdx,7FFA98DCDDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBA0
       mov       rdx,7FFA98DCDBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBC0
       mov       rdx,7FFA98DCDBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBD8
       mov       rdx,7FFA98DCDBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,21F0A84DF40
       mov       rcx,21F0A84DF40
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,21F0A843090
       mov       rdx,21F0A843090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,21F0A843020
       mov       rdx,21F0A843020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,21F0A84DF48
       mov       rax,21F0A84DF48
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA978678B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA97869210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA9759B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,219D8400B10
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,219D4402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,219D4402028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA97088D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA9759B198]
       mov       r15,rax
       mov       rcx,219DC40AB78
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9759B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA97355750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97237900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA9784EFC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA9784EFC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA9784F208
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA9784EFC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA9784EFE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA974D3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA9784F008
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96F70A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA9784F020
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97867840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97237A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96F70A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96F70A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA97351C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9759B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA9732FF90]
       int       3
M01_L32:
       call      qword ptr [7FFA9711B630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F70A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDDE8
       mov       rdx,7FFA98DCDDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBA0
       mov       rdx,7FFA98DCDBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBC0
       mov       rdx,7FFA98DCDBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBD8
       mov       rdx,7FFA98DCDBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,238D7B39B38
       mov       rcx,238D7B39B38
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,238F7B33090
       mov       rdx,238F7B33090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,238F7B33020
       mov       rdx,238F7B33020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,238D7B39B40
       mov       rax,238D7B39B40
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA978598B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA9785B210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA9758B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1B93AC08EF0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1B93AC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,1B93AC02028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA97078D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA9758B198]
       mov       r15,rax
       mov       rcx,1B93AC12790
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA9758B450]
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
       call      qword ptr [7FFA97589C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9758B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9758B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9758B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA9758B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA97345750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97227900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA9783E118
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA9783E118
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA9783E360
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA9783E118
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA9783E140
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA974C3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA9783E160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96F60A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA9783E178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97859840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97227A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96F60A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96F60A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA97341C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97341C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA9758B450]
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
       call      qword ptr [7FFA97589C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9758B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9758B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9758B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA9731FF90]
       int       3
M01_L32:
       call      qword ptr [7FFA9710B630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F60A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDB78
       mov       rdx,7FFA98DDDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDB78
       mov       rdx,7FFA98DDDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDDE8
       mov       rdx,7FFA98DDDDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDB78
       mov       rdx,7FFA98DDDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDBA0
       mov       rdx,7FFA98DDDBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDBC0
       mov       rdx,7FFA98DDDBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986D0940
       mov       r11,7FFA986D0940
       call      qword ptr [7FFA986D0940]
       call      qword ptr [7FFA986D0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDBD8
       mov       rdx,7FFA98DDDBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986D0940
       mov       r11,7FFA986D0940
       call      qword ptr [7FFA986D0940]
       call      qword ptr [7FFA986D0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986D0948
       mov       r11,7FFA986D0948
       call      qword ptr [7FFA986D0948]
       call      qword ptr [7FFA986D0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,1CE88801BA0
       mov       rcx,1CE88801BA0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1CE28803090
       mov       rdx,1CE28803090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1CE28803020
       mov       rdx,1CE28803020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,1CE88801BA8
       mov       rax,1CE88801BA8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986D0948
       mov       r11,7FFA986D0948
       call      qword ptr [7FFA986D0948]
       call      qword ptr [7FFA986D0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA96EF7BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA96EF94B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA96C2B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,21BE0C002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA968899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,21BDEC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA968899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,21BDEC02028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA96718D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA96C2B198]
       mov       r15,rax
       mov       rcx,21BEEC00BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA96C2B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A598E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A598E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C29C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C2B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C2B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA96843510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C2B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA96C2B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA969E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA968C7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA96EDEFA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA96EDEFA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA96EDF1E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA96EDEFA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA96EDEFC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA96B63318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA96EDEFE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96600A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA96EDF000
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA96EF7B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA968C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96600A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96600A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA969E1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA969E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA96C2B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A598E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A598E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C29C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C2B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C2B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA96843510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C2B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA969BFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA965F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA969BFF90]
       int       3
M01_L32:
       call      qword ptr [7FFA967AB630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96600A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDB78
       mov       rdx,7FFA98DDDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDB78
       mov       rdx,7FFA98DDDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDDE8
       mov       rdx,7FFA98DDDDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDB78
       mov       rdx,7FFA98DDDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDBA0
       mov       rdx,7FFA98DDDBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDBC0
       mov       rdx,7FFA98DDDBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986D0940
       mov       r11,7FFA986D0940
       call      qword ptr [7FFA986D0940]
       call      qword ptr [7FFA986D0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DDDBD8
       mov       rdx,7FFA98DDDBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986D0940
       mov       r11,7FFA986D0940
       call      qword ptr [7FFA986D0940]
       call      qword ptr [7FFA986D0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986D0948
       mov       r11,7FFA986D0948
       call      qword ptr [7FFA986D0948]
       call      qword ptr [7FFA986D0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,147CDDC1BA0
       mov       rcx,147CDDC1BA0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1476DDC3090
       mov       rdx,1476DDC3090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1476DDC3020
       mov       rdx,1476DDC3020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,147CDDC1BA8
       mov       rax,147CDDC1BA8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989761A8
       mov       rdx,7FFA989761A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986D0948
       mov       r11,7FFA986D0948
       call      qword ptr [7FFA986D0948]
       call      qword ptr [7FFA986D0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA96F09BB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA96F0B4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA96C3B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,279288002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA968999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,27926802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA968999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,27926802028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA96728D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA96C3B198]
       mov       r15,rax
       mov       rcx,27928801C00
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA96C3B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A698E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A698E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C39C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C3B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C3B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA96853510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C3B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA96C3B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA969F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA968D7900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA96EEF178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA96EEF178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA96EEF3C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA96EEF178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA96EEF1A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA96B73318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA96EEF1C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96610A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA96EEF1D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA96F09B40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA968D7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96610A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96610A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA969F1C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA969F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA96C3B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A698E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A698E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C39C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C3B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C3B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA96853510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C3B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA969CFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96604000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA969CFF90]
       int       3
M01_L32:
       call      qword ptr [7FFA967BB630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96610A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DADDE8
       mov       rdx,7FFA98DADDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBA0
       mov       rdx,7FFA98DADBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBC0
       mov       rdx,7FFA98DADBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986A0940
       mov       r11,7FFA986A0940
       call      qword ptr [7FFA986A0940]
       call      qword ptr [7FFA986A0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBD8
       mov       rdx,7FFA98DADBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986A0940
       mov       r11,7FFA986A0940
       call      qword ptr [7FFA986A0940]
       call      qword ptr [7FFA986A0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986A0948
       mov       r11,7FFA986A0948
       call      qword ptr [7FFA986A0948]
       call      qword ptr [7FFA986A0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,1DF09601BA0
       mov       rcx,1DF09601BA0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1DE99603090
       mov       rdx,1DE99603090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1DE99603020
       mov       rdx,1DE99603020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,1DF09601BA8
       mov       rax,1DF09601BA8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0948
       mov       r11,7FFA986A0948
       call      qword ptr [7FFA986A0948]
       call      qword ptr [7FFA986A0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA96F398B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA96F3B210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA96C6B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1DEAEC08EF0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA968C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1DEAEC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA968C99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,1DEAEC02028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA96758D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA96C6B198]
       mov       r15,rax
       mov       rcx,1DEB8C00BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA96C6B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A998E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A998E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C69C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C6B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C6B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA96883510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C6B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA96C6B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA96A25750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA96907900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA96F1E0A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA96F1E0A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA96F1E2F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA96F1E0A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA96F1E0D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA96BA3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA96F1E0F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96640A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA96F1E108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA96F39840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA96907A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96640A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96640A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA96A21C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96A21C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA96C6B450]
       mov       rsi,rax
       mov       ecx,32C
       mov       rdx,7FFA96A998E0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFA96A998E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA96C69C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA96C6B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA96C6B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA969FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA96883510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA96C6B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA969FFF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96634000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA969FFF90]
       int       3
M01_L32:
       call      qword ptr [7FFA967EB630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96640A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DADDE8
       mov       rdx,7FFA98DADDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DADB78
       mov       rdx,7FFA98DADB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBA0
       mov       rdx,7FFA98DADBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBC0
       mov       rdx,7FFA98DADBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986A0940
       mov       r11,7FFA986A0940
       call      qword ptr [7FFA986A0940]
       call      qword ptr [7FFA986A0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DADBD8
       mov       rdx,7FFA98DADBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986A0940
       mov       r11,7FFA986A0940
       call      qword ptr [7FFA986A0940]
       call      qword ptr [7FFA986A0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986A0948
       mov       r11,7FFA986A0948
       call      qword ptr [7FFA986A0948]
       call      qword ptr [7FFA986A0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,1C082821BA0
       mov       rcx,1C082821BA0
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,1C022823090
       mov       rdx,1C022823090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,1C022823020
       mov       rdx,1C022823020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,1C082821BA8
       mov       rax,1C082821BA8
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989461A8
       mov       rdx,7FFA989461A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986A0948
       mov       r11,7FFA986A0948
       call      qword ptr [7FFA986A0948]
       call      qword ptr [7FFA986A0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA9787BBB8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA9787D4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA9759B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,250BE0002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,250B2002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,250B2002028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA97088D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA9759B198]
       mov       r15,rax
       mov       rcx,250AE00D370
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9759B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA97355750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97237900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA9786C288
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA9786C288
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA9786C4D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA9786C288
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA9786C2B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA974D3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA9786C2D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96F70A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA9786C2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA9787BB40]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97237A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96F70A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96F70A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA97351C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9759B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA9732FF90]
       int       3
M01_L32:
       call      qword ptr [7FFA9711B630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F70A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DB78
       mov       rdx,7FFA98D9DB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DB78
       mov       rdx,7FFA98D9DB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DDE8
       mov       rdx,7FFA98D9DDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DB78
       mov       rdx,7FFA98D9DB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DBA0
       mov       rdx,7FFA98D9DBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DBC0
       mov       rdx,7FFA98D9DBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA98690940
       mov       r11,7FFA98690940
       call      qword ptr [7FFA98690940]
       call      qword ptr [7FFA98690940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98D9DBD8
       mov       rdx,7FFA98D9DBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA98690940
       mov       r11,7FFA98690940
       call      qword ptr [7FFA98690940]
       call      qword ptr [7FFA98690940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA98690948
       mov       r11,7FFA98690948
       call      qword ptr [7FFA98690948]
       call      qword ptr [7FFA98690948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,19087193748
       mov       rcx,19087193748
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,19087183090
       mov       rdx,19087183090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,19087183020
       mov       rdx,19087183020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,19087193750
       mov       rax,19087193750
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989361A8
       mov       rdx,7FFA989361A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA98690948
       mov       r11,7FFA98690948
       call      qword ptr [7FFA98690948]
       call      qword ptr [7FFA98690948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA978778B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA97879210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA975AB330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,1D40A0002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,1D408002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,1D408002028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA97098D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA975AB198]
       mov       r15,rax
       mov       rcx,1D414000BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA975AB450]
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
       call      qword ptr [7FFA975A9C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975AB078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9733FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975AB090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA97365750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97247900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA9785E580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA9785E580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA9785E7C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA9785E580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA9785E5A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA974E3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA9785E5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96F80A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA9785E5E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97877840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97247A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96F80A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96F80A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA97361C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97361C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA975AB450]
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
       call      qword ptr [7FFA975A9C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA975AB078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA975AB510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9733FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA975AB078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9733FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA9733FF90]
       int       3
M01_L32:
       call      qword ptr [7FFA9712B630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F80A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,48
       sub       rsp,48
       lea       rbp,[rsp+80]
       lea       rbp,[rsp+80]
       mov       [rbp-58],rsp
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rbx,rdx
       mov       esi,r8d
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       r14,[rcx+8]
       test      rbx,rbx
       test      rbx,rbx
       setne     cl
       setne     cl
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        near ptr M01_L21
       je        near ptr M01_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       rcx,rax
       mov       [r15+8],esi
       mov       [r15+8],esi
       mov       rdx,r15
       mov       rdx,r15
       call      System.Enum.IsDefined(System.Type, System.Object)
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L25
       je        near ptr M01_L25
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r15,rax
       mov       rcx,r15
       mov       rcx,r15
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L00
       je        short M01_L00
       jmp       short M01_L01
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       mov       r12,[rax+8]
       test      r12,r12
       test      r12,r12
       jne       near ptr M01_L08
       jne       near ptr M01_L08
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L02
       je        short M01_L02
       jmp       short M01_L03
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       r12,[rax]
       mov       rcx,[r14+38]
       mov       rcx,[r14+38]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L04
       je        short M01_L04
       jmp       short M01_L05
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDDE8
       mov       rdx,7FFA98DCDDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r13,rax
       test      r12,r12
       test      r12,r12
       je        near ptr M01_L29
       je        near ptr M01_L29
       lea       rcx,[r13+8]
       lea       rcx,[r13+8]
       mov       rdx,r12
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       mov       rcx,[r14+18]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L06
       je        short M01_L06
       jmp       short M01_L07
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDB78
       mov       rdx,7FFA98DCDB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       lea       rcx,[rax+8]
       mov       rdx,r13
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
       mov       r12,r13
M01_L08:
       mov       rcx,[r14+20]
M01_L08:
       mov       rcx,[r14+20]
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L09
       je        short M01_L09
       jmp       short M01_L10
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBA0
       mov       rdx,7FFA98DCDBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       rbx,rax
       mov       r11,[r14+28]
       mov       r11,[r14+28]
       test      r11,r11
       test      r11,r11
       je        short M01_L11
       je        short M01_L11
       jmp       short M01_L12
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBC0
       mov       rdx,7FFA98DCDBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       mov       rbx,rax
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       je        near ptr M01_L20
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r14+30]
M01_L13:
       mov       r11,[r14+30]
       test      r11,r11
       test      r11,r11
       je        short M01_L14
       je        short M01_L14
       jmp       short M01_L15
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFA98DCDBD8
       mov       rdx,7FFA98DCDBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r11,rax
M01_L15:
       mov       rcx,rbx
M01_L15:
       mov       rcx,rbx
       call      qword ptr [r11]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
       jne       short M01_L17
M01_L16:
       mov       rcx,r15
M01_L16:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       call      DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r15+14]
M01_L17:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       cmp       [rcx+8],edx
       jbe       short M01_L18
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       [r15+10],r8d
       mov       r8,rax
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
       jmp       short M01_L19
M01_L18:
       mov       rcx,r15
M01_L18:
       mov       rcx,r15
       mov       rdx,rax
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,rbx
M01_L19:
       mov       rcx,rbx
       mov       r11,7FFA986C0940
       mov       r11,7FFA986C0940
       call      qword ptr [7FFA986C0940]
       call      qword ptr [7FFA986C0940]
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L13
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,rbx
M01_L20:
       mov       rcx,rbx
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
       mov       rax,r15
       mov       rax,r15
       add       rsp,48
       add       rsp,48
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
M01_L21:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rcx,2DDD182E758
       mov       rcx,2DDD182E758
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,2DDD1823090
       mov       rdx,2DDD1823090
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       mov       rdx,2DDD1823020
       mov       rdx,2DDD1823020
       mov       rdx,[rdx]
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rcx,rax
       test      rcx,rcx
       test      rcx,rcx
       je        short M01_L22
       je        short M01_L22
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L22
       je        short M01_L22
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L23
       jmp       short M01_L23
M01_L22:
       mov       eax,1
M01_L22:
       mov       eax,1
M01_L23:
       test      eax,eax
M01_L23:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L24
       jne       near ptr M01_L24
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       rcx,rsi
       mov       r9,rdi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rbx
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       [rcx],ecx
M01_L24:
       cmp       [rcx],ecx
       mov       edx,3
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rsi
       mov       rdx,rsi
       mov       rcx,rdi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
M01_L25:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       rsi,rax
       mov       rax,2DDD182E760
       mov       rax,2DDD182E760
       mov       rcx,[rax]
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       cmp       dword ptr [rcx+8],0
       je        short M01_L26
       je        short M01_L26
       xor       eax,eax
       xor       eax,eax
       jmp       short M01_L27
       jmp       short M01_L27
M01_L26:
       mov       eax,1
M01_L26:
       mov       eax,1
M01_L27:
       test      eax,eax
M01_L27:
       test      eax,eax
       sete      al
       sete      al
       movzx     eax,al
       movzx     eax,al
       test      eax,eax
       test      eax,eax
       jne       near ptr M01_L28
       jne       near ptr M01_L28
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       rsi,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       rdi,rax
       mov       ecx,9
       mov       ecx,9
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       rbx,rax
       mov       ecx,3AD
       mov       ecx,3AD
       mov       rdx,7FFA989661A8
       mov       rdx,7FFA989661A8
       call      CORINFO_HELP_STRCNS
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       rcx,rdi
       mov       r9,rbx
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       [rsp+20],rax
       mov       edx,1
       mov       edx,1
       xor       r8d,r8d
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L28:
       mov       edx,3
M01_L28:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentOutOfRange()
       mov       rdx,rax
       mov       rdx,rax
       mov       rcx,rsi
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       r8,rax
       mov       rdx,rdi
       mov       rdx,rdi
       mov       rcx,rbx
       mov       rcx,rbx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rbx
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       call      CORINFO_HELP_THROW
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
M01_L29:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       int       3
       push      rbp
       push      rbp
       push      r15
       push      r15
       push      r14
       push      r14
       push      r13
       push      r13
       push      r12
       push      r12
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rbx
       push      rbx
       sub       rsp,38
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-48],0
       cmp       qword ptr [rbp-48],0
       je        short M01_L30
       je        short M01_L30
       mov       rcx,[rbp-48]
       mov       rcx,[rbp-48]
       mov       r11,7FFA986C0948
       mov       r11,7FFA986C0948
       call      qword ptr [7FFA986C0948]
       call      qword ptr [7FFA986C0948]
M01_L30:
       nop
M01_L30:
       nop
       add       rsp,38
       add       rsp,38
       pop       rbx
       pop       rbx
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       r12
       pop       r12
       pop       r13
       pop       r13
       pop       r14
       pop       r14
       pop       r15
       pop       r15
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 2646
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFA9787B8B8]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], dotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Collections.Generic.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA9787D210]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp-58],rsp
       mov       [rbp-40],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rax,[rdi+30]
       mov       r14,[rax+8]
       test      rbx,rbx
       jne       near ptr M01_L03
       call      qword ptr [7FFA9759B330]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       dword ptr [r15+8],5
       jl        near ptr M01_L27
       lea       rcx,[r15+0C]
       mov       rdx,201A7C002F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L28
       lea       rcx,[r15+16]
       mov       rdx,201A1C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [r15+8],0
       je        short M01_L02
       mov       rcx,r15
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L29
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L29
M01_L02:
       mov       rcx,201A1C02028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr M01_L31
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [7FFA97088D00]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFA9759B198]
       mov       r15,rax
       mov       rcx,2019FC00BE8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9759B090]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA97355750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA97237900]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA9786C2A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L14
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FFA9786C2A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFA9786C4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L32
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__9_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFA9786C2A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L14:
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rdi
       mov       rdx,7FFA9786C2D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L16:
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [7FFA974D3318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       rdx,7FFA9786C2F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-48],rbx
       mov       rcx,rbx
       mov       r11,7FFA96F70A90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L26
M01_L19:
       mov       r11,[r14+30]
       test      r11,r11
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rdi
       mov       rdx,7FFA9786C308
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L21:
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L22
       cmp       esi,0FFFFFFFE
       jne       short M01_L23
M01_L22:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA9787B840]; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L25
M01_L23:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M01_L24
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       movsxd    rdx,edx
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L25
M01_L24:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFA97237A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L25:
       mov       rcx,rbx
       mov       r11,7FFA96F70A90
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L19
M01_L26:
       mov       rcx,rbx
       mov       r11,7FFA96F70A98
       call      qword ptr [r11]
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
M01_L27:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA97351C78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA97351C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L29:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L30
       call      qword ptr [7FFA9759B450]
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
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA9759B078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA9732FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,2E7
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA9732FF90]
       int       3
M01_L32:
       call      qword ptr [7FFA9711B630]
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
       cmp       qword ptr [rbp-48],0
       je        short M01_L33
       mov       rcx,[rbp-48]
       mov       r11,7FFA96F70A98
       call      qword ptr [r11]
M01_L33:
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
; Total bytes of code 1473
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

